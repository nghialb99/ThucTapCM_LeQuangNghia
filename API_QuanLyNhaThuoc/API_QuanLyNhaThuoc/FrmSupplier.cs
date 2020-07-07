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
    public partial class FrmSupplier : Form
    {
        private Logout Exit;
        public FrmSupplier()
        {
            InitializeComponent();
        }
        public FrmSupplier(Logout ex)
        {
            InitializeComponent();
            Exit = ex;
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            if (this.TopLevel == false) btExit.Visible = false;
            dgvCustomer.AutoGenerateColumns = false;
            //LoadData();
            ClearData();
            DisableItem();
            dgvCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvCustomer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomer.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvCustomer.DefaultCellStyle.SelectionForeColor = Color.Red;

            cbIdgr.ValueMember = "RoleCode";
            cbIdgr.DisplayMember = "RoleName";
            cbIdgr.DataSource = Category_DAO.Instance.GetListCategorySupplier("");
        }
        private void LoadData()
        {
            dgvCustomer.DataSource = Supplier_DAO.Instance.GetListSupplier("");
            SetColorRowWhenBillStatusIsDelete();
            ClearData();
            DisableItem();
        }
        private void ClearData()
        {
            tbTaxCode.Text = "";
            tbName.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            tbNote.Text = "";
            tbWeb.Text = "";
            cbIdgr.Text = "";
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
            tbTaxCode.Enabled = false;
            tbName.Enabled = false;
            tbAddress.Enabled = false;
            tbEmail.Enabled = false;
            tbPhone.Enabled = false;
            tbNote.Enabled = false;
            tbWeb.Enabled = false;
            cbIdgr.Enabled = false;
            btCancle.Enabled = false;
            btSave.Enabled = false;
            btEdit.Enabled = false;
        }
        private void EnableItem()
        {
            tbTaxCode.Enabled = true;
            tbName.Enabled = true;
            tbAddress.Enabled = true;
            tbEmail.Enabled = true;
            tbPhone.Enabled = true;
            tbNote.Enabled = true;
            tbWeb.Enabled = true;
            cbIdgr.Enabled = true;
            btSave.Enabled = true;
            btCancle.Enabled = true;
        }
        private void SetColorRowWhenBillStatusIsDelete()
        {
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                if (dgvCustomer.Rows[i].Cells[9].Value.ToString() == "Bị khóa")
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
                tbTaxCode.Text = dgvCustomer.Rows[i].Cells[1].Value.ToString();
                tbName.Text = dgvCustomer.Rows[i].Cells[2].Value.ToString();
                cbIdgr.Text = dgvCustomer.Rows[i].Cells[3].Value.ToString();
                tbEmail.Text = dgvCustomer.Rows[i].Cells[4].Value.ToString();
                tbWeb.Text = dgvCustomer.Rows[i].Cells[5].Value.ToString();
                tbPhone.Text = dgvCustomer.Rows[i].Cells[6].Value.ToString();
                tbAddress.Text = dgvCustomer.Rows[i].Cells[7].Value.ToString();
                tbNote.Text = dgvCustomer.Rows[i].Cells[8].Value.ToString();

                string id = dgvCustomer.Rows[i].Cells[1].Value.ToString();
                if (tbTaxCode.Text != "" || tbTaxCode.Text != null)
                    btEdit.Enabled = true;
                else btEdit.Enabled = false;
                if (dgvCustomer.Rows[i].Cells[9].Value.ToString() == "Hoạt động")
                {
                    btRestore.Enabled = false;
                    btLock.Enabled = true;
                }
                else if (dgvCustomer.Rows[i].Cells[9].Value.ToString() == "Bị khóa")
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
            btNew.Enabled = false;
            btEdit.Enabled = false;
            btLock.Enabled = false;
            btRestore.Enabled = false;
            dgvCustomer.Enabled = false;
            EnableItem();
            tbTaxCode.Enabled = false;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            string roleName = tbTaxCode.Text.Trim().ToUpper();

            if (tbTaxCode.Enabled == true)
            {
                if (tbName.Text.Trim() == "" || roleName == "" || cbIdgr.Text=="")
                {
                    MessageBox.Show("Những trường bắt buộc không được để trống!", "Thông báo!");
                }
                else
                {
                    if (Supplier_DAO.Instance.InsertSupplier(roleName, tbName.Text, cbIdgr.SelectedValue.ToString(), tbEmail.Text, tbWeb.Text, tbPhone.Text, tbAddress.Text, tbNote.Text))
                    {
                        LoadData();
                        btNew.Enabled = true;
                        dgvCustomer.Enabled = true;

                        MessageBox.Show("Thêm khách hàng " + roleName + " thành công!", "Thông báo!");
                    }
                    else { MessageBox.Show("Thêm thất bại do mã khách hàng " + roleName + " đã tồn tại!", "Thông báo!"); }
                }
            }
            else
            {
                if (tbName.Text.Trim() == "" || cbIdgr.Text == "")
                {
                    MessageBox.Show("Những trường bắt buộc không được để trống!", "Thông báo!");
                }
                else
                {//string TaxCode,string Name,string IdGr,string Email,string Website,string Phone,string Addr,string Note
                    if (Supplier_DAO.Instance.UpdateSupplier(roleName, tbName.Text,cbIdgr.SelectedValue.ToString(), tbEmail.Text,tbWeb.Text, tbPhone.Text, tbAddress.Text,tbNote.Text))
                    {
                        LoadData();
                        btEdit.Enabled = true;
                        btNew.Enabled = true;
                        dgvCustomer.Enabled = true;
                        MessageBox.Show("Cập nhật " + roleName + " thành công!", "Thông báo!");
                    }
                    else { MessageBox.Show("Có lỗi gì đó xãy ra. Vui lòng thử lại sau ít phút.", "Thông báo!"); }
                }
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
            dgvCustomer.Enabled = true;
        }
        private void btLock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Khóa nhà cung cấp bạn sẽ không tìm thấy tên nhà cung cấp lúc nhập hàng.\nBạn có chắc muốn thực hiện?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Supplier_DAO.Instance.LockSupplier(tbTaxCode.Text))
                    MessageBox.Show("Khóa " + tbTaxCode.Text + " thành công!", "Thông báo!");
                LoadData();
            }
        }
        private void btRestore_Click(object sender, EventArgs e)
        {
            if (Supplier_DAO.Instance.UnLockSupplier(tbTaxCode.Text))
                MessageBox.Show("Khôi phục " + tbTaxCode.Text + " thành công!", "Thông báo!");
            LoadData();
        }

        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = Supplier_DAO.Instance.GetListSupplier(tbSearch.text);
            SetColorRowWhenBillStatusIsDelete();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Exit();
            this.Close();
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = Supplier_DAO.Instance.GetListSupplier(tbSearch.text);
            SetColorRowWhenBillStatusIsDelete();
        }
    }
}
