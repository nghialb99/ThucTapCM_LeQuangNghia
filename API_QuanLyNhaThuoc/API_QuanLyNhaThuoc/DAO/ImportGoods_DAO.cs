using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DAO
{
    class ImportGoods_DAO
    {
        private static ImportGoods_DAO instance;

        public static ImportGoods_DAO Instance
        {
            get { if (instance == null) instance = new ImportGoods_DAO(); return instance; }
            private set { instance = value; }
        }

        private ImportGoods_DAO() { }

        public List<ImportGoods> GetListImportGoods(DateTime dateFrom , DateTime dateTo)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC ThongKePN @date1 , @date2 ", new object[] {dateFrom, dateTo});
            List<ImportGoods> listImp = new List<ImportGoods>();
            foreach(DataRow item in data.Rows)
            {
                ImportGoods list = new ImportGoods(item);
                listImp.Add(list);
            }
            return listImp;
        }
        public List<ImportGoods> GetFullListImportGoods()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetImportBill ");
            List<ImportGoods> listImp = new List<ImportGoods>();
            foreach (DataRow item in data.Rows)
            {
                ImportGoods list = new ImportGoods(item);
                listImp.Add(list);
            }
            return listImp;
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
