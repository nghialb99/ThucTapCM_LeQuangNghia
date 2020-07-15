using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DAO
{
    class ImportBill_DAO
    {
        private static ImportBill_DAO instance;

        public static ImportBill_DAO Instance
        {
            get { if (instance == null) instance = new ImportBill_DAO(); return instance; }
            private set { instance = value; }
        }

        private ImportBill_DAO() { }

        public List<ImportBill> GetListImportGoods(DateTime dateFrom , DateTime dateTo)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC ThongKePN @date1 , @date2 ", new object[] {dateFrom, dateTo});
            List<ImportBill> listImp = new List<ImportBill>();
            foreach(DataRow item in data.Rows)
            {
                ImportBill list = new ImportBill(item);
                listImp.Add(list);
            }
            return listImp;
        }
        public List<ImportBill> GetFullListImportGoods(string text)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetImportBill @text",new object[]{text});
            List<ImportBill> listImp = new List<ImportBill>();
            foreach (DataRow item in data.Rows)
            {
                ImportBill list = new ImportBill(item);
                listImp.Add(list);
            }
            return listImp;
        }
        public bool CheckUserCreateImportBill(string id,string user)
        {
            return DataProvider.Instance.ExcuteScalar("exec CheckUserCreateImportBill @id ",new object[] {id}).ToString() == user;
        }
        public bool InsertImprortBill( DateTime date ,  string userName ,  string SupplierTaxCode ,  int vat ,  float totalAmount ,  string note)
        {
            return DataProvider.Instance.ExcuteNunQuery("exec CreateImportBill @date , @userName , @SupplierTaxCode , @vat , @totalAmount , @note",
                new object[]{ date, userName, SupplierTaxCode, vat, totalAmount, note }) > 0;
        }
        public int InsertImprortDetailBill(string ProductName, string CategoryProduct, string Dosage, string From, string PackagingSpecifications, int ExchangeValue, string UnitName, string BatchNo, DateTime ManDate, DateTime ExpDate, string UnitNameImport, float UnitPriceImport, int QuantityImport, string ImportBillId)
        {
            string query = "InsertDetailImportBill @ProductName , @CategoryProduct , @Dosage , @From , @PackagingSpecifications , @ExchangeValue , @UnitName , @BatchNo , @ManDate , @ExpDate , @UnitNameImport , @UnitPriceImport , @QuantityImport , @ImportBillId ";
            return DataProvider.Instance.ExcuteNunQuery(query,new object[] { ProductName, CategoryProduct, Dosage, From, PackagingSpecifications, ExchangeValue, UnitName, BatchNo, ManDate, ExpDate, UnitNameImport, UnitPriceImport, QuantityImport, ImportBillId });
        }
        public bool DeleteImprortBill(string id)
        {
            return DataProvider.Instance.ExcuteNunQuery("exec DeleteImportBill @id ",
                new object[] { id }) > 0;
        }
        public int GetTotalImprtBillThisMonth()
        {
            return Convert.ToInt32(DataProvider.Instance.ExcuteScalar("EXEC TongPNthangnay"));
        }
        public int GetTotalImprtBillLastMonth()
        {
            return Convert.ToInt32(DataProvider.Instance.ExcuteScalar("EXEC TongPNthangtruoc"));
        }
        public float GetTotalSpendThisMonth()
        {
            return (float)Convert.ToDouble(DataProvider.Instance.ExcuteScalar("EXEC TonChithangnay"));
        }
        public float GetTotalSpendLastMonth()
        {
            return (float)Convert.ToDouble(DataProvider.Instance.ExcuteScalar("EXEC TongChithangtruoc"));
        }
    }
}
