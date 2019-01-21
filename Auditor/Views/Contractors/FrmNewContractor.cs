using System;
using System.Windows.Forms;
using Auditor.Properties;

namespace Auditor.Views.Contractors
{
    public partial class FrmNewContractor : Form
    {
        public FrmNewContractor()
        {
            InitializeComponent();
            BtnSave.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProAddContractor(TxtName.Text, TxtNotes.Text);
                }
                MessageBox.Show(Resources.MsgContractorAdded, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
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
