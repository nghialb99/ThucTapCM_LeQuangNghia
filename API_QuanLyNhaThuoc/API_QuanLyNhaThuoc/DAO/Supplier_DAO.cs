using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DAO
{
    public class Supplier_DAO
    {
        private static Supplier_DAO instance;

        public static Supplier_DAO Instance
        {
            get { if (instance == null) instance = new Supplier_DAO(); return instance; }
            private set { instance = value; }
        }

        private Supplier_DAO() { }

        public List<Supplier> GetListSupplier(string text)
        {
            List<Supplier> listSupplier = new List<Supplier>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetSupplier @text ", new object[] { text });
            foreach(DataRow item in data.Rows)
            {
                Supplier list = new Supplier(item);
                listSupplier.Add(list);
            }
            return listSupplier;
        }
        public Supplier GetSupplierById(string id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetSupplierById @text ", new object[] { id });
            foreach(DataRow item in data.Rows)
            {
                return new Supplier(item);
            }
            return null;
        }
        public bool InsertSupplier(string TaxCode,string Name,string IdGr,string Email,string Website,string Phone,string Addr,string Note)
        {
            string query = "EXEC NHAPNCC @MST , @TEN , @MANHOM , @SDT , @DIACHI , @EMAIL , @WEBSITE , @NOTE ";
            try
            {
                return DataProvider.Instance.ExcuteNunQuery(query,new object[] { TaxCode, Name, IdGr, Email, Addr, Phone, Website, Note }) > 0;
            }
            catch { return false; }
        }
        public bool UpdateSupplier(string TaxCode, string Name, string IdGr, string Email, string Website, string Phone, string Addr, string Note)
        {
            string query = "EXEC UPDATENCC @MST , @TEN , @MANHOM , @SDT , @DIACHI , @EMAIL , @WEBSITE , @NOTE ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { TaxCode, Name, IdGr, Email, Addr, Phone, Website, Note }) > 0;
        }
        public bool LockSupplier(string taxcode)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC LOCKNCC @MST ",new object[] { taxcode}) > 0;
        }
        public bool UnLockSupplier(string taxcode)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC UNLOCKNCC @MST ", new object[] { taxcode }) > 0;
        }
        public bool CheckIsImportBillDone(string id)
        {
            return Convert.ToInt32(DataProvider.Instance.ExcuteScalar("EXEC CheckIsImportBillDone @id ", new object[] { id })) > 0;
        }
    }
}
