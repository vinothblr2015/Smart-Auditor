namespace Auditor
{
    partial class FrmViewContractors
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
            this.GrdViewContractors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewContractors)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdViewContractors
            // 
            this.GrdViewContractors.AllowUserToAddRows = false;
            this.GrdViewContractors.AllowUserToDeleteRows = false;
            this.GrdViewContractors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdViewContractors.Location = new System.Drawing.Point(23, 23);
            this.GrdViewContractors.Name = "GrdViewContractors";
            this.GrdViewContractors.ReadOnly = true;
            this.GrdViewContractors.Size = new System.Drawing.Size(427, 413);
            this.GrdViewContractors.TabIndex = 104;
            // 
            // FrmViewContractors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 458);
            this.Controls.Add(this.GrdViewContractors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmViewContractors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض بيانات المقاولين";
            this.Load += new System.EventHandler(this.FrmViewContractors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewContractors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrdViewContractors;
    }
}