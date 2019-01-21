namespace Auditor
{
    partial class FrmNewDoctor
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.TxtDoctor = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.ComboType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(294, 187);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 33);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.Text = "إلـغــاء";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Location = new System.Drawing.Point(132, 187);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(114, 33);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "حــفــظ";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(116, 81);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(405, 81);
            this.TxtNotes.TabIndex = 2;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(19, 80);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(71, 31);
            this.label41.TabIndex = 63;
            this.label41.Text = "ملاحظات";
            // 
            // TxtDoctor
            // 
            this.TxtDoctor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDoctor.Location = new System.Drawing.Point(116, 9);
            this.TxtDoctor.Name = "TxtDoctor";
            this.TxtDoctor.Size = new System.Drawing.Size(405, 29);
            this.TxtDoctor.TabIndex = 0;
            this.TxtDoctor.TextChanged += new System.EventHandler(this.TxtDoctor_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(19, 8);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(83, 31);
            this.label42.TabIndex = 62;
            this.label42.Text = "اسم الطبيب";
            // 
            // ComboType
            // 
            this.ComboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboType.DisplayMember = "UserName";
            this.ComboType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Items.AddRange(new object[] {
            "طبيب",
            "مركز"});
            this.ComboType.Location = new System.Drawing.Point(116, 44);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(211, 30);
            this.ComboType.TabIndex = 1;
            this.ComboType.ValueMember = "ID";
            this.ComboType.TextChanged += new System.EventHandler(this.ComboType_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(19, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 31);
            this.label7.TabIndex = 130;
            this.label7.Text = "النوع";
            // 
            // FrmNewDoctor
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(541, 242);
            this.Controls.Add(this.ComboType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.TxtDoctor);
            this.Controls.Add(this.label42);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmNewDoctor";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة الأطباء والمراكز";
            this.Load += new System.EventHandler(this.FrmNewDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox TxtDoctor;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox ComboType;
        private System.Windows.Forms.Label label7;
    }
}