using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DAO
{
    public class Buyer_DAO
    {
        private static Buyer_DAO instance;

        public static Buyer_DAO Instance
        {
            get { if (instance == null) instance = new Buyer_DAO(); return instance; }
            private set { instance = value; }
        }

        private Buyer_DAO() { }

        public List<Buyer> GetListBuyer(string text)
        {
            List<Buyer> listBuyer = new List<Buyer>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetListBuyer @text ", new object[]{text});
            foreach(DataRow item in data.Rows)
            {
                Buyer list = new Buyer(item);
                listBuyer.Add(list);
            }
            return listBuyer;
        }
        public List<Buyer> GetListBuyerWhenCreateInvoice(string text)
        {
            List<Buyer> listBuyer = new List<Buyer>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetListBuyerWhenCreateInvoice @text ", new object[] { text });
            foreach (DataRow item in data.Rows)
            {
                Buyer list = new Buyer(item);
                listBuyer.Add(list);
            }
            return listBuyer;
        }
        public Buyer GetListBuyerById(string id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from ThongTinKhachHang where MaKH = '" + id + "'");
            foreach(DataRow item in data.Rows)
            {
                return new Buyer(item);
            }
            return null;
        }
        public bool UnLockBuyer(string code)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC UnLockBuyer @code ", new object[] { code }) > 0;
        }
        public bool LockBuyer(string code)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC LockBuyer @code ", new object[] { code }) > 0;
        }
        public bool InsertBuyer(string code, string name, string taxCode, string phone,string email,string address)
        {
            try
            {
                return DataProvider.Instance.ExcuteNunQuery("EXEC InsertBuyer @code , @name , @taxCode , @address , @phone , @email ", 
                    new object[]{code,name,taxCode,address,phone,email}) > 0;
            }
            catch { return false; }
        }
        public bool UpdateBuyer(string code, string name, string taxCode, string phone, string email, string address)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC UpdateBuyer @code , @name , @taxCode , @address , @phone , @email ",
                new object[]{ code, name, taxCode, address, phone, email }) > 0;
        }
    }
}
