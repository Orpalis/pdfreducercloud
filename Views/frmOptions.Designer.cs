namespace pdfReducerCloud.Views
{
    partial class frmOptions : PassportPDF.Tools.WinForm.Views.frmOptionsBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkOnlyPdf = new System.Windows.Forms.CheckBox();
            this.chkDeleteOriginalFileOnSuccess = new System.Windows.Forms.CheckBox();
            this.chkEnableColorDetection = new System.Windows.Forms.CheckBox();
            this.tabCompression = new System.Windows.Forms.TabPage();
            this.chkPackFonts = new System.Windows.Forms.CheckBox();
            this.chkUseMRC = new System.Windows.Forms.CheckBox();
            this.chkCharRepair = new System.Windows.Forms.CheckBox();
            this.tabBitmap = new System.Windows.Forms.TabPage();
            this.chkJBIG2 = new System.Windows.Forms.CheckBox();
            this.lbDpi = new System.Windows.Forms.Label();
            this.chkRecompressImages = new System.Windows.Forms.CheckBox();
            this.chkDownscaleImages = new System.Windows.Forms.CheckBox();
            this.chkJPEG2000 = new System.Windows.Forms.CheckBox();
            this.cmbImageQuality = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nuDownscaleResolution = new System.Windows.Forms.NumericUpDown();
            this.lbResolution = new System.Windows.Forms.Label();
            this.lbQuality = new System.Windows.Forms.Label();
            this.tabContentRemoval = new System.Windows.Forms.TabPage();
            this.chkRemoveBlankPages = new System.Windows.Forms.CheckBox();
            this.chkRemoveHyperlinks = new System.Windows.Forms.CheckBox();
            this.chkPackDocument = new System.Windows.Forms.CheckBox();
            this.lbDocumentContent = new System.Windows.Forms.Label();
            this.lbInteractiveContent = new System.Windows.Forms.Label();
            this.chkRemoveEmbeddedFiles = new System.Windows.Forms.CheckBox();
            this.chkRemoveBookmarks = new System.Windows.Forms.CheckBox();
            this.chkRemoveFormFields = new System.Windows.Forms.CheckBox();
            this.chkRemoveAnnotations = new System.Windows.Forms.CheckBox();
            this.tabOutputFormat = new System.Windows.Forms.TabPage();
            this.chkKeepWriteAcessTime = new System.Windows.Forms.CheckBox();
            this.cmbPreferredVersion = new System.Windows.Forms.ComboBox();
            this.lbPreferredVersion = new System.Windows.Forms.Label();
            this.chkFastWebView = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipPreferredVersion = new System.Windows.Forms.ToolTip(this.components);
            this.tabGeneral.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCompression.SuspendLayout();
            this.tabBitmap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDownscaleResolution)).BeginInit();
            this.tabContentRemoval.SuspendLayout();
            this.tabOutputFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.chkOnlyPdf);
            this.tabGeneral.Controls.Add(this.chkDeleteOriginalFileOnSuccess);
            this.tabGeneral.Controls.SetChildIndex(this.chkDeleteOriginalFileOnSuccess, 0);
            this.tabGeneral.Controls.SetChildIndex(this.chkOnlyPdf, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCompression);
            this.tabControl1.Controls.Add(this.tabBitmap);
            this.tabControl1.Controls.Add(this.tabContentRemoval);
            this.tabControl1.Controls.Add(this.tabOutputFormat);
            this.tabControl1.Controls.SetChildIndex(this.tabOutputFormat, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabContentRemoval, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabBitmap, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabCompression, 0);
            this.tabControl1.Controls.SetChildIndex(this.tabGeneral, 0);
            // 
            // chkOnlyPdf
            // 
            this.chkOnlyPdf.AutoSize = true;
            this.chkOnlyPdf.Location = new System.Drawing.Point(15, 84);
            this.chkOnlyPdf.Name = "chkOnlyPdf";
            this.chkOnlyPdf.Size = new System.Drawing.Size(132, 17);
            this.chkOnlyPdf.TabIndex = 0;
            this.chkOnlyPdf.Text = "Only process PDF files";
            this.chkOnlyPdf.UseVisualStyleBackColor = true;
            // 
            // chkDeleteOriginalFileOnSuccess
            // 
            this.chkDeleteOriginalFileOnSuccess.AutoSize = true;
            this.chkDeleteOriginalFileOnSuccess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkDeleteOriginalFileOnSuccess.Location = new System.Drawing.Point(15, 107);
            this.chkDeleteOriginalFileOnSuccess.Name = "chkDeleteOriginalFileOnSuccess";
            this.chkDeleteOriginalFileOnSuccess.Size = new System.Drawing.Size(254, 17);
            this.chkDeleteOriginalFileOnSuccess.TabIndex = 15;
            this.chkDeleteOriginalFileOnSuccess.Text = "Delete original files after succesful size reduction";
            this.chkDeleteOriginalFileOnSuccess.UseVisualStyleBackColor = true;
            // 
            // chkEnableColorDetection
            // 
            this.chkEnableColorDetection.AutoSize = true;
            this.chkEnableColorDetection.Location = new System.Drawing.Point(15, 15);
            this.chkEnableColorDetection.Name = "chkEnableColorDetection";
            this.chkEnableColorDetection.Size = new System.Drawing.Size(132, 17);
            this.chkEnableColorDetection.TabIndex = 0;
            this.chkEnableColorDetection.Text = "Enable color detection";
            this.chkEnableColorDetection.UseVisualStyleBackColor = true;
            this.chkEnableColorDetection.CheckedChanged += new System.EventHandler(this.chkEnableColorDetection_CheckedChanged);
            // 
            // tabCompression
            // 
            this.tabCompression.Controls.Add(this.chkPackFonts);
            this.tabCompression.Controls.Add(this.chkUseMRC);
            this.tabCompression.Controls.Add(this.chkCharRepair);
            this.tabCompression.Controls.Add(this.chkEnableColorDetection);
            this.tabCompression.Location = new System.Drawing.Point(4, 22);
            this.tabCompression.Name = "tabCompression";
            this.tabCompression.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompression.Size = new System.Drawing.Size(485, 217);
            this.tabCompression.TabIndex = 0;
            this.tabCompression.Text = "Compression";
            this.tabCompression.UseVisualStyleBackColor = true;
            // 
            // chkPackFonts
            // 
            this.chkPackFonts.AutoSize = true;
            this.chkPackFonts.Location = new System.Drawing.Point(15, 85);
            this.chkPackFonts.Name = "chkPackFonts";
            this.chkPackFonts.Size = new System.Drawing.Size(77, 17);
            this.chkPackFonts.TabIndex = 17;
            this.chkPackFonts.Text = "Pack fonts";
            this.chkPackFonts.UseVisualStyleBackColor = true;
            // 
            // chkUseMRC
            // 
            this.chkUseMRC.AutoSize = true;
            this.chkUseMRC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkUseMRC.Location = new System.Drawing.Point(15, 61);
            this.chkUseMRC.Name = "chkUseMRC";
            this.chkUseMRC.Size = new System.Drawing.Size(253, 17);
            this.chkUseMRC.TabIndex = 16;
            this.chkUseMRC.Text = "Enable MRC (Mixed raster content) compression";
            this.chkUseMRC.UseVisualStyleBackColor = true;
            // 
            // chkCharRepair
            // 
            this.chkCharRepair.AutoSize = true;
            this.chkCharRepair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkCharRepair.Location = new System.Drawing.Point(15, 38);
            this.chkCharRepair.Name = "chkCharRepair";
            this.chkCharRepair.Size = new System.Drawing.Size(213, 17);
            this.chkCharRepair.TabIndex = 8;
            this.chkCharRepair.Text = "Apply character repairing after threshold";
            this.chkCharRepair.UseVisualStyleBackColor = true;
            // 
            // tabBitmap
            // 
            this.tabBitmap.Controls.Add(this.chkJBIG2);
            this.tabBitmap.Controls.Add(this.lbDpi);
            this.tabBitmap.Controls.Add(this.chkRecompressImages);
            this.tabBitmap.Controls.Add(this.chkDownscaleImages);
            this.tabBitmap.Controls.Add(this.chkJPEG2000);
            this.tabBitmap.Controls.Add(this.cmbImageQuality);
            this.tabBitmap.Controls.Add(this.label3);
            this.tabBitmap.Controls.Add(this.nuDownscaleResolution);
            this.tabBitmap.Controls.Add(this.lbResolution);
            this.tabBitmap.Controls.Add(this.lbQuality);
            this.tabBitmap.Location = new System.Drawing.Point(4, 22);
            this.tabBitmap.Name = "tabBitmap";
            this.tabBitmap.Size = new System.Drawing.Size(485, 217);
            this.tabBitmap.TabIndex = 2;
            this.tabBitmap.Text = "Images";
            this.tabBitmap.UseVisualStyleBackColor = true;
            // 
            // chkJBIG2
            // 
            this.chkJBIG2.AutoSize = true;
            this.chkJBIG2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkJBIG2.Location = new System.Drawing.Point(15, 85);
            this.chkJBIG2.Name = "chkJBIG2";
            this.chkJBIG2.Size = new System.Drawing.Size(238, 17);
            this.chkJBIG2.TabIndex = 12;
            this.chkJBIG2.Text = "Enable JBIG2 compression for bitonal images";
            this.chkJBIG2.UseVisualStyleBackColor = true;
            // 
            // lbDpi
            // 
            this.lbDpi.AutoSize = true;
            this.lbDpi.Location = new System.Drawing.Point(185, 132);
            this.lbDpi.Name = "lbDpi";
            this.lbDpi.Size = new System.Drawing.Size(21, 13);
            this.lbDpi.TabIndex = 10;
            this.lbDpi.Text = "dpi";
            // 
            // chkRecompressImages
            // 
            this.chkRecompressImages.AutoSize = true;
            this.chkRecompressImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkRecompressImages.Location = new System.Drawing.Point(15, 15);
            this.chkRecompressImages.Name = "chkRecompressImages";
            this.chkRecompressImages.Size = new System.Drawing.Size(121, 17);
            this.chkRecompressImages.TabIndex = 8;
            this.chkRecompressImages.Text = "Recompress images";
            this.chkRecompressImages.UseVisualStyleBackColor = true;
            // 
            // chkDownscaleImages
            // 
            this.chkDownscaleImages.AutoSize = true;
            this.chkDownscaleImages.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkDownscaleImages.Location = new System.Drawing.Point(15, 108);
            this.chkDownscaleImages.Name = "chkDownscaleImages";
            this.chkDownscaleImages.Size = new System.Drawing.Size(115, 17);
            this.chkDownscaleImages.TabIndex = 7;
            this.chkDownscaleImages.Text = "Downscale images";
            this.chkDownscaleImages.UseVisualStyleBackColor = true;
            // 
            // chkJPEG2000
            // 
            this.chkJPEG2000.AutoSize = true;
            this.chkJPEG2000.Location = new System.Drawing.Point(15, 62);
            this.chkJPEG2000.Name = "chkJPEG2000";
            this.chkJPEG2000.Size = new System.Drawing.Size(395, 17);
            this.chkJPEG2000.TabIndex = 6;
            this.chkJPEG2000.Text = "Enable JPEG2000 compression for high definition images (PDF 1.5 and higher)";
            this.chkJPEG2000.UseVisualStyleBackColor = true;
            // 
            // cmbImageQuality
            // 
            this.cmbImageQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImageQuality.FormattingEnabled = true;
            this.cmbImageQuality.Location = new System.Drawing.Point(93, 35);
            this.cmbImageQuality.Name = "cmbImageQuality";
            this.cmbImageQuality.Size = new System.Drawing.Size(94, 21);
            this.cmbImageQuality.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 11;
            // 
            // nuDownscaleResolution
            // 
            this.nuDownscaleResolution.Location = new System.Drawing.Point(129, 131);
            this.nuDownscaleResolution.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nuDownscaleResolution.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nuDownscaleResolution.Name = "nuDownscaleResolution";
            this.nuDownscaleResolution.Size = new System.Drawing.Size(50, 20);
            this.nuDownscaleResolution.TabIndex = 3;
            this.nuDownscaleResolution.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lbResolution
            // 
            this.lbResolution.AutoSize = true;
            this.lbResolution.Location = new System.Drawing.Point(12, 132);
            this.lbResolution.Name = "lbResolution";
            this.lbResolution.Size = new System.Drawing.Size(111, 13);
            this.lbResolution.TabIndex = 2;
            this.lbResolution.Text = "Downscale resolution:";
            // 
            // lbQuality
            // 
            this.lbQuality.AutoSize = true;
            this.lbQuality.Location = new System.Drawing.Point(15, 38);
            this.lbQuality.Name = "lbQuality";
            this.lbQuality.Size = new System.Drawing.Size(72, 13);
            this.lbQuality.TabIndex = 0;
            this.lbQuality.Text = "Image quality:";
            // 
            // tabContentRemoval
            // 
            this.tabContentRemoval.Controls.Add(this.chkRemoveBlankPages);
            this.tabContentRemoval.Controls.Add(this.chkRemoveHyperlinks);
            this.tabContentRemoval.Controls.Add(this.chkPackDocument);
            this.tabContentRemoval.Controls.Add(this.lbDocumentContent);
            this.tabContentRemoval.Controls.Add(this.lbInteractiveContent);
            this.tabContentRemoval.Controls.Add(this.chkRemoveEmbeddedFiles);
            this.tabContentRemoval.Controls.Add(this.chkRemoveBookmarks);
            this.tabContentRemoval.Controls.Add(this.chkRemoveFormFields);
            this.tabContentRemoval.Controls.Add(this.chkRemoveAnnotations);
            this.tabContentRemoval.Location = new System.Drawing.Point(4, 22);
            this.tabContentRemoval.Name = "tabContentRemoval";
            this.tabContentRemoval.Size = new System.Drawing.Size(485, 217);
            this.tabContentRemoval.TabIndex = 4;
            this.tabContentRemoval.Text = "Content Removal";
            this.tabContentRemoval.UseVisualStyleBackColor = true;
            // 
            // chkRemoveBlankPages
            // 
            this.chkRemoveBlankPages.AutoSize = true;
            this.chkRemoveBlankPages.Location = new System.Drawing.Point(34, 195);
            this.chkRemoveBlankPages.Name = "chkRemoveBlankPages";
            this.chkRemoveBlankPages.Size = new System.Drawing.Size(127, 17);
            this.chkRemoveBlankPages.TabIndex = 12;
            this.chkRemoveBlankPages.Text = "Remove blank pages";
            this.chkRemoveBlankPages.UseVisualStyleBackColor = true;
            // 
            // chkRemoveHyperlinks
            // 
            this.chkRemoveHyperlinks.AutoSize = true;
            this.chkRemoveHyperlinks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkRemoveHyperlinks.Location = new System.Drawing.Point(34, 81);
            this.chkRemoveHyperlinks.Name = "chkRemoveHyperlinks";
            this.chkRemoveHyperlinks.Size = new System.Drawing.Size(116, 17);
            this.chkRemoveHyperlinks.TabIndex = 11;
            this.chkRemoveHyperlinks.Text = "Remove hyperlinks";
            this.chkRemoveHyperlinks.UseVisualStyleBackColor = true;
            // 
            // chkPackDocument
            // 
            this.chkPackDocument.AutoSize = true;
            this.chkPackDocument.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkPackDocument.Location = new System.Drawing.Point(34, 172);
            this.chkPackDocument.Name = "chkPackDocument";
            this.chkPackDocument.Size = new System.Drawing.Size(137, 17);
            this.chkPackDocument.TabIndex = 10;
            this.chkPackDocument.Text = "Discard unused objects";
            this.chkPackDocument.UseVisualStyleBackColor = true;
            // 
            // lbDocumentContent
            // 
            this.lbDocumentContent.AutoSize = true;
            this.lbDocumentContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDocumentContent.Location = new System.Drawing.Point(15, 106);
            this.lbDocumentContent.Name = "lbDocumentContent";
            this.lbDocumentContent.Size = new System.Drawing.Size(98, 13);
            this.lbDocumentContent.TabIndex = 9;
            this.lbDocumentContent.Text = "Document content:";
            // 
            // lbInteractiveContent
            // 
            this.lbInteractiveContent.AutoSize = true;
            this.lbInteractiveContent.Location = new System.Drawing.Point(15, 15);
            this.lbInteractiveContent.Name = "lbInteractiveContent";
            this.lbInteractiveContent.Size = new System.Drawing.Size(99, 13);
            this.lbInteractiveContent.TabIndex = 8;
            this.lbInteractiveContent.Text = "Interactive content:";
            // 
            // chkRemoveEmbeddedFiles
            // 
            this.chkRemoveEmbeddedFiles.AutoSize = true;
            this.chkRemoveEmbeddedFiles.Location = new System.Drawing.Point(34, 149);
            this.chkRemoveEmbeddedFiles.Name = "chkRemoveEmbeddedFiles";
            this.chkRemoveEmbeddedFiles.Size = new System.Drawing.Size(140, 17);
            this.chkRemoveEmbeddedFiles.TabIndex = 7;
            this.chkRemoveEmbeddedFiles.Text = "Remove embedded files";
            this.chkRemoveEmbeddedFiles.UseVisualStyleBackColor = true;
            // 
            // chkRemoveBookmarks
            // 
            this.chkRemoveBookmarks.AutoSize = true;
            this.chkRemoveBookmarks.Location = new System.Drawing.Point(34, 126);
            this.chkRemoveBookmarks.Name = "chkRemoveBookmarks";
            this.chkRemoveBookmarks.Size = new System.Drawing.Size(121, 17);
            this.chkRemoveBookmarks.TabIndex = 6;
            this.chkRemoveBookmarks.Text = "Remove bookmarks";
            this.chkRemoveBookmarks.UseVisualStyleBackColor = true;
            // 
            // chkRemoveFormFields
            // 
            this.chkRemoveFormFields.AutoSize = true;
            this.chkRemoveFormFields.Location = new System.Drawing.Point(34, 35);
            this.chkRemoveFormFields.Name = "chkRemoveFormFields";
            this.chkRemoveFormFields.Size = new System.Drawing.Size(113, 17);
            this.chkRemoveFormFields.TabIndex = 4;
            this.chkRemoveFormFields.Text = "Remove formfields";
            this.chkRemoveFormFields.UseVisualStyleBackColor = true;
            // 
            // chkRemoveAnnotations
            // 
            this.chkRemoveAnnotations.AutoSize = true;
            this.chkRemoveAnnotations.Location = new System.Drawing.Point(34, 58);
            this.chkRemoveAnnotations.Name = "chkRemoveAnnotations";
            this.chkRemoveAnnotations.Size = new System.Drawing.Size(124, 17);
            this.chkRemoveAnnotations.TabIndex = 5;
            this.chkRemoveAnnotations.Text = "Remove annotations";
            this.chkRemoveAnnotations.UseVisualStyleBackColor = true;
            // 
            // tabOutputFormat
            // 
            this.tabOutputFormat.Controls.Add(this.chkKeepWriteAcessTime);
            this.tabOutputFormat.Controls.Add(this.cmbPreferredVersion);
            this.tabOutputFormat.Controls.Add(this.lbPreferredVersion);
            this.tabOutputFormat.Controls.Add(this.chkFastWebView);
            this.tabOutputFormat.Location = new System.Drawing.Point(4, 22);
            this.tabOutputFormat.Name = "tabOutputFormat";
            this.tabOutputFormat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabOutputFormat.Size = new System.Drawing.Size(485, 217);
            this.tabOutputFormat.TabIndex = 3;
            this.tabOutputFormat.Text = "Output Format";
            this.tabOutputFormat.UseVisualStyleBackColor = true;
            // 
            // chkKeepWriteAcessTime
            // 
            this.chkKeepWriteAcessTime.AutoSize = true;
            this.chkKeepWriteAcessTime.Location = new System.Drawing.Point(15, 63);
            this.chkKeepWriteAcessTime.Name = "chkKeepWriteAcessTime";
            this.chkKeepWriteAcessTime.Size = new System.Drawing.Size(184, 17);
            this.chkKeepWriteAcessTime.TabIndex = 4;
            this.chkKeepWriteAcessTime.Text = "Keep last access and edition time";
            this.chkKeepWriteAcessTime.UseVisualStyleBackColor = true;
            // 
            // cmbPreferredVersion
            // 
            this.cmbPreferredVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreferredVersion.FormattingEnabled = true;
            this.cmbPreferredVersion.Location = new System.Drawing.Point(107, 13);
            this.cmbPreferredVersion.Name = "cmbPreferredVersion";
            this.cmbPreferredVersion.Size = new System.Drawing.Size(121, 21);
            this.cmbPreferredVersion.TabIndex = 3;
            // 
            // lbPreferredVersion
            // 
            this.lbPreferredVersion.Location = new System.Drawing.Point(12, 16);
            this.lbPreferredVersion.Name = "lbPreferredVersion";
            this.lbPreferredVersion.Size = new System.Drawing.Size(100, 23);
            this.lbPreferredVersion.TabIndex = 5;
            this.lbPreferredVersion.Text = "Preferred version:";
            // 
            // chkFastWebView
            // 
            this.chkFastWebView.AutoSize = true;
            this.chkFastWebView.Location = new System.Drawing.Point(15, 40);
            this.chkFastWebView.Name = "chkFastWebView";
            this.chkFastWebView.Size = new System.Drawing.Size(127, 17);
            this.chkFastWebView.TabIndex = 1;
            this.chkFastWebView.Text = "Enable fast web view";
            this.chkFastWebView.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(3, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(490, 1);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pdfReducerCloud.Properties.Resources.banner_pdf_reducer_cloud;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // toolTipPreferredVersion
            // 
            this.toolTipPreferredVersion.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 344);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmOptions";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCompression.ResumeLayout(false);
            this.tabCompression.PerformLayout();
            this.tabBitmap.ResumeLayout(false);
            this.tabBitmap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDownscaleResolution)).EndInit();
            this.tabContentRemoval.ResumeLayout(false);
            this.tabContentRemoval.PerformLayout();
            this.tabOutputFormat.ResumeLayout(false);
            this.tabOutputFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOnlyPdf;
        private System.Windows.Forms.CheckBox chkDeleteOriginalFileOnSuccess;
        private System.Windows.Forms.CheckBox chkEnableColorDetection;
        private System.Windows.Forms.TabPage tabCompression;
        private System.Windows.Forms.TabPage tabBitmap;
        private System.Windows.Forms.Label lbQuality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nuDownscaleResolution;
        private System.Windows.Forms.Label lbResolution;
        private System.Windows.Forms.TabPage tabOutputFormat;
        private System.Windows.Forms.CheckBox chkFastWebView;
        private System.Windows.Forms.TabPage tabContentRemoval;
        private System.Windows.Forms.CheckBox chkRemoveEmbeddedFiles;
        private System.Windows.Forms.CheckBox chkRemoveBookmarks;
        private System.Windows.Forms.CheckBox chkRemoveFormFields;
        private System.Windows.Forms.CheckBox chkRemoveAnnotations;
        private System.Windows.Forms.ComboBox cmbPreferredVersion;
        private System.Windows.Forms.Label lbPreferredVersion;
        private System.Windows.Forms.ComboBox cmbImageQuality;
        private System.Windows.Forms.CheckBox chkJPEG2000;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkKeepWriteAcessTime;
        private System.Windows.Forms.ToolTip toolTipPreferredVersion;
        private System.Windows.Forms.CheckBox chkPackDocument;
        private System.Windows.Forms.Label lbDocumentContent;
        private System.Windows.Forms.Label lbInteractiveContent;
        private System.Windows.Forms.CheckBox chkCharRepair;
        private System.Windows.Forms.CheckBox chkUseMRC;
        private System.Windows.Forms.CheckBox chkRecompressImages;
        private System.Windows.Forms.CheckBox chkDownscaleImages;
        private System.Windows.Forms.CheckBox chkRemoveHyperlinks;
        private System.Windows.Forms.Label lbDpi;
        private System.Windows.Forms.CheckBox chkPackFonts;
        private System.Windows.Forms.CheckBox chkJBIG2;
        private System.Windows.Forms.CheckBox chkRemoveBlankPages;
    }
}