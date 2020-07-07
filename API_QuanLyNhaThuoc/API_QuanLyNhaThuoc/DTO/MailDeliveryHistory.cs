using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class MailDeliveryHistory
    {
        private int id;
        private string mailTo;
        private string buyerName;
        private string invoiceNumber;
        private DateTime sendDate;
        private string status;
        private string detailError;

        public MailDeliveryHistory(int id, string mailTo, string buyerName, string invoiceNumber, DateTime sendDate, string status, string detailError)
        {
            this.Id = id;
            this.MailTo = mailTo;
            this.BuyerName = buyerName;
            this.InvoiceNumber = invoiceNumber;
            this.SendDate = sendDate;
            this.Status = status;
            this.DetailError = detailError;
        }
        public MailDeliveryHistory(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"]);
            this.MailTo = row["EmailTo"].ToString();
            this.BuyerName = row["buyerName"].ToString();
            this.InvoiceNumber = row["invoiceNumber"].ToString();
            this.SendDate = Convert.ToDateTime(row["sendDate"]);
            this.DetailError = row["detailError"].ToString();
            if (Convert.ToBoolean(row["status"]))
                 this.Status = "Thành công";
            else this.Status = "Thất bại";
        }
        public int Id { get => id; set => id = value; }
        public string MailTo { get => mailTo; set => mailTo = value; }
        public string BuyerName { get => buyerName; set => buyerName = value; }
        public string InvoiceNumber { get => invoiceNumber; set => invoiceNumber = value; }
        public DateTime SendDate { get => sendDate; set => sendDate = value; }
        public string Status { get => status; set => status = value; }
        public string DetailError { get => detailError; set => detailError = value; }
    }
}
