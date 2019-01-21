using System;
using System.Windows.Forms;
using Auditor.Models;

namespace Auditor.Views.TemporaryLoan
{
    public partial class FrmNewTemporaryLoan : Form
    {
        public FrmNewTemporaryLoan()
        {
            InitializeComponent();
        }

        //Define Classes

        private void FrmNewTemporaryLoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Employee' table. You can move, or remove it, as needed.
            employeeTableAdapter.Fill(auditorDataSet.Employee);
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            locationTableAdapter.Fill(auditorDataSet.Location);

            // Formatting the form:
            TxtDocNo.Text = "";
            ComboLocation.Text = "";
            ComboEmployee.Text = "";
            TxtTotalAmount.Text = "";
            BtnAdd.Enabled = false;
        }

        private void TxtDocNo_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:

                if (TxtDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" )
                {
                    BtnAdd.Enabled = false;
                }
                else
                {
                    BtnAdd.Enabled = true;
                }                        
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
                if (TxtDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" )
                {
                    BtnAdd.Enabled = false;
                }
                else
                {
                    BtnAdd.Enabled = true;
                }
        }

        private void ComboEmployee_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
                if (TxtDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" )
                {
                    BtnAdd.Enabled = false;
                }
                else
                {
                    BtnAdd.Enabled = true;
                }
        }

        private void TxtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
            MathOperations.AmountZeroFormat(TxtTotalAmount);
                if (TxtDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" )
                {
                    BtnAdd.Enabled = false;
                }
                else
                {
                    BtnAdd.Enabled = true;
                }
        }

        private void TxtReason_TextChanged(object sender, EventArgs e)
        {
            // Formatting the form:
                if (TxtDocNo.Text == "" || ComboLocation.Text == "" || ComboEmployee.Text == "" || TxtTotalAmount.Text == "" || TxtPeriod.Text == "" || TxtReason.Text == "" )
                {
                    BtnAdd.Enabled = false;
                }
                else
                {
                    BtnAdd.Enabled = true;
                }
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProAddTempLoan(TxtDocNo.Text, DatePayDate.Value, int.Parse(ComboLocation.SelectedValue.ToString()), int.Parse(ComboEmployee.SelectedValue.ToString()), decimal.Parse(TxtTotalAmount.Text), int.Parse(TxtPeriod.Text), TxtReason.Text, TxtNotes.Text);
                    MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    new FrmNewTemporaryLoan().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtTotalAmount_Leave(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtTotalAmount);
        }
    }
}
