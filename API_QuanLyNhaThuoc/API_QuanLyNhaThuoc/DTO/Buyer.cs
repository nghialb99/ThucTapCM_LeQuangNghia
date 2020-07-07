using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class Buyer
    {
        private string idBuyer;
        private string buyerName;
        private string buyerTaxCode;
        private string buyerAddress;
        private string buyerPhone;
        private string buyerEmail;
        private string status;

        public Buyer(string idBuyer, string buyerName, string buyerTaxCode, string buyerAddress, string buyerPhone, string buyerEmail, string status)
        {
            this.IdBuyer = idBuyer;
            this.BuyerName = buyerName;
            this.BuyerTaxCode = buyerTaxCode;
            this.BuyerAddress = buyerAddress;
            this.BuyerPhone = buyerPhone;
            this.BuyerEmail = buyerEmail;
            this.Status = status;
        }
        public Buyer(DataRow row)
        {
            this.IdBuyer = row["MaKH"].ToString();
            this.BuyerName = row["TenKH"].ToString();
            this.BuyerTaxCode = row["MST"].ToString();
            this.BuyerAddress = row["DiaChi"].ToString();
            this.BuyerPhone = row["SoDienThoai"].ToString();
            this.BuyerEmail = row["Email"].ToString();
            if (Convert.ToBoolean(row["Status"])) this.Status = "Hoạt động";
            else this.Status = "Khóa";
        }
        public string IdBuyer { get => idBuyer; set => idBuyer = value; }
        public string BuyerName { get => buyerName; set => buyerName = value; }
        public string BuyerAddress { get => buyerAddress; set => buyerAddress = value; }
        public string BuyerPhone { get => buyerPhone; set => buyerPhone = value; }
        public string BuyerEmail { get => buyerEmail; set => buyerEmail = value; }
        public string Status { get => status; set => status = value; }
        public string BuyerTaxCode { get => buyerTaxCode; set => buyerTaxCode = value; }
    }
}
