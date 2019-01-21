namespace Auditor
{
    partial class FrmModifyTemporaryLoan
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
            this.label9 = new System.Windows.Forms.Label();
            this.TxtReason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DateEndDate = new System.Windows.Forms.DateTimePicker();
            this.TxtBill = new System.Windows.Forms.TextBox();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupSettlement = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtPenalty = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.DateChequeExpense = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.TxtSettlementPeriod = new System.Windows.Forms.TextBox();
            this.TxtSettlementNo = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.TxtChequeNo = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.TxtSettlementAmount = new System.Windows.Forms.TextBox();
            this.DateChequeDate = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.TxtNetAmount = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.TxtFees = new System.Windows.Forms.TextBox();
            this.TxtTax = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.TxtAmountToPay = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPaidAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtRevenues = new System.Windows.Forms.TextBox();
            this.TxtTotalDiscount = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TxtPeriod = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.DatePayDate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.ComboLocation = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditorDataSet = new Auditor.AuditorDataSet();
            this.label42 = new System.Windows.Forms.Label();
            this.ComboEmployee = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalAmount = new System.Windows.Forms.TextBox();
            this.DateSettlement = new System.Windows.Forms.DateTimePicker();
            this.LblDateSettlement = new System.Windows.Forms.Label();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.ComboDocNo = new System.Windows.Forms.ComboBox();
            this.temporaryLoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.temporaryLoanTableAdapter = new Auditor.AuditorDataSetTableAdapters.TemporaryLoanTableAdapter();
            this.locationTableAdapter = new Auditor.AuditorDataSetTableAdapters.LocationTableAdapter();
            this.employeeTableAdapter = new Auditor.AuditorDataSetTableAdapters.EmployeeTableAdapter();
            this.GroupSettlement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temporaryLoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(278, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 32);
            this.label9.TabIndex = 219;
            this.label9.Text = "جنيه";
            // 
            // TxtReason
            // 
            this.TxtReason.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtReason.Location = new System.Drawing.Point(149, 116);
            this.TxtReason.Multiline = true;
            this.TxtReason.Name = "TxtReason";
            this.TxtReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtReason.Size = new System.Drawing.Size(546, 82);
            this.TxtReason.TabIndex = 6;
            this.TxtReason.TextChanged += new System.EventHandler(this.TxtReason_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(24, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 32);
            this.label8.TabIndex = 218;
            this.label8.Text = "الغرض من العملية";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(598, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 32);
            this.label11.TabIndex = 211;
            this.label11.Text = "إيصال توريد";
            // 
            // DateEndDate
            // 
            this.DateEndDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateEndDate.Location = new System.Drawing.Point(27, 65);
            this.DateEndDate.Name = "DateEndDate";
            this.DateEndDate.RightToLeftLayout = true;
            this.DateEndDate.Size = new System.Drawing.Size(187, 29);
            this.DateEndDate.TabIndex = 3;
            // 
            // TxtBill
            // 
            this.TxtBill.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtBill.Location = new System.Drawing.Point(348, 275);
            this.TxtBill.Name = "TxtBill";
            this.TxtBill.Size = new System.Drawing.Size(188, 29);
            this.TxtBill.TabIndex = 14;
            // 
            // TxtNotes
            // 
            this.TxtNotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNotes.Location = new System.Drawing.Point(110, 576);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNotes.Size = new System.Drawing.Size(588, 53);
            this.TxtNotes.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(23, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 32);
            this.label3.TabIndex = 217;
            this.label3.Text = "ملاحظات";
            // 
            // GroupSettlement
            // 
            this.GroupSettlement.Controls.Add(this.TxtBill);
            this.GroupSettlement.Controls.Add(this.label11);
            this.GroupSettlement.Controls.Add(this.DateEndDate);
            this.GroupSettlement.Controls.Add(this.label10);
            this.GroupSettlement.Controls.Add(this.label6);
            this.GroupSettlement.Controls.Add(this.label7);
            this.GroupSettlement.Controls.Add(this.TxtPenalty);
            this.GroupSettlement.Controls.Add(this.label40);
            this.GroupSettlement.Controls.Add(this.label41);
            this.GroupSettlement.Controls.Add(this.label43);
            this.GroupSettlement.Controls.Add(this.label44);
            this.GroupSettlement.Controls.Add(this.label46);
            this.GroupSettlement.Controls.Add(this.DateChequeExpense);
            this.GroupSettlement.Controls.Add(this.label27);
            this.GroupSettlement.Controls.Add(this.TxtSettlementPeriod);
            this.GroupSettlement.Controls.Add(this.TxtSettlementNo);
            this.GroupSettlement.Controls.Add(this.label26);
            this.GroupSettlement.Controls.Add(this.label28);
            this.GroupSettlement.Controls.Add(this.TxtChequeNo);
            this.GroupSettlement.Controls.Add(this.label30);
            this.GroupSettlement.Controls.Add(this.label31);
            this.GroupSettlement.Controls.Add(this.TxtSettlementAmount);
            this.GroupSettlement.Controls.Add(this.DateChequeDate);
            this.GroupSettlement.Controls.Add(this.label32);
            this.GroupSettlement.Controls.Add(this.label33);
            this.GroupSettlement.Controls.Add(this.label34);
            this.GroupSettlement.Controls.Add(this.label35);
            this.GroupSettlement.Controls.Add(this.label20);
            this.GroupSettlement.Controls.Add(this.TxtNetAmount);
            this.GroupSettlement.Controls.Add(this.label37);
            this.GroupSettlement.Controls.Add(this.TxtFees);
            this.GroupSettlement.Controls.Add(this.TxtTax);
            this.GroupSettlement.Controls.Add(this.label38);
            this.GroupSettlement.Controls.Add(this.label39);
            this.GroupSettlement.Controls.Add(this.TxtAmountToPay);
            this.GroupSettlement.Controls.Add(this.label36);
            this.GroupSettlement.Controls.Add(this.label2);
            this.GroupSettlement.Controls.Add(this.TxtPaidAmount);
            this.GroupSettlement.Controls.Add(this.label13);
            this.GroupSettlement.Controls.Add(this.label15);
            this.GroupSettlement.Controls.Add(this.TxtRevenues);
            this.GroupSettlement.Controls.Add(this.TxtTotalDiscount);
            this.GroupSettlement.Enabled = false;
            this.GroupSettlement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupSettlement.Location = new System.Drawing.Point(17, 237);
            this.GroupSettlement.Name = "GroupSettlement";
            this.GroupSettlement.Size = new System.Drawing.Size(697, 324);
            this.GroupSettlement.TabIndex = 9;
            this.GroupSettlement.TabStop = false;
            this.GroupSettlement.Text = "التسوية";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(247, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 32);
            this.label10.TabIndex = 209;
            this.label10.Text = "تاريخ الاستلام";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(27, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 32);
            this.label6.TabIndex = 207;
            this.label6.Text = "جنيه";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(237, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 32);
            this.label7.TabIndex = 205;
            this.label7.Text = "غرامات التأخير";
            // 
            // TxtPenalty
            // 
            this.TxtPenalty.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPenalty.Location = new System.Drawing.Point(90, 132);
            this.TxtPenalty.Name = "TxtPenalty";
            this.TxtPenalty.Size = new System.Drawing.Size(124, 29);
            this.TxtPenalty.TabIndex = 7;
            this.TxtPenalty.Text = "0";
            this.TxtPenalty.TextChanged += new System.EventHandler(this.TxtPenalty_TextChanged);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label40.Location = new System.Drawing.Point(35, 95);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(33, 32);
            this.label40.TabIndex = 204;
            this.label40.Text = "يوم";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label41.Location = new System.Drawing.Point(380, 237);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(42, 32);
            this.label41.TabIndex = 203;
            this.label41.Text = "جنيه";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label43.Location = new System.Drawing.Point(27, 236);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(42, 32);
            this.label43.TabIndex = 202;
            this.label43.Text = "جنيه";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label44.Location = new System.Drawing.Point(27, 167);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(42, 32);
            this.label44.TabIndex = 201;
            this.label44.Text = "جنيه";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label46.Location = new System.Drawing.Point(27, 202);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(42, 32);
            this.label46.TabIndex = 200;
            this.label46.Text = "جنيه";
            // 
            // DateChequeExpense
            // 
            this.DateChequeExpense.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateChequeExpense.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateChequeExpense.Location = new System.Drawing.Point(348, 65);
            this.DateChequeExpense.Name = "DateChequeExpense";
            this.DateChequeExpense.RightToLeftLayout = true;
            this.DateChequeExpense.Size = new System.Drawing.Size(187, 29);
            this.DateChequeExpense.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label27.Location = new System.Drawing.Point(600, 66);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 32);
            this.label27.TabIndex = 199;
            this.label27.Text = "تاريخ صرفه";
            // 
            // TxtSettlementPeriod
            // 
            this.TxtSettlementPeriod.Enabled = false;
            this.TxtSettlementPeriod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtSettlementPeriod.Location = new System.Drawing.Point(90, 96);
            this.TxtSettlementPeriod.Name = "TxtSettlementPeriod";
            this.TxtSettlementPeriod.Size = new System.Drawing.Size(124, 29);
            this.TxtSettlementPeriod.TabIndex = 5;
            this.TxtSettlementPeriod.Text = "0";
            this.TxtSettlementPeriod.TextChanged += new System.EventHandler(this.TxtSettlementPeriod_TextChanged);
            // 
            // TxtSettlementNo
            // 
            this.TxtSettlementNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtSettlementNo.Location = new System.Drawing.Point(27, 272);
            this.TxtSettlementNo.Name = "TxtSettlementNo";
            this.TxtSettlementNo.Size = new System.Drawing.Size(187, 29);
            this.TxtSettlementNo.TabIndex = 15;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label26.Location = new System.Drawing.Point(265, 97);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(81, 32);
            this.label26.TabIndex = 183;
            this.label26.Text = "مدة التسوية";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label28.Location = new System.Drawing.Point(263, 271);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 32);
            this.label28.TabIndex = 197;
            this.label28.Text = "رقم التسوية";
            // 
            // TxtChequeNo
            // 
            this.TxtChequeNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtChequeNo.Location = new System.Drawing.Point(348, 32);
            this.TxtChequeNo.Name = "TxtChequeNo";
            this.TxtChequeNo.Size = new System.Drawing.Size(187, 29);
            this.TxtChequeNo.TabIndex = 0;
            this.TxtChequeNo.TextChanged += new System.EventHandler(this.TxtChequeNo_TextChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label30.Location = new System.Drawing.Point(616, 31);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 32);
            this.label30.TabIndex = 195;
            this.label30.Text = "رقم الشيك";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label31.Location = new System.Drawing.Point(377, 97);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(42, 32);
            this.label31.TabIndex = 193;
            this.label31.Text = "جنيه";
            // 
            // TxtSettlementAmount
            // 
            this.TxtSettlementAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtSettlementAmount.Location = new System.Drawing.Point(428, 99);
            this.TxtSettlementAmount.Name = "TxtSettlementAmount";
            this.TxtSettlementAmount.Size = new System.Drawing.Size(105, 29);
            this.TxtSettlementAmount.TabIndex = 4;
            this.TxtSettlementAmount.Text = "0";
            this.TxtSettlementAmount.TextChanged += new System.EventHandler(this.TxtSettlementAmount_TextChanged);
            // 
            // DateChequeDate
            // 
            this.DateChequeDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateChequeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateChequeDate.Location = new System.Drawing.Point(35, 29);
            this.DateChequeDate.Name = "DateChequeDate";
            this.DateChequeDate.RightToLeftLayout = true;
            this.DateChequeDate.Size = new System.Drawing.Size(179, 29);
            this.DateChequeDate.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label32.Location = new System.Drawing.Point(602, 97);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(88, 32);
            this.label32.TabIndex = 191;
            this.label32.Text = "مبلغ التسوية";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label33.Location = new System.Drawing.Point(377, 166);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(42, 32);
            this.label33.TabIndex = 190;
            this.label33.Text = "جنيه";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label34.Location = new System.Drawing.Point(377, 200);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(42, 32);
            this.label34.TabIndex = 189;
            this.label34.Text = "جنيه";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label35.Location = new System.Drawing.Point(377, 132);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(42, 32);
            this.label35.TabIndex = 188;
            this.label35.Text = "جنيه";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label20.Location = new System.Drawing.Point(215, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(126, 32);
            this.label20.TabIndex = 172;
            this.label20.Text = "تاريخ تحرير الشيك";
            // 
            // TxtNetAmount
            // 
            this.TxtNetAmount.Enabled = false;
            this.TxtNetAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtNetAmount.Location = new System.Drawing.Point(428, 203);
            this.TxtNetAmount.Name = "TxtNetAmount";
            this.TxtNetAmount.Size = new System.Drawing.Size(105, 29);
            this.TxtNetAmount.TabIndex = 10;
            this.TxtNetAmount.Text = "0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label37.Location = new System.Drawing.Point(600, 202);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(91, 32);
            this.label37.TabIndex = 186;
            this.label37.Text = "صافي السلفة";
            // 
            // TxtFees
            // 
            this.TxtFees.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtFees.Location = new System.Drawing.Point(428, 168);
            this.TxtFees.Name = "TxtFees";
            this.TxtFees.Size = new System.Drawing.Size(105, 29);
            this.TxtFees.TabIndex = 8;
            this.TxtFees.Text = "0";
            this.TxtFees.TextChanged += new System.EventHandler(this.TxtFees_TextChanged);
            // 
            // TxtTax
            // 
            this.TxtTax.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTax.Location = new System.Drawing.Point(428, 134);
            this.TxtTax.Name = "TxtTax";
            this.TxtTax.Size = new System.Drawing.Size(105, 29);
            this.TxtTax.TabIndex = 6;
            this.TxtTax.Text = "0";
            this.TxtTax.TextChanged += new System.EventHandler(this.TxtTax_TextChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label38.Location = new System.Drawing.Point(548, 166);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(141, 32);
            this.label38.TabIndex = 182;
            this.label38.Text = "مهن تطبيقية وهندسية";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label39.Location = new System.Drawing.Point(628, 133);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(58, 32);
            this.label39.TabIndex = 183;
            this.label39.Text = "ضرائب";
            // 
            // TxtAmountToPay
            // 
            this.TxtAmountToPay.Enabled = false;
            this.TxtAmountToPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtAmountToPay.Location = new System.Drawing.Point(428, 240);
            this.TxtAmountToPay.Name = "TxtAmountToPay";
            this.TxtAmountToPay.Size = new System.Drawing.Size(105, 29);
            this.TxtAmountToPay.TabIndex = 12;
            this.TxtAmountToPay.Text = "0";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label36.Location = new System.Drawing.Point(231, 201);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(116, 32);
            this.label36.TabIndex = 81;
            this.label36.Text = "إجمالي المستقطع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(286, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 32);
            this.label2.TabIndex = 82;
            this.label2.Text = "إيرادات";
            // 
            // TxtPaidAmount
            // 
            this.TxtPaidAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPaidAmount.Location = new System.Drawing.Point(90, 237);
            this.TxtPaidAmount.Name = "TxtPaidAmount";
            this.TxtPaidAmount.Size = new System.Drawing.Size(124, 29);
            this.TxtPaidAmount.TabIndex = 13;
            this.TxtPaidAmount.Text = "0";
            this.TxtPaidAmount.TextChanged += new System.EventHandler(this.TxtPaidAmount_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(234, 235);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 32);
            this.label13.TabIndex = 94;
            this.label13.Text = "مبالغ تم توريدها";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(589, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 32);
            this.label15.TabIndex = 97;
            this.label15.Text = "مطلوب توريده";
            // 
            // TxtRevenues
            // 
            this.TxtRevenues.Enabled = false;
            this.TxtRevenues.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtRevenues.Location = new System.Drawing.Point(90, 168);
            this.TxtRevenues.Name = "TxtRevenues";
            this.TxtRevenues.Size = new System.Drawing.Size(124, 29);
            this.TxtRevenues.TabIndex = 9;
            this.TxtRevenues.Text = "0";
            // 
            // TxtTotalDiscount
            // 
            this.TxtTotalDiscount.Enabled = false;
            this.TxtTotalDiscount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTotalDiscount.Location = new System.Drawing.Point(90, 203);
            this.TxtTotalDiscount.Name = "TxtTotalDiscount";
            this.TxtTotalDiscount.Size = new System.Drawing.Size(124, 29);
            this.TxtTotalDiscount.TabIndex = 11;
            this.TxtTotalDiscount.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label23.Location = new System.Drawing.Point(654, 79);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 32);
            this.label23.TabIndex = 216;
            this.label23.Text = "يوم";
            // 
            // TxtPeriod
            // 
            this.TxtPeriod.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPeriod.Location = new System.Drawing.Point(469, 79);
            this.TxtPeriod.Name = "TxtPeriod";
            this.TxtPeriod.Size = new System.Drawing.Size(187, 29);
            this.TxtPeriod.TabIndex = 5;
            this.TxtPeriod.Text = "0";
            this.TxtPeriod.TextChanged += new System.EventHandler(this.TxtPeriod_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label22.Location = new System.Drawing.Point(343, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 32);
            this.label22.TabIndex = 215;
            this.label22.Text = "التسوية خلال";
            // 
            // DatePayDate
            // 
            this.DatePayDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePayDate.Location = new System.Drawing.Point(132, 44);
            this.DatePayDate.Name = "DatePayDate";
            this.DatePayDate.RightToLeftLayout = true;
            this.DatePayDate.Size = new System.Drawing.Size(187, 29);
            this.DatePayDate.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label18.Location = new System.Drawing.Point(23, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 32);
            this.label18.TabIndex = 213;
            this.label18.Text = "حالة التسوية";
            // 
            // ComboLocation
            // 
            this.ComboLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboLocation.DataSource = this.locationBindingSource;
            this.ComboLocation.DisplayMember = "LocationName";
            this.ComboLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboLocation.FormattingEnabled = true;
            this.ComboLocation.Location = new System.Drawing.Point(469, 10);
            this.ComboLocation.Name = "ComboLocation";
            this.ComboLocation.Size = new System.Drawing.Size(226, 30);
            this.ComboLocation.TabIndex = 2;
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
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.Location = new System.Drawing.Point(24, 9);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(79, 32);
            this.label42.TabIndex = 208;
            this.label42.Text = "رقم المستند";
            // 
            // ComboEmployee
            // 
            this.ComboEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboEmployee.DataSource = this.employeeBindingSource;
            this.ComboEmployee.DisplayMember = "EmployeeName";
            this.ComboEmployee.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboEmployee.FormattingEnabled = true;
            this.ComboEmployee.Location = new System.Drawing.Point(469, 45);
            this.ComboEmployee.Name = "ComboEmployee";
            this.ComboEmployee.Size = new System.Drawing.Size(226, 30);
            this.ComboEmployee.TabIndex = 3;
            this.ComboEmployee.ValueMember = "EmployeeID";
            this.ComboEmployee.TextChanged += new System.EventHandler(this.ComboEmployee_TextChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.auditorDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(343, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 210;
            this.label1.Text = "الجهة التابع لها";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(343, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 32);
            this.label5.TabIndex = 211;
            this.label5.Text = "مسئول السلفة";
            // 
            // TxtTotalAmount
            // 
            this.TxtTotalAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtTotalAmount.Location = new System.Drawing.Point(132, 78);
            this.TxtTotalAmount.Name = "TxtTotalAmount";
            this.TxtTotalAmount.Size = new System.Drawing.Size(140, 29);
            this.TxtTotalAmount.TabIndex = 4;
            this.TxtTotalAmount.Text = "0";
            this.TxtTotalAmount.TextChanged += new System.EventHandler(this.TxtTotalAmount_TextChanged);
            // 
            // DateSettlement
            // 
            this.DateSettlement.Enabled = false;
            this.DateSettlement.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateSettlement.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateSettlement.Location = new System.Drawing.Point(469, 204);
            this.DateSettlement.Name = "DateSettlement";
            this.DateSettlement.RightToLeftLayout = true;
            this.DateSettlement.Size = new System.Drawing.Size(187, 29);
            this.DateSettlement.TabIndex = 8;
            // 
            // LblDateSettlement
            // 
            this.LblDateSettlement.AutoSize = true;
            this.LblDateSettlement.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblDateSettlement.Location = new System.Drawing.Point(343, 205);
            this.LblDateSettlement.Name = "LblDateSettlement";
            this.LblDateSettlement.Size = new System.Drawing.Size(93, 32);
            this.LblDateSettlement.TabIndex = 214;
            this.LblDateSettlement.Text = "تاريخ التسوية";
            // 
            // ComboStatus
            // 
            this.ComboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Items.AddRange(new object[] {
            "تم تسويتها",
            "لم يتم تسويتها"});
            this.ComboStatus.Location = new System.Drawing.Point(132, 206);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboStatus.Size = new System.Drawing.Size(187, 30);
            this.ComboStatus.TabIndex = 7;
            this.ComboStatus.TextChanged += new System.EventHandler(this.ComboStatus_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(24, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 32);
            this.label4.TabIndex = 212;
            this.label4.Text = "مبلغ السلفة";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label45.Location = new System.Drawing.Point(24, 42);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(96, 32);
            this.label45.TabIndex = 209;
            this.label45.Text = "تاريخ الصرف";
            // 
            // ComboDocNo
            // 
            this.ComboDocNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboDocNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboDocNo.DataSource = this.temporaryLoanBindingSource;
            this.ComboDocNo.DisplayMember = "DocNo";
            this.ComboDocNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboDocNo.FormattingEnabled = true;
            this.ComboDocNo.Location = new System.Drawing.Point(132, 8);
            this.ComboDocNo.Name = "ComboDocNo";
            this.ComboDocNo.Size = new System.Drawing.Size(187, 30);
            this.ComboDocNo.TabIndex = 0;
            this.ComboDocNo.ValueMember = "DocNo";
            this.ComboDocNo.TextChanged += new System.EventHandler(this.ComboDocNo_TextChanged);
            // 
            // temporaryLoanBindingSource
            // 
            this.temporaryLoanBindingSource.DataMember = "TemporaryLoan";
            this.temporaryLoanBindingSource.DataSource = this.auditorDataSet;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Location = new System.Drawing.Point(307, 636);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 33);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "حـذف";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.Location = new System.Drawing.Point(464, 636);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 33);
            this.BtnClose.TabIndex = 13;
            this.BtnClose.Text = "إلـغــاء";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdate.Location = new System.Drawing.Point(150, 636);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 33);
            this.BtnUpdate.TabIndex = 11;
            this.BtnUpdate.Text = "تـحـديـث";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // temporaryLoanTableAdapter
            // 
            this.temporaryLoanTableAdapter.ClearBeforeFill = true;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmModifyTemporaryLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(728, 674);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.ComboDocNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtReason);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GroupSettlement);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.TxtPeriod);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.DatePayDate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ComboLocation);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.ComboEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtTotalAmount);
            this.Controls.Add(this.DateSettlement);
            this.Controls.Add(this.LblDateSettlement);
            this.Controls.Add(this.ComboStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label45);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmModifyTemporaryLoan";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات سلفة مؤقتة";
            this.Load += new System.EventHandler(this.FrmModifyTemporaryLoan_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDoubleClick);
            this.GroupSettlement.ResumeLayout(false);
            this.GroupSettlement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temporaryLoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtReason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DateEndDate;
        private System.Windows.Forms.TextBox TxtBill;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupSettlement;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtPenalty;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.DateTimePicker DateChequeExpense;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox TxtSettlementPeriod;
        private System.Windows.Forms.TextBox TxtSettlementNo;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox TxtChequeNo;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox TxtSettlementAmount;
        private System.Windows.Forms.DateTimePicker DateChequeDate;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxtNetAmount;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox TxtFees;
        private System.Windows.Forms.TextBox TxtTax;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox TxtAmountToPay;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPaidAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtRevenues;
        private System.Windows.Forms.TextBox TxtTotalDiscount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TxtPeriod;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker DatePayDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox ComboLocation;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox ComboEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotalAmount;
        private System.Windows.Forms.DateTimePicker DateSettlement;
        private System.Windows.Forms.Label LblDateSettlement;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox ComboDocNo;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnUpdate;
        private AuditorDataSet auditorDataSet;
        private System.Windows.Forms.BindingSource temporaryLoanBindingSource;
        private AuditorDataSetTableAdapters.TemporaryLoanTableAdapter temporaryLoanTableAdapter;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private AuditorDataSetTableAdapters.LocationTableAdapter locationTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private AuditorDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}