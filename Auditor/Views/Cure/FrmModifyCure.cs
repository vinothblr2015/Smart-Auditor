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
    public partial class FrmModifyCure : Form
    {
        public FrmModifyCure()
        {
            InitializeComponent();
        }
        public void FormatBtnUpdate()
        {
            if (ComboDocNo.Text == "" || ComboLocation.Text == "" || ComboName.Text == "" || TxtPerson.Text == "" || TxtAmount.Text == "0" || TxtDesc.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }  
        }
        //
        // Formatting the delete button
        public void FormatBtnDelete()
        {
            if (ComboDocNo.Text == "")
            {
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnDelete.Enabled = true;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModifyCure_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Cure' table. You can move, or remove it, as needed.
            this.cureTableAdapter.Fill(this.auditorDataSet.Cure);
            // TODO: This line of code loads data into the 'auditorDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.auditorDataSet.Employee);
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.auditorDataSet.Location); 
            // Formatting the form:
            ComboDocNo.Text = "";
            ComboLocation.Text = "";
            TxtAmount.Text = "0.00";
            ComboName.Text = "";
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void ComboDocNo_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate();
            FormatBtnDelete();
            // Loading data into the form:               
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    if (ComboDocNo.Text != "")
                    {
                        string StrDocNo = null;
                        DateTime? VarDatePay = null;
                        int? IntLocationID = null;
                        int? IntEmployeeID = null;
                        string StrLocation = null;
                        string StrEmployee = null;
                        string StrPerson = null;
                        decimal? decimalAmount = null;
                        string StrDesc = null;
                        string StrNotes = null;
                        var c = dc.ProSelectCure(ComboDocNo.Text, ref StrDocNo,ref IntEmployeeID, ref IntLocationID, ref StrPerson, ref decimalAmount, ref VarDatePay, ref StrDesc, ref StrNotes);
                        TxtDocNo.Text = StrDocNo;
                        if (VarDatePay != null)
                        {
                            DatePayDate.Value = VarDatePay.Value;
                        }                        
                        var d = dc.ProGetLocationByID(IntLocationID, ref StrLocation);
                        ComboLocation.Text = StrLocation;
                        var x = dc.ProGetEmployeeByID(IntEmployeeID, ref StrEmployee);
                        ComboName.Text = StrEmployee;
                        TxtPerson.Text = StrPerson;
                        TxtAmount.Text = decimalAmount.ToString();
                        TxtDesc.Text = StrDesc;
                        TxtNotes.Text = StrNotes;
                    }
                    else
                    {
                        TxtDocNo.Text = "";
                        TxtPerson.Text ="";
                        ComboLocation.Text = "";
                        TxtAmount.Text = "";
                        TxtDesc.Text = "";
                        TxtNotes.Text = "";
                    }
                }
            }
            catch (NullReferenceException)
            {
                BtnDelete.Enabled = false;
            }
            catch (InvalidOperationException)
            {
                BtnDelete.Enabled = false;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate();
        }

        private void ComboName_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate();
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate();
        }

        private void TxtDesc_TextChanged(object sender, EventArgs e)
        {
            FormatBtnUpdate();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Update document:
            try
            {

                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProUpdateCure(ComboDocNo.Text,int.Parse(ComboLocation.SelectedValue.ToString()), int.Parse(ComboName.SelectedValue.ToString()), TxtPerson.Text, decimal.Parse(TxtAmount.Text), ComboDocNo.Text, DatePayDate.Value, TxtDesc.Text, TxtNotes.Text);
                }
                MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FrmModifyCure Frm = new FrmModifyCure();
                Frm.ShowDialog();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Delete document:
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProDeleteCure(ComboDocNo.Text);
                }
                MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FrmModifyCure Frm = new FrmModifyCure();
                Frm.ShowDialog();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void TxtAmount_Leave(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtAmount);
        }
    }
}
