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
    public partial class FrmUserInfo : Form
    {
        public FrmUserInfo()
        {
            InitializeComponent();
        }
        private void FrmUserInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            UserAccount user = Account_DAO.Instance.GetUserAccount(FrmLogin.username);
            tbUserName.Text = user.UserName;
            tbDisplayName.Text = user.UserDisplayName;
            tbIdCard.Text = user.UserIdCard;
            tbGender.Text = user.UserGender;
            tbUserPhone.Text = user.UserPhoneNumber;
            tbUserEmail.Text = user.UserEmail;
            tbUserAddress.Text = user.UserAddress;
            DatepickerBirthday.Value = (DateTime)user.UserBirthDate;
            tbUserPass.Text = "";
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (tbUserPass.Text == null || tbUserPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo");
            }
            else
            {
                if (Email_DAO.Instance.isEmail(tbUserEmail.Text))
                {
                    string pass = Account_DAO.Instance.Encrypt(tbUserPass.Text);
                    if (Account_DAO.Instance.UpdateUserInfo(tbUserName.Text, pass, tbDisplayName.Text, tbIdCard.Text, tbGender.Text, DatepickerBirthday.Value, tbUserPhone.Text, tbUserEmail.Text, tbUserAddress.Text))
                    {
                        MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu sai!", "Thông báo!");
                        tbUserPass.Text = "";
                    }
                }
                else { MessageBox.Show("Email không đúng định dạng!", "Thông báo!"); }
            }
        }

        private void tbUserPass_OnValueChanged(object sender, EventArgs e)
        {
            tbUserPass.isPassword = true;
        }
    }
}
