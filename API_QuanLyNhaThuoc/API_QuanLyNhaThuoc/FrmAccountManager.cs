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
    public partial class FrmAccountManager : Form
    {
        public FrmAccountManager()
        {
            InitializeComponent();
        }

        private void FrmAccountManager_Load(object sender, EventArgs e)
        {
            dgvAccount.AutoGenerateColumns = false;
            LoadData();
            DisabledItem();
            dgvAccount.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvAccount.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAccount.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvAccount.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAccount.Enabled = true;
            cbRoleUser.Text = "";
            //dgvAccount.DataSource = Account_DAO.Instance.GetListUerAccount("");
            //this.tbSearch.Enter += new System.EventHandler(tbSearch_Enter);
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
            btRestore.Enabled = false;
            btResetPass.Enabled = false;
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
            dgvAccount.DataSource = Account_DAO.Instance.GetListUerAccount("");
            SetColorRowWhenAccStatusIsDelete();
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
                //cbRoleUser.Text = dgvAccount.Rows[i].Cells[2].Value.ToString();
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
                    btResetPass.Enabled = false;
                    cbRoleUser.Enabled = false;
                }
                else
                {
                    cbRoleUser.Enabled = true;
                    btResetPass.Enabled = true;
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
                SetColorRowWhenAccStatusIsDelete();
            }
            catch {  }
        }
        private void dgvAccount_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvAccount.Rows.Count; i++)
            {
                dgvAccount.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            btNew.Enabled = false;
            EnabledItem();
            ResetValue();
            dgvAccount.Enabled = false;
            btResetPass.Enabled = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string user = tbUserName.Text.Trim().ToLower();
            string name = tbDisplayName.Text;
            string idCard = tbIdCard.Text;
            string gender = tbSex.Text;
            string role = cbRoleUser.Text;
            DateTime birthday = DatepickerBirthday.Value;
            string phone = tbUserPhone.Text;
            string email = tbUserEmail.Text;
            string address = tbUserAddress.Text;
            string pass = Account_DAO.Instance.Encrypt("1");

            if(btNew.Enabled == false && tbUserName.Enabled == true)
            {
                if (tbUserName.Text == "" || tbDisplayName.Text == "" || tbIdCard.Text == "" || cbRoleUser.Text == "" || tbUserEmail.Text == "")
                {
                    MessageBox.Show("Những trường bắt buộc không được để trống!", "Thông báo!");
                }
                else
                {
                    if (Email_DAO.Instance.isEmail(tbUserEmail.Text))
                    {
                        if (Account_DAO.Instance.InsertAccount(user, pass, role, name, idCard, gender, birthday, phone, email, address))
                        {
                            DisabledItem();
                            ResetValue();
                            btNew.Enabled = true;
                            dgvAccount.Enabled = true;
                            btResetPass.Enabled = false;
                            btLock.Enabled = false;
                            btRestore.Enabled = false;
                            MessageBox.Show("Thêm mới tài khoản " + Account_DAO.Instance.CheckUsername() + "_" + user + " thành công !", "Thông báo!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm tài khoản thất bại do tên đăng nhập đã tồn tại!", "Thông báo!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email không đúng định dạng!", "Thông báo!");
                    }
                }
            }
            else
            {
                if(tbUserName.Text != "" && tbUserName.Enabled == false)
                {
                    if(cbRoleUser.SelectedValue.ToString() == cbRoleUser.Text)
                    {
                        if (Account_DAO.Instance.UpdateRoleForUser(user, cbRoleUser.SelectedValue.ToString()))
                        {
                            btCancle.Enabled = false;
                            btSave.Enabled = false;
                            dgvAccount.Enabled = true;
                            btResetPass.Enabled = false;
                            btLock.Enabled = false;
                            btRestore.Enabled = false;
                            MessageBox.Show("Cập nhật quyền thành công!", "Thông báo!");
                            ResetValue();
                        }
                    }
                    else { MessageBox.Show("Nhóm người dùng không hợp lệ!", "Thông báo!"); }
                }
            }
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            DisabledItem();
            ResetValue();
            btNew.Enabled = true;
            dgvAccount.Enabled = true;
            btResetPass.Enabled = false;
        }
        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            dgvAccount.DataSource = Account_DAO.Instance.GetListUerAccount(tbSearch.text);
            SetColorRowWhenAccStatusIsDelete();
        }
        private void tbSearch_Enter(object sender, EventArgs e)
        {
            dgvAccount.DataSource = Account_DAO.Instance.GetListUerAccount(tbSearch.text);
            SetColorRowWhenAccStatusIsDelete();
        }
        private void tbSearch_MouseClick(object sender, MouseEventArgs e)
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
            if (MessageBox.Show("Bạn có chắc muốn khóa tài khoản " + userName + " ?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Account_DAO.Instance.LockUser(userName)) ResetValue();
            }
        }
        private void btRestore_Click(object sender, EventArgs e)
        {
            if (Account_DAO.Instance.UnLockUser(userName))
            {
                MessageBox.Show("Khôi phục tài khoản " + userName + " thành công", "Thông báo!"); ResetValue();
            }
        }
        private void btResetPass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đặt lại mật khẩu cho tài khoản " + userName + " ?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Account_DAO.Instance.ResetPassByAdmin(userName))
                {
                    MessageBox.Show("Đặt lại mật khẩu cho tài khoản " + userName + " thành công", "Thông báo!");
                    ResetValue();
                }
            }
        }
        private void cbRoleUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            btSave.Enabled = true;
            btCancle.Enabled = true;
            dgvAccount.Enabled = false;
        }
    }
}
