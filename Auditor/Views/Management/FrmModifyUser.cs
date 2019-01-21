using System;
using System.Windows.Forms;
using Auditor.Models;
using Auditor.Properties;

namespace Auditor.Views.Management
{
    public partial class FrmModifyUser : Form
    {
        // Declare variables:
        private string _encryptedPass;

        int _intDisbled;
        int _intLocked;

        public FrmModifyUser()
        {
            InitializeComponent();
            userGroupsTableAdapter.Fill(auditorDataSet.UserGroups);
            usersTableAdapter.Fill(auditorDataSet.Users);
            ComboUserName.SelectedIndex = -1;
            ComboUserGroups.SelectedIndex = -1;
            _intDisbled = 0;
            _intLocked = 0;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void ComboUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
            ImportData();
        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
            _encryptedPass = Security.EncryptPassword(TxtPassword);
        }

        private void ComboUserGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void CheckDisabled_CheckedChanged(object sender, EventArgs e)
        {
            _intDisbled = CheckDisabled.CheckState == CheckState.Checked ? 1 : 0;
        }

        private void CheckLocked_CheckedChanged(object sender, EventArgs e)
        {
            _intLocked = CheckLocked.CheckState == CheckState.Checked ? 1 : 0;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    if (TxtPassword.Text == "")
                    {
                        dc.ProUpdateUserWithoutUpdatePassword(ComboUserName.Text, TxtFirstName.Text,
                            TxtLastName.Text, TxtAddress.Text, TxtTelephone.Text, TxtUserName.Text,
                            int.Parse(ComboUserGroups.SelectedValue.ToString()), _intDisbled, _intLocked,
                            TxtNotes.Text);
                    }
                    else
                    {
                        dc.ProUpdateUser(ComboUserName.Text, TxtFirstName.Text, TxtLastName.Text,
                            TxtAddress.Text, TxtTelephone.Text, TxtUserName.Text, _encryptedPass,
                            int.Parse(ComboUserGroups.SelectedValue.ToString()), _intDisbled, _intLocked,
                            TxtNotes.Text);
                    }
                }
                MessageBox.Show(Resources.MsgUserUpdated, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
                new FrmModifyUser().Show();
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
                DialogResult rslt = MessageBox.Show(Resources.MsgUserDeleteConfirm, Resources.AppName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt == DialogResult.Yes)
                {
                    using (DBAuditDataContext dc = new DBAuditDataContext())
                    {
                        dc.ProDeleteUser(ComboUserName.Text);
                    }
                    MessageBox.Show(Resources.MsgUserDeleted, Resources.AppName, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                    new FrmModifyUser().Show();
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
            if (ComboUserName.SelectedIndex >= 0 && !string.IsNullOrEmpty(TxtFirstName.Text) &&
                !string.IsNullOrEmpty(TxtLastName.Text) && !string.IsNullOrEmpty(TxtUserName.Text) &&
                ComboUserGroups.SelectedIndex >= 0)
            {
                BtnUpdate.Enabled = true;
            }
            else
            {
                BtnUpdate.Enabled = false;
            }
            BtnDelete.Enabled = ComboUserName.Text != "";
        }

        private void ImportData()
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    if (ComboUserName.Text != "")
                    {
                        string strFirstName = null;
                        string strLastName = null;
                        string strAddress = null;
                        string strTelephone = null;
                        string strUserName = null;
                        int? intGroupId = null;
                        string strGroup = null;
                        int? intDisabled = null;
                        int? intLocked = null;
                        string strNotes = null;
                        dc.ProSelectUser(ComboUserName.Text, ref strFirstName, ref strLastName, ref strAddress,
                            ref strTelephone, ref strUserName, ref intGroupId, ref intDisabled, ref intLocked,
                            ref strNotes);
                        TxtFirstName.Text = strFirstName;
                        TxtLastName.Text = strLastName;
                        TxtAddress.Text = strAddress;
                        TxtTelephone.Text = strTelephone;
                        TxtUserName.Text = strUserName;
                        dc.ProGetGroupByID(intGroupId, ref strGroup);
                        ComboUserGroups.Text = strGroup;
                        CheckDisabled.Checked = intDisabled == 1;
                        CheckLocked.Checked = intLocked == 1;
                        TxtNotes.Text = strNotes;
                    }
                    else
                    {
                        TxtFirstName.Text = "";
                        TxtLastName.Text = "";
                        TxtAddress.Text = "";
                        TxtTelephone.Text = "";
                        TxtUserName.Text = "";
                        TxtPassword.Text = "";
                        ComboUserGroups.Text = "";
                        CheckDisabled.Checked = false;
                        CheckLocked.Checked = false;
                    }
                }
            }
            catch (NullReferenceException)
            {
            }
            catch (InvalidOperationException)
            {
                TxtFirstName.Text = "";
                TxtLastName.Text = "";
                TxtAddress.Text = "";
                TxtTelephone.Text = "";
                TxtUserName.Text = "";
                TxtPassword.Text = "";
                ComboUserGroups.Text = "";
                CheckDisabled.Checked = false;
                CheckLocked.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}