namespace Auditor
{
    partial class FrmViewTransFees
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
            this.GrdViewTransFees = new System.Windows.Forms.DataGridView();
            this.BtnSearchDocNo = new System.Windows.Forms.Button();
            this.BtnSearchLocation = new System.Windows.Forms.Button();
            this.BtnSearchPayDate = new System.Windows.Forms.Button();
            this.BtnSearchEmployee = new System.Windows.Forms.Button();
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            this.employeeTableAdapter = new Auditor.AuditorDataSetTableAdapters.EmployeeTableAdapter();
            this.TxtTotalTrans = new System.Windows.Forms.TextBox();
            this.LblTotalTrans = new System.Windows.Forms.Label();
            this.TxtTotalTravel = new System.Windows.Forms.TextBox();
            this.LblTotalTravel = new System.Windows.Forms.Label();
            this.LblPound2 = new System.Windows.Forms.Label();
            this.LblPound1 = new System.Windows.Forms.Label();
            this.GroupInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCountRec = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewTransFees)).BeginInit();
            this.GroupInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboName
            // 
            this.ComboName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboName.DataSource = this.employeeBindingSource;
            this.ComboName.DisplayMember = "EmployeeName";
            this.ComboName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboName.FormattingEnabled = true;
            this.ComboName.Location = new System.Drawing.Point(145, 137);
            this.ComboName.Name = "ComboName";
            this.ComboName.Size = new System.Drawing.Size(196, 30);
            this.ComboName.TabIndex = 6;
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
            this.label4.Location = new System.Drawing.Point(29, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 32);
            this.label4.TabIndex = 96;
            this.label4.Text = "اسم الموظف";
            // 
            // ComboLocation
            // 
            this.ComboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "LocationName";
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(145, 98);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(196, 30);
            this.ComboLocation.TabIndex = 4;
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
            this.label1.Location = new System.Drawing.Point(29, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 95;
            this.label1.Text = "الجهة التابع لها";
            // 
            // DatePay
            // 
            this.DatePay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePay.Location = new System.Drawing.Point(145, 57);
            this.DatePay.Name = "DatePay";
            this.DatePay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePay.RightToLeftLayout = true;
            this.DatePay.Size = new System.Drawing.Size(196, 29);
            this.DatePay.TabIndex = 2;
            this.DatePay.CloseUp += new System.EventHandler(this.DatePay_CloseUp);
            this.DatePay.Enter += new System.EventHandler(this.DatePay_Enter);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label45.Location = new System.Drawing.Point(29, 58);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 32);
            this.label45.TabIndex = 94;
            this.label45.Text = "تاريخ الصرف";
            // 
            // TxtDocNo
            // 
            this.TxtDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDocNo.Location = new System.Drawing.Point(145, 20);
            this.TxtDocNo.Name = "TxtDocNo";
            this.TxtDocNo.Size = new System.Drawing.Size(196, 29);
            this.TxtDocNo.TabIndex = 0;
            this.TxtDocNo.TextChanged += new System.EventHandler(this.TxtDocNo_TextChanged);
            this.TxtDocNo.Enter += new System.EventHandler(this.TxtDocNo_Enter);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(29, 19);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(79, 32);
            this.label42.TabIndex = 93;
            this.label42.Text = "رقم المستند";
            // 
            // GrdViewTransFees
            // 
            this.GrdViewTransFees.AllowUserToAddRows = false;
            this.GrdViewTransFees.AllowUserToDeleteRows = false;
            this.GrdViewTransFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GrdViewTransFees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GrdViewTransFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrdViewTransFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdViewTransFees.Location = new System.Drawing.Point(24, 180);
            this.GrdViewTransFees.Name = "GrdViewTransFees";
            this.GrdViewTransFees.ReadOnly = true;
            this.GrdViewTransFees.Size = new System.Drawing.Size(886, 422);
            this.GrdViewTransFees.TabIndex = 9;
            // 
            // BtnSearchDocNo
            // 
            this.BtnSearchDocNo.Enabled = false;
            this.BtnSearchDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchDocNo.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchDocNo.Location = new System.Drawing.Point(364, 18);
            this.BtnSearchDocNo.Name = "BtnSearchDocNo";
            this.BtnSearchDocNo.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchDocNo.TabIndex = 1;
            this.BtnSearchDocNo.Text = "بحث";
            this.BtnSearchDocNo.UseVisualStyleBackColor = true;
            this.BtnSearchDocNo.Click += new System.EventHandler(this.BtnSearchDocNo_Click);
            // 
            // BtnSearchLocation
            // 
            this.BtnSearchLocation.Enabled = false;
            this.BtnSearchLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchLocation.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchLocation.Location = new System.Drawing.Point(364, 96);
            this.BtnSearchLocation.Name = "BtnSearchLocation";
            this.BtnSearchLocation.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchLocation.TabIndex = 5;
            this.BtnSearchLocation.Text = "بحث";
            this.BtnSearchLocation.UseVisualStyleBackColor = true;
            this.BtnSearchLocation.Click += new System.EventHandler(this.BtnSearchLocation_Click);
            // 
            // BtnSearchPayDate
            // 
            this.BtnSearchPayDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchPayDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchPayDate.Location = new System.Drawing.Point(364, 57);
            this.BtnSearchPayDate.Name = "BtnSearchPayDate";
            this.BtnSearchPayDate.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchPayDate.TabIndex = 3;
            this.BtnSearchPayDate.Text = "بحث";
            this.BtnSearchPayDate.UseVisualStyleBackColor = true;
            this.BtnSearchPayDate.Click += new System.EventHandler(this.BtnSearchPayDate_Click);
            // 
            // BtnSearchEmployee
            // 
            this.BtnSearchEmployee.Enabled = false;
            this.BtnSearchEmployee.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchEmployee.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchEmployee.Location = new System.Drawing.Point(364, 135);
            this.BtnSearchEmployee.Name = "BtnSearchEmployee";
            this.BtnSearchEmployee.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchEmployee.TabIndex = 7;
            this.BtnSearchEmployee.Text = "بحث";
            this.BtnSearchEmployee.UseVisualStyleBackColor = true;
            this.BtnSearchEmployee.Click += new System.EventHandler(this.BtnSearchEmployee_Click);
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // TxtTotalTrans
            // 
            this.TxtTotalTrans.Enabled = false;
            this.TxtTotalTrans.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTotalTrans.Location = new System.Drawing.Point(79, 52);
            this.TxtTotalTrans.Name = "TxtTotalTrans";
            this.TxtTotalTrans.Size = new System.Drawing.Size(115, 29);
            this.TxtTotalTrans.TabIndex = 102;
            this.TxtTotalTrans.Visible = false;
            // 
            // LblTotalTrans
            // 
            this.LblTotalTrans.AutoSize = true;
            this.LblTotalTrans.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblTotalTrans.Location = new System.Drawing.Point(200, 49);
            this.LblTotalTrans.Name = "LblTotalTrans";
            this.LblTotalTrans.Size = new System.Drawing.Size(131, 32);
            this.LblTotalTrans.TabIndex = 103;
            this.LblTotalTrans.Text = "إجمالي بدل الانتقال";
            this.LblTotalTrans.Visible = false;
            // 
            // TxtTotalTravel
            // 
            this.TxtTotalTravel.Enabled = false;
            this.TxtTotalTravel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTotalTravel.Location = new System.Drawing.Point(79, 87);
            this.TxtTotalTravel.Name = "TxtTotalTravel";
            this.TxtTotalTravel.Size = new System.Drawing.Size(115, 29);
            this.TxtTotalTravel.TabIndex = 104;
            this.TxtTotalTravel.Visible = false;
            // 
            // LblTotalTravel
            // 
            this.LblTotalTravel.AutoSize = true;
            this.LblTotalTravel.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblTotalTravel.Location = new System.Drawing.Point(211, 80);
            this.LblTotalTravel.Name = "LblTotalTravel";
            this.LblTotalTravel.Size = new System.Drawing.Size(120, 32);
            this.LblTotalTravel.TabIndex = 105;
            this.LblTotalTravel.Text = "إجمالي بدل السفر";
            this.LblTotalTravel.Visible = false;
            // 
            // LblPound2
            // 
            this.LblPound2.AutoSize = true;
            this.LblPound2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblPound2.Location = new System.Drawing.Point(23, 85);
            this.LblPound2.Name = "LblPound2";
            this.LblPound2.Size = new System.Drawing.Size(42, 32);
            this.LblPound2.TabIndex = 106;
            this.LblPound2.Text = "جنيه";
            this.LblPound2.Visible = false;
            // 
            // LblPound1
            // 
            this.LblPound1.AutoSize = true;
            this.LblPound1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblPound1.Location = new System.Drawing.Point(23, 50);
            this.LblPound1.Name = "LblPound1";
            this.LblPound1.Size = new System.Drawing.Size(42, 32);
            this.LblPound1.TabIndex = 107;
            this.LblPound1.Text = "جنيه";
            this.LblPound1.Visible = false;
            // 
            // GroupInfo
            // 
            this.GroupInfo.Controls.Add(this.label2);
            this.GroupInfo.Controls.Add(this.LblTotalTrans);
            this.GroupInfo.Controls.Add(this.TxtCountRec);
            this.GroupInfo.Controls.Add(this.LblPound2);
            this.GroupInfo.Controls.Add(this.LblPound1);
            this.GroupInfo.Controls.Add(this.LblTotalTravel);
            this.GroupInfo.Controls.Add(this.TxtTotalTrans);
            this.GroupInfo.Controls.Add(this.TxtTotalTravel);
            this.GroupInfo.Location = new System.Drawing.Point(561, 18);
            this.GroupInfo.Name = "GroupInfo";
            this.GroupInfo.Size = new System.Drawing.Size(349, 149);
            this.GroupInfo.TabIndex = 8;
            this.GroupInfo.TabStop = false;
            this.GroupInfo.Text = "إحصائيات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(235, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 109;
            this.label2.Text = "عدد السجلات";
            // 
            // TxtCountRec
            // 
            this.TxtCountRec.Enabled = false;
            this.TxtCountRec.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtCountRec.Location = new System.Drawing.Point(79, 16);
            this.TxtCountRec.Name = "TxtCountRec";
            this.TxtCountRec.Size = new System.Drawing.Size(115, 29);
            this.TxtCountRec.TabIndex = 108;
            // 
            // FrmViewTransFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 624);
            this.Controls.Add(this.GroupInfo);
            this.Controls.Add(this.BtnSearchEmployee);
            this.Controls.Add(this.BtnSearchPayDate);
            this.Controls.Add(this.BtnSearchLocation);
            this.Controls.Add(this.BtnSearchDocNo);
            this.Controls.Add(this.GrdViewTransFees);
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
            this.Name = "FrmViewTransFees";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض مستندات بدل الانتقال والسفر";
            this.Load += new System.EventHandler(this.FrmViewTransFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewTransFees)).EndInit();
            this.GroupInfo.ResumeLayout(false);
            this.GroupInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatePay;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox TxtDocNo;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DataGridView GrdViewTransFees;
        private System.Windows.Forms.Button BtnSearchDocNo;
        private System.Windows.Forms.Button BtnSearchLocation;
        private System.Windows.Forms.Button BtnSearchPayDate;
        private System.Windows.Forms.Button BtnSearchEmployee;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private AuditorDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.TextBox TxtTotalTrans;
        private System.Windows.Forms.Label LblTotalTrans;
        private System.Windows.Forms.TextBox TxtTotalTravel;
        private System.Windows.Forms.Label LblTotalTravel;
        private System.Windows.Forms.Label LblPound2;
        private System.Windows.Forms.Label LblPound1;
        private System.Windows.Forms.GroupBox GroupInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCountRec;
    }
}