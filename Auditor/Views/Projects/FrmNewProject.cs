using System;
using System.Windows.Forms;
using Auditor.Models;

namespace Auditor.Views.Projects
{
    public partial class FrmOperation : Form
    {
        public FrmOperation()
        {
            InitializeComponent();
            contractorTableAdapter.Fill(auditorDataSet.Contractor);
            locationTableAdapter.Fill(auditorDataSet.Location);

            ComboLocation.Text = "";
            ComboContractor.Text = "";
            BtnSave.Enabled = false;
            CalculateDiscounts();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProAddProject(int.Parse(ComboLocation.SelectedValue.ToString()),
                        int.Parse(ComboContractor.SelectedValue.ToString()), TxtExcuteOrder.Text, DateExcuteOrder.Value,
                        TxtpredicationOrder.Text, DatepredicationOrder.Value, int.Parse(TxtPeriod.Text), TxtDocNo.Text,
                        DateStart.Value, DateEnd.Value, int.Parse(TxtActualPeriod.Text), TxtOperation.Text,
                        decimal.Parse(TxtAmount.Text), DatePay.Value, decimal.Parse(TxtTaxRate.Text),
                        decimal.Parse(TxtTaxAmount.Text), decimal.Parse(TxtTransRate.Text),
                        decimal.Parse(TxtTransAmount.Text), decimal.Parse(TxtInsurRate.Text),
                        decimal.Parse(TxtInsurAmount.Text), decimal.Parse(TxtReservedRate.Text),
                        decimal.Parse(TxtReservedAmount.Text), decimal.Parse(TxtBusinessFees.Text),
                        decimal.Parse(TxtTotalDiscount.Text), decimal.Parse(TxtNetAmount.Text), TxtJustAmount.Text,
                        TxtNotes.Text);
                    MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                    new FrmOperation().Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscounts();
            FormatForm();
        }

        private void TxtPenalty_TextChanged(object sender, EventArgs e)
        {
            MathOperations.NetAmount(TxtAmount, TxtTaxAmount, TxtTransAmount, TxtInsurAmount, TxtReservedAmount,
                TxtBusinessFees, TxtPenalty, TxtTotalDiscount, TxtNetAmount);
        }

        private void TxtTaxRate_TextChanged(object sender, EventArgs e)
        {
            if (TxtTaxRate.Text != "")
            {
                CalculateDiscounts();
            }
            else
            {
                TxtTaxRate.Text = @"0.0";
            }
        }

        private void TxtTransRate_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscounts();
        }

        private void TxtInsurRate_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscounts();
        }

        private void TxtReservedRate_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscounts();
        }

        private void TxtDocNo_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            FormatForm();
        }


        private void ComboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void ComboContractor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtExcuteOrder_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtpredicationOrder_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtOperation_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtJustAmount_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtPeriod_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
            CalculateDiscounts();
        }

        private void TxtActualPeriod_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscounts();
        }

        private void DateStart_ValueChanged(object sender, EventArgs e)
        {
            MathOperations.ActualPeriod(DateStart, DateEnd, TxtActualPeriod, "Project");
        }

        private void DateEnd_ValueChanged(object sender, EventArgs e)
        {
            MathOperations.ActualPeriod(DateStart, DateEnd, TxtActualPeriod, "Project");
        }

        private void TxtAmount_Leave(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtAmount);
        }

        private void TxtBusinessFees_TextChanged(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtBusinessFees);
        }

        private void CalculateDiscounts()
        {
            //Calculate discounts by rates:
            try
            {
                MathOperations.Tax(TxtAmount, TxtTaxRate, TxtTaxAmount);
                MathOperations.Percent(TxtAmount, TxtTransRate, TxtTransAmount);
                MathOperations.Percent(TxtAmount, TxtInsurRate, TxtInsurAmount);
                MathOperations.Percent(TxtAmount, TxtReservedRate, TxtReservedAmount);
                MathOperations.OPerationFees(TxtAmount, TxtBusinessFees);
                MathOperations.ActualPeriod(DateStart, DateEnd, TxtActualPeriod, "Project");
                MathOperations.CountPenalty(TxtPeriod, TxtActualPeriod, TxtAmount, TxtPenalty);
                MathOperations.NetAmount(TxtAmount, TxtTaxAmount, TxtTransAmount, TxtInsurAmount, TxtReservedAmount,
                    TxtBusinessFees, TxtPenalty, TxtTotalDiscount, TxtNetAmount);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void FormatForm()
        {
            // Formatting form
            try
            {
                if (ComboLocation.SelectedIndex == 0 || ComboContractor.SelectedIndex == 0 ||
                    TxtExcuteOrder.Text == "" ||
                    TxtpredicationOrder.Text == "" || TxtPeriod.Text == @"0" || TxtDocNo.Text == "" ||
                    TxtOperation.Text == "" ||
                    TxtAmount.Text == @"0" || TxtJustAmount.Text == "")
                {
                    BtnSave.Enabled = false;
                }
                else
                {
                    BtnSave.Enabled = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}