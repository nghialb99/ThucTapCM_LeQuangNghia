using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DAO
{
    public class Product_DAO
    {
        private static Product_DAO instance;

        public static Product_DAO Instance
        {
            get { if (instance == null) instance = new Product_DAO(); return instance; }
            private set { instance = value; }
        }

        private Product_DAO() { }

        public bool CheckIsEXISTSProductWhenCreateInvoice(string id,string user)
        {
            string query = "select COUNT(*) from SANPHAM where EXISTS (SELECT * FROM GiaBanLe WHERE SANPHAM.MATHUOC = GiaBanLe.idSanPham) and status != 0 and statusDelete = 1 and MATHUOC =N'" + id + "' and not EXISTS (select * from ItemInvoiceTemp"+ user + " where IdItemCode =N'" + id+"') and SOLUONGTON >0";
            return (int)DataProvider.Instance.ExcuteScalar(query) == 1;
        }
        public List<Product> LoadListProduct(string text,int status)
        {
            List<Product> listproduct = new List<Product>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetListProduct @text , @status ", new object[] { text,status });
            foreach(DataRow item in data.Rows)
            {
                Product list = new Product(item);
                listproduct.Add(list);
            }
            return listproduct;
        }
        public List<Product> GetListProduct(string text)
        {
            List<Product> listproduct = new List<Product>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC SearchListProduct @text ", new object[] { text });
            foreach (DataRow item in data.Rows)
            {
                Product list = new Product(item);
                listproduct.Add(list);
            }
            return listproduct;
        }
        public List<Product> GetListProductWhenCreateInvoice(string text,string user)
        {
            List<Product> listproduct = new List<Product>();
            string query = "select * from SANPHAM where EXISTS (SELECT * FROM GiaBanLe WHERE SANPHAM.MATHUOC = GiaBanLe.idSanPham) and not EXISTS (SELECT * FROM ItemInvoiceTemp"+user+ " WHERE SANPHAM.MATHUOC = ItemInvoiceTemp"+user+".IdItemCode) and status != 0 and CONCAT(MATHUOC,TEN,MALOAI,solo) like '%'+N'" + text+"'+'%' and statusDelete = 1 and SOLUONGTON > 0";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Product list = new Product(item);
                listproduct.Add(list);
            }
            return listproduct;
        }
        public Product GetProductById(string id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetProductById @id ", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                return new Product(item);
            }
            return null;
        }
        public Product GetProductWhenCreateInvoice(string id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetProductWhenCreateInvoice @id ", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                return new Product(item);
            }
            return null;
        }
        public Product GetFullProductById(string id) // hết hạn + còn hạn
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetFullProductById @id ", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                return new Product(item);
            }
            return null;
        }
        public List<UnitPrices> GetUnitPrice(string idProcduct,string text)
        {
            List<UnitPrices> listproduct = new List<UnitPrices>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetUnitPrice @text , @idProduct ", new object[] { text, idProcduct });
            foreach (DataRow item in data.Rows)
            {
                UnitPrices list = new UnitPrices(item);
                listproduct.Add(list);
            }
            return listproduct;
        }
        public UnitPrices GetUnitPriceWhenCreateInvoice(int id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetUnitPriceWhenCreateInvoice @id", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                return new UnitPrices(item);
            }
            return null;
        }
        public List<UnitNames> GetUnitName( string text)
        {
            List<UnitNames> listproduct = new List<UnitNames>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetUnitName @text ", new object[] { text });
            foreach (DataRow item in data.Rows)
            {
                UnitNames list = new UnitNames(item);
                listproduct.Add(list);
            }
            return listproduct;
        }
        public bool InsertUnitPrice(string idProduct, int idUnitName, int exchangeValue, float unitPrice)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC InsertUnitPrice @idProduct , @idUnitName , @exchangeValue , @UnitPrice ",
                new object[] { idProduct, idUnitName, exchangeValue, unitPrice }) > 0;
        }
        public bool UpdateUnitPrice(int id, string idProduct, int idUnitName, int exchangeValue, float unitPrice)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC UpdateUnitPrice @id , @idProduct , @idUnitName , @exchangeValue , @UnitPrice ", 
                new object[] {id, idProduct, idUnitName, exchangeValue,unitPrice }) > 0;
        }
        public bool DeleteUnitPrice(int id)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC DeleteUnitPrice @id ", new object[] { id }) > 0;
        }
        public bool UpdateImageProduct(string id,string image)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC UpdateProduct @id , @image ",new object[]{ id,image}) > 0;
        }
        public Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public bool AutoUpdateStatusProduct()
        {
            return DataProvider.Instance.ExcuteNunQuery("autoUpdateStatusProduct") > 0;
        }
    }
}
