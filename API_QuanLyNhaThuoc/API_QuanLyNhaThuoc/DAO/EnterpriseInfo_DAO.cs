using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DAO
{
    public class EnterpriseInfo_DAO
    {
        private static EnterpriseInfo_DAO instance;

        public static EnterpriseInfo_DAO Instance
        {
            get { if (instance == null) instance = new EnterpriseInfo_DAO();return instance; }
            private set { instance = value; }
        }
        private EnterpriseInfo_DAO() { }

        public List<EnterpriseInfo> LoadEnterpriseInfo(string taxcode)
        {
            List<EnterpriseInfo> list = new List<EnterpriseInfo>();
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from ThongTinDoanhNghiep where MST = "+taxcode);
            foreach(DataRow item in data.Rows)
            {
                EnterpriseInfo l = new EnterpriseInfo(item);
                list.Add(l);
            }
            return list;
        }
        public EnterpriseInfo LoadEnterpriseInfoById(string taxcode)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from ThongTinDoanhNghiep where MST = " + taxcode);
            foreach (DataRow item in data.Rows)
            {
                return new EnterpriseInfo(item);
            }
            return null;
        }
        public bool UpdateEnterpriseInfo(string EnterpriseName, string EnterpriseTaxCode, string EnterpriseAddress, string EnterpriseEmail, string EnterprisePhone, string EnterpriseWeb, string EnterpriseAccNo, string EnterpriseAccName)
        {
            string query = "exec UpdateEnterpriseInfo @EnterpriseName , @EnterpriseTaxCode , @EnterpriseAddress , @EnterpriseEmail , @EnterprisePhone , @EnterpriseWeb , @EnterpriseAccNo , @EnterpriseAccName ";
            int data = DataProvider.Instance.ExcuteNunQuery(query, new object[]
            { EnterpriseName, EnterpriseTaxCode, EnterpriseAddress, EnterpriseEmail, EnterprisePhone, EnterpriseWeb, EnterpriseAccNo, EnterpriseAccName});
            return data > 0;
        }
    }
}
