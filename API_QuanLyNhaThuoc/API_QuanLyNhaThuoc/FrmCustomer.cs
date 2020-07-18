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
    public partial class FrmCustomer : Form
    {
        private Logout Exit;
        public FrmCustomer()
        {
            InitializeComponent();
        }
        public FrmCustomer(Logout ex)
        {
            InitializeComponent();
            Exit = ex;
        }
        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomer.AutoGenerateColumns = false;
            //LoadData();
            ClearData();
            DisableItem();
            dgvCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvCustomer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomer.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvCustomer.DefaultCellStyle.SelectionForeColor = Color.Red;
            if (this.TopLevel == false) btExit.Visible = false;
        }
        private void LoadData()
        {
            dgvCustomer.DataSource = Buyer_DAO.Instance.GetListBuyer("");
            SetColorRowWhenBillStatusIsDelete();
            ClearData();
            DisableItem();
        }
        private void ClearData()
        {
            tbCode.Text = "";
            tbName.Text = "";
            tbTaxCode.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
        }
        private void dgvRoleUser_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                dgvCustomer.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void DisableItem()
        {
            tbCode.Enabled = false;
            tbName.Enabled = false;
            tbTaxCode.Enabled = false;
            tbAddress.Enabled = false;
            tbEmail.Enabled = false;
            tbPhone.Enabled = false;
            btCancle.Enabled = false;
            btSave.Enabled = false;
            btEdit.Enabled = false;
            btLock.Enabled = false;
            btRestore.Enabled = false;
        }
        private void EnableItem()
        {
            tbCode.Enabled = true;
            tbName.Enabled = true;
            tbTaxCode.Enabled = true;
            tbAddress.Enabled = true;
            tbEmail.Enabled = true;
            tbPhone.Enabled = true;
            btSave.Enabled = true;
            btCancle.Enabled = true;
        }
        private void SetColorRowWhenBillStatusIsDelete()
        {
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                if (dgvCustomer.Rows[i].Cells[7].Value.ToString() == "Khóa")
                {
                    dgvCustomer.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void dgvRoleUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                tbCode.Text = dgvCustomer.Rows[i].Cells[1].Value.ToString();
                tbName.Text = dgvCustomer.Rows[i].Cells[2].Value.ToString();
                tbTaxCode.Text = dgvCustomer.Rows[i].Cells[3].Value.ToString();
                tbPhone.Text = dgvCustomer.Rows[i].Cells[4].Value.ToString();
                tbEmail.Text = dgvCustomer.Rows[i].Cells[5].Value.ToString();
                tbAddress.Text = dgvCustomer.Rows[i].Cells[6].Value.ToString();

                string id = dgvCustomer.Rows[i].Cells[1].Value.ToString();
                if (tbCode.Text != "" || tbCode.Text != null)
                    btEdit.Enabled = true;
                else btEdit.Enabled = false;
                if (dgvCustomer.Rows[i].Cells[7].Value.ToString() == "Hoạt động")
                {
                    btRestore.Enabled = false;
                    btLock.Enabled = true;
                }
                else if (dgvCustomer.Rows[i].Cells[7].Value.ToString() == "Khóa")
                {
                    btRestore.Enabled = true;
                    btLock.Enabled = false;
                }
                else
                {
                    btRestore.Enabled = false;
                    btLock.Enabled = false;
                }
                SetColorRowWhenBillStatusIsDelete();
            }
            catch { }
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            ClearData();
            EnableItem();

            btNew.Enabled = false;
            btEdit.Enabled = false;
            btLock.Enabled = false;
            btRestore.Enabled = false;
            dgvCustomer.Enabled = false;
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            btSave.Enabled = true;
            btCancle.Enabled = true;
            btNew.Enabled = false;
            btEdit.Enabled = false;
            btLock.Enabled = false;
            btRestore.Enabled = false;
            dgvCustomer.Enabled = false;
            tbName.Enabled = true;
            tbAddress.Enabled = true;
            tbEmail.Enabled = true;
            tbPhone.Enabled = true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            string roleName = tbCode.Text.Trim().ToUpper();

            if (tbCode.Enabled == true)
            {
                if (tbName.Text.Trim() == "" || roleName == "")
                {
                    MessageBox.Show("Những trường bắt buộc không được để trống!", "Thông báo!");
                }
                else
                {
                    if(tbEmail.Text != "")
                    {
                        if (Email_DAO.Instance.isEmail(tbEmail.Text))
                        {
                            if (Buyer_DAO.Instance.InsertBuyer(roleName, tbName.Text, tbTaxCode.Text, tbPhone.Text, tbEmail.Text, tbAddress.Text))
                            {
                                LoadData();
                                btNew.Enabled = true;
                                dgvCustomer.Enabled = true;

                                MessageBox.Show("Thêm khách hàng " + roleName + " thành công!", "Thông báo!");
                            }
                            else { MessageBox.Show("Thêm thất bại do mã khách hàng " + roleName + " đã tồn tại!", "Thông báo!"); }
                        }
                        else { MessageBox.Show("Email không đúng định dạng!", "Thông báo!"); }
                    }
                    else
                    {
                        if (Buyer_DAO.Instance.InsertBuyer(roleName, tbName.Text, tbTaxCode.Text, tbPhone.Text, tbEmail.Text, tbAddress.Text))
                        {
                            LoadData();
                            btNew.Enabled = true;
                            dgvCustomer.Enabled = true;

                            MessageBox.Show("Thêm khách hàng " + roleName + " thành công!", "Thông báo!");
                        }
                        else { MessageBox.Show("Thêm thất bại do mã khách hàng " + roleName + " đã tồn tại!", "Thông báo!"); }
                    }
                    
                }
            }
            else
            {
                if(tbEmail.Text == "")
                {
                    if (Buyer_DAO.Instance.UpdateBuyer(roleName, tbName.Text, tbTaxCode.Text, tbPhone.Text, tbEmail.Text, tbAddress.Text))
                    {
                        LoadData();
                        btEdit.Enabled = true;
                        btNew.Enabled = true;
                        dgvCustomer.Enabled = true;
                        MessageBox.Show("Cập nhật " + roleName + " thành công!", "Thông báo!");
                    }
                    else { MessageBox.Show("Có lỗi gì đó xãy ra. Vui lòng thử lại sau ít phút.", "Thông báo!"); }
                }
                else
                {
                    if (Email_DAO.Instance.isEmail(tbEmail.Text))
                    {
                        if (Buyer_DAO.Instance.UpdateBuyer(roleName, tbName.Text, tbTaxCode.Text, tbPhone.Text, tbEmail.Text, tbAddress.Text))
                        {
                            LoadData();
                            btEdit.Enabled = true;
                            btNew.Enabled = true;
                            dgvCustomer.Enabled = true;
                            MessageBox.Show("Cập nhật " + roleName + " thành công!", "Thông báo!");
                        }
                        else { MessageBox.Show("Có lỗi gì đó xãy ra. Vui lòng thử lại sau ít phút.", "Thông báo!"); }
                    }
                    else { MessageBox.Show("Email không đúng định dạng!", "Thông báo!"); }
                }
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
            dgvCustomer.Enabled = true;
        }
        private void btLock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Khóa khách hàng bạn sẽ không tìm thấy tên khách hàng lúc lập hóa đơn.\nBạn có chắc muốn thực hiện?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Buyer_DAO.Instance.LockBuyer(tbCode.Text))
                    MessageBox.Show("Khóa " + tbCode.Text + " thành công!", "Thông báo!");
                LoadData();
            }
        }
        private void btRestore_Click(object sender, EventArgs e)
        {
            if (Buyer_DAO.Instance.UnLockBuyer(tbCode.Text))
                MessageBox.Show("Khôi phục " + tbCode.Text + " thành công!", "Thông báo!");
            LoadData();
        }
        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = Buyer_DAO.Instance.GetListBuyer(tbSearch.text);
            SetColorRowWhenBillStatusIsDelete();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Exit();
            this.Close();
        }
        private void tbSearch_Enter(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = Buyer_DAO.Instance.GetListBuyer(tbSearch.text);
            SetColorRowWhenBillStatusIsDelete();
        }
    }
}
