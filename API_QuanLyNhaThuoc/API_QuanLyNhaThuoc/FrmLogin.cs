using API_QuanLyNhaThuoc.DAO;
using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_QuanLyNhaThuoc
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            LoadForm();
            Product_DAO.Instance.AutoUpdateStatusProduct();
            lbNotification.Text = "";
            lbNotification1.Text = "";
            lbNotification2.Text = "";
            panelTransparen.Visible = true;
            panelFogetPass.Visible = false;
            panelChangePass.Visible = false;
            //label1.Text = Account_DAO.Instance.Decrypt(lbNotification.Text);
        }
        private void LoadForm()
        {
            //tbUserName.ForeColor = Color.LightGray;
            //tbUserName.Text = "Tài khoản";
            //this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
            //this.tbUserName.Enter += new System.EventHandler(this.tbUserName_Enter);

            //tbPassWord.ForeColor = Color.LightGray;
            //tbPassWord.UseSystemPasswordChar = false;
            //tbPassWord.Text = "Mật khẩu";
            //this.tbPassWord.Leave += new System.EventHandler(this.tbPassWord_Leave);
            //this.tbPassWord.Enter += new System.EventHandler(this.tbPassWord_Enter);

            tbUserNameForget.ForeColor = Color.LightGray;
            tbUserNameForget.Text = "Tài khoản";
            this.tbUserNameForget.Leave += new System.EventHandler(this.tbUserNameForget_Leave);
            this.tbUserNameForget.Enter += new System.EventHandler(this.tbUserNameForget_Enter);

            tbUserEmail.ForeColor = Color.LightGray;
            tbUserEmail.Text = "Email";
            this.tbUserEmail.Leave += new System.EventHandler(this.tbUserEmail_Leave);
            this.tbUserEmail.Enter += new System.EventHandler(this.tbUserEmail_Enter);

            tbVerificationCode.ForeColor = Color.LightGray;
            tbVerificationCode.Text = "Mã xác nhận";
            this.tbVerificationCode.Leave += new System.EventHandler(this.tbVerificationCode_Leave);
            this.tbVerificationCode.Enter += new System.EventHandler(this.tbVerificationCode_Enter);

            tbNewPass.ForeColor = Color.LightGray;
            tbNewPass.UseSystemPasswordChar = false;
            tbNewPass.Text = "Mật khẩu mới";
            this.tbNewPass.Leave += new System.EventHandler(this.tbNewPass_Leave);
            this.tbNewPass.Enter += new System.EventHandler(this.tbNewPass_Enter);

            tbReEnterPass.ForeColor = Color.LightGray;
            tbReEnterPass.UseSystemPasswordChar = false;
            tbReEnterPass.Text = "Nhập lại mật khẩu";
            this.tbReEnterPass.Leave += new System.EventHandler(this.tbReEnterPass_Leave);
            this.tbReEnterPass.Enter += new System.EventHandler(this.tbReEnterPass_Enter);
        }
        private void LogOut()
        {
            lbNotification.Text = "";
            //tbUserName.Clear();
            tbPassWord.Clear();
            this.Show();
            btContinue.Enabled = true;
        }
        public static string username = "";
        private bool CheckLogin(string user, string pass)
        {
            return Account_DAO.Instance.CheckLogin(user, pass);
        }

        #region even click
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            string user = tbUserName.Text.TrimEnd();
            string pass = tbPassWord.Text;

            if (CheckLogin(user, pass))
            {
                username = user.ToLower();
                try
                {
                    List<RoleUserManager> ListRole = RoleUserManager_DAO.Instance.CheckRoleUserManager(username);
                    if (ListRole[0].Status == "Hoạt động")
                    {
                        btContinue.Enabled = false;
                        FrmManager f = new FrmManager(LogOut);
                        this.Hide();
                        f.ShowDialog();
                    }
                    else
                    {
                        lbNotification.Text = "Tài khoản của bạn chưa được cấp quyền. Liên hệ với quản trị viên.";
                        i = 3;
                        timer1.Enabled = true;
                        //MessageBox.Show("Tài khoản của bạn chưa được cấp quyền", "Thông báo!");
                    }
                }
                catch
                {
                    lbNotification.Text = "Tài khoản của bạn chưa được cấp quyền. Liên hệ với quản trị viên.";
                    i = 3;
                    timer1.Enabled = true;
                    //MessageBox.Show("Tài khoản của bạn chưa được cấp quyền", "Thông báo!"); 
                }
            }
            else
            {
                lbNotification.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                i = 3;
                timer1.Enabled = true;
            }

        }
        private void lbForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelTransparen.Visible = false;
            panelFogetPass.Visible = true;
            LoadForm();
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            panelFogetPass.Visible = false;
            panelTransparen.Visible = true;
            LoadForm();
        }
        private void btContinue_Click(object sender, EventArgs e)
        {
            string user = tbUserNameForget.Text.TrimEnd().ToLower();
            string email = tbUserEmail.Text.Trim().ToLower();
            if (Email_DAO.Instance.isEmail(email))
            {
                if (Account_DAO.Instance.CheckForgetPass(user, email))
                {
                    if (Account_DAO.Instance.CheckStatus(user))
                    {
                        if (Email_DAO.Instance.SendMailResetPassword(email, Account_DAO.Instance.GetVerificationCode(user, email)))
                        {
                            lbNotification2.Text = "Hệ thống đã thực hiện gửi mã xác nhận. Vui lòng kiểm tra mail.";
                            i = 5;
                            timer1.Enabled = true;
                            username = user;
                            panelFogetPass.Visible = false;
                            panelChangePass.Visible = true;
                            LoadForm();
                        }
                        else
                        {
                            lbNotification1.Text = "Có lỗi gì đó xãy ra. Vui lòng thử lái sau.";
                            i = 3;
                            timer1.Enabled = true;
                        }
                    }
                    else
                    {
                        lbNotification1.Text = "Tài khoản của bạn đã bị khóa. Liên hệ với quản trị viên";
                        i = 3;
                        timer1.Enabled = true;
                    }
                }
                else
                {
                    tbUserNameForget.Text = "";
                    tbUserEmail.Text = "";
                    lbNotification1.Text = "Tên đăng nhập và email không đúng";
                    i = 3;
                    timer1.Enabled = true;
                }
            }
            else
            {
                tbUserEmail.Text = "";
                lbNotification1.Text = "Email không đúng định dạng";
                i = 3;
                timer1.Enabled = true;
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            LoadForm();
            panelChangePass.Visible = false;
            panelTransparen.Visible = true;
        }
        private void btChangePass_Click(object sender, EventArgs e)
        {
            string veriCode = tbVerificationCode.Text.Trim();
            string newPass = tbNewPass.Text;
            string passReEnter = tbReEnterPass.Text;
            if(newPass == passReEnter)
            {
                newPass = Account_DAO.Instance.Encrypt(newPass);
                if (Account_DAO.Instance.ChangePassWhenForgetPass(username, newPass, veriCode))
                {
                    lbNotification.Text = "Đổi mật khẩu thành công. Vui lòng đăng nhập lại";
                    i = 7;
                    timer1.Enabled = true;
                    LoadForm();
                    timer1.Enabled = true;
                    panelChangePass.Visible = false;
                    panelTransparen.Visible = true;
                }
                else
                {
                    lbNotification2.Text = "Mã xác nhận không đúng";
                    i = 3;
                    timer1.Enabled = true;
                }
            }
            else
            {
                lbNotification2.Text = "Mật khẩu mới với mật khẩu nhập lại không trùng nhau";
                i = 3;
                timer1.Enabled = true;
            }
        }
        #endregion
        #region even load
        int i = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            if (i == 0) { lbNotification.Text = ""; lbNotification1.Text = ""; lbNotification2.Text = ""; timer1.Enabled = false; }
        }
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tbUserName_Leave(object sender, EventArgs e)
        {
            if (tbUserName.Text == "")
            {
                tbUserName.Text = "Tài khoản";
                tbUserName.ForeColor = Color.Gray;
            }
        }

        private void tbUserName_Enter(object sender, EventArgs e)
        {
            if (tbUserName.Text == "Tài khoản")
            {
                tbUserName.Text = "";
                tbUserName.ForeColor = Color.Black;
            }
        }

        private void tbUserNameForget_Enter(object sender, EventArgs e)
        {
            if (tbUserNameForget.Text == "Tài khoản")
            {
                tbUserNameForget.Text = "";
                tbUserNameForget.ForeColor = Color.Black;
            }
        }

        private void tbUserNameForget_Leave(object sender, EventArgs e)
        {
            if (tbUserNameForget.Text == "")
            {
                tbUserNameForget.Text = "Tài khoản";
                tbUserNameForget.ForeColor = Color.Gray;
            }
        }

        private void tbUserEmail_Enter(object sender, EventArgs e)
        {
            if (tbUserEmail.Text == "Email")
            {
                tbUserEmail.Text = "";
                tbUserEmail.ForeColor = Color.Black;
            }
        }

        private void tbUserEmail_Leave(object sender, EventArgs e)
        {
            if (tbUserEmail.Text == "")
            {
                tbUserEmail.Text = "Email";
                tbUserEmail.ForeColor = Color.Gray;
            }
        }

        private void tbVerificationCode_Enter(object sender, EventArgs e)
        {
            if (tbVerificationCode.Text == "Mã xác nhận")
            {
                tbVerificationCode.Text = "";
                tbVerificationCode.ForeColor = Color.Black;
            }
        }

        private void tbVerificationCode_Leave(object sender, EventArgs e)
        {
            if (tbVerificationCode.Text == "")
            {
                tbVerificationCode.Text = "Mã xác nhận";
                tbVerificationCode.ForeColor = Color.Gray;
            }
        }

        private void tbPassWord_Leave(object sender, EventArgs e)
        {
            if (tbPassWord.Text == "")
            {
                tbPassWord.Text = "Mật khẩu";
                tbPassWord.UseSystemPasswordChar = false;
                tbPassWord.ForeColor = Color.Gray;
            }
        }

        private void tbPassWord_Enter(object sender, EventArgs e)
        {
            if (tbPassWord.Text == "Mật khẩu")
            {
                tbPassWord.Text = "";
                tbPassWord.UseSystemPasswordChar = true;
                tbPassWord.ForeColor = Color.Black;
            }
        }
        private void tbNewPass_Enter(object sender, EventArgs e)
        {
            if (tbNewPass.Text == "Mật khẩu mới")
            {
                tbNewPass.Text = "";
                tbNewPass.UseSystemPasswordChar = true;
                tbNewPass.ForeColor = Color.Black;
            }
        }

        private void tbNewPass_Leave(object sender, EventArgs e)
        {
            if (tbNewPass.Text == "")
            {
                tbNewPass.Text = "Mật khẩu mới";
                tbNewPass.UseSystemPasswordChar = false;
                tbNewPass.ForeColor = Color.Gray;
            }
        }

        private void tbReEnterPass_Enter(object sender, EventArgs e)
        {
            if (tbReEnterPass.Text == "Nhập lại mật khẩu")
            {
                tbReEnterPass.Text = "";
                tbReEnterPass.UseSystemPasswordChar = true;
                tbReEnterPass.ForeColor = Color.Black;
            }
        }

        private void tbReEnterPass_Leave(object sender, EventArgs e)
        {
            if (tbReEnterPass.Text == "")
            {
                tbReEnterPass.Text = "Nhập lại mật khẩu";
                tbReEnterPass.UseSystemPasswordChar = false;
                tbReEnterPass.ForeColor = Color.Gray;
            }
        }
        #endregion
    }
}
