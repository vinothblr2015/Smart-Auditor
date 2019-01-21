using System;
using System.Windows.Forms;
using Auditor.Properties;

namespace Auditor.Models
{
    class MathOperations
    {
        /**
         * Format TextBox value as money
         */
        public static void MoneyFormat(TextBox txtAmount)
        {
            // Formatting the number in 0.00 Format:
            try
            {
                if (string.IsNullOrEmpty(txtAmount.Text))
                {
                    txtAmount.Text = Resources.Zero;
                }
                double doubleAmount = double.Parse(txtAmount.Text);
                txtAmount.Text = doubleAmount.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void PrePay(TextBox txtAmount, TextBox txtTaxRate, TextBox txtTaxAmount, TextBox txtSellTax,
            TextBox txtBillTotal, CheckBox checkFees, TextBox txtFees, TextBox txtTotalDiscount, TextBox txtNetAmount)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtAmount.Text))
                {
                    if (txtTaxRate.Text == "")
                    {
                        txtTaxRate.Text = Resources.Zero;
                    }
                    if (txtSellTax.Text == "")
                    {
                        txtSellTax.Text = Resources.Zero;
                    }
                    double amount = double.Parse(txtAmount.Text);
                    double sellTax = double.Parse(txtSellTax.Text);
                    double billTotal = amount + sellTax;
                    txtBillTotal.Text = billTotal.ToString("F2");
                    double rate = double.Parse(txtTaxRate.Text);
                    double tax = 0;
                    double fees;
                    if (amount > 300)
                    {
                        tax = amount * (rate / 100);
                    }
                    txtTaxAmount.Text = tax.ToString("F2");
                    if (checkFees.Checked)
                    {
                        if (amount <= 500 && amount > 0)
                        {
                            fees = 1;
                        }
                        else if (amount <= 1000 && amount > 0)
                        {
                            fees = 2;
                        }
                        else if (amount > 1000 && amount < 50000)
                        {
                            fees = ((amount / 1000) * 3) - 1;
                        }
                        else if (amount > 50000)
                        {
                            fees = (((amount / 1000) * 3) - 1) * 2;
                        }
                        else
                        {
                            fees = 0;
                        }
                    }
                    else
                    {
                        fees = 0;
                    }
                    txtFees.Text = fees.ToString("F2");
                    double totalDiscount = tax + fees;
                    txtTotalDiscount.Text = totalDiscount.ToString("F2");
                    double netAmount = billTotal - totalDiscount;
                    txtNetAmount.Text = netAmount.ToString("F2");
                }
                else
                {
                    txtAmount.Text = Resources.Zero;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Tax(TextBox txtAmount, TextBox txtTaxRate, TextBox txtTaxAmount)
        {
            try
            {
                if (txtAmount.Text != "")
                {
                    double amount = double.Parse(txtAmount.Text);
                    double rate = double.Parse(txtTaxRate.Text);
                    double taxAmount = 0;
                    if (amount > 300)
                    {
                        taxAmount = amount * (rate / 100);
                    }
                    txtTaxAmount.Text = taxAmount.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * Percentage calculation operation
         */
        public static void Percent(TextBox txtAmount, TextBox txtTaxRate, TextBox txtTaxAmount)
        {
            try
            {
                if (txtAmount.Text != "")
                {
                    if (txtTaxRate.Text == "")
                    {
                        txtTaxRate.Text = Resources.Zero;
                    }
                    double amount = double.Parse(txtAmount.Text);
                    double rate = double.Parse(txtTaxRate.Text);
                    double tax = amount * (rate / 100);
                    txtTaxAmount.Text = tax.ToString("F2");
                }
                else
                {
                    txtAmount.Text = Resources.Zero;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /**
         * Calculating operstion fees
         */
        public static void OPerationFees(TextBox txtAmount, TextBox txtFees)
        {
            try
            {
                double fees;
                if (txtAmount.Text != "")
                {
                    double amount = double.Parse(txtAmount.Text);
                    var overAmount = amount % 1000;
                    if (amount <= 500 && amount > 0)
                    {
                        fees = 1;
                    }
                    else if (amount <= 1000 && amount > 0)
                    {
                        fees = 2;
                    }
                    else if (amount > 1000 && amount < 50000)
                    {
                        if (overAmount < 500 && overAmount > 0)
                        {
                            fees = (((Convert.ToInt32(amount / 1000)) + 1) * 3) - 1;
                        }
                        else
                        {
                            fees = ((Convert.ToInt32(amount / 1000)) * 3) - 1;
                        }
                    }
                    else if (amount > 50000)
                    {
                        if (overAmount <= 500)
                        {
                            fees = ((Convert.ToInt32(amount / 1000)) * 3 - 1) * 2;
                        }
                        else
                        {
                            fees = (((Convert.ToInt32(amount / 1000)) + 1) * 3 - 1) * 2;
                        }
                    }
                    else
                    {
                        fees = 0;
                    }
                }
                else
                {
                    fees = 0;
                }
                txtFees.Text = fees.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * Claculate Paid amount for project document
         */
        public static void NetAmount(TextBox txtAmount, TextBox txtTaxAmount, TextBox txtTransAmount,
            TextBox txtInsurAmount, TextBox txtReservedAmount, TextBox txtFees, TextBox txtPenalty, TextBox txtTotal,
            TextBox txtNetAmount)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPenalty.Text))
                {
                    double amount = double.Parse(txtAmount.Text);
                    double tax = double.Parse(txtTaxAmount.Text);
                    double transAmount = double.Parse(txtTransAmount.Text);
                    double insurAmount = double.Parse(txtInsurAmount.Text);
                    double reservedAmount = double.Parse(txtReservedAmount.Text);
                    double fees = double.Parse(txtFees.Text);
                    double penalty = double.Parse(txtPenalty.Text);
                    double total = tax + transAmount + insurAmount + reservedAmount + fees + penalty;
                    txtTotal.Text = total.ToString("F2");
                    double netAmount = amount - total;
                    txtNetAmount.Text = netAmount.ToString("F2");
                }
                else
                {
                    txtPenalty.Text = Resources.Zero;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * Claculate Paid amount for telephone document
         */
        public static void NetAmount(TextBox txtAmount, TextBox txtSellTax, TextBox txtStamp, TextBox txtTotalDiscount,
            TextBox txtNetAmount, TextBox txtPercentage, TextBox txtTax, TextBox txtPaidAmount)
        {
            try
            {
                MoneyFormat(txtAmount);
                MoneyFormat(txtSellTax);
                MoneyFormat(txtStamp);
                MoneyFormat(txtTotalDiscount);
                MoneyFormat(txtNetAmount);
                MoneyFormat(txtPercentage);
                MoneyFormat(txtTax);
                MoneyFormat(txtPaidAmount);

                double amount = double.Parse(txtAmount.Text);
                double stamp = double.Parse(txtStamp.Text);
                double sellTax = double.Parse(txtSellTax.Text);
                double totalDiscount = stamp + sellTax;
                txtTotalDiscount.Text = totalDiscount.ToString("F2");
                double netAmount = amount - totalDiscount;
                txtNetAmount.Text = netAmount.ToString("F2");
                double percentage = double.Parse(txtPercentage.Text);
                double tax = netAmount * (percentage / 100);
                txtTax.Text = tax.ToString("F2");
                double paidAmount = netAmount - tax;
                txtPaidAmount.Text = paidAmount.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtPercentage.Text = Resources.Zero;
            }
        }

        /**
         * Count ActualPeriod or project document
         */
        public static void ActualPeriod(DateTimePicker dateStart, DateTimePicker dateEnd, TextBox txtActualPeriod,
            string type)
        {
            var startDate = dateStart.Value;
            var endDate = dateEnd.Value;
            if (startDate.Date > endDate.Date)
            {
                dateEnd.Value = dateStart.Value;
                if (type == "Project")
                {
                    MessageBox.Show(Resources.MsgProjectDatesInvalid, Resources.AppName, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                //Count Actual period if the two dates are not in the same year:
                int days;
                if (endDate.Year > startDate.Year)
                {
                    var years = endDate.Year - startDate.Year;
                    days = (endDate.DayOfYear - startDate.DayOfYear) + 1 + (years * 365);
                    txtActualPeriod.Text = days.ToString();
                }
                else
                {
                    //Count Actual perid if the two dates are in the same year:
                    days = (endDate.DayOfYear - startDate.DayOfYear) + 1;
                    txtActualPeriod.Text = days.ToString();
                }
            }
        }

        /**
         * Count Penalty for Projects / احتساب غرامات التأخير للمستخلصات
         */
        public static void CountPenalty(TextBox txtPeriod, TextBox txtActualPeriod, TextBox txtValue,
            TextBox txtPenalty)
        {
            try
            {
                if (txtPeriod.Text == "")
                {
                    txtPeriod.Text = Resources.Zero;
                }
                if (txtActualPeriod.Text == "")
                {
                    txtActualPeriod.Text = Resources.Zero;
                }
                if (int.Parse(txtPeriod.Text) >= int.Parse(txtActualPeriod.Text) || txtPeriod.Text == Resources.Zero)
                {
                    txtPenalty.Text = Resources.Zero;
                }
                else
                {
                    int def = int.Parse(txtActualPeriod.Text) - int.Parse(txtPeriod.Text);
                    int weekNo = def / 7;
                    int subRate = def % 7;
                    if (def <= 7)
                    {
                        weekNo = 1;
                    }
                    else if ((subRate) > 0)
                    {
                        weekNo = weekNo + 1;
                    }
                    double value = double.Parse(txtValue.Text);
                    if (weekNo > 10)
                    {
                        weekNo = 10;
                    }
                    double penalty = Convert.ToDouble(value * 0.01 * weekNo);
                    double doublePenalty = double.Parse(penalty.ToString("F1"));
                    txtPenalty.Text = doublePenalty.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * Count penalty for Temporary Loan
         */
        public static void TempLoanPenalty(TextBox txtPeriod, TextBox txtActualPeriod, TextBox txtValue,
            TextBox txtPenalty)
        {
            try
            {
                if (int.Parse(txtPeriod.Text) >= int.Parse(txtActualPeriod.Text) || txtPeriod.Text == Resources.Zero)
                {
                    txtPenalty.Text = Resources.Zero;
                }
                else
                {
                    int def = int.Parse(txtActualPeriod.Text) - int.Parse(txtPeriod.Text);
                    double value = double.Parse(txtValue.Text);
                    double doubleDef = Convert.ToDouble(def / 360);
                    double penalty = Convert.ToDouble(value * 0.1 * doubleDef);
                    double doublePenalty = double.Parse(penalty.ToString("F1"));
                    txtPenalty.Text = doublePenalty.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * Formatting Amount TextBoxes
         */
        public static void AmountZeroFormat(TextBox txtAmount)
        {
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                txtAmount.Text = Resources.Zero;
            }
        }

        /**
         * Formatting Period TextBoxes
         */
        public static void PeriodZeroFormat(TextBox txtPeriod)
        {
            if (string.IsNullOrEmpty(txtPeriod.Text))
            {
                txtPeriod.Text = Resources.Zero;
            }
        }

        /**
         * calculating temporary loan
         */
        public static void TemporaryLoan(TextBox txtTotalAmount, TextBox txtSettlementAmount, TextBox txtTax,
            TextBox txtPenalty, TextBox txtFees, TextBox txtRevenues, TextBox txtTotalDiscount, TextBox txtNetAmount,
            TextBox txtAmountToPay, TextBox txtPaidAmount)
        {
            try
            {
                double totalAmount = double.Parse(txtTotalAmount.Text);
                double settlementAmount = double.Parse(txtSettlementAmount.Text);
                double tax = double.Parse(txtTax.Text);
                double penalty = double.Parse(txtPenalty.Text);
                double fees = double.Parse(txtFees.Text);
                double revenues;
                double totalDiscount;
                double netAmount;
                double paidAmount = double.Parse(txtPaidAmount.Text);
                double amountToPay;
                if (settlementAmount < totalAmount && settlementAmount > 0)
                {
                    totalDiscount = tax + penalty + fees;
                    revenues = totalAmount - settlementAmount;
                    netAmount = settlementAmount - totalDiscount;
                    amountToPay = totalAmount - netAmount - paidAmount;
                }
                else if (settlementAmount > totalAmount)
                {
                    totalDiscount = tax + penalty + fees;
                    netAmount = settlementAmount - totalDiscount;
                    if (netAmount > totalAmount)
                    {
                        revenues = netAmount - totalAmount;
                        amountToPay = 0;
                    }
                    else if (netAmount < totalAmount)
                    {
                        revenues = 0;
                        amountToPay = totalAmount - netAmount - paidAmount;
                    }
                    else
                    {
                        revenues = 0;
                        amountToPay = 0;
                    }
                }
                else
                {
                    revenues = 0;
                    totalDiscount = tax + penalty + fees;
                    netAmount = settlementAmount - totalDiscount;
                    amountToPay = totalAmount - netAmount - paidAmount;
                }
                double doubleRevenues = double.Parse(revenues.ToString("F2"));
                txtRevenues.Text = doubleRevenues.ToString("F2");
                double doubleTotalDiscount = double.Parse(totalDiscount.ToString("F2"));
                txtTotalDiscount.Text = doubleTotalDiscount.ToString("F2");
                double doubleNetAmount = double.Parse(netAmount.ToString("F2"));
                txtNetAmount.Text = doubleNetAmount.ToString("F2");
                double doubleAmountToPay = double.Parse(amountToPay.ToString("F2"));
                txtAmountToPay.Text = doubleAmountToPay.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * Count reserved mounts and insurance to refund them to contractor
         */
        public static void AfterPayProject(ComboBox comboStatues, TextBox txtAmount, TextBox txtSubAmount,
            TextBox txtPercent, TextBox txtDiscount, TextBox txtPaidAmount)
        {
            try
            {
                double doubleAmount = double.Parse(txtAmount.Text);
                double doubleSubAmount = double.Parse(txtSubAmount.Text);
                double doublePercent = double.Parse(txtPercent.Text);
                double doubleDiscount = doubleAmount * (doublePercent / 100);
                txtDiscount.Text = doubleDiscount.ToString("F2");
                if (comboStatues.Text == Resources.StringStatuesReserved)
                {
                    double doublePaid = doubleSubAmount - doubleDiscount;
                    txtPaidAmount.Text = doublePaid.ToString("F2");
                }
                else
                {
                    txtPaidAmount.Text = Resources.Zero;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * calculate net amount for doctor bill
         */
        public static void NetDocBill(TextBox txtAmount, TextBox txtPercent, TextBox txtTaxs, TextBox txtDiscuonts,
            TextBox txtTotalDiscounts, TextBox txtNetAmount)
        {
            try
            {
                double doubleAmount = double.Parse(txtAmount.Text);
                double doublePercent = double.Parse(txtPercent.Text);
                double doubleTaxs = doubleAmount * (doublePercent / 100);
                double doubleDiscounts = double.Parse(txtDiscuonts.Text);
                double doubleTotalDiscounts = doubleTaxs + doubleDiscounts;
                double doubleNetAmount = doubleAmount - doubleTotalDiscounts;
                txtTaxs.Text = doubleTaxs.ToString("F2");
                txtTotalDiscounts.Text = doubleTotalDiscounts.ToString("F2");
                txtNetAmount.Text = doubleNetAmount.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}