namespace Auditor.Views.Telepohne
{
    partial class FrmModifyTel
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
            this.label10 = new System.Windows.Forms.Label();
            this.TxtStamp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSellTax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DatePay = new System.Windows.Forms.DateTimePicker();
            this.label45 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPortion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.ComboTelNo = new System.Windows.Forms.ComboBox();
            this.telNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboDocNo = new System.Windows.Forms.ComboBox();
            this.telephoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNetAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTotalDiscount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtPercentage = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtPaidAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.DateSettlement = new System.Windows.Forms.DateTimePicker();
            this.LblDateSettlement = new System.Windows.Forms.Label();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtTax = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            this.telephoneTableAdapter = new Auditor.AuditorDataSetTableAdapters.TelephoneTableAdapter();
            this.telNoTableAdapter = new Auditor.AuditorDataSetTableAdapters.TelNoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(251, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 32);
            this.label10.TabIndex = 119;
            this.label10.Text = "جنيه";
            // 
            // TxtStamp
            // 
            this.TxtStamp.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtStamp.Location = new System.Drawing.Point(128, 116);
            this.TxtStamp.Name = "TxtStamp";
            this.TxtStamp.Size = new System.Drawing.Size(118, 29);
            this.TxtStamp.TabIndex = 3;
            this.TxtStamp.TextChanged += new System.EventHandler(this.TxtStamp_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(16, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 32);
            this.label11.TabIndex = 118;
            this.label11.Text = "الدمغة";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(570, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 32);
            this.label8.TabIndex = 117;
            this.label8.Text = "جنيه";
            // 
            // TxtSellTax
            // 
            this.TxtSellTax.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtSellTax.Location = new System.Drawing.Point(438, 114);
            this.TxtSellTax.Name = "TxtSellTax";
            this.TxtSellTax.Size = new System.Drawing.Size(126, 29);
            this.TxtSellTax.TabIndex = 9;
            this.TxtSellTax.TextChanged += new System.EventHandler(this.TxtSellTax_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(301, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 32);
            this.label9.TabIndex = 116;
            this.label9.Text = "ضريبة المبيعات";
            // 
            // DatePay
            // 
            this.DatePay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePay.Location = new System.Drawing.Point(128, 46);
            this.DatePay.Name = "DatePay";
            this.DatePay.RightToLeftLayout = true;
            this.DatePay.Size = new System.Drawing.Size(166, 29);
            this.DatePay.TabIndex = 1;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label45.Location = new System.Drawing.Point(16, 45);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 32);
            this.label45.TabIndex = 109;
            this.label45.Text = "تاريخ الصرف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 106;
            this.label1.Text = "الجهة التابع لها";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(16, 9);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(79, 32);
            this.label42.TabIndex = 107;
            this.label42.Text = "رقم المستند";
            // 
            // ComboLocation
            // 
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "LocationName";
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(438, 10);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(174, 30);
            this.ComboLocation.TabIndex = 6;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(252, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 32);
            this.label5.TabIndex = 113;
            this.label5.Text = "جنيه";
            // 
            // TxtAmount
            // 
            this.TxtAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtAmount.Location = new System.Drawing.Point(128, 81);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Size = new System.Drawing.Size(118, 29);
            this.TxtAmount.TabIndex = 2;
            this.TxtAmount.TextChanged += new System.EventHandler(this.TxtAmount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 112;
            this.label4.Text = "قيمة الفاتورة";
            // 
            // TxtPortion
            // 
            this.TxtPortion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPortion.Location = new System.Drawing.Point(438, 80);
            this.TxtPortion.Name = "TxtPortion";
            this.TxtPortion.Size = new System.Drawing.Size(174, 29);
            this.TxtPortion.TabIndex = 8;
            this.TxtPortion.TextChanged += new System.EventHandler(this.TxtPortion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(301, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 32);
            this.label3.TabIndex = 111;
            this.label3.Text = "قـسـط";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(301, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 110;
            this.label2.Text = "رقم التليفون";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Location = new System.Drawing.Point(257, 386);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 33);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "حـذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(416, 386);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 33);
            this.BtnClose.TabIndex = 17;
            this.BtnClose.Text = "إلـغــاء";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(98, 386);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdate.TabIndex = 15;
            this.BtnUpdate.Text = "تـحـديـث";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // ComboTelNo
            // 
            this.ComboTelNo.DataSource = this.telNoBindingSource;
            this.ComboTelNo.DisplayMember = "TelNo";
            this.ComboTelNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTelNo.FormattingEnabled = true;
            this.ComboTelNo.Location = new System.Drawing.Point(438, 45);
            this.ComboTelNo.Name = "ComboTelNo";
            this.ComboTelNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboTelNo.Size = new System.Drawing.Size(174, 30);
            this.ComboTelNo.TabIndex = 7;
            this.ComboTelNo.ValueMember = "ID";
            this.ComboTelNo.TextChanged += new System.EventHandler(this.ComboTelNo_TextChanged);
            // 
            // telNoBindingSource
            // 
            this.telNoBindingSource.DataMember = "TelNo";
            this.telNoBindingSource.DataSource = this.auditorDataSet;
            // 
            // ComboDocNo
            // 
            this.ComboDocNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboDocNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboDocNo.DataSource = this.telephoneBindingSource;
            this.ComboDocNo.DisplayMember = "DocNo";
            this.ComboDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboDocNo.FormattingEnabled = true;
            this.ComboDocNo.Location = new System.Drawing.Point(128, 10);
            this.ComboDocNo.Name = "ComboDocNo";
            this.ComboDocNo.Size = new System.Drawing.Size(166, 30);
            this.ComboDocNo.TabIndex = 0;
            this.ComboDocNo.ValueMember = "DocNo";
            this.ComboDocNo.TextChanged += new System.EventHandler(this.ComboDocNo_TextChanged);
            // 
            // telephoneBindingSource
            // 
            this.telephoneBindingSource.DataMember = "Telephone";
            this.telephoneBindingSource.DataSource = this.auditorDataSet;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(570, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 32);
            this.label12.TabIndex = 146;
            this.label12.Text = "جنيه";
            // 
            // TxtNetAmount
            // 
            this.TxtNetAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNetAmount.Location = new System.Drawing.Point(438, 148);
            this.TxtNetAmount.Name = "TxtNetAmount";
            this.TxtNetAmount.ReadOnly = true;
            this.TxtNetAmount.Size = new System.Drawing.Size(126, 29);
            this.TxtNetAmount.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(301, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 32);
            this.label13.TabIndex = 145;
            this.label13.Text = "المبلغ الصافي";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(251, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 32);
            this.label6.TabIndex = 142;
            this.label6.Text = "جنيه";
            // 
            // TxtTotalDiscount
            // 
            this.TxtTotalDiscount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTotalDiscount.Location = new System.Drawing.Point(128, 151);
            this.TxtTotalDiscount.Name = "TxtTotalDiscount";
            this.TxtTotalDiscount.ReadOnly = true;
            this.TxtTotalDiscount.Size = new System.Drawing.Size(118, 29);
            this.TxtTotalDiscount.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(4, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 141;
            this.label7.Text = "إجمالي الخصم";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label21.Location = new System.Drawing.Point(301, 188);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 32);
            this.label21.TabIndex = 161;
            this.label21.Text = "مبلغ الضريبة";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label20.Location = new System.Drawing.Point(235, 185);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 32);
            this.label20.TabIndex = 160;
            this.label20.Text = "%";
            // 
            // TxtPercentage
            // 
            this.TxtPercentage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPercentage.Location = new System.Drawing.Point(179, 187);
            this.TxtPercentage.Name = "TxtPercentage";
            this.TxtPercentage.Size = new System.Drawing.Size(53, 29);
            this.TxtPercentage.TabIndex = 159;
            this.TxtPercentage.TextChanged += new System.EventHandler(this.TxtPercentage_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(279, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 32);
            this.label16.TabIndex = 158;
            this.label16.Text = "جنيه";
            // 
            // TxtPaidAmount
            // 
            this.TxtPaidAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPaidAmount.Location = new System.Drawing.Point(128, 221);
            this.TxtPaidAmount.Name = "TxtPaidAmount";
            this.TxtPaidAmount.ReadOnly = true;
            this.TxtPaidAmount.Size = new System.Drawing.Size(134, 29);
            this.TxtPaidAmount.TabIndex = 148;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label17.Location = new System.Drawing.Point(12, 223);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 32);
            this.label17.TabIndex = 157;
            this.label17.Text = "المبلغ المدفوع";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(128, 299);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(474, 81);
            this.TxtNotes.TabIndex = 151;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(12, 298);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(72, 32);
            this.label41.TabIndex = 156;
            this.label41.Text = "ملاحظات";
            // 
            // DateSettlement
            // 
            this.DateSettlement.Enabled = false;
            this.DateSettlement.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSettlement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateSettlement.Location = new System.Drawing.Point(434, 254);
            this.DateSettlement.Name = "DateSettlement";
            this.DateSettlement.RightToLeftLayout = true;
            this.DateSettlement.Size = new System.Drawing.Size(174, 29);
            this.DateSettlement.TabIndex = 150;
            // 
            // LblDateSettlement
            // 
            this.LblDateSettlement.AutoSize = true;
            this.LblDateSettlement.Enabled = false;
            this.LblDateSettlement.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblDateSettlement.Location = new System.Drawing.Point(324, 258);
            this.LblDateSettlement.Name = "LblDateSettlement";
            this.LblDateSettlement.Size = new System.Drawing.Size(93, 32);
            this.LblDateSettlement.TabIndex = 155;
            this.LblDateSettlement.Text = "تاريخ التسوية";
            // 
            // ComboStatus
            // 
            this.ComboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Items.AddRange(new object[] {
            "تمت التسوية",
            "لم يتم التسوية"});
            this.ComboStatus.Location = new System.Drawing.Point(128, 254);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboStatus.Size = new System.Drawing.Size(174, 30);
            this.ComboStatus.TabIndex = 149;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(12, 258);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 32);
            this.label18.TabIndex = 154;
            this.label18.Text = "حالة التسوية";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(574, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 32);
            this.label14.TabIndex = 153;
            this.label14.Text = "جنيه";
            // 
            // TxtTax
            // 
            this.TxtTax.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTax.Location = new System.Drawing.Point(434, 190);
            this.TxtTax.Name = "TxtTax";
            this.TxtTax.ReadOnly = true;
            this.TxtTax.Size = new System.Drawing.Size(134, 29);
            this.TxtTax.TabIndex = 147;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(12, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 32);
            this.label15.TabIndex = 152;
            this.label15.Text = "ضريبة أ ت ص";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label19.Location = new System.Drawing.Point(122, 188);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 32);
            this.label19.TabIndex = 162;
            this.label19.Text = "النسبة";
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // telephoneTableAdapter
            // 
            this.telephoneTableAdapter.ClearBeforeFill = true;
            // 
            // telNoTableAdapter
            // 
            this.telNoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmModifyTel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(629, 437);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.TxtPercentage);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtPaidAmount);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.DateSettlement);
            this.Controls.Add(this.LblDateSettlement);
            this.Controls.Add(this.ComboStatus);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtTax);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtNetAmount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtTotalDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComboDocNo);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtStamp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtSellTax);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DatePay);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboTelNo);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.ComboLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPortion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmModifyTel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات مستند تليفونات";
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtStamp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSellTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DatePay;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPortion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Auditor.AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.ComboBox ComboTelNo;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.ComboBox ComboDocNo;
        private System.Windows.Forms.BindingSource telephoneBindingSource;
        private Auditor.AuditorDataSetTableAdapters.TelephoneTableAdapter telephoneTableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtNetAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTotalDiscount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtPercentage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtPaidAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DateTimePicker DateSettlement;
        private System.Windows.Forms.Label LblDateSettlement;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtTax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.BindingSource telNoBindingSource;
        private AuditorDataSetTableAdapters.TelNoTableAdapter telNoTableAdapter;
    }
}