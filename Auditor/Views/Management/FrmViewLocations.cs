using System;
using System.Windows.Forms;

namespace Auditor.Views.Management
{
    public partial class FrmViewLocations : Form
    {
        public FrmViewLocations()
        {
            InitializeComponent();
        }

        private void FrmViewLocations_Load(object sender, EventArgs e)
        {
            try
            {
                using (DBAuditDataContext dc = new DBAuditDataContext())
                {
                    dc.ProViewLocations();
                    //GrdViewLocations.DataSource = c;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
