using API_QuanLyNhaThuoc.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_QuanLyNhaThuoc
{
    public partial class FrmImportInventory : Form
    {
        public FrmImportInventory()
        {
            InitializeComponent();
        }

        private void FrmImportInventory_Load(object sender, EventArgs e)
        {
            dgvListInvoice.AutoGenerateColumns = false;
            dgvListInvoice.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvListInvoice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListInvoice.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvListInvoice.DefaultCellStyle.SelectionForeColor = Color.Black;
            LoadData();
            dgvListInvoice.DataSource = ImportInventory_DAO.Instance.GetFullListImportGoods("//SetColorRowWhenBillStatusIsDelete();");
        }
        private void LoadData()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            lbPNThangNay.Text = "Tháng này: " + ImportInventory_DAO.Instance.GetTotalImprtBillThisMonth().ToString();
            lbPNThangTruoc.Text = "Tháng trước: " + ImportInventory_DAO.Instance.GetTotalImprtBillLastMonth().ToString();
            lbTCThangNay.Text = "Tháng này: " + ImportInventory_DAO.Instance.GetTotalSpendThisMonth().ToString("c0", culture);
            lbTCThangTruoc.Text = "Tháng trước: " + ImportInventory_DAO.Instance.GetTotalSpendLastMonth().ToString("c0", culture);

            lbIdImportBill.Text = DataProvider.Instance.ExcuteScalar("exec AutoKeyPNT").ToString();
            dgvListInvoice.DataSource = ImportInventory_DAO.Instance.GetFullListImportGoods("");
            SetColorRowWhenBillStatusIsDelete();
            rtbNote.Text = "";
            lbCreator.Text = Account_DAO.Instance.GetUserAccount(FrmLogin.username).UserDisplayName;
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbNotification.Text = "";
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
                }
                else
                {
                    if (e.ColumnIndex == dgvListInvoice.Columns["dgvButtonImport"].Index && row >= 0 && ImportInventory_DAO.Instance.CheckIsImportInventoryDone(idBill) == false && ImportInventory_DAO.Instance.CheckUserCreateImportInventory(idBill, FrmLogin.username))
                    {
                        FrmImportDetailProduct f = new FrmImportDetailProduct(LoadData, idBill);
                        f.ShowDialog();
                    }
                    else
                    {
                        if (e.ColumnIndex == dgvListInvoice.Columns["gdvButtonDelete"].Index && row >= 0)
                        {
                            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu nhập tồn: " + idBill + " ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                if (ImportInventory_DAO.Instance.DeleteImprortBill(idBill))
                                {
                                    MessageBox.Show("Xóa phiếu nhập tồn: " + idBill + " thành công !");
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
        private void btCreateInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = FrmLogin.username;
                float totalAmount = 0;
                string note = rtbNote.Text;

                if (ImportInventory_DAO.Instance.InsertImprortBill(userName, totalAmount, note))
                {
                    LoadData();
                    lbNotification.Text = "Thêm phiếu nhập tồn dự thảo thành công !";
                    i = 5;
                    timer1.Enabled = true;
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
        private void SetColorRowWhenBillStatusIsDelete()
        {
            for (int i = 0; i < dgvListInvoice.Rows.Count; i++)
            {
                if (dgvListInvoice.Rows[i].Cells[7].Value.ToString() == "Xóa bỏ")
                {
                    dgvListInvoice.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (dgvListInvoice.Rows[i].Cells[7].Value.ToString() == "Dự thảo")
                {
                    dgvListInvoice.Rows[i].DefaultCellStyle.ForeColor = Color.FromArgb(248, 207, 1);
                }
            }
        }

        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            dgvListInvoice.DataSource = ImportInventory_DAO.Instance.GetFullListImportGoods(tbSearch.text);
            SetColorRowWhenBillStatusIsDelete();
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            dgvListInvoice.DataSource = ImportInventory_DAO.Instance.GetFullListImportGoods(tbSearch.text);
            SetColorRowWhenBillStatusIsDelete();
        }
    }
}
