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
    public partial class UserCrtUserManager : UserControl
    {
        public UserCrtUserManager()
        {
            InitializeComponent();
        }
        private void UserCrtRoleUser_Load(object sender, EventArgs e)
        {
            dgvAccount.AutoGenerateColumns = false;
            LoadData();
            DisabledItem();
            dgvAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvAccount.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAccount.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvAccount.DefaultCellStyle.SelectionForeColor = Color.Red;
            dgvAccount.Enabled = true;
            SetColorRowWhenAccStatusIsDelete();
        }
        private void LoadData()
        {
            cbRoleUser.DataSource = DataProvider.Instance.ExcuteQuery("select TenNhom from NhomNguoiDung");
            cbRoleUser.DisplayMember = "TenNhom";
            cbRoleUser.ValueMember = "TenNhom";
            //dgvAccount.DataSource = Account_DAO.Instance.GetListUerAccount("");
            tbSearch.text = "";
        }
        private void DisabledItem()
        {
            btSave.Enabled = false;
            btCancle.Enabled = false;
            btLock.Enabled = false;
            btResetPass.Enabled = false;
            btRestore.Enabled = false;
            tbUserName.Enabled = false;
            tbDisplayName.Enabled = false;
            tbIdCard.Enabled = false;
            tbSex.Enabled = false;
            //cbRoleUser.Enabled = false;
            //DatepickerBirthday.Enabled = false;
            tbUserPhone.Enabled = false;
            tbUserEmail.Enabled = false;
            tbUserAddress.Enabled = false;
            dgvAccount.Enabled = false;
        }
        private void ResetValue()
        {
            tbUserName.Text = "";
            tbDisplayName.Text = "";
            tbIdCard.Text = "";
            tbSex.Text = "";
            cbRoleUser.Text = "";
            DatepickerBirthday.Value = DateTime.Now;
            tbUserPhone.Text = "";
            tbUserEmail.Text = "";
            tbUserAddress.Text = "";
        }
        private void EnabledItem()
        {
            btSave.Enabled = true;
            btCancle.Enabled = true;
            btLock.Enabled = false;
            btResetPass.Enabled = false;
            btRestore.Enabled = false;
            tbUserName.Enabled = true;
            tbDisplayName.Enabled = true;
            tbIdCard.Enabled = true;
            tbSex.Enabled = true;
            //cbRoleUser.Enabled = true;
            //DatepickerBirthday.Enabled = true;
            tbUserPhone.Enabled = true;
            tbUserEmail.Enabled = true;
            tbUserAddress.Enabled = true;
        }
        private static string userName;
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                userName = dgvAccount.Rows[i].Cells[1].Value.ToString();
                tbUserName.Text = dgvAccount.Rows[i].Cells[1].Value.ToString();
                cbRoleUser.Text = dgvAccount.Rows[i].Cells[2].Value.ToString();
                tbDisplayName.Text = dgvAccount.Rows[i].Cells[3].Value.ToString();
                tbIdCard.Text = dgvAccount.Rows[i].Cells[4].Value.ToString();
                tbSex.Text = dgvAccount.Rows[i].Cells[5].Value.ToString();
                DatepickerBirthday.Value = Convert.ToDateTime(dgvAccount.Rows[i].Cells[6].Value);
                tbUserPhone.Text = dgvAccount.Rows[i].Cells[7].Value.ToString();
                tbUserEmail.Text = dgvAccount.Rows[i].Cells[8].Value.ToString();
                tbUserAddress.Text = dgvAccount.Rows[i].Cells[9].Value.ToString();

                UserAccount acc = Account_DAO.Instance.GetUserAccount(userName);
                if (acc.UserName.IndexOf('_') == -1 || acc.UserName == FrmLogin.username)
                {
                    btLock.Enabled = false;
                    btRestore.Enabled = false;
                }
                else
                {
                    if (acc.UserStatus == "Bị khóa")
                    {
                        btLock.Enabled = false;
                        btRestore.Enabled = true;
                    }
                    else
                    {
                        btLock.Enabled = true;
                        btRestore.Enabled = false;
                    }
                }
            }
            catch { }
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            btNew.Enabled = false;
            EnabledItem();
            ResetValue();
            dgvAccount.Enabled = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DisabledItem();
            ResetValue();
            btNew.Enabled = true;
            dgvAccount.Enabled = true;
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            DisabledItem();
            ResetValue();
            btNew.Enabled = true;
            dgvAccount.Enabled = true;
        }

        private void dgvAccount_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvAccount.Rows.Count; i++)
            {
                dgvAccount.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            dgvAccount.DataSource = Account_DAO.Instance.GetListUerAccount(tbSearch.text);
            SetColorRowWhenAccStatusIsDelete(); 
        }
        private void SetColorRowWhenAccStatusIsDelete()
        {
            try
            {
                for (int i = 0; i < dgvAccount.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvAccount.Rows[i];

                    if (dgvAccount.Rows[i].Cells[10].Value.ToString() == "Bị khóa")
                    {
                        dgvAccount.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
            catch { }
        }
        private void btLock_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn khóa tài khoản "+userName+" ?","Thông báo!",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Account_DAO.Instance.LockUser(userName)) LoadData();
            }
        }

        private void btRestore_Click(object sender, EventArgs e)
        {
            if (Account_DAO.Instance.UnLockUser(userName))
            {
                MessageBox.Show("Khôi phục tài khoản " + userName + " thành công", "Thông báo!"); LoadData();
            }
        }

        private void btResetPass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đặt lại mật khẩu cho tài khoản " + userName + " ?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Account_DAO.Instance.ResetPassByAdmin(userName))
                {
                    MessageBox.Show("Đặt lại mật khẩu cho tài khoản " + userName + " thành công", "Thông báo!");
                    LoadData();
                }
            }
        }

        private void cbRoleUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColorRowWhenAccStatusIsDelete();
        }
    }
}
