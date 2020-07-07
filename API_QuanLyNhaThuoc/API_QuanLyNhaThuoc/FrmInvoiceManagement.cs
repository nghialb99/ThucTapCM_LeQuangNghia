using API_QuanLyNhaThuoc.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_QuanLyNhaThuoc
{
    public partial class FrmInvoiceManagement : Form
    {
        public FrmInvoiceManagement()
        {
            InitializeComponent();
        }

        private void FrmInvoiceManagement_Load(object sender, EventArgs e)
        {
            dgvListInvoice.AutoGenerateColumns = false;
            LoadData();
            //màu dòng chẵn
            dgvListInvoice.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvListInvoice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //Mau o khi click
            dgvListInvoice.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //color chữ khi click
            dgvListInvoice.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void LoadData()
        {
            DateTime date = DateTime.Now;
            dateTimeFrom.Value = new DateTime(date.Year, date.Month, 1);
            dateTimeTo.Value = dateTimeFrom.Value.AddMonths(1).AddDays(-1);
            tbSellerTaxcode.Text = Account_DAO.Instance.CheckUsername();
            dgvListInvoice.DataSource = Invoice_DAO.Instance.GetListAllInvoice();
            cbInvoiceStatus.ValueMember = "ID";
            cbInvoiceStatus.DisplayMember = "MOTA";
            cbInvoiceStatus.DataSource = DataProvider.Instance.ExcuteQuery("select * from trangthai order by ID desc");
        }
        private void ResetValue()
        {
            DateTime date = DateTime.Now;
            dateTimeFrom.Value = new DateTime(date.Year, date.Month, 1);
            dateTimeTo.Value = dateTimeFrom.Value.AddMonths(1).AddDays(-1);
            tbBuyerCode.Text = "";
            tbBuyerEmail.Text = "";
            tbBuyerName.Text = "";
            tbBuyerPhone.Text = "";
            tbCreator.Text = "";
            tbInvoiceId.Text = "";
            //cbInvoiceStatus.Text = "";
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
        private void dgvListInvoice_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for(int i = 0; i < dgvListInvoice.Rows.Count; i++)
            {
                dgvListInvoice.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private int row;
        private static int idBill = 0;
        private static string InvoiceNumber = "";
        private void dgvListInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            try
            {
                idBill = Convert.ToInt32(dgvListInvoice.Rows[row].Cells[11].Value);
                InvoiceNumber = dgvListInvoice.Rows[row].Cells[1].Value.ToString();
                if (e.ColumnIndex == dgvListInvoice.Columns["dgvButtonView"].Index && row >= 0)
                {
                    FrmPrintBill f = new FrmPrintBill();
                    f.GetReport(idBill);
                    f.ShowDialog();
                }
                else if(e.ColumnIndex == dgvListInvoice.Columns["dgvButtonDelete"].Index && row >= 0 && 
                    dgvListInvoice.Rows[row].Cells[7].Value.ToString()!="Xóa bỏ")
                {
                    FrmDeleteInvoice f = new FrmDeleteInvoice(LoadData, idBill, InvoiceNumber);
                    f.ShowDialog();
                }
            }
            catch { }
            
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dgvListInvoice.DataSource = Invoice_DAO.Instance.GetListInvoice(tbBuyerEmail.Text, tbBuyerPhone.Text, Convert.ToBoolean(cbInvoiceStatus.SelectedValue), tbInvoiceId.Text, tbCreator.Text, tbBuyerCode.Text, tbBuyerName.Text, dateTimeFrom.Value, dateTimeTo.Value);
            SetColorRowWhenBillStatusIsDelete();
        }

        private void btSendMail_Click(object sender, EventArgs e)
        {
            if(idBill != 0)
            {
                FrmSendInvoiceToMail f = new FrmSendInvoiceToMail(idBill, InvoiceNumber);
                f.ShowDialog();
            }
            else { }
        }
        
        private void btClear_Click(object sender, EventArgs e)
        {
            ResetValue();
        }
    }
}
