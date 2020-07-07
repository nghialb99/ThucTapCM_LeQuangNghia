using API_QuanLyNhaThuoc.DAO;
using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_QuanLyNhaThuoc
{
    public partial class FrmCreateInvoice : Form
    {
        public FrmCreateInvoice()
        {
            InitializeComponent();
        }
        private void FrmCreateInvoice_Load(object sender, EventArgs e)
        {
            LoadDataProduct();
            LoadData(Account_DAO.Instance.CheckUsername());
            dgvSearchItem.Visible = false;
            btAdd.Visible = false;
        }
        private void LoadData(string user)
        {
            List<EnterpriseInfo> data = EnterpriseInfo_DAO.Instance.LoadEnterpriseInfo(user);
            lbSellerLegalName.Text = data[0].EnterpriseName.ToString();
            lbSellerTaxCode.Text = data[0].EnterpriseTaxCode.ToString();
            lbSellerAddress.Text = data[0].EnterpriseAddress.ToString();
            lbSellerPhoneNumber.Text = data[0].EnterprisePhone.ToString();
            lbSellerEmail.Text = data[0].EnterpriseEmail.ToString();
            lbCreator.Text = Account_DAO.Instance.GetUserAccount(FrmLogin.username).UserDisplayName;
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbIdBill.Text = DataProvider.Instance.ExcuteScalar("exec AutoKeyBill").ToString();
            lbNotification.Text = "";
        }
        private int row = 0;
        private CultureInfo culture = new CultureInfo("vi-VN");
        
        private void LoadDataProduct()
        {
            //cbNameSp.ValueMember = "Id";
            //cbNameSp.DisplayMember = "Name";
            //cbNameSp.DataSource = Product_DAO.Instance.GetListProductWhenCreateInvoice();
            
            cbBuyerCode.ValueMember = "MaKH";
            cbBuyerCode.DisplayMember = "MaKH";
            cbBuyerCode.DataSource = DataProvider.Instance.ExcuteQuery("Select MaKH, TenKH from ThongTinKhachHang where Status = 1");

            //dgvCbUnitName.ValueMember = "Id";
            //dgvCbUnitName.DisplayMember = "UnitName";
            //dgvCbUnitName.DataSource = Product_DAO.Instance.GetUnitPrice("HH000012", "");
        }
        private void ResetValues()
        {
            lbIdBill.Text = DataProvider.Instance.ExcuteScalar("exec AutoKeyBill").ToString();
            rtbNote.Text = "";
            nbDisCount.Value = 0;
            lbTotalAmount.Text = "000000";
            lbTotalPayment.Text = "000000";
            cbBuyerCode.Text = "";
            tbBuyerName.Text = "";
            tbBuyerAddress.Text = "";
            tbBuyerPhone.Text = "";
            tbBuyerEmail.Text = "";
            rtbAmountInWord.Text = "";
            rtbNote.Text = "";
            //while (dgvBillInfo.Rows.Count > 1)
            //{
            //    dgvBillInfo.Rows.Clear();
            //}
        }
        private float ComputeTotalAmount()
        {
            float t = 0;
            try
            {
                //for (int i = 0; i < dgvBillInfo.Rows.Count - 1; i++)
                //{
                //    t = t + (float)Convert.ToDouble(dgvBillInfo.Rows[i].Cells[5].Value.ToString());
                //}
            }
            catch { }
            return t;
        }
        private void dgvBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }
        private void dgvBillInfo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SendMail(string toMail,int idBill,string invoiceNumber)
        {
            FrmPrintBill f = new FrmPrintBill(null);
            string filePath = f.GetFileInvoice(idBill, invoiceNumber);
            try
            {
                if (File.Exists(filePath))
                {
                    Thread thread = new Thread(() =>
                    {
                        if (Email_DAO.Instance.SendInvoiceToMail(toMail, new Attachment(filePath)))
                        {
                            //DeleteFileAfterSendMail(filePath);
                        }
                        //CloseF();
                    }
                    );
                    thread.Start();
                }
            }
            catch { }
        }
        private void btCreateInvoice_Click(object sender, EventArgs e)
        {
            //if(dgvBillInfo.Rows.Count > 1)
            //{
            //    string id = lbIdBill.Text;
            //    string creator = lbCreator.Text;
            //    int discount = Convert.ToInt32(nbDisCount.Value.ToString());
            //    float totalAmount = ComputeTotalAmount() - ComputeTotalAmount() * ((float)Convert.ToDouble(discount) / 100);
            //    string note = rtbNote.Text;
            //    string amountInWord = Invoice_DAO.Instance.NumberToTextVN((decimal)totalAmount);
            //    string idBuyer = cbBuyerCode.Text;
            //    if(idBuyer == null || idBuyer == "") { idBuyer = "nguoi_mua_khong_lay_hoa_don"; }
            //    try 
            //    {
            //        if (Invoice_DAO.Instance.InsertBill(id, creator, discount, totalAmount, amountInWord, note, idBuyer))
            //        {
            //            int temp = 0;
            //            for (int j = 0; j < dgvBillInfo.Rows.Count - 1; j++)
            //            {
            //                string idproduct = dgvBillInfo.Rows[j].Cells[1].Value.ToString();
            //                string productName = Product_DAO.Instance.GetProductById(idproduct).Name;
            //                string solo = Product_DAO.Instance.GetProductById(idproduct).BatchNo;
            //                DateTime expDate = Product_DAO.Instance.GetProductById(idproduct).ExpDate;
            //                float unitPrice = Product_DAO.Instance.GetProductById(idproduct).UnitPrice;
            //                string unitName = Product_DAO.Instance.GetProductById(idproduct).UnitName;
            //                int quantity = Convert.ToInt32(dgvBillInfo.Rows[j].Cells[3].Value);

            //                if (Invoice_DAO.Instance.InsertDetailBill(id, idproduct, productName, solo, expDate, unitName, quantity, unitPrice))
            //                {
            //                    temp += 1;
            //                }
            //            }
            //            if (temp == dgvBillInfo.Rows.Count - 1)
            //            {
            //                invoiceId = id;
            //                string mail = tbBuyerEmail.Text.Trim().ToLower().ToString();
            //                ResetValues();
            //                lbNotification.Text = "Lập HĐ " + id + " thành công!";
            //                i = 5;
            //                timerResetNtf.Enabled = true;
            //                //if (mail != "")
            //                //{
            //                //    if (Email_DAO.Instance.isEmail(mail))
            //                //    {
            //                //        SendMail(mail, invoiceId);
            //                //    }
            //                //}
            //            }
            //            else
            //            {
            //                lbNotification.Text = "Lập HĐ " + id + " thất bại! Vui lòng thử lại sau.";
            //                i = 5;
            //                timerResetNtf.Enabled = true;
            //                Invoice_DAO.Instance.DeleteBill(id);
            //            }
            //        }
            //        else
            //        {
            //            lbNotification.Text = "Có lỗi gì đó xãy ra vui lòng thử lại!";
            //            i = 5;
            //            timerResetNtf.Enabled = true;
            //        }
            //    } catch { }
            //}
            //else
            //{
            //    lbNotification.Text = "Bảng hàng hóa không được để trống!";
            //    i = 5;
            //    timerResetNtf.Enabled = true;
            //}
        }
        private static string invoiceId;
        private void btCreateAndPrintInvoice_Click(object sender, EventArgs e)
        {
            //if (dgvBillInfo.Rows.Count > 1)
            //{
            //    string id = lbIdBill.Text;
            //    string creator = lbCreator.Text;
            //    int discount = Convert.ToInt32(nbDisCount.Value.ToString());
            //    float totalAmount = ComputeTotalAmount() - ComputeTotalAmount() * ((float)Convert.ToDouble(discount) / 100);
            //    string note = rtbNote.Text;
            //    string amountInWord = Invoice_DAO.Instance.NumberToTextVN((decimal)totalAmount);
            //    string idBuyer = cbBuyerCode.Text;
            //    if (idBuyer == null || idBuyer == "") { idBuyer = "nguoi_mua_khong_lay_hoa_don"; }
            //    try
            //    {
            //        if (Invoice_DAO.Instance.InsertBill(id, creator, discount, totalAmount, amountInWord, note, idBuyer))
            //        {
            //            int temp = 0;
            //            for (int j = 0; j < dgvBillInfo.Rows.Count - 1; j++)
            //            {
            //                string idproduct = dgvBillInfo.Rows[j].Cells[1].Value.ToString();
            //                string productName = Product_DAO.Instance.GetProductById(idproduct).Name;
            //                string solo = Product_DAO.Instance.GetProductById(idproduct).BatchNo;
            //                DateTime expDate = Product_DAO.Instance.GetProductById(idproduct).ExpDate;
            //                float unitPrice = Product_DAO.Instance.GetProductById(idproduct).UnitPrice;
            //                string unitName = Product_DAO.Instance.GetProductById(idproduct).UnitName;
            //                int quantity = Convert.ToInt32(dgvBillInfo.Rows[j].Cells[3].Value);
            //                if (Invoice_DAO.Instance.InsertDetailBill(id, idproduct, productName, solo, expDate, unitName, quantity, unitPrice))
            //                {
            //                    temp += 1;
            //                }
            //            }
            //            if (temp == dgvBillInfo.Rows.Count - 1)
            //            {
            //                lbNotification.Text = "Lập HĐ " + id + " thành công!";
            //                i = 5;
            //                timerResetNtf.Enabled = true;
            //                FrmPrintBill f = new FrmPrintBill();
            //                //f.GetReport(id);
            //                f.ShowDialog();
            //                ResetValues();
            //            }
            //            else
            //            {
            //                lbNotification.Text = "Lập HĐ " + id + " thất bại! Vui lòng thử lại sau.";
            //                i = 5;
            //                timerResetNtf.Enabled = true;
            //                Invoice_DAO.Instance.DeleteBill(id);
            //            }
            //        }
            //        else
            //        {
            //            lbNotification.Text = "Có lỗi gì đó xãy ra vui lòng thử lại!";
            //            i = 5;
            //            timerResetNtf.Enabled = true;
            //        }
            //    }
            //    catch { /*MessageBox.Show("dmm");*/ }
            //}
            //else
            //{
            //    lbNotification.Text = "Bảng hàng hóa không được để trống!";
            //    i = 5;
            //    timerResetNtf.Enabled = true;
            //}
        }

        private void cbBuyerCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbBuyerName.Text = Buyer_DAO.Instance.GetListBuyerById(cbBuyerCode.SelectedValue.ToString()).BuyerName;
                tbBuyerAddress.Text = Buyer_DAO.Instance.GetListBuyerById(cbBuyerCode.SelectedValue.ToString()).BuyerAddress;
                tbBuyerPhone.Text = Buyer_DAO.Instance.GetListBuyerById(cbBuyerCode.SelectedValue.ToString()).BuyerPhone;
                tbBuyerEmail.Text = Buyer_DAO.Instance.GetListBuyerById(cbBuyerCode.SelectedValue.ToString()).BuyerEmail;
            }
            catch { }
        }
        int i = 5;
        private void timerResetNtf_Tick(object sender, EventArgs e)
        {
            i--;
            if (i == 0) { lbNotification.Text = ""; timerResetNtf.Enabled = false; }
        }

        private void nbDisCount_ValueChanged(object sender, EventArgs e)
        {
            try 
            { 
                lbTotalPayment.Text = (ComputeTotalAmount() - (ComputeTotalAmount() * ((float)Convert.ToDouble(nbDisCount.Value) / 100))).ToString("c", culture);
                rtbAmountInWord.Text = Invoice_DAO.Instance.NumberToTextVN((decimal)(ComputeTotalAmount() - ComputeTotalAmount() * ((float)Convert.ToDouble(nbDisCount.Value)/100)));
            } catch { }
        }

        private void btNewBuyer_Click(object sender, EventArgs e)
        {
            FrmCustomer f = new FrmCustomer(LoadDataProduct);
            f.ShowDialog();
        }

        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            if(tbSearch.text == "")
            {
                dgvSearchItem.Visible = false;
                btAdd.Visible = false;
            }
            else
            {
                dgvSearchItem.Visible = true;
                btAdd.Visible = true;
                dgvSearchItem.DataSource = Product_DAO.Instance.GetListProduct(tbSearch.text);
            }
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //dgvSearchItem.Visible = false;
            //btAdd.Visible = false;
            //tbSearch.text = "";
            FrmItems f = new FrmItems();
            f.TopLevel = false;
            PanelLoadItem.Controls.Add(f);
            f.Dock = DockStyle.Top;
            f.Show();
        }

        private void dgvSearchItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
        }

        private void dgvSearchItem_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvSearchItem.Rows.Count; i++)
            {
                dgvSearchItem.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
