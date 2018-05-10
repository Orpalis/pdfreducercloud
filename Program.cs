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
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Reflection;
using PassportPDF.Model;
using PassportPDF.Tools.Framework;
using PassportPDF.Tools.Framework.Utilities;
using PassportPDF.Tools.Framework.Configuration;
using PassportPDF.Tools.WinForm;
using PassportPDF.Tools.WinForm.Views;
using PassportPDF.Tools.WinForm.Controllers;
using PassportPDF.Tools.WinForm.Utilities;
using pdfReducerCloud.Views;
using pdfReducerCloud.Utilities;
using pdfReducerCloud.Controller;

namespace pdfReducerCloud
{
    internal static class Program
    {
        static Program()
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls11;
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            int argsCount = args.Length;
            bool autoRun;

            if (argsCount != 0)
            {
                FrameworkGlobals.ApplicationConfiguration = ConfigurationManager.ResetDefaultApplicationConfiguration();
                autoRun = true;
                FrameworkGlobals.ApplicationConfiguration.InputPath = "";
                FrameworkGlobals.ApplicationConfiguration.OutputPath = "";
            }
            else
            {
                autoRun = false;
            }

            Mutex mutex = null;
            bool owned = false;

            try
            {
                mutex = new Mutex(true, PdfReducerGlobals.PASSPORT_PDF_APP_ID, out owned);

                if (!owned)
                {
                    DialogUtilities.ShowErrorMessage(FrameworkGlobals.MessagesLocalizer.GetString("programInstanceAlreadyRunning", FrameworkGlobals.ApplicationLanguage), FrameworkGlobals.MessagesLocalizer.GetString("caption_stop", FrameworkGlobals.ApplicationLanguage));
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
            finally
            {
                if (mutex != null && owned)
                {
                    mutex.ReleaseMutex();
                }
            }

            IPassportPDFAppController controller = new PDFReducerController(autoRun, args);
            frmMain view = new frmMain();
            ((IPassportPDFAppMainView)view).SetController(controller);
            controller.SetView(view);

            Application.EnableVisualStyles();
            Application.Run(view);
        }
    }
}