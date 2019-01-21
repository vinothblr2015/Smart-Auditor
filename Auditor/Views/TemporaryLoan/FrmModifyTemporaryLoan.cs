using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Auditor.Models;

namespace Auditor
{
    public partial class FrmModifyTemporaryLoan : Form
    {
        //Define Classes
        MathOperations Maths = new MathOperations();
        public FrmModifyTemporaryLoan()
        {
            InitializeComponent();
        }

        private void FrmModifyTemporaryLoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.auditorDataSet.Employee);
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.auditorDataSet.Location);
            // TODO: This line of code loads data into the 'auditorDataSet.TemporaryLoan' table. You can move, or remove it, as needed.
            this.temporaryLoanTableAdapter.Fill(this.auditorDataSet.TemporaryLoan);
            // Formatting the form:
            ComboDocNo.Text = "";
            ComboLocation.Text = "";
            ComboEmployee.Text = "";
            TxtTotalAmount.Text = "";
            ComboStatus.Text = "لم يتم تسويتها";
            TxtFees.Text = "0.00";
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void ComboDocNo_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            if (ComboDocNo.Text == "")
            {
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnDelete.Enabled = true;
            }

            if (ComboStatus.Text == "لم يتم تسويتها")
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
            else
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" || TxtChequeNo.Text == "" || TxtSettlementAmount.Text == "0")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }

            // Loading data into the form:
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    if (ComboDocNo.Text != "")
                    {
                        DateTime? VarPayDate = null;
                        int? IntLocationID = null;
                        string StrLocation = null;
                        int? IntEmployeeID = null;
                        string StrEmployee = null;
                        decimal? decimalTotalAmount = null;
                        int? IntPeriod = null;
                        string StrResason = null;
                        string StrStatues = null;
                        DateTime? varSettlementDate = null;
                        string StrChequeNo = null;
                        DateTime? VarChequeDate = null;
                        DateTime? VarExpenseDate = null;
                        DateTime? VarEndDate = null;
                        decimal? decimalSettlementAmount = null;
                        int? IntSettlementPEriod = null;
                        decimal? decimalTax = null;
                        decimal? decimalPenalty = null;
                        decimal? decimalFees = null;
                        decimal? decimalRevenues = null;
                        decimal? decimalNetAmount = null;
                        decimal? decimalTotalDiscount = null;
                        decimal? decimalAmountToPay = null;
                        decimal? decimalPaidAmount = null;
                        string StrBillNo = null;
                        string StrSettlementNo = null;
                        string StrNotes = null;
                        var c = dc.ProSelectTempLoan(ComboDocNo.Text, ref VarPayDate, ref IntLocationID, ref IntEmployeeID, ref decimalTotalAmount, ref IntPeriod, ref StrResason, ref StrStatues, ref varSettlementDate, ref StrChequeNo, ref VarChequeDate, ref VarExpenseDate, ref VarEndDate, ref decimalSettlementAmount, ref IntSettlementPEriod, ref decimalTax, ref decimalPenalty, ref decimalFees, ref decimalRevenues, ref decimalNetAmount, ref decimalTotalDiscount, ref decimalAmountToPay, ref decimalPaidAmount, ref StrBillNo, ref StrSettlementNo, ref StrNotes);
                        DatePayDate.Value = VarPayDate.Value;
                        var d = dc.ProGetLocationByID(IntLocationID, ref StrLocation);
                        ComboLocation.Text = StrLocation;
                        var x = dc.ProGetEmployeeByID(IntEmployeeID, ref StrEmployee);
                        ComboEmployee.Text = StrEmployee;
                        TxtTotalAmount.Text = decimalTotalAmount.ToString();
                        TxtPeriod.Text = IntPeriod.ToString();
                        TxtReason.Text = StrResason;
                        ComboStatus.Text = StrStatues;
                        if (varSettlementDate != null)
                        {
                            DateSettlement.Value = varSettlementDate.Value;
                        }                        
                        TxtChequeNo.Text = StrChequeNo;
                        if (VarChequeDate != null)
                        {
                            DateChequeDate.Value = VarChequeDate.Value;
                        }                        
                        if (VarExpenseDate != null)
                        {
                            DateChequeExpense.Value = VarExpenseDate.Value;
                        }                        
                        if (VarExpenseDate != null)
                        {
                            DateChequeExpense.Value = VarExpenseDate.Value;
                        }
                        if (VarEndDate != null)
                        {
                            DateEndDate.Value = VarEndDate.Value;
                        }
                        TxtSettlementAmount.Text = decimalSettlementAmount.ToString();
                        TxtSettlementPeriod.Text = IntSettlementPEriod.ToString();
                        TxtTax.Text = decimalTax.ToString();
                        TxtPenalty.Text = decimalPenalty.ToString();
                        TxtFees.Text = decimalFees.ToString();
                        TxtRevenues.Text = decimalRevenues.ToString();
                        TxtNetAmount.Text = decimalNetAmount.ToString();
                        TxtTotalDiscount.Text = decimalTotalDiscount.ToString();
                        TxtAmountToPay.Text = decimalAmountToPay.ToString();
                        TxtPaidAmount.Text = decimalPaidAmount.ToString();
                        TxtBill.Text = StrBillNo;
                        TxtSettlementNo.Text = StrSettlementNo;
                        TxtNotes.Text = StrNotes;
                    }
                    else
                    {
                        DatePayDate.Value = DateTime.Now;
                        ComboLocation.Text = "";
                        ComboEmployee.Text = "";
                        TxtTotalAmount.Text = "";
                        TxtPeriod.Text = "";
                        TxtReason.Text = "";
                        ComboStatus.Text = "";
                        DateSettlement.Value = DateTime.Now;
                        TxtChequeNo.Text = "";
                        DateChequeDate.Value = DateTime.Now;
                        DateChequeExpense.Value = DateTime.Now;
                        DateEndDate.Value = DateTime.Now;
                        TxtSettlementAmount.Text = "";
                        TxtSettlementPeriod.Text = "";
                        TxtTax.Text = "";
                        TxtPenalty.Text = "";
                        TxtFees.Text = "";
                        TxtRevenues.Text = "";
                        TxtNetAmount.Text = "";
                        TxtTotalDiscount.Text = "";
                        TxtAmountToPay.Text = "";
                        TxtPaidAmount.Text = "";
                        TxtBill.Text = "";
                        TxtSettlementNo.Text = "";
                        TxtNotes.Text = "";
                    }

                }
            }
            catch (NullReferenceException)
            {
            }
            catch (InvalidOperationException)
            {
                DatePayDate.Value = DateTime.Now;
                ComboLocation.Text = "";
                ComboEmployee.Text = "";
                TxtTotalAmount.Text = "";
                TxtPeriod.Text = "";
                TxtReason.Text = "";
                ComboStatus.Text = "";
                DateSettlement.Value = DateTime.Now;
                TxtChequeNo.Text = "";
                DateChequeDate.Value = DateTime.Now;
                DateChequeExpense.Value = DateTime.Now;
                DateEndDate.Value = DateTime.Now;
                TxtSettlementAmount.Text = "";
                TxtSettlementPeriod.Text = "";
                TxtTax.Text = "";
                TxtPenalty.Text = "";
                TxtFees.Text = "";
                TxtRevenues.Text = "";
                TxtNetAmount.Text = "";
                TxtTotalDiscount.Text = "";
                TxtAmountToPay.Text = "";
                TxtPaidAmount.Text = "";
                TxtBill.Text = "";
                TxtSettlementNo.Text = "";
                TxtNotes.Text = "";
                BtnDelete.Enabled = false;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message.ToString());
            }
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            if (ComboStatus.Text == "لم يتم تسويتها")
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }                
            }
            else
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" || TxtChequeNo.Text == "" || TxtSettlementAmount.Text == "0")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
        }

        private void ComboEmployee_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            if (ComboStatus.Text == "لم يتم تسويتها")
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
            else
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" || TxtChequeNo.Text == "" || TxtSettlementAmount.Text == "0")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
        }

        private void TxtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            MathOperations.AmountZeroFormat(TxtTotalAmount);
            if (ComboStatus.Text == "لم يتم تسويتها")
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
            else
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" || TxtChequeNo.Text == "" || TxtSettlementAmount.Text == "0")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
            // Math operations:
            MathOperations.TemporaryLoan(TxtTotalAmount, TxtSettlementAmount, TxtTax, TxtPenalty, TxtFees, TxtRevenues, TxtTotalDiscount, TxtNetAmount, TxtAmountToPay, TxtPaidAmount);
            MathOperations.TempLoanPenalty(TxtPeriod, TxtSettlementPeriod, TxtTotalAmount, TxtPenalty);
        }

        private void ComboStatus_TextChanged(object sender, EventArgs e)
        {
            //Formatting the form:
            if (ComboStatus.Text == "تم تسويتها")
            {
                DateSettlement.Enabled = true;
                GroupSettlement.Enabled = true;
                
            }
            else
            {
                DateSettlement.Enabled = false;
                GroupSettlement.Enabled = false;
                DateSettlement.Value = DateTime.Now;
                TxtChequeNo.Text = "";
                DateChequeDate.Value = DateTime.Now;
                DateChequeExpense.Value = DateTime.Now;
                DateEndDate.Value = DateTime.Now;
                TxtSettlementAmount.Text = "";
                TxtSettlementPeriod.Text = "";
                TxtTax.Text = "";
                TxtPenalty.Text = "";
                TxtFees.Text = "";
                TxtRevenues.Text = "";
                TxtNetAmount.Text = "";
                TxtTotalDiscount.Text = "";
                TxtAmountToPay.Text = "";
                TxtPaidAmount.Text = "";
                TxtBill.Text = "";
                TxtSettlementNo.Text = "";
                TxtNotes.Text = "";
            }
            // Formatting the form:           
            if (ComboStatus.Text == "لم يتم تسويتها")
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
            else
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" || TxtChequeNo.Text == "" || TxtSettlementAmount.Text == "0")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
        }

        private void TxtPeriod_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            MathOperations.PeriodZeroFormat(TxtPeriod);
            MathOperations.TempLoanPenalty(TxtPeriod, TxtSettlementPeriod, TxtTotalAmount, TxtPenalty);
            try
            {
                int.Parse(TxtPeriod.Text);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

            if (ComboStatus.Text == "لم يتم تسويتها")
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
            else
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" || TxtChequeNo.Text == "" || TxtSettlementAmount.Text == "0")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
        }

        private void TxtReason_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            if (ComboStatus.Text == "لم يتم تسويتها")
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
            else
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" || TxtChequeNo.Text == "" || TxtSettlementAmount.Text == "0")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
        }

        private void TxtChequeNo_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            if (ComboStatus.Text == "لم يتم تسويتها")
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
            else
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" || TxtChequeNo.Text == "" || TxtSettlementAmount.Text == "0")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
        }

        private void TxtSettlementAmount_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            MathOperations.AmountZeroFormat(TxtSettlementAmount);
            if (ComboStatus.Text == "لم يتم تسويتها")
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
            else
            {
                if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" || TxtChequeNo.Text == "" || TxtSettlementAmount.Text == "0")
                {
                    BtnUpdate.Enabled = false;
                }
                else
                {
                    BtnUpdate.Enabled = true;
                }
            }
            // Math operations:
            MathOperations.TemporaryLoan(TxtTotalAmount, TxtSettlementAmount, TxtTax, TxtPenalty, TxtFees, TxtRevenues, TxtTotalDiscount, TxtNetAmount, TxtAmountToPay, TxtPaidAmount);
        }

        private void TxtSettlementPeriod_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            MathOperations.PeriodZeroFormat(TxtSettlementPeriod);
            try
            {
                int.Parse(TxtSettlementPeriod.Text);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

            // Math operations:
            MathOperations.TemporaryLoan(TxtTotalAmount, TxtSettlementAmount, TxtTax, TxtPenalty, TxtFees, TxtRevenues, TxtTotalDiscount, TxtNetAmount, TxtAmountToPay, TxtPaidAmount);
            MathOperations.TempLoanPenalty(TxtPeriod, TxtSettlementPeriod, TxtTotalAmount, TxtPenalty);
        }

        private void TxtPenalty_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            MathOperations.AmountZeroFormat(TxtPenalty);
            // Math operations:
            MathOperations.TemporaryLoan(TxtTotalAmount, TxtSettlementAmount, TxtTax, TxtPenalty, TxtFees, TxtRevenues, TxtTotalDiscount, TxtNetAmount, TxtAmountToPay, TxtPaidAmount);
        }

        private void TxtTax_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            MathOperations.AmountZeroFormat(TxtTax);
            // Math operations:
            MathOperations.TemporaryLoan(TxtTotalAmount, TxtSettlementAmount, TxtTax, TxtPenalty, TxtFees, TxtRevenues, TxtTotalDiscount, TxtNetAmount, TxtAmountToPay, TxtPaidAmount);
        }

        private void TxtFees_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            MathOperations.AmountZeroFormat(TxtFees);
            // Math operations:
            MathOperations.TemporaryLoan(TxtTotalAmount, TxtSettlementAmount, TxtTax, TxtPenalty, TxtFees, TxtRevenues, TxtTotalDiscount, TxtNetAmount, TxtAmountToPay, TxtPaidAmount);
        }

        private void TxtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            MathOperations.AmountZeroFormat(TxtPaidAmount);
            try
            {
                decimal PaidAmount = decimal.Parse(TxtPaidAmount.Text);
                if (PaidAmount > 0)
                {
                    TxtBill.Enabled = true;
                }
                else
                {
                    TxtBill.Enabled = false;
                    TxtBill.Text = "";
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            // Math operations:
            MathOperations.TemporaryLoan(TxtTotalAmount, TxtSettlementAmount, TxtTax, TxtPenalty, TxtFees, TxtRevenues, TxtTotalDiscount, TxtNetAmount, TxtAmountToPay, TxtPaidAmount);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProUpdateTempLoan(ComboDocNo.Text, DatePayDate.Value, int.Parse(ComboLocation.SelectedValue.ToString()), int.Parse(ComboEmployee.SelectedValue.ToString()), decimal.Parse(TxtTotalAmount.Text), int.Parse(TxtPeriod.Text), TxtReason.Text, ComboStatus.Text, DateSettlement.Value, TxtChequeNo.Text, DateChequeDate.Value, DateChequeExpense.Value, DateEndDate.Value, decimal.Parse(TxtSettlementAmount.Text), int.Parse(TxtSettlementPeriod.Text), decimal.Parse(TxtTax.Text), decimal.Parse(TxtPenalty.Text), decimal.Parse(TxtFees.Text), decimal.Parse(TxtRevenues.Text), decimal.Parse(TxtNetAmount.Text), decimal.Parse(TxtTotalDiscount.Text), decimal.Parse(TxtAmountToPay.Text), decimal.Parse(TxtPaidAmount.Text), TxtBill.Text, TxtSettlementNo.Text, TxtNotes.Text);
                    MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FrmModifyTemporaryLoan Frm = new FrmModifyTemporaryLoan();
                    Frm.Show();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message.ToString());
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Rslt = MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Rslt == DialogResult.Yes)
                {
                    using (DBAuditDataContext dc = new DBAuditDataContext())
                    {
                        var c = dc.ProDeleteTempLoan(ComboDocNo.Text);
                    }
                    MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FrmModifyTemporaryLoan Frm = new FrmModifyTemporaryLoan();
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
        private void Frm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Close();
            FrmModifyTemporaryLoan Frm = new FrmModifyTemporaryLoan();
            Frm.Show();
        }
    }
}

