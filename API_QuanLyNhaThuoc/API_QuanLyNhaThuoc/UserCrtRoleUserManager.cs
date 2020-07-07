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

                if (id == "ADMIN" || id == "DEFAULT") { btRestore.Enabled = false; btLock.Enabled = false; }
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
            string roleName = tbRoleName.Text.Trim().ToUpper();
            byte checkCreateInvoice;
            byte checkInvoiceManager;
            byte checkWarehouseManager;
            byte checkCategory;
            byte checkEnterpriseInfo;
            byte checkUserManager;
            byte checkReport;
            byte checkSettings;
            if (checkBoxCreateInvoice.Checked == false) checkCreateInvoice = 0;
            else checkCreateInvoice = 1;
            if (checkBoxInvoiceManager.Checked == false) checkInvoiceManager = 0;
            else checkInvoiceManager = 1;
            if (checkBoxWarehouseManager.Checked == false) checkWarehouseManager = 0;
            else checkWarehouseManager = 1;
            if (checkBoxCategory.Checked == false) checkCategory = 0;
            else checkCategory = 1;
            if (checkBoxEnterpriseInfo.Checked == false) checkEnterpriseInfo = 0;
            else checkEnterpriseInfo = 1;
            if (checkBoxUserManager.Checked == false) checkUserManager = 0;
            else checkUserManager = 1;
            if (checkBoxReport.Checked == false) checkReport = 0;
            else checkReport = 1;
            if (checkBoxSettings.Checked == false) checkSettings = 0;
            else checkSettings = 1;
            if (tbRoleName.Enabled == true)
            {
                if (roleName == null || roleName == "")
                {
                    MessageBox.Show("Tên nhóm không được để trống!", "Thông báo!");
                }
                else
                {
                    if (RoleUserManager_DAO.Instance.InsertRoleUser(roleName, tbDescription.Text, checkCreateInvoice, checkInvoiceManager, checkWarehouseManager, checkCategory, checkEnterpriseInfo, checkUserManager, checkReport, checkSettings))
                    {
                        LoadData();
                        btNew.Enabled = true;
                        dgvRoleUser.Enabled = true;

                        MessageBox.Show("Thêm nhóm " + roleName + " thành công!", "Thông báo!");
                    }
                    else { MessageBox.Show("Thêm thất bại do tên nhóm " + roleName + " đã tồn tại!", "Thông báo!"); }
                }
            }
            else
            {
                if (RoleUserManager_DAO.Instance.UpdateRoleUser(roleName, tbDescription.Text, checkCreateInvoice, checkInvoiceManager, checkWarehouseManager, checkCategory, checkEnterpriseInfo, checkUserManager, checkReport, checkSettings))
                {
                    LoadData();
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
            btEdit.Enabled = true;
            btLock.Enabled = true;
            btRestore.Enabled = true;
            dgvRoleUser.Enabled = true;
        }
        private bool CheckRoleByUsername(string user,string rolename)
        {
            return DataProvider.Instance.ExcuteScalar("select NhomNguoiDung from NHANVIEN where USERNAME=" + user).ToString() == rolename;
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
                }
            }
        }
        private void btRestore_Click(object sender, EventArgs e)
        {
            if (RoleUserManager_DAO.Instance.UnLockRoleUser(tbRoleName.Text, status))
                MessageBox.Show("Khôi phục nhóm " + tbRoleName.Text + " thành công!", "Thông báo!");
            LoadData();
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
    }
}
