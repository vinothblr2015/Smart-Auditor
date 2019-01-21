using System;
using System.Windows.Forms;
using Auditor.Properties;

namespace Auditor.Views.Locations
{
    public partial class FrmModifyLocation : Form
    {
        public FrmModifyLocation()
        {
            InitializeComponent();
            sectorsTableAdapter.Fill(auditorDataSet.Sectors);
            locationTableAdapter.Fill(auditorDataSet.Location);
            ComboLocation.SelectedIndex = -1;
            ComboSectors.SelectedIndex = -1;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }


        private void ComboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
            ImportData();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dc = new DBAuditDataContext())
                {
                    var c = dc.ProUpdateLocation(int.Parse(ComboLocation.SelectedValue.ToString()), TxtName.Text,
                        int.Parse(ComboSectors.SelectedValue.ToString()), TxtNotes.Text);
                }
                MessageBox.Show(Resources.MsgLocationUpdated, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
                new FrmModifyLocation().Show();
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
                var rslt = MessageBox.Show(Resources.MsgLocationDeleteConfirm, Resources.AppName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt != DialogResult.Yes) return;
                using (var dc = new DBAuditDataContext())
                {
                    dc.ProDeleteLocation(int.Parse(ComboLocation.SelectedValue.ToString()));
                }
                MessageBox.Show(Resources.MsgLocationDeleted, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
                new FrmModifyLocation().Show();
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
            BtnDelete.Enabled = ComboLocation.SelectedIndex >= 0;
            if (ComboLocation.SelectedIndex < 0 || string.IsNullOrEmpty(TxtName.Text))
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void ImportData()
        {           
            // Loading data into the form
            try
            {
                if (ComboLocation.SelectedIndex < 0) return;
                using (var dc = new DBAuditDataContext())
                {
                    string strName = null;
                    int? intSectorId = null;
                    string strNotes = null;
                    dc.ProSelectLocation(int.Parse(ComboLocation.SelectedValue.ToString()), ref strName,
                        ref intSectorId,
                        ref strNotes);
                    TxtName.Text = strName;
                    ComboSectors.SelectedValue = intSectorId;
                    TxtNotes.Text = strNotes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}