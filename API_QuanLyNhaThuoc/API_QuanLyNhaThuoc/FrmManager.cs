using API_QuanLyNhaThuoc.DAO;
using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_QuanLyNhaThuoc
{
    public delegate void Logout();
    public partial class FrmManager : Form
    {
        private Logout logout;
        public FrmManager()
        {
            InitializeComponent();
        }
        public FrmManager(Logout log)
        {
            InitializeComponent();
            logout = log;
        }
        private void LogOut()
        {
            logout();
            this.Close();
        }
        private void FrmManager_Load(object sender, EventArgs e)
        {
            PanelRight.Width = 0;
            string UserName = FrmLogin.username;
            toolStripStatusLabelUserName.Text = UserName;
            DataProvider.Instance.ExcuteNunQuery("exec DropTable");
            AddForm(new FrmOverviews());
            CheckRoleUser(UserName);
        }
        private void DisanleItem()
        {
            btCreateInvoice.Visible = false;
            btInvoiceManagement.Visible = false;
            btWarehouseManager.Visible = false;
            btCategory.Visible = false;
            btEnterpriseInfo.Visible = false;
            btUserManager.Visible = false;
            btReport.Visible = false;
            btSettings.Visible = false;
        }
        private void CheckRoleUser(string user)
        {
            try
            {
                RoleUserManager Role = RoleUserManager_DAO.Instance.CheckRoleUserByUserName(user);
                if(Role.Status == "Hoạt động")
                {
                    if (!Role.CheckCreateInvoice) { btCreateInvoice.Visible = false; }
                    if (!Role.CheckInvoiceManager) { btInvoiceManagement.Visible = false; }
                    if (!Role.CheckWarehouseManager) { btWarehouseManager.Visible = false; }
                    if (!Role.CheckCategory) { btCategory.Visible = false; }
                    if (!Role.CheckEnterpriseInfo) { btEnterpriseInfo.Visible = false; }
                    if (!Role.CheckUserManager) { btUserManager.Visible = false; }
                    if (!Role.CheckReport) { btReport.Visible = false; }
                    if (!Role.CheckSettings) { btSettings.Visible = false; }
                }
                else
                {
                    DisanleItem();
                }
            }
            catch { DisanleItem(); }
        }
        private void AddForm(Form f)
        {
            this.pannelLoad.Controls.Clear();
            f.TopLevel = false;
            this.pannelLoad.Controls.Add(f);
            f.Show();
        }
        #region evenButonClick
        private void btExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            LogOut();
        }

        private void toolStripMenuItemLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 200)
            {
                PanelMenu.Width = 63;
                PanelRight.Width = 137;
                //timer1.Enabled = true;
            }
            else
            {
                PanelMenu.Width = 200;
                PanelRight.Width = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (PanelMenu.Width <= 63) timer1.Enabled = false;
            //label1.Text = (PanelMenu.Width - 1).ToString();
            //PanelMenu.Width = PanelMenu.Width - 1;//63;
            //PanelRight.Width = 137;
        }
        private void btOverviews_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNunQuery("exec DropTable");
            AddForm(new FrmOverviews());
        }

        private void btCreateInvoice_Click(object sender, EventArgs e)
        {
            AddForm(new FrmCreateInvoice());
        }

        private void btInvoiceManagement_Click(object sender, EventArgs e)
        {
            AddForm(new FrmInvoiceManagement());
        }

        private void btWarehouseManager_Click(object sender, EventArgs e)
        {
            AddForm(new FrmWarehouseManager());
        }
        private void GetFrmWarehouseManager()
        {
            AddForm(new FrmWarehouseManager());
        }
        private void btCategory_Click(object sender, EventArgs e)
        {
            AddForm(new FrmCategory(GetFrmWarehouseManager));
        }

        private void btEnterpriseInfo_Click(object sender, EventArgs e)
        {
            AddForm(new FrmEnterpriseInfo(AddForm));
        }

        private void btUserManager_Click(object sender, EventArgs e)
        {
            AddForm(new FrmUserManager());
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            AddForm(new FrmReports());
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            AddForm(new FrmSettings());
        }

        private void toolStripMenuItemChangePass_Click(object sender, EventArgs e)
        {
            FrmUserChangePass f = new FrmUserChangePass(LogOut);
            f.ShowDialog();
        }

        private void toolStripMenuItemUserInfo_Click(object sender, EventArgs e)
        {
            FrmUserInfo f = new FrmUserInfo();
            f.ShowDialog();
        }
        #endregion

        private void FrmManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogOut();
        }
    }
}