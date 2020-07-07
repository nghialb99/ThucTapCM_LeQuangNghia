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
    public partial class FrmOverviews : Form
    {
        public FrmOverviews()
        {
            InitializeComponent();
        }
        private void FrmTongQuan_Load(object sender, EventArgs e)
        {
            dgvTopSP.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvTopSP.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgvTopSP.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvTopSP.DefaultCellStyle.SelectionForeColor = Color.Red;
            fillChart();
            loadData();
        }
        private void loadData()
        {
            CultureInfo culture = new CultureInfo("vi-VN");

            dgvTopSP.DataSource = Invoice_DAO.Instance.GetTopSPThisMonth();
            //dgvTopSP.AutoResizeColumns();

            dgvTopSP.Columns[0].Width = 30;
            dgvTopSP.Columns[1].Width = 140;
            dgvTopSP.Columns[2].Width = 80;
            dgvTopSP.Columns[2].Width = 80;

            label11.Text = ("Biểu đồ doanh số năm: " + DateTime.Now.Year).ToString();
            lbTotalAmount.Text = Invoice_DAO.Instance.GetTotalThisMonth().ToString("c0", culture);
            lbDSThangNay.Text = "Tháng này: " + lbTotalAmount.Text;
            lbDSThangTruoc.Text = "Tháng trước: " + Invoice_DAO.Instance.GetTotalLastMonth().ToString("c0", culture);
            tbHDThangNay.Text = "Tháng này: " + Invoice_DAO.Instance.GetTotalBillThisMonth().ToString();
            lbHDThangTruoc.Text = "Tháng trước: " + Invoice_DAO.Instance.GetTotalBillLastMonth().ToString();
            lbDSHomNay.Text = "Doanh số: " + Invoice_DAO.Instance.GetTotalAmountThisDay().ToString("c0", culture);
            lbHDHomNay.Text = "Hóa đơn: " + Invoice_DAO.Instance.GetTotalBillThisDay().ToString();
            lbSPHetHanThangToi.Text = "Tháng tới: " + Invoice_DAO.Instance.SoThuocSapHetHanThangSau().ToString();
            lbSPHetHanThangNay.Text = "Tháng này: " + Invoice_DAO.Instance.SoThuocSapHetHanThangNay().ToString();
        }
        private void fillChart()
        {
            //chart1.Series["Doanh số"].Points.AddXY("T 1", "2000000");
            //chart1.Series["Doanh số"].Points.AddXY("T 2", "2500000");
            //chart1.Series["Doanh số"].Points.AddXY("T 3", "7000000");
            //chart1.Series["Doanh số"].Points.AddXY("T 4", "1900000");
            //chart1.Series["Doanh số"].Points.AddXY("T 5", "8500000");
            //chart1.Series["Doanh số"].Points.AddXY("T 6", "0");
            //chart1.Series["Doanh số"].Points.AddXY("T 7", "0");
            //chart1.Series["Doanh số"].Points.AddXY("T 8", "0");
            //chart1.Series["Doanh số"].Points.AddXY("T 9", "0");
            //chart1.Series["Doanh số"].Points.AddXY("T 10","0");
            //chart1.Series["Doanh số"].Points.AddXY("T 11","0");
            //chart1.Series["Doanh số"].Points.AddXY("T 12","0");
            // Tên biểu đồ 
            chart1.Titles.Add("Biểu đồ doanh số");

            chart1.DataSource = Invoice_DAO.Instance.GetTotalMonthOnYear();

            chart1.Series["Doanh số"].XValueMember = "Thang";

            chart1.Series["Doanh số"].YValueMembers = "TT";
        }

        private void dgvTopSP_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for(int i = 0; i < dgvTopSP.Rows.Count; i++)
            {
                dgvTopSP.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
