using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Auditor.Models;

namespace Auditor.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            Security.SingleInstance(this);
            BtnLogin.Enabled = false;
            Security.ChangeKeyboard("EN-US");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Security.Authenticate(TxtUName, TxtPassword, this);
        }
        
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_UserName_Password_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUName.Text) && !string.IsNullOrEmpty(TxtPassword.Text))
            {
                string strPass = TxtPassword.Text;
                BtnLogin.Enabled = strPass.Length >= 8;
            }
            else
            {
                BtnLogin.Enabled = false;
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exit Application if not Log in:
            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
            {
                openForms.Add(f);
            }
            if (openForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
