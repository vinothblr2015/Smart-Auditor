using System;
using System.Windows.Forms;
using Auditor.Properties;

namespace Auditor.Views.Management
{
    public partial class FrmNewUserGroup : Form
    {
        public FrmNewUserGroup()
        {
            InitializeComponent();
            BtnAdd.Enabled = false;
            _intAdmin = _intAdd = _intEdit = _intView = 0;
        }

        // Declare variables:
        int _intAdmin,_intAdd,_intEdit,_intView;


        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            // Control add button Start
            if (TxtName.Text == "")
            {
                BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
            }
            // Control add button End
        }

        private void CheckAdmin_CheckedChanged(object sender, EventArgs e)
        {
            _intAdmin = CheckAdmin.CheckState == CheckState.Checked ? 1 : 0;
        }

        private void CheckAdd_CheckedChanged(object sender, EventArgs e)
        {
            _intAdd = CheckAdd.CheckState == CheckState.Checked ? 1 : 0;
        }

        private void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            _intEdit = CheckEdit.CheckState == CheckState.Checked ? 1 : 0;
        }

        private void CheckView_CheckedChanged(object sender, EventArgs e)
        {
            _intView = CheckView.CheckState == CheckState.Checked ? 1 : 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProAddUserGroup(TxtName.Text,_intAdmin,_intAdd,_intEdit,_intView,TxtNotes.Text);
                }
                MessageBox.Show(Resources.MsgUserGroupAdded,Resources.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                new FrmNewUserGroup().Show();
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
    }
}
