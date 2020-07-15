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
    public partial class FrmImportFromSupplier : Form
    {
        public FrmImportFromSupplier()
        {
            InitializeComponent();
        }

        private void btNewSupplier_Click(object sender, EventArgs e)
        {
            FrmSupplier f = new FrmSupplier(LoadSupplierinfo);
            f.ShowDialog();
        }

        private void FrmImportFromSupplier_Load(object sender, EventArgs e)
        {
            dgvListInvoice.AutoGenerateColumns = false;
            dgvListInvoice.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvListInvoice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListInvoice.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvListInvoice.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvListInvoice.DataSource = ImportBill_DAO.Instance.GetFullListImportGoods("//SetColorRowWhenBillStatusIsDelete();");
            
            LoadSupplierinfo();
            LoadSellerInfo(Account_DAO.Instance.CheckUsername());

            rbtSupplier.Checked = true;
            dgvSupplier.Visible = false;
            dgvSupplier.AutoGenerateColumns = false;
            dgvSupplier.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvSupplier.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSupplier.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvSupplier.DefaultCellStyle.SelectionForeColor = Color.Black;

            dateTimeCreate.Value = DateTime.Now;
        }
        private void SetColorRowWhenBillStatusIsDelete()
        {
            for (int i = 0; i < dgvListInvoice.Rows.Count; i++)
            {
                if (dgvListInvoice.Rows[i].Cells[9].Value.ToString() == "Xóa bỏ")
                {
                    dgvListInvoice.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }else if (dgvListInvoice.Rows[i].Cells[9].Value.ToString() == "Dự thảo")
                {
                    dgvListInvoice.Rows[i].DefaultCellStyle.ForeColor = Color.FromArgb(248, 207, 1);
                }
            }
        }
        private void LoadData()
        {
            lbIdImportBill.Text = DataProvider.Instance.ExcuteScalar("exec AutoKeyPN").ToString();
            dgvListInvoice.DataSource = ImportBill_DAO.Instance.GetFullListImportGoods("");
            SetColorRowWhenBillStatusIsDelete();
            rtbNote.Text = "";
            nbVatRate.Value = 0;
            dateTimeCreate.Value = DateTime.Now;
        }
        private void LoadSellerInfo(string user)
        {
            List<EnterpriseInfo> data = EnterpriseInfo_DAO.Instance.LoadEnterpriseInfo(user);
            lbSellerLegalName.Text = data[0].EnterpriseName.ToString();
            lbSellerTaxCode.Text = data[0].EnterpriseTaxCode.ToString();
            lbSellerAddress.Text = data[0].EnterpriseAddress.ToString();
            lbSellerPhoneNumber.Text = data[0].EnterprisePhone.ToString();
            lbSellerEmail.Text = data[0].EnterpriseEmail.ToString();
            //lbCreator.Text = DataProvider.Instance.ExcuteScalar("select HoTen from nhanvien where username ='" +FrmLogin.username+"'").ToString();
            lbCreator.Text = Account_DAO.Instance.GetUserAccount(FrmLogin.username).UserDisplayName;
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbIdImportBill.Text = DataProvider.Instance.ExcuteScalar("exec AutoKeyPN").ToString();
            lbNotification.Text = "";
        }
        private void LoadSupplierinfo()
        {
            cbSupplierTaxCode.ValueMember = "TaxCode";
            cbSupplierTaxCode.DisplayMember = "Name";
            cbSupplierTaxCode.DataSource = Supplier_DAO.Instance.GetListSupplier("");
        }
        private void dgvListInvoice_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvListInvoice.Rows.Count; i++)
            {
                dgvListInvoice.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private static string idBill = "";
        private void dgvListInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            try
            {
                idBill = dgvListInvoice.Rows[row].Cells[3].Value.ToString();
                if (e.ColumnIndex == dgvListInvoice.Columns["dgvButtonView"].Index && row >= 0)
                {
                    FrmDetailImportBill f = new FrmDetailImportBill(idBill);
                    f.ShowDialog();
                }else
                {
                    if(e.ColumnIndex == dgvListInvoice.Columns["dgvButtonImport"].Index && row >= 0 && Supplier_DAO.Instance.CheckIsImportBillDone(idBill)==false && ImportBill_DAO.Instance.CheckUserCreateImportBill(idBill, FrmLogin.username))
                    {
                        FrmImportDetailProduct f = new FrmImportDetailProduct(LoadData,idBill);
                        f.ShowDialog();
                    }
                    else
                    {
                        if(e.ColumnIndex == dgvListInvoice.Columns["gdvButtonDelete"].Index && row >= 0)
                        {
                            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập: " + idBill + " ?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                if (ImportBill_DAO.Instance.DeleteImprortBill(idBill))
                                {
                                    MessageBox.Show("Xóa phiếu nhập: "+idBill+" thành công !");
                                    LoadData();
                                }
                                else
                                {
                                    lbNotification.Text = "Lỗi kết nối. Vui lòng thử lại sau !";
                                    i = 5;
                                    timer1.Enabled = true;
                                }
                            }
                        }
                    }
                }
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void cbSupplierTaxCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier data = Supplier_DAO.Instance.GetSupplierById(cbSupplierTaxCode.SelectedValue.ToString());
            lbSupplierTaxCode.Text = data.TaxCode;
            lbBuyerAddress.Text = data.Addr;
            lbBuyerEmail.Text = data.Email;
            lbBuyerPhone.Text = data.Phone;
        }

        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            if (rbtSupplier.Checked)
            {
                if(tbSearch.text == "")
                {
                    dgvSupplier.Visible = false;
                }
                else
                {
                    dgvSupplier.Visible = true;
                    dgvSupplier.DataSource = Supplier_DAO.Instance.GetSupplierWhenImportProduct(tbSearch.text);
                }
            }
            else
            {
                dgvListInvoice.DataSource = ImportBill_DAO.Instance.GetFullListImportGoods(tbSearch.text);
                SetColorRowWhenBillStatusIsDelete();
            }
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            dgvListInvoice.DataSource = ImportBill_DAO.Instance.GetFullListImportGoods(tbSearch.text);
            SetColorRowWhenBillStatusIsDelete();
        }

        private void rbtSupplier_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSupplier.Checked)
            {
                rbtImportBill.Checked = false;
            }
        }

        private void rbtImportBill_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtImportBill.Checked)
            {
                rbtSupplier.Checked = false;
                dgvSupplier.Visible = false;
            }
        }
        private string SuppliertaxCode;
        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SuppliertaxCode = dgvSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbSupplierTaxCode.SelectedValue = SuppliertaxCode;
                tbSearch.text = "";
            }
            catch { }
        }

        private void btCreateInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dateTimeCreate.Value;
                string userName = FrmLogin.username;
                string SupplierTaxCode = cbSupplierTaxCode.SelectedValue.ToString();
                int vat = (int)nbVatRate.Value;
                float totalAmount = 0;
                string note = rtbNote.Text;
                if (DateTime.Compare(date,DateTime.Now)==1)
                {
                    lbNotification.Text = "Ngày nhập không được lớn hơn ngày hiện tại !";
                    i = 5;
                    timer1.Enabled = true;
                }
                else
                {
                    if (ImportBill_DAO.Instance.InsertImprortBill(date, userName, SupplierTaxCode, vat, totalAmount, note))
                    {
                        lbNotification.Text = "Thêm phiếu nhập dự thảo thành công !";
                        i = 5;
                        timer1.Enabled = true;
                        LoadData();
                    }
                }
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        private int i = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            if (i == 0) { lbNotification.Text = ""; timer1.Enabled = false; }
        }
    }
}
