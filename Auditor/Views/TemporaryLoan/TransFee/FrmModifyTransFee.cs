using System;
using System.Windows.Forms;
using Auditor.Models;
using Auditor.Properties;

namespace Auditor.Views.TransFee
{
    public partial class FrmModifyTransFee : Form
    {
        public FrmModifyTransFee()
        {
            InitializeComponent();
            transFeeTableAdapter.Fill(auditorDataSet.TransFee);
            employeeTableAdapter.Fill(auditorDataSet.Employee);
            locationTableAdapter.Fill(auditorDataSet.Location);
            // Formatting the form:
            ComboDocNo.SelectedIndex = -1;
            ComboLocation.SelectedIndex = -1;
            ComboName.SelectedIndex = -1;
            DatePay.Text = null;
            TxtTrans.Text = Resources.Zero;
            TxtTravel.Text = Resources.Zero;
            BtnUpdate.Enabled = false;
            BtnDelete.Enabled = false;
            BtnDeleteDocument.Enabled = false;
        }

        private void ComboDocNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
            ImportData();
        }

        private void ComboLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void ComboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatForm();
            ImportData();
        }

        private void TxtDestination_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtPeriod_TextChanged(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void TxtTrans_TextChanged(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat((TextBox) sender);
            FormatForm();
        }

        private void TxtTravel_TextChanged(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat((TextBox) sender);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dc = new DBAuditDataContext())
                {
                    dc.ProUpdateTransFee(ComboDocNo.Text, DatePay.Value,
                        int.Parse(ComboLocation.SelectedValue.ToString()),
                        int.Parse(ComboName.SelectedValue.ToString()), TxtDestination.Text, TxtPeriod.Text,
                        decimal.Parse(TxtTrans.Text), decimal.Parse(TxtTravel.Text), TxtNotes.Text);
                }
                MessageBox.Show(Resources.MsgDocumentUpdated, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
                new FrmModifyTransFee().Show();
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
                var rslt = MessageBox.Show(Resources.MsgEmployeeTransFeeDeleteConfirm, Resources.AppName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt != DialogResult.Yes) return;
                using (var dc = new DBAuditDataContext())
                {
                    dc.ProDeleteTransFee(ComboDocNo.Text, int.Parse(ComboName.SelectedValue.ToString()));
                }
                MessageBox.Show(Resources.MsgEmployeeTransFeeDeleted, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
                new FrmModifyTransFee().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteDocument_Click(object sender, EventArgs e)
        {
            try
            {
                var rslt = MessageBox.Show(Resources.MsgDocumentDeleteConfirm, Resources.AppName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rslt != DialogResult.Yes) return;
                using (var dc = new DBAuditDataContext())
                {
                    dc.ProDeleteAllTransFee(ComboDocNo.Text);
                }
                MessageBox.Show(Resources.MsgDocumentDeleted, Resources.AppName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Close();
                new FrmModifyTransFee().Show();
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

        private void ImportData()
        {
            //Retreive document details from database
            try
            {
                using (var dc = new DBAuditDataContext())
                {
                    if (ComboDocNo.SelectedIndex != -1 && ComboName.SelectedIndex != -1)
                    {
                        DateTime? varDatePay = null;
                        int? intLocationId = null;
                        string strLocation = null;
                        string strDestination = null;
                        string strPeriod = null;
                        decimal? doubleTrans = null;
                        decimal? doubleTravel = null;
                        string strNotes = null;
                        dc.ProSelectTransFee(ComboDocNo.SelectedValue.ToString(), ref varDatePay, ref intLocationId,
                            int.Parse(ComboName.SelectedValue.ToString()), ref strDestination, ref strPeriod,
                            ref doubleTrans, ref doubleTravel, ref strNotes);
                        if (varDatePay != null) DatePay.Value = varDatePay.Value;
                        dc.ProGetLocationByID(intLocationId, ref strLocation);
                        ComboLocation.Text = strLocation;
                        TxtDestination.Text = strDestination;
                        TxtPeriod.Text = strPeriod;
                        TxtTrans.Text = doubleTrans.ToString();
                        TxtTravel.Text = doubleTravel.ToString();
                        TxtNotes.Text = strNotes;
                    }
                    else
                    {
                        DatePay.Text = null;
                        ComboLocation.SelectedIndex = -1;
                        TxtDestination.Clear();
                        TxtPeriod.Clear();
                        TxtTrans.Clear();
                        TxtTravel.Clear();
                        TxtNotes.Clear();
                    }
                }
            }
            catch (InvalidOperationException)
            {
                DatePay.Value = DateTime.Now;
                ComboLocation.Text = "";
                TxtDestination.Text = "";
                TxtPeriod.Text = "";
                TxtTrans.Text = "";
                TxtTravel.Text = "";
                TxtNotes.Text = "";
                BtnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormatForm()
        {
            if (string.IsNullOrEmpty(ComboDocNo.Text))
            {
                BtnDelete.Enabled = false;
                BtnDeleteDocument.Enabled = false;
            }
            else
            {
                if (string.IsNullOrEmpty(ComboName.Text))
                {
                    BtnDelete.Enabled = false;
                    BtnDeleteDocument.Enabled = true;
                }
                else
                {
                    BtnDelete.Enabled = true;
                    BtnDeleteDocument.Enabled = true;
                }
            }
            if (ComboDocNo.SelectedIndex == -1 || ComboLocation.SelectedIndex == -1 ||
                ComboName.SelectedIndex == -1 || string.IsNullOrEmpty(TxtDestination.Text) ||
                string.IsNullOrEmpty(TxtPeriod.Text) || TxtTrans.Text == Resources.Zero &&
                TxtTravel.Text == Resources.Zero)
            {
                BtnUpdate.Enabled = false;
            }
            else
            {
                BtnUpdate.Enabled = true;
            }
        }
    }
}