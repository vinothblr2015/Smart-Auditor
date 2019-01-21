using System;
using System.Windows.Forms;
using Auditor.Models;
using Auditor.Properties;

namespace Auditor.Views.Cure
{
    public partial class FrmNewDoctorBill : Form
    {
        public FrmNewDoctorBill()
        {
            InitializeComponent();
            doctorTableAdapter.Fill(auditorDataSet.Doctor);
            locationTableAdapter.Fill(auditorDataSet.Location);
            ComboLocation.Text = null;
            ComboDoctor.Text = null;
            BtnAdd.Enabled = false;
        }
        // Define Classes
        //
        // Formatting BtnAdd
        private void FormatBtnAdd(TextBox txtDocNo, ComboBox comboLocation, ComboBox comboDoctor, TextBox txtAmount, TextBox txtDetails)
        {
            if (txtDocNo.Text == "" || comboLocation.Text == "" || comboDoctor.Text == "" || txtAmount.Text == Resources.Zero || txtDetails.Text == "")
            {
                BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            MathOperations.AmountZeroFormat(TxtAmount);
            MathOperations.NetDocBill(TxtAmount, TxtPercent, TxtTaxs, TxtDiscounts, TxtTotalDiscount, TxtNetAmount);
            FormatBtnAdd(TxtDocNo, ComboLocation, ComboDoctor, TxtAmount, TxtDesc);
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
            FormatBtnAdd(TxtDocNo, ComboLocation, ComboDoctor, TxtAmount, TxtDesc);
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            FormatBtnAdd(TxtDocNo, ComboLocation, ComboDoctor, TxtAmount, TxtDesc);
        }

        private void ComboDoctor_TextChanged(object sender, EventArgs e)
        {
            FormatBtnAdd(TxtDocNo, ComboLocation, ComboDoctor, TxtAmount, TxtDesc);
        }

        private void TxtDesc_TextChanged(object sender, EventArgs e)
        {
            FormatBtnAdd(TxtDocNo, ComboLocation, ComboDoctor, TxtAmount, TxtDesc);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProAddDoctorBill(TxtDocNo.Text, DatePayDate.Value, int.Parse(ComboLocation.SelectedValue.ToString()), int.Parse(ComboDoctor.SelectedValue.ToString()), decimal.Parse(TxtAmount.Text), decimal.Parse(TxtPercent.Text), decimal.Parse(TxtTaxs.Text), decimal.Parse(TxtDiscounts.Text), decimal.Parse(TxtTotalDiscount.Text), decimal.Parse(TxtNetAmount.Text), TxtDesc.Text, TxtNotes.Text);
                    MessageBox.Show(Resources.MsgDocumentAdded, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    new FrmNewDoctorBill().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
