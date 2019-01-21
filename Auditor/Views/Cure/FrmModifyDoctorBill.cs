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
    public partial class FrmModifyDoctorBill : Form
    {
        public FrmModifyDoctorBill()
        {
            InitializeComponent();
        }
        // Formatting BtnAUpdate
        public void FormatBtnUpdate(ComboBox ComboDocNo, TextBox TxtDocNo, ComboBox ComboLocation, ComboBox ComboDoctor, TextBox TxtAmount, TextBox TxtDetails)
        {
            if (ComboDocNo.Text == "" || TxtDocNo.Text == "" || ComboLocation.Text == "" || ComboDoctor.Text == "" || TxtAmount.Text == "0.00" || TxtDetails.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }
        // Formatting BtnDelete
        public void FormatBtnDelete(ComboBox ComboDocNo)
        {
            if (ComboDocNo.Text == "")
            {
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnDelete.Enabled = true;
            }
        }
        private void FrmModifyDoctorBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.auditorDataSet.Doctor);
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.auditorDataSet.Location);
            // TODO: This line of code loads data into the 'auditorDataSet.DoctorBills' table. You can move, or remove it, as needed.
            this.doctorBillsTableAdapter.Fill(this.auditorDataSet.DoctorBills);
            ComboDocNo.Text = "";
            ComboLocation.Text = "";
            ComboDoctor.Text = "";
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }
        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            MathOperations.AmountZeroFormat(TxtAmount);
            MathOperations.NetDocBill(TxtAmount, TxtPercent, TxtTaxs, TxtDiscounts, TxtTotalDiscount, TxtNetAmount);
            FormatBtnUpdate(ComboDocNo, TxtDocNo, ComboLocation, ComboDoctor, TxtAmount, TxtDesc);
        }
        private void TxtPercent_TextChanged(object sender, EventArgs e)
        {
            MathOperations.AmountZeroFormat(TxtPercent);
            MathOperations.NetDocBill(TxtAmount, TxtPercent, TxtTaxs, TxtDiscounts, TxtTotalDiscount, TxtNetAmount);
        }
        private void TxtDiscounts_TextChanged(object sender, EventArgs e)
        {
            MathOperations.AmountZeroFormat(TxtDiscounts);
            MathOperations.NetDocBill(TxtAmount, TxtPercent, TxtTaxs, TxtDiscounts, TxtTotalDiscount, TxtNetAmount);
        }
        private void TxtDocNo_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate(ComboDocNo, TxtDocNo, ComboLocation, ComboDoctor, TxtAmount, TxtDesc);
        }
        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate(ComboDocNo, TxtDocNo, ComboLocation, ComboDoctor, TxtAmount, TxtDesc);
        }
        private void ComboDoctor_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate(ComboDocNo, TxtDocNo, ComboLocation, ComboDoctor, TxtAmount, TxtDesc);
        }
        private void TxtDesc_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate(ComboDocNo, TxtDocNo, ComboLocation, ComboDoctor, TxtAmount, TxtDesc);
        }
        private void ComboDocNo_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate(ComboDocNo, TxtDocNo, ComboLocation, ComboDoctor, TxtAmount, TxtDesc);
            FormatBtnDelete(ComboDocNo);
            // Loading data into the form
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    if (ComboDocNo.Text != "")
                    {
                        string StrDocNo = null;
                        DateTime? VarDatePay = null;
                        string StrLocation = null;
                        string StrDoctor = null;
                        decimal? DecimalAmount = null;
                        decimal? DecimalPercent = null;
                        decimal? DecimalTaxs = null;
                        decimal? DecimalDiscounts = null;
                        decimal? DecimalTotalDiscounts = null;
                        decimal? DecimalNetAmount = null;
                        string StrDetails = null;
                        string StrNotes = null;
                        var c = dc.ProSelectDoctorBill(ComboDocNo.Text, ref StrDocNo, ref VarDatePay, ref StrLocation, ref StrDoctor, ref DecimalAmount, ref DecimalPercent, ref DecimalTaxs, ref DecimalDiscounts, ref DecimalTotalDiscounts, ref DecimalNetAmount, ref StrDetails, ref StrNotes);
                        TxtDocNo.Text = StrDocNo;
                        if (VarDatePay != null)
                        {
                            DatePayDate.Value = VarDatePay.Value;
                        }
                        ComboLocation.Text = StrLocation;
                        ComboDoctor.Text = StrDoctor;
                        TxtAmount.Text = DecimalAmount.ToString();
                        TxtPercent.Text = DecimalPercent.ToString();
                        TxtTaxs.Text = DecimalTaxs.ToString();
                        TxtDiscounts.Text = DecimalDiscounts.ToString();
                        TxtTotalDiscount.Text = DecimalTotalDiscounts.ToString();
                        TxtNetAmount.Text = DecimalNetAmount.ToString();
                        TxtDesc.Text = StrDetails;
                        TxtNotes.Text = StrNotes;
                    }
                }
            }
            catch (NullReferenceException)
            {
            }
            catch (InvalidOperationException)
            {
                TxtDocNo.Text = "";
                DatePayDate.Value = DateTime.Now;
                ComboLocation.Text = "";
                ComboDoctor.Text = "";
                TxtAmount.Text = "";
                TxtPercent.Text = "";
                TxtTaxs.Text = "";
                TxtDiscounts.Text = "";
                TxtTotalDiscount.Text = "";
                TxtNetAmount.Text = "";
                TxtDesc.Text = "";
                TxtNotes.Text = "";
                BtnDelete.Enabled = false;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
        private void TxtAmount_Leave(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtAmount);
        }
        private void TxtPercent_Leave(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtPercent);
        }
        private void TxtTaxs_TextChanged(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtTaxs);
        }
        private void TxtDiscounts_Leave(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtDiscounts);
        }
        private void TxtTotalDiscount_TextChanged(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtTotalDiscount);
        }
        private void TxtNetAmount_TextChanged(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtNetAmount);
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            using (DBAuditDataContext dc = new DBAuditDataContext())
            {
                var c = dc.ProUpdateDoctorBill(ComboDocNo.Text, TxtDocNo.Text, DatePayDate.Value, int.Parse(ComboLocation.SelectedValue.ToString()), int.Parse(ComboDoctor.SelectedValue.ToString()), decimal.Parse(TxtAmount.Text), decimal.Parse(TxtPercent.Text), decimal.Parse(TxtTaxs.Text), decimal.Parse(TxtDiscounts.Text), decimal.Parse(TxtTotalDiscount.Text), decimal.Parse(TxtNetAmount.Text), TxtDesc.Text, TxtNotes.Text);
            }
            MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            FrmModifyDoctorBill Frm = new FrmModifyDoctorBill();
            Frm.Show();
            //}
            //catch (Exception EX)
            //{
            //    MessageBox.Show(EX.Message);
            //}
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
                        var c = dc.ProDeleteDoctorBill(ComboDocNo.Text);
                    }
                    MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FrmModifyDoctorBill Frm = new FrmModifyDoctorBill();
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
    }
}
