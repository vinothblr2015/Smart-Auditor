using System;
using System.Windows.Forms;
using Auditor.Properties;

namespace Auditor.Views.Management
{
    public partial class FrmModifyUserGroup : Form
    {
        int _intAdmin, _intAdd, _intEdit, _intView;

        public FrmModifyUserGroup()
        {
            InitializeComponent();
            userGroupsTableAdapter.Fill(auditorDataSet.UserGroups);
            ComboName.SelectedIndex = -1;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void ComboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
            ImportData();
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dc = new DBAuditDataContext())
                {
                    dc.ProUpdateUserGroup(ComboName.Text, TxtName.Text, _intAdmin, _intAdd, _intEdit, _intView,
                        TxtNotes.Text);
                }
                MessageBox.Show(Resources.MsgUserGroupUpdated, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
                new FrmModifyUserGroup().Show();
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
                var rslt = MessageBox.Show(Resources.msgUserGroupDeleteConfirm, Resources.AppName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt == DialogResult.Yes)
                {
                    using (var dc = new DBAuditDataContext())
                    {
                        dc.ProDeleteUserGroup(ComboName.Text);
                    }
                    MessageBox.Show(Resources.MsgUserGroupDeleted, Resources.AppName, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                    new FrmModifyUserGroup().Show();
                }
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
            if (ComboName.SelectedIndex >= 0)
            {
                BtnDelete.Enabled = true;
                BtnUpdate.Enabled = !string.IsNullOrEmpty(TxtName.Text);
            }
            else
            {
                BtnDelete.Enabled = false;
            }
        }

        private void ImportData()
        {
            try
            {
                // Loading data into the form
                using (var dc = new DBAuditDataContext())
                {
                    string strName = null;
                    int? intAdminPerm = null;
                    int? intAddPerm = null;
                    int? intEditPerm = null;
                    int? intViewPerm = null;
                    string strNotes = null;
                    dc.ProSelectUserGroup(ComboName.Text, ref strName, ref intAdminPerm, ref intAddPerm,
                        ref intEditPerm, ref intViewPerm, ref strNotes);
                    TxtName.Text = strName;
                    CheckAdmin.Checked = intAdminPerm == 1;
                    CheckAdd.Checked = intAddPerm == 1;
                    CheckEdit.Checked = intEditPerm == 1;
                    CheckView.Checked = intViewPerm == 1;
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