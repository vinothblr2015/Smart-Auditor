namespace Auditor
{
    partial class FrmViewProjects
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
            this.BtnSearchReservedStatus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboReservedStatues = new System.Windows.Forms.ComboBox();
            this.BtnSearchInsuranceStatues = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.ComboInsuranceStatus = new System.Windows.Forms.ComboBox();
            this.BtnSearchContractor = new System.Windows.Forms.Button();
            this.BtnSearchPayDate = new System.Windows.Forms.Button();
            this.BtnSearchLocation = new System.Windows.Forms.Button();
            this.BtnSearchDocNo = new System.Windows.Forms.Button();
            this.GrdViewProject = new System.Windows.Forms.DataGridView();
            this.ComboContractor = new System.Windows.Forms.ComboBox();
            this.contractorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DatePay = new System.Windows.Forms.DateTimePicker();
            this.TxtDocNo = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            this.contractorTableAdapter = new Auditor.AuditorDataSetTableAdapters.ContractorTableAdapter();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.btnPrintSelected = new System.Windows.Forms.Button();
            this.btnPrintViewed = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearchReservedStatus
            // 
            this.BtnSearchReservedStatus.Enabled = false;
            this.BtnSearchReservedStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchReservedStatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchReservedStatus.Location = new System.Drawing.Point(809, 95);
            this.BtnSearchReservedStatus.Name = "BtnSearchReservedStatus";
            this.BtnSearchReservedStatus.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchReservedStatus.TabIndex = 244;
            this.BtnSearchReservedStatus.Text = "بحث";
            this.BtnSearchReservedStatus.UseVisualStyleBackColor = true;
            this.BtnSearchReservedStatus.Click += new System.EventHandler(this.BtnSearchReservedStatus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(484, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 243;
            this.label2.Text = "حالة المبالغ المعلاة";
            // 
            // ComboReservedStatues
            // 
            this.ComboReservedStatues.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboReservedStatues.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboReservedStatues.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboReservedStatues.FormattingEnabled = true;
            this.ComboReservedStatues.Items.AddRange(new object[] {
            "تم الرد",
            "لم يتم الرد"});
            this.ComboReservedStatues.Location = new System.Drawing.Point(616, 97);
            this.ComboReservedStatues.Name = "ComboReservedStatues";
            this.ComboReservedStatues.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboReservedStatues.Size = new System.Drawing.Size(187, 30);
            this.ComboReservedStatues.TabIndex = 242;
            this.ComboReservedStatues.TextChanged += new System.EventHandler(this.ComboReservedStatues_TextChanged);
            // 
            // BtnSearchInsuranceStatues
            // 
            this.BtnSearchInsuranceStatues.Enabled = false;
            this.BtnSearchInsuranceStatues.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchInsuranceStatues.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchInsuranceStatues.Location = new System.Drawing.Point(809, 56);
            this.BtnSearchInsuranceStatues.Name = "BtnSearchInsuranceStatues";
            this.BtnSearchInsuranceStatues.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchInsuranceStatues.TabIndex = 241;
            this.BtnSearchInsuranceStatues.Text = "بحث";
            this.BtnSearchInsuranceStatues.UseVisualStyleBackColor = true;
            this.BtnSearchInsuranceStatues.Click += new System.EventHandler(this.BtnSearchInsuranceStatues_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(484, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 32);
            this.label18.TabIndex = 240;
            this.label18.Text = "حالة التأمين النهائي";
            // 
            // ComboInsuranceStatus
            // 
            this.ComboInsuranceStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboInsuranceStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboInsuranceStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboInsuranceStatus.FormattingEnabled = true;
            this.ComboInsuranceStatus.Items.AddRange(new object[] {
            "تم الرد",
            "لم يتم الرد"});
            this.ComboInsuranceStatus.Location = new System.Drawing.Point(616, 58);
            this.ComboInsuranceStatus.Name = "ComboInsuranceStatus";
            this.ComboInsuranceStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboInsuranceStatus.Size = new System.Drawing.Size(187, 30);
            this.ComboInsuranceStatus.TabIndex = 239;
            this.ComboInsuranceStatus.TextChanged += new System.EventHandler(this.ComboInsuranceStatus_TextChanged);
            // 
            // BtnSearchContractor
            // 
            this.BtnSearchContractor.Enabled = false;
            this.BtnSearchContractor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchContractor.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSearchContractor.Location = new System.Drawing.Point(809, 17);
            this.BtnSearchContractor.Name = "BtnSearchContractor";
            this.BtnSearchContractor.Size = new System.Drawing.Size(98, 33);
            this.BtnSearchContractor.TabIndex = 238;
            this.BtnSearchContractor.Text = "بحث";
            this.BtnSearchContractor.UseVisualStyleBackColor = true;
            this.BtnSearchContractor.Click += new System.EventHandler(this.BtnSearchContractor_Click);
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
            // GrdViewProject
            // 
            this.GrdViewProject.AllowUserToAddRows = false;
            this.GrdViewProject.AllowUserToDeleteRows = false;
            this.GrdViewProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdViewProject.Location = new System.Drawing.Point(21, 141);
            this.GrdViewProject.Name = "GrdViewProject";
            this.GrdViewProject.ReadOnly = true;
            this.GrdViewProject.Size = new System.Drawing.Size(886, 422);
            this.GrdViewProject.TabIndex = 234;
            // 
            // ComboContractor
            // 
            this.ComboContractor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboContractor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboContractor.DataSource = this.contractorBindingSource;
            this.ComboContractor.DisplayMember = "Name";
            this.ComboContractor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboContractor.FormattingEnabled = true;
            this.ComboContractor.Location = new System.Drawing.Point(616, 19);
            this.ComboContractor.Name = "ComboContractor";
            this.ComboContractor.Size = new System.Drawing.Size(187, 30);
            this.ComboContractor.TabIndex = 229;
            this.ComboContractor.ValueMember = "ContractorID";
            this.ComboContractor.TextChanged += new System.EventHandler(this.ComboContractor_TextChanged);
            // 
            // contractorBindingSource
            // 
            this.contractorBindingSource.DataMember = "Contractor";
            this.contractorBindingSource.DataSource = this.auditorDataSet;
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
            this.label4.Location = new System.Drawing.Point(474, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 233;
            this.label4.Text = "اسم المقاول";
            // 
            // ComboLocation
            // 
            this.ComboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "LocationName";
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(142, 97);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(196, 30);
            this.ComboLocation.TabIndex = 228;
            this.ComboLocation.ValueMember = "LocationID";
            this.ComboLocation.TextChanged += new System.EventHandler(this.ComboLocation_TextChanged);
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
            this.label1.Location = new System.Drawing.Point(26, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
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
            this.DatePay.ValueChanged += new System.EventHandler(this.DatePay_ValueChanged);
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
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label45.Location = new System.Drawing.Point(26, 57);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 32);
            this.label45.TabIndex = 231;
            this.label45.Text = "تاريخ الصرف";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(26, 18);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(79, 32);
            this.label42.TabIndex = 230;
            this.label42.Text = "رقم المستند";
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // contractorTableAdapter
            // 
            this.contractorTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAll.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPrintAll.Location = new System.Drawing.Point(481, 573);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(196, 33);
            this.btnPrintAll.TabIndex = 246;
            this.btnPrintAll.Text = "طباعة كافة المستندات";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // btnPrintSelected
            // 
            this.btnPrintSelected.Enabled = false;
            this.btnPrintSelected.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSelected.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPrintSelected.Location = new System.Drawing.Point(249, 573);
            this.btnPrintSelected.Name = "btnPrintSelected";
            this.btnPrintSelected.Size = new System.Drawing.Size(196, 33);
            this.btnPrintSelected.TabIndex = 245;
            this.btnPrintSelected.Text = "طباعة المستند المحدد";
            this.btnPrintSelected.UseVisualStyleBackColor = true;
            this.btnPrintSelected.Click += new System.EventHandler(this.btnPrintSelected_Click);
            // 
            // btnPrintViewed
            // 
            this.btnPrintViewed.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintViewed.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPrintViewed.Location = new System.Drawing.Point(21, 573);
            this.btnPrintViewed.Name = "btnPrintViewed";
            this.btnPrintViewed.Size = new System.Drawing.Size(196, 33);
            this.btnPrintViewed.TabIndex = 247;
            this.btnPrintViewed.Text = "طباعة المستندات المعروضة";
            this.btnPrintViewed.UseVisualStyleBackColor = true;
            this.btnPrintViewed.Click += new System.EventHandler(this.btnPrintViewed_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(711, 573);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(196, 33);
            this.btnClose.TabIndex = 248;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmViewProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 618);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrintViewed);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.btnPrintSelected);
            this.Controls.Add(this.BtnSearchReservedStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboReservedStatues);
            this.Controls.Add(this.BtnSearchInsuranceStatues);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ComboInsuranceStatus);
            this.Controls.Add(this.BtnSearchContractor);
            this.Controls.Add(this.BtnSearchPayDate);
            this.Controls.Add(this.BtnSearchLocation);
            this.Controls.Add(this.BtnSearchDocNo);
            this.Controls.Add(this.GrdViewProject);
            this.Controls.Add(this.ComboContractor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatePay);
            this.Controls.Add(this.TxtDocNo);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label42);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmViewProjects";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض المستخلصات";
            this.Load += new System.EventHandler(this.FrmViewProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearchReservedStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboReservedStatues;
        private System.Windows.Forms.Button BtnSearchInsuranceStatues;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox ComboInsuranceStatus;
        private System.Windows.Forms.Button BtnSearchContractor;
        private System.Windows.Forms.Button BtnSearchPayDate;
        private System.Windows.Forms.Button BtnSearchLocation;
        private System.Windows.Forms.Button BtnSearchDocNo;
        private System.Windows.Forms.DataGridView GrdViewProject;
        private System.Windows.Forms.ComboBox ComboContractor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatePay;
        private System.Windows.Forms.TextBox TxtDocNo;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label42;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource contractorBindingSource;
        private AuditorDataSetTableAdapters.ContractorTableAdapter contractorTableAdapter;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Button btnPrintSelected;
        private System.Windows.Forms.Button btnPrintViewed;
        private System.Windows.Forms.Button btnClose;
    }
}