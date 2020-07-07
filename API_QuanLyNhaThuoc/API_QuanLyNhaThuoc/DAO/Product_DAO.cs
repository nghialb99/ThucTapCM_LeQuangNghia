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
        public List<Product> GetListProductWhenCreateInvoice()
        {
            List<Product> listproduct = new List<Product>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetListProductWhenCreateInvoice");
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
    }
}
