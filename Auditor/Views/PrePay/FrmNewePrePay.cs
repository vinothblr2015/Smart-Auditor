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
    public partial class FrmNewePrePay : Form
    {
        public FrmNewePrePay()
        {
            InitializeComponent();
        }
        //Defin Class:
        MathOperations Maths = new MathOperations();

        private void FrmAddPrePay_Load(object sender, EventArgs e)
        {
            try
            {
                // Calculate Discounts While loading the form:
                MathOperations.PrePay(TxtAmount, TxtTaxRate, TxtTaxAmount, TxtSellTax, TxtBillTotal, CheckFees, TxtFees, TxtTotalDiscount, TxtNetAmount);
                // TODO: This line of code loads data into the 'auditorDataSet.Vendors' table. You can move, or remove it, as needed.
                this.vendorsTableAdapter.Fill(this.auditorDataSet.Vendors);
                // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
                this.locationTableAdapter.Fill(this.auditorDataSet.Location);
                ComboLocation.Text = "";
                ComboVendor.Text = "";
                ComboBridge.Text = "";
                TxtAmount.Text = "0";
                TxtSellTax.Text = "0";
                TxtFees.Text = "0";
                CheckFees.Checked = true;
                BtnAdd.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Formatting Form:
                if (ComboLocation.Text == "" || ComboVendor.Text == "" || ComboBridge.Text == "" || TxtDocNo.Text == "" || TxtAmount.Text == "0" || TxtReason.Text == "")
                {
                    BtnAdd.Enabled = false;
                }
                else
                {
                    BtnAdd.Enabled = true;
                }

                // TODO: This line of code loads data into the 'auditorDataSet.Employee' table. You can move, or remove it, as needed.
                //this.employeeTableAdapter.FillByLocation(this.auditorDataSet.Employee,int.Parse(ComboLocation.SelectedValue.ToString()));
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            
        }

        private void ComboVendor_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (ComboLocation.Text == "" || ComboVendor.Text == "" || ComboBridge.Text == "" || TxtDocNo.Text == "" || TxtAmount.Text == "0" || TxtReason.Text == "")
            {
                BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
            }
        }

        private void ComboBridge_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (ComboLocation.Text == "" || ComboVendor.Text == "" || ComboBridge.Text == "" || TxtDocNo.Text == "" || TxtAmount.Text == "0" || TxtReason.Text == "")
            {
                BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
            }
        }

        private void TxtDocNo_TextChanged(object sender, EventArgs e)
        {
            //Formatting Form:
            if (ComboLocation.Text == "" || ComboVendor.Text == "" || ComboBridge.Text == "" || TxtDocNo.Text == "" || TxtAmount.Text == "0" || TxtReason.Text == "")
            {
                BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
            }
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            // Calculate Discounts by rates:
            MathOperations.PrePay(TxtAmount, TxtTaxRate, TxtTaxAmount, TxtSellTax, TxtBillTotal, CheckFees, TxtFees, TxtTotalDiscount, TxtNetAmount);

            //Formatting Form:
            if (ComboLocation.Text == "" || ComboVendor.Text == "" || ComboBridge.Text == "" || TxtDocNo.Text == "" || TxtAmount.Text == "0" || TxtReason.Text == "")
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
            //Formatting Form:
            if (ComboLocation.Text == "" || ComboVendor.Text == "" || ComboBridge.Text == "" || TxtDocNo.Text == "" || TxtAmount.Text == "0" || TxtReason.Text == "")
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
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var C = dc.ProAddPrePay(int.Parse(ComboLocation.SelectedValue.ToString()), int.Parse(ComboVendor.SelectedValue.ToString()), int.Parse(ComboBridge.SelectedValue.ToString()), TxtDocNo.Text, DatePayDate.Value, double.Parse(TxtAmount.Text), double.Parse(TxtTaxRate.Text), double.Parse(TxtTaxAmount.Text), double.Parse(TxtFees.Text), double.Parse(TxtTotalDiscount.Text), double.Parse(TxtNetAmount.Text), TxtJust.Text, TxtReason.Text, TxtNotes.Text);
                }
                MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void TxtTaxRate_TextChanged(object sender, EventArgs e)
        {
            // Calculate Discounts by rates:
            MathOperations.PrePay(TxtAmount, TxtTaxRate, TxtTaxAmount, TxtSellTax, TxtBillTotal, CheckFees, TxtFees, TxtTotalDiscount, TxtNetAmount);
        }

        private void TxtSellTax_TextChanged(object sender, EventArgs e)
        {
            // Calculate Discounts by rates:
            MathOperations.PrePay(TxtAmount, TxtTaxRate, TxtTaxAmount, TxtSellTax, TxtBillTotal, CheckFees, TxtFees, TxtTotalDiscount, TxtNetAmount);
        }

        private void CheckFees_CheckedChanged(object sender, EventArgs e)
        {
            // Calculate Discounts by rates:
            MathOperations.PrePay(TxtAmount, TxtTaxRate, TxtTaxAmount, TxtSellTax, TxtBillTotal, CheckFees, TxtFees, TxtTotalDiscount, TxtNetAmount);
        }
    }
}
