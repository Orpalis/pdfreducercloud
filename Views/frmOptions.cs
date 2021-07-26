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
using PassportPDF.Model;
using PassportPDF.Tools.Framework;
using PassportPDF.Tools.Framework.Configuration;

namespace pdfReducerCloud.Views
{
    public partial class frmOptions : PassportPDF.Tools.WinForm.Views.frmOptionsBase
    {
        public frmOptions() : base(Properties.Resources.banner_pdf_reducer_cloud)
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
            chkRemoveBlankPages.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkRemoveBlankPages", FrameworkGlobals.ApplicationLanguage);
            chkRemoveJavaScript.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkRemoveJavaScript", FrameworkGlobals.ApplicationLanguage);
            chkUseMRC.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkUseMRC", FrameworkGlobals.ApplicationLanguage);
            chkPreserveSmoothing.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkPreserveSmoothing", FrameworkGlobals.ApplicationLanguage);
            lbFonts.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbFonts", FrameworkGlobals.ApplicationLanguage);
            chkPackFonts.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkPackFonts", FrameworkGlobals.ApplicationLanguage);
            lbDocumentContent.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbDocumentContent", FrameworkGlobals.ApplicationLanguage);
            lbInteractiveContent.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbInteractiveContent", FrameworkGlobals.ApplicationLanguage);
            lbPreferredVersion.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbPreferredVersion", FrameworkGlobals.ApplicationLanguage);
            lbDpi.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbDpi", FrameworkGlobals.ApplicationLanguage);
            lbQuality.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbQuality", FrameworkGlobals.ApplicationLanguage);
            lbResolution.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbResolution", FrameworkGlobals.ApplicationLanguage);
            lbMrc.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbMrc", FrameworkGlobals.ApplicationLanguage);
            lbColorDetection.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbColorDetection", FrameworkGlobals.ApplicationLanguage);
            tabBitmap.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_tabBitmap", FrameworkGlobals.ApplicationLanguage);
            tabContentRemoval.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_tabContentRemoval", FrameworkGlobals.ApplicationLanguage);
            tabOutputFormat.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_tabOutputFormat", FrameworkGlobals.ApplicationLanguage);
            tabCompression.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_tabCompression", FrameworkGlobals.ApplicationLanguage);
            lbBackgroundImageResolution.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbBackgroundImageResolution", FrameworkGlobals.ApplicationLanguage);
            lbDpi2.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_lbDpi2", FrameworkGlobals.ApplicationLanguage);
            chkRemoveMetadata.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkRemoveMetadata", FrameworkGlobals.ApplicationLanguage);
            chkRemovePageThumbnails.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkRemovePageThumbnails", FrameworkGlobals.ApplicationLanguage);
            chkRemoveEmbeddedFonts.Text = PdfReducerGlobals.LabelsLocalizer.GetString("label_chkRemoveEmbeddedFonts", FrameworkGlobals.ApplicationLanguage);

            cmbImageQuality.Items.AddRange(new object[]
            {
                PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbImageQuality.Items", FrameworkGlobals.ApplicationLanguage),
                PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbImageQuality.Items1", FrameworkGlobals.ApplicationLanguage),
                PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbImageQuality.Items2", FrameworkGlobals.ApplicationLanguage),
                PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbImageQuality.Items3", FrameworkGlobals.ApplicationLanguage)
            });
            cmbPreferredVersion.Items.AddRange(new object[]
            {
                PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbPreferredVersion.Items", FrameworkGlobals.ApplicationLanguage),
                PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbPreferredVersion.Items1", FrameworkGlobals.ApplicationLanguage),
                PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbPreferredVersion.Items2", FrameworkGlobals.ApplicationLanguage),
                PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbPreferredVersion.Items3", FrameworkGlobals.ApplicationLanguage),
                PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbPreferredVersion.Items4", FrameworkGlobals.ApplicationLanguage)
            });
            toolTipPreferredVersion.SetToolTip(cmbPreferredVersion, PdfReducerGlobals.LabelsLocalizer.GetString("label_cmbPreferredVersion.ToolTip", FrameworkGlobals.ApplicationLanguage));
            toolTipPreferredVersion.ToolTipTitle = PdfReducerGlobals.LabelsLocalizer.GetString("label_tooltipPreferredVersionTitle", FrameworkGlobals.ApplicationLanguage);
        }


        public override void LoadConfiguration()
        {
            base.LoadConfiguration();

            chkDeleteOriginalFileOnSuccess.Checked = FrameworkGlobals.ApplicationConfiguration.FileProductionRules.DeleteOriginalFileOnSuccess;
            chkOnlyPdf.Checked = FrameworkGlobals.ApplicationConfiguration.OnlyProcessPDF;

            chkEnableColorDetection.Checked = PdfReducerGlobals.ReduceActionConfiguration.EnableColorDetection;
            chkCharRepair.Checked = PdfReducerGlobals.ReduceActionConfiguration.EnableCharRepair;
            chkRecompressImages.Checked = PdfReducerGlobals.ReduceActionConfiguration.RecompressImages;
            chkPackDocument.Checked = PdfReducerGlobals.ReduceActionConfiguration.PackDocument;
            chkDownscaleImages.Checked = PdfReducerGlobals.ReduceActionConfiguration.DownscaleImages;
            nuDownscaleResolution.Value = PdfReducerGlobals.ReduceActionConfiguration.DownscaleResolution;
            chkFastWebView.Checked = PdfReducerGlobals.ReduceActionConfiguration.FastWebView;
            chkRemoveAnnotations.Checked = PdfReducerGlobals.ReduceActionConfiguration.RemoveAnnotations;
            chkRemoveBookmarks.Checked = PdfReducerGlobals.ReduceActionConfiguration.RemoveBookmarks;
            chkRemoveFormFields.Checked = PdfReducerGlobals.ReduceActionConfiguration.RemoveFormFields;
            chkRemoveHyperlinks.Checked = PdfReducerGlobals.ReduceActionConfiguration.RemoveHyperlinks;
            chkRemoveEmbeddedFiles.Checked = PdfReducerGlobals.ReduceActionConfiguration.RemoveEmbeddedFiles;
            chkRemoveBlankPages.Checked = PdfReducerGlobals.ReduceActionConfiguration.RemoveBlankPages;
            chkRemoveJavaScript.Checked = PdfReducerGlobals.ReduceActionConfiguration.RemoveJavaScript;
            chkJPEG2000.Checked = PdfReducerGlobals.ReduceActionConfiguration.EnableJPEG2000;
            chkJBIG2.Checked = PdfReducerGlobals.ReduceActionConfiguration.EnableJBIG2;
            chkUseMRC.Checked = PdfReducerGlobals.ReduceActionConfiguration.EnableMRC;
            chkPreserveSmoothing.Checked = PdfReducerGlobals.ReduceActionConfiguration.MRCPreserveSmoothing;
            chkKeepWriteAcessTime.Checked = FrameworkGlobals.ApplicationConfiguration.FileProductionRules.KeepWriteAndAccessTime;
            chkPackFonts.Checked = PdfReducerGlobals.ReduceActionConfiguration.PackFonts;
            nuBackgroundImageResolution.Value = PdfReducerGlobals.ReduceActionConfiguration.MRCDownscaleResolution;
            chkRemovePageThumbnails.Checked = PdfReducerGlobals.ReduceActionConfiguration.RemovePageThumbnails;
            chkRemoveMetadata.Checked = PdfReducerGlobals.ReduceActionConfiguration.RemoveMetadata;
            chkRemoveEmbeddedFonts.Checked = PdfReducerGlobals.ReduceActionConfiguration.RemoveEmbeddedFonts;

            switch (PdfReducerGlobals.ReduceActionConfiguration.OutputVersion)
            {
                case PdfVersion.PdfVersionRetainExisting:
                    cmbPreferredVersion.SelectedIndex = 0;
                    break;

                case PdfVersion.PdfVersion14:
                    cmbPreferredVersion.SelectedIndex = 1;
                    break;

                case PdfVersion.PdfVersion15:
                    cmbPreferredVersion.SelectedIndex = 2;
                    break;

                case PdfVersion.PdfVersion16:
                    cmbPreferredVersion.SelectedIndex = 3;
                    break;

                case PdfVersion.PdfVersion17:
                    cmbPreferredVersion.SelectedIndex = 4;
                    break;
            }

            switch (PdfReducerGlobals.ReduceActionConfiguration.ImageQuality)
            {
                case ImageQuality.ImageQualityLow:
                    cmbImageQuality.SelectedIndex = 0;
                    break;
                case ImageQuality.ImageQualityMedium:
                    cmbImageQuality.SelectedIndex = 1;
                    break;
                case ImageQuality.ImageQualityHigh:
                    cmbImageQuality.SelectedIndex = 2;
                    break;
                case ImageQuality.ImageQualityVeryHigh:
                    cmbImageQuality.SelectedIndex = 3;
                    break;
            }


            // Check whether mutually exclusive options should be disabled
            chkCharRepair.Enabled = PdfReducerGlobals.ReduceActionConfiguration.EnableColorDetection;
            cmbImageQuality.Enabled = PdfReducerGlobals.ReduceActionConfiguration.RecompressImages;
            nuDownscaleResolution.Enabled = PdfReducerGlobals.ReduceActionConfiguration.DownscaleImages;
            lbDpi.Enabled = PdfReducerGlobals.ReduceActionConfiguration.DownscaleImages;
            lbResolution.Enabled = PdfReducerGlobals.ReduceActionConfiguration.DownscaleImages;
            chkPreserveSmoothing.Enabled = PdfReducerGlobals.ReduceActionConfiguration.EnableMRC;
            lbBackgroundImageResolution.Enabled = PdfReducerGlobals.ReduceActionConfiguration.EnableMRC;
            lbDpi2.Enabled = PdfReducerGlobals.ReduceActionConfiguration.EnableMRC;
            nuBackgroundImageResolution.Enabled = PdfReducerGlobals.ReduceActionConfiguration.EnableMRC;
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
            PdfReducerGlobals.ReduceActionConfiguration.RemoveBlankPages = chkRemoveBlankPages.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.RemoveJavaScript = chkRemoveJavaScript.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.EnableJPEG2000 = chkJPEG2000.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.EnableJBIG2 = chkJBIG2.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.EnableMRC = chkUseMRC.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.MRCPreserveSmoothing = chkPreserveSmoothing.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.EnableCharRepair = chkCharRepair.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.PackFonts = chkPackFonts.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.MRCDownscaleResolution = (int)nuBackgroundImageResolution.Value;
            PdfReducerGlobals.ReduceActionConfiguration.RemoveMetadata = chkRemoveMetadata.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.RemovePageThumbnails = chkRemovePageThumbnails.Checked;
            PdfReducerGlobals.ReduceActionConfiguration.RemoveEmbeddedFonts = chkRemoveEmbeddedFonts.Checked;

            switch (cmbImageQuality.SelectedIndex)
            {
                case 0:
                    PdfReducerGlobals.ReduceActionConfiguration.ImageQuality = ImageQuality.ImageQualityLow;
                    break;
                case 1:
                    PdfReducerGlobals.ReduceActionConfiguration.ImageQuality = ImageQuality.ImageQualityMedium;
                    break;
                case 2:
                    PdfReducerGlobals.ReduceActionConfiguration.ImageQuality = ImageQuality.ImageQualityHigh;
                    break;
                case 3:
                    PdfReducerGlobals.ReduceActionConfiguration.ImageQuality = ImageQuality.ImageQualityVeryHigh;
                    break;
            }

            switch (cmbPreferredVersion.SelectedIndex)
            {
                case 0:
                    PdfReducerGlobals.ReduceActionConfiguration.OutputVersion = PdfVersion.PdfVersionRetainExisting;
                    break;
                case 1:
                    PdfReducerGlobals.ReduceActionConfiguration.OutputVersion = PdfVersion.PdfVersion14;
                    break;
                case 2:
                    PdfReducerGlobals.ReduceActionConfiguration.OutputVersion = PdfVersion.PdfVersion15;
                    break;
                case 3:
                    PdfReducerGlobals.ReduceActionConfiguration.OutputVersion = PdfVersion.PdfVersion16;
                    break;
                case 4:
                    PdfReducerGlobals.ReduceActionConfiguration.OutputVersion = PdfVersion.PdfVersion17;
                    break;

            }

            Dispose();
        }


        protected override void ResetDefaultConfiguration()
        {
            base.ResetDefaultConfiguration();
            PdfReducerGlobals.ReduceActionConfiguration = ConfigurationManager.ResetDefaultPDFReduceActionConfiguration();
            LoadConfiguration();
        }


        private void chkEnableColorDetection_CheckedChanged(object sender, EventArgs e)
        {
            chkCharRepair.Enabled = chkEnableColorDetection.Checked;
        }


        private void chkUseMRC_CheckedChanged(object sender, EventArgs e)
        {
            chkPreserveSmoothing.Enabled = chkUseMRC.Checked;
            nuBackgroundImageResolution.Enabled = chkUseMRC.Checked;
            lbBackgroundImageResolution.Enabled = chkUseMRC.Checked;
            lbDpi2.Enabled = chkUseMRC.Checked;
        }


        private void chkDownscaleImages_CheckedChanged(object sender, EventArgs e)
        {
            nuDownscaleResolution.Enabled = chkDownscaleImages.Checked;
            lbDpi.Enabled = chkDownscaleImages.Checked;
            lbResolution.Enabled = chkDownscaleImages.Checked;
        }


        private void chkRecompressImages_CheckedChanged(object sender, EventArgs e)
        {
            cmbImageQuality.Enabled = chkRecompressImages.Checked;
        }
    }
}