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
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            lbSPHetHanThangToi.Text = "Tháng tới: " + Invoice_DAO.Instance.SoThuocSapHetHanThangSau().ToString();
            lbSPHetHanThangNay.Text = "Tháng này: " + Invoice_DAO.Instance.SoThuocSapHetHanThangNay().ToString();

            dgvListProduct.AutoGenerateColumns = false;
            dgvListProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvListProduct.CellBorderStyle = DataGridViewCellBorderStyle.Raised;// SingleHorizontal;
            dgvListProduct.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvListProduct.DefaultCellStyle.SelectionForeColor = Color.Black;

            radioButton1.Checked = true;
            dgvListProduct.DataSource = Product_DAO.Instance.LoadListProduct("ggggggggggggggggggggggggggggggg", status);

            
        }

        private void dgvListProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvListProduct.Rows.Count; i++)
            {
                dgvListProduct.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private int status = 1;
        private void btSearch_OnTextChange(object sender, EventArgs e)
        {
            dgvListProduct.DataSource = Product_DAO.Instance.LoadListProduct(btSearch.text,status);
            SetColorRowWhenBillStatusIsDelete();
        }
        private void SetColorRowWhenBillStatusIsDelete()
        {
            for (int i = 0; i < dgvListProduct.Rows.Count; i++)
            {
                //DataGridViewRow row = dgvListProduct.Rows[i];

                if (dgvListProduct.Rows[i].Cells[6].Value.ToString() == "Đã hết hạn")
                {
                    dgvListProduct.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
                else if(dgvListProduct.Rows[i].Cells[6].Value.ToString() == "Sắp hết hạn")
                {
                    dgvListProduct.Rows[i].DefaultCellStyle.ForeColor = Color.Orange;
                }
            }
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                status = 1;
                dgvListProduct.DataSource = Product_DAO.Instance.LoadListProduct(btSearch.text, status);
                SetColorRowWhenBillStatusIsDelete();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                radioButton3.Checked = false;
                status = 2;
                dgvListProduct.DataSource = Product_DAO.Instance.LoadListProduct(btSearch.text, status);
                SetColorRowWhenBillStatusIsDelete();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                radioButton2.Checked = false;
                radioButton1.Checked = false;
                status = 0;
                dgvListProduct.DataSource = Product_DAO.Instance.LoadListProduct(btSearch.text, status);
                SetColorRowWhenBillStatusIsDelete();
            }
        }

        private void btSearch_Enter(object sender, EventArgs e)
        {
            dgvListProduct.DataSource = Product_DAO.Instance.LoadListProduct(btSearch.text, status);
            SetColorRowWhenBillStatusIsDelete();
        }
    }
}
