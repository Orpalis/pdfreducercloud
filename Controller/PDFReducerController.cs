/**********************************************************************
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
using System.Reflection;
using System.Drawing;
using PassportPDF.Tools.Framework;
using PassportPDF.Tools.Framework.Models;
using PassportPDF.Tools.Framework.Utilities;
using PassportPDF.Tools.Framework.Business;
using PassportPDF.Tools.Framework.Configuration;
using PassportPDF.Tools.WinForm.Controllers;
using PassportPDF.Tools.WinForm.Models;
using PassportPDF.Tools.WinForm.Utilities;
using pdfReducerCloud.Utilities;
using pdfReducerCloud.Views;

namespace pdfReducerCloud.Controller
{
    internal sealed class PDFReducerController : PassportPDFAppControllerBase
    {
        public PDFReducerController(bool autoRun, string[] args) : base(
            new PassportPDFDesktopAppInformation(
                PdfReducerGlobals.PRODUCT_NAME, PdfReducerGlobals.PASSPORT_PDF_APP_ID,
                PdfReducerGlobals.APP_EXECUTABLE_NAME, PdfReducerGlobals.SOURCE_CODE_URL,
                AssemblyUtilities.GetVersion(), Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location),
                Properties.Resources.pdf_reducer_cloud_final_logo, PdfReducerGlobals.GetApplicationConfigurationFilePath(), autoRun, args))
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
                    PdfReducerGlobals.ReduceActionConfiguration = (PDFReduceActionConfiguration)ConfigurationManager.InitializeConfigurationInstanceEx(PdfReducerGlobals.GetReduceActionConfigurationFilePath(), typeof(PDFReduceActionConfiguration));
                }
                catch (Exception)
                {
                    DialogUtilities.ShowErrorMessage(FrameworkGlobals.MessagesLocalizer.GetString("readReduceConfigurationFailure", FrameworkGlobals.ApplicationLanguage), FrameworkGlobals.MessagesLocalizer.GetString("readConfigurationFailureTitle", FrameworkGlobals.ApplicationLanguage));
                    PdfReducerGlobals.ReduceActionConfiguration = ConfigurationManager.ResetDefaultPDFReduceActionConfiguration();
                }
            }
            else
            {
                PdfReducerGlobals.ReduceActionConfiguration = ConfigurationManager.ResetDefaultPDFReduceActionConfiguration();
                CommandLineParsingUtilities.ParseCommandLineArgs(_appInfo.CommandLineArguments, FrameworkGlobals.ApplicationConfiguration, PdfReducerGlobals.ReduceActionConfiguration);

                if (FrameworkGlobals.ApplicationConfiguration.MinimizedWindow)
                {
                    _view.Minimize();
                }
            }

            return true;
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
                ((IPDFReducerCloudMainView)_view).NotifyReductionRatioChange(100 - _operationsStats.ReductionRatio);
            }
        }


        protected override void OnOperationsCompletion()
        {
            base.OnOperationsCompletion();

            string elapsedTime = ParsingUtils.GetElapsedTimeString(_stopwatch.Elapsed);

            _view.NotifyOperationsResult(LogMessagesUtils.GetReductionWorkCompletionText(_operationsStats.ProcessedFileCount, _operationsStats.SuccesfullyProcessedFileCount, _operationsStats.UnsuccesfullyProcessedFileCount, _operationsStats.TotalInputSize, _operationsStats.TotalOutputSize, elapsedTime));

            string detailedWorkCompletionMessage = LogMessagesUtils.GetDetailedReductionWorkCompletionText(_operationsStats.ProcessedFileCount, _operationsStats.SuccesfullyProcessedFileCount, _operationsStats.UnsuccesfullyProcessedFileCount, _operationsStats.FileConvertedToPDFCount, _operationsStats.TotalInputSize, _operationsStats.TotalOutputSize, elapsedTime);

            if (!_appInfo.AutoRun)
            {
                DialogUtilities.ShowInformationMessage(detailedWorkCompletionMessage, FrameworkGlobals.MessagesLocalizer.GetString("processTerminated", FrameworkGlobals.ApplicationLanguage));
                _view.UnlockView();
            }
            else
            {
                Console.Write(detailedWorkCompletionMessage);
                _view.ExitApplication();
            }
        }


        protected override void HandleApplicationClosing()
        {
            base.HandleApplicationClosing();

            if (!_appInfo.AutoRun && (!ConfigurationManager.SaveConfiguration(PdfReducerGlobals.GetApplicationConfigurationFilePath(), FrameworkGlobals.ApplicationConfiguration) ||
                !ConfigurationManager.SaveConfiguration(PdfReducerGlobals.GetReduceActionConfigurationFilePath(), PdfReducerGlobals.ReduceActionConfiguration)))
            {
                DialogUtilities.ShowErrorMessage(FrameworkGlobals.MessagesLocalizer.GetString("saveConfigurationFailure", FrameworkGlobals.ApplicationLanguage), FrameworkGlobals.MessagesLocalizer.GetString("saveConfigurationFailureTitle", FrameworkGlobals.ApplicationLanguage));
            }
        }


        private void UpdateReductionStats(float inputSize, float outputSize, bool convertedToPdf)
        {
            if (!convertedToPdf)
            {
                _operationsStats.TotalInputSize += inputSize;
                _operationsStats.TotalOutputSize += outputSize;
                _operationsStats.ReductionRatio = StatsComputationUtilities.ComputeReductionRatio(_operationsStats.TotalInputSize, _operationsStats.TotalOutputSize);
            }
            else
            {
                _operationsStats.FileConvertedToPDFCount += 1;
            }
        }
    }
}
