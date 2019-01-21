namespace Auditor
{
    partial class FrmModifyDoctorBill
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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtNetAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtTotalDiscount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtDiscounts = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPercent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTaxs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.DatePayDate = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.TxtDocNo = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.ComboDoctor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboDocNo = new System.Windows.Forms.ComboBox();
            this.doctorBillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.doctorBillsTableAdapter = new Auditor.AuditorDataSetTableAdapters.DoctorBillsTableAdapter();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new Auditor.AuditorDataSetTableAdapters.DoctorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBillsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(28, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 32);
            this.label12.TabIndex = 156;
            this.label12.Text = "صافي القيمة";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(304, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 32);
            this.label13.TabIndex = 155;
            this.label13.Text = "جنيه";
            // 
            // TxtNetAmount
            // 
            this.TxtNetAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNetAmount.Location = new System.Drawing.Point(152, 180);
            this.TxtNetAmount.Name = "TxtNetAmount";
            this.TxtNetAmount.ReadOnly = true;
            this.TxtNetAmount.Size = new System.Drawing.Size(146, 29);
            this.TxtNetAmount.TabIndex = 135;
            this.TxtNetAmount.TabStop = false;
            this.TxtNetAmount.Text = "0.00";
            this.TxtNetAmount.TextChanged += new System.EventHandler(this.TxtNetAmount_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(379, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 32);
            this.label10.TabIndex = 154;
            this.label10.Text = "إجمالي الاستقطاعات";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(662, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 32);
            this.label11.TabIndex = 153;
            this.label11.Text = "جنيه";
            // 
            // TxtTotalDiscount
            // 
            this.TxtTotalDiscount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTotalDiscount.Location = new System.Drawing.Point(522, 146);
            this.TxtTotalDiscount.Name = "TxtTotalDiscount";
            this.TxtTotalDiscount.ReadOnly = true;
            this.TxtTotalDiscount.Size = new System.Drawing.Size(137, 29);
            this.TxtTotalDiscount.TabIndex = 134;
            this.TxtTotalDiscount.TabStop = false;
            this.TxtTotalDiscount.Text = "0.00";
            this.TxtTotalDiscount.TextChanged += new System.EventHandler(this.TxtTotalDiscount_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(28, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 32);
            this.label8.TabIndex = 152;
            this.label8.Text = "استقطاعات أخرى";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(304, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 32);
            this.label9.TabIndex = 151;
            this.label9.Text = "جنيه";
            // 
            // TxtDiscounts
            // 
            this.TxtDiscounts.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDiscounts.Location = new System.Drawing.Point(152, 146);
            this.TxtDiscounts.Name = "TxtDiscounts";
            this.TxtDiscounts.Size = new System.Drawing.Size(146, 29);
            this.TxtDiscounts.TabIndex = 133;
            this.TxtDiscounts.Text = "0.00";
            this.TxtDiscounts.TextChanged += new System.EventHandler(this.TxtDiscounts_TextChanged);
            this.TxtDiscounts.Leave += new System.EventHandler(this.TxtDiscounts_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(539, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 32);
            this.label7.TabIndex = 150;
            this.label7.Text = "%";
            // 
            // TxtPercent
            // 
            this.TxtPercent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPercent.Location = new System.Drawing.Point(480, 111);
            this.TxtPercent.Name = "TxtPercent";
            this.TxtPercent.Size = new System.Drawing.Size(56, 29);
            this.TxtPercent.TabIndex = 131;
            this.TxtPercent.Text = "0.0";
            this.TxtPercent.TextChanged += new System.EventHandler(this.TxtPercent_TextChanged);
            this.TxtPercent.Leave += new System.EventHandler(this.TxtPercent_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(379, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 149;
            this.label3.Text = "الضرائب";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(662, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 32);
            this.label6.TabIndex = 148;
            this.label6.Text = "جنيه";
            // 
            // TxtTaxs
            // 
            this.TxtTaxs.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTaxs.Location = new System.Drawing.Point(570, 111);
            this.TxtTaxs.Name = "TxtTaxs";
            this.TxtTaxs.ReadOnly = true;
            this.TxtTaxs.Size = new System.Drawing.Size(89, 29);
            this.TxtTaxs.TabIndex = 132;
            this.TxtTaxs.TabStop = false;
            this.TxtTaxs.Text = "0.00";
            this.TxtTaxs.TextChanged += new System.EventHandler(this.TxtTaxs_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(28, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 32);
            this.label4.TabIndex = 147;
            this.label4.Text = "قيمة المطالبة";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDesc.Location = new System.Drawing.Point(152, 215);
            this.TxtDesc.Multiline = true;
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDesc.Size = new System.Drawing.Size(551, 59);
            this.TxtDesc.TabIndex = 136;
            this.TxtDesc.TextChanged += new System.EventHandler(this.TxtDesc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(24, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 32);
            this.label2.TabIndex = 146;
            this.label2.Text = "البيــان";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(152, 280);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(551, 79);
            this.TxtNotes.TabIndex = 137;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(28, 279);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 32);
            this.label41.TabIndex = 145;
            this.label41.Text = "ملاحظات";
            // 
            // DatePayDate
            // 
            this.DatePayDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePayDate.Location = new System.Drawing.Point(152, 77);
            this.DatePayDate.Name = "DatePayDate";
            this.DatePayDate.RightToLeftLayout = true;
            this.DatePayDate.Size = new System.Drawing.Size(193, 29);
            this.DatePayDate.TabIndex = 127;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label45.Location = new System.Drawing.Point(28, 74);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 32);
            this.label45.TabIndex = 144;
            this.label45.Text = "تاريخ الصرف";
            // 
            // TxtDocNo
            // 
            this.TxtDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDocNo.Location = new System.Drawing.Point(152, 44);
            this.TxtDocNo.Name = "TxtDocNo";
            this.TxtDocNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtDocNo.Size = new System.Drawing.Size(193, 29);
            this.TxtDocNo.TabIndex = 126;
            this.TxtDocNo.TextChanged += new System.EventHandler(this.TxtDocNo_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(28, 42);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(79, 32);
            this.label42.TabIndex = 143;
            this.label42.Text = "رقم المستند";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label44.Location = new System.Drawing.Point(304, 110);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(42, 32);
            this.label44.TabIndex = 142;
            this.label44.Text = "جنيه";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtAmount.Location = new System.Drawing.Point(152, 111);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(146, 29);
            this.TxtAmount.TabIndex = 130;
            this.TxtAmount.Text = "0.00";
            this.TxtAmount.TextChanged += new System.EventHandler(this.TxtAmount_TextChanged);
            this.TxtAmount.Leave += new System.EventHandler(this.TxtAmount_Leave);
            // 
            // ComboDoctor
            // 
            this.ComboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboDoctor.DataSource = this.doctorBindingSource;
            this.ComboDoctor.DisplayMember = "Name";
            this.ComboDoctor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboDoctor.FormattingEnabled = true;
            this.ComboDoctor.Location = new System.Drawing.Point(480, 77);
            this.ComboDoctor.Name = "ComboDoctor";
            this.ComboDoctor.Size = new System.Drawing.Size(223, 30);
            this.ComboDoctor.TabIndex = 129;
            this.ComboDoctor.ValueMember = "ID";
            this.ComboDoctor.TextChanged += new System.EventHandler(this.ComboDoctor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(379, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 32);
            this.label5.TabIndex = 141;
            this.label5.Text = "اسم الدكتور";
            // 
            // ComboLocation
            // 
            this.ComboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "LocationName";
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(480, 44);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(223, 30);
            this.ComboLocation.TabIndex = 128;
            this.ComboLocation.ValueMember = "LocationID";
            this.ComboLocation.TextChanged += new System.EventHandler(this.ComboLocation_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(379, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 140;
            this.label1.Text = "الجهة التابع لها";
            // 
            // ComboDocNo
            // 
            this.ComboDocNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboDocNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboDocNo.DataSource = this.doctorBillsBindingSource;
            this.ComboDocNo.DisplayMember = "DocNo";
            this.ComboDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboDocNo.FormattingEnabled = true;
            this.ComboDocNo.Location = new System.Drawing.Point(152, 6);
            this.ComboDocNo.Name = "ComboDocNo";
            this.ComboDocNo.Size = new System.Drawing.Size(193, 30);
            this.ComboDocNo.TabIndex = 157;
            this.ComboDocNo.ValueMember = "DocNo";
            this.ComboDocNo.TextChanged += new System.EventHandler(this.ComboDocNo_TextChanged);
            // 
            // doctorBillsBindingSource
            // 
            this.doctorBillsBindingSource.DataMember = "DoctorBills";
            this.doctorBillsBindingSource.DataSource = this.auditorDataSet;
            // 
            // auditorDataSet
            // 
            this.auditorDataSet.DataSetName = "AuditorDataSet";
            this.auditorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(28, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 32);
            this.label14.TabIndex = 158;
            this.label14.Text = "رقم المستند";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Location = new System.Drawing.Point(306, 382);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 33);
            this.BtnDelete.TabIndex = 160;
            this.BtnDelete.Text = "حـذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(442, 382);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 33);
            this.BtnClose.TabIndex = 161;
            this.BtnClose.Text = "إلـغــاء";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(170, 382);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdate.TabIndex = 159;
            this.BtnUpdate.Text = "تـحـديـث";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // doctorBillsTableAdapter
            // 
            this.doctorBillsTableAdapter.ClearBeforeFill = true;
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
            // FrmModifyDoctorBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 440);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.ComboDocNo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtNetAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtTotalDiscount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtDiscounts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtPercent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTaxs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.DatePayDate);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.TxtDocNo);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.ComboDoctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboLocation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmModifyDoctorBill";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل مطالبات المراكز الطبية";
            this.Load += new System.EventHandler(this.FrmModifyDoctorBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBillsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtNetAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtTotalDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtDiscounts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTaxs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DateTimePicker DatePayDate;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox TxtDocNo;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.ComboBox ComboDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboDocNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnUpdate;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource doctorBillsBindingSource;
        private AuditorDataSetTableAdapters.DoctorBillsTableAdapter doctorBillsTableAdapter;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private AuditorDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
    }
}