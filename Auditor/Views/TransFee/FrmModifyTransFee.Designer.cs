namespace Auditor.Views.TransFee
{
    partial class FrmModifyTransFee
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
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTravel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTrans = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboName = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPeriod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.TxtDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DatePay = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.ComboDocNo = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            this.BtnDeleteDocument = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new Auditor.AuditorDataSetTableAdapters.EmployeeTableAdapter();
            this.transFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transFeeTableAdapter = new Auditor.AuditorDataSetTableAdapters.TransFeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transFeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(570, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 32);
            this.label8.TabIndex = 116;
            this.label8.Text = "جنيه";
            // 
            // TxtTravel
            // 
            this.TxtTravel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTravel.Location = new System.Drawing.Point(430, 227);
            this.TxtTravel.Name = "TxtTravel";
            this.TxtTravel.Size = new System.Drawing.Size(134, 29);
            this.TxtTravel.TabIndex = 7;
            this.TxtTravel.TextChanged += new System.EventHandler(this.TxtTravel_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(270, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 32);
            this.label7.TabIndex = 115;
            this.label7.Text = "جنيه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(320, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 32);
            this.label6.TabIndex = 114;
            this.label6.Text = "بدل السفر";
            // 
            // TxtTrans
            // 
            this.TxtTrans.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTrans.Location = new System.Drawing.Point(130, 227);
            this.TxtTrans.Name = "TxtTrans";
            this.TxtTrans.Size = new System.Drawing.Size(134, 29);
            this.TxtTrans.TabIndex = 6;
            this.TxtTrans.TextChanged += new System.EventHandler(this.TxtTrans_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(14, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 32);
            this.label5.TabIndex = 113;
            this.label5.Text = "بدل الانتقال";
            // 
            // ComboName
            // 
            this.ComboName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboName.DataSource = this.employeeBindingSource;
            this.ComboName.DisplayMember = "EmployeeName";
            this.ComboName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboName.FormattingEnabled = true;
            this.ComboName.Location = new System.Drawing.Point(430, 62);
            this.ComboName.Name = "ComboName";
            this.ComboName.Size = new System.Drawing.Size(196, 30);
            this.ComboName.TabIndex = 3;
            this.ComboName.ValueMember = "EmployeeID";
            this.ComboName.SelectedIndexChanged += new System.EventHandler(this.ComboName_SelectedIndexChanged);
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
            this.label4.Location = new System.Drawing.Point(320, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 32);
            this.label4.TabIndex = 112;
            this.label4.Text = "اسم الموظف";
            // 
            // TxtPeriod
            // 
            this.TxtPeriod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPeriod.Location = new System.Drawing.Point(130, 194);
            this.TxtPeriod.MaxLength = 150;
            this.TxtPeriod.Name = "TxtPeriod";
            this.TxtPeriod.Size = new System.Drawing.Size(496, 29);
            this.TxtPeriod.TabIndex = 5;
            this.TxtPeriod.TextChanged += new System.EventHandler(this.TxtPeriod_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(14, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 32);
            this.label3.TabIndex = 111;
            this.label3.Text = "الفترة التي قضاها في المأمورية:";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(130, 280);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(496, 81);
            this.TxtNotes.TabIndex = 8;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(24, 257);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 32);
            this.label41.TabIndex = 110;
            this.label41.Text = "ملاحظات";
            // 
            // TxtDestination
            // 
            this.TxtDestination.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDestination.Location = new System.Drawing.Point(130, 128);
            this.TxtDestination.MaxLength = 150;
            this.TxtDestination.Name = "TxtDestination";
            this.TxtDestination.Size = new System.Drawing.Size(496, 29);
            this.TxtDestination.TabIndex = 4;
            this.TxtDestination.TextChanged += new System.EventHandler(this.TxtDestination_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 109;
            this.label2.Text = "الجهة التي مضى بها المأمورية:";
            // 
            // ComboLocation
            // 
            this.ComboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "LocationName";
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(430, 29);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(196, 30);
            this.ComboLocation.TabIndex = 2;
            this.ComboLocation.ValueMember = "LocationID";
            this.ComboLocation.SelectedIndexChanged += new System.EventHandler(this.ComboLocation_SelectedIndexChanged);
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
            this.label1.Location = new System.Drawing.Point(320, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 108;
            this.label1.Text = "الجهة التابع لها";
            // 
            // DatePay
            // 
            this.DatePay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePay.Location = new System.Drawing.Point(130, 62);
            this.DatePay.Name = "DatePay";
            this.DatePay.RightToLeftLayout = true;
            this.DatePay.Size = new System.Drawing.Size(174, 29);
            this.DatePay.TabIndex = 1;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label45.Location = new System.Drawing.Point(14, 61);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 32);
            this.label45.TabIndex = 107;
            this.label45.Text = "تاريخ الصرف";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(14, 28);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(79, 32);
            this.label42.TabIndex = 106;
            this.label42.Text = "رقم المستند";
            // 
            // ComboDocNo
            // 
            this.ComboDocNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboDocNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboDocNo.DataSource = this.transFeeBindingSource;
            this.ComboDocNo.DisplayMember = "DocNo";
            this.ComboDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboDocNo.FormattingEnabled = true;
            this.ComboDocNo.Location = new System.Drawing.Point(130, 29);
            this.ComboDocNo.Name = "ComboDocNo";
            this.ComboDocNo.Size = new System.Drawing.Size(174, 30);
            this.ComboDocNo.TabIndex = 0;
            this.ComboDocNo.ValueMember = "DocNo";
            this.ComboDocNo.SelectedIndexChanged += new System.EventHandler(this.ComboDocNo_SelectedIndexChanged);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Location = new System.Drawing.Point(190, 397);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 33);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "حـذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(482, 397);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 33);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "إلـغــاء";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(44, 397);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "تـحـديـث";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // BtnDeleteDocument
            // 
            this.BtnDeleteDocument.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteDocument.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDeleteDocument.Location = new System.Drawing.Point(336, 397);
            this.BtnDeleteDocument.Name = "BtnDeleteDocument";
            this.BtnDeleteDocument.Size = new System.Drawing.Size(114, 33);
            this.BtnDeleteDocument.TabIndex = 11;
            this.BtnDeleteDocument.Text = "حـذف المستند";
            this.BtnDeleteDocument.UseVisualStyleBackColor = true;
            this.BtnDeleteDocument.Click += new System.EventHandler(this.BtnDeleteDocument_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // transFeeBindingSource
            // 
            this.transFeeBindingSource.DataMember = "TransFee";
            this.transFeeBindingSource.DataSource = this.auditorDataSet;
            // 
            // transFeeTableAdapter
            // 
            this.transFeeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmModifyTransFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.BtnDeleteDocument);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.ComboDocNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtTravel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTrans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPeriod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.TxtDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DatePay);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label42);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmModifyTransFee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات بدل الانتقال والسفر";
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transFeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTravel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPeriod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox TxtDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatePay;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox ComboDocNo;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnUpdate;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private AuditorDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button BtnDeleteDocument;
        private System.Windows.Forms.BindingSource transFeeBindingSource;
        private AuditorDataSetTableAdapters.TransFeeTableAdapter transFeeTableAdapter;
    }
}