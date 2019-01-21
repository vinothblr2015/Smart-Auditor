using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Auditor.Views.TemporaryLoan
{
    public partial class FrmRptTempLoan : Form
    {
        public FrmRptTempLoan()
        {
            InitializeComponent();
            ShowReportForAllTemporaryLoans();
        }

        private void ShowReportForAllTemporaryLoans()
        {
            Reports.RptTempLoans rpt = new Reports.RptTempLoans();
            SqlConnectionStringBuilder con = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["Auditor.Properties.Settings.AuditorConnectionString"].ConnectionString);
            string dataSource = con.DataSource;
            string dbName = con.InitialCatalog;
            string userName = con.UserID;
            string password = con.Password;
            rpt.SetDatabaseLogon(userName, password, dataSource, dbName);
            RptViewerTempLoans.ReportSource = rpt;
        }
    }
}
