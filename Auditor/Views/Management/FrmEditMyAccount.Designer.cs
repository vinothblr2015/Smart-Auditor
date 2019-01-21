namespace Auditor.Views.Management
{
    partial class FrmEditMyAccount
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
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Auditor.AuditorDataSetTableAdapters.UsersTableAdapter();
            this.userGroupsTableAdapter = new Auditor.AuditorDataSetTableAdapters.UserGroupsTableAdapter();
            this.TxtTelephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.TxtCurrentPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // auditorDataSet
            // 
            this.auditorDataSet.DataSetName = "AuditorDataSet";
            this.auditorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(169, 302);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdate.TabIndex = 137;
            this.BtnUpdate.Text = "تـحـديـث";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.auditorDataSet;
            // 
            // userGroupsBindingSource
            // 
            this.userGroupsBindingSource.DataMember = "UserGroups";
            this.userGroupsBindingSource.DataSource = this.auditorDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // userGroupsTableAdapter
            // 
            this.userGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // TxtTelephone
            // 
            this.TxtTelephone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTelephone.Location = new System.Drawing.Point(163, 184);
            this.TxtTelephone.MaxLength = 12;
            this.TxtTelephone.Name = "TxtTelephone";
            this.TxtTelephone.Size = new System.Drawing.Size(165, 29);
            this.TxtTelephone.TabIndex = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(22, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 31);
            this.label5.TabIndex = 147;
            this.label5.Text = "التليفون";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPassword.Location = new System.Drawing.Point(163, 256);
            this.TxtPassword.MaxLength = 150;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(243, 29);
            this.TxtPassword.TabIndex = 132;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(22, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 146;
            this.label2.Text = "كلمة السر";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtUserName.Location = new System.Drawing.Point(163, 220);
            this.TxtUserName.MaxLength = 150;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(243, 29);
            this.TxtUserName.TabIndex = 131;
            this.TxtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(22, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 31);
            this.label6.TabIndex = 145;
            this.label6.Text = "اسم المستخدم";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtLastName.Location = new System.Drawing.Point(163, 93);
            this.TxtLastName.MaxLength = 150;
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(243, 29);
            this.TxtLastName.TabIndex = 128;
            this.TxtLastName.TextChanged += new System.EventHandler(this.TxtLastName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(22, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 144;
            this.label1.Text = "الاسم الأخير";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(333, 302);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(98, 33);
            this.BtnClose.TabIndex = 139;
            this.BtnClose.Text = "خروج";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtAddress.Location = new System.Drawing.Point(163, 129);
            this.TxtAddress.MaxLength = 250;
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAddress.Size = new System.Drawing.Size(415, 48);
            this.TxtAddress.TabIndex = 129;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(22, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 31);
            this.label4.TabIndex = 142;
            this.label4.Text = "العنوان";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtFirstName.Location = new System.Drawing.Point(163, 55);
            this.TxtFirstName.MaxLength = 150;
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(243, 29);
            this.TxtFirstName.TabIndex = 127;
            this.TxtFirstName.TextChanged += new System.EventHandler(this.TxtFirstName_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(22, 54);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(82, 31);
            this.label42.TabIndex = 140;
            this.label42.Text = "الاسم الأول";
            // 
            // TxtCurrentPassword
            // 
            this.TxtCurrentPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtCurrentPassword.Location = new System.Drawing.Point(163, 15);
            this.TxtCurrentPassword.MaxLength = 150;
            this.TxtCurrentPassword.Name = "TxtCurrentPassword";
            this.TxtCurrentPassword.PasswordChar = '*';
            this.TxtCurrentPassword.Size = new System.Drawing.Size(243, 29);
            this.TxtCurrentPassword.TabIndex = 148;
            this.TxtCurrentPassword.TextChanged += new System.EventHandler(this.TxtCurrentPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 149;
            this.label3.Text = "كلمة السر الحالية";
            // 
            // FrmEditMyAccount
            // 
            this.AcceptButton = this.BtnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(600, 358);
            this.Controls.Add(this.TxtCurrentPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.TxtTelephone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.label42);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmEditMyAccount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات حسابي";
            this.Load += new System.EventHandler(this.FrmEditMyAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGroupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource userGroupsBindingSource;
        private AuditorDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private AuditorDataSetTableAdapters.UserGroupsTableAdapter userGroupsTableAdapter;
        private System.Windows.Forms.TextBox TxtTelephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox TxtCurrentPassword;
        private System.Windows.Forms.Label label3;
    }
}