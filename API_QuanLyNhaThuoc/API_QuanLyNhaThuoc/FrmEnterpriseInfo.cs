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
    public delegate void AddOnMairorm(Form form);
    public partial class FrmEnterpriseInfo : Form
    {
        private AddOnMairorm BackHome;
        public FrmEnterpriseInfo()
        {
            InitializeComponent();
        }
        public FrmEnterpriseInfo(AddOnMairorm back)
        {
            InitializeComponent();
            BackHome = back;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackHome(new FrmOverviews());
        }

        private void FrmEnterpriseInfo_Load(object sender, EventArgs e)
        {
            tbEnterpriseTaxCode.Enabled = false;
            DisabledTexbox();
            LoadData(Account_DAO.Instance.CheckUsername());
        }
        private void LoadData(string user)
        {
            List<EnterpriseInfo> data = EnterpriseInfo_DAO.Instance.LoadEnterpriseInfo(user);
            tbEnterpriseName.Text = data[0].EnterpriseName.ToString();
            tbEnterpriseTaxCode.Text = data[0].EnterpriseTaxCode.ToString();
            tbEnterpriseAddress.Text = data[0].EnterpriseAddress.ToString();
            tbEnterpriseEmail.Text = data[0].EnterpriseEmail.ToString();
            tbEnterprisePhone.Text = data[0].EnterprisePhone.ToString();
            tbEnterpriseWeb.Text = data[0].EnterpriseWeb.ToString();
            tbEnterpriseAccNo.Text = data[0].EnterpriseAccNo.ToString();
            tbEnterpriseAccName.Text = data[0].EnterpriseAccName.ToString();
        }
        private void DisabledTexbox()
        {
            tbEnterpriseName.Enabled = false;
            tbEnterpriseAddress.Enabled = false;
            tbEnterpriseEmail.Enabled = false;
            tbEnterprisePhone.Enabled = false;
            tbEnterpriseWeb.Enabled = false;
            tbEnterpriseAccNo.Enabled = false;
            tbEnterpriseAccName.Enabled = false;
            btSave.Visible = false;
            btCancle.Visible = false;
            btUpdate.Visible = true;
        }
        private void EnabledTexbox()
        {
            tbEnterpriseName.Enabled = true;
            tbEnterpriseAddress.Enabled = true;
            tbEnterpriseEmail.Enabled = true;
            tbEnterprisePhone.Enabled = true;
            tbEnterpriseWeb.Enabled = true;
            tbEnterpriseAccNo.Enabled = true;
            tbEnterpriseAccName.Enabled = true;
            btSave.Visible = true;
            btCancle.Visible = true;
            btUpdate.Visible = false;
        }
        private bool UpdateEnterpriseInfo()
        {
            return EnterpriseInfo_DAO.Instance.UpdateEnterpriseInfo(tbEnterpriseName.Text, tbEnterpriseTaxCode.Text, tbEnterpriseAddress.Text, tbEnterpriseEmail.Text, tbEnterprisePhone.Text, tbEnterpriseWeb.Text, tbEnterpriseAccNo.Text, tbEnterpriseAccName.Text);
        }
        private void btUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Sửa thông tin doanh nghiệp có thể sẽ làm thay đổi thông tin có trên mẫu hóa đơn khác với thông tin mẫu hóa đơn đã đăng kí với cơ quan thuế.\nDoanh nghiệp có chắc chắn thực hiện?","Thông báo!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EnabledTexbox();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (UpdateEnterpriseInfo()) MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else MessageBox.Show("Cập nhật thông tin không thành công.\nVui lòng thử lại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisabledTexbox();
            LoadData(FrmLogin.username);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DisabledTexbox();
            LoadData(FrmLogin.username);
        }
    }
}
