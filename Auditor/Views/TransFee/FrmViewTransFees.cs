using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auditor
{
    public partial class FrmViewTransFees : Form
    {
        public FrmViewTransFees()
        {
            InitializeComponent();
        }

        private void FrmViewTransFees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.auditorDataSet.Employee);
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.auditorDataSet.Location);

            // Formatting the form:
            BtnSearchDocNo.Enabled = false;
            BtnSearchPayDate.Enabled = false;
            BtnSearchEmployee.Enabled = false;
            BtnSearchLocation.Enabled = false;
            ComboLocation.Text = "";
            ComboName.Text = "";
        }

        private void BtnSearchDocNo_Click(object sender, EventArgs e)
        {
            // Formatting the form:
            LblTotalTrans.Visible = true;
            LblTotalTravel.Visible = true;
            TxtTotalTrans.Visible = true;
            TxtTotalTravel.Visible = true;
            LblPound1.Visible = true;
            LblPound2.Visible = true;

            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    // Search progress:
                    var c = dc.ProGetTransFeeByDocNo(TxtDocNo.Text);
                    GrdViewTransFees.DataSource = c;

                    // Calculating:
                    double? DoubleTotalTrans = null;
                    double? DoubleTotalTravel = null;
                    int? IntCount = null;
                    var d = dc.ProCountTotal(TxtDocNo.Text, ref DoubleTotalTrans, ref DoubleTotalTravel, ref IntCount);
                    TxtCountRec.Text = IntCount.ToString();
                    TxtTotalTrans.Text = DoubleTotalTrans.ToString();
                    TxtTotalTravel.Text = DoubleTotalTravel.ToString();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BtnSearchPayDate_Click(object sender, EventArgs e)
        {
            // Formatting the form:
            LblTotalTrans.Visible = false;
            LblTotalTravel.Visible = false;
            TxtTotalTrans.Visible = false;
            TxtTotalTravel.Visible = false;
            LblPound1.Visible = false;
            LblPound2.Visible = false;
            
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                { 
                    
                   // Calculating:
                    int? IntCount = null;
                    var d = dc.ProCountPayDate(DatePay.Value.Date, ref IntCount);
                    TxtCountRec.Text = IntCount.ToString();

                    // Search Progress:
                    var c = dc.ProGetTransFeeByPayDate(DatePay.Value.Date);
                    GrdViewTransFees.DataSource = c;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BtnSearchLocation_Click(object sender, EventArgs e)
        {
            // Formatting the form:
            LblTotalTrans.Visible = false;
            LblTotalTravel.Visible = false;
            TxtTotalTrans.Visible = false;
            TxtTotalTravel.Visible = false;
            LblPound1.Visible = false;
            LblPound2.Visible = false;

            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    // Calculating:
                    int? IntCount = null;
                    var d = dc.ProCountLocation(int.Parse(ComboLocation.SelectedValue.ToString()), ref IntCount);
                    TxtCountRec.Text = IntCount.ToString();

                    // Search Progress:
                    var c = dc.ProGetTransFeeByLocationID(int.Parse(ComboLocation.SelectedValue.ToString()));
                    GrdViewTransFees.DataSource = c;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            // Formatting the form:
            LblTotalTrans.Visible = false;
            LblTotalTravel.Visible = false;
            TxtTotalTrans.Visible = false;
            TxtTotalTravel.Visible = false;
            LblPound1.Visible = false;
            LblPound2.Visible = false;

            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    // Calculating:
                    int? IntCount = null;
                    var d = dc.ProCountEmployee(int.Parse(ComboName.SelectedValue.ToString()), ref IntCount);
                    TxtCountRec.Text = IntCount.ToString();

                    // Search Progress:
                    var c = dc.ProGetTransFeeByEmployeeID(int.Parse(ComboName.SelectedValue.ToString()));
                    GrdViewTransFees.DataSource = c;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void TxtDocNo_TextChanged(object sender, EventArgs e)
        {
            if (TxtDocNo.Text != "")
            {
                BtnSearchDocNo.Enabled = true;
            }
            else
            {
                BtnSearchDocNo.Enabled = false;
            }
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            if (ComboLocation.Text != "")
            {
                BtnSearchLocation.Enabled = true;
            }
            else
            {
                BtnSearchLocation.Enabled = false;
            }
        }

        private void ComboName_TextChanged(object sender, EventArgs e)
        {
            if (ComboName.Text != "")
            {
                BtnSearchEmployee.Enabled = true;
            }
            else
            {
                BtnSearchEmployee.Enabled = false;
            }
        }

        private void TxtDocNo_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = BtnSearchDocNo;
        }

        private void DatePay_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = BtnSearchPayDate;
        }

        private void ComboLocation_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = BtnSearchLocation;
        }

        private void ComboName_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = BtnSearchEmployee;
        }

        private void DatePay_CloseUp(object sender, EventArgs e)
        {
            BtnSearchPayDate.Enabled = true;
        }
    }
}
