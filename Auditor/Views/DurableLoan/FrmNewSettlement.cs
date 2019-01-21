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
    public partial class FrmNewSettlement : Form
    {
        public FrmNewSettlement()
        {
            InitializeComponent();
        }

        // Define Classes:
        MathOperations Math = new MathOperations();
        //
        // Formatting the form:
        public void FormatForm(TextBox TxtSetNo, ComboBox ComboLocation, TextBox TxtAmount, TextBox TxtDetails)
        {
            if (TxtSetNo.Text == "" || ComboLocation.Text == "" || TxtAmount.Text == "0.00" || TxtDetails.Text == "")
            {
                BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
            }
        }
        //
        private void FrmNewSettlement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.auditorDataSet.Location);
            //
            // Formatting the form
            ComboLocation.Text = "";
            BtnAdd.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSettlementNo_TextChanged(object sender, EventArgs e)
        {
            FormatForm(TxtSettlementNo, ComboLocation, TxtTotalAmount, TxtReason);
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            FormatForm(TxtSettlementNo, ComboLocation, TxtTotalAmount, TxtReason);
        }

        private void TxtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            MathOperations.AmountZeroFormat(TxtTotalAmount);
            FormatForm(TxtSettlementNo, ComboLocation, TxtTotalAmount, TxtReason);
        }

        private void TxtReason_TextChanged(object sender, EventArgs e)
        {
            FormatForm(TxtSettlementNo, ComboLocation, TxtTotalAmount, TxtReason);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProAddSettlement(TxtSettlementNo.Text, int.Parse(ComboLocation.SelectedValue.ToString()), DateSettlement.Value, decimal.Parse(TxtTotalAmount.Text), TxtReason.Text, TxtNotes.Text);
                    MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FrmNewSettlement Frm = new FrmNewSettlement();
                    Frm.Show();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void TxtTotalAmount_Leave(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtTotalAmount);
        }
    }
}
