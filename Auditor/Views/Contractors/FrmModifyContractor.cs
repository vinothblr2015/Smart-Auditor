using System;
using System.Windows.Forms;
using Auditor.Properties;

namespace Auditor.Views.Contractors
{
    public partial class FrmModifyContractor : Form
    {
        public FrmModifyContractor()
        {
            InitializeComponent();
            contractorTableAdapter.Fill(auditorDataSet.Contractor);
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            ComboName.SelectedIndex = -1;
        }

        private void ComboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
            ImportData();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProUpdateContractor(TxtName.Text, TxtNotes.Text,
                        int.Parse(ComboName.SelectedValue.ToString()));
                }
                MessageBox.Show(Resources.MsgContractorUpdated, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
                new FrmModifyContractor().Show();
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
                DialogResult rslt = MessageBox.Show(Resources.MsgContractorDeleteConfirm, Resources.AppName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt == DialogResult.Yes)
                {
                    using (DBAuditDataContext dc = new DBAuditDataContext())
                    {
                        dc.ProDeleteContractor(int.Parse(ComboName.SelectedValue.ToString()));
                    }
                    MessageBox.Show(Resources.MsgContractordeleted, Resources.AppName, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
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
            BtnDelete.Enabled = ComboName.SelectedIndex >= 0;
            if (ComboName.SelectedIndex < 0 || TxtName.Text == "")
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }

        private void ImportData()
        {
            try
            {
                //Loading data into the form:
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    if (ComboName.Text != "")
                    {
                        string strName = null;
                        string strNotes = null;
                        dc.ProSelectContractor(int.Parse(ComboName.SelectedValue.ToString()), ref strName,
                            ref strNotes);
                        TxtName.Text = strName;
                        TxtNotes.Text = strNotes;
                    }
                    else
                    {
                        TxtName.Clear();
                        TxtNotes.Clear();
                    }
                }
            }
            catch (NullReferenceException)
            {
            }
            catch (InvalidOperationException)
            {
                TxtName.Clear();
                TxtNotes.Clear();
                BtnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}