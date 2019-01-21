using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Auditor.Models;
using Auditor.Views.Contractors;
using Auditor.Views.Cure;
using Auditor.Views.Employees;
using Auditor.Views.Locations;
using Auditor.Views.Management;
using Auditor.Views.Projects;
using Auditor.Views.Telepohne;
using Auditor.Views.TemporaryLoan;
using Auditor.Views.TransFee;

namespace Auditor.Views
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            // Get Current user:
            LblCurrentUser.Text = Security.GetCurrentUser();
            // Applying Permisions
            Security sec = new Security();
            // Admin:
            SepManagement.Visible = sec.ApplyPermisions("Admin");
            MenuItemAppSettings.Visible = sec.ApplyPermisions("Admin");
            MenuItemUserGroups.Visible = sec.ApplyPermisions("Admin");
            MenuItemUsers.Visible = sec.ApplyPermisions("Admin");
            MenuItemDatabaseBackup.Visible = sec.ApplyPermisions("Admin");
            MenuItemDatabaseRestore.Visible = sec.ApplyPermisions("Admin");
            // Add:
            MenuItemAddContractor.Enabled = sec.ApplyPermisions("Add");
            MenuItemAddCure.Enabled = sec.ApplyPermisions("Add");
            MenuItemAddCureBill.Enabled = sec.ApplyPermisions("Add");
            MenuItemAddDoctor.Enabled = sec.ApplyPermisions("Add");
            MenuItemAddDurableLoan.Enabled = sec.ApplyPermisions("Add");
            MenuItemAddEmployee.Enabled = sec.ApplyPermisions("Add");
            MenuItemAddLocation.Enabled = sec.ApplyPermisions("Add");
            MenuItemAddPrePay.Enabled = sec.ApplyPermisions("Add");
            MenuItemAddProject.Enabled = sec.ApplyPermisions("Add");
            MenuItemAddTelephone.Enabled = sec.ApplyPermisions("Add");
            MenuItemAddTelNo.Enabled = sec.ApplyPermisions("Add");
            MenuItemAddTempLoan.Enabled = sec.ApplyPermisions("Add");
            MenuItemAddTransfee.Enabled = sec.ApplyPermisions("Add");
            // Edit:
            MenuItemEditContractor.Enabled = sec.ApplyPermisions("Edit");
            MenuItemEditCure.Enabled = sec.ApplyPermisions("Edit");
            MenuItemEditCureBill.Enabled = sec.ApplyPermisions("Edit");
            MenuItemEditDoctor.Enabled = sec.ApplyPermisions("Edit");
            MenuItemEditDurableLoan.Enabled = sec.ApplyPermisions("Edit");
            MenuItemEditEmployee.Enabled = sec.ApplyPermisions("Edit");
            MenuItemEditLocation.Enabled = sec.ApplyPermisions("Edit");
            MenuItemEditPrePay.Enabled = sec.ApplyPermisions("Edit");
            MenuItemEditProject.Enabled = sec.ApplyPermisions("Edit");
            MenuItemEditTelephone.Enabled = sec.ApplyPermisions("Edit");
            MenuItemEditTelNo.Enabled = sec.ApplyPermisions("Edit");
            MenuItemEditTemploan.Enabled = sec.ApplyPermisions("Edit");
            MenuItemEditTransFee.Enabled = sec.ApplyPermisions("Edit");
            // View:
            MenuItemViewContractors.Enabled = sec.ApplyPermisions("View");
            MenuItemViewCure.Enabled = sec.ApplyPermisions("View");
            MenuItemViewCureBills.Enabled = sec.ApplyPermisions("View");
            MenuItemViewDoctors.Enabled = sec.ApplyPermisions("View");
            MenuItemViewDurableLoans.Enabled = sec.ApplyPermisions("View");
            MenuItemViewEmployees.Enabled = sec.ApplyPermisions("View");
            MenuItemViewLocations.Enabled = sec.ApplyPermisions("View");
            MenuItemViewPrePays.Enabled = sec.ApplyPermisions("View");
            MenuItemViewProjects.Enabled = sec.ApplyPermisions("View");
            MenuItemViewTelephones.Enabled = sec.ApplyPermisions("View");
            MenuItemViewTelNo.Enabled = sec.ApplyPermisions("View");
            MenuItemTempLoanReports.Enabled = sec.ApplyPermisions("View");
            MenuItemViewTransFee.Enabled = sec.ApplyPermisions("View");
        }
        private void إضافةمستخلصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmOperation().Show();
        }

        private void إنهاءالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void إضافةدفعمقدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewePrePay().Show();
        }

        private void إضافةمستندToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewTel().Show();
        }

        private void إضافةموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewEmployee().Show();
        }

        private void إضافةجهةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewLocation().Show();
        }

        private void تعديلجهةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModifyLocation().Show();
        }

        private void تعديلبياناتموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModifyEmployee().Show();
        }

        private void إضافةمقاولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewContractor().Show();
        }

        private void تحديثبياناتمقاولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModifyContractor().Show();
        }

        private void إضافةرقمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewTelNo().Show();
        }

        private void تعديلرقمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModifyTelNo().Show();
        }

        private void تعديلمستندToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModifyTel().Show();
        }

        private void حولالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void تعديلبياناتمستخلصToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModifyProject().Show();
        }

        private void إضافةمستندعلاجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewCure().Show();
        }

        private void تعديلبياناتمستندToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmModifyCure().Show();
        }

        private void إضافةطبيبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewDoctor().Show();
        }

        private void تعديلالدفعالمقدمToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void إضافةمستندبدلانتقالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewTransFee().Show();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Security.LogOut();
        }
        private void تعديلبياناتمستندToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModifyTransFee().Show();
        }

        private void عرضمستنداتبدلالانتقالToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmViewTransFees().Show();
        }

        private void عرضالجهاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmViewLocations().Show();
        }

        private void عرضبياناتالمقاولينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmViewContractors().Show();
        }

        private void إضافةسلفةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewTemporaryLoan().Show();
        }

        private void تعديلبياناتسلفةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmModifyTemporaryLoan().Show();
        }

        private void عرضمستنداتالعلاجالفرديToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmViewCures().Show();
        }

        private void عرضالمستخلصاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmViewProjects().Show();
        }
        private void MenuItemAddGroupUser_Click(object sender, EventArgs e)
        {
            new FrmNewUserGroup().Show();
        }

        private void MenuItemAddUser_Click(object sender, EventArgs e)
        {
            new FrmNewUser().Show();
        }

        private void MenuItemEditUser_Click(object sender, EventArgs e)
        {
            new FrmModifyUser().Show();
        }

        private void MenuItemEditMyAccount_Click(object sender, EventArgs e)
        {
            new FrmEditMyAccount().Show();
        }

        private void تسجيلخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MenuItemEditGroupUser_Click(object sender, EventArgs e)
        {
            new FrmModifyUserGroup().Show();
        }

        private void MenuItemViewTelephones_Click(object sender, EventArgs e)
        {
            new FrmViewTel().Show();
        }

        private void إضافةمستندتسويةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNewSettlement().Show();
        }

        private void تعديلبيناتمستندToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModifySettlement().Show();
        }

        private void MenuItemAddCureBill_Click(object sender, EventArgs e)
        {
            new FrmNewDoctorBill().Show();
        }

        private void MenuItemEditCureBill_Click(object sender, EventArgs e)
        {
            new FrmModifyDoctorBill().Show();
        }

        private void MenuItemViewCureBills_Click(object sender, EventArgs e)
        {
            new FrmViewDoctorBills().Show();
        }

        private void تقريرالمقاولينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new FrmRptContractors().Show();
        }

        private void MenuItemAppSettings_Click(object sender, EventArgs e)
        {
            new FrmSystemSettings().Show();
        }

        private void عرضوطباعةبياناتالسلفالمؤقتةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmRptTempLoan().Show();
        }

        private void تقريرالسلفالواجبتسويتهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new FrmRptTempLoanMustSettled().Show();
        }

        private void نسخاحتياطيلقاعدةالبياناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set Backup file for the software database
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Auditor.Properties.Settings.AuditorConnectionString"].ConnectionString);
                SaveFileDialog sf = new SaveFileDialog();
                sf.FileName = con.Database + "-" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;
                sf.Filter = @"Backup Files (*.BAK)|*.bak";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand("BACKUP DATABASE [DBAuditor] TO DISK ='" + sf.FileName + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void استعادةنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Restore database backup
            try
            {
                //connectionString = "Data Source=192.168.1.10;Initial Catalog=DBAuditor;Integrated Security=False;User Id=auditor;Password=123;MultipleActiveResultSets=True";
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Auditor.Properties.Settings.AuditorConnectionString"].ConnectionString);
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = @"Backup Files (*.BAK)|*.bak";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    con.Open();
                    var cmd = new SqlCommand("USE master", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("ALTER DATABASE [DBAuditor] SET Single_User WITH Rollback Immediate", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("RESTORE DATABASE [DBAuditor] FROM DISK ='" + of.FileName + "'WITH REPLACE", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("ALTER DATABASE [DBAuditor] SET Multi_User", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(@"تمت إضافة بيانات السلفة المؤقتة بنجاح", @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"المراجع الذكي", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

