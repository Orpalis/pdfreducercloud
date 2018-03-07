﻿/**********************************************************************
 * Project:                  pdfReducer.Cloud
 * Authors:                 - Evan Carrère.
 *                          - Loïc Carrère.
 *
 * (C) Copyright 2018, ORPALIS.
 ** Licensed under the Apache License, Version 2.0 (the "License");
 ** you may not use this file except in compliance with the License.
 ** You may obtain a copy of the License at
 ** http://www.apache.org/licenses/LICENSE-2.0
 ** Unless required by applicable law or agreed to in writing, software
 ** distributed under the License is distributed on an "AS IS" BASIS,
 ** WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 ** See the License for the specific language governing permissions and
 ** limitations under the License.
 *
 **********************************************************************/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using PassportPDF.Model;
using PassportPDF.Tools.Framework;
using PassportPDF.Tools.Framework.Models;
using PassportPDF.Tools.Framework.Utilities;
using PassportPDF.Tools.Framework.Business;
using PassportPDF.Tools.Framework.Configuration;
using PassportPDF.Tools.WinForm.Controllers;
using PassportPDF.Tools.WinForm.Models;
using pdfReducerCloud.Utilities;
using pdfReducerCloud.Models;
using pdfReducerCloud.Views;

namespace pdfReducerCloud.Controller
{
    internal sealed class PDFReducerController : PassportPDFAppControllerBase
    {
        private PDFReducerStats _stats;

        public PDFReducerController(bool autoRun, string[] args) : base(
            new PassportPDFDesktopAppInformation(PdfReducerGlobals.PRODUCT_NAME, PdfReducerGlobals.PASSPORT_PDF_APP_ID, 
                PdfReducerGlobals.APP_EXECUTABLE_NAME,AssemblyUtilities.GetVersion(),
                Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location), 
                global::pdfReducerCloud.Properties.Resources.pdf_reducer_cloud_final_logo,
                PdfReducerGlobals.GetApplicationConfigurationFilePath(), autoRun, args))
        { }


        protected override OperationsWorkflow GetOperationWorkflow()
        {
            return OperationsWorkflowUtilities.CreatePDFReductionWorkflow(PdfReducerGlobals.ReduceActionConfiguration);
        }


        protected override void OnOptionsFormOpeningRequested()
        {
            using (frmOptions frmOptions = new frmOptions())
            {
                frmOptions.LoadLabels();
                frmOptions.LoadConfiguration();
                frmOptions.ShowDialog(_view.WindowInstance);
            }
        }


        protected override void OnWorkerWorkCompletion(int workerNumber)
        {
            base.OnWorkerWorkCompletion(workerNumber);

            _view.RemoveWorker(workerNumber);

            if (_view.WorkerItemCount == 0)
            {
                _stopwatch.Stop();

                if (FrameworkGlobals.LogsManager.Error != null)
                {
                    _view.NotifyOperationError(LogMessagesUtils.ReplaceMessageSequencesAndReferences(FrameworkGlobals.MessagesLocalizer.GetString("message_logs_exportation_failure", FrameworkGlobals.ApplicationLanguage), additionalMessage: FrameworkGlobals.LogsManager.Error.Message));
                }

                string elapsedTime = ParsingUtils.GetElapsedTimeString(_stopwatch.Elapsed.Hours, _stopwatch.Elapsed.Minutes, _stopwatch.Elapsed.Seconds, _stopwatch.Elapsed.Milliseconds / 10);

                _view.NotifyOperationsResult(LogMessagesUtils.GetReductionWorkCompletionText(_operationsStats.ProcessedFileCount, _operationsStats.SuccesfullyProcessedFileCount, _operationsStats.UnsuccesfullyProcessedFileCount, _stats.TotalInputSize, _stats.TotalOutputSize, elapsedTime));

                string detailedWorkCompletionMessage = LogMessagesUtils.GetDetailedReductionWorkCompletionText(_operationsStats.ProcessedFileCount, _operationsStats.SuccesfullyProcessedFileCount, _operationsStats.UnsuccesfullyProcessedFileCount, _stats.TotalInputSize, _stats.TotalOutputSize, elapsedTime);

                if (!_appInfo.AutoRun)
                {
                    _view.PromptInformationMessage(detailedWorkCompletionMessage, FrameworkGlobals.MessagesLocalizer.GetString("processTerminated", FrameworkGlobals.ApplicationLanguage));
                    _view.UnlockView();
                }
                else
                {
                    Console.Write(detailedWorkCompletionMessage);
                    _view.ExitApplication();
                }
            }
        }


        protected override bool InitializeAppConfiguration()
        {
            if (!base.InitializeAppConfiguration())
            {
                return false;
            }

            if (!_appInfo.AutoRun)
            {
                try
                {
                    PdfReducerGlobals.ReduceActionConfiguration = (ReduceActionConfiguration)ConfigurationManager.InitializeConfigurationInstanceEx(PdfReducerGlobals.GetReduceActionConfigurationFilePath(), typeof(ReduceActionConfiguration));
                }
                catch (Exception)
                {
                    MessageBox.Show(FrameworkGlobals.MessagesLocalizer.GetString("readReduceConfigurationFailure", FrameworkGlobals.ApplicationLanguage), FrameworkGlobals.MessagesLocalizer.GetString("readConfigurationFailureTitle", FrameworkGlobals.ApplicationLanguage), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PdfReducerGlobals.ReduceActionConfiguration = ConfigurationManager.ResetDefaultReduceActionConfiguration();
                }
            }
            else
            {
                PdfReducerGlobals.ReduceActionConfiguration = ConfigurationManager.ResetDefaultReduceActionConfiguration();
                CommandLineParsingUtilities.ParseCommandLineArgs(_appInfo.CommandLineArguments, FrameworkGlobals.ApplicationConfiguration, PdfReducerGlobals.ReduceActionConfiguration);

                if (FrameworkGlobals.ApplicationConfiguration.MinimizedWindow)
                {
                    _view.Minimize();
                }
            }

            return true;
        }


        protected override void HandleApplicationClosing()
        {
            base.HandleApplicationClosing();

            if (!_appInfo.AutoRun && (!ConfigurationManager.SaveConfiguration(PdfReducerGlobals.GetApplicationConfigurationFilePath(), FrameworkGlobals.ApplicationConfiguration) ||
                !ConfigurationManager.SaveConfiguration(PdfReducerGlobals.GetReduceActionConfigurationFilePath(), PdfReducerGlobals.ReduceActionConfiguration)))
            {
                MessageBox.Show(FrameworkGlobals.MessagesLocalizer.GetString("saveConfigurationFailure", FrameworkGlobals.ApplicationLanguage), FrameworkGlobals.MessagesLocalizer.GetString("saveConfigurationFailureTitle", FrameworkGlobals.ApplicationLanguage), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void OnFileOperationsCompletion(FileOperationsResult fileOperationsResult)
        {
            base.OnFileOperationsCompletion(fileOperationsResult);

            UpdateReductionStats(fileOperationsResult.InputFileSize, fileOperationsResult.OutputFileSize, fileOperationsResult.ConvertedToPDF);

            string operationsCompletionMessage = LogMessagesUtils.GetFileReductionOperationsCompletionText(fileOperationsResult);
            if (FrameworkGlobals.ApplicationConfiguration.TimestampLogs)
            {
                operationsCompletionMessage = LogMessagesUtils.TimeStampLogMessage(operationsCompletionMessage);
            }

            _view.NotifyOperationCompletion(operationsCompletionMessage);
            if (!string.IsNullOrEmpty(FrameworkGlobals.ApplicationConfiguration.LogsPath) && FrameworkGlobals.ApplicationConfiguration.ExportLogs)
            {
                FrameworkGlobals.LogsManager.LogMessage(operationsCompletionMessage);
            }

            if (!fileOperationsResult.ConvertedToPDF)
            {
                ((IPDFReducerCloudMainView)_view).NotifyReductionRatioChange(100 - _stats.ReductionRatio);
            }
        }


        protected override void ResetStats()
        {
            base.ResetStats();

            _stats.TotalInputSize = 0;
            _stats.TotalOutputSize = 0;
            _stats.ReductionRatio = 0;
        }


        private void UpdateReductionStats(float inputSize, float outputSize, bool convertedToPDF)
        {
            if (!convertedToPDF)
            {
                _stats.TotalInputSize += inputSize;
                _stats.TotalOutputSize += outputSize;
                _stats.ReductionRatio = StatsComputationUtilities.ComputeReductionRatio(_stats.TotalInputSize, _stats.TotalOutputSize);
            }
        }
    }
}
