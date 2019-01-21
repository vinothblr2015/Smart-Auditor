using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Auditor.Models;

namespace Auditor
{
    public partial class FrmNewCure : Form
    {
        public FrmNewCure()
        {
            InitializeComponent();
        }

        // Define Class:
        MathOperations Math = new MathOperations();
        //
        //Format the Add button
        public void FormatBtnAdd()
        {
            if (ComboLocation.Text == "" || ComboName.Text == "" || TxtPerson.Text == "" ||TxtAmount.Text == "0" || TxtDocNo.Text == "" || TxtDesc.Text == "")
            {
                BtnAdd.Enabled = false;
            }
            else
            {
                BtnAdd.Enabled = true;
            }
        }
        private void FrmNewCure_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auditorDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.auditorDataSet.Employee);
            // TODO: This line of code loads data into the 'auditorDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.auditorDataSet.Location);
            // Formatting the form:
            ComboLocation.Text = "";
            ComboName.Text = "";
            TxtAmount.Text = "0.00";
            BtnAdd.Enabled = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboLocation_TextChanged(object sender, EventArgs e)
        {
            FormatBtnAdd();
        }

        private void ComboName_TextChanged(object sender, EventArgs e)
        {
            FormatBtnAdd();
        }

        private void TxtAmount_TextChanged(object sender, EventArgs e)
        {
            FormatBtnAdd();
        }

        private void TxtDocNo_TextChanged(object sender, EventArgs e)
        {
            FormatBtnAdd();
        }


        private void TxtDesc_TextChanged(object sender, EventArgs e)
        {
            FormatBtnAdd();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProAddCure(int.Parse(ComboLocation.SelectedValue.ToString()), int.Parse(ComboName.SelectedValue.ToString()), TxtPerson.Text, decimal.Parse(TxtAmount.Text), TxtDocNo.Text, DatePayDate.Value, TxtDesc.Text, TxtNotes.Text);
                    MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FrmNewCure Frm = new FrmNewCure();
                    Frm.Show();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void TxtAmount_Leave(object sender, EventArgs e)
        {
            MathOperations.MoneyFormat(TxtAmount);
        }
    }
}
