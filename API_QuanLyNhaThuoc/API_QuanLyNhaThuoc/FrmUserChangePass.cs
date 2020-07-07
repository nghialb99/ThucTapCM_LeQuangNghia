using API_QuanLyNhaThuoc.DAO;
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
    public partial class FrmUserChangePass : Form
    {
        private Logout logout;
        public FrmUserChangePass(Logout log)
        {
            InitializeComponent();
            logout = log;
        }
        private void FrmUserChangePass_Load(object sender, EventArgs e)
        {
            tbOutPass.isPassword = true;
            tbNewPass.isPassword = true;
            tbReEnterPass.isPassword = true;
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if(tbOutPass.Text == null || tbOutPass.Text == "" || tbNewPass.Text == null || tbNewPass.Text == "" || tbReEnterPass.Text == null || tbReEnterPass.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo!");
            }
            else
            {
                string Pass = tbOutPass.Text;
                string NewPass = tbNewPass.Text;
                string ReEnterPass = tbReEnterPass.Text;
                if (Pass == NewPass)
                {
                    MessageBox.Show("Mật khẩu mới của bạn trùng với mật khẩu cũ!", "Thông báo");
                    tbNewPass.Text = "";
                    tbReEnterPass.Text = "";
                }
                else
                {
                    if (!NewPass.Equals(ReEnterPass))
                    {
                        MessageBox.Show("Mật khẩu nhập lại không trùng với mật khẩu mới!", "Thông báo!");
                        tbReEnterPass.Text = "";
                    }
                    else
                    {
                        Pass = Account_DAO.Instance.Encrypt(Pass);
                        NewPass = Account_DAO.Instance.Encrypt(NewPass);
                        if (Account_DAO.Instance.UpdatePass(FrmLogin.username, Pass, NewPass))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công.\nVui lòng đăng nhập lại", "Thông báo!");
                            tbOutPass.Text = "";
                            tbNewPass.Text = "";
                            tbReEnterPass.Text = "";
                            this.Close();
                            logout();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu sai! Vui lòng thử lại.", "Thông báo!");
                            tbOutPass.Text = "";
                            tbNewPass.Text = "";
                            tbReEnterPass.Text = "";
                        }
                    }
                }
            }
        }

        private void tbNewPass_OnValueChanged(object sender, EventArgs e)
        {
            tbNewPass.isPassword = true;
        }

        private void tbReEnterPass_OnValueChanged(object sender, EventArgs e)
        {
            tbReEnterPass.isPassword = true;
        }

        private void tbOutPass_OnValueChanged(object sender, EventArgs e)
        {
            tbOutPass.isPassword = true;
        }
    }
}
