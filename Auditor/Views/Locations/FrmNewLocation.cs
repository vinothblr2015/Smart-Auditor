using System;
using System.Windows.Forms;
using Auditor.Properties;

namespace Auditor.Views.Locations
{
    public partial class FrmNewLocation : Form
    {
        public FrmNewLocation()
        {
            InitializeComponent();
            sectorsTableAdapter.Fill(auditorDataSet.Sectors);
            BtnSave.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
            {
                    //var c = dc.ProAddLocation(TxtName.Text, TxtNotes.Text);
                    dc.ProAddLocation(TxtName.Text, int.Parse(ComboSectors.SelectedValue.ToString()), TxtNotes.Text);
                MessageBox.Show(Resources.MsgLocationAdded, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                new FrmNewLocation().Show();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            BtnSave.Enabled = !string.IsNullOrEmpty(TxtName.Text);
        }
    }
}
