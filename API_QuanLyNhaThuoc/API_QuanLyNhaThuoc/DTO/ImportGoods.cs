using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class ImportGoods
    {
        private string id;
        private DateTime dateCreate;
        private string creator;
        private string supplier;
        private int vatRate;
        private float totalAmountWithVat;
        private string note;
        private string status;

        public ImportGoods(string id, DateTime dateCreate, string creator, string supplier, int vatRate, float totalAmountWithVat, string note, string status)
        {
            this.Id = id;
            this.DateCreate = dateCreate;
            this.Creator = creator;
            this.Supplier = supplier;
            this.VatRate = vatRate;
            this.TotalAmountWithVat = totalAmountWithVat;
            this.Note = note;
            this.Status = status;
        }
        public ImportGoods(DataRow row)
        {
            this.Id = row["SO_PN"].ToString();
            this.DateCreate = Convert.ToDateTime(row["NGAYLAP"]);
            this.Creator = row["USERNAME"].ToString();
            this.Supplier = row["TEN"].ToString();
            this.VatRate = Convert.ToInt32(row["VAT"]);
            this.TotalAmountWithVat = (float)Convert.ToDouble(row["TONGTIEN"]);
            this.Note = row["ghichu"].ToString();
            this.Status = row["TrangThai"].ToString();
        }

        public string Id { get => id; set => id = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public string Creator { get => creator; set => creator = value; }
        public string Supplier { get => supplier; set => supplier = value; }
        public int VatRate { get => vatRate; set => vatRate = value; }
        public float TotalAmountWithVat { get => totalAmountWithVat; set => totalAmountWithVat = value; }
        public string Note { get => note; set => note = value; }
        public string Status { get => status; set => status = value; }
    }
}
