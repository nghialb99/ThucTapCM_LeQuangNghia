using API_QuanLyNhaThuoc.DAO;
using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_QuanLyNhaThuoc
{
    public partial class FrmProduct : Form
    {
        private Logout New;
        public FrmProduct(Logout n)
        {
            InitializeComponent();
            New = n;
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            dgvListProduct.AutoGenerateColumns = false;
            dgvListProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvListProduct.CellBorderStyle = DataGridViewCellBorderStyle.Raised;// SingleHorizontal;
            dgvListProduct.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvListProduct.DefaultCellStyle.SelectionForeColor = Color.Black;

            tbSearch.text = "";
            btCancle.Enabled = false;
            btSave.Enabled = false;
            btChooseImage.Enabled = false;
        }
        private void dgvListProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvListProduct.Rows.Count; i++)
            {
                dgvListProduct.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void SetColorRowWhenBillStatusIsDelete()
        {
            for (int i = 0; i < dgvListProduct.Rows.Count; i++)
            {
                if (dgvListProduct.Rows[i].Cells[8].Value.ToString() == "Đã hết hạn")
                {
                    dgvListProduct.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (dgvListProduct.Rows[i].Cells[8].Value.ToString() == "Sắp hết hạn")
                {
                    dgvListProduct.Rows[i].DefaultCellStyle.ForeColor = Color.Orange;
                }
            }
        }
        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            dgvListProduct.DataSource = Product_DAO.Instance.GetListProduct(tbSearch.text);
            SetColorRowWhenBillStatusIsDelete();
        }
        private void tbSearch_Enter(object sender, EventArgs e)
        {
            dgvListProduct.DataSource = Product_DAO.Instance.GetListProduct(tbSearch.text);
            SetColorRowWhenBillStatusIsDelete();
        }

        private string id;
        private void dgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                id = dgvListProduct.Rows[i].Cells[1].Value.ToString();
                tbId.Text = id;
                Product pr = Product_DAO.Instance.GetFullProductById(id);
                tbName.Text = pr.Name;
                tbIdCategory.Text = pr.IdCategory;
                tbDosage.Text = pr.Dosage;
                tbFrom.Text = pr.From;
                tbPackagingSpecifications.Text = pr.PackagingSpecifications;
                tbExchangeValue.Text = pr.ExchangeValue.ToString();
                tbUnitName.Text = pr.UnitName;
                tbBatchNo.Text = pr.BatchNo;
                tbInventoryNumber.Text = pr.InventoryNumber.ToString();
                tbManDate.Value = pr.ManDate;
                tbExpDate.Value = pr.ExpDate;
                pictureBox1.Image = pr.Image;
                if (tbId.Text != "")
                {
                    btChooseImage.Enabled = true;
                    btUnitPrice.Enabled = true;
                }
                else
                {
                    btChooseImage.Enabled = false;
                    btUnitPrice.Enabled = false;
                }
            }
            catch { btChooseImage.Enabled = false; btUnitPrice.Enabled = false; }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void tbUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btNewUnitName_Click(object sender, EventArgs e)
        {
            FrmUnitName f = new FrmUnitName();
            f.ShowDialog();
        }

        private void btUnitPrice_Click(object sender, EventArgs e)
        {
            FrmUnitPrice f = new FrmUnitPrice(id);
            f.ShowDialog();
        }

        private string ImageLocation;
        private void btChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
                ImageLocation = dlg.FileName;
                btCancle.Enabled = true;
                btSave.Enabled = true;
                dgvListProduct.Enabled = false;
                btNew.Enabled = false;
                btNewUnitName.Enabled = false;
                btUnitPrice.Enabled = false;
            }
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            btCancle.Enabled = false;
            btSave.Enabled = false;
            btNew.Enabled = true;
            btNewUnitName.Enabled = true;
            btUnitPrice.Enabled = true;
            dgvListProduct.Enabled = true;
            pictureBox1.Image = null;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            byte[] imageData = null;
            using (FileStream fs = new FileStream(ImageLocation, FileMode.Open, FileAccess.Read))
            {
                imageData = new Byte[fs.Length];
                fs.Read(imageData, 0, Convert.ToInt32(fs.Length));
            }
            if (Product_DAO.Instance.UpdateImageProduct(id, Convert.ToBase64String(imageData)))
            {
                MessageBox.Show("Cập nhật thành công","Thông báo");
                btCancle.Enabled = false;
                btSave.Enabled = false;
                btNew.Enabled = true;
                btNewUnitName.Enabled = true;
                btUnitPrice.Enabled = true;
                dgvListProduct.Enabled = true;
                dgvListProduct.DataSource = Product_DAO.Instance.GetListProduct(tbSearch.text);
                SetColorRowWhenBillStatusIsDelete();
            }
        }
    }
}
