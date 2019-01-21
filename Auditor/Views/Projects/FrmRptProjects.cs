using Auditor.Reports;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Auditor.Views.Projects
{
    public partial class FrmRptProjects : Form
    {
        public FrmRptProjects()
        {
            InitializeComponent();
            ShowReportForAllPorjects();
        }

        private void ShowReportForAllPorjects()
        {
            RptProjectsAll rpt = new RptProjectsAll();
            SqlConnectionStringBuilder con = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["Auditor.Properties.Settings.AuditorConnectionString"].ConnectionString);
            string dataSource = con.DataSource;
            string dbName = con.InitialCatalog;
            string userName = con.UserID;
            string password = con.Password;
            rpt.SetDatabaseLogon(userName, password, dataSource, dbName);
            rptViewerProjects.ReportSource = rpt;
        }
    }
}
