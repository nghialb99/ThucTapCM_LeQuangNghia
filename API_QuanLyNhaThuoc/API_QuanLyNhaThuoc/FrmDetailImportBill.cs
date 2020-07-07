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
    public partial class FrmDetailImportBill : Form
    {
        public FrmDetailImportBill()
        {
            InitializeComponent();
        }
        public FrmDetailImportBill(string getIdBill)
        {
            InitializeComponent();
            //GetIdBill = getIdBill;
            dgvListInvoice.AutoGenerateColumns = false;
            dgvListInvoice.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvListInvoice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListInvoice.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvListInvoice.DefaultCellStyle.SelectionForeColor = Color.Black;

            label1.Text = getIdBill;
            dgvListInvoice.DataSource = DataProvider.Instance.ExcuteQuery("EXEC GetDetailImportBill @IdBill ", new object[] { getIdBill });
        }
        private void FrmDetailImportBill_Load(object sender, EventArgs e)
        {
            dgvListInvoice.AutoGenerateColumns = false;
            dgvListInvoice.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvListInvoice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListInvoice.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvListInvoice.DefaultCellStyle.SelectionForeColor = Color.Black;

            //label1.Text = UserCrtReportBuy.idBill;
            //dgvListInvoice.DataSource = DataProvider.Instance.ExcuteQuery("EXEC GetDetailImportBill @IdBill ", new object[] { UserCrtReportBuy.idBill });
        }
        private void dgvListInvoice_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvListInvoice.Rows.Count -1; i++)
            {
                dgvListInvoice.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
