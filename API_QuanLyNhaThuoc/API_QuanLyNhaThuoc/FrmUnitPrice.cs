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
    public partial class FrmUnitPrice : Form
    {
        private string IdProduct;
        public FrmUnitPrice(string id)
        {
            InitializeComponent();
            IdProduct = id;
        }
        private void FrmUnitPrice_Load(object sender, EventArgs e)
        {
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvCategory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategory.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvCategory.DefaultCellStyle.SelectionForeColor = Color.Red;
            LoadData();
            DisableItem();
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisableItem()
        {
            btCancle.Enabled = false;
            btSave.Enabled = false;
            btEdit.Enabled = false;
            tbExchangeValue.Enabled = false;
            tbUnitPrice.Enabled = false;
            cbUnitName.Enabled = false;
        }
        private void EnableItem()
        {
            btSave.Enabled = true;
            btCancle.Enabled = true;
            tbExchangeValue.Enabled = true;
            tbUnitPrice.Enabled = true;
            cbUnitName.Enabled = true;
        }
        private void LoadData()
        {
            dgvCategory.DataSource = Product_DAO.Instance.GetUnitPrice(IdProduct, "");
            Product pr = Product_DAO.Instance.GetFullProductById(IdProduct);
            rtbProductInfo.Text = pr.SyntheticName;
            pictureBox1.Image = pr.Image;

            cbUnitName.ValueMember = "id";
            cbUnitName.DisplayMember = "Ten";
            cbUnitName.DataSource = DataProvider.Instance.ExcuteQuery("exec GetUnitName @text", new object[] { "" });
        }
        private void dgvCategory_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvCategory.Rows.Count; i++)
            {
                dgvCategory.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private int ID = 0;
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            try
            {
                cbUnitName.Text = dgvCategory.Rows[row].Cells[1].Value.ToString();
                tbExchangeValue.Text = Convert.ToInt32(dgvCategory.Rows[row].Cells[2].Value).ToString("N0");
                tbUnitPrice.Text = Convert.ToDouble(dgvCategory.Rows[row].Cells[3].Value).ToString("N0");

                ID = Convert.ToInt32(dgvCategory.Rows[row].Cells[5].Value);
                if (e.ColumnIndex == dgvCategory.Columns["dgvButtonDelete"].Index && row >= 0)
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa cấu hình giá: " + cbUnitName.Text + " ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (Product_DAO.Instance.DeleteUnitPrice(ID))
                        {
                            MessageBox.Show("Xóa thành công !", "Thông báo");
                            LoadData();
                        }
                    }
                }
                if (dgvCategory.Rows[row].Cells[0].Value.ToString() != "")
                {
                    btEdit.Enabled = true;
                }
            }
            catch { btEdit.Enabled = false; cbUnitName.Text = ""; tbExchangeValue.Text = ""; tbUnitPrice.Text = ""; }
        }
        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            dgvCategory.DataSource = Product_DAO.Instance.GetUnitPrice(IdProduct, tbSearch.text);
        }

        private bool temp;
        private void btNew_Click(object sender, EventArgs e)
        {
            EnableItem();
            btNew.Enabled = false;
            dgvCategory.Enabled = false;
            temp = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EnableItem();
            tbUnitPrice.Text = tbUnitPrice.Text.Replace(",","");
            btEdit.Enabled = false;
            btNew.Enabled = false;
            dgvCategory.Enabled = false;
            temp = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (cbUnitName.Text == ""||tbExchangeValue.Text==""||tbUnitPrice.Text=="")
            {
                MessageBox.Show("Các trường bắt buộc không được để trống !", "Thông báo");
            }
            else
            {
                if (temp)
                {
                    if (Product_DAO.Instance.InsertUnitPrice(IdProduct, Convert.ToInt32(cbUnitName.SelectedValue), Convert.ToInt32(tbExchangeValue.Text), (float)Convert.ToDouble(tbUnitPrice.Text)))
                    {
                        MessageBox.Show("Thêm thành công !", "Thông báo");
                        LoadData();
                        DisableItem();
                        btNew.Enabled = true;
                        dgvCategory.Enabled = true;
                        tbExchangeValue.Text = "";
                        tbUnitPrice.Text = "";
                        cbUnitName.Text = "";
                    }
                }
                else
                {
                    if (Product_DAO.Instance.UpdateUnitPrice(ID, IdProduct, Convert.ToInt32(cbUnitName.SelectedValue), Convert.ToInt32(tbExchangeValue.Text), (float)Convert.ToDouble(tbUnitPrice.Text)))
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo");
                        LoadData();
                        DisableItem();
                        btNew.Enabled = true;
                        dgvCategory.Enabled = true;
                        tbExchangeValue.Text = "";
                        tbUnitPrice.Text = "";
                        cbUnitName.Text = "";
                    }
                }
            }
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            DisableItem();
            btNew.Enabled = true;
            dgvCategory.Enabled = true;
            tbExchangeValue.Text = "";
            tbUnitPrice.Text = "";
            cbUnitName.Text = "";
        }

        private void tbExchangeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
