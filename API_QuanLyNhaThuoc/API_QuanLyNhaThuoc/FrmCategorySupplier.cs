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
    public partial class FrmCategorySupplier : Form
    {
        public FrmCategorySupplier()
        {
            InitializeComponent();
        }

        private void FrmCategorySupplier_Load(object sender, EventArgs e)
        {
            dgvCategory.AutoGenerateColumns = false;
            tbNote.Enabled = false;
            //LoadData();
            dgvCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvCategory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategory.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvCategory.DefaultCellStyle.SelectionForeColor = Color.Red;
            ClearData();
            DisableItem();
        }
        private void LoadData()
        {
            dgvCategory.DataSource = Category_DAO.Instance.GetListCategorySupplier("");
            SetColorRowWhenBillStatusIsDelete();
            ClearData();
            DisableItem();
        }
        private void ClearData()
        {
            tbRoleCode.Text = "";
            tbRoleName.Text = "";
            tbNote.Text = "";
        }
        private void dgvRoleUser_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvCategory.Rows.Count - 1; i++)
            {
                dgvCategory.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void DisableItem()
        {
            tbRoleCode.Enabled = false;
            tbRoleName.Enabled = false;
            btCancle.Enabled = false;
            btSave.Enabled = false;
            btEdit.Enabled = false;
            btLock.Enabled = false;
            btRestore.Enabled = false;
        }
        private void EnableItem()
        {
            tbRoleCode.Enabled = true;
            tbRoleName.Enabled = true;
            btSave.Enabled = true;
            btCancle.Enabled = true;
        }
        private void SetColorRowWhenBillStatusIsDelete()
        {
            for (int i = 0; i < dgvCategory.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvCategory.Rows[i].Cells[5].Value) == false)
                {
                    dgvCategory.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }
        private void dgvRoleUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                tbRoleCode.Text = dgvCategory.Rows[i].Cells[1].Value.ToString();
                tbRoleName.Text = dgvCategory.Rows[i].Cells[2].Value.ToString();
                tbNote.Text = dgvCategory.Rows[i].Cells[4].Value.ToString();
                string id = dgvCategory.Rows[i].Cells[1].Value.ToString();
                if (tbRoleCode.Text != "" || tbRoleCode.Text != null)
                    btEdit.Enabled = true;
                else btEdit.Enabled = false;
                if (Convert.ToBoolean(dgvCategory.Rows[i].Cells[5].Value) == true)
                {
                    btRestore.Enabled = false;
                    btLock.Enabled = true;
                }
                else if (Convert.ToBoolean(dgvCategory.Rows[i].Cells[5].Value) == false)
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
            tbNote.Enabled = true;
            btNew.Enabled = false;
            btEdit.Enabled = false;
            btLock.Enabled = false;
            btRestore.Enabled = false;
            dgvCategory.Enabled = false;
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            btSave.Enabled = true;
            btCancle.Enabled = true;
            btNew.Enabled = false;
            btEdit.Enabled = false;
            btLock.Enabled = false;
            btRestore.Enabled = false;
            dgvCategory.Enabled = false;
            tbRoleName.Enabled = true;
            tbNote.Enabled = true;
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            string roleName = tbRoleCode.Text.Trim().ToUpper();

            if (tbRoleCode.Enabled == true)
            {
                if (tbRoleName.Text.Trim() == "" || roleName == "")
                {
                    MessageBox.Show("Những trường bắt buộc không được để trống!", "Thông báo!");
                }
                else
                {
                    if (Category_DAO.Instance.InsertCategorySupplier(roleName, tbRoleName.Text.Trim(), tbNote.Text))
                    {
                        LoadData();
                        btNew.Enabled = true;
                        dgvCategory.Enabled = true;

                        MessageBox.Show("Thêm nhóm " + roleName + " thành công!", "Thông báo!");
                    }
                    else { MessageBox.Show("Thêm thất bại do tên nhóm " + roleName + " đã tồn tại!", "Thông báo!"); }
                }
            }
            else
            {
                if (Category_DAO.Instance.UpdateCategorySupplier(roleName, tbRoleName.Text.Trim(), tbNote.Text))
                {
                    LoadData();
                    btEdit.Enabled = true;
                    btNew.Enabled = true;
                    dgvCategory.Enabled = true;
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
            dgvCategory.Enabled = true;
        }
        private void btLock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Khóa nhóm sẽ ảnh hưởng đến những sản phẩm thuộc nhóm này.\nBạn có chắc muốn thực hiện?", "Thông báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Category_DAO.Instance.LockCategorySupplier(tbRoleCode.Text))
                    MessageBox.Show("Khóa nhóm " + tbRoleCode.Text + " thành công!", "Thông báo!");
                LoadData();
            }
        }
        private void btRestore_Click(object sender, EventArgs e)
        {
            if (Category_DAO.Instance.UnLockCategorySupplier(tbRoleCode.Text))
                MessageBox.Show("Khôi phục nhóm " + tbRoleCode.Text + " thành công!", "Thông báo!");
            LoadData();
        }

        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            dgvCategory.DataSource = Category_DAO.Instance.GetListCategorySupplier(tbSearch.text);
            SetColorRowWhenBillStatusIsDelete();
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            dgvCategory.DataSource = Category_DAO.Instance.GetListCategorySupplier(tbSearch.text);
            SetColorRowWhenBillStatusIsDelete();
        }
    }
}
