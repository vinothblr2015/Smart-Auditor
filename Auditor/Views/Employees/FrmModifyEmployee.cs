using System;
using System.Windows.Forms;
using Auditor.Properties;

namespace Auditor.Views.Employees
{
    public partial class FrmModifyEmployee : Form
    {
        public FrmModifyEmployee()
        {
            InitializeComponent();
            locationTableAdapter.Fill(auditorDataSet.Location);
            employeeTableAdapter.Fill(auditorDataSet.Employee);
            ComboLocation.SelectedIndex = -1;
            ComboName.SelectedIndex = -1;
            ComboDegree.SelectedIndex = -1;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProUpdateEmployee(int.Parse(ComboName.SelectedValue.ToString()), TxtName.Text,
                        int.Parse(ComboLocation.SelectedValue.ToString()), ComboDegree.Text, ComboPosition.Text,
                        TxtAddress.Text, TxtTelephone.Text, TxtNotes.Text);
                }
                MessageBox.Show(Resources.MsgEmployeeUpdated, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
                new FrmModifyEmployee().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rslt = MessageBox.Show(Resources.MsgEmployeeDeleteConfirm, Resources.AppName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt != DialogResult.Yes) return;
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProDeleteEmployee(int.Parse(ComboName.SelectedValue.ToString()));
                }
                MessageBox.Show(Resources.MsgEmloyeeDeleted, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
            ImportData();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void ComboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void ImportData()
        {
            try
            {
                // Loading data into the form:
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    if (ComboName.Text == "") return;
                    string strName = null;
                    int? intLocationId = null;
                    string strLocation = null;
                    string strDegree = null;
                    string strPosition = null;
                    string strAdress = null;
                    string strTelephone = null;
                    string strNotes = null;
                    dc.ProSelectEmployee(int.Parse(ComboName.SelectedValue.ToString()), ref strName,
                        ref intLocationId, ref strDegree, ref strPosition, ref strAdress, ref strTelephone,
                        ref strNotes);
                    dc.ProGetLocationByID(intLocationId, ref strLocation);
                    TxtName.Text = strName;
                    ComboLocation.Text = strLocation;
                    ComboDegree.Text = strDegree;
                    ComboPosition.Text = strPosition;
                    TxtAddress.Text = strAdress;
                    TxtTelephone.Text = strTelephone;
                    TxtNotes.Text = strNotes;
                }
            }
            catch (NullReferenceException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormatForm()
        {
            BtnDelete.Enabled = ComboName.Text != "";
            if (ComboLocation.SelectedIndex < 0 || ComboName.SelectedIndex < 0 || TxtName.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }
    }
}