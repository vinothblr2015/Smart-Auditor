using Auditor.Reports;
using Auditor.Views.Projects;
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
    public partial class FrmViewProjects : Form
    {
        public FrmViewProjects()
        {
            InitializeComponent();
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

        private void BtnSearchDocNo_Click(object sender, EventArgs e)
        {
            // Formatting the form Start
            ComboLocation.Text = "";
            ComboContractor.Text = "";
            ComboInsuranceStatus.Text = "";
            ComboReservedStatues.Text = "";
            // Formatting the form End
            //
            // Search operation Start
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProGetProjectByDocNo(TxtDocNo.Text);
                    GrdViewProject.DataSource = c;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            //Search operation End
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

        private void BtnSearchLocation_Click(object sender, EventArgs e)
        {
            // Formatting the form Start
            TxtDocNo.Text = "";
            ComboContractor.Text = "";
            ComboInsuranceStatus.Text = "";
            ComboReservedStatues.Text = "";
            // Formatting the form End
            //
            // Search operation Start
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProGetProjectByLocationID(int.Parse(ComboLocation.SelectedValue.ToString()));
                    GrdViewProject.DataSource = c;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            // Search Operartion End
        }

        private void FrmViewProjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Contractor' table. You can move, or remove it, as needed.
            this.contractorTableAdapter.Fill(this.auditorDataSet.Contractor);
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.auditorDataSet.Location);
            ComboLocation.Text = "";
            ComboContractor.Text = "";
        }

        private void ComboContractor_TextChanged(object sender, EventArgs e)
        {
            if (ComboContractor.Text != "")
            {
                BtnSearchContractor.Enabled = true;
            }
            else
            {
                BtnSearchContractor.Enabled = false;
            }
        }

        private void DatePay_ValueChanged(object sender, EventArgs e)
        {
            BtnSearchPayDate.Enabled = true;
        }

        private void BtnSearchPayDate_Click(object sender, EventArgs e)
        {
            // Formatting the form Start
            TxtDocNo.Text = "";
            ComboLocation.Text = "";
            ComboContractor.Text = "";
            ComboInsuranceStatus.Text = "";
            ComboReservedStatues.Text = "";
            // Formatting the form End
            //
            // Search operation Start
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProGetProjectByPayDate(DatePay.Value.Date);
                    GrdViewProject.DataSource = c;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            // Search operation End
        }

        private void ComboInsuranceStatus_TextChanged(object sender, EventArgs e)
        {
            if (ComboInsuranceStatus.Text != "")
            {
                BtnSearchInsuranceStatues.Enabled = true;
            }
            else
            {
                BtnSearchInsuranceStatues.Enabled = false;
            }
        }

        private void ComboReservedStatues_TextChanged(object sender, EventArgs e)
        {
            if (ComboReservedStatues.Text != "")
            {
                BtnSearchReservedStatus.Enabled = true;
            }
            else
            {
                BtnSearchReservedStatus.Enabled = false;
            }
        }

        private void BtnSearchInsuranceStatues_Click(object sender, EventArgs e)
        {
            // Formatting the form Start
            TxtDocNo.Text = "";
            ComboLocation.Text = "";
            ComboContractor.Text = "";
            ComboReservedStatues.Text = "";
            // Formatting the form End
            //
            // Search operation Start
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProGetProjectByInsuranceRefund(ComboInsuranceStatus.Text);
                    GrdViewProject.DataSource = c;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            // Search operation End
        }

        private void BtnSearchReservedStatus_Click(object sender, EventArgs e)
        {
            // Formatting the form Start
            TxtDocNo.Text = "";
            ComboLocation.Text = "";
            ComboContractor.Text = "";
            ComboInsuranceStatus.Text = "";
            // Formatting the form End
            //
            // Search operation Start
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProGetProjectByReservedRefund(ComboReservedStatues.Text);
                    GrdViewProject.DataSource = c;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            // Search operation End
        }

        private void BtnSearchContractor_Click(object sender, EventArgs e)
        {
            // Formatting the form Start
            ComboLocation.Text = "";
            TxtDocNo.Text = "";
            ComboInsuranceStatus.Text = "";
            ComboReservedStatues.Text = "";
            // Formatting the form End
            //
            // Search operation Start
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProGetProjectByContractorID(int.Parse(ComboContractor.SelectedValue.ToString()));
                    GrdViewProject.DataSource = c;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            // Search Operation End
        }

        private void btnPrintViewed_Click(object sender, EventArgs e)
        {
            new FrmRptProjects().Show();
        }

        private void btnPrintSelected_Click(object sender, EventArgs e)
        {
            new FrmRptProjects().Show();
        }

        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            FrmRptProjects frm = new FrmRptProjects();
            frm.Text = "طباعة بيانات كافة المستخلصات";
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
