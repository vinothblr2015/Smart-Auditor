using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Auditor
{
    public partial class FrmNewDoctor : Form
    {
        public FrmNewDoctor()
        {
            InitializeComponent();
        }

        public void FormatForm(TextBox TxtDoc, ComboBox ComboType, Button Btn)
        {
            if (TxtDoc.Text == "" ||ComboType.Text == "")
            {
                Btn.Enabled = false;
            }
            else
            {
                Btn.Enabled = true;
            }
        }

        private void FrmNewDoctor_Load(object sender, EventArgs e)
        {
            BtnSave.Enabled = false;
        }

        private void TxtDoctor_TextChanged(object sender, EventArgs e)
        {
            FormatForm(TxtDoctor,ComboType,BtnSave);
        }

        private void ComboType_TextChanged(object sender, EventArgs e)
        {
            FormatForm(TxtDoctor, ComboType, BtnSave);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProAddDoctor(TxtDoctor.Text, ComboType.Text,TxtNotes.Text);
                }
                MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FrmNewDoctor Frm = new FrmNewDoctor();
                Frm.Show();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            } 
        }
    }
}
