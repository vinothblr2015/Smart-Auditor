using System;
using System.Windows.Forms;

namespace Auditor.Views.Telepohne
{
    public partial class FrmNewTelNo : Form
    {
        public FrmNewTelNo()
        {
            InitializeComponent();
        }

        private void FrmAddTelNo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            locationTableAdapter.Fill(auditorDataSet.Location);
            ComboLocation.Text = "";
            BtnSave.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProAddTelNo(TxtTelNo.Text, int.Parse(ComboLocation.SelectedValue.ToString()), TxtNotes.Text);
                }
                MessageBox.Show(@"تمت إضافة بيانات المستند بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
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

        private void TxtTelNo_TextChanged(object sender, EventArgs e)
        {
            if (TxtTelNo.Text == "" || ComboLocation.Text == "")
            {
                BtnSave.Enabled = false;
            }
            else
            {
                BtnSave.Enabled = true;
            }
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            if (TxtTelNo.Text == "" || ComboLocation.Text == "")
            {
                BtnSave.Enabled = false;
            }
            else
            {
                BtnSave.Enabled = true;
            }
        }
    }
}
