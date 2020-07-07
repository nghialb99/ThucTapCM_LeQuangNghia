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

            dgvListInvoice.DataSource = ImportGoods_DAO.Instance.GetFullListImportGoods();
            SetColorRowWhenBillStatusIsDelete();
            LoadSupplierinfo();
            LoadSellerInfo(Account_DAO.Instance.CheckUsername());
        }
        private void SetColorRowWhenBillStatusIsDelete()
        {
            for (int i = 0; i < dgvListInvoice.Rows.Count; i++)
            {
                if (dgvListInvoice.Rows[i].Cells[9].Value.ToString() == "Xóa bỏ")
                {
                    dgvListInvoice.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
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
            lbIdBill.Text = DataProvider.Instance.ExcuteScalar("exec AutoKeyPN").ToString();
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
        public static string idBill = "";
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
                    if(e.ColumnIndex == dgvListInvoice.Columns["dgvButtonImport"].Index && row >= 0 && Supplier_DAO.Instance.CheckIsImportBillDone(idBill)==false)
                    {
                        FrmImportDetailProduct f = new FrmImportDetailProduct(idBill);
                        f.ShowDialog();
                    }
                }
            }
            catch { }
        }

        private void cbSupplierTaxCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier data = Supplier_DAO.Instance.GetSupplierById(cbSupplierTaxCode.SelectedValue.ToString());
            tbSupplierTaxCode.Text = data.TaxCode;
            tbBuyerAddress.Text = data.Addr;
            tbBuyerEmail.Text = data.Email;
            tbBuyerPhone.Text = data.Phone;
        }
    }
}
