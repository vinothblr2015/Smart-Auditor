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
    public partial class FrmModifyTelNo : Form
    {
        public FrmModifyTelNo()
        {
            InitializeComponent();
        }

        private void FrmModifyTelNo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.auditorDataSet.Location);
            // TODO: This line of code loads data into the 'auditorDataSet.TelNo' table. You can move, or remove it, as needed.
            this.telNoTableAdapter.Fill(this.auditorDataSet.TelNo);
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.auditorDataSet.Location);
            // TODO: This line of code loads data into the 'auditorDataSet.TelNo' table. You can move, or remove it, as needed.
            this.telNoTableAdapter.Fill(this.auditorDataSet.TelNo);
            ComboTelNo.Text = "";
            ComboLocation.Text = "";
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
        }

        private void ComboTelNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboTelNo.SelectedIndex == 0)
            {
                BtnDelete.Enabled = false;
            }
            else
            {
                BtnDelete.Enabled = true;
            }
            if (ComboTelNo.SelectedIndex == 0 || TxtTelNo.Text == "" || ComboLocation.SelectedIndex == 0)
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void ComboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboTelNo.SelectedIndex == 0 || TxtTelNo.Text == "" || ComboLocation.SelectedIndex == 0)
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }

        }

        private void TxtTelNo_TextChanged(object sender, EventArgs e)
        {
            if (ComboTelNo.SelectedIndex == 0 || TxtTelNo.Text == "" || ComboLocation.SelectedIndex == 0)
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProUpdateTelNo(int.Parse(ComboTelNo.SelectedValue.ToString()), TxtTelNo.Text, int.Parse(ComboLocation.SelectedValue.ToString()), TxtNotes.Text);
                }
                MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                FrmModifyTelNo Frm = new FrmModifyTelNo();
                Frm.ShowDialog();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Rslt = MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Rslt == DialogResult.Yes)
                {
                    using (DBAuditDataContext dc = new DBAuditDataContext())
                    {
                        var c = dc.ProDeleteTelNo(int.Parse(ComboTelNo.SelectedValue.ToString()));
                    }
                    MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
