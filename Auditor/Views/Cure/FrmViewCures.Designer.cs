namespace Auditor
{
    partial class FrmViewCures
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
            this.BtnSearchEmployee = new System.Windows.Forms.Button();
            this.BtnSearchPayDate = new System.Windows.Forms.Button();
            this.BtnSearchLocation = new System.Windows.Forms.Button();
            this.BtnSearchDocNo = new System.Windows.Forms.Button();
            this.ComboName = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DatePay = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.TxtDocNo = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.GrdViewCure = new System.Windows.Forms.DataGridView();
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            this.employeeTableAdapter = new Auditor.AuditorDataSetTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewCure)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearchEmployee
            // 
            this.BtnSearchEmployee.Enabled = false;
            this.BtnSearchEmployee.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchEmployee.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchEmployee.Location = new System.Drawing.Point(589, 127);
            this.BtnSearchEmployee.Name = "BtnSearchEmployee";
            this.BtnSearchEmployee.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchEmployee.TabIndex = 126;
            this.BtnSearchEmployee.Text = "بحث";
            this.BtnSearchEmployee.UseVisualStyleBackColor = true;
            this.BtnSearchEmployee.Click += new System.EventHandler(this.BtnSearchEmployee_Click);
            // 
            // BtnSearchPayDate
            // 
            this.BtnSearchPayDate.Enabled = false;
            this.BtnSearchPayDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchPayDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchPayDate.Location = new System.Drawing.Point(589, 49);
            this.BtnSearchPayDate.Name = "BtnSearchPayDate";
            this.BtnSearchPayDate.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchPayDate.TabIndex = 125;
            this.BtnSearchPayDate.Text = "بحث";
            this.BtnSearchPayDate.UseVisualStyleBackColor = true;
            this.BtnSearchPayDate.Click += new System.EventHandler(this.BtnSearchPayDate_Click);
            // 
            // BtnSearchLocation
            // 
            this.BtnSearchLocation.Enabled = false;
            this.BtnSearchLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchLocation.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchLocation.Location = new System.Drawing.Point(589, 88);
            this.BtnSearchLocation.Name = "BtnSearchLocation";
            this.BtnSearchLocation.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchLocation.TabIndex = 124;
            this.BtnSearchLocation.Text = "بحث";
            this.BtnSearchLocation.UseVisualStyleBackColor = true;
            this.BtnSearchLocation.Click += new System.EventHandler(this.BtnSearchLocation_Click);
            // 
            // BtnSearchDocNo
            // 
            this.BtnSearchDocNo.Enabled = false;
            this.BtnSearchDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchDocNo.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchDocNo.Location = new System.Drawing.Point(589, 10);
            this.BtnSearchDocNo.Name = "BtnSearchDocNo";
            this.BtnSearchDocNo.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchDocNo.TabIndex = 123;
            this.BtnSearchDocNo.Text = "بحث";
            this.BtnSearchDocNo.UseVisualStyleBackColor = true;
            this.BtnSearchDocNo.Click += new System.EventHandler(this.BtnSearchDocNo_Click);
            // 
            // ComboName
            // 
            this.ComboName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboName.DataSource = this.employeeBindingSource;
            this.ComboName.DisplayMember = "Name";
            this.ComboName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboName.FormattingEnabled = true;
            this.ComboName.Location = new System.Drawing.Point(370, 129);
            this.ComboName.Name = "ComboName";
            this.ComboName.Size = new System.Drawing.Size(196, 30);
            this.ComboName.TabIndex = 118;
            this.ComboName.ValueMember = "EmployeeID";
            this.ComboName.TextChanged += new System.EventHandler(this.ComboName_TextChanged);
            this.ComboName.Enter += new System.EventHandler(this.ComboName_Enter);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(254, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 122;
            this.label4.Text = "اسم الموظف";
            // 
            // ComboLocation
            // 
            this.ComboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "Name";
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(370, 90);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(196, 30);
            this.ComboLocation.TabIndex = 117;
            this.ComboLocation.ValueMember = "LocationID";
            this.ComboLocation.TextChanged += new System.EventHandler(this.ComboLocation_TextChanged);
            this.ComboLocation.Enter += new System.EventHandler(this.ComboLocation_Enter);
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.auditorDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(254, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 121;
            this.label1.Text = "الجهة التابع لها";
            // 
            // DatePay
            // 
            this.DatePay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePay.Location = new System.Drawing.Point(370, 49);
            this.DatePay.Name = "DatePay";
            this.DatePay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePay.RightToLeftLayout = true;
            this.DatePay.Size = new System.Drawing.Size(196, 29);
            this.DatePay.TabIndex = 116;
            this.DatePay.Enter += new System.EventHandler(this.DatePay_Enter);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label45.Location = new System.Drawing.Point(254, 50);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(101, 31);
            this.label45.TabIndex = 120;
            this.label45.Text = "تاريخ الصرف";
            // 
            // TxtDocNo
            // 
            this.TxtDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDocNo.Location = new System.Drawing.Point(370, 12);
            this.TxtDocNo.Name = "TxtDocNo";
            this.TxtDocNo.Size = new System.Drawing.Size(196, 29);
            this.TxtDocNo.TabIndex = 115;
            this.TxtDocNo.TextChanged += new System.EventHandler(this.TxtDocNo_TextChanged);
            this.TxtDocNo.Enter += new System.EventHandler(this.TxtDocNo_Enter);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(254, 11);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(81, 31);
            this.label42.TabIndex = 119;
            this.label42.Text = "رقم المستند";
            // 
            // GrdViewCure
            // 
            this.GrdViewCure.AllowUserToAddRows = false;
            this.GrdViewCure.AllowUserToDeleteRows = false;
            this.GrdViewCure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdViewCure.Location = new System.Drawing.Point(30, 178);
            this.GrdViewCure.Name = "GrdViewCure";
            this.GrdViewCure.ReadOnly = true;
            this.GrdViewCure.Size = new System.Drawing.Size(881, 429);
            this.GrdViewCure.TabIndex = 127;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewCures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 634);
            this.Controls.Add(this.GrdViewCure);
            this.Controls.Add(this.BtnSearchEmployee);
            this.Controls.Add(this.BtnSearchPayDate);
            this.Controls.Add(this.BtnSearchLocation);
            this.Controls.Add(this.BtnSearchDocNo);
            this.Controls.Add(this.ComboName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatePay);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.TxtDocNo);
            this.Controls.Add(this.label42);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmViewCures";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عرض مستندات العلاج الفردي";
            this.Load += new System.EventHandler(this.FrmViewCures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewCure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearchEmployee;
        private System.Windows.Forms.Button BtnSearchPayDate;
        private System.Windows.Forms.Button BtnSearchLocation;
        private System.Windows.Forms.Button BtnSearchDocNo;
        private System.Windows.Forms.ComboBox ComboName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatePay;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox TxtDocNo;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DataGridView GrdViewCure;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private AuditorDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}