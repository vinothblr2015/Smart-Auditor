namespace Auditor
{
    partial class FrmNewePrePay
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
            this.TxtDocNo = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.DatePayDate = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDeductions = new System.Windows.Forms.GroupBox();
            this.CheckFees = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.TxtTotalDiscount = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.TxtFees = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.TxtTaxAmount = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TxtTaxRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.TxtNetAmount = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.TxtReason = new System.Windows.Forms.TextBox();
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.ComboVendor = new System.Windows.Forms.ComboBox();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBridge = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtJust = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSellTax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtBillTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            this.vendorsTableAdapter = new Auditor.AuditorDataSetTableAdapters.VendorsTableAdapter();
            this.employeeTableAdapter = new Auditor.AuditorDataSetTableAdapters.EmployeeTableAdapter();
            this.groupBoxDeductions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDocNo
            // 
            this.TxtDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDocNo.Location = new System.Drawing.Point(500, 11);
            this.TxtDocNo.Name = "TxtDocNo";
            this.TxtDocNo.Size = new System.Drawing.Size(187, 29);
            this.TxtDocNo.TabIndex = 3;
            this.TxtDocNo.TextChanged += new System.EventHandler(this.TxtDocNo_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(392, 10);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(79, 32);
            this.label42.TabIndex = 53;
            this.label42.Text = "رقم المستند";
            // 
            // DatePayDate
            // 
            this.DatePayDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePayDate.Location = new System.Drawing.Point(500, 45);
            this.DatePayDate.Name = "DatePayDate";
            this.DatePayDate.RightToLeftLayout = true;
            this.DatePayDate.Size = new System.Drawing.Size(187, 29);
            this.DatePayDate.TabIndex = 5;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label45.Location = new System.Drawing.Point(392, 44);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 32);
            this.label45.TabIndex = 61;
            this.label45.Text = "تاريخ الصرف";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label44.Location = new System.Drawing.Point(689, 77);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(42, 32);
            this.label44.TabIndex = 60;
            this.label44.Text = "جنيه";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtAmount.Location = new System.Drawing.Point(501, 77);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(186, 29);
            this.TxtAmount.TabIndex = 6;
            this.TxtAmount.Text = "0";
            this.TxtAmount.TextChanged += new System.EventHandler(this.TxtAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(12, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 55;
            this.label2.Text = "الغرض من الصرف";
            // 
            // groupBoxDeductions
            // 
            this.groupBoxDeductions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDeductions.Controls.Add(this.CheckFees);
            this.groupBoxDeductions.Controls.Add(this.label35);
            this.groupBoxDeductions.Controls.Add(this.TxtTotalDiscount);
            this.groupBoxDeductions.Controls.Add(this.label36);
            this.groupBoxDeductions.Controls.Add(this.label37);
            this.groupBoxDeductions.Controls.Add(this.label33);
            this.groupBoxDeductions.Controls.Add(this.TxtFees);
            this.groupBoxDeductions.Controls.Add(this.label29);
            this.groupBoxDeductions.Controls.Add(this.TxtTaxAmount);
            this.groupBoxDeductions.Controls.Add(this.label22);
            this.groupBoxDeductions.Controls.Add(this.TxtTaxRate);
            this.groupBoxDeductions.Controls.Add(this.label12);
            this.groupBoxDeductions.Controls.Add(this.label6);
            this.groupBoxDeductions.Controls.Add(this.label7);
            this.groupBoxDeductions.Controls.Add(this.label14);
            this.groupBoxDeductions.Controls.Add(this.label11);
            this.groupBoxDeductions.Location = new System.Drawing.Point(18, 139);
            this.groupBoxDeductions.Name = "groupBoxDeductions";
            this.groupBoxDeductions.Size = new System.Drawing.Size(710, 125);
            this.groupBoxDeductions.TabIndex = 62;
            this.groupBoxDeductions.TabStop = false;
            this.groupBoxDeductions.Text = "الاستقطاعات";
            // 
            // CheckFees
            // 
            this.CheckFees.AutoSize = true;
            this.CheckFees.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.CheckFees.Location = new System.Drawing.Point(428, 44);
            this.CheckFees.Name = "CheckFees";
            this.CheckFees.Size = new System.Drawing.Size(71, 36);
            this.CheckFees.TabIndex = 52;
            this.CheckFees.Text = "تخصم";
            this.CheckFees.UseVisualStyleBackColor = true;
            this.CheckFees.CheckedChanged += new System.EventHandler(this.CheckFees_CheckedChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label35.Location = new System.Drawing.Point(96, 76);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(42, 32);
            this.label35.TabIndex = 51;
            this.label35.Text = "جنيه";
            // 
            // TxtTotalDiscount
            // 
            this.TxtTotalDiscount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTotalDiscount.Location = new System.Drawing.Point(140, 77);
            this.TxtTotalDiscount.Name = "TxtTotalDiscount";
            this.TxtTotalDiscount.ReadOnly = true;
            this.TxtTotalDiscount.Size = new System.Drawing.Size(116, 29);
            this.TxtTotalDiscount.TabIndex = 10;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label36.Location = new System.Drawing.Point(593, 75);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(116, 32);
            this.label36.TabIndex = 48;
            this.label36.Text = "إجمالي المستقطع";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label37.Location = new System.Drawing.Point(262, 77);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(40, 32);
            this.label37.TabIndex = 49;
            this.label37.Text = "مبلغ";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label33.Location = new System.Drawing.Point(96, 45);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(42, 32);
            this.label33.TabIndex = 45;
            this.label33.Text = "جنيه";
            // 
            // TxtFees
            // 
            this.TxtFees.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtFees.Location = new System.Drawing.Point(140, 46);
            this.TxtFees.Name = "TxtFees";
            this.TxtFees.Size = new System.Drawing.Size(116, 29);
            this.TxtFees.TabIndex = 8;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label29.Location = new System.Drawing.Point(96, 14);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 32);
            this.label29.TabIndex = 37;
            this.label29.Text = "جنيه";
            // 
            // TxtTaxAmount
            // 
            this.TxtTaxAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTaxAmount.Location = new System.Drawing.Point(140, 15);
            this.TxtTaxAmount.Name = "TxtTaxAmount";
            this.TxtTaxAmount.ReadOnly = true;
            this.TxtTaxAmount.Size = new System.Drawing.Size(116, 29);
            this.TxtTaxAmount.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label22.Location = new System.Drawing.Point(368, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 32);
            this.label22.TabIndex = 22;
            this.label22.Text = "%";
            // 
            // TxtTaxRate
            // 
            this.TxtTaxRate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTaxRate.Location = new System.Drawing.Point(403, 15);
            this.TxtTaxRate.Name = "TxtTaxRate";
            this.TxtTaxRate.Size = new System.Drawing.Size(42, 29);
            this.TxtTaxRate.TabIndex = 0;
            this.TxtTaxRate.Text = "0.5";
            this.TxtTaxRate.TextChanged += new System.EventHandler(this.TxtTaxRate_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(262, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 32);
            this.label12.TabIndex = 11;
            this.label12.Text = "مبلغ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(565, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "مهن تطبيقية وهندسية";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(646, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "ضرائب";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(262, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 32);
            this.label14.TabIndex = 14;
            this.label14.Text = "مبلغ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(463, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 32);
            this.label11.TabIndex = 10;
            this.label11.Text = "نسبة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(392, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 32);
            this.label4.TabIndex = 56;
            this.label4.Text = "المبلغ";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(169, 384);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(517, 81);
            this.TxtNotes.TabIndex = 8;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(12, 383);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 32);
            this.label41.TabIndex = 67;
            this.label41.Text = "ملاحظات";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label38.Location = new System.Drawing.Point(291, 266);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(42, 32);
            this.label38.TabIndex = 66;
            this.label38.Text = "جنيه";
            // 
            // TxtNetAmount
            // 
            this.TxtNetAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNetAmount.Location = new System.Drawing.Point(169, 270);
            this.TxtNetAmount.Name = "TxtNetAmount";
            this.TxtNetAmount.ReadOnly = true;
            this.TxtNetAmount.Size = new System.Drawing.Size(116, 29);
            this.TxtNetAmount.TabIndex = 63;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label39.Location = new System.Drawing.Point(12, 267);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(149, 32);
            this.label39.TabIndex = 65;
            this.label39.Text = "صافي القيمة المنصرفة";
            // 
            // TxtReason
            // 
            this.TxtReason.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtReason.Location = new System.Drawing.Point(169, 336);
            this.TxtReason.Multiline = true;
            this.TxtReason.Name = "TxtReason";
            this.TxtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtReason.Size = new System.Drawing.Size(517, 45);
            this.TxtReason.TabIndex = 7;
            this.TxtReason.TextChanged += new System.EventHandler(this.TxtReason_TextChanged);
            // 
            // ComboLocation
            // 
            this.ComboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboLocation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.locationBindingSource, "LocationID", true));
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "LocationName";
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(113, 11);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(251, 30);
            this.ComboLocation.TabIndex = 0;
            this.ComboLocation.ValueMember = "LocationID";
            this.ComboLocation.TextChanged += new System.EventHandler(this.ComboLocation_TextChanged);
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this.auditorDataSet;
            // 
            // auditorDataSet
            // 
            this.auditorDataSet.DataSetName = "AuditorDataSet";
            this.auditorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ComboVendor
            // 
            this.ComboVendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboVendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboVendor.DataSource = this.vendorsBindingSource;
            this.ComboVendor.DisplayMember = "Name";
            this.ComboVendor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboVendor.FormattingEnabled = true;
            this.ComboVendor.Location = new System.Drawing.Point(113, 44);
            this.ComboVendor.Name = "ComboVendor";
            this.ComboVendor.Size = new System.Drawing.Size(251, 30);
            this.ComboVendor.TabIndex = 1;
            this.ComboVendor.ValueMember = "ID";
            this.ComboVendor.TextChanged += new System.EventHandler(this.ComboVendor_TextChanged);
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.auditorDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 72;
            this.label3.Text = "اسم المورد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 69;
            this.label1.Text = "الجهة التابع لها";
            // 
            // ComboBridge
            // 
            this.ComboBridge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBridge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBridge.DataSource = this.employeeBindingSource;
            this.ComboBridge.DisplayMember = "EmployeeName";
            this.ComboBridge.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBridge.FormattingEnabled = true;
            this.ComboBridge.Location = new System.Drawing.Point(113, 77);
            this.ComboBridge.Name = "ComboBridge";
            this.ComboBridge.Size = new System.Drawing.Size(251, 30);
            this.ComboBridge.TabIndex = 2;
            this.ComboBridge.ValueMember = "ID";
            this.ComboBridge.TextChanged += new System.EventHandler(this.ComboBridge_TextChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.auditorDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(12, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 32);
            this.label5.TabIndex = 74;
            this.label5.Text = "اسم المناول";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(383, 481);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(98, 33);
            this.BtnClose.TabIndex = 10;
            this.BtnClose.Text = "خروج";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnAdd.Location = new System.Drawing.Point(252, 481);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(98, 33);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "إضافة";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtJust
            // 
            this.TxtJust.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtJust.Location = new System.Drawing.Point(169, 303);
            this.TxtJust.Name = "TxtJust";
            this.TxtJust.Size = new System.Drawing.Size(517, 29);
            this.TxtJust.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(323, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 32);
            this.label8.TabIndex = 78;
            this.label8.Text = "جنيه";
            // 
            // TxtSellTax
            // 
            this.TxtSellTax.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtSellTax.Location = new System.Drawing.Point(113, 109);
            this.TxtSellTax.Name = "TxtSellTax";
            this.TxtSellTax.Size = new System.Drawing.Size(204, 29);
            this.TxtSellTax.TabIndex = 76;
            this.TxtSellTax.Text = "0";
            this.TxtSellTax.TextChanged += new System.EventHandler(this.TxtSellTax_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(12, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 32);
            this.label9.TabIndex = 77;
            this.label9.Text = "ض المبيعات";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(689, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 32);
            this.label10.TabIndex = 81;
            this.label10.Text = "جنيه";
            // 
            // TxtBillTotal
            // 
            this.TxtBillTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBillTotal.Location = new System.Drawing.Point(501, 109);
            this.TxtBillTotal.Name = "TxtBillTotal";
            this.TxtBillTotal.ReadOnly = true;
            this.TxtBillTotal.Size = new System.Drawing.Size(186, 29);
            this.TxtBillTotal.TabIndex = 79;
            this.TxtBillTotal.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(392, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 32);
            this.label13.TabIndex = 80;
            this.label13.Text = "إجمالي الفاتورة";
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNewePrePay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 534);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtBillTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtSellTax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtJust);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.ComboBridge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ComboLocation);
            this.Controls.Add(this.ComboVendor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtReason);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.TxtNetAmount);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.groupBoxDeductions);
            this.Controls.Add(this.DatePayDate);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDocNo);
            this.Controls.Add(this.label42);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmNewePrePay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الدفع المقدم";
            this.Load += new System.EventHandler(this.FrmAddPrePay_Load);
            this.groupBoxDeductions.ResumeLayout(false);
            this.groupBoxDeductions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDocNo;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.DateTimePicker DatePayDate;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDeductions;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox TxtTotalDiscount;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox TxtFees;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox TxtTaxAmount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox TxtTaxRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox TxtNetAmount;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox TxtReason;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.ComboBox ComboVendor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBridge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnAdd;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private Auditor.AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.TextBox TxtJust;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private Auditor.AuditorDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSellTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtBillTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox CheckFees;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Auditor.AuditorDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}