using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DAO
{
    public class Category_DAO
    {
        private static Category_DAO instance;

        public static Category_DAO Instance
        {
            get { if (instance == null) instance = new Category_DAO(); return instance; }
            private set { instance = value; }
        }
        #region Product
        private Category_DAO() { }

        public DataTable GetListCategoryProduct(string text)
        {
            string query = "GetListCategoryProduct @text ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { text });
        }
        public bool UnLockCategoryProd(string code)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC UnLockCategorySP @code ", new object[] { code }) > 0;
        }
        public bool LockCategoryProd(string code)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC LockCategorySP @code ", new object[] { code }) > 0;
        }
        public bool InsertCategoryProd(string code, string name, string note)
        {
            try
            {
                return DataProvider.Instance.ExcuteNunQuery("InsertCategorySP @code , @name , @Note ",new object[] { code,name,note}) > 0;
            }
            catch { return false; }
        }
        public bool UpdateCategoryProd(string code, string name, string note)
        {
                return DataProvider.Instance.ExcuteNunQuery("UpdateCategorySP @code , @name , @Note ", new object[] { code, name, note }) > 0;
        }
        #endregion
        #region Supplier
        public DataTable GetListCategorySupplier(string text)
        {
            string query = "GetListCategoryNCC @text ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { text });
        }
        public bool UnLockCategorySupplier(string code)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC UnLockCategoryNCC @code ", new object[] { code }) > 0;
        }
        public bool LockCategorySupplier(string code)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC LockCategoryNCC @code ", new object[] { code }) > 0;
        }
        public bool InsertCategorySupplier(string code, string name, string note)
        {
            try
            {
                return DataProvider.Instance.ExcuteNunQuery("InsertCategoryNCC @code , @name , @Note ", new object[] { code, name, note }) > 0;
            }
            catch { return false; }
        }
        public bool UpdateCategorySupplier(string code, string name, string note)
        {
            return DataProvider.Instance.ExcuteNunQuery("UpdateCategoryNCC @code , @name , @Note ", new object[] { code, name, note }) > 0;
        }
        #endregion
    }
}
