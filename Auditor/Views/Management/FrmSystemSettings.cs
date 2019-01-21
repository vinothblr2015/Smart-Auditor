using System;
using System.Windows.Forms;
using Auditor.Properties;

namespace Auditor.Views.Management
{
    public partial class FrmSystemSettings : Form
    {
        public FrmSystemSettings()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dc = new DBAuditDataContext())
                {
                    dc.ProAuditorGeneralSettings(DatePeriodStart.Value, DatePeriodEnd.Value);
                    MessageBox.Show(Resources.MsgAppSettingsSaved, Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSystemSettings_Load(object sender, EventArgs e)
        {
            try
            {
                using (var dc = new DBAuditDataContext())
                {
                    DateTime? periodSatart = null;
                    DateTime? periodEnd = null;
                    dc.ProGetAuditorSettings(ref periodSatart,ref periodEnd);
                    if (periodSatart != null) DatePeriodStart.Value = periodSatart.Value;
                    if (periodEnd != null) DatePeriodEnd.Value = periodEnd.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
