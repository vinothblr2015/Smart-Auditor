namespace Auditor.Views.Projects
{
    partial class FrmRptProjects
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
            this.rptViewerProjects = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptViewerProjects
            // 
            this.rptViewerProjects.ActiveViewIndex = -1;
            this.rptViewerProjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewerProjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewerProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewerProjects.Location = new System.Drawing.Point(0, 0);
            this.rptViewerProjects.Name = "rptViewerProjects";
            this.rptViewerProjects.ShowCloseButton = false;
            this.rptViewerProjects.ShowGroupTreeButton = false;
            this.rptViewerProjects.ShowLogo = false;
            this.rptViewerProjects.ShowParameterPanelButton = false;
            this.rptViewerProjects.Size = new System.Drawing.Size(1319, 547);
            this.rptViewerProjects.TabIndex = 0;
            this.rptViewerProjects.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // FrmRptProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 547);
            this.Controls.Add(this.rptViewerProjects);
            this.Name = "FrmRptProjects";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRptProjects";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewerProjects;
    }
}