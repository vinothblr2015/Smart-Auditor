using System;
using System.Windows.Forms;
using Auditor.Models;

namespace Auditor.Views.Management
{
    public partial class FrmEditMyAccount : Form
    {
        public FrmEditMyAccount()
        {
            InitializeComponent();
        }

        // Define Variables
        static string _staticStrCurrentUserName;

        // Control Enable and disable update button
        public void ControlBtnUpdate()
        {
            if (TxtCurrentPassword.Text != "" && TxtFirstName.Text != "" && TxtLastName.Text != "" &&
                TxtUserName.Text != "")
            {
                BtnUpdate.Enabled = true;
            }
            else
            {
                BtnUpdate.Enabled = false;
            }
        }

        private void FrmEditMyAccount_Load(object sender, EventArgs e)
        {
            try
            {
                // Get Current User name Start
                _staticStrCurrentUserName = Security.GetCurrentUser();
                // Get current user name End
                //
                // Loading current user date into form Start
                string strFName = null;
                string strLName = null;
                string strAddress = null;
                string strTelephone = null;
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProSelectMyUserAccount(_staticStrCurrentUserName, ref strFName, ref strLName,
                        ref strAddress, ref strTelephone);
                    TxtUserName.Text = _staticStrCurrentUserName;
                    TxtFirstName.Text = strFName;
                    TxtLastName.Text = strLName;
                    TxtAddress.Text = strAddress;
                    TxtTelephone.Text = strTelephone;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Loading current user date into form End
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Verify current password & Update My Account Start                
                string strCurrentPassword = null;
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var strEncCurrentPass = Security.EncryptPassword(TxtCurrentPassword);
                    dc.ProGetUserPassword(_staticStrCurrentUserName, ref strCurrentPassword);
                    if (strEncCurrentPass == strCurrentPassword)
                    {
                        // Update User Data Start
                        if (TxtPassword.Text != "")
                        {
                            var strEncPass = Security.EncryptPassword(TxtPassword);
                            dc.ProUpdateUserMyAccount(_staticStrCurrentUserName, TxtFirstName.Text,
                                TxtLastName.Text, TxtAddress.Text, TxtTelephone.Text, TxtUserName.Text, strEncPass);
                        }
                        else
                        {
                            dc.ProUpdateUserMyAccountWithoutPassword(_staticStrCurrentUserName,
                                TxtFirstName.Text, TxtLastName.Text, TxtAddress.Text, TxtTelephone.Text,
                                TxtUserName.Text);
                        }
                        MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        // Update User Data End
                    }
                    else
                    {
                        MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي",
                            MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        TxtCurrentPassword.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Verify current password & Update My Account Start
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            ControlBtnUpdate();
        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            ControlBtnUpdate();
        }

        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            ControlBtnUpdate();
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            ControlBtnUpdate();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            ControlBtnUpdate();
        }
    }
}