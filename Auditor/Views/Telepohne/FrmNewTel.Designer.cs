namespace Auditor.Views.Telepohne
{
    partial class FrmNewTel
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
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.DatePay = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.ComboTelNo = new System.Windows.Forms.ComboBox();
            this.telNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPortion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTotalDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSellTax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtStamp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtTax = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DateSettlement = new System.Windows.Forms.DateTimePicker();
            this.LblDateSettlement = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtPaidAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNetAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtPercentage = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.contractorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            this.auditorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telNoTableAdapter = new Auditor.AuditorDataSetTableAdapters.TelNoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDocNo
            // 
            this.TxtDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDocNo.Location = new System.Drawing.Point(131, 21);
            this.TxtDocNo.Name = "TxtDocNo";
            this.TxtDocNo.Size = new System.Drawing.Size(174, 29);
            this.TxtDocNo.TabIndex = 0;
            this.TxtDocNo.TextChanged += new System.EventHandler(this.TxtDocNo_TextChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(15, 19);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(79, 32);
            this.label42.TabIndex = 54;
            this.label42.Text = "رقم المستند";
            // 
            // ComboLocation
            // 
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "LocationName";
            this.ComboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(437, 21);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(174, 30);
            this.ComboLocation.TabIndex = 4;
            this.ComboLocation.ValueMember = "LocationID";
            this.ComboLocation.SelectedIndexChanged += new System.EventHandler(this.ComboLocation_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(327, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "الجهة التابع لها";
            // 
            // DatePay
            // 
            this.DatePay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePay.Location = new System.Drawing.Point(131, 53);
            this.DatePay.Name = "DatePay";
            this.DatePay.RightToLeftLayout = true;
            this.DatePay.Size = new System.Drawing.Size(174, 29);
            this.DatePay.TabIndex = 1;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label45.Location = new System.Drawing.Point(15, 52);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 32);
            this.label45.TabIndex = 57;
            this.label45.Text = "تاريخ الصرف";
            // 
            // ComboTelNo
            // 
            this.ComboTelNo.DataSource = this.telNoBindingSource;
            this.ComboTelNo.DisplayMember = "TelNo";
            this.ComboTelNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTelNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTelNo.FormattingEnabled = true;
            this.ComboTelNo.Location = new System.Drawing.Point(437, 53);
            this.ComboTelNo.Name = "ComboTelNo";
            this.ComboTelNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboTelNo.Size = new System.Drawing.Size(174, 30);
            this.ComboTelNo.TabIndex = 5;
            this.ComboTelNo.ValueMember = "ID";
            this.ComboTelNo.SelectedIndexChanged += new System.EventHandler(this.ComboTelNo_SelectedIndexChanged);
            // 
            // telNoBindingSource
            // 
            this.telNoBindingSource.DataMember = "TelNo";
            this.telNoBindingSource.DataSource = this.auditorDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(327, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 59;
            this.label2.Text = "رقم التليفون";
            // 
            // TxtPortion
            // 
            this.TxtPortion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPortion.Location = new System.Drawing.Point(437, 85);
            this.TxtPortion.Name = "TxtPortion";
            this.TxtPortion.Size = new System.Drawing.Size(174, 29);
            this.TxtPortion.TabIndex = 6;
            this.TxtPortion.TextChanged += new System.EventHandler(this.TxtPortion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(327, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 32);
            this.label3.TabIndex = 61;
            this.label3.Text = "قـسـط";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtAmount.Location = new System.Drawing.Point(131, 85);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(134, 29);
            this.TxtAmount.TabIndex = 2;
            this.TxtAmount.TextChanged += new System.EventHandler(this.TxtAmount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 63;
            this.label4.Text = "قيمة الفاتورة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(280, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 32);
            this.label5.TabIndex = 64;
            this.label5.Text = "جنيه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(282, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 32);
            this.label6.TabIndex = 67;
            this.label6.Text = "جنيه";
            // 
            // TxtTotalDiscount
            // 
            this.TxtTotalDiscount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTotalDiscount.Location = new System.Drawing.Point(131, 149);
            this.TxtTotalDiscount.Name = "TxtTotalDiscount";
            this.TxtTotalDiscount.ReadOnly = true;
            this.TxtTotalDiscount.Size = new System.Drawing.Size(134, 29);
            this.TxtTotalDiscount.TabIndex = 4;
            this.TxtTotalDiscount.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(15, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 66;
            this.label7.Text = "إجمالي الخصم";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(576, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 32);
            this.label8.TabIndex = 70;
            this.label8.Text = "جنيه";
            // 
            // TxtSellTax
            // 
            this.TxtSellTax.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtSellTax.Location = new System.Drawing.Point(437, 116);
            this.TxtSellTax.Name = "TxtSellTax";
            this.TxtSellTax.Size = new System.Drawing.Size(134, 29);
            this.TxtSellTax.TabIndex = 7;
            this.TxtSellTax.TextChanged += new System.EventHandler(this.TxtSellTax_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(327, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 32);
            this.label9.TabIndex = 69;
            this.label9.Text = "ضريبة المبيعات";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(280, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 32);
            this.label10.TabIndex = 73;
            this.label10.Text = "جنيه";
            // 
            // TxtStamp
            // 
            this.TxtStamp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtStamp.Location = new System.Drawing.Point(131, 117);
            this.TxtStamp.Name = "TxtStamp";
            this.TxtStamp.Size = new System.Drawing.Size(134, 29);
            this.TxtStamp.TabIndex = 3;
            this.TxtStamp.TextChanged += new System.EventHandler(this.TxtStamp_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(15, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 32);
            this.label11.TabIndex = 72;
            this.label11.Text = "الدمغة";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(577, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 32);
            this.label14.TabIndex = 79;
            this.label14.Text = "جنيه";
            // 
            // TxtTax
            // 
            this.TxtTax.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTax.Location = new System.Drawing.Point(437, 184);
            this.TxtTax.Name = "TxtTax";
            this.TxtTax.ReadOnly = true;
            this.TxtTax.Size = new System.Drawing.Size(134, 29);
            this.TxtTax.TabIndex = 5;
            this.TxtTax.TabStop = false;
            this.TxtTax.TextChanged += new System.EventHandler(this.TxtTax_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(15, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 32);
            this.label15.TabIndex = 78;
            this.label15.Text = "ضريبة أ ت ص";
            // 
            // ComboStatus
            // 
            this.ComboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Items.AddRange(new object[] {
            "لم يتم التسوية",
            "تمت التسوية"});
            this.ComboStatus.Location = new System.Drawing.Point(131, 248);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboStatus.Size = new System.Drawing.Size(174, 30);
            this.ComboStatus.TabIndex = 9;
            this.ComboStatus.SelectedIndexChanged += new System.EventHandler(this.ComboStatus_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(15, 252);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 32);
            this.label18.TabIndex = 84;
            this.label18.Text = "حالة التسوية";
            // 
            // DateSettlement
            // 
            this.DateSettlement.Enabled = false;
            this.DateSettlement.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSettlement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateSettlement.Location = new System.Drawing.Point(437, 248);
            this.DateSettlement.Name = "DateSettlement";
            this.DateSettlement.RightToLeftLayout = true;
            this.DateSettlement.Size = new System.Drawing.Size(174, 29);
            this.DateSettlement.TabIndex = 10;
            // 
            // LblDateSettlement
            // 
            this.LblDateSettlement.AutoSize = true;
            this.LblDateSettlement.Enabled = false;
            this.LblDateSettlement.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblDateSettlement.Location = new System.Drawing.Point(327, 252);
            this.LblDateSettlement.Name = "LblDateSettlement";
            this.LblDateSettlement.Size = new System.Drawing.Size(93, 32);
            this.LblDateSettlement.TabIndex = 86;
            this.LblDateSettlement.Text = "تاريخ التسوية";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(112, 293);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(493, 81);
            this.TxtNotes.TabIndex = 11;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(15, 292);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 32);
            this.label41.TabIndex = 90;
            this.label41.Text = "ملاحظات";
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(403, 387);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(98, 33);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Text = "إلـغــاء";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Location = new System.Drawing.Point(113, 387);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(98, 33);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "حــفــظ";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(282, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 32);
            this.label16.TabIndex = 96;
            this.label16.Text = "جنيه";
            // 
            // TxtPaidAmount
            // 
            this.TxtPaidAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPaidAmount.Location = new System.Drawing.Point(131, 215);
            this.TxtPaidAmount.Name = "TxtPaidAmount";
            this.TxtPaidAmount.ReadOnly = true;
            this.TxtPaidAmount.Size = new System.Drawing.Size(134, 29);
            this.TxtPaidAmount.TabIndex = 11;
            this.TxtPaidAmount.TabStop = false;
            this.TxtPaidAmount.TextChanged += new System.EventHandler(this.TxtPaidAmount_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.Location = new System.Drawing.Point(15, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 32);
            this.label17.TabIndex = 95;
            this.label17.Text = "المبلغ المدفوع";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(576, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 32);
            this.label12.TabIndex = 93;
            this.label12.Text = "جنيه";
            // 
            // TxtNetAmount
            // 
            this.TxtNetAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNetAmount.Location = new System.Drawing.Point(437, 149);
            this.TxtNetAmount.Name = "TxtNetAmount";
            this.TxtNetAmount.ReadOnly = true;
            this.TxtNetAmount.Size = new System.Drawing.Size(134, 29);
            this.TxtNetAmount.TabIndex = 10;
            this.TxtNetAmount.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(327, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 32);
            this.label13.TabIndex = 92;
            this.label13.Text = "المبلغ الصافي";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.Location = new System.Drawing.Point(125, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 32);
            this.label19.TabIndex = 97;
            this.label19.Text = "النسبة";
            // 
            // TxtPercentage
            // 
            this.TxtPercentage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPercentage.Location = new System.Drawing.Point(180, 182);
            this.TxtPercentage.Name = "TxtPercentage";
            this.TxtPercentage.Size = new System.Drawing.Size(53, 29);
            this.TxtPercentage.TabIndex = 8;
            this.TxtPercentage.TextChanged += new System.EventHandler(this.TxtPercentage_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label20.Location = new System.Drawing.Point(236, 180);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 32);
            this.label20.TabIndex = 99;
            this.label20.Text = "%";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label21.Location = new System.Drawing.Point(327, 182);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 32);
            this.label21.TabIndex = 100;
            this.label21.Text = "مبلغ الضريبة";
            // 
            // contractorBindingSource
            // 
            this.contractorBindingSource.DataMember = "Contractor";
            this.contractorBindingSource.DataSource = this.auditorDataSet;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // auditorDataSetBindingSource
            // 
            this.auditorDataSetBindingSource.DataSource = this.auditorDataSet;
            this.auditorDataSetBindingSource.Position = 0;
            // 
            // telNoTableAdapter
            // 
            this.telNoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmNewTel
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(638, 440);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.TxtPercentage);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtPaidAmount);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtNetAmount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.DateSettlement);
            this.Controls.Add(this.LblDateSettlement);
            this.Controls.Add(this.ComboStatus);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtTax);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtStamp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtSellTax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTotalDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPortion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboTelNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatePay);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.TxtDocNo);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.ComboLocation);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmNewTel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مستند تليفونات";
            this.Load += new System.EventHandler(this.FrmAddTel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDocNo;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatePay;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox ComboTelNo;
        private System.Windows.Forms.Label label2;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource contractorBindingSource;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private Auditor.AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.TextBox TxtPortion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTotalDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSellTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtStamp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtTax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker DateSettlement;
        private System.Windows.Forms.Label LblDateSettlement;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtPaidAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtNetAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtPercentage;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.BindingSource auditorDataSetBindingSource;
        private System.Windows.Forms.BindingSource telNoBindingSource;
        private AuditorDataSetTableAdapters.TelNoTableAdapter telNoTableAdapter;
    }
}