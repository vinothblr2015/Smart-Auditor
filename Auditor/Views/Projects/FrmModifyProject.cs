using System;
using System.Windows.Forms;
using Auditor.Models;

namespace Auditor.Views.Projects
{
    public partial class FrmModifyProject : Form
    {
        public FrmModifyProject()
        {
            InitializeComponent();
        }

        private void FrmModifyProject_Load(object sender, EventArgs e)
        {
            contractorTableAdapter.Fill(auditorDataSet.Contractor);
            locationTableAdapter.Fill(auditorDataSet.Location);
            projectTableAdapter.Fill(auditorDataSet.Project);
           
            //Formatting Data:
            ComboDocNo.Text = "";
            TxtPredicationOrder.Text = "";
            ComboLocation.Text = "";
            ComboContractor.Text = "";
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;

            //Calculate discounts While loading the form //
            MathOperations.Percent(TxtAmount, TxtTaxRate, TxtTaxAmount);
            MathOperations.Percent(TxtAmount, TxtTransRate, TxtTransAmount);
            MathOperations.Percent(TxtAmount, TxtInsurRate, TxtInsurAmount);
            MathOperations.Percent(TxtAmount, TxtReservedRate, TxtReservedAmount);
            MathOperations.OPerationFees(TxtAmount, TxtBusinessFees);
            MathOperations.ActualPeriod(DateStart, DateEnd, TxtActualPeriod, "Project");
            MathOperations.CountPenalty(TxtPeriod, TxtActualPeriod, TxtAmount, TxtPenalty);
            MathOperations.NetAmount(TxtAmount, TxtTaxAmount, TxtTransAmount, TxtInsurAmount, TxtReservedAmount,
                TxtBusinessFees, TxtPenalty, TxtTotalDiscount, TxtNetAmount);
            MathOperations.AfterPayProject(ComboReservedRefund, TxtAmount, TxtReservedAmount, TxtResDiscountPercentage,
                TxtResDiscountAmount, TxtReservedPaid);
            MathOperations.AfterPayProject(ComboInsuranceRefund, TxtAmount, TxtInsurAmount, TxtInsurDiscountPercentage,
                TxtInsuranceDiscountAmount, TxtInsurancePaid);
        }

        //
        // Claclate discounts by rates
        //
        private void TxtTaxRate_TextChanged(object sender, EventArgs e)
        {
            if (TxtTaxRate.Text != "")
            {
                //Calculate discounts While loading the form
                MathOperations.Percent(TxtAmount, TxtTaxRate, TxtTaxAmount);
                MathOperations.Percent(TxtAmount, TxtTransRate, TxtTransAmount);
                MathOperations.Percent(TxtAmount, TxtInsurRate, TxtInsurAmount);
                MathOperations.Percent(TxtAmount, TxtReservedRate, TxtReservedAmount);
                MathOperations.OPerationFees(TxtAmount, TxtBusinessFees);
                MathOperations.ActualPeriod(DateStart, DateEnd, TxtActualPeriod, "Project");
                MathOperations.CountPenalty(TxtPeriod, TxtActualPeriod, TxtAmount, TxtPenalty);
                MathOperations.NetAmount(TxtAmount, TxtTaxAmount, TxtTransAmount, TxtInsurAmount, TxtReservedAmount,
                    TxtBusinessFees, TxtPenalty, TxtTotalDiscount, TxtNetAmount);
            }
            else
            {
                TxtTaxRate.Text = "0.0";
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    // Detect DateTime Start
                    DateTime? VarReservedPayDate;
                    DateTime? VareInsurancePayDate;
                    if (DateResevedPay.Enabled == true)
                    {
                        VarReservedPayDate = DateResevedPay.Value;
                    }
                    else
                    {
                        VarReservedPayDate = null;
                    }
                    if (DateInsurancePay.Enabled == true)
                    {
                        VareInsurancePayDate = DateInsurancePay.Value;
                    }
                    else
                    {
                        VareInsurancePayDate = null;
                    }
                    // Detect DateTime End
                    //
                    // Update process Start
                    var c = dc.ProUpdateProject(int.Parse(ComboLocation.SelectedValue.ToString()),
                        int.Parse(ComboContractor.SelectedValue.ToString()), TxtExcuteOrder.Text, DateExcuteOrder.Value,
                        TxtPredicationOrder.Text, DatePredicationOreder.Value, int.Parse(TxtPeriod.Text),
                        ComboDocNo.Text, DateStart.Value, DateEnd.Value, int.Parse(TxtActualPeriod.Text),
                        TxtOperation.Text, Convert.ToDecimal(TxtAmount.Text), DatePay.Value,
                        Convert.ToDecimal(TxtTaxRate.Text), Convert.ToDecimal(TxtTaxAmount.Text),
                        Convert.ToDecimal(TxtTransRate.Text), Convert.ToDecimal(TxtTransAmount.Text),
                        Convert.ToDecimal(TxtInsurRate.Text), Convert.ToDecimal(TxtInsurAmount.Text),
                        ComboInsuranceRefund.Text, Convert.ToDecimal(TxtReservedRate.Text),
                        Convert.ToDecimal(TxtReservedAmount.Text), ComboReservedRefund.Text,
                        Convert.ToDecimal(TxtBusinessFees.Text), Convert.ToDecimal(TxtTotalDiscount.Text),
                        Convert.ToDecimal(TxtNetAmount.Text), TxtJustAmount.Text, TxtReservedDocNo.Text,
                        VarReservedPayDate, Convert.ToDecimal(TxtResDiscountPercentage.Text),
                        Convert.ToDecimal(TxtResDiscountAmount.Text), Convert.ToDecimal(TxtReservedPaid.Text),
                        TxtInsuranceDocNo.Text, VareInsurancePayDate,
                        Convert.ToDecimal(TxtInsurDiscountPercentage.Text),
                        Convert.ToDecimal(TxtInsuranceDiscountAmount.Text), Convert.ToDecimal(TxtInsurancePaid.Text),
                        TxtNotes.Text);
                }
                MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
                FrmModifyProject Frm = new FrmModifyProject();
                Frm.Show();
                // Update process End
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Rslt = MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Rslt == DialogResult.Yes)
                {
                    using (DBAuditDataContext dc = new DBAuditDataContext())
                    {
                        var c = dc.ProDeleteProject(ComboDocNo.Text);
                    }
                    MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                    FrmModifyProject Frm = new FrmModifyProject();
                    Frm.Show();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPredicationOrder_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (TxtPredicationOrder.Text == "" || DatePredicationOreder.Text == DateTime.Now.ToShortDateString())
            {
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnDelete.Enabled = true;
            }

            if (TxtPredicationOrder.Text == "" || ComboLocation.Text == "" || ComboContractor.Text == "" ||
                TxtExcuteOrder.Text == "" || TxtPeriod.Text == "0" || ComboDocNo.Text == "" ||
                TxtOperation.Text == "" || TxtAmount.Text == "0" || ComboReservedRefund.Text == "" ||
                ComboInsuranceRefund.Text == "" || TxtJustAmount.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void DatePredicationSearch_ValueChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (TxtPredicationOrder.Text == "" || DatePredicationOreder.Text == DateTime.Now.ToShortDateString())
            {
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnDelete.Enabled = true;
            }
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (TxtPredicationOrder.Text == "" || ComboLocation.Text == "" || ComboContractor.Text == "" ||
                TxtExcuteOrder.Text == "" || TxtPeriod.Text == "0" || ComboDocNo.Text == "" ||
                TxtOperation.Text == "" || TxtAmount.Text == "0" || ComboReservedRefund.Text == "" ||
                ComboInsuranceRefund.Text == "" || TxtJustAmount.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void ComboContractor_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (TxtPredicationOrder.Text == "" || ComboLocation.Text == "" || ComboContractor.Text == "" ||
                TxtExcuteOrder.Text == "" || TxtPeriod.Text == "0" || ComboDocNo.Text == "" ||
                TxtOperation.Text == "" || TxtAmount.Text == "0" || ComboReservedRefund.Text == "" ||
                ComboInsuranceRefund.Text == "" || TxtJustAmount.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void TxtExcuteOrder_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (TxtPredicationOrder.Text == "" || ComboLocation.Text == "" || ComboContractor.Text == "" ||
                TxtExcuteOrder.Text == "" || TxtPeriod.Text == "0" || ComboDocNo.Text == "" ||
                TxtOperation.Text == "" || TxtAmount.Text == "0" || ComboReservedRefund.Text == "" ||
                ComboInsuranceRefund.Text == "" || TxtJustAmount.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void TxtpredicationOrder_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (TxtPredicationOrder.Text == "" || ComboLocation.Text == "" || ComboContractor.Text == "" ||
                TxtExcuteOrder.Text == "" || TxtPeriod.Text == "0" || ComboDocNo.Text == "" ||
                TxtOperation.Text == "" || TxtAmount.Text == "0" || ComboReservedRefund.Text == "" ||
                ComboInsuranceRefund.Text == "" || TxtJustAmount.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void TxtPeriod_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (TxtPredicationOrder.Text == "" || ComboLocation.Text == "" || ComboContractor.Text == "" ||
                TxtExcuteOrder.Text == "" || TxtPeriod.Text == "0" || ComboDocNo.Text == "" ||
                TxtOperation.Text == "" || TxtAmount.Text == "0" || ComboReservedRefund.Text == "" ||
                ComboInsuranceRefund.Text == "" || TxtJustAmount.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
            //
            //Calculate discounts While loading the form
            //
            MathOperations.Percent(TxtAmount, TxtTaxRate, TxtTaxAmount);
            MathOperations.Percent(TxtAmount, TxtTransRate, TxtTransAmount);
            MathOperations.Percent(TxtAmount, TxtInsurRate, TxtInsurAmount);
            MathOperations.Percent(TxtAmount, TxtReservedRate, TxtReservedAmount);
            MathOperations.OPerationFees(TxtAmount, TxtBusinessFees);
            MathOperations.ActualPeriod(DateStart, DateEnd, TxtActualPeriod, "Project");
            MathOperations.CountPenalty(TxtPeriod, TxtActualPeriod, TxtAmount, TxtPenalty);
            MathOperations.NetAmount(TxtAmount, TxtTaxAmount, TxtTransAmount, TxtInsurAmount, TxtReservedAmount,
                TxtBusinessFees, TxtPenalty, TxtTotalDiscount, TxtNetAmount);
        }


        private void ComboDocNo_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (ComboDocNo.Text == "")
            {
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnDelete.Enabled = true;
            }
            if (TxtPredicationOrder.Text == "" || ComboLocation.Text == "" || ComboContractor.Text == "" ||
                TxtExcuteOrder.Text == "" || TxtPeriod.Text == "0" || ComboDocNo.Text == "" ||
                TxtOperation.Text == "" || TxtAmount.Text == "0" || ComboReservedRefund.Text == "" ||
                ComboInsuranceRefund.Text == "" || TxtJustAmount.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
            //
            // Loading data to form:
            //
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    if (ComboDocNo.Text != "")
                    {
                        int? IntLocationID = null;
                        int? IntContractorID = null;
                        string StrExcuteOrder = null;
                        DateTime? VarExcuteDate = null;
                        string StrPredicationOder = null;
                        DateTime? VarPredicationDate = null;
                        int? IntPeriod = null;
                        DateTime? VarStartDate = null;
                        DateTime? VarEndDate = null;
                        int? IntActualPeriod = null;
                        string StrName = null;
                        decimal? DecimalValue = null;
                        DateTime? VarDatePay = null;
                        decimal? DecimalTaxRate = null;
                        decimal? DecimalTaxValue = null;
                        decimal? DecimalTransFeesRate = null;
                        decimal? DecimalTransFeesValue = null;
                        decimal? DecimalInsuranceRate = null;
                        decimal? DecimalInsuranceValue = null;
                        string StrInsuranceRefund = null;
                        decimal? DecimalReservedRate = null;
                        decimal? DecimalReservedValue = null;
                        string StrReservedRefund = null;
                        decimal? DecimalBusinessFees = null;
                        decimal? DecimalTotalDiscount = null;
                        decimal? DecimalNetAmount = null;
                        string StrJustAmount = null;
                        string StrReservedDocNo = null;
                        DateTime? VarReservedPayDate = null;
                        decimal? DecimalResDiscPercent = null;
                        decimal? DecimalResDiscount = null;
                        decimal? DecimalResPaid = null;
                        string StrInsDocNo = null;
                        DateTime? varInsurancePayDate = null;
                        decimal? DecimalInsDiscPercent = null;
                        decimal? DecimalInsDiscount = null;
                        decimal? DecimalInsurancePaid = null;
                        string StrNotes = null;
                        string StrLocation = null;
                        string StrContractor = null;
                        dc.ProSelectProject(ref IntLocationID, ref IntContractorID, ref StrExcuteOrder,
                            ref VarExcuteDate, ref StrPredicationOder, ref VarPredicationDate, ref IntPeriod,
                            ComboDocNo.SelectedValue.ToString(), ref VarStartDate, ref VarEndDate, ref IntActualPeriod, ref StrName,
                            ref DecimalValue, ref VarDatePay, ref DecimalTaxRate, ref DecimalTaxValue,
                            ref DecimalTransFeesRate, ref DecimalTransFeesValue, ref DecimalInsuranceRate,
                            ref DecimalInsuranceValue, ref StrInsuranceRefund, ref DecimalReservedRate,
                            ref DecimalReservedValue, ref StrReservedRefund, ref DecimalBusinessFees,
                            ref DecimalTotalDiscount, ref DecimalNetAmount, ref StrJustAmount, ref StrReservedDocNo,
                            ref VarReservedPayDate, ref DecimalResDiscPercent, ref DecimalResDiscount,
                            ref DecimalResPaid, ref StrInsDocNo, ref varInsurancePayDate, ref DecimalInsDiscPercent,
                            ref DecimalInsDiscount, ref DecimalInsurancePaid, ref StrNotes);
                        TxtExcuteOrder.Text = StrExcuteOrder;
                        DateExcuteOrder.Value = VarExcuteDate.Value;
                        TxtPredicationOrder.Text = StrPredicationOder;
                        DatePredicationOreder.Value = VarPredicationDate.Value;
                        TxtPeriod.Text = IntPeriod.ToString();
                        DateStart.Value = VarStartDate.Value;
                        DateEnd.Value = VarEndDate.Value;
                        TxtActualPeriod.Text = IntActualPeriod.ToString();
                        TxtOperation.Text = StrName;
                        TxtAmount.Text = DecimalValue.ToString();
                        DatePay.Value = VarDatePay.Value;
                        TxtTaxRate.Text = DecimalTaxRate.ToString();
                        TxtTaxAmount.Text = DecimalTaxValue.ToString();
                        TxtTransRate.Text = DecimalTransFeesRate.ToString();
                        TxtTransAmount.Text = DecimalTransFeesValue.ToString();
                        TxtInsurRate.Text = DecimalInsuranceRate.ToString();
                        TxtInsurAmount.Text = DecimalInsuranceValue.ToString();
                        ComboReservedRefund.Text = StrInsuranceRefund;
                        TxtReservedRate.Text = DecimalReservedRate.ToString();
                        TxtReservedAmount.Text = DecimalReservedValue.ToString();
                        ComboInsuranceRefund.Text = StrReservedRefund;
                        TxtBusinessFees.Text = DecimalBusinessFees.ToString();
                        TxtTotalDiscount.Text = DecimalTotalDiscount.ToString();
                        TxtNetAmount.Text = DecimalNetAmount.ToString();
                        TxtJustAmount.Text = StrJustAmount;
                        TxtReservedDocNo.Text = StrReservedDocNo;
                        if (VarReservedPayDate != null)
                        {
                            DateResevedPay.Value = VarReservedPayDate.Value;
                        }
                        else
                        {
                            DateResevedPay.Value = DateTime.Now;
                        }
                        TxtResDiscountPercentage.Text = DecimalResDiscPercent.ToString();
                        TxtResDiscountAmount.Text = DecimalResDiscount.ToString();
                        TxtReservedPaid.Text = DecimalResPaid.ToString();
                        TxtInsuranceDocNo.Text = StrInsDocNo;
                        if (varInsurancePayDate != null)
                        {
                            DateInsurancePay.Value = varInsurancePayDate.Value;
                        }
                        else
                        {
                            DateInsurancePay.Value = DateTime.Now;
                        }
                        TxtInsurDiscountPercentage.Text = DecimalInsDiscPercent.ToString();
                        TxtInsuranceDiscountAmount.Text = DecimalInsDiscount.ToString();
                        TxtInsurancePaid.Text = DecimalInsurancePaid.ToString();
                        TxtNotes.Text = StrNotes;
                        DatePay.Value = VarDatePay.Value;
                        var d = dc.ProGetLocationByID(IntLocationID, ref StrLocation);
                        ComboLocation.Text = StrLocation;
                        var x = dc.ProGetContractorByID(IntContractorID, ref StrContractor);
                        ComboContractor.Text = StrContractor;
                        TxtNotes.Text = StrNotes;
                    }
                    else
                    {
                        ComboLocation.Text = "";
                        ComboContractor.Text = "";
                        TxtExcuteOrder.Text = "";
                        DateExcuteOrder.Value = DatePredicationOreder.Value =
                            DateStart.Value = DateEnd.Value = DatePay.Value = DateTime.Now;
                        TxtPredicationOrder.Text = "";
                        TxtPeriod.Text = "0";
                        TxtActualPeriod.Text = "";
                        TxtOperation.Text = "";
                        TxtAmount.Text = "0.00";
                        TxtTaxAmount.Text = "0.00";
                        TxtTransAmount.Text = "0.00";
                        TxtInsurAmount.Text = "0.00";
                        ComboReservedRefund.Text = "";
                        TxtReservedAmount.Text = "0.00";
                        ComboInsuranceRefund.Text = "";
                        TxtBusinessFees.Text = "0.00";
                        TxtTotalDiscount.Text = "0.00";
                        TxtNetAmount.Text = "0.00";
                        TxtJustAmount.Text = "";
                        TxtReservedDocNo.Text = null;
                        DateResevedPay.Value = DateTime.Now;
                        ;
                        TxtResDiscountPercentage.Text = null;
                        TxtResDiscountAmount.Text = null;
                        TxtReservedPaid.Text = null;
                        TxtInsuranceDocNo.Text = null;
                        DateInsurancePay.Value = DateTime.Now;
                        TxtInsurDiscountPercentage.Text = null;
                        TxtInsuranceDiscountAmount.Text = null;
                        TxtInsurancePaid.Text = null;
                        TxtNotes.Text = null;
                    }
                }
            }
            catch (NullReferenceException)
            {
            }
            catch (InvalidOperationException IEX)
            {
                MessageBox.Show(IEX.Message);
                ComboLocation.Text = "";
                ComboContractor.Text = "";
                TxtExcuteOrder.Text = "";
                DateExcuteOrder.Value = DatePredicationOreder.Value =
                    DateStart.Value = DateEnd.Value = DatePay.Value = DateTime.Now;
                TxtPredicationOrder.Text = "";
                TxtPeriod.Text = "0";
                TxtActualPeriod.Text = "";
                TxtOperation.Text = "";
                TxtAmount.Text = "0.00";
                TxtTaxAmount.Text = "0.00";
                TxtTransAmount.Text = "0.00";
                TxtInsurAmount.Text = "0.00";
                ComboReservedRefund.Text = "";
                TxtReservedAmount.Text = "0.00";
                ComboInsuranceRefund.Text = "";
                TxtBusinessFees.Text = "0.00";
                TxtTotalDiscount.Text = "0.00";
                TxtNetAmount.Text = "0.00";
                TxtJustAmount.Text = "";
                TxtReservedDocNo.Text = null;
                DateResevedPay.Value = DateTime.Now;
                ;
                TxtResDiscountPercentage.Text = null;
                TxtResDiscountAmount.Text = null;
                TxtReservedPaid.Text = null;
                TxtInsuranceDocNo.Text = null;
                DateInsurancePay.Value = DateTime.Now;
                TxtInsurDiscountPercentage.Text = null;
                TxtInsuranceDiscountAmount.Text = null;
                TxtInsurancePaid.Text = null;
                TxtNotes.Text = "";
                BtnDelete.Enabled = false;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                ComboLocation.Text = "";
                ComboContractor.Text = "";
                TxtExcuteOrder.Text = "";
                DateExcuteOrder.Value = DatePredicationOreder.Value =
                    DateStart.Value = DateEnd.Value = DatePay.Value = DateTime.Now;
                TxtPredicationOrder.Text = "";
                TxtPeriod.Text = "0";
                TxtActualPeriod.Text = "";
                TxtOperation.Text = "";
                TxtAmount.Text = "0.00";
                TxtTaxAmount.Text = "0.00";
                TxtTransAmount.Text = "0.00";
                TxtInsurAmount.Text = "0.00";
                ComboReservedRefund.Text = "";
                TxtReservedAmount.Text = "0.00";
                ComboInsuranceRefund.Text = "";
                TxtBusinessFees.Text = "0.00";
                TxtTotalDiscount.Text = "0.00";
                TxtNetAmount.Text = "0.00";
                TxtJustAmount.Text = "";
                TxtReservedDocNo.Text = null;
                DateResevedPay.Value = DateTime.Now;
                ;
                TxtResDiscountPercentage.Text = null;
                TxtResDiscountAmount.Text = null;
                TxtReservedPaid.Text = null;
                TxtInsuranceDocNo.Text = null;
                DateInsurancePay.Value = DateTime.Now;
                TxtInsurDiscountPercentage.Text = null;
                TxtInsuranceDiscountAmount.Text = null;
                TxtInsurancePaid.Text = null;
                TxtNotes.Text = "";
                BtnDelete.Enabled = false;
            }
        }


        private void TxtOperation_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (TxtPredicationOrder.Text == "" || ComboLocation.Text == "" || ComboContractor.Text == "" ||
                TxtExcuteOrder.Text == "" || TxtPeriod.Text == "0" || ComboDocNo.Text == "" ||
                TxtOperation.Text == "" || TxtAmount.Text == "0" || ComboReservedRefund.Text == "" ||
                ComboInsuranceRefund.Text == "" || TxtJustAmount.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (TxtPredicationOrder.Text == "" || ComboLocation.Text == "" || ComboContractor.Text == "" ||
                TxtExcuteOrder.Text == "" || TxtPeriod.Text == "0" || ComboDocNo.Text == "" ||
                TxtOperation.Text == "" || TxtAmount.Text == "0" || ComboReservedRefund.Text == "" ||
                ComboInsuranceRefund.Text == "" || TxtJustAmount.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
            //Calculate discounts While loading the form
            MathOperations.Tax(TxtAmount, TxtTaxRate, TxtTaxAmount);
            MathOperations.Percent(TxtAmount, TxtTransRate, TxtTransAmount);
            MathOperations.Percent(TxtAmount, TxtInsurRate, TxtInsurAmount);
            MathOperations.Percent(TxtAmount, TxtReservedRate, TxtReservedAmount);
            MathOperations.OPerationFees(TxtAmount, TxtBusinessFees);
            MathOperations.ActualPeriod(DateStart, DateEnd, TxtActualPeriod, "Project");
            MathOperations.CountPenalty(TxtPeriod, TxtActualPeriod, TxtAmount, TxtPenalty);
            MathOperations.NetAmount(TxtAmount, TxtTaxAmount, TxtTransAmount, TxtInsurAmount, TxtReservedAmount,
                TxtBusinessFees, TxtPenalty, TxtTotalDiscount, TxtNetAmount);
            MathOperations.AfterPayProject(ComboReservedRefund, TxtAmount, TxtReservedAmount, TxtResDiscountPercentage,
                TxtResDiscountAmount, TxtReservedPaid);
            MathOperations.AfterPayProject(ComboInsuranceRefund, TxtAmount, TxtInsurAmount, TxtInsurDiscountPercentage,
                TxtInsuranceDiscountAmount, TxtInsurancePaid);
        }

        private void TxtJustAmount_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (TxtPredicationOrder.Text == "" || ComboLocation.Text == "" || ComboContractor.Text == "" ||
                TxtExcuteOrder.Text == "" || TxtPeriod.Text == "0" || ComboDocNo.Text == "" ||
                TxtOperation.Text == "" || TxtAmount.Text == "0" || ComboReservedRefund.Text == "" ||
                ComboInsuranceRefund.Text == "" || TxtJustAmount.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void TxtActualPeriod_TextChanged(object sender, EventArgs e)
        {
            //Calculate discounts While loading the form
            MathOperations.Percent(TxtAmount, TxtTaxRate, TxtTaxAmount);
            MathOperations.Percent(TxtAmount, TxtTransRate, TxtTransAmount);
            MathOperations.Percent(TxtAmount, TxtInsurRate, TxtInsurAmount);
            MathOperations.Percent(TxtAmount, TxtReservedRate, TxtReservedAmount);
            MathOperations.OPerationFees(TxtAmount, TxtBusinessFees);
            MathOperations.ActualPeriod(DateStart, DateEnd, TxtActualPeriod, "Project");
            MathOperations.CountPenalty(TxtPeriod, TxtActualPeriod, TxtAmount, TxtPenalty);
            MathOperations.NetAmount(TxtAmount, TxtTaxAmount, TxtTransAmount, TxtInsurAmount, TxtReservedAmount,
                TxtBusinessFees, TxtPenalty, TxtTotalDiscount, TxtNetAmount);
        }

        private void DateStart_ValueChanged(object sender, EventArgs e)
        {
            MathOperations.ActualPeriod(DateStart, DateEnd, TxtActualPeriod, "Project");
        }

        private void DateEnd_ValueChanged(object sender, EventArgs e)
        {
            MathOperations.ActualPeriod(DateStart, DateEnd, TxtActualPeriod, "Project");
        }

        private void ComboInsuranceRefund_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (TxtPredicationOrder.Text == "" || ComboLocation.Text == "" || ComboContractor.Text == "" ||
                TxtExcuteOrder.Text == "" || TxtPeriod.Text == "0" || ComboDocNo.Text == "" ||
                TxtOperation.Text == "" || TxtAmount.Text == "0" || ComboReservedRefund.Text == "" ||
                ComboInsuranceRefund.Text == "" || TxtJustAmount.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
            //
            if (ComboInsuranceRefund.Text == "تم الرد")
            {
                LblInsStatues.Enabled = true;
                LblInsDocNo.Enabled = true;
                LblInsPayDate.Enabled = true;
                LblInsDiscount.Enabled = true;
                LblInsPaid.Enabled = true;
                TxtInsuranceDocNo.Enabled = true;
                DateInsurancePay.Enabled = true;
                TxtInsurDiscountPercentage.Enabled = true;
            }
            else
            {
                TxtInsuranceDocNo.Text = null;
                TxtInsurDiscountPercentage.Text = "0.0";
                LblInsStatues.Enabled = false;
                LblInsDocNo.Enabled = false;
                LblInsPayDate.Enabled = false;
                LblInsDiscount.Enabled = false;
                LblInsPaid.Enabled = false;
                TxtInsuranceDocNo.Enabled = false;
                DateInsurancePay.Enabled = false;
                TxtInsurDiscountPercentage.Enabled = false;
            }
            //
            MathOperations.AfterPayProject(ComboInsuranceRefund, TxtAmount, TxtInsurAmount, TxtInsurDiscountPercentage,
                TxtInsuranceDiscountAmount, TxtInsurancePaid);
        }

        private void ComboReservedRefund_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (TxtPredicationOrder.Text == "" || ComboLocation.Text == "" || ComboContractor.Text == "" ||
                TxtExcuteOrder.Text == "" || TxtPeriod.Text == "0" || ComboDocNo.Text == "" ||
                TxtOperation.Text == "" || TxtAmount.Text == "0" || ComboReservedRefund.Text == "" ||
                ComboInsuranceRefund.Text == "" || TxtJustAmount.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
            //
            if (ComboReservedRefund.Text == "تم الرد")
            {
                LblResStatues.Enabled = true;
                LblResDocNo.Enabled = true;
                LblResPayDate.Enabled = true;
                LblResDiscount.Enabled = true;
                LblResPaid.Enabled = true;
                TxtReservedDocNo.Enabled = true;
                DateResevedPay.Enabled = true;
                TxtResDiscountPercentage.Enabled = true;
            }
            else
            {
                TxtReservedDocNo.Text = null;
                TxtResDiscountPercentage.Text = "0.0";
                LblResStatues.Enabled = false;
                LblResDocNo.Enabled = false;
                LblResPayDate.Enabled = false;
                LblResDiscount.Enabled = false;
                LblResPaid.Enabled = false;
                TxtReservedDocNo.Enabled = false;
                DateResevedPay.Enabled = false;
                TxtResDiscountPercentage.Enabled = false;
            }
            //
            MathOperations.AfterPayProject(ComboReservedRefund, TxtAmount, TxtReservedAmount, TxtResDiscountPercentage,
                TxtResDiscountAmount, TxtReservedPaid);
        }

        private void TxtAmount_Leave(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtAmount);
        }

        private void TxtBusinessFees_TextChanged(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtBusinessFees);
        }

        private void TxtReservedAmount_TextChanged(object sender, EventArgs e)
        {
            MathOperations.AfterPayProject(ComboReservedRefund, TxtAmount, TxtReservedAmount, TxtResDiscountPercentage,
                TxtResDiscountAmount, TxtReservedPaid);
        }

        private void TxtResDiscountPercentage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtResDiscountPercentage.Text))
            {
                TxtResDiscountPercentage.Text = "0";
            }
            MathOperations.AfterPayProject(ComboReservedRefund, TxtAmount, TxtReservedAmount, TxtResDiscountPercentage,
                TxtResDiscountAmount, TxtReservedPaid);
        }

        private void TxtInsurAmount_TextChanged(object sender, EventArgs e)
        {
            MathOperations.AfterPayProject(ComboInsuranceRefund, TxtAmount, TxtInsurAmount, TxtInsurDiscountPercentage,
                TxtInsuranceDiscountAmount, TxtInsurancePaid);
        }

        private void TxtInsurDiscountPercentage_TextChanged(object sender, EventArgs e)
        {
            MathOperations.AmountZeroFormat(TxtInsurDiscountPercentage);
            MathOperations.AfterPayProject(ComboInsuranceRefund, TxtAmount, TxtInsurAmount, TxtInsurDiscountPercentage,
                TxtInsuranceDiscountAmount, TxtInsurancePaid);
        }

        private void TxtResDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            MathOperations.AmountZeroFormat(TxtResDiscountAmount);
        }

        private void TxtReservedPaid_TextChanged(object sender, EventArgs e)
        {
            MathOperations.AmountZeroFormat(TxtReservedPaid);
        }

        private void TxtInsuranceDiscountAmount_TextChanged(object sender, EventArgs e)
        {
            MathOperations.AmountZeroFormat(TxtInsuranceDiscountAmount);
        }

        private void TxtInsurancePaid_TextChanged(object sender, EventArgs e)
        {
            MathOperations.AmountZeroFormat(TxtInsurancePaid);
        }

        private void ComboDocNo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}