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

namespace API_QuanLyNhaThuoc
{
    public partial class UserCrtReportMailDelivery : UserControl
    {
        public UserCrtReportMailDelivery()
        {
            InitializeComponent();
        }

        private void UserCrtReportMailDelivery_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            dateTimeFrom.Value = new DateTime(date.Year, date.Month, 1);
            dateTimeTo.Value = date;//new DateTime(date.Year, date.Month, date.Day, date.Hour,date.Minute,date.Second);//dateTimeFrom.Value.AddMonths(1).AddDays(-1);

            dgvListMailDelivery.AutoGenerateColumns = false;
            dgvListMailDelivery.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvListMailDelivery.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListMailDelivery.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvListMailDelivery.DefaultCellStyle.SelectionForeColor = Color.Black;

            lbTotalEmailDeliveryThisMonth.Text = "Tháng này: " + Email_DAO.Instance.GetTotalMailDeliveryThisMonth();
            lbTotalEmailDeliveryLastMonth.Text = "Tháng trước: " + Email_DAO.Instance.GetTotalMailDeliveryLastMonth();
            lbTotalBillThisDay.Text = "Hóa đơn: " + Invoice_DAO.Instance.GetTotalBillThisDay().ToString();
            lbTotalEmailDeliveryThisDay.Text = "Lần gửi: " + Email_DAO.Instance.GetTotalMailDeliveryThisDay();
        }

        private void dgvListMailDelivery_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvListMailDelivery.Rows.Count; i++)
            {
                dgvListMailDelivery.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void SetColorRowWhenBillStatusIsDelete()
        {
            for (int i = 0; i < dgvListMailDelivery.Rows.Count; i++)
            {
                DataGridViewRow row = dgvListMailDelivery.Rows[i];

                if (dgvListMailDelivery.Rows[i].Cells[5].Value.ToString() == "Thất bại")
                {
                    dgvListMailDelivery.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void btFilter_Click(object sender, EventArgs e)
        {
            dgvListMailDelivery.DataSource = Email_DAO.Instance.GetListMailDelivery(dateTimeFrom.Value, dateTimeTo.Value);
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
                worksheet.Cells[1, 4] = "BẢNG THỐNG KÊ LỊCH SỬ GỬI MAIL";
                worksheet.Cells[2, 3] = "";
                worksheet.Cells[3, 1] = "STT";
                worksheet.Cells[3, 2] = "Người nhận";
                worksheet.Cells[3, 3] = "Tên người mua";
                worksheet.Cells[3, 4] = "Số hóa đơn";
                worksheet.Cells[3, 5] = "Ngày gửi";
                worksheet.Cells[3, 6] = "Trạng thái";
                worksheet.Cells[3, 7] = "Chi tiết lỗi";

                for (int i = 0; i < dgvListMailDelivery.Rows.Count; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        //worksheet.Cells[i + 4, 1] = i + 1;
                        worksheet.Cells[i + 4, j + 1] ="'"+ dgvListMailDelivery.Rows[i].Cells[j].Value;
                    }
                }
                int dem = dgvListMailDelivery.Rows.Count;


                //dinh dạng trang
                worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
                worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
                worksheet.PageSetup.LeftMargin = 0;
                worksheet.PageSetup.RightMargin = 0;
                worksheet.PageSetup.TopMargin = 0;
                worksheet.PageSetup.BottomMargin = 0;

                //dinh dạng cot

                worksheet.Range["A1"].ColumnWidth = 8;
                worksheet.Range["B1"].ColumnWidth = 50;
                worksheet.Range["C1"].ColumnWidth = 80;
                worksheet.Range["D1"].ColumnWidth = 30;
                worksheet.Range["E1"].ColumnWidth = 40;
                worksheet.Range["F1"].ColumnWidth = 20;
                worksheet.Range["G1"].ColumnWidth = 100;


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
                //worksheet.Range["E4", "E" + (dem + 4)].HorizontalAlignment = 3;
                worksheet.Range["F4", "F" + (dem + 4)].HorizontalAlignment = 3;
                //worksheet.Range["G4", "G" + (dem + 4)].HorizontalAlignment = 3;
                //worksheet.Range["H4", "H" + (dem + 4)].HorizontalAlignment = 3;
                //worksheet.Range["I4", "I" + (dem + 4)].HorizontalAlignment = 3;

                //   workbook.Save();
            }
            catch { }
        }
    }
}
