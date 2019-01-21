using System;
using System.Windows.Forms;
using Auditor.Models;
using Auditor.Properties;

namespace Auditor.Views.Telepohne
{
    public partial class FrmModifyTel : Form
    {
        public FrmModifyTel()
        {
            InitializeComponent();
            telNoTableAdapter.Fill(this.auditorDataSet.TelNo);
            telephoneTableAdapter.Fill(this.auditorDataSet.Telephone);
            locationTableAdapter.Fill(this.auditorDataSet.Location);

            //Formatting Form:
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            ComboDocNo.Text = "";
            ComboLocation.Text = "";
            ComboTelNo.Text = "";
            TxtAmount.Text = "0";
            TxtSellTax.Text = "0";
            TxtStamp.Text = "0";
            ComboStatus.Text = "";
            TxtPercentage.Text = "2";

            //Calculate Paid amount:
            MathOperations.NetAmount(TxtAmount, TxtSellTax, TxtStamp, TxtTotalDiscount, TxtNetAmount, TxtPercentage,
                TxtTax, TxtPaidAmount);
        }

        private void ComboTelNo_TextChanged(object sender, EventArgs e)
        {
            //Button Update Format:
            if (ComboDocNo.Text == "" || ComboLocation.Text == "" || TxtPortion.Text == "" || TxtAmount.Text == "0" ||
                ComboStatus.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void TxtPortion_TextChanged(object sender, EventArgs e)
        {
            //Button Update Format:
            if (ComboDocNo.Text == "" || ComboLocation.Text == "" || TxtPortion.Text == "" || TxtAmount.Text == "0" ||
                ComboStatus.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'auditorDataSet.TelNo' table. You can move, or remove it, as needed.
                //this.telNoTableAdapter.FillByLocation(this.auditorDataSet.TelNo, int.Parse(ComboLocation.SelectedValue.ToString()));
                ComboTelNo.Text = "";
            }
            catch (NullReferenceException)
            {
            }


            //Button Update Format:
            if (ComboDocNo.Text == "" || ComboLocation.Text == "" || TxtPortion.Text == "" || TxtAmount.Text == Resources.Zero ||
                ComboStatus.Text == "")
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
            MathOperations.NetAmount(TxtAmount, TxtSellTax, TxtStamp, TxtTotalDiscount, TxtNetAmount, TxtPercentage,
                TxtTax, TxtPaidAmount);

            //Button Update Format:
            if (ComboDocNo.Text == "" || ComboLocation.Text == "" || TxtPortion.Text == "" || TxtAmount.Text == Resources.Zero ||
                ComboStatus.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void TxtSellTax_TextChanged(object sender, EventArgs e)
        {
            MathOperations.NetAmount(TxtAmount, TxtSellTax, TxtStamp, TxtTotalDiscount, TxtNetAmount, TxtPercentage,
                TxtTax, TxtPaidAmount);
        }

        private void TxtStamp_TextChanged(object sender, EventArgs e)
        {
            MathOperations.NetAmount(TxtAmount, TxtSellTax, TxtStamp, TxtTotalDiscount, TxtNetAmount, TxtPercentage,
                TxtTax, TxtPaidAmount);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProUpdateTelephone(ComboDocNo.Text, DatePay.Value, int.Parse(ComboLocation.ValueMember),
                        int.Parse(ComboTelNo.Text), TxtPortion.Text, decimal.Parse(TxtAmount.Text),
                        decimal.Parse(TxtSellTax.Text), decimal.Parse(TxtStamp.Text),
                        decimal.Parse(TxtTotalDiscount.Text), decimal.Parse(TxtNetAmount.Text),
                        double.Parse(TxtPercentage.Text), decimal.Parse(TxtTax.Text), decimal.Parse(TxtPaidAmount.Text),
                        ComboStatus.Text, DateSettlement.Value, TxtNotes.Text);
                }
                MessageBox.Show(Resources.MsgDocumentUpdated, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rslt = MessageBox.Show(Resources.MsgDocumentDeleteConfirm, Resources.AppName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt == DialogResult.Yes)
                {
                    using (DBAuditDataContext dc = new DBAuditDataContext())
                    {
                        dc.ProDeleteTelephone(ComboDocNo.Text);
                    }
                    MessageBox.Show(Resources.MsgDocumentDeleted, Resources.AppName, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
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

        private void ComboDocNo_TextChanged(object sender, EventArgs e)
        {
            // Buttons View & Delete Format:
            if (ComboTelNo.Text == "" || TxtPortion.Text == "")
            {
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnDelete.Enabled = true;
            }

            //Button Update Format:
            if (ComboDocNo.Text == "" || ComboLocation.Text == "" || TxtPortion.Text == "" ||
                TxtAmount.Text == Resources.Zero || ComboStatus.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void TxtPercentage_TextChanged(object sender, EventArgs e)
        {
            MathOperations.NetAmount(TxtAmount, TxtSellTax, TxtStamp, TxtTotalDiscount, TxtNetAmount, TxtPercentage,
                TxtTax, TxtPaidAmount);
        }
    }
}