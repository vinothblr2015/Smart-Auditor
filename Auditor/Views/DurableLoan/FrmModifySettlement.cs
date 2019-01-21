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
    public partial class FrmModifySettlement : Form
    {
        public FrmModifySettlement()
        {
            InitializeComponent();
        }

        // Define Classes
        MathOperations Maths = new MathOperations();
        //
        // Formatting the update button
        public void FormatBtnUpdate(ComboBox ComboSetNo, TextBox TxtSetNo, ComboBox ComboLocation, TextBox TxtAmount, TextBox TxtDetails)
        {
            if (ComboSetNo.Text == "" || TxtSetNo.Text == "" || ComboLocation.Text == "" || TxtAmount.Text == "0.00" || TxtDetails.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        // Formatting the delete button
        public void FormatBtnDelete(ComboBox ComboSetNo)
        {
            if (ComboSetNo.Text == "")
            {
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnDelete.Enabled = true;
            }
        }

        private void FrmModifySettlement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.auditorDataSet.Location);
            // TODO: This line of code loads data into the 'auditorDataSet.Settlements' table. You can move, or remove it, as needed.
            this.settlementsTableAdapter.Fill(this.auditorDataSet.Settlements);
            // Formatting the form
            ComboSetNo.Text = "";
            ComboLocation.Text = "";
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;            
        }

        private void ComboSetNo_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate(ComboSetNo, TxtSettlementNo, ComboLocation, TxtTotalAmount, TxtReason);
            FormatBtnDelete(ComboSetNo);
            //
            // Loading data into form            
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    if (ComboSetNo.Text != "")
                    {
                        string StrSetNo = null;
                        int? IntLocID = null;
                        string StrLocation = null;
                        DateTime? VarSetDate = null;
                        decimal? DecimalAmount = null;
                        string StrDetails = null;
                        string StrNotes = null;
                        var c = dc.ProSelectSettlement(ComboSetNo.Text, ref StrSetNo, ref IntLocID, ref VarSetDate, ref DecimalAmount, ref StrDetails, ref StrNotes);
                        TxtSettlementNo.Text = StrSetNo;
                        var d = dc.ProGetLocationByID(IntLocID, ref StrLocation);
                        ComboLocation.Text = StrLocation;                        
                        if (VarSetDate != null)
                        {
                            DateSettlement.Value = VarSetDate.Value;
                        }
                        else
                        {
                            DateSettlement.Value = DateTime.Now;
                        }
                        TxtTotalAmount.Text = DecimalAmount.ToString();
                        TxtReason.Text = StrDetails;
                        TxtNotes.Text = StrNotes;
                    }
                    else
                    {
                        TxtSettlementNo.Text = null;
                        ComboLocation.Text = null;
                        DateSettlement.Value = DateTime.Now;
                        TxtTotalAmount.Text = null;
                        TxtReason.Text = null;
                        TxtNotes.Text = null;
                    }
                }
            }
            catch (NullReferenceException)
            {
            }
            catch (InvalidOperationException)
            {
                DateSettlement.Value = DateTime.Now;
                BtnDelete.Enabled = false;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message.ToString());
            }
        }

        private void TxtSettlementNo_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate(ComboSetNo, TxtSettlementNo, ComboLocation, TxtTotalAmount, TxtReason);
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate(ComboSetNo, TxtSettlementNo, ComboLocation, TxtTotalAmount, TxtReason);
        }

        private void TxtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate(ComboSetNo, TxtSettlementNo, ComboLocation, TxtTotalAmount, TxtReason);
        }

        private void TxtReason_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate(ComboSetNo, TxtSettlementNo, ComboLocation, TxtTotalAmount, TxtReason);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProUpdateSettlement(ComboSetNo.Text, TxtSettlementNo.Text, int.Parse(ComboLocation.SelectedValue.ToString()), DateSettlement.Value, decimal.Parse(TxtTotalAmount.Text), TxtReason.Text, TxtNotes.Text);
                }
                MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
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
                        var c = dc.ProDeleteSettlement(ComboSetNo.Text);
                    }
                    MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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

        private void TxtTotalAmount_Leave(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtTotalAmount);
        }
    }
}
