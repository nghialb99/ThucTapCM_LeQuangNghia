using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API_QuanLyNhaThuoc.DAO;
using System.Globalization;

namespace API_QuanLyNhaThuoc
{
    public partial class UserCrtReportBuy : UserControl
    {
        public UserCrtReportBuy()
        {
            InitializeComponent();
        }

        private void UserCrtReportBuy_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dateTimeFrom.Value = new DateTime(date.Year, date.Month, 1);
            dateTimeTo.Value = dateTimeFrom.Value.AddMonths(1).AddDays(-1);

            dgvListInvoice.AutoGenerateColumns = false;
            dgvListInvoice.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvListInvoice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListInvoice.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvListInvoice.DefaultCellStyle.SelectionForeColor = Color.Black;

            CultureInfo culture = new CultureInfo("vi-VN");
            lbPNThangNay.Text = "Tháng này: " + ImportBill_DAO.Instance.GetTotalImprtBillThisMonth().ToString();
            lbPNThangTruoc.Text = "Tháng trước: " + ImportBill_DAO.Instance.GetTotalImprtBillLastMonth().ToString();
            lbTCThangNay.Text = "Tháng này: " + ImportBill_DAO.Instance.GetTotalSpendThisMonth().ToString("c0", culture);
            lbTCThangTruoc.Text = "Tháng trước: " + ImportBill_DAO.Instance.GetTotalSpendLastMonth().ToString("c0", culture);
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            dgvListInvoice.DataSource = ImportBill_DAO.Instance.GetListImportGoods(dateTimeFrom.Value, dateTimeTo.Value);
            SetColorRowWhenBillStatusIsDelete();
        }
        private void btExportToExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //khoi tao excel
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                //khoi tao workbook
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                // khoi tao worksheet
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;
                //dua du lieu
                worksheet.Cells[1, 4] = "BẢNG THỐNG KÊ PHIẾU NHẬP HÀNG";
                worksheet.Cells[2, 3] = "";
                worksheet.Cells[3, 1] = "STT";
                worksheet.Cells[3, 2] = "Mã phiếu nhập";
                worksheet.Cells[3, 3] = "Ngày lập";
                worksheet.Cells[3, 4] = "Người lập";
                worksheet.Cells[3, 5] = "Nhà cung cấp";
                worksheet.Cells[3, 6] = "VAT %";
                worksheet.Cells[3, 7] = "Tổng tiền";
                worksheet.Cells[3, 8] = "Trạng thái";
                worksheet.Cells[3, 9] = "Ghi chú";

                for (int i = 0; i < dgvListInvoice.Rows.Count; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        //worksheet.Cells[i + 4, 1] = i + 1;
                        worksheet.Cells[i + 4, j + 1] = dgvListInvoice.Rows[i].Cells[j].Value;
                    }
                }
                int dem = dgvListInvoice.Rows.Count;


                //dinh dạng trang
                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
                worksheet.PageSetup.LeftMargin = 0;
                worksheet.PageSetup.RightMargin = 0;
                worksheet.PageSetup.TopMargin = 0;
                worksheet.PageSetup.BottomMargin = 0;

                //dinh dạng cot

                worksheet.Range["A1"].ColumnWidth = 8;
                worksheet.Range["B1"].ColumnWidth = 16.14;
                worksheet.Range["C1"].ColumnWidth = 20.29;
                worksheet.Range["D1"].ColumnWidth = 30;
                worksheet.Range["E1"].ColumnWidth = 60;
                worksheet.Range["F1"].ColumnWidth = 15;
                worksheet.Range["G1"].ColumnWidth = 26.71;
                worksheet.Range["H1"].ColumnWidth = 17;
                worksheet.Range["I1"].ColumnWidth = 60;


                // dinh dang chữ
                worksheet.Range["A1", "I1000"].Font.Name = "Times New Roman";
                worksheet.Range["A1", "I1"].Font.Size = 24;
                worksheet.Range["A3", "I100"].Font.Size = 16;
                worksheet.Range["A1", "I1"].MergeCells = true;
                worksheet.Range["A1", "I1"].Font.Bold = true;
                worksheet.Range["A3", "I3"].Font.Bold = true;

                // kẻ bảng
                worksheet.Range["A3", "I" + (dem + 3)].Borders.LineStyle = 1;
                // dinh dạng text

                worksheet.Range["A1", "I1"].HorizontalAlignment = 3;
                worksheet.Range["A3", "I3"].HorizontalAlignment = 3;
                worksheet.Range["A4", "A" + (dem + 4)].HorizontalAlignment = 3;
                worksheet.Range["D4", "D" + (dem + 4)].HorizontalAlignment = 3;
                worksheet.Range["E4", "E" + (dem + 4)].HorizontalAlignment = 3;
                worksheet.Range["F4", "F" + (dem + 4)].HorizontalAlignment = 3;
                worksheet.Range["G4", "G" + (dem + 4)].HorizontalAlignment = 3;
                worksheet.Range["H4", "H" + (dem + 4)].HorizontalAlignment = 3;
                worksheet.Range["I4", "I" + (dem + 4)].HorizontalAlignment = 3;

                //   workbook.Save();
            }
            catch { }
        }
        private void dgvListInvoice_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvListInvoice.Rows.Count; i++)
            {
                dgvListInvoice.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void SetColorRowWhenBillStatusIsDelete()
        {
            for (int i = 0; i < dgvListInvoice.Rows.Count; i++)
            {
                DataGridViewRow row = dgvListInvoice.Rows[i];

                if (dgvListInvoice.Rows[i].Cells[7].Value.ToString() == "Xóa bỏ")
                {
                    dgvListInvoice.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        public static string idBill = "";
        private void dgvListInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            try
            {
                idBill = dgvListInvoice.Rows[row].Cells[1].Value.ToString();
                if (e.ColumnIndex == dgvListInvoice.Columns["dgvButtonView"].Index && row >= 0)
                {
                    FrmDetailImportBill f = new FrmDetailImportBill(idBill);
                    f.ShowDialog();
                }
            }
            catch { }
        }
    }
}
