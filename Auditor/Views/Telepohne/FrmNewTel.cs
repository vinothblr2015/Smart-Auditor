using System;
using System.Windows.Forms;
using Auditor.Models;
using Auditor.Properties;

namespace Auditor.Views.Telepohne
{
    public partial class FrmNewTel : Form
    {
        public FrmNewTel()
        {
            InitializeComponent();
        }

        private void FrmAddTel_Load(object sender, EventArgs e)
        {
            telNoTableAdapter.Fill(auditorDataSet.TelNo);
            locationTableAdapter.Fill(auditorDataSet.Location);
            ComboLocation.SelectedIndex = -1;
            ComboTelNo.SelectedIndex = -1;
            TxtAmount.Clear();
            TxtStamp.Clear();
            TxtSellTax.Clear();
            TxtPercentage.Text = @"2";
            ComboStatus.SelectedIndex = 0;
            MathOperations.NetAmount(TxtAmount, TxtSellTax, TxtStamp, TxtTotalDiscount, TxtNetAmount, TxtPercentage,
                TxtTax, TxtPaidAmount);
            BtnSave.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Load document details into form
            try
            {
                using (var dc = new DBAuditDataContext())
                {
                    dc.ProAddTelephone(TxtDocNo.Text, DatePay.Value, int.Parse(ComboLocation.ValueMember),
                        int.Parse(ComboTelNo.Text), TxtPortion.Text, Convert.ToDecimal(TxtAmount.Text),
                        Convert.ToDecimal(TxtSellTax.Text), Convert.ToDecimal(TxtStamp.Text),
                        Convert.ToDecimal(TxtTotalDiscount.Text), Convert.ToDecimal(TxtNetAmount.Text),
                        double.Parse(TxtPercentage.Text), Convert.ToDecimal(TxtTax.Text),
                        Convert.ToDecimal(TxtPaidAmount.Text), ComboStatus.Text, DateSettlement.Value, TxtNotes.Text);
                }
                MessageBox.Show(Resources.MsgDocumentAdded, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
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

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            MathOperations.NetAmount(TxtAmount, TxtSellTax, TxtStamp, TxtTotalDiscount, TxtNetAmount, TxtPercentage,
                TxtTax, TxtPaidAmount);
            FormatForm();
        }

        private void TxtSellTax_TextChanged(object sender, EventArgs e)
        {
            MathOperations.NetAmount(TxtAmount, TxtSellTax, TxtStamp, TxtTotalDiscount, TxtNetAmount, TxtPercentage,
                TxtTax, TxtPaidAmount);
            FormatForm();
        }

        private void TxtStamp_TextChanged(object sender, EventArgs e)
        {
            MathOperations.NetAmount(TxtAmount, TxtSellTax, TxtStamp, TxtTotalDiscount, TxtNetAmount, TxtPercentage,
                TxtTax, TxtPaidAmount);
            FormatForm();
        }

        private void TxtTax_TextChanged(object sender, EventArgs e)
        {
            MathOperations.NetAmount(TxtAmount, TxtSellTax, TxtStamp, TxtTotalDiscount, TxtNetAmount, TxtPercentage,
                TxtTax, TxtPaidAmount);
            FormatForm();
        }

        private void TxtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            MathOperations.NetAmount(TxtAmount, TxtSellTax, TxtStamp, TxtTotalDiscount, TxtNetAmount, TxtPercentage,
                TxtTax, TxtPaidAmount);
        }

        private void TxtDocNo_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtPercentage_TextChanged(object sender, EventArgs e)
        {
            MathOperations.NetAmount(TxtAmount, TxtSellTax, TxtStamp, TxtTotalDiscount, TxtNetAmount, TxtPercentage,
                TxtTax, TxtPaidAmount);
        }

        private void ComboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void ComboTelNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtPortion_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void ComboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboStatus.SelectedIndex == 0)
            {
                DateSettlement.Enabled = false;
                LblDateSettlement.Enabled = false;
            }
            else
            {
                DateSettlement.Enabled = true;
                LblDateSettlement.Enabled = true;
            }
        }

        private void FormatForm()
        {
            // Formatting Form:
            try
            {
                if (string.IsNullOrEmpty(TxtDocNo.Text) || int.Parse(TxtAmount.Text) == 0 ||
                    int.Parse(TxtStamp.Text) == 0 || int.Parse(TxtTax.Text) == 0 ||
                    string.IsNullOrEmpty(ComboLocation.Text) || string.IsNullOrEmpty(ComboTelNo.Text) ||
                    string.IsNullOrEmpty(TxtPortion.Text) || int.Parse(TxtSellTax.Text) == 0)
                {
                    BtnSave.Enabled = false;
                }
                else
                {
                    BtnSave.Enabled = true;
                }
            }
            catch (FormatException)
            {
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}