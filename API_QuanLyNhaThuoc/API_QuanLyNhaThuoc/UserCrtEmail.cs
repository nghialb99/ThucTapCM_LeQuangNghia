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
    public partial class UserCrtEmail : UserControl
    {
        public UserCrtEmail()
        {
            InitializeComponent();
        }

        private void UserCrtEmail_Load(object sender, EventArgs e)
        {
            ResetValue();
            ConfigurationEmail mail = Email_DAO.Instance.GetEmail();
            tbEmail.Text = mail.EmailAddress;
            tbConfigurationName.Text = mail.ConfigurationName;
            tbPort.Text = mail.Port.ToString();
            tbSeverAddress.Text = mail.Server;
            cbStatus.Text = mail.Status;
        }

        private void ResetValue()
        {
            tbPassEmail.Text = "";
            tbReEnterPass.Text = "";
            cbConfigurationName.Text = "";
        }

        private void cbConfigurationName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConfigurationName.SelectedItem.ToString() == "Gmail")
            {
                tbSeverAddress.Text = "smtp.gmail.com";
                tbPort.Text = "587";
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if(tbEmail.Text == "" || tbConfigurationName.Text==""|| tbEmail.Text==""|| tbPassEmail.Text=="")
            {
                MessageBox.Show("Những trường bắt buộc không được để trống!", "Thông báo!");
            }
            else
            {
                if (Email_DAO.Instance.isEmail(tbEmail.Text))
                {
                    if (tbPassEmail.Text != tbReEnterPass.Text)
                    {
                        MessageBox.Show("Mật khẩu nhập lại không trùng với mật khẩu!", "Thông báo!");
                    }
                    else
                    {
                        if (Email_DAO.Instance.UpdateEmail(tbConfigurationName.Text, tbEmail.Text, tbPassEmail.Text, tbSeverAddress.Text, Convert.ToInt32(tbPort.Text), status))
                        {
                            ResetValue();
                            MessageBox.Show("Cập nhật thành công!", "Thông báo!");
                        }
                        else { MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại!", "Thông báo!"); ResetValue(); }
                    }
                }
                else { MessageBox.Show("Email không đúng định dạng!", "Thông báo!"); }
            }
        }
        private int status = 1;
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.SelectedItem.ToString() == "Hoạt động") status = 1;
            else if (cbStatus.SelectedItem.ToString() == "Không hoạt động") status = 0;
        }

        private void btBackupData_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog dl = new FolderBrowserDialog();

            //if (dl.ShowDialog(this) == DialogResult.OK)
            //{
            //    string filePath = dl.SelectedPath;

            //    string query = @"backup database Api_QuanLyNhaThuoc to disk = '" + filePath+ @"\Api_QLNT.bak' with differential";

            //    if (DataProvider.Instance.ExcuteNunQuery(query)>0) MessageBox.Show("Sao lưu hoàn tất ", "Thông báo");
            //}
        }

        private void btRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog dl = new OpenFileDialog();
            dl.Filter = "Image Files(*.bak,) | *.bak";
            if (dl.ShowDialog(this) == DialogResult.OK)
            {
                string filePath = dl.FileName;

                //if (temp == dgvListInvoice.Rows.Count) MessageBox.Show("Tải hoàn tất ", "Thông báo");
            }
        }
    }
}
