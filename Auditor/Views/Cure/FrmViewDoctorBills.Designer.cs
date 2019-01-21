namespace Auditor
{
    partial class FrmViewDoctorBills
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
            this.BtnSearchDoctor = new System.Windows.Forms.Button();
            this.BtnSearchPayDate = new System.Windows.Forms.Button();
            this.BtnSearchLocation = new System.Windows.Forms.Button();
            this.BtnSearchDocNo = new System.Windows.Forms.Button();
            this.GrdViewDoctorBills = new System.Windows.Forms.DataGridView();
            this.ComboDoctor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DatePay = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.TxtDocNo = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new Auditor.AuditorDataSetTableAdapters.DoctorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewDoctorBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearchDoctor
            // 
            this.BtnSearchDoctor.Enabled = false;
            this.BtnSearchDoctor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchDoctor.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchDoctor.Location = new System.Drawing.Point(361, 134);
            this.BtnSearchDoctor.Name = "BtnSearchDoctor";
            this.BtnSearchDoctor.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchDoctor.TabIndex = 238;
            this.BtnSearchDoctor.Text = "بحث";
            this.BtnSearchDoctor.UseVisualStyleBackColor = true;
            this.BtnSearchDoctor.Click += new System.EventHandler(this.BtnSearchDoctor_Click);
            // 
            // BtnSearchPayDate
            // 
            this.BtnSearchPayDate.Enabled = false;
            this.BtnSearchPayDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchPayDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchPayDate.Location = new System.Drawing.Point(361, 56);
            this.BtnSearchPayDate.Name = "BtnSearchPayDate";
            this.BtnSearchPayDate.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchPayDate.TabIndex = 237;
            this.BtnSearchPayDate.Text = "بحث";
            this.BtnSearchPayDate.UseVisualStyleBackColor = true;
            this.BtnSearchPayDate.Click += new System.EventHandler(this.BtnSearchPayDate_Click);
            // 
            // BtnSearchLocation
            // 
            this.BtnSearchLocation.Enabled = false;
            this.BtnSearchLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchLocation.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchLocation.Location = new System.Drawing.Point(361, 95);
            this.BtnSearchLocation.Name = "BtnSearchLocation";
            this.BtnSearchLocation.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchLocation.TabIndex = 236;
            this.BtnSearchLocation.Text = "بحث";
            this.BtnSearchLocation.UseVisualStyleBackColor = true;
            this.BtnSearchLocation.Click += new System.EventHandler(this.BtnSearchLocation_Click);
            // 
            // BtnSearchDocNo
            // 
            this.BtnSearchDocNo.Enabled = false;
            this.BtnSearchDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchDocNo.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchDocNo.Location = new System.Drawing.Point(361, 17);
            this.BtnSearchDocNo.Name = "BtnSearchDocNo";
            this.BtnSearchDocNo.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchDocNo.TabIndex = 235;
            this.BtnSearchDocNo.Text = "بحث";
            this.BtnSearchDocNo.UseVisualStyleBackColor = true;
            this.BtnSearchDocNo.Click += new System.EventHandler(this.BtnSearchDocNo_Click);
            // 
            // GrdViewDoctorBills
            // 
            this.GrdViewDoctorBills.AllowUserToAddRows = false;
            this.GrdViewDoctorBills.AllowUserToDeleteRows = false;
            this.GrdViewDoctorBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdViewDoctorBills.Location = new System.Drawing.Point(21, 179);
            this.GrdViewDoctorBills.Name = "GrdViewDoctorBills";
            this.GrdViewDoctorBills.ReadOnly = true;
            this.GrdViewDoctorBills.Size = new System.Drawing.Size(886, 422);
            this.GrdViewDoctorBills.TabIndex = 234;
            // 
            // ComboDoctor
            // 
            this.ComboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboDoctor.DataSource = this.doctorBindingSource;
            this.ComboDoctor.DisplayMember = "Name";
            this.ComboDoctor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboDoctor.FormattingEnabled = true;
            this.ComboDoctor.Location = new System.Drawing.Point(142, 136);
            this.ComboDoctor.Name = "ComboDoctor";
            this.ComboDoctor.Size = new System.Drawing.Size(196, 30);
            this.ComboDoctor.TabIndex = 229;
            this.ComboDoctor.ValueMember = "ID";
            this.ComboDoctor.TextChanged += new System.EventHandler(this.ComboDoctor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(26, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 31);
            this.label4.TabIndex = 233;
            this.label4.Text = "اسم المركز";
            // 
            // ComboLocation
            // 
            this.ComboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "Name";
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(142, 97);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(196, 30);
            this.ComboLocation.TabIndex = 228;
            this.ComboLocation.ValueMember = "LocationID";
            this.ComboLocation.TextChanged += new System.EventHandler(this.ComboLocation_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(26, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 232;
            this.label1.Text = "الجهة التابع لها";
            // 
            // DatePay
            // 
            this.DatePay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePay.Location = new System.Drawing.Point(142, 56);
            this.DatePay.Name = "DatePay";
            this.DatePay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePay.RightToLeftLayout = true;
            this.DatePay.Size = new System.Drawing.Size(196, 29);
            this.DatePay.TabIndex = 227;
            this.DatePay.Enter += new System.EventHandler(this.DatePay_Enter);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label45.Location = new System.Drawing.Point(26, 57);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(101, 31);
            this.label45.TabIndex = 231;
            this.label45.Text = "تاريخ الصرف";
            // 
            // TxtDocNo
            // 
            this.TxtDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDocNo.Location = new System.Drawing.Point(142, 19);
            this.TxtDocNo.Name = "TxtDocNo";
            this.TxtDocNo.Size = new System.Drawing.Size(196, 29);
            this.TxtDocNo.TabIndex = 226;
            this.TxtDocNo.TextChanged += new System.EventHandler(this.TxtDocNo_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(26, 18);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(81, 31);
            this.label42.TabIndex = 230;
            this.label42.Text = "رقم المستند";
            // 
            // auditorDataSet
            // 
            this.auditorDataSet.DataSetName = "AuditorDataSet";
            this.auditorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.auditorDataSet;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // FrmViewDoctorBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 618);
            this.Controls.Add(this.BtnSearchDoctor);
            this.Controls.Add(this.BtnSearchPayDate);
            this.Controls.Add(this.BtnSearchLocation);
            this.Controls.Add(this.BtnSearchDocNo);
            this.Controls.Add(this.GrdViewDoctorBills);
            this.Controls.Add(this.ComboDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatePay);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.TxtDocNo);
            this.Controls.Add(this.label42);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmViewDoctorBills";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض مطالبات المراكز الطبية";
            this.Load += new System.EventHandler(this.FrmViewDoctorBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewDoctorBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearchDoctor;
        private System.Windows.Forms.Button BtnSearchPayDate;
        private System.Windows.Forms.Button BtnSearchLocation;
        private System.Windows.Forms.Button BtnSearchDocNo;
        private System.Windows.Forms.DataGridView GrdViewDoctorBills;
        private System.Windows.Forms.ComboBox ComboDoctor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatePay;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox TxtDocNo;
        private System.Windows.Forms.Label label42;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private AuditorDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
    }
}