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
using System.Windows.Forms;
using PassportPDF.Model;
using PassportPDF.Tools.Framework;
using PassportPDF.Tools.Framework.Configuration;

namespace pdfReducerCloud.Views
{
    public partial class frmOptions : PassportPDF.Tools.WinForm.Views.frmOptionsBase
    {
        public frmOptions() : base(global::pdfReducerCloud.Properties.Resources.banner_pdf_reducer_cloud)
        {
            InitializeComponent();
        }


        public override void LoadLabels()
        {
            base.LoadLabels();

            chkDeleteOriginalFileOnSuccess.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkDeleteOriginalFileOnSuccess", FrameworkGlobals.ApplicationLanguage);
            chkOnlyPdf.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkOnlyPdf", FrameworkGlobals.ApplicationLanguage);
            chkCharRepair.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkCharRepair", FrameworkGlobals.ApplicationLanguage);
            chkDownscaleImages.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkDownscaleImages", FrameworkGlobals.ApplicationLanguage);
            chkEnableColorDetection.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkEnableColorDetection", FrameworkGlobals.ApplicationLanguage);
            chkFastWebView.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkFastWebView", FrameworkGlobals.ApplicationLanguage);
            chkJPEG2000.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkJPEG2000", FrameworkGlobals.ApplicationLanguage);
            chkJBIG2.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkJBIG2", FrameworkGlobals.ApplicationLanguage);
            chkKeepWriteAcessTime.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkKeepWriteAcessTime", FrameworkGlobals.ApplicationLanguage);
            chkPackDocument.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkPackDocument", FrameworkGlobals.ApplicationLanguage);
            chkRecompressImages.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkRecompressImages", FrameworkGlobals.ApplicationLanguage);
            chkRemoveAnnotations.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkRemoveAnnotations", FrameworkGlobals.ApplicationLanguage);
            chkRemoveBookmarks.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkRemoveBookmarks", FrameworkGlobals.ApplicationLanguage);
            chkRemoveEmbeddedFiles.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkRemoveEmbeddedFiles", FrameworkGlobals.ApplicationLanguage);
            chkRemoveFormFields.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkRemoveFormFields", FrameworkGlobals.ApplicationLanguage);
            chkRemoveHyperlinks.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkRemoveHyperlinks", FrameworkGlobals.ApplicationLanguage);
            chkUseMRC.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkUseMRC", FrameworkGlobals.ApplicationLanguage);
            chkPackFonts.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkPackFonts", FrameworkGlobals.ApplicationLanguage);
            lbDocumentContent.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbDocumentContent", FrameworkGlobals.ApplicationLanguage);
            lbInteractiveContent.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbInteractiveContent", FrameworkGlobals.ApplicationLanguage);
            lbPreferredVersion.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbPreferredVersion", FrameworkGlobals.ApplicationLanguage);
            lbDpi.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbDpi", FrameworkGlobals.ApplicationLanguage);
            lbQuality.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbQuality", FrameworkGlobals.ApplicationLanguage);
            lbResolution.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbResolution", FrameworkGlobals.ApplicationLanguage);
            tabBitmap.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_tabBitmap", FrameworkGlobals.ApplicationLanguage);
            tabContentRemoval.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_tabContentRemoval", FrameworkGlobals.ApplicationLanguage);
            tabOutputFormat.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_tabOutputFormat", FrameworkGlobals.ApplicationLanguage);
            tabCompression.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_tabCompression", FrameworkGlobals.ApplicationLanguage);
            this.cmbImageQuality.Items.AddRange(new object[] {
            PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbImageQuality.Items", FrameworkGlobals.ApplicationLanguage),
            PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbImageQuality.Items1", FrameworkGlobals.ApplicationLanguage),
            PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbImageQuality.Items2", FrameworkGlobals.ApplicationLanguage),
            PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbImageQuality.Items3", FrameworkGlobals.ApplicationLanguage)});
            this.cmbPreferredVersion.Items.AddRange(new object[] {
            PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbPreferredVersion.Items", FrameworkGlobals.ApplicationLanguage),
            PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbPreferredVersion.Items1", FrameworkGlobals.ApplicationLanguage),
            PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbPreferredVersion.Items2", FrameworkGlobals.ApplicationLanguage),
            PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbPreferredVersion.Items3", FrameworkGlobals.ApplicationLanguage),
            PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbPreferredVersion.Items4", FrameworkGlobals.ApplicationLanguage)});
            toolTipPreferredVersion.SetToolTip(this.cmbPreferredVersion, PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbPreferredVersion.ToolTip", FrameworkGlobals.ApplicationLanguage));
            toolTipPreferredVersion.ToolTipTitle = PdfReducerGlobals.LabelsLocalizer.GetString("label_tooltipPreferredVersionTitle", FrameworkGlobals.ApplicationLanguage);
        }


        public override void LoadConfiguration()
        {
            base.LoadConfiguration();

            chkDeleteOriginalFileOnSuccess.Checked = FrameworkGlobals.ApplicationConfiguration.FileProductionRules.DeleteOriginalFileOnSuccess;
            chkOnlyPdf.Checked = FrameworkGlobals.ApplicationConfiguration.OnlyProcessPDF;

            chkEnableColorDetection.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.EnableColorDetection;
            chkRecompressImages.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.RecompressImages;
            chkPackDocument.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.PackDocument;
            chkDownscaleImages.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.DownscaleImages;
            nuDownscaleResolution.Value = (int)PdfReducerGlobals.ReduceActionConfiguration.DownscaleResolution;
            chkFastWebView.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.FastWebView;
            chkRemoveAnnotations.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.RemoveAnnotations;
            chkRemoveBookmarks.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.RemoveBookmarks;
            chkRemoveFormFields.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.RemoveFormFields;
            chkRemoveHyperlinks.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.RemoveHyperlinks;
            chkRemoveEmbeddedFiles.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.RemoveEmbeddedFiles;
            chkJPEG2000.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.EnableJPEG2000;
            chkJBIG2.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.EnableJBIG2;
            chkUseMRC.Checked = (bool)PdfReducerGlobals.ReduceActionConfiguration.EnableMRC;
            chkKeepWriteAcessTime.Checked = FrameworkGlobals.ApplicationConfiguration.FileProductionRules.KeepWriteAndAccessTime;
            chkPackFonts.Checked = PdfReducerGlobals.ReduceActionConfiguration.PackFonts;

            // Check whether mutually exclusive options should be disabled
            chkCharRepair.Enabled = PdfReducerGlobals.ReduceActionConfiguration.EnableColorDetection;
            chkCharRepair.Checked = chkCharRepair.Enabled && (bool)PdfReducerGlobals.ReduceActionConfiguration.EnableCharRepair;

            switch (PdfReducerGlobals.ReduceActionConfiguration.OutputVersion)
            {
                case PDFReduceParameters.OutputVersionEnum.PdfVersionRetainExisting:
                    cmbPreferredVersion.SelectedIndex = 0;
                    break;

                case PDFReduceParameters.OutputVersionEnum.PdfVersion14:
                    cmbPreferredVersion.SelectedIndex = 1;
                    break;

                case PDFReduceParameters.OutputVersionEnum.PdfVersion15:
                    cmbPreferredVersion.SelectedIndex = 2;
                    break;

                case PDFReduceParameters.OutputVersionEnum.PdfVersion16:
                    cmbPreferredVersion.SelectedIndex = 3;
                    break;

                case PDFReduceParameters.OutputVersionEnum.PdfVersion17:
                    cmbPreferredVersion.SelectedIndex = 4;
                    break;
            }

            switch (PdfReducerGlobals.ReduceActionConfiguration.ImageQuality)
            {
                case PDFReduceParameters.ImageQualityEnum.ImageQualityLow:
                    cmbImageQuality.SelectedIndex = 0;
                    break;
                case PDFReduceParameters.ImageQualityEnum.ImageQualityMedium:
                    cmbImageQuality.SelectedIndex = 1;
                    break;
                case PDFReduceParameters.ImageQualityEnum.ImageQualityHigh:
                    cmbImageQuality.SelectedIndex = 2;
                    break;
                case PDFReduceParameters.ImageQualityEnum.ImageQualityVeryHigh:
                    cmbImageQuality.SelectedIndex = 3;
                    break;
            }
        }

        protected override void ApplyConfigurationChanges()
        {
            base.ApplyConfigurationChanges();

            FrameworkGlobals.ApplicationConfiguration.FileProductionRules.DeleteOriginalFileOnSuccess = chkDeleteOriginalFileOnSuccess.Checked;
            FrameworkGlobals.ApplicationConfiguration.OnlyProcessPDF = chkOnlyPdf.Checked;
            FrameworkGlobals.ApplicationConfiguration.FileProductionRules.KeepWriteAndAccessTime = chkKeepWriteAcessTime.Checked;

            PdfReducerGlobals.ReduceActionConfiguration.EnableColorDetection = chkEnableColorDetection.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.RecompressImages = chkRecompressImages.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.PackDocument = chkPackDocument.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.DownscaleImages = chkDownscaleImages.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.DownscaleResolution = (int)nuDownscaleResolution.Value;
            PdfReducerGlobals.ReduceActionConfiguration.FastWebView = chkFastWebView.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.RemoveAnnotations = chkRemoveAnnotations.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.RemoveBookmarks = chkRemoveBookmarks.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.RemoveFormFields = chkRemoveFormFields.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.RemoveEmbeddedFiles = chkRemoveEmbeddedFiles.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.RemoveHyperlinks = chkRemoveHyperlinks.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.EnableJPEG2000 = chkJPEG2000.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.EnableJBIG2 = chkJBIG2.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.EnableMRC = chkUseMRC.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.EnableCharRepair = chkCharRepair.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.PackFonts = chkPackFonts.Checked;

            switch (cmbImageQuality.SelectedIndex)
            {
                case 0:
                    PdfReducerGlobals.ReduceActionConfiguration.ImageQuality = PDFReduceParameters.ImageQualityEnum.ImageQualityLow;
                    break;
                case 1:
                    PdfReducerGlobals.ReduceActionConfiguration.ImageQuality = PDFReduceParameters.ImageQualityEnum.ImageQualityMedium;
                    break;
                case 2:
                    PdfReducerGlobals.ReduceActionConfiguration.ImageQuality = PDFReduceParameters.ImageQualityEnum.ImageQualityHigh;
                    break;
                case 3:
                    PdfReducerGlobals.ReduceActionConfiguration.ImageQuality = PDFReduceParameters.ImageQualityEnum.ImageQualityVeryHigh;
                    break;
            }

            switch (cmbPreferredVersion.SelectedIndex)
            {
                case 0:
                    PdfReducerGlobals.ReduceActionConfiguration.OutputVersion = PDFReduceParameters.OutputVersionEnum.PdfVersionRetainExisting;
                    break;
                case 1:
                    PdfReducerGlobals.ReduceActionConfiguration.OutputVersion = PDFReduceParameters.OutputVersionEnum.PdfVersion14;
                    break;
                case 2:
                    PdfReducerGlobals.ReduceActionConfiguration.OutputVersion = PDFReduceParameters.OutputVersionEnum.PdfVersion15;
                    break;
                case 3:
                    PdfReducerGlobals.ReduceActionConfiguration.OutputVersion = PDFReduceParameters.OutputVersionEnum.PdfVersion16;
                    break;
                case 4:
                    PdfReducerGlobals.ReduceActionConfiguration.OutputVersion = PDFReduceParameters.OutputVersionEnum.PdfVersion17;
                    break;

            }

            Dispose();
        }

        protected override void ResetDefaultConfiguration()
        {
            base.ResetDefaultConfiguration();
            PdfReducerGlobals.ReduceActionConfiguration = ConfigurationManager.ResetDefaultReduceActionConfiguration();
            LoadConfiguration();
        }


        private void chkEnableColorDetection_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkEnableColorDetection.Checked)
            {
                // Don't allow character repairing when no color detection is performed
                chkCharRepair.Checked = false;
                chkCharRepair.Enabled = false;
            }
            else
            {
                // Re-enable char character repairing
                chkCharRepair.Enabled = true;
            }
        }
    }
}