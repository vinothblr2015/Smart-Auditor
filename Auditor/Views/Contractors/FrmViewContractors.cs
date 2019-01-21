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
    public partial class FrmViewContractors : Form
    {
        public FrmViewContractors()
        {
            InitializeComponent();
        }

        private void FrmViewContractors_Load(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    var c = dc.ProViewContractors();
                    GrdViewContractors.DataSource = c;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }
    }
}
