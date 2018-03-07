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
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using PassportPDF.Model;
using PassportPDF.Tools.Framework;
using PassportPDF.Tools.Framework.Configuration;
using PassportPDF.Tools.Framework.Utilities;
using PassportPDF.Tools.Framework.Models;
using PassportPDF.Tools.WinForm.Views;
using pdfReducerCloud.Controller;
using pdfReducerCloud.Utilities;
using pdfReducerCloud.Models;

namespace pdfReducerCloud.Views
{
    internal partial class frmMain : frmMainBase, IPDFReducerCloudMainView
    {
        private delegate void UpdateRatioDelegate(double ratio);

        private readonly UpdateRatioDelegate _reductionRatioUpdateEventHandler;

        public frmMain() : base()
        {
            _reductionRatioUpdateEventHandler = UpdateReductionRatio;
            InitializeComponent();
            lbCompRatio.Visible = false;
            lbCompRatioPct.Visible = false;
        }

        protected override void LoadLabels()
        {
            base.LoadLabels();
            lbCompRatio.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_CompRatio", FrameworkGlobals.ApplicationLanguage);
        }


        protected override void LockView()
        {
            base.LockView();
            lbCompRatioPct.Text = "0%";
            lbCompRatio.Visible = true;
            lbCompRatioPct.Visible = true;

        }


        protected override void UnlockView()
        {
            base.UnlockView();
            lbCompRatio.Visible = false;
            lbCompRatioPct.Visible = false;
        }


        private void UpdateReductionRatio(double updatedRatio)
        {
            lbCompRatioPct.Text = Math.Round(updatedRatio, 2) + "%";
        }


        void IPDFReducerCloudMainView.NotifyReductionRatioChange(double ratio)
        {
            if (InvokeRequired)
            {
                Invoke(_reductionRatioUpdateEventHandler, ratio);
            }
            else
            {
                UpdateReductionRatio(ratio);
            }
        }
    }
}