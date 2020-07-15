using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class ImportInventory
    {
        private string id;
        private DateTime dateCreate;
        private string creator;
        private float totalAmountWithVat;
        private string note;
        private string status;

        public ImportInventory(string id, DateTime dateCreate, string creator, float totalAmountWithVat, string note, string status)
        {
            this.Id = id;
            this.DateCreate = dateCreate;
            this.Creator = creator;
            this.TotalAmountWithVat = totalAmountWithVat;
            this.Note = note;
            this.Status = status;
        }
        public ImportInventory(DataRow row)
        {
            this.Id = row["SO_PN"].ToString();
            this.DateCreate = Convert.ToDateTime(row["NGAYLAP"]);
            this.Creator = row["USERNAME"].ToString();
            this.TotalAmountWithVat = (float)Convert.ToDouble(row["TONGTIEN"]);
            this.Note = row["ghichu"].ToString();
            if (Convert.ToInt32(row["status"]) == 0)
                this.Status = "Xóa bỏ";
            else if (Convert.ToInt32(row["status"]) == 1)
                this.Status = "Dự thảo";
            else this.Status = "Hoàn thành";
        }

        public string Id { get => id; set => id = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public string Creator { get => creator; set => creator = value; }
        public float TotalAmountWithVat { get => totalAmountWithVat; set => totalAmountWithVat = value; }
        public string Note { get => note; set => note = value; }
        public string Status { get => status; set => status = value; }
    }
}
