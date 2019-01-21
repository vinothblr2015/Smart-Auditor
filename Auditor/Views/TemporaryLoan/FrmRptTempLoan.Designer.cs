namespace Auditor.Views.TemporaryLoan
{
    partial class FrmRptTempLoan
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
            this.RptViewerTempLoans = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // RptViewerTempLoans
            // 
            this.RptViewerTempLoans.ActiveViewIndex = -1;
            this.RptViewerTempLoans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RptViewerTempLoans.Cursor = System.Windows.Forms.Cursors.Default;
            this.RptViewerTempLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptViewerTempLoans.Location = new System.Drawing.Point(0, 0);
            this.RptViewerTempLoans.Name = "RptViewerTempLoans";
            this.RptViewerTempLoans.ReuseParameterValuesOnRefresh = true;
            this.RptViewerTempLoans.ShowCloseButton = false;
            this.RptViewerTempLoans.ShowGroupTreeButton = false;
            this.RptViewerTempLoans.ShowLogo = false;
            this.RptViewerTempLoans.ShowParameterPanelButton = false;
            this.RptViewerTempLoans.Size = new System.Drawing.Size(1335, 586);
            this.RptViewerTempLoans.TabIndex = 0;
            this.RptViewerTempLoans.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmRptTempLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 586);
            this.Controls.Add(this.RptViewerTempLoans);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Name = "FrmRptTempLoan";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير السلف المؤقتة";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RptViewerTempLoans;
    }
}