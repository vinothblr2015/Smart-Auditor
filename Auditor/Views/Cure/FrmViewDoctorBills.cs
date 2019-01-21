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
    public partial class FrmViewDoctorBills : Form
    {
        public FrmViewDoctorBills()
        {
            InitializeComponent();
        }
        
        // Formatting buttons
        public void Format(string StrKey, Button Btn)
        {
            if (StrKey == "")
            {
                Btn.Enabled = false;
            }
            else
            {
                Btn.Enabled = true;
                this.AcceptButton = Btn;
            }
        }

        private void TxtDocNo_TextChanged(object sender, EventArgs e)
        {
            Format(TxtDocNo.Text, BtnSearchDocNo);
        }

        private void DatePay_Enter(object sender, EventArgs e)
        {
            BtnSearchPayDate.Enabled = true;
            this.AcceptButton = BtnSearchPayDate;
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            Format(ComboLocation.Text, BtnSearchLocation);
        }

        private void ComboDoctor_TextChanged(object sender, EventArgs e)
        {
            Format(ComboDoctor.Text, BtnSearchDoctor);
        }

        private void BtnSearchDocNo_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    // Search progress:
                    var c = dc.ProGetDoctorBillByDocNo(TxtDocNo.Text);
                    GrdViewDoctorBills.DataSource = c;
                    // Formatting the form
                    BtnSearchPayDate.Enabled = false;
                    BtnSearchLocation.Enabled = false;
                    BtnSearchDoctor.Enabled = false;
                    ComboLocation.Text = "";
                    ComboDoctor.Text = "";
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }            
        }

        private void BtnSearchPayDate_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    // Search progress:
                    var c = dc.ProGetDoctorBillByPayDate(DatePay.Value.Date);
                    GrdViewDoctorBills.DataSource = c;
                    // Formatting the form
                    BtnSearchDocNo.Enabled = false;
                    BtnSearchLocation.Enabled = false;
                    BtnSearchDoctor.Enabled = false;
                    TxtDocNo.Text = "";
                    ComboLocation.Text = "";
                    ComboDoctor.Text = "";
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
                    // Search progress:
                    var c = dc.ProGetDoctorBillByLocationID(int.Parse(ComboLocation.SelectedValue.ToString()));
                    GrdViewDoctorBills.DataSource = c;
                    // Formatting the form
                    BtnSearchDocNo.Enabled = false;
                    BtnSearchPayDate.Enabled = false;
                    BtnSearchDoctor.Enabled = false;
                    TxtDocNo.Text = "";
                    ComboDoctor.Text = "";
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BtnSearchDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    // Search progress:
                    var c = dc.ProGetDoctorBillByDoctorID(int.Parse(ComboDoctor.SelectedValue.ToString()));
                    GrdViewDoctorBills.DataSource = c;
                    // Formatting the form
                    BtnSearchDocNo.Enabled = false;
                    BtnSearchPayDate.Enabled = false;
                    BtnSearchDoctor.Enabled = false;
                    TxtDocNo.Text = "";
                    ComboLocation.Text = "";
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void FrmViewDoctorBills_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.auditorDataSet.Doctor);
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.auditorDataSet.Location);
            ComboLocation.Text = "";
            ComboDoctor.Text = "";
            Format(ComboLocation.Text, BtnSearchLocation);
            Format(ComboDoctor.Text, BtnSearchDoctor);
        }
    }
}
