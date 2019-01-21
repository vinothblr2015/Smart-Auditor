using System;
using System.Windows.Forms;
using Auditor.Models;

namespace Auditor.Views.Management
{
    public partial class FrmNewUser : Form
    {
        public FrmNewUser()
        {
            InitializeComponent();
        }

        // Declare variables:
        int _intDisbled, _intLocked;

        // Control Enable and disable add button
        public void ControlBtnAdd()
        {
            if (TxtFirstName.Text != "" && TxtLastName.Text != "" && TxtUserName.Text != "" && TxtPassword.Text != "" &&
                ComboUserGroups.Text != "")
            {
                BtnAdd.Enabled = true;
            }
            else
            {
                BtnAdd.Enabled = false;
            }
        }

        private void FrmNewUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.UserGroups' table. You can move, or remove it, as needed.
            userGroupsTableAdapter.Fill(auditorDataSet.UserGroups);
            ComboUserGroups.Text = "";
            _intDisbled = 0;
            _intLocked = 0;
            BtnAdd.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            ControlBtnAdd();
        }

        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            ControlBtnAdd();
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            ControlBtnAdd();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            ControlBtnAdd();
        }

        private void ComboUserGroups_TextChanged(object sender, EventArgs e)
        {
            ControlBtnAdd();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var strEncPass = Security.EncryptPassword(TxtPassword);
                    dc.ProAddUser(TxtFirstName.Text, TxtLastName.Text, TxtAddress.Text, TxtTelephone.Text,
                        TxtUserName.Text, strEncPass, int.Parse(ComboUserGroups.SelectedValue.ToString()), _intDisbled,
                        _intLocked, TxtNotes.Text);
                }
                MessageBox.Show(@"تمت إضافة بيانات المستخدم بنجاح", @"المراجع الذكي", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
                new FrmNewUser().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckDisabled.CheckState == CheckState.Checked)
            {
                _intDisbled = 1;
            }
            else
            {
                _intDisbled = 0;
            }
        }

        private void CheckLocked_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckLocked.CheckState == CheckState.Checked)
            {
                _intLocked = 1;
            }
            else
            {
                _intLocked = 0;
            }
        }
    }
}