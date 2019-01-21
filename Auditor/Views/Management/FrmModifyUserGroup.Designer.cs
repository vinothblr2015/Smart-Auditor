namespace Auditor.Views.Management
{
    partial class FrmModifyUserGroup
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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.ComboName = new System.Windows.Forms.ComboBox();
            this.userGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.CheckEdit = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckAdmin = new System.Windows.Forms.CheckBox();
            this.CheckView = new System.Windows.Forms.CheckBox();
            this.CheckAdd = new System.Windows.Forms.CheckBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.userGroupsTableAdapter = new Auditor.AuditorDataSetTableAdapters.UserGroupsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Location = new System.Drawing.Point(251, 405);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 33);
            this.BtnDelete.TabIndex = 131;
            this.BtnDelete.Text = "حـذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(97, 405);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdate.TabIndex = 130;
            this.BtnUpdate.Text = "تـحـديـث";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // ComboName
            // 
            this.ComboName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboName.DataSource = this.userGroupsBindingSource;
            this.ComboName.DisplayMember = "Name";
            this.ComboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboName.FormattingEnabled = true;
            this.ComboName.Location = new System.Drawing.Point(169, 14);
            this.ComboName.Name = "ComboName";
            this.ComboName.Size = new System.Drawing.Size(243, 30);
            this.ComboName.TabIndex = 129;
            this.ComboName.ValueMember = "ID";
            this.ComboName.SelectedIndexChanged += new System.EventHandler(this.ComboName_SelectedIndexChanged);
            // 
            // userGroupsBindingSource
            // 
            this.userGroupsBindingSource.DataMember = "UserGroups";
            this.userGroupsBindingSource.DataSource = this.auditorDataSet;
            // 
            // auditorDataSet
            // 
            this.auditorDataSet.DataSetName = "AuditorDataSet";
            this.auditorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(28, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 32);
            this.label7.TabIndex = 133;
            this.label7.Text = "اسم المجموعة";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(405, 405);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(98, 33);
            this.BtnClose.TabIndex = 132;
            this.BtnClose.Text = "خروج";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // CheckEdit
            // 
            this.CheckEdit.AutoSize = true;
            this.CheckEdit.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.CheckEdit.Location = new System.Drawing.Point(286, 98);
            this.CheckEdit.Name = "CheckEdit";
            this.CheckEdit.Size = new System.Drawing.Size(175, 36);
            this.CheckEdit.TabIndex = 100;
            this.CheckEdit.Text = "تعديل وحذف المستندات";
            this.CheckEdit.UseVisualStyleBackColor = true;
            this.CheckEdit.CheckedChanged += new System.EventHandler(this.CheckEdit_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckAdmin);
            this.groupBox1.Controls.Add(this.CheckEdit);
            this.groupBox1.Controls.Add(this.CheckView);
            this.groupBox1.Controls.Add(this.CheckAdd);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 199);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "صلاحيات المجموعة";
            // 
            // CheckAdmin
            // 
            this.CheckAdmin.AutoSize = true;
            this.CheckAdmin.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.CheckAdmin.Location = new System.Drawing.Point(347, 16);
            this.CheckAdmin.Name = "CheckAdmin";
            this.CheckAdmin.Size = new System.Drawing.Size(108, 36);
            this.CheckAdmin.TabIndex = 108;
            this.CheckAdmin.Text = "إدارة البرنامج";
            this.CheckAdmin.UseVisualStyleBackColor = true;
            this.CheckAdmin.CheckedChanged += new System.EventHandler(this.CheckAdmin_CheckedChanged);
            // 
            // CheckView
            // 
            this.CheckView.AutoSize = true;
            this.CheckView.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.CheckView.Location = new System.Drawing.Point(324, 139);
            this.CheckView.Name = "CheckView";
            this.CheckView.Size = new System.Drawing.Size(136, 36);
            this.CheckView.TabIndex = 107;
            this.CheckView.Text = "عرض المستندات";
            this.CheckView.UseVisualStyleBackColor = true;
            this.CheckView.CheckedChanged += new System.EventHandler(this.CheckView_CheckedChanged);
            // 
            // CheckAdd
            // 
            this.CheckAdd.AutoSize = true;
            this.CheckAdd.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.CheckAdd.Location = new System.Drawing.Point(298, 57);
            this.CheckAdd.Name = "CheckAdd";
            this.CheckAdd.Size = new System.Drawing.Size(165, 36);
            this.CheckAdd.TabIndex = 106;
            this.CheckAdd.Text = "إضافة مستندات جديدة";
            this.CheckAdd.UseVisualStyleBackColor = true;
            this.CheckAdd.CheckedChanged += new System.EventHandler(this.CheckAdd_CheckedChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(16, 307);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 32);
            this.label41.TabIndex = 137;
            this.label41.Text = "ملاحظات";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(28, 51);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(95, 32);
            this.label42.TabIndex = 136;
            this.label42.Text = "اسم المجموعة";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(115, 308);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(469, 81);
            this.TxtNotes.TabIndex = 135;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtName.Location = new System.Drawing.Point(169, 52);
            this.TxtName.MaxLength = 150;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(243, 29);
            this.TxtName.TabIndex = 134;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // userGroupsTableAdapter
            // 
            this.userGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmModifyUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.ComboName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmModifyUserGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات مجموعة مستخدمين";
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.ComboBox ComboName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.CheckBox CheckEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckAdmin;
        private System.Windows.Forms.CheckBox CheckView;
        private System.Windows.Forms.CheckBox CheckAdd;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.TextBox TxtName;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource userGroupsBindingSource;
        private AuditorDataSetTableAdapters.UserGroupsTableAdapter userGroupsTableAdapter;
    }
}