using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_QuanLyNhaThuoc.DAO;
using API_QuanLyNhaThuoc.DTO;

namespace API_QuanLyNhaThuoc
{
    public partial class UserCrtRoleUserManager : UserControl
    {
        public UserCrtRoleUserManager()
        {
            InitializeComponent();
        }

        private void UserCrtRoleUserManager_Load(object sender, EventArgs e)
        {
            dgvRoleUser.AutoGenerateColumns = false;
            tbStatus.Enabled = false;
            LoadData();
            dgvRoleUser.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvRoleUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRoleUser.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvRoleUser.DefaultCellStyle.SelectionForeColor = Color.Red;
        }
        private void LoadData()
        {
            //dgvRoleUser.DataSource = RoleUserManager_DAO.Instance.LoadListRoleUserManager("");
            ClearData();
            DisableItem();
        }
        private void ClearData()
        {
            checkBoxCreateInvoice.Checked = false;
            checkBoxInvoiceManager.Checked = false;
            checkBoxWarehouseManager.Checked = false;
            checkBoxCategory.Checked = false;
            checkBoxEnterpriseInfo.Checked = false;
            checkBoxUserManager.Checked = false;
            checkBoxReport.Checked = false;
            checkBoxSettings.Checked = false;

            tbRoleName.Text = "";
            tbDescription.Text = "";
            tbStatus.Text = "";
        }
        private void dgvRoleUser_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvRoleUser.Rows.Count; i++)
            {
                dgvRoleUser.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void DisableItem()
        {
            panelCheckBox.Enabled = false;
            tbRoleName.Enabled = false;
            tbDescription.Enabled = false;
            btCancle.Enabled = false;
            btSave.Enabled = false;
            btEdit.Enabled = false;
            btLock.Enabled = false;
            btRestore.Enabled = false;
        }
        private void EnableItem()
        {
            panelCheckBox.Enabled = true;
            tbRoleName.Enabled = true;
            tbDescription.Enabled = true;
            btSave.Enabled = true;
            btCancle.Enabled = true;
        }
        private void SetColorRowWhenAccStatusIsDelete()
        {
            try
            {
                for (int i = 0; i < dgvRoleUser.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvRoleUser.Rows[i];

                    if (dgvRoleUser.Rows[i].Cells[4].Value.ToString() == "Bị khóa")
                    {
                        dgvRoleUser.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            catch { }
        }

        private byte status = 0;
        private void dgvRoleUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UserAccount acc = Account_DAO.Instance.GetUserAccount(FrmLogin.username);
            int i = e.RowIndex;
            try
            {
                tbRoleName.Text = dgvRoleUser.Rows[i].Cells[1].Value.ToString();
                tbDescription.Text = dgvRoleUser.Rows[i].Cells[2].Value.ToString();
                tbStatus.Text = dgvRoleUser.Rows[i].Cells[4].Value.ToString();
                string id = dgvRoleUser.Rows[i].Cells[1].Value.ToString();
                RoleUserManager Role = RoleUserManager_DAO.Instance.CheckRoleUserByRoleName(id);
                if (Role.CheckCreateInvoice) checkBoxCreateInvoice.Checked = true;
                else checkBoxCreateInvoice.Checked = false;
                if (Role.CheckInvoiceManager) checkBoxInvoiceManager.Checked = true;
                else checkBoxInvoiceManager.Checked = false;
                if (Role.CheckWarehouseManager) checkBoxWarehouseManager.Checked = true;
                else checkBoxWarehouseManager.Checked = false;
                if (Role.CheckCategory) checkBoxCategory.Checked = true;
                else checkBoxCategory.Checked = false;
                if (Role.CheckEnterpriseInfo) checkBoxEnterpriseInfo.Checked = true;
                else checkBoxEnterpriseInfo.Checked = false;
                if (Role.CheckUserManager) checkBoxUserManager.Checked = true;
                else checkBoxUserManager.Checked = false;
                if (Role.CheckReport) checkBoxReport.Checked = true;
                else checkBoxReport.Checked = false;
                if (Role.CheckSettings) checkBoxSettings.Checked = true;
                else checkBoxSettings.Checked = false;

                checkBoxImportFromSupplier.Checked = Role.CheckImportFromSupplier;
                checkBoxInventory.Checked = Role.CheckInventory;
                checkBoxImportInventory.Checked = Role.CheckImportInventory;

                checkBoxCategoryProduct.Checked = Role.CheckCategoryProduct;
                checkBoxCategorySupplier.Checked = Role.CheckCategorySupplier;
                checkBoxCustomer.Checked = Role.CheckCustomer;
                checkBoxSupplier.Checked = Role.CheckSupplier;
                checkBoxProduct.Checked = Role.CheckProduct;

                checkBoxUsers.Checked = Role.CheckUsers;
                checkBoxRoleUser.Checked = Role.CheckRoleUser;

                checkBoxReportSell.Checked = Role.CheckReportSell;
                checkBoxReportBuy.Checked = Role.CheckReportBuy;
                checkBoxReportImportInventory.Checked = Role.CheckReportImportInventory;
                checkBoxReportSendMail.Checked = Role.CheckReportSendMail;

                if (id == "ADMIN" || id == "DEFAULT" || id == acc.RoleUser) { btRestore.Enabled = false; btLock.Enabled = false; }
                else
                {
                    if (Role.Status == "Hoạt động") { btRestore.Enabled = false; btLock.Enabled = true; status = 1; }
                    else { btRestore.Enabled = true; btLock.Enabled = false; status = 0; }
                }
                btEdit.Enabled = true;
            }
            catch { }
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            ClearData();
            EnableItem();
            tbStatus.Text = "Hoạt động";
            btNew.Enabled = false;
            btEdit.Enabled = false;
            btLock.Enabled = false;
            btRestore.Enabled = false;
            dgvRoleUser.Enabled = false;
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            btSave.Enabled = true;
            btCancle.Enabled = true;
            btNew.Enabled = false;
            btEdit.Enabled = false;
            btLock.Enabled = false;
            btRestore.Enabled = false;
            dgvRoleUser.Enabled = false;
            tbDescription.Enabled = true;
            if (tbRoleName.Text == "ADMIN" || tbRoleName.Text == "DEFAULT")
                panelCheckBox.Enabled = false;
            else panelCheckBox.Enabled = true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            string roleName = tbRoleName.Text.Trim().ToUpper().Replace(" ","");
            bool checkCreateInvoice = checkBoxCreateInvoice.Checked;
            bool checkInvoiceManager = checkBoxInvoiceManager.Checked;
            bool checkWarehouseManager = checkBoxWarehouseManager.Checked;
            bool checkCategory = checkBoxCategory.Checked;
            bool checkEnterpriseInfo = checkBoxEnterpriseInfo.Checked;
            bool checkUserManager = checkBoxUserManager.Checked;
            bool checkReport = checkBoxReport.Checked;
            bool checkSettings = checkBoxSettings.Checked;
            bool checkImportFromSupplier = checkBoxImportFromSupplier.Checked;
            bool checkInventory = checkBoxInventory.Checked;
            bool checkImportInventory = checkBoxImportInventory.Checked;
            bool checkCategoryProduct = checkBoxCategoryProduct.Checked;
            bool checkCategorySupplier = checkBoxCategorySupplier.Checked;
            bool checkCustomer = checkBoxCustomer.Checked;
            bool checkSupplier = checkBoxSupplier.Checked;
            bool checkProduct = checkBoxProduct.Checked;
            bool checkUsers = checkBoxUsers.Checked;
            bool checkRoleUser = checkBoxRoleUser.Checked;
            bool checkReportSell = checkBoxReportSell.Checked;
            bool checkReportBuy = checkBoxReportBuy.Checked;
            bool checkReportImportInventory = checkBoxReportImportInventory.Checked;
            bool checkReportSendMail = checkBoxReportSendMail.Checked;

            if (tbRoleName.Enabled == true)
            {
                if (roleName == null || roleName == "")
                {
                    MessageBox.Show("Tên nhóm không được để trống!", "Thông báo!");
                }
                else
                {
                    if (RoleUserManager_DAO.Instance.InsertRoleUser(roleName, tbDescription.Text, checkCreateInvoice, checkInvoiceManager, checkWarehouseManager, checkCategory, checkEnterpriseInfo, checkUserManager, checkReport, checkSettings, checkImportFromSupplier, checkInventory, checkImportInventory, checkCategoryProduct, checkCategorySupplier, checkCustomer, checkSupplier, checkProduct, checkUsers, checkRoleUser, checkReportSell, checkReportBuy, checkReportImportInventory, checkReportSendMail))
                    {
                        LoadData();
                        dgvRoleUser.DataSource = RoleUserManager_DAO.Instance.LoadListRoleUserManager(tbSearch.text);
                        SetColorRowWhenAccStatusIsDelete();
                        btNew.Enabled = true;
                        dgvRoleUser.Enabled = true;

                        MessageBox.Show("Thêm nhóm " + roleName + " thành công!", "Thông báo!");
                    }
                    else { MessageBox.Show("Thêm thất bại do tên nhóm " + roleName + " đã tồn tại!", "Thông báo!"); }
                }
            }
            else
            {
                if (RoleUserManager_DAO.Instance.UpdateRoleUser(roleName, tbDescription.Text, checkCreateInvoice, checkInvoiceManager, checkWarehouseManager, checkCategory, checkEnterpriseInfo, checkUserManager, checkReport, checkSettings, checkImportFromSupplier, checkInventory, checkImportInventory, checkCategoryProduct, checkCategorySupplier, checkCustomer, checkSupplier, checkProduct, checkUsers, checkRoleUser, checkReportSell, checkReportBuy, checkReportImportInventory, checkReportSendMail))
                {
                    LoadData();
                    dgvRoleUser.DataSource = RoleUserManager_DAO.Instance.LoadListRoleUserManager(tbSearch.text);
                    SetColorRowWhenAccStatusIsDelete();
                    btEdit.Enabled = true;
                    btNew.Enabled = true;
                    dgvRoleUser.Enabled = true;
                    MessageBox.Show("Cập nhật nhóm " + roleName + " thành công!", "Thông báo!");
                }
                else { MessageBox.Show("Có lỗi gì đó xãy ra. Vui lòng thử lại sau ít phút.", "Thông báo!"); }
            }
        }
        private void btCancle_Click(object sender, EventArgs e)
        {
            ClearData();
            DisableItem();
            btNew.Enabled = true;
            btEdit.Enabled = false;
            btLock.Enabled = false;
            btRestore.Enabled = false;
            dgvRoleUser.Enabled = true;
        }
        private bool CheckRoleByUsername(string user,string rolename)
        {
            return DataProvider.Instance.ExcuteScalar("select NhomNguoiDung from NHANVIEN where USERNAME=N'" + user+"'").ToString() == rolename;
        }
        private void btLock_Click(object sender, EventArgs e)
        {
            if (CheckRoleByUsername(FrmLogin.username, tbRoleName.Text))
            {
                MessageBox.Show("Không thể thực hiện do tài khoản của bạn đang sử dụng nhóm quyền này!", "Thông báo!");
            }
            else
            {
                if (MessageBox.Show("Khóa nhóm người dùng sẽ ảnh hưởng đến những tài khoản đang sử dụng quyền này.\nBạn có chắc muốn thực hiện?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (RoleUserManager_DAO.Instance.LockRoleUser(tbRoleName.Text, status))
                        MessageBox.Show("Khóa nhóm " + tbRoleName.Text + " thành công!", "Thông báo!");
                    LoadData();
                    dgvRoleUser.DataSource = RoleUserManager_DAO.Instance.LoadListRoleUserManager(tbSearch.text);
                    SetColorRowWhenAccStatusIsDelete();
                }
            }
        }
        private void btRestore_Click(object sender, EventArgs e)
        {
            if (RoleUserManager_DAO.Instance.UnLockRoleUser(tbRoleName.Text, status))
                MessageBox.Show("Khôi phục nhóm " + tbRoleName.Text + " thành công!", "Thông báo!");
            LoadData();
            dgvRoleUser.DataSource = RoleUserManager_DAO.Instance.LoadListRoleUserManager(tbSearch.text);
            SetColorRowWhenAccStatusIsDelete();
        }
        private void tbRoleName_OnValueChanged(object sender, EventArgs e)
        {
            if (tbRoleName.Text == "ADMIN" || tbRoleName.Text == "DEFAULT")
            {
                panelCheckBox.Enabled = false;
                tbDescription.Enabled = false;
            }
        }
        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            dgvRoleUser.DataSource = RoleUserManager_DAO.Instance.LoadListRoleUserManager(tbSearch.text);
            SetColorRowWhenAccStatusIsDelete();
        }
        private void tbSearch_Enter(object sender, EventArgs e)
        {
            dgvRoleUser.DataSource = RoleUserManager_DAO.Instance.LoadListRoleUserManager(tbSearch.text);
            SetColorRowWhenAccStatusIsDelete();
        }

        private void checkBoxReport_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxReport.Checked)
            {
                checkBoxReportSell.Checked = true;
                checkBoxReportBuy.Checked = true;
                checkBoxReportImportInventory.Checked = true;
                checkBoxReportSendMail.Checked = true;
            }
            else
            {
                checkBoxReportSell.Checked = false;
                checkBoxReportBuy.Checked = false;
                checkBoxReportImportInventory.Checked = false;
                checkBoxReportSendMail.Checked = false;
            }
        }

        private void checkBoxUserManager_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUserManager.Checked)
            {
                checkBoxUsers.Checked = true;
                checkBoxRoleUser.Checked = true;
            }
            else
            {
                checkBoxUsers.Checked = false;
                checkBoxRoleUser.Checked = false;
            }
        }

        private void checkBoxCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCategory.Checked)
            {
                checkBoxCategoryProduct.Checked = true;
                checkBoxCategorySupplier.Checked = true;
                checkBoxCustomer.Checked = true;
                checkBoxSupplier.Checked = true;
                checkBoxProduct.Checked = true;
            }
            else
            {
                checkBoxCategoryProduct.Checked = false;
                checkBoxCategorySupplier.Checked = false;
                checkBoxCustomer.Checked = false;
                checkBoxSupplier.Checked = false;
                checkBoxProduct.Checked = false;
            }
        }

        private void checkBoxWarehouseManager_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWarehouseManager.Checked)
            {
                checkBoxImportFromSupplier.Checked = true;
                checkBoxInventory.Checked = true;
                checkBoxImportInventory.Checked = true;
            }
            else
            {
                checkBoxImportFromSupplier.Checked = false;
                checkBoxInventory.Checked = false;
                checkBoxImportInventory.Checked = false;
            }
        }
    }
}
