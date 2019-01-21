namespace Auditor.Views.Employees
{
    partial class FrmModifyEmployee
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
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.employeeTableAdapter = new Auditor.AuditorDataSetTableAdapters.EmployeeTableAdapter();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.TxtTelephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboPosition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboDegree = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.auditorDataSet;
            // 
            // auditorDataSet
            // 
            this.auditorDataSet.DataSetName = "AuditorDataSet";
            this.auditorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Location = new System.Drawing.Point(283, 333);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 33);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "حـذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(71, 333);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "تـحـديـث";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(19, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 32);
            this.label6.TabIndex = 120;
            this.label6.Text = "اسم الموظف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(355, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 114;
            this.label1.Text = "الجهة التابع لها";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(495, 333);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 33);
            this.BtnClose.TabIndex = 11;
            this.BtnClose.Text = "إلـغــاء";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(133, 222);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(531, 81);
            this.TxtNotes.TabIndex = 8;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(19, 221);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 32);
            this.label41.TabIndex = 119;
            this.label41.Text = "ملاحظات";
            // 
            // TxtTelephone
            // 
            this.TxtTelephone.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTelephone.Location = new System.Drawing.Point(133, 184);
            this.TxtTelephone.MaxLength = 12;
            this.TxtTelephone.Name = "TxtTelephone";
            this.TxtTelephone.Size = new System.Drawing.Size(179, 29);
            this.TxtTelephone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(19, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 32);
            this.label5.TabIndex = 118;
            this.label5.Text = "التليفون";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtAddress.Location = new System.Drawing.Point(133, 129);
            this.TxtAddress.MaxLength = 250;
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAddress.Size = new System.Drawing.Size(529, 48);
            this.TxtAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(19, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 32);
            this.label4.TabIndex = 117;
            this.label4.Text = "العنوان";
            // 
            // ComboPosition
            // 
            this.ComboPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboPosition.DisplayMember = "Name";
            this.ComboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPosition.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboPosition.FormattingEnabled = true;
            this.ComboPosition.Items.AddRange(new object[] {
            "رئيس مجلس الإدارة",
            "عضو مجلس إدارة",
            "رئيس قطاعات",
            "رئيس قطاع",
            "مدير عام",
            "مدير إدارة",
            "مهندس",
            "محاسب",
            "فني"});
            this.ComboPosition.Location = new System.Drawing.Point(465, 57);
            this.ComboPosition.Name = "ComboPosition";
            this.ComboPosition.Size = new System.Drawing.Size(197, 30);
            this.ComboPosition.TabIndex = 5;
            this.ComboPosition.ValueMember = "LocationID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(355, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 32);
            this.label3.TabIndex = 116;
            this.label3.Text = "الوظيفة";
            // 
            // ComboDegree
            // 
            this.ComboDegree.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboDegree.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboDegree.DisplayMember = "Name";
            this.ComboDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDegree.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboDegree.FormattingEnabled = true;
            this.ComboDegree.Items.AddRange(new object[] {
            "الدرجة السادسة",
            "الدرجة الخامسة",
            "الدرجة الرابعة",
            "الدرجة الثالثة",
            "الدرجة الثانية",
            "الدرجة الأولى",
            "كبير"});
            this.ComboDegree.Location = new System.Drawing.Point(133, 92);
            this.ComboDegree.Name = "ComboDegree";
            this.ComboDegree.Size = new System.Drawing.Size(216, 30);
            this.ComboDegree.TabIndex = 4;
            this.ComboDegree.ValueMember = "LocationID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(19, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 115;
            this.label2.Text = "الدرجة الوظيفية";
            // 
            // ComboLocation
            // 
            this.ComboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "LocationName";
            this.ComboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(465, 22);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(197, 30);
            this.ComboLocation.TabIndex = 3;
            this.ComboLocation.ValueMember = "LocationID";
            this.ComboLocation.SelectedIndexChanged += new System.EventHandler(this.ComboLocation_SelectedIndexChanged);
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.auditorDataSet;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtName.Location = new System.Drawing.Point(133, 57);
            this.TxtName.MaxLength = 250;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(216, 29);
            this.TxtName.TabIndex = 2;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(19, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 32);
            this.label7.TabIndex = 122;
            this.label7.Text = "اسم الموظف";
            // 
            // ComboName
            // 
            this.ComboName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboName.DataSource = this.employeeBindingSource;
            this.ComboName.DisplayMember = "EmployeeName";
            this.ComboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboName.FormattingEnabled = true;
            this.ComboName.Location = new System.Drawing.Point(133, 21);
            this.ComboName.Name = "ComboName";
            this.ComboName.Size = new System.Drawing.Size(216, 30);
            this.ComboName.TabIndex = 0;
            this.ComboName.ValueMember = "EmployeeID";
            this.ComboName.SelectedIndexChanged += new System.EventHandler(this.ComboName_SelectedIndexChanged);
            // 
            // FrmModifyEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.ComboName);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.TxtTelephone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboDegree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmModifyEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحديث بيانات الموظفين";
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private AuditorDataSet auditorDataSet;
        private Auditor.AuditorDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox TxtTelephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboDegree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private Auditor.AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboName;

    }
}