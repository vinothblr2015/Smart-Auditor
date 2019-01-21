namespace Auditor.Views.Management
{
    partial class FrmNewUser
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
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
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
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTelephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckDisabled = new System.Windows.Forms.CheckBox();
            this.CheckLocked = new System.Windows.Forms.CheckBox();
            this.userGroupsTableAdapter = new Auditor.AuditorDataSetTableAdapters.UserGroupsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(351, 479);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(98, 33);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.Text = "خروج";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnAdd.Location = new System.Drawing.Point(220, 479);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(98, 33);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "إضافة";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(110, 384);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(469, 81);
            this.TxtNotes.TabIndex = 9;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(11, 383);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(71, 31);
            this.label41.TabIndex = 98;
            this.label41.Text = "ملاحظات";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtAddress.Location = new System.Drawing.Point(164, 95);
            this.TxtAddress.MaxLength = 250;
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAddress.Size = new System.Drawing.Size(415, 48);
            this.TxtAddress.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(23, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 31);
            this.label4.TabIndex = 96;
            this.label4.Text = "العنوان";
            // 
            // ComboUserGroups
            // 
            this.ComboUserGroups.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboUserGroups.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboUserGroups.DataSource = this.userGroupsBindingSource;
            this.ComboUserGroups.DisplayMember = "Name";
            this.ComboUserGroups.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboUserGroups.FormattingEnabled = true;
            this.ComboUserGroups.Location = new System.Drawing.Point(164, 258);
            this.ComboUserGroups.Name = "ComboUserGroups";
            this.ComboUserGroups.Size = new System.Drawing.Size(168, 30);
            this.ComboUserGroups.TabIndex = 6;
            this.ComboUserGroups.ValueMember = "GroupID";
            this.ComboUserGroups.TextChanged += new System.EventHandler(this.ComboUserGroups_TextChanged);
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
            this.label3.Location = new System.Drawing.Point(23, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 31);
            this.label3.TabIndex = 95;
            this.label3.Text = "مجموعة المستخدمين";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtFirstName.Location = new System.Drawing.Point(164, 23);
            this.TxtFirstName.MaxLength = 150;
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(243, 29);
            this.TxtFirstName.TabIndex = 0;
            this.TxtFirstName.TextChanged += new System.EventHandler(this.TxtFirstName_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(23, 22);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(82, 31);
            this.label42.TabIndex = 92;
            this.label42.Text = "الاسم الأول";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtLastName.Location = new System.Drawing.Point(164, 59);
            this.TxtLastName.MaxLength = 150;
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(243, 29);
            this.TxtLastName.TabIndex = 1;
            this.TxtLastName.TextChanged += new System.EventHandler(this.TxtLastName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 100;
            this.label1.Text = "الاسم الأخير";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtUserName.Location = new System.Drawing.Point(164, 186);
            this.TxtUserName.MaxLength = 150;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(243, 29);
            this.TxtUserName.TabIndex = 4;
            this.TxtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(23, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 31);
            this.label6.TabIndex = 102;
            this.label6.Text = "اسم المستخدم";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPassword.Location = new System.Drawing.Point(164, 222);
            this.TxtPassword.MaxLength = 150;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(243, 29);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(23, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 104;
            this.label2.Text = "كلمة السر";
            // 
            // TxtTelephone
            // 
            this.TxtTelephone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTelephone.Location = new System.Drawing.Point(164, 150);
            this.TxtTelephone.MaxLength = 12;
            this.TxtTelephone.Name = "TxtTelephone";
            this.TxtTelephone.Size = new System.Drawing.Size(165, 29);
            this.TxtTelephone.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(23, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 31);
            this.label5.TabIndex = 106;
            this.label5.Text = "التليفون";
            // 
            // CheckDisabled
            // 
            this.CheckDisabled.AutoSize = true;
            this.CheckDisabled.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.CheckDisabled.Location = new System.Drawing.Point(164, 294);
            this.CheckDisabled.Name = "CheckDisabled";
            this.CheckDisabled.Size = new System.Drawing.Size(68, 35);
            this.CheckDisabled.TabIndex = 7;
            this.CheckDisabled.Text = "معطل";
            this.CheckDisabled.UseVisualStyleBackColor = true;
            this.CheckDisabled.CheckedChanged += new System.EventHandler(this.CheckEnabled_CheckedChanged);
            // 
            // CheckLocked
            // 
            this.CheckLocked.AutoSize = true;
            this.CheckLocked.Font = new System.Drawing.Font("Simplified Arabic", 14.25F);
            this.CheckLocked.Location = new System.Drawing.Point(164, 333);
            this.CheckLocked.Name = "CheckLocked";
            this.CheckLocked.Size = new System.Drawing.Size(62, 35);
            this.CheckLocked.TabIndex = 8;
            this.CheckLocked.Text = "معلق";
            this.CheckLocked.UseVisualStyleBackColor = true;
            this.CheckLocked.CheckedChanged += new System.EventHandler(this.CheckLocked_CheckedChanged);
            // 
            // userGroupsTableAdapter
            // 
            this.userGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 515);
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
            this.Controls.Add(this.BtnAdd);
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
            this.Name = "FrmNewUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مستخدم جديد";
            this.Load += new System.EventHandler(this.FrmNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboUserGroups;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTelephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckDisabled;
        private System.Windows.Forms.CheckBox CheckLocked;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource userGroupsBindingSource;
        private AuditorDataSetTableAdapters.UserGroupsTableAdapter userGroupsTableAdapter;
    }
}