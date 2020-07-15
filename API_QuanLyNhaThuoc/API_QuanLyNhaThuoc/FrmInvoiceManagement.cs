using API_QuanLyNhaThuoc.DAO;
using API_QuanLyNhaThuoc.DTO;
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
            //LoadData();
            dgvListInvoice.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvListInvoice.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvListInvoice.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvListInvoice.DefaultCellStyle.SelectionForeColor = Color.Black;

            DateTime date = DateTime.Now;
            dateTimeFrom.Value = new DateTime(date.Year, date.Month, 1);
            dateTimeTo.Value = dateTimeFrom.Value.AddMonths(1).AddDays(-1);
            tbSellerTaxcode.Text = Account_DAO.Instance.CheckUsername();
            cbInvoiceStatus.ValueMember = "ID";
            cbInvoiceStatus.DisplayMember = "MOTA";
            cbInvoiceStatus.DataSource = DataProvider.Instance.ExcuteQuery("select * from trangthai order by ID desc");

            cbPageNum.SelectedItem = "10";
        }
        private void LoadData()
        {
            dgvListInvoice.DataSource = LoadRecord(pageNumber, recordNumber);
            SetColorRowWhenBillStatusIsDelete();
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
        private List<Invoice> LoadRecord(int page, int recordNum)
        {
            List<Invoice> list = Invoice_DAO.Instance.GetListInvoice(tbBuyerEmail.Text, tbBuyerPhone.Text, Convert.ToBoolean(cbInvoiceStatus.SelectedValue), tbInvoiceId.Text, tbCreator.Text, tbBuyerCode.Text, tbBuyerName.Text, dateTimeFrom.Value, dateTimeTo.Value);
            
            lbPageNum.Text = page.ToString() + "/" + (list.Count / recordNum + 1).ToString();
            return list.Skip((page - 1) * recordNum).Take(recordNum).ToList();
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            //dgvListInvoice.DataSource = Invoice_DAO.Instance.GetListInvoice(tbBuyerEmail.Text, tbBuyerPhone.Text, Convert.ToBoolean(cbInvoiceStatus.SelectedValue), tbInvoiceId.Text, tbCreator.Text, tbBuyerCode.Text, tbBuyerName.Text, dateTimeFrom.Value, dateTimeTo.Value).Skip(0).Take(10).ToList();
            dgvListInvoice.DataSource = LoadRecord(pageNumber, recordNumber);
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

        private int pageNumber = 1;
        private int recordNumber = 10;
        private void btPrivousPage_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                dgvListInvoice.DataSource = LoadRecord(pageNumber, recordNumber);
                SetColorRowWhenBillStatusIsDelete();
            }
        }

        private void btNextPage_Click(object sender, EventArgs e)
        {
            List<Invoice> list = Invoice_DAO.Instance.GetListInvoice(tbBuyerEmail.Text, tbBuyerPhone.Text, Convert.ToBoolean(cbInvoiceStatus.SelectedValue), tbInvoiceId.Text, tbCreator.Text, tbBuyerCode.Text, tbBuyerName.Text, dateTimeFrom.Value, dateTimeTo.Value);

            if (pageNumber - 1 < list.Count/recordNumber)
            {
                pageNumber++;
                dgvListInvoice.DataSource = LoadRecord(pageNumber, recordNumber);
                SetColorRowWhenBillStatusIsDelete();
            }
        }

        private void btFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber=1;
            dgvListInvoice.DataSource = LoadRecord(pageNumber, recordNumber);
            SetColorRowWhenBillStatusIsDelete();
        }

        private void btLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = Invoice_DAO.Instance.GetListInvoice(tbBuyerEmail.Text, tbBuyerPhone.Text, Convert.ToBoolean(cbInvoiceStatus.SelectedValue), tbInvoiceId.Text, tbCreator.Text, tbBuyerCode.Text, tbBuyerName.Text, dateTimeFrom.Value, dateTimeTo.Value).Count/recordNumber+1;
            dgvListInvoice.DataSource = LoadRecord(pageNumber, recordNumber);
            SetColorRowWhenBillStatusIsDelete();
        }

        private void cbPageNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPageNum.SelectedItem.ToString() == "10")
            {
                pageNumber = 1;
                recordNumber = 10;
                dgvListInvoice.DataSource = LoadRecord(pageNumber, recordNumber);
                SetColorRowWhenBillStatusIsDelete();
            }
            else
            {
                if(cbPageNum.SelectedItem.ToString() == "15")
                {
                    pageNumber = 1;
                    recordNumber = 15;
                    dgvListInvoice.DataSource = LoadRecord(pageNumber, recordNumber);
                    SetColorRowWhenBillStatusIsDelete();
                }
                else
                {
                    if (cbPageNum.SelectedItem.ToString() == "20")
                    {
                        pageNumber = 1;
                        recordNumber = 20;
                        dgvListInvoice.DataSource = LoadRecord(pageNumber, recordNumber);
                        SetColorRowWhenBillStatusIsDelete();
                    }
                    else
                    {
                        if (cbPageNum.SelectedItem.ToString() == "30")
                        {
                            pageNumber = 1;
                            recordNumber = 30;
                            dgvListInvoice.DataSource = LoadRecord(pageNumber, recordNumber);
                            SetColorRowWhenBillStatusIsDelete();
                        }
                        else
                        {
                            if (cbPageNum.SelectedItem.ToString() == "Tất cả")
                            {
                                pageNumber = 1;
                                recordNumber = Invoice_DAO.Instance.GetListInvoice(tbBuyerEmail.Text, tbBuyerPhone.Text, Convert.ToBoolean(cbInvoiceStatus.SelectedValue), tbInvoiceId.Text, tbCreator.Text, tbBuyerCode.Text, tbBuyerName.Text, dateTimeFrom.Value, dateTimeTo.Value).Count+1;
                                dgvListInvoice.DataSource = LoadRecord(pageNumber, recordNumber);
                                SetColorRowWhenBillStatusIsDelete();
                            }
                        }
                    }
                }
            }
        }
    }
}
