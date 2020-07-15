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
            panelCategory.Height = 0;
            panelReports.Height = 0;
            panelUserManager.Height = 0;
            panelInventory.Height = 0;
            string UserName = FrmLogin.username;
            toolStripStatusLabelUserName.Text = UserName;
            //DataProvider.Instance.ExcuteNunQuery("exec DropTable");
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
            btImportFromSupplier.Visible = false; 
            btInventory.Visible = false; 
            btImportInventory.Visible = false; 
            btCategoryProduct.Visible = false; 
            btCategorySupplier.Visible = false; 
            btCustomerManager.Visible = false; 
            btSupplierManager.Visible = false; 
            btProductManager.Visible = false; 
            btUserManagerment.Visible = false; 
            btRoleUserManager.Visible = false; 
            btReportSell.Visible = false; 
            btReportBuy.Visible = false; 
            btReportImportInventory.Visible = false; 
            btReportSendMail.Visible = false; 
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
                    if (!Role.CheckImportFromSupplier) { btImportFromSupplier.Visible = false;}
                    if (!Role.CheckInventory) { btInventory.Visible = false;}
                    if (!Role.CheckImportInventory) { btImportInventory.Visible = false;}
                    if (!Role.CheckCategoryProduct) { btCategoryProduct.Visible = false;}
                    if (!Role.CheckCategorySupplier) { btCategorySupplier.Visible = false;}
                    if (!Role.CheckCustomer) { btCustomerManager.Visible = false;}
                    if (!Role.CheckSupplier) { btSupplierManager.Visible = false;}
                    if (!Role.CheckProduct) { btProductManager.Visible = false;}
                    if (!Role.CheckUsers) { btUserManagerment.Visible = false;}
                    if (!Role.CheckRoleUser) { btRoleUserManager.Visible = false;}
                    if (!Role.CheckReportSell) { btReportSell.Visible = false;}
                    if (!Role.CheckReportBuy) { btReportBuy.Visible = false;}
                    if (!Role.CheckReportImportInventory) { btReportImportInventory.Visible = false;}
                    if (!Role.CheckReportSendMail) { btReportSendMail.Visible = false;}
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
        private void LoadUserCtr(UserControl f)
        {
            this.pannelLoad.Controls.Clear();
            this.pannelLoad.Controls.Add(f);
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
                //timer1.Enabled = true; 1 6 7 9
                panel1.Width = 15;
                panel6.Width = 15;
                panel7.Width = 15;
                panel9.Width = 15;
            }
            else
            {
                PanelMenu.Width = 200;
                PanelRight.Width = 0;
                panel1.Width = 46;
                panel6.Width = 46;
                panel7.Width = 46;
                panel9.Width = 46;
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
            //DataProvider.Instance.ExcuteNunQuery("exec DropTable");
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
            //AddForm(new FrmWarehouseManager());
            panelCategory.Height = 0;
            panelReports.Height = 0;
            panelUserManager.Height = 0;
            //panelInventory.Height = 0;
            if (panelInventory.Height == 0)
            {
                panelInventory.Height = 141;
            }
            else
            {
                panelInventory.Height = 0;
            }
        }
        private void GetFrmWarehouseManager()
        {
            AddForm(new FrmImportFromSupplier());
        }
        private void btCategory_Click(object sender, EventArgs e)
        {
            //AddForm(new FrmCategory(GetFrmWarehouseManager));
            //panelCategory.Height = 0;
            panelReports.Height = 0;
            panelUserManager.Height = 0;
            panelInventory.Height = 0;
            if (panelCategory.Height == 0)
            {
                panelCategory.Height = 205;
            }
            else
            {
                panelCategory.Height = 0;
            }
        }

        private void btEnterpriseInfo_Click(object sender, EventArgs e)
        {
            AddForm(new FrmEnterpriseInfo(AddForm));
        }

        private void btUserManager_Click(object sender, EventArgs e)
        {
            //AddForm(new FrmUserManager());
            panelCategory.Height = 0;
            panelReports.Height = 0;
            //panelUserManager.Height = 0;
            panelInventory.Height = 0;
            if (panelUserManager.Height == 0)
            {
                panelUserManager.Height = 82;
            }
            else
            {
                panelUserManager.Height = 0;
            }
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            //AddForm(new FrmReports());
            panelCategory.Height = 0;
            //panelReports.Height = 0;
            panelUserManager.Height = 0;
            panelInventory.Height = 0;
            if (panelReports.Height == 0)
            {
                panelReports.Height = 164;
            }
            else
            {
                panelReports.Height = 0;
            }
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

        private void btImportFromSupplier_Click(object sender, EventArgs e)
        {
            AddForm(new FrmImportFromSupplier());
        }

        private void btInventory_Click(object sender, EventArgs e)
        {
            AddForm(new FrmInventory());
        }

        private void btCategoryProduct_Click(object sender, EventArgs e)
        {
            AddForm(new FrmCategoryProduct());
        }

        private void btCategorySupplier_Click(object sender, EventArgs e)
        {
            AddForm(new FrmCategorySupplier());
        }

        private void btCustomerManager_Click(object sender, EventArgs e)
        {
            AddForm(new FrmCustomer());
        }

        private void btSupplierManager_Click(object sender, EventArgs e)
        {
            AddForm(new FrmSupplier());
        }

        private void btProductManager_Click(object sender, EventArgs e)
        {
            AddForm(new FrmProduct(GetFrmWarehouseManager));
        }

        private void btUserManagerment_Click(object sender, EventArgs e)
        {
            AddForm(new FrmAccountManager());
        }

        private void btRoleUserManager_Click(object sender, EventArgs e)
        {
            LoadUserCtr(new UserCrtRoleUserManager());
        }

        private void btReportSell_Click(object sender, EventArgs e)
        {
            LoadUserCtr(new UserCrtReportSell());
        }

        private void btReportBuy_Click(object sender, EventArgs e)
        {
            LoadUserCtr(new UserCrtReportBuy());
        }

        private void btReportImportInventory_Click(object sender, EventArgs e)
        {
            LoadUserCtr(new UserCrtReportImportInventory());
        }

        private void btReportSendMail_Click(object sender, EventArgs e)
        {
            LoadUserCtr(new UserCrtReportMailDelivery());
        }

        private void btImportInventory_Click(object sender, EventArgs e)
        {
            AddForm(new FrmImportInventory());
        }
    }
}