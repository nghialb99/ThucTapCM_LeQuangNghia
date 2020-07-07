using API_QuanLyNhaThuoc.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class Product
    {
        private string syntheticName;//Tên tổng hợp
        private string id;
        private string name;
        private string idCategory;
        private string batchNo;//Số lô
        private string dosage;//Hàm lượng
        private string from; //xuất xứ
        private string packagingSpecifications;//Quy cách đóng gói
        private string unitName; //Đơn vị tính
        private DateTime manDate;
        private DateTime expDate;
        private int inventoryNumber;//Số lượng tồn kho
        private string unitInput; // đơn vị nhập
        private int exchangeValue;//Giá trị quy đổi
        private float unitPrice; // Giá bán
        private int quantityInput; // Số lượng nhập
        private string status;
        private Image image;

        public Product(string syntheticName, string id, string name, string idCategory, string batchNo, string dosage, string from, string packagingSpecifications, string unitName, DateTime manDate, DateTime expDate, int inventoryNumber, string unitInput, int exchangeValue, float unitPrice, string status,Image image)
        {
            this.SyntheticName = syntheticName;
            this.Id = id;
            this.Name = name;
            this.IdCategory = idCategory;
            this.BatchNo = batchNo;
            this.Dosage = dosage;
            this.From = from;
            this.PackagingSpecifications = packagingSpecifications;
            this.UnitName = unitName;
            this.ManDate = manDate;
            this.ExpDate = expDate;
            this.InventoryNumber = inventoryNumber;
            this.UnitInput = unitInput;
            this.ExchangeValue = exchangeValue;
            this.UnitPrice = unitPrice;
            this.QuantityInput = quantityInput;
            this.Status = status;
            this.Image = image;
        }
        public Product(DataRow row)
        {
            this.SyntheticName = "Mã sản phẩm: " + row["mathuoc"].ToString() + "  Loại: " + row["maloai"].ToString() + "\nTên sản phẩm: " + row["ten"].ToString() + "  " + row["Hamluong"] + "\nĐóng gói: " + row["quycachdonggoi"].ToString() + "\nSố lô: " + row["solo"].ToString() + "\nXuất sứ: " + row["xuatsu"];
            this.Id = row["mathuoc"].ToString();
            this.Name = row["ten"].ToString();
            this.IdCategory = row["maloai"].ToString();
            this.BatchNo = row["solo"].ToString();
            this.Dosage = row["hamLuong"].ToString();
            this.From = row["xuatsu"].ToString();
            this.PackagingSpecifications = row["QUYCACHDONGGOI"].ToString();
            this.UnitName = row["donViCoBan"].ToString();
            this.ManDate = (DateTime)row["nSX"];
            this.ExpDate = (DateTime)row["hSD"];
            this.InventoryNumber = (int)row["soLuongton"];
            this.UnitInput = row["donVi_N"].ToString();
            this.ExchangeValue = (int)row["GIATRIQUYDOI"];
            this.UnitPrice = (float)Convert.ToDouble(row["DONGIA_B"].ToString());
            this.QuantityInput = (int)row["SOLUONG_N"];
            int a = (int)row["status"];
            if (a == 1) this.Status = "Sử dụng tốt";
            else if (a == 0) this.Status = "Đã hết hạn";
            else this.Status = "Sắp hết hạn";
            if (row["HinhAnh"].ToString() != "")
                this.Image = Product_DAO.Instance.ByteToImg(row["HinhAnh"].ToString());
            else
                this.Image = null;
        }
        public string SyntheticName { get => syntheticName; set => syntheticName = value; }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string IdCategory { get => idCategory; set => idCategory = value; }
        public string BatchNo { get => batchNo; set => batchNo = value; }
        public string Dosage { get => dosage; set => dosage = value; }
        public string From { get => from; set => from = value; }
        public string PackagingSpecifications { get => packagingSpecifications; set => packagingSpecifications = value; }
        public string UnitName { get => unitName; set => unitName = value; }
        public DateTime ManDate { get => manDate; set => manDate = value; }
        public DateTime ExpDate { get => expDate; set => expDate = value; }
        public int InventoryNumber { get => inventoryNumber; set => inventoryNumber = value; }
        public string UnitInput { get => unitInput; set => unitInput = value; }
        public int ExchangeValue { get => exchangeValue; set => exchangeValue = value; }
        public float UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int QuantityInput { get => quantityInput; set => quantityInput = value; }
        public string Status { get => status; set => status = value; }
        public Image Image { get => image; set => image = value; }
    }
}
