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
        private string userInvoiceTemp()
        {
            return FrmLogin.username.Replace(".", "");
        }
        private void FrmCreateInvoice_Load(object sender, EventArgs e)
        {
            LoadDataBuyer();
            LoadData(Account_DAO.Instance.CheckUsername());
            ResetValues();
            
            dgvSearchItem.Visible = false;
            dgvCustomer.Visible = false;
            btAdd.Visible = false;
            dgvSearchItem.AutoGenerateColumns = false;
            dgvCustomer.AutoGenerateColumns = false;
            rbtProduct.Checked = true;

            dgvCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvCustomer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomer.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvCustomer.DefaultCellStyle.SelectionForeColor = Color.OrangeRed;

            dgvSearchItem.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgvSearchItem.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSearchItem.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvSearchItem.DefaultCellStyle.SelectionForeColor = Color.OrangeRed;
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

        private CultureInfo culture = new CultureInfo("vi-VN");
        
        private void LoadDataBuyer()
        {
            cbBuyerCode.ValueMember = "MaKH";
            cbBuyerCode.DisplayMember = "MaKH";
            cbBuyerCode.DataSource = DataProvider.Instance.ExcuteQuery("Select MaKH, TenKH from ThongTinKhachHang where Status = 1");
        }
        private void ResetValues()
        {
            lbIdBill.Text = DataProvider.Instance.ExcuteScalar("exec AutoKeyBill").ToString();
            rtbNote.Text = "";
            nbDisCount.Value = 0;
            lbTotalAmount.Text = "000000";
            lbTotalPayment.Text = "000000";
            cbBuyerCode.SelectedValue = "nguoi_mua_khong_lay_hoa_don";
            lbBuyerName.Text = "";
            lbBuyerTaxCode.Text = "";
            lbBuyerAddress.Text = "";
            lbBuyerPhone.Text = "";
            lbBuyerEmail.Text = "";
            rtbAmountInWord.Text = "";
            rtbNote.Text = "";
            PanelLoadItem.Controls.Clear();
            Invoice_DAO.Instance.ResetTableItemInvoiceTemp(userInvoiceTemp());
            Invoice_DAO.Instance.DropTableInvoiceTemp();
            idItemTemp = 0;
            //while (dgvBillInfo.Rows.Count > 1)
            //{
            //    dgvBillInfo.Rows.Clear();
            //}
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
            List<ItemTemp> itemTemps = Invoice_DAO.Instance.GetListItemTemp(userInvoiceTemp());
            if (itemTemps.Count == 0)
            {
                lbNotification.Text = "Bảng hàng hóa không được để trống!";
                i = 5;
                timerResetNtf.Enabled = true;
            }
            else
            {
                try
                {
                    if (TotalAmount >= 0)
                    {
                        int totalLineNumber = 0;
                        for (int j = 0; j < itemTemps.Count; j++)
                        {
                            string idproduct = itemTemps[j].IdItemCode;
                            float unitPrice = itemTemps[j].UnitPrice;
                            string unitName = itemTemps[j].UnitName;
                            int exchangeValue = itemTemps[j].ExchangeValue;
                            float quantity = itemTemps[j].Quantity;

                            if (Invoice_DAO.Instance.InsertDetailBill(idproduct, unitName, exchangeValue, quantity, unitPrice))
                            {
                                totalLineNumber += 1;
                            }
                        }
                        if (totalLineNumber == itemTemps.Count)
                        {
                            string creator = FrmLogin.username;
                            int discount = Convert.ToInt32(nbDisCount.Value);
                            float totalAmount = TotalAmount;
                            string note = rtbNote.Text;
                            string amountInWord = rtbAmountInWord.Text;
                            string buyerCode = cbBuyerCode.SelectedValue.ToString();
                            if (buyerCode == null || buyerCode == "") { buyerCode = "nguoi_mua_khong_lay_hoa_don"; }

                            if (Invoice_DAO.Instance.InsertBill(creator, lbSellerTaxCode.Text, buyerCode, totalAmount, discount, amountInWord, note))
                            {
                                string invoiceNumber = lbIdBill.Text;
                                //string mail = lbBuyerEmail.Text.Trim().ToLower().ToString();
                                FrmCreateInvoice_Load(sender, e);
                                lbNotification.Text = "Lập HĐ " + invoiceNumber + " thành công!";
                                i = 5;
                                timerResetNtf.Enabled = true;
                                //FrmPrintBill f = new FrmPrintBill();
                                //f.GetReport(Convert.ToInt32(invoiceNumber));
                                //f.ShowDialog();
                                //if (mail != "")
                                //{
                                //    if (Email_DAO.Instance.isEmail(mail))
                                //    {
                                //        SendMail(mail, Convert.ToInt32(invoiceNumber), invoiceNumber);
                                //    }
                                //}
                            }
                            else
                            {
                                lbNotification.Text = "Có lỗi kết nối! Vui lòng thử lại!";
                                i = 5;
                                timerResetNtf.Enabled = true;
                            }
                        }
                        else
                        {
                            lbNotification.Text = "Có lỗi kết nối! Vui lòng thử lại!";
                            i = 5;
                            timerResetNtf.Enabled = true;
                        }
                    }
                    else
                    {
                        lbNotification.Text = "Tổng tiền của hóa đơn phải lớn hơn hoặc bằng 0 !";
                        i = 5;
                        timerResetNtf.Enabled = true;
                    }
                }
                catch /*(Exception ex)*/
                {
                    lbNotification.Text = "Có lỗi kết nối! Vui lòng thử lại!";
                    i = 5;
                    timerResetNtf.Enabled = true;
                }
            }
        }
        private void btCreateAndPrintInvoice_Click(object sender, EventArgs e)
        {
            List<ItemTemp> itemTemps = Invoice_DAO.Instance.GetListItemTemp(userInvoiceTemp());
            if (itemTemps.Count == 0)
            {
                lbNotification.Text = "Bảng hàng hóa không được để trống!";
                i = 5;
                timerResetNtf.Enabled = true;
            }
            else
            {
                try
                {
                    if (TotalAmount >= 0)
                    {
                        int totalLineNumber = 0;
                        for (int j = 0; j < itemTemps.Count; j++)
                        {
                            string idproduct = itemTemps[j].IdItemCode;
                            float unitPrice = itemTemps[j].UnitPrice;
                            string unitName = itemTemps[j].UnitName;
                            int exchangeValue = itemTemps[j].ExchangeValue;
                            float quantity = itemTemps[j].Quantity;

                            if (Invoice_DAO.Instance.InsertDetailBill(idproduct, unitName, exchangeValue, quantity, unitPrice))
                            {
                                totalLineNumber += 1;
                            }
                        }
                        if (totalLineNumber == itemTemps.Count)
                        {
                            string creator = FrmLogin.username;
                            int discount = Convert.ToInt32(nbDisCount.Value);
                            float totalAmount = TotalAmount;
                            string note = rtbNote.Text;
                            string amountInWord = rtbAmountInWord.Text;
                            string buyerCode = cbBuyerCode.SelectedValue.ToString();
                            if (buyerCode == null || buyerCode == "") { buyerCode = "nguoi_mua_khong_lay_hoa_don"; }

                            if (Invoice_DAO.Instance.InsertBill(creator, lbSellerTaxCode.Text, buyerCode, totalAmount, discount, amountInWord, note))
                            {
                                string invoiceNumber = lbIdBill.Text;
                                //string mail = lbBuyerEmail.Text.Trim().ToLower().ToString();
                                FrmCreateInvoice_Load(sender, e);
                                lbNotification.Text = "Lập HĐ " + invoiceNumber + " thành công!";
                                i = 5;
                                timerResetNtf.Enabled = true;
                                FrmPrintBill f = new FrmPrintBill();
                                f.GetReport(Convert.ToInt32(invoiceNumber));
                                f.ShowDialog();
                                //if (mail != "")
                                //{
                                //    if (Email_DAO.Instance.isEmail(mail))
                                //    {
                                //        SendMail(mail, Convert.ToInt32(invoiceNumber), invoiceNumber);
                                //    }
                                //}
                            }
                            else
                            {
                                lbNotification.Text = "Có lỗi kết nối! Vui lòng thử lại!";
                                i = 5;
                                timerResetNtf.Enabled = true;
                            }
                        }
                        else
                        {
                            lbNotification.Text = "Có lỗi kết nối! Vui lòng thử lại!";
                            i = 5;
                            timerResetNtf.Enabled = true;
                        }
                    }
                    else
                    {
                        lbNotification.Text = "Tổng tiền của hóa đơn phải lớn hơn hoặc bằng 0 !";
                        i = 5;
                        timerResetNtf.Enabled = true;
                    }
                }
                catch /*(Exception ex)*/
                {
                    lbNotification.Text = "Có lỗi kết nối! Vui lòng thử lại!";
                    i = 5;
                    timerResetNtf.Enabled = true;
                }
            }
        }

        private void cbBuyerCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                Buyer buyer = Buyer_DAO.Instance.GetListBuyerById(cbBuyerCode.SelectedValue.ToString());
                lbBuyerName.Text = buyer.BuyerName;
                lbBuyerTaxCode.Text = buyer.BuyerTaxCode;
                lbBuyerAddress.Text = buyer.BuyerAddress;
                lbBuyerPhone.Text = buyer.BuyerPhone;
                lbBuyerEmail.Text = buyer.BuyerEmail;
            }
            catch { }
        }
        private int i = 5;
        private void timerResetNtf_Tick(object sender, EventArgs e)
        {
            i--;
            if (i == 0) { lbNotification.Text = ""; timerResetNtf.Enabled = false; }
        }

        private void nbDisCount_ValueChanged(object sender, EventArgs e)
        {
            try 
            { 
                lbTotalPayment.Text = (ComputeTotalAmount() - (ComputeTotalAmount() * ((float)Convert.ToDouble(nbDisCount.Value) / 100))).ToString("c0", culture);
                rtbAmountInWord.Text = Invoice_DAO.Instance.NumberToTextVN((decimal)(ComputeTotalAmount() - ComputeTotalAmount() * ((float)Convert.ToDouble(nbDisCount.Value)/100)));
            } catch { }
        }

        private void btNewBuyer_Click(object sender, EventArgs e)
        {
            FrmCustomer f = new FrmCustomer(LoadDataBuyer);
            f.ShowDialog();
        }

        private void tbSearch_OnTextChange(object sender, EventArgs e)
        {
            if (rbtProduct.Checked)
            {
                if (tbSearch.text == "")
                {
                    dgvSearchItem.Visible = false;
                    btAdd.Visible = false;
                    btScan.Enabled = true;
                }
                else
                {
                    dgvSearchItem.Visible = true;
                    btAdd.Visible = true;
                    if (idProduct == "") btAdd.Enabled = false;
                    dgvSearchItem.DataSource = Product_DAO.Instance.GetListProductWhenCreateInvoice(tbSearch.text, userInvoiceTemp());
                    btScan.Enabled = false;
                }
            }
            else
            {
                if (tbSearch.text == "")
                {
                    dgvCustomer.Visible = false;
                    btAdd.Visible = false;
                    btScan.Enabled = true;
                }
                else
                {
                    dgvCustomer.Visible = true;
                    //btAdd.Visible = true;
                    dgvCustomer.DataSource = Buyer_DAO.Instance.GetListBuyerWhenCreateInvoice(tbSearch.text);
                    btScan.Enabled = false;
                }
            }
        }
        private float ComputeTotalAmount()
        {
            float t = 0;
            List<ItemTemp> listItem = Invoice_DAO.Instance.GetListItemTemp(userInvoiceTemp());
            
            for(int i = 0;i < listItem.Count; i++)
            {
                t += listItem[i].Quantity*listItem[i].UnitPrice;
            }
            return t;
        }
        private void ComputeTotalAmountWhenUpdateItem()
        {
            lbTotalAmount.Text = ComputeTotalAmount().ToString("C0",culture);
            lbTotalPayment.Text = (ComputeTotalAmount() - ComputeTotalAmount() * ((float)Convert.ToDouble(nbDisCount.Value)/100)).ToString("C0",culture);
            rtbAmountInWord.Text = Invoice_DAO.Instance.NumberToTextVN((decimal)(ComputeTotalAmount() - ComputeTotalAmount() * ((float)Convert.ToDouble(nbDisCount.Value) / 100)));
            TotalAmount = ComputeTotalAmount();
        }
        private float TotalAmount = -1;
        private int idItemTemp = 0;
        private void LoadItemInfo()
        {
            idItemTemp += 1;
            FrmItems f = new FrmItems(ComputeTotalAmountWhenUpdateItem, idItemTemp, idProduct);
            f.TopLevel = false;
            PanelLoadItem.Controls.Add(f);
            f.Dock = DockStyle.Top;
            //f.TopMost = true;
            f.Show();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (Invoice_DAO.Instance.InsertItemInvoiceTemp(idProduct, userInvoiceTemp()))
            {
                dgvSearchItem.Visible = false;
                btAdd.Visible = false;
                tbSearch.text = "";
                LoadItemInfo();
            }
        }

        private string idProduct ="";
        private void dgvSearchItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idProduct = dgvSearchItem.Rows[e.RowIndex].Cells[1].Value.ToString();
                btAdd.Enabled = true;
            }
            catch { btAdd.Enabled = false; }
        }

        private void dgvSearchItem_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvSearchItem.Rows.Count; i++)
            {
                dgvSearchItem.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dgvCustomer_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                dgvCustomer.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void rbtProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtProduct.Checked)
            {
                rbtBuyer.Checked = false;
                dgvCustomer.Visible = false;
            }
        }

        private void rbtBuyer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBuyer.Checked)
            {
                rbtProduct.Checked = false;
                dgvSearchItem.Visible = false;
            }
        }
        private string BuyerCode;
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BuyerCode = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbBuyerCode.SelectedValue = BuyerCode;
                tbSearch.text = "";
            }
            catch {}
        }

        private void LoadItemInfoWhenScanQRCode()
        {
            if(FrmScanQR_Bar.idProduct != "")
            {
                if (Invoice_DAO.Instance.InsertItemInvoiceTemp(FrmScanQR_Bar.idProduct, userInvoiceTemp()))
                {
                    idItemTemp += 1;
                    FrmItems f = new FrmItems(ComputeTotalAmountWhenUpdateItem, idItemTemp, FrmScanQR_Bar.idProduct);
                    f.TopLevel = false;
                    PanelLoadItem.Controls.Add(f);
                    f.Dock = DockStyle.Top;
                    //f.TopMost = true;
                    f.Show();
                }
            }
        }
        private void btScan_Click(object sender, EventArgs e)
        {
            FrmScanQR_Bar f = new FrmScanQR_Bar(LoadItemInfoWhenScanQRCode);
            f.ShowDialog();
        }
    }
}
