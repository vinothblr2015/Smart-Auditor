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
    public partial class FrmViewCures : Form
    {
        public FrmViewCures()
        {
            InitializeComponent();
        }

        private void BtnSearchDocNo_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProGetCureByDocNo(TxtDocNo.Text);
                    GrdViewCure.DataSource = c;
                    ComboName.Text = "";
                    ComboLocation.Text = "";
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BtnSearchLocation_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProGetCureByLocationID(int.Parse(ComboLocation.SelectedValue.ToString()));
                    GrdViewCure.DataSource = c;
                    ComboName.Text = "";
                    TxtDocNo.Text = "";
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProGetCureByEmployeeID(int.Parse(ComboName.SelectedValue.ToString()));
                    GrdViewCure.DataSource = c;
                    TxtDocNo.Text = "";
                    ComboLocation.Text = "";
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }

        private void FrmViewCures_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.auditorDataSet.Employee);
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.auditorDataSet.Location);
            //
            // Formatting the form:
            //
            ComboLocation.Text = "";
            ComboName.Text = "";
            BtnSearchDocNo.Enabled = false;
            BtnSearchPayDate.Enabled = false;
            BtnSearchLocation.Enabled = false;
            BtnSearchEmployee.Enabled = false;
        }

        private void TxtDocNo_TextChanged(object sender, EventArgs e)
        {
            BtnSearchDocNo.Enabled = true;
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            BtnSearchLocation.Enabled = true;
        }

        private void ComboName_TextChanged(object sender, EventArgs e)
        {
            BtnSearchEmployee.Enabled = true;
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

        private void BtnSearchPayDate_Click(object sender, EventArgs e)
        {

        }
    }
}
