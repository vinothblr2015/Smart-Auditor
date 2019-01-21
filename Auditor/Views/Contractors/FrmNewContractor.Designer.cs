namespace Auditor.Views.Contractors
{
    partial class FrmNewContractor
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
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(119, 51);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(405, 81);
            this.TxtNotes.TabIndex = 1;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(22, 50);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(71, 31);
            this.label41.TabIndex = 57;
            this.label41.Text = "ملاحظات";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtName.Location = new System.Drawing.Point(119, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(405, 29);
            this.TxtName.TabIndex = 0;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(22, 11);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(82, 31);
            this.label42.TabIndex = 55;
            this.label42.Text = "اسم المقاول";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(302, 154);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 33);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "إلـغــاء";
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Location = new System.Drawing.Point(130, 154);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(114, 33);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "حــفــظ";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmNewContractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 218);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label42);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmNewContractor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة بيانات مقاول";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
    }
}