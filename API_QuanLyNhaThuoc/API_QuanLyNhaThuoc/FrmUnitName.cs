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
    public partial class FrmUnitName : Form
    {
        public FrmUnitName()
        {
            InitializeComponent();
        }
        private void FrmUnitName_Load(object sender, EventArgs e)
        {
            dgvCategory.AutoGenerateColumns = false;
            dgvCategory.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvCategory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategory.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvCategory.DefaultCellStyle.SelectionForeColor = Color.Red;
            LoadData();
            DisableItem();
        }
        private void DisableItem()
        {
            btCancle.Enabled = false;
            btSave.Enabled = false;
            btEdit.Enabled = false;
            tbUnitName.Enabled = false;
        }
        private void EnableItem()
        {
            btSave.Enabled = true;
            btCancle.Enabled = true;
            tbUnitName.Enabled = true;
        }
        private void LoadData()
        {
            dgvCategory.DataSource = Product_DAO.Instance.GetUnitName("");
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategory_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvCategory.Rows.Count; i++)
            {
                dgvCategory.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private int ID;
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            try
            {
                tbUnitName.Text = dgvCategory.Rows[row].Cells[2].Value.ToString();
                ID = Convert.ToInt32(dgvCategory.Rows[row].Cells[1].Value);
                if (e.ColumnIndex == dgvCategory.Columns["dgvButtonDelete"].Index && row >= 0)
                {
                    if(MessageBox.Show("Bạn có chắc muốn xóa đơn vị tính "+tbUnitName.Text+" ?","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if(DataProvider.Instance.ExcuteNunQuery("exec DeleteUnitName @id",new object[] { ID }) > 0)
                        {
                            MessageBox.Show("Xóa thành công !", "Thông báo");
                            LoadData();
                        }
                    }
                }
                btEdit.Enabled = true;
            }
            catch { btEdit.Enabled = false; }
        }

        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            dgvCategory.DataSource = Product_DAO.Instance.GetUnitName(tbSearch.text);
        }

        private bool temp;
        private void btNew_Click(object sender, EventArgs e)
        {
            EnableItem();
            btEdit.Enabled = false;
            btNew.Enabled = false;
            dgvCategory.Enabled = false;
            tbUnitName.Text = "";
            temp = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            EnableItem();
            btEdit.Enabled = false;
            btNew.Enabled = false;
            dgvCategory.Enabled = false;
            temp = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(tbUnitName.Text == "")
            {
                MessageBox.Show("Tên đơn vị không được để trống !", "Thông báo");
            }
            else
            {
                if (temp)
                {
                    if (DataProvider.Instance.ExcuteNunQuery("exec InsertUnitName @unitName ", new object[] { tbUnitName.Text }) > 0)
                    {
                        MessageBox.Show("Thêm thành công !", "Thông báo");
                        LoadData();
                        DisableItem();
                        btNew.Enabled = true;
                        dgvCategory.Enabled = true;
                        tbUnitName.Text = "";
                    }
                }
                else
                {
                    if (DataProvider.Instance.ExcuteNunQuery("exec UpdateUnitName @id , @unitName ", new object[] { ID, tbUnitName.Text }) > 0)
                    {
                        MessageBox.Show("Cập nhật thành công !", "Thông báo");
                        LoadData();
                        DisableItem();
                        btNew.Enabled = true;
                        dgvCategory.Enabled = true;
                        tbUnitName.Text = "";
                    }
                }
            }
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            DisableItem();
            btNew.Enabled = true;
            dgvCategory.Enabled = true;
            tbUnitName.Text = "";
        }
    }
}
