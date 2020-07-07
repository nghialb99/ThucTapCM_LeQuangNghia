using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class Invoice
    {
        private int id;//invoice data
        private string invoiceNumber;
        private DateTime invoiceIssuedDate;
        private string userName; // creator
        private string sellerLegalName; // Seller
        private string sellerTaxCode;
        private string sellerAddressLine;
        private string sellerPhoneNumber;
        private string sellerEmail;
        private string sellerBankName;
        private string sellerBankAccount;
        private string sellerWebsite;
        private string buyerCode;// Buyer
        private string buyerDisplayName; 
        private string buyerLegalName;
        private string buyerTaxCode;
        private string buyerAddressLine;
        private string buyerPhoneNumber;
        private string buyerEmail;
        private string paymentMethodName; //
        private float totalAmount;
        private int discount;
        private float discountAmount;
        private Double totalAmountAfterDiscount;
        private string totalAmountInWords;
        private string invoiceNote;
        private string status;
        private string reasonDelete;

        public Invoice(int id, string invoiceNumber, DateTime invoiceIssuedDate, string userName, string sellerLegalName, string sellerTaxCode, string sellerAddressLine, string sellerPhoneNumber, string sellerEmail, string sellerBankName, string sellerBankAccount, string sellerWebsite, string buyerCode, string buyerDisplayName, string buyerLegalName, string buyerTaxCode, string buyerAddressLine, string buyerPhoneNumber, string buyerEmail, string paymentMethodName, float totalAmount, int discount, float discountAmount, Double totalAmountAfterDiscount, string totalAmountInWords, string invoiceNote, string status, string reasonDelete)
        {
            this.Id = id;
            this.InvoiceNumber = invoiceNumber;
            this.InvoiceIssuedDate = invoiceIssuedDate;
            this.UserName = userName;
            this.SellerLegalName = sellerLegalName;
            this.SellerTaxCode = sellerTaxCode;
            this.SellerAddressLine = sellerAddressLine;
            this.SellerPhoneNumber = sellerPhoneNumber;
            this.SellerEmail = sellerEmail;
            this.SellerBankName = sellerBankName;
            this.SellerBankAccount = sellerBankAccount;
            this.SellerWebsite = sellerWebsite;
            this.BuyerCode = buyerCode;
            this.BuyerDisplayName = buyerDisplayName;
            this.BuyerLegalName = buyerLegalName;
            this.BuyerTaxCode = buyerTaxCode;
            this.BuyerAddressLine = buyerAddressLine;
            this.BuyerPhoneNumber = buyerPhoneNumber;
            this.BuyerEmail = buyerEmail;
            this.PaymentMethodName = paymentMethodName;
            this.TotalAmount = totalAmount;
            this.Discount = discount;
            this.DiscountAmount = discountAmount;
            this.TotalAmountAfterDiscount = totalAmountAfterDiscount;
            this.TotalAmountInWords = totalAmountInWords;
            this.InvoiceNote = invoiceNote;
            this.Status = status;
            this.ReasonDelete = reasonDelete;
        }
        public Invoice(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.InvoiceNumber = row["invoiceNumber"].ToString();
            this.InvoiceIssuedDate = Convert.ToDateTime(row["invoiceIssuedDate"]);
            this.UserName = row["userName"].ToString();
            this.SellerLegalName = row["sellerLegalName"].ToString();
            this.SellerTaxCode = row["sellerTaxCode"].ToString();
            this.SellerAddressLine = row["sellerAddressLine"].ToString();
            this.SellerPhoneNumber = row["sellerPhoneNumber"].ToString();
            this.SellerEmail = row["sellerEmail"].ToString();
            this.SellerBankName = row["sellerBankName"].ToString();
            this.SellerBankAccount = row["sellerBankAccount"].ToString();
            this.SellerWebsite = row["sellerWebsite"].ToString();
            this.BuyerCode = row["buyerCode"].ToString();
            this.BuyerDisplayName = row["buyerDisplayName"].ToString();
            this.BuyerLegalName = row["buyerLegalName"].ToString();
            this.BuyerTaxCode = row["buyerTaxCode"].ToString();
            this.BuyerAddressLine = row["buyerAddressLine"].ToString();
            this.BuyerPhoneNumber = row["buyerPhoneNumber"].ToString();
            this.BuyerEmail = row["buyerEmail"].ToString();
            this.PaymentMethodName = row["paymentMethodName"].ToString();
            this.TotalAmount = (float)Convert.ToDouble(row["totalAmount"]);
            this.Discount = Convert.ToInt32(row["discount"]);
            this.DiscountAmount = (float)Convert.ToDouble(row["discountAmount"]);
            this.TotalAmountAfterDiscount = Convert.ToDouble(row["totalAmountAfterDiscount"]);
            this.TotalAmountInWords = row["totalAmountInWords"].ToString();
            this.InvoiceNote = row["invoiceNote"].ToString();
            this.ReasonDelete = row["reasonDelete"].ToString();
            bool d = Convert.ToBoolean(row["status"]);
            if (d) this.Status = "Hoàn thành";
            else this.Status = "Xóa bỏ";

        }

        public int Id { get => id; set => id = value; }
        public string InvoiceNumber { get => invoiceNumber; set => invoiceNumber = value; }
        public DateTime InvoiceIssuedDate { get => invoiceIssuedDate; set => invoiceIssuedDate = value; }
        public string UserName { get => userName; set => userName = value; }
        public string SellerLegalName { get => sellerLegalName; set => sellerLegalName = value; }
        public string SellerTaxCode { get => sellerTaxCode; set => sellerTaxCode = value; }
        public string SellerAddressLine { get => sellerAddressLine; set => sellerAddressLine = value; }
        public string SellerPhoneNumber { get => sellerPhoneNumber; set => sellerPhoneNumber = value; }
        public string SellerEmail { get => sellerEmail; set => sellerEmail = value; }
        public string SellerBankName { get => sellerBankName; set => sellerBankName = value; }
        public string SellerBankAccount { get => sellerBankAccount; set => sellerBankAccount = value; }
        public string SellerWebsite { get => sellerWebsite; set => sellerWebsite = value; }
        public string BuyerDisplayName { get => buyerDisplayName; set => buyerDisplayName = value; }
        public string BuyerLegalName { get => buyerLegalName; set => buyerLegalName = value; }
        public string BuyerTaxCode { get => buyerTaxCode; set => buyerTaxCode = value; }
        public string BuyerAddressLine { get => buyerAddressLine; set => buyerAddressLine = value; }
        public string BuyerPhoneNumber { get => buyerPhoneNumber; set => buyerPhoneNumber = value; }
        public string BuyerEmail { get => buyerEmail; set => buyerEmail = value; }
        public string PaymentMethodName { get => paymentMethodName; set => paymentMethodName = value; }
        public float TotalAmount { get => totalAmount; set => totalAmount = value; }
        public int Discount { get => discount; set => discount = value; }
        public float DiscountAmount { get => discountAmount; set => discountAmount = value; }
        public Double TotalAmountAfterDiscount { get => totalAmountAfterDiscount; set => totalAmountAfterDiscount = value; }
        public string TotalAmountInWords { get => totalAmountInWords; set => totalAmountInWords = value; }
        public string InvoiceNote { get => invoiceNote; set => invoiceNote = value; }
        public string Status { get => status; set => status = value; }
        public string ReasonDelete { get => reasonDelete; set => reasonDelete = value; }
        public string BuyerCode { get => buyerCode; set => buyerCode = value; }
    }
}
