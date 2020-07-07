using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class Supplier
    {
        private string taxCode;
        private string name;
        private string idGr;
        private string email;
        private string website;
        private string phone;
        private string addr;
        private string note;
        private string status;

        public Supplier(string taxCode, string name, string idGr, string email, string website, string phone, string addr, string note, string status)
        {
            this.TaxCode = taxCode;
            this.Name = name;
            this.IdGr = idGr;
            this.Email = email;
            this.Website = website;
            this.Phone = phone;
            this.Addr = addr;
            this.Note = note;
            this.Status = status;
        }
        public Supplier(DataRow row)
        {
            this.TaxCode = row["taxcode"].ToString();
            this.Name = row["ten"].ToString();
            this.IdGr = row["manhom"].ToString();
            this.Email = row["Email"].ToString();
            this.Website = row["Website"].ToString();
            this.Phone = row["sdt"].ToString();
            this.Addr = row["diachi"].ToString();
            this.Note = row["ghichu"].ToString();
            if (Convert.ToBoolean(row["status"])) this.Status = "Hoạt động";
            else this.Status = "Bị khóa";
        }


        public string Name { get => name; set => name = value; }
        public string IdGr { get => idGr; set => idGr = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Addr { get => addr; set => addr = value; }
        public string Website { get => website; set => website = value; }
        public string Email { get => email; set => email = value; }
        public string TaxCode { get => taxCode; set => taxCode = value; }
        public string Note { get => note; set => note = value; }
        public string Status { get => status; set => status = value; }
    }
}
