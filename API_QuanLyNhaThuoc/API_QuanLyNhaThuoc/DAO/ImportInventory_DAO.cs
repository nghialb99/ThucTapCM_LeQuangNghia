using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DAO
{
    class ImportInventory_DAO
    {
        private static ImportInventory_DAO instance;

        public static ImportInventory_DAO Instance
        {
            get { if (instance == null) instance = new ImportInventory_DAO(); return instance; }
            private set { instance = value; }
        }

        private ImportInventory_DAO() { }

        public List<ImportInventory> GetListImportGoods(DateTime dateFrom, DateTime dateTo)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC ThongKePNT @date1 , @date2 ", new object[] { dateFrom, dateTo });
            List<ImportInventory> listImp = new List<ImportInventory>();
            foreach (DataRow item in data.Rows)
            {
                ImportInventory list = new ImportInventory(item);
                listImp.Add(list);
            }
            return listImp;
        }
        public List<ImportInventory> GetFullListImportGoods(string text)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetImportInventory @text", new object[] { text });
            List<ImportInventory> listImp = new List<ImportInventory>();
            foreach (DataRow item in data.Rows)
            {
                ImportInventory list = new ImportInventory(item);
                listImp.Add(list);
            }
            return listImp;
        }
        public bool CheckUserCreateImportInventory(string id, string user)
        {
            return DataProvider.Instance.ExcuteScalar("exec CheckUserCreateImportInventory @id ", new object[] { id }).ToString() == user;
        }
        public bool InsertImprortBill( string userName, float totalAmount, string note)
        {
            return DataProvider.Instance.ExcuteNunQuery("exec CreateImportInventory @userName , @totalAmount , @note",
                new object[] { userName, totalAmount, note }) > 0;
        }
        public int InsertImprortDetailBill(string ProductName, string CategoryProduct, string Dosage, string From, string PackagingSpecifications, int ExchangeValue, string UnitName, string BatchNo, DateTime ManDate, DateTime ExpDate, string UnitNameImport, float UnitPriceImport, int QuantityImport, string ImportInventoryId)
        {
            string query = "InsertDetailImportInventory @ProductName , @CategoryProduct , @Dosage , @From , @PackagingSpecifications , @ExchangeValue , @UnitName , @BatchNo , @ManDate , @ExpDate , @UnitNameImport , @UnitPriceImport , @QuantityImport , @ImportInventoryId ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { ProductName, CategoryProduct, Dosage, From, PackagingSpecifications, ExchangeValue, UnitName, BatchNo, ManDate, ExpDate, UnitNameImport, UnitPriceImport, QuantityImport, ImportInventoryId });
        }
        public bool DeleteImprortBill(string id)
        {
            return DataProvider.Instance.ExcuteNunQuery("exec DeleteImportInventory @id ", new object[] { id }) > 0;
        }
        public int GetTotalImprtBillThisMonth()
        {
            return Convert.ToInt32(DataProvider.Instance.ExcuteScalar("EXEC TongPNTthangnay"));
        }
        public int GetTotalImprtBillLastMonth()
        {
            return Convert.ToInt32(DataProvider.Instance.ExcuteScalar("EXEC TongPNTthangtruoc"));
        }
        public float GetTotalSpendThisMonth()
        {
            return (float)Convert.ToDouble(DataProvider.Instance.ExcuteScalar("EXEC TonTienNhapTonthangnay"));
        }
        public float GetTotalSpendLastMonth()
        {
            return (float)Convert.ToDouble(DataProvider.Instance.ExcuteScalar("EXEC TongTienNhapTonthangtruoc"));
        }
        public bool CheckIsImportInventoryDone(string id)
        {
            return Convert.ToInt32(DataProvider.Instance.ExcuteScalar("EXEC CheckIsImportInventoryDone @id ", new object[] { id })) > 0;
        }
    }
}
