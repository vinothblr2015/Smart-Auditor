using System;
using System.Windows.Forms;
using Auditor.Models;

namespace Auditor.Views.TransFee
{
    public partial class FrmNewTransFee : Form
    {
        public FrmNewTransFee()
        {
            InitializeComponent();
            // TODO: This line of code loads data into the 'auditorDataSet1.Employee' table. You can move, or remove it, as needed.
            employeeTableAdapter.Fill(auditorDataSet1.Employee);
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            locationTableAdapter.Fill(auditorDataSet.Location);
            // Formatting the form:
            ComboLocation.Text = "";
            ComboName.Text = "";
            TxtTrans.Text = @"0.00";
            TxtTravel.Text = @"0.00";
            BtnAdd.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProAddTransFee(TxtDocNo.Text, DatePay.Value, int.Parse(ComboLocation.SelectedValue.ToString()),
                        int.Parse(ComboName.SelectedValue.ToString()), TxtDestination.Text, TxtPeriod.Text,
                        decimal.Parse(TxtTrans.Text), decimal.Parse(TxtTravel.Text), TxtNotes.Text);
                }
                MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
                new FrmNewTransFee().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtDocNo_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            if (TxtDocNo.Text == "" || ComboLocation.Text == "" || ComboName.Text == "" || TxtDestination.Text == "" ||
                TxtPeriod.Text == "" || TxtTrans.Text == @"0" & TxtTravel.Text == @"0")
            {
                BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
            }
            MathOperations.AmountZeroFormat(TxtTrans);
            MathOperations.AmountZeroFormat(TxtTravel);
        }

        private void TxtTrans_Leave(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtTrans);
        }

        private void TxtTravel_Leave(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtTravel);
        }
    }
}