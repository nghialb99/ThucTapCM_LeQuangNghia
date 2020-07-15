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
    public partial class FrmImportDetailProduct : Form
    {
        public FrmImportDetailProduct()
        {
            InitializeComponent();
        }
        private Logout LoadDataWhenExit;
        public FrmImportDetailProduct(Logout lg,string id)
        {
            InitializeComponent();
            LoadDataWhenExit = lg;

            label1.Text = id;
        }
        private void FrmImportDetailProduct_Load(object sender, EventArgs e)
        {
            dgvListInvoice.AutoGenerateColumns = false;
            dgvListInvoice.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvListInvoice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListInvoice.DefaultCellStyle.SelectionBackColor = Color.Cyan;
            dgvListInvoice.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvSearchProduct.AutoGenerateColumns = false;
            dgvSearchProduct.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvSearchProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSearchProduct.DefaultCellStyle.SelectionBackColor = Color.Cyan;
            dgvSearchProduct.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvSearchProduct.Visible = false;

            LoadData();
            ResetValues();
        }
        private void LoadData()
        {
            cbCategoryProduct.ValueMember = "RoleCode";
            cbCategoryProduct.DisplayMember = "RoleName";
            cbCategoryProduct.DataSource = Category_DAO.Instance.GetListCategoryProduct("");
        }
        private void ResetValues()
        {
            tbName.Text = "";
            cbCategoryProduct.Text = "";
            tbDosage.Text = "";
            tbFrom.Text = "";
            tbPackagingSpecifications.Text = "";
            tbExchangeValue.Text = "0";
            tbUnitName.Text = "";
            tbBatchNo.Text = "";
            tbManDate.Value = DateTime.Now;
            tbExpDate.Value = DateTime.Now;
            tbUnitNameImport.Text = "";
            tbUnitPriceImport.Text = "0";
            tbQuantityImport.Text = "0";
        }

        private bool IsImportFromSupplier()
        {
            return label1.Text.IndexOf("NT") == -1;
        }
        private void dgvListInvoice_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvListInvoice.Rows.Count - 1; i++)
            {
                dgvListInvoice.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            int row = dgvListInvoice.Rows.Count-1;

            if (tbName.Text == "" || cbCategoryProduct.Text == "" || tbDosage.Text == "" || tbFrom.Text == "" || tbPackagingSpecifications.Text == "" || tbExchangeValue.Text == "" || tbUnitName.Text == "" || tbBatchNo.Text == "" || tbUnitNameImport.Text == "" || tbUnitPriceImport.Text == "" || tbQuantityImport.Text == "")
            {
                MessageBox.Show("Các trường bắt buộc không được để trống !","Thông báo");
            }
            else
            {
                if (Convert.ToInt32(tbExchangeValue.Text)==0)
                {
                    MessageBox.Show("Giá trị quy đổi không hợp lệ !","Thông báo");
                }
                else
                {
                    if(Convert.ToInt32(tbQuantityImport.Text) == 0)
                    {
                        MessageBox.Show("Số lượng nhập không hợp lệ !","Thông báo");
                    }
                    else
                    {
                        if (tbExpDate.Value < DateTime.Now || tbManDate.Value > DateTime.Now || tbExpDate.Value < tbManDate.Value)
                        {
                            MessageBox.Show("Ngày sản xuất và hạn sử dụng không hợp lệ !","Thông báo");
                        }
                        else
                        {
                            dgvListInvoice.Rows.Add();
                            dgvListInvoice.Rows[row].Cells[1].Value = tbName.Text;
                            dgvListInvoice.Rows[row].Cells[2].Value = cbCategoryProduct.SelectedValue;
                            dgvListInvoice.Rows[row].Cells[3].Value = tbDosage.Text;
                            dgvListInvoice.Rows[row].Cells[4].Value = tbFrom.Text;
                            dgvListInvoice.Rows[row].Cells[5].Value = tbPackagingSpecifications.Text;
                            dgvListInvoice.Rows[row].Cells[6].Value = tbExchangeValue.Text;
                            dgvListInvoice.Rows[row].Cells[7].Value = tbUnitName.Text;
                            dgvListInvoice.Rows[row].Cells[8].Value = tbBatchNo.Text;
                            dgvListInvoice.Rows[row].Cells[9].Value = tbManDate.Value;
                            dgvListInvoice.Rows[row].Cells[10].Value = tbExpDate.Value;
                            dgvListInvoice.Rows[row].Cells[11].Value = tbUnitNameImport.Text;
                            dgvListInvoice.Rows[row].Cells[12].Value = tbQuantityImport.Text;
                            dgvListInvoice.Rows[row].Cells[13].Value = Convert.ToDouble(tbUnitPriceImport.Text);
                            
                            //UnitPriceImport = (float)Convert.ToDouble(tbUnitPriceImport.Text);
                        }
                    }
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(dgvListInvoice.Rows.Count == 1)
            {
                MessageBox.Show("Bản chi tiết sản phẩm không được để trống !", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (IsImportFromSupplier())
                {
                    int t = 0;
                    try
                    {
                        for (int i = 0; i < dgvListInvoice.Rows.Count - 1; i++)
                        {
                            string ISName = dgvListInvoice.Rows[i].Cells[1].Value.ToString();
                            string ISCategoryProduct = dgvListInvoice.Rows[i].Cells[2].Value.ToString();
                            string ISDosage = dgvListInvoice.Rows[i].Cells[3].Value.ToString();
                            string ISFrom = dgvListInvoice.Rows[i].Cells[4].Value.ToString();
                            string ISPackagingSpecifications = dgvListInvoice.Rows[i].Cells[5].Value.ToString();
                            int ISExchangeValue = Convert.ToInt32(dgvListInvoice.Rows[i].Cells[6].Value);
                            string ISUnitName = dgvListInvoice.Rows[i].Cells[7].Value.ToString();
                            string ISBatchNo = dgvListInvoice.Rows[i].Cells[8].Value.ToString();
                            DateTime ISManDate = Convert.ToDateTime(dgvListInvoice.Rows[i].Cells[9].Value);
                            DateTime ISExpDate = Convert.ToDateTime(dgvListInvoice.Rows[i].Cells[10].Value);
                            string ISUnitNameImport = dgvListInvoice.Rows[i].Cells[11].Value.ToString();
                            int ISQuantityImport = Convert.ToInt32(dgvListInvoice.Rows[i].Cells[12].Value);
                            float ISUnitPriceImport = (float)Convert.ToDouble(dgvListInvoice.Rows[i].Cells[13].Value);
                            string ISImportBillId = label1.Text;

                            t += ImportBill_DAO.Instance.InsertImprortDetailBill(ISName, ISCategoryProduct, ISDosage, ISFrom, ISPackagingSpecifications, ISExchangeValue, ISUnitName, ISBatchNo, ISManDate, ISExpDate, ISUnitNameImport, ISUnitPriceImport, ISQuantityImport, ISImportBillId);
                        }
                        if (t > 0)
                        {
                            MessageBox.Show("Lưu thành công! ", "Thông báo", MessageBoxButtons.OK);
                            LoadDataWhenExit();
                            this.Close();
                        }
                        else { MessageBox.Show("Lỗi kết nối! Vui lòng kiểm tra lại kết nối trước khi thao tác!", "Thông báo"); }
                    }
                    catch { MessageBox.Show("Lỗi kết nối! Vui lòng kiểm tra lại kết nối trước khi thao tác!", "Thông báo"); }
                }
                else
                {
                    int t = 0;
                    try
                    {
                        for (int i = 0; i < dgvListInvoice.Rows.Count - 1; i++)
                        {
                            string ISName = dgvListInvoice.Rows[i].Cells[1].Value.ToString();
                            string ISCategoryProduct = dgvListInvoice.Rows[i].Cells[2].Value.ToString();
                            string ISDosage = dgvListInvoice.Rows[i].Cells[3].Value.ToString();
                            string ISFrom = dgvListInvoice.Rows[i].Cells[4].Value.ToString();
                            string ISPackagingSpecifications = dgvListInvoice.Rows[i].Cells[5].Value.ToString();
                            int ISExchangeValue = Convert.ToInt32(dgvListInvoice.Rows[i].Cells[6].Value);
                            string ISUnitName = dgvListInvoice.Rows[i].Cells[7].Value.ToString();
                            string ISBatchNo = dgvListInvoice.Rows[i].Cells[8].Value.ToString();
                            DateTime ISManDate = Convert.ToDateTime(dgvListInvoice.Rows[i].Cells[9].Value);
                            DateTime ISExpDate = Convert.ToDateTime(dgvListInvoice.Rows[i].Cells[10].Value);
                            string ISUnitNameImport = dgvListInvoice.Rows[i].Cells[11].Value.ToString();
                            int ISQuantityImport = Convert.ToInt32(dgvListInvoice.Rows[i].Cells[12].Value);
                            float ISUnitPriceImport = (float)Convert.ToDouble(dgvListInvoice.Rows[i].Cells[13].Value);
                            string ISImportBillId = label1.Text;

                            t += ImportInventory_DAO.Instance.InsertImprortDetailBill(ISName, ISCategoryProduct, ISDosage, ISFrom, ISPackagingSpecifications, ISExchangeValue, ISUnitName, ISBatchNo, ISManDate, ISExpDate, ISUnitNameImport, ISUnitPriceImport, ISQuantityImport, ISImportBillId);
                        }
                        if (t > 0)
                        {
                            MessageBox.Show("Lưu thành công! ", "Thông báo", MessageBoxButtons.OK);
                            LoadDataWhenExit();
                            this.Close();
                        }
                        else { MessageBox.Show("Lỗi kết nối! Vui lòng kiểm tra lại kết nối trước khi thao tác!", "Thông báo"); }
                    }
                    catch { MessageBox.Show("Lỗi kết nối! Vui lòng kiểm tra lại kết nối trước khi thao tác!", "Thông báo"); }
                }
            }
        }

        private void dgvListInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            try
            {
                if(e.ColumnIndex == dgvListInvoice.Columns["dgvButtonEdit"].Index && row >= 0)
                {
                    tbName.Text = dgvListInvoice.Rows[row].Cells[1].Value.ToString();
                    cbCategoryProduct.SelectedValue = dgvListInvoice.Rows[row].Cells[2].Value.ToString();
                    tbDosage.Text = dgvListInvoice.Rows[row].Cells[3].Value.ToString();
                    tbFrom.Text = dgvListInvoice.Rows[row].Cells[4].Value.ToString();
                    tbPackagingSpecifications.Text = dgvListInvoice.Rows[row].Cells[5].Value.ToString();
                    tbExchangeValue.Text = dgvListInvoice.Rows[row].Cells[6].Value.ToString();
                    tbUnitName.Text = dgvListInvoice.Rows[row].Cells[7].Value.ToString();
                    tbBatchNo.Text = dgvListInvoice.Rows[row].Cells[8].Value.ToString();
                    tbManDate.Value = Convert.ToDateTime(dgvListInvoice.Rows[row].Cells[9].Value);
                    tbExpDate.Value = Convert.ToDateTime(dgvListInvoice.Rows[row].Cells[10].Value);
                    tbUnitNameImport.Text = dgvListInvoice.Rows[row].Cells[11].Value.ToString();
                    tbQuantityImport.Text = dgvListInvoice.Rows[row].Cells[12].Value.ToString();
                    tbUnitPriceImport.Text = dgvListInvoice.Rows[row].Cells[13].Value.ToString();
                    dgvListInvoice.Rows.RemoveAt(row);
                }
                else
                {
                    if(e.ColumnIndex == dgvListInvoice.Columns["dgvButtonDelete"].Index && row >= 0)
                    {
                        dgvListInvoice.Rows.RemoveAt(row);
                    }
                }
            }
            catch { }
        }

        private void tbQuantityImport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void tbQuantityImport_Leave(object sender, EventArgs e)
        {
            try{Convert.ToInt32(tbQuantityImport.Text);} catch { tbQuantityImport.Text = "0"; }
        }

        private void tbUnitPriceImport_Leave(object sender, EventArgs e)
        {
            try { Convert.ToDouble(tbUnitPriceImport.Text); } catch { tbUnitPriceImport.Text = "0"; }
        }

        private void tbExchangeValue_Leave(object sender, EventArgs e)
        {
            try { Convert.ToInt32(tbExchangeValue.Text); } catch { tbExchangeValue.Text = "0"; }
        }

        private void dgvSearchProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idProduct = dgvSearchProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                Product pr = Product_DAO.Instance.GetFullProductById(idProduct);

                tbName.Text = pr.Name;
                cbCategoryProduct.SelectedValue = pr.IdCategory;
                tbDosage.Text = pr.Dosage;
                tbFrom.Text = pr.From;
                tbPackagingSpecifications.Text = pr.PackagingSpecifications;
                tbExchangeValue.Text = pr.ExchangeValue.ToString();
                tbUnitName.Text = pr.UnitName;
                tbBatchNo.Text = pr.BatchNo;
                tbManDate.Value = pr.ManDate;
                tbExpDate.Value = pr.ExpDate;
                tbUnitNameImport.Text = "";
                tbUnitPriceImport.Text = "0";
                tbQuantityImport.Text = "0";

                tbSearch.text = "";
            }
            catch {  }
        }

        private void dgvSearchProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvSearchProduct.Rows.Count; i++)
            {
                dgvSearchProduct.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            if (tbSearch.text == "")
            {
                dgvSearchProduct.Visible = false;
            }
            else
            {
                dgvSearchProduct.Visible = true;
                dgvSearchProduct.DataSource = Product_DAO.Instance.GetListProduct(tbSearch.text);
            }
        }
    }
}
