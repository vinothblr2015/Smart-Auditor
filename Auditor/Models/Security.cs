using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Auditor.Properties;
using Auditor.Views;

namespace Auditor.Models
{
    class Security
    {
        // Declaring variables
        static int _countLogin;

        static string _strUser;
        static int _staticIntUserId;
        static string _staticStrUserName;
        static string _staticStrLoginTime;
        int? _intAdmin;
        int? _intAdd;
        int? _intEdit;
        int? _intView;

        /**
         * Verify that there is single instence from the application is running at the same time
         * */
        public static void SingleInstance(Form frm)
        {
            bool firstInstance;
            var mutex = new Mutex(true, "ProgramKey", out firstInstance);
            if (firstInstance) return;
            MessageBox.Show(Resources.MsgSingleInstance, Resources.AppName, MessageBoxButtons.OK,
                MessageBoxIcon.Hand);
            frm.Close();
        }

        /**
         * User authentication
         */
        public static void Authenticate(TextBox txtUser, TextBox txtPass, Form frmLogin)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    _strUser = txtUser.Text;
                    int? intUSerId = null;
                    string strPass = null;
                    int? intDisabled = null;
                    int? intLocked = null;
                    string strFName = null;
                    string strLName = null;
                    var strEncPass = EncryptPassword(txtPass);
                    dc.ProLoginData(_strUser, ref intUSerId, ref strPass, ref intDisabled, ref intLocked,
                        ref strFName, ref strLName);
                    if (strPass == strEncPass && intDisabled == 0 && intLocked == 0)
                    {
                        // Get Current User Details
                        _staticIntUserId = Convert.ToInt32(intUSerId);
                        _staticStrUserName = strFName + " " + strLName;
                        //                               
                        // Open Main Form & close the Login Form: 
                        new FrmMain().Show();
                        // Change Culture (Input language) to Arabic:
                        CultureInfo ci = new CultureInfo("AR-EG");
                        Thread.CurrentThread.CurrentCulture = ci;
                        Thread.CurrentThread.CurrentUICulture = ci;
                        Application.CurrentCulture = ci;
                        Application.CurrentInputLanguage = InputLanguage.FromCulture(ci);
                        //
                        // Add Login Process to Log
                        string strLoginTime = DateTime.Now.ToString(CultureInfo.CurrentCulture);
                        dc.ProAuditLogin(_staticIntUserId, strLoginTime);
                        _staticStrLoginTime = strLoginTime;
                        frmLogin.Close();
                    }
                    else if (intDisabled == 1)
                    {
                        MessageBox.Show(@"عفواً تم تعطيل هذا الحساب يرجى الرجوع للإدارة", @"المراجع الذكي",
                            MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        txtUser.Text = "";
                        txtPass.Text = "";
                    }
                    else if (intLocked == 1)
                    {
                        MessageBox.Show(@"عفواً تم تعطيل هذا الحساب مؤقتاً يرجى الرجوع للإدارة", @"المراجع الذكي",
                            MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        txtUser.Text = "";
                        txtPass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(@"عفواً البيانات التي قمت بإدخالها غير صحيحة!", @"المراجع الذكي",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _countLogin = _countLogin + 1;
                        txtPass.Text = "";
                        if (_countLogin >= 3)
                        {
                            dc.ProAutoLockAccount(_strUser);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * Encrypt user password before storing it in the database
         */
        public static String EncryptPassword(TextBox txtPass)
        {
            // Encrypt password Start
            MD5Cng hashEnc = new MD5Cng();
            byte[] password = Encoding.ASCII.GetBytes(txtPass.Text);
            byte[] hashedPass = hashEnc.ComputeHash(password);
            return Encoding.ASCII.GetString(hashedPass);
        }

        /**
         * Add logout record to log
         */
        public static void LogoutLog()
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProAuditLogout(_staticIntUserId, _staticStrLoginTime,
                        DateTime.Now.ToString(CultureInfo.CurrentCulture));
                }
                _staticStrUserName = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        /** 
         * Logout current user
         */ 
        public static void LogOut()
        {
            try
            {
                LogoutLog();
                CloseOtherForms();
                new FrmLogin().Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void CloseOtherForms()
        {
            try
            {
                List<Form> openForms = new List<Form>();
                foreach (Form f in Application.OpenForms)
                {
                    openForms.Add(f);
                }
                foreach (Form f in openForms)
                {
                    if (f.Name != "FrmLogin") f.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /**
         * Apply permissions to users depending on user group
         */
        public bool ApplyPermisions(string strPerm)
        {
            bool isEnabled = false;
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProGetUserPermisions(_strUser, ref _intAdmin, ref _intAdd, ref _intEdit, ref _intView);
                }
                if (strPerm == "Admin" && _intAdmin == 1)
                {
                    isEnabled = true;
                }
                else if (strPerm == "Add" && _intAdd == 1)
                {
                    isEnabled = true;
                }
                else if (strPerm == "Edit" && _intEdit == 1)
                {
                    isEnabled = true;
                }
                else if (strPerm == "View" && _intView == 1)
                {
                    isEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return isEnabled;
        }

        /** 
         * Get current user name
         */ 
        public static string GetCurrentUser()
        {
            return _staticStrUserName;
        }

        /**
         * Change keyboard input language
         */
        public static void ChangeKeyboard(string languageCode)
        {
            CultureInfo ci = new CultureInfo(languageCode);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            Application.CurrentCulture = ci;
            Application.CurrentInputLanguage = InputLanguage.FromCulture(ci);
        }
    }
}