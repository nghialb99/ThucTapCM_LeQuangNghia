using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DAO
{
    class Email_DAO
    {
        private static Email_DAO instance;

        public static Email_DAO Instance
        {
            get { if (instance == null) instance = new Email_DAO(); return instance; }
            private set { instance = value; }
        }

        private Email_DAO() { }
        
        public ConfigurationEmail GetEmail()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from Email");
            foreach (DataRow item in data.Rows)
            {
                return new ConfigurationEmail(item);
            }
            return null;
        }
        public bool UpdateEmail(string configurationName , string email , string pass , string sever , int port , int status)
        {
            string query = "exec UpdateEmail @configurationName , @email , @pass , @sever , @port , @status ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { configurationName, email, pass, sever, port, status }) > 0;
        }
        public List<MailDeliveryHistory> GetListMailDelivery(DateTime fromDate,DateTime toDate)
        {
            List<MailDeliveryHistory> listBuyer = new List<MailDeliveryHistory>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetListMailDeliveryHistory @FromDate , @ToDate ",new object[]{fromDate,toDate});
            foreach (DataRow item in data.Rows)
            {
                MailDeliveryHistory list = new MailDeliveryHistory(item);
                listBuyer.Add(list);
            }
            return listBuyer;
        }
        public bool InsertMailDeliveryHistory(string EmailTo ,string BuyerName ,string InvoiceNumber ,bool Status ,string detailError)
        {
            string query = "EXEC InsertMailDeliveryHistory @EmailTo , @BuyerName , @InvoiceNumber , @Status , @detailError";
            return DataProvider.Instance.ExcuteNunQuery(query,new object[] { EmailTo, BuyerName, InvoiceNumber, Status, detailError }) > 0;
        }
        public bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public bool SendInvoiceToMail( string ToEmail, Attachment attach )
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            EnterpriseInfo seller = EnterpriseInfo_DAO.Instance.LoadEnterpriseInfoById(Account_DAO.Instance.CheckUsername());
            Invoice bill = Invoice_DAO.Instance.GetListInvoiceByInvoiceNumber(attach.Name);
            string Title = "HÓA ĐƠN BÁN HÀNG " + seller.EnterpriseName;
            string Content = " Kính gửi Quý Khách hàng,\n\n" +
                             " Hóa đơn của quý khách bao gồm:" +
                             "\n\n - Mã số thuế đơn vị phát hành: " + seller.EnterpriseTaxCode +
                             "\n\n - Mã số hóa đơn: " + bill.InvoiceNumber +
                             "\n\n - Ngày lập: " + bill.InvoiceIssuedDate.ToString("dd/MM/yyyy") +
                             "\n\n - Tên người mua: " + bill.BuyerLegalName +
                             "\n\n - Tông tiền thanh toán: " + bill.TotalAmountAfterDiscount.ToString("c0",culture) +
                             "\n\n - Tiền bằng chữ: " + bill.TotalAmountInWords + 
                             "\n\n" + seller.EnterpriseName+ " xin trân trọng cảm ơn Quý khách đã sử dụng sản phẩm/dịch vụ của chúng tôi!";
            try
            {
                MailMessage mail = new MailMessage(GetEmail().EmailAddress, ToEmail, Title, Content);
                SmtpClient client = new SmtpClient(GetEmail().Server);
                client.Port = GetEmail().Port;
                client.Credentials = new System.Net.NetworkCredential(GetEmail().EmailAddress, GetEmail().Pass);
                client.EnableSsl = true;
                mail.Attachments.Add(attach);
                client.Send(mail);
                InsertMailDeliveryHistory(ToEmail, bill.BuyerLegalName, bill.InvoiceNumber,true,"");
                return true;
            }
            catch (Exception ex)
            {
                string detailError = ex.Message;
                InsertMailDeliveryHistory(ToEmail, bill.BuyerLegalName, bill.InvoiceNumber, false, detailError);
                return false;
            }
        }
        public bool SendMailResetPassword(string toMail, string verificationCode)
        {
            string Title = "YÊU CẦU LẤY LẠI MẬT KHẨU";
            string Content = " Để đảm bảo an toàn bạn không cung cấp mã xác nhận cho bất cứ ai.\n\n" +
                             " Mã xác nhận của bạn là: " + verificationCode;
            try
            {
                MailMessage mail = new MailMessage(GetEmail().EmailAddress, toMail, Title, Content);
                SmtpClient client = new SmtpClient(GetEmail().Server);
                client.Port = GetEmail().Port;
                client.Credentials = new System.Net.NetworkCredential(GetEmail().EmailAddress, GetEmail().Pass);
                client.EnableSsl = true;
                client.Send(mail);

                return true;
            }
            catch
            {
                return false;
            }
        }
        public int GetTotalMailDeliveryThisDay()
        {
            return Convert.ToInt32(DataProvider.Instance.ExcuteScalar("GetTotalMailDeliveryThisDay"));
        }
        public int GetTotalMailDeliveryThisMonth()
        {
            return Convert.ToInt32(DataProvider.Instance.ExcuteScalar("GetTotalMailDeliveryThisMonth"));
        }
        public int GetTotalMailDeliveryLastMonth()
        {
            return Convert.ToInt32(DataProvider.Instance.ExcuteScalar("GetTotalMailDeliveryLastMonth"));
        }
    }
}
