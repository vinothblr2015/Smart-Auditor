using System;
using System.Windows.Forms;
using Auditor.Properties;

namespace Auditor.Views.Employees
{
    public partial class FrmNewEmployee : Form
    {
        public FrmNewEmployee()
        {
            InitializeComponent();
            locationTableAdapter.Fill(this.auditorDataSet.Location);
            ComboLocation.SelectedIndex = -1;
        }

        private void ComboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProAddEmployee(TxtName.Text, int.Parse(ComboLocation.SelectedValue.ToString()), ComboDegree.Text, ComboPosition.Text, TxtAddress.Text, TxtTelephone.Text, TxtNotes.Text);
                }
                MessageBox.Show(Resources.MsgEmployeeAdded, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                new FrmNewEmployee().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormatForm()
        {
            if (ComboLocation.SelectedIndex == -1 || string.IsNullOrEmpty(TxtName.Text))
            {
                BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
            }
        }

    }
}
