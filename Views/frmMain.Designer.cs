using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using PassportPDF.Tools.WinForm.Views;

namespace pdfReducerCloud.Views
{
    partial class frmMain : frmMainBase, IPDFReducerCloudMainView
    {
        // Form overrides dispose to clean up the component list.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }


        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.lbCompRatioPct = new System.Windows.Forms.Label();
            this.lbCompRatio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCompRatioPct
            // 
            this.lbCompRatioPct.AutoSize = true;
            this.lbCompRatioPct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompRatioPct.Location = new System.Drawing.Point(426, 88);
            this.lbCompRatioPct.Name = "lbCompRatioPct";
            this.lbCompRatioPct.Size = new System.Drawing.Size(70, 24);
            this.lbCompRatioPct.TabIndex = 37;
            this.lbCompRatioPct.Text = "99.99%";
            this.lbCompRatioPct.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbCompRatio
            // 
            this.lbCompRatio.AutoSize = true;
            this.lbCompRatio.Location = new System.Drawing.Point(343, 94);
            this.lbCompRatio.Name = "lbCompRatio";
            this.lbCompRatio.Size = new System.Drawing.Size(82, 13);
            this.lbCompRatio.TabIndex = 36;
            this.lbCompRatio.Text = "Reduction ratio:";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(497, 388);
            this.Controls.Add(this.lbCompRatio);
            this.Controls.Add(this.lbCompRatioPct);
            this.Name = "frmMain";
            this.Controls.SetChildIndex(this.lbCompRatioPct, 0);
            this.Controls.SetChildIndex(this.lbCompRatio, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Label lbCompRatioPct;
        private Label lbCompRatio;
    }
}