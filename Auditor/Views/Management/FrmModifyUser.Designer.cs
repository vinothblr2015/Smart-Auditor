namespace Auditor.Views.Management
{
    partial class FrmModifyUser
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
            this.CheckLocked = new System.Windows.Forms.CheckBox();
            this.CheckDisabled = new System.Windows.Forms.CheckBox();
            this.TxtTelephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboUserGroups = new System.Windows.Forms.ComboBox();
            this.userGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.ComboUserName = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.usersTableAdapter = new Auditor.AuditorDataSetTableAdapters.UsersTableAdapter();
            this.userGroupsTableAdapter = new Auditor.AuditorDataSetTableAdapters.UserGroupsTableAdapter();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckLocked
            // 
            this.CheckLocked.AutoSize = true;
            this.CheckLocked.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.CheckLocked.Location = new System.Drawing.Point(161, 366);
            this.CheckLocked.Name = "CheckLocked";
            this.CheckLocked.Size = new System.Drawing.Size(63, 36);
            this.CheckLocked.TabIndex = 9;
            this.CheckLocked.Text = "معلق";
            this.CheckLocked.UseVisualStyleBackColor = true;
            this.CheckLocked.CheckedChanged += new System.EventHandler(this.CheckLocked_CheckedChanged);
            // 
            // CheckDisabled
            // 
            this.CheckDisabled.AutoSize = true;
            this.CheckDisabled.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.CheckDisabled.Location = new System.Drawing.Point(163, 327);
            this.CheckDisabled.Name = "CheckDisabled";
            this.CheckDisabled.Size = new System.Drawing.Size(69, 36);
            this.CheckDisabled.TabIndex = 8;
            this.CheckDisabled.Text = "معطل";
            this.CheckDisabled.UseVisualStyleBackColor = true;
            this.CheckDisabled.CheckedChanged += new System.EventHandler(this.CheckDisabled_CheckedChanged);
            // 
            // TxtTelephone
            // 
            this.TxtTelephone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTelephone.Location = new System.Drawing.Point(163, 183);
            this.TxtTelephone.MaxLength = 12;
            this.TxtTelephone.Name = "TxtTelephone";
            this.TxtTelephone.Size = new System.Drawing.Size(165, 29);
            this.TxtTelephone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(22, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 32);
            this.label5.TabIndex = 126;
            this.label5.Text = "التليفون";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPassword.Location = new System.Drawing.Point(163, 255);
            this.TxtPassword.MaxLength = 150;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(243, 29);
            this.TxtPassword.TabIndex = 6;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(22, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 32);
            this.label2.TabIndex = 125;
            this.label2.Text = "كلمة السر";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtUserName.Location = new System.Drawing.Point(163, 219);
            this.TxtUserName.MaxLength = 150;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(243, 29);
            this.TxtUserName.TabIndex = 5;
            this.TxtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(22, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 32);
            this.label6.TabIndex = 124;
            this.label6.Text = "اسم المستخدم";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtLastName.Location = new System.Drawing.Point(163, 92);
            this.TxtLastName.MaxLength = 150;
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(243, 29);
            this.TxtLastName.TabIndex = 2;
            this.TxtLastName.TextChanged += new System.EventHandler(this.TxtLastName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(22, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 123;
            this.label1.Text = "الاسم الأخير";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(406, 512);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(98, 33);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Text = "خروج";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(115, 417);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(469, 81);
            this.TxtNotes.TabIndex = 10;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(16, 416);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 32);
            this.label41.TabIndex = 122;
            this.label41.Text = "ملاحظات";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtAddress.Location = new System.Drawing.Point(163, 128);
            this.TxtAddress.MaxLength = 250;
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAddress.Size = new System.Drawing.Size(415, 48);
            this.TxtAddress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(22, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 32);
            this.label4.TabIndex = 121;
            this.label4.Text = "العنوان";
            // 
            // ComboUserGroups
            // 
            this.ComboUserGroups.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboUserGroups.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboUserGroups.DataSource = this.userGroupsBindingSource;
            this.ComboUserGroups.DisplayMember = "Name";
            this.ComboUserGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboUserGroups.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboUserGroups.FormattingEnabled = true;
            this.ComboUserGroups.Location = new System.Drawing.Point(163, 291);
            this.ComboUserGroups.Name = "ComboUserGroups";
            this.ComboUserGroups.Size = new System.Drawing.Size(209, 30);
            this.ComboUserGroups.TabIndex = 7;
            this.ComboUserGroups.ValueMember = "GroupID";
            this.ComboUserGroups.SelectedIndexChanged += new System.EventHandler(this.ComboUserGroups_SelectedIndexChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(22, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 120;
            this.label3.Text = "مجموعة المستخدمين";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtFirstName.Location = new System.Drawing.Point(163, 54);
            this.TxtFirstName.MaxLength = 150;
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(243, 29);
            this.TxtFirstName.TabIndex = 1;
            this.TxtFirstName.TextChanged += new System.EventHandler(this.TxtFirstName_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(22, 53);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(82, 32);
            this.label42.TabIndex = 119;
            this.label42.Text = "الاسم الأول";
            // 
            // ComboUserName
            // 
            this.ComboUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboUserName.DataSource = this.usersBindingSource;
            this.ComboUserName.DisplayMember = "UserName";
            this.ComboUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboUserName.FormattingEnabled = true;
            this.ComboUserName.Location = new System.Drawing.Point(161, 16);
            this.ComboUserName.Name = "ComboUserName";
            this.ComboUserName.Size = new System.Drawing.Size(211, 30);
            this.ComboUserName.TabIndex = 0;
            this.ComboUserName.ValueMember = "ID";
            this.ComboUserName.SelectedIndexChanged += new System.EventHandler(this.ComboUserName_SelectedIndexChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.auditorDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(16, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 32);
            this.label7.TabIndex = 128;
            this.label7.Text = "اسم المستخدم";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // userGroupsTableAdapter
            // 
            this.userGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Location = new System.Drawing.Point(251, 512);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 33);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "حـذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(96, 512);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "تـحـديـث";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // FrmModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 557);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.ComboUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CheckLocked);
            this.Controls.Add(this.CheckDisabled);
            this.Controls.Add(this.TxtTelephone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboUserGroups);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.label42);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmModifyUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات مستخدم";
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckLocked;
        private System.Windows.Forms.CheckBox CheckDisabled;
        private System.Windows.Forms.TextBox TxtTelephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboUserGroups;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox ComboUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private AuditorDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource userGroupsBindingSource;
        private AuditorDataSetTableAdapters.UserGroupsTableAdapter userGroupsTableAdapter;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
    }
}