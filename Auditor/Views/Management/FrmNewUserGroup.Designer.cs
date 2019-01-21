namespace Auditor.Views.Management
{
    partial class FrmNewUserGroup
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
            this.CheckEdit = new System.Windows.Forms.CheckBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.CheckAdd = new System.Windows.Forms.CheckBox();
            this.CheckView = new System.Windows.Forms.CheckBox();
            this.CheckAdmin = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckEdit
            // 
            this.CheckEdit.AutoSize = true;
            this.CheckEdit.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.CheckEdit.Location = new System.Drawing.Point(286, 106);
            this.CheckEdit.Name = "CheckEdit";
            this.CheckEdit.Size = new System.Drawing.Size(175, 36);
            this.CheckEdit.TabIndex = 100;
            this.CheckEdit.Text = "تعديل وحذف المستندات";
            this.CheckEdit.UseVisualStyleBackColor = true;
            this.CheckEdit.CheckedChanged += new System.EventHandler(this.CheckEdit_CheckedChanged);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(320, 371);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(98, 33);
            this.BtnClose.TabIndex = 103;
            this.BtnClose.Text = "خروج";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnAdd.Location = new System.Drawing.Point(189, 371);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(98, 33);
            this.BtnAdd.TabIndex = 102;
            this.BtnAdd.Text = "إضافة";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(118, 269);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(469, 81);
            this.TxtNotes.TabIndex = 101;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(19, 268);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 32);
            this.label41.TabIndex = 105;
            this.label41.Text = "ملاحظات";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtName.Location = new System.Drawing.Point(172, 13);
            this.TxtName.MaxLength = 150;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(243, 29);
            this.TxtName.TabIndex = 99;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(31, 12);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(95, 32);
            this.label42.TabIndex = 104;
            this.label42.Text = "اسم المجموعة";
            // 
            // CheckAdd
            // 
            this.CheckAdd.AutoSize = true;
            this.CheckAdd.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.CheckAdd.Location = new System.Drawing.Point(298, 65);
            this.CheckAdd.Name = "CheckAdd";
            this.CheckAdd.Size = new System.Drawing.Size(165, 36);
            this.CheckAdd.TabIndex = 106;
            this.CheckAdd.Text = "إضافة مستندات جديدة";
            this.CheckAdd.UseVisualStyleBackColor = true;
            this.CheckAdd.CheckedChanged += new System.EventHandler(this.CheckAdd_CheckedChanged);
            // 
            // CheckView
            // 
            this.CheckView.AutoSize = true;
            this.CheckView.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.CheckView.Location = new System.Drawing.Point(324, 147);
            this.CheckView.Name = "CheckView";
            this.CheckView.Size = new System.Drawing.Size(136, 36);
            this.CheckView.TabIndex = 107;
            this.CheckView.Text = "عرض المستندات";
            this.CheckView.UseVisualStyleBackColor = true;
            this.CheckView.CheckedChanged += new System.EventHandler(this.CheckView_CheckedChanged);
            // 
            // CheckAdmin
            // 
            this.CheckAdmin.AutoSize = true;
            this.CheckAdmin.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.CheckAdmin.Location = new System.Drawing.Point(347, 24);
            this.CheckAdmin.Name = "CheckAdmin";
            this.CheckAdmin.Size = new System.Drawing.Size(108, 36);
            this.CheckAdmin.TabIndex = 108;
            this.CheckAdmin.Text = "إدارة البرنامج";
            this.CheckAdmin.UseVisualStyleBackColor = true;
            this.CheckAdmin.CheckedChanged += new System.EventHandler(this.CheckAdmin_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckAdmin);
            this.groupBox1.Controls.Add(this.CheckEdit);
            this.groupBox1.Controls.Add(this.CheckView);
            this.groupBox1.Controls.Add(this.CheckAdd);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 199);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "صلاحيات المجموعة";
            // 
            // FrmNewUserGroup
            // 
            this.AcceptButton = this.BtnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(606, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label42);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmNewUserGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مجوعة مستخدمين جديدة";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckEdit;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.CheckBox CheckAdd;
        private System.Windows.Forms.CheckBox CheckView;
        private System.Windows.Forms.CheckBox CheckAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}