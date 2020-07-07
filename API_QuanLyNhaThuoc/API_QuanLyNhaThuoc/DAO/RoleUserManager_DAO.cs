using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DAO
{
    class RoleUserManager_DAO
    {
        private static RoleUserManager_DAO instance;

        public static RoleUserManager_DAO Instance
        {
            get { if (instance == null) instance = new RoleUserManager_DAO(); return RoleUserManager_DAO.instance; }
            private set { RoleUserManager_DAO.instance = value; }
        }
        private RoleUserManager_DAO() {}

        public List<RoleUserManager> LoadListRoleUserManager(string text)
        {
            List<RoleUserManager> ListRole = new List<RoleUserManager>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC GetRole @text ",new object[]{text});
            foreach(DataRow item in data.Rows)
            {
                RoleUserManager list = new RoleUserManager(item);
                ListRole.Add(list);
            }
            return ListRole;
        }
        public List<RoleUserManager> CheckRoleUserManager(string username)
        {
            List<RoleUserManager> ListRole = new List<RoleUserManager>(0);
            DataTable data = DataProvider.Instance.ExcuteQuery("exec CheckRoleUser @Username ", new object[] { username });
            foreach (DataRow item in data.Rows)
            {
                RoleUserManager list = new RoleUserManager(item);
                ListRole.Add(list);
            }
            return ListRole;
        }
        public RoleUserManager CheckRoleUserByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("exec CheckRoleUser @Username ", new object[] { username });
            foreach (DataRow item in data.Rows)
            {
                return new RoleUserManager(item);
            }
            return null;
        }
        public RoleUserManager CheckRoleUserByRoleName(string roleName)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("exec CheckRoleUserByRoleName @name ", new object[] { roleName });
            foreach (DataRow item in data.Rows)
            {
                return new RoleUserManager(item);
            }
            return null;
        }
        public List<RoleUserManager> LoadRoleUserManagerByRoleName(string id)
        {
            List<RoleUserManager> ListRole = new List<RoleUserManager>(0);
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from NhomNguoiDung where TenNhom = '"+ id +"'");
            foreach (DataRow item in data.Rows)
            {
                RoleUserManager list = new RoleUserManager(item);
                ListRole.Add(list);
            }
            return ListRole;
        }
        public bool InsertRoleUser(string roleName, string description, byte checkCreateInvoice, byte checkInvoiceManager, byte checkWarehouseManager, byte checkCategory, byte checkEnterpriseInfo, byte checkUserManager, byte checkReport, byte checkSettings)
        {
            string query = "exec InsertRoleUser @TenNhom , @MoTa , @LapHoaDon , @QuanLyHoaDon , @QuanLyKho , @DanhMuc , @ThongTinDoanhNghiep , @QuanLyNguoiDung , @BaoCao , @ThietLap ";
            try
            {
                int a = DataProvider.Instance.ExcuteNunQuery(query, new object[]
                    { roleName, description, checkCreateInvoice, checkInvoiceManager, checkWarehouseManager, checkCategory, checkEnterpriseInfo, checkUserManager, checkReport, checkSettings});
                return a > 0;
            }
            catch { return false; }
        }
        public bool UpdateRoleUser(string roleName, string description, byte checkCreateInvoice, byte checkInvoiceManager, byte checkWarehouseManager, byte checkCatagory, byte checkEnterpriseInfo, byte checkUsermanager, byte checkReport, byte checkSettings)
        {
            string query = "exec UpdateRoleUser @TenNhom , @MoTa , @LapHoaDon , @QuanLyHoaDon , @QuanLyKho , @DanhMuc , @ThongTinDoanhNghiep , @QuanLyNguoiDung , @BaoCao , @ThietLap ";
            int a = DataProvider.Instance.ExcuteNunQuery(query, new object[]
            { roleName, description, checkCreateInvoice, checkInvoiceManager, checkWarehouseManager, checkCatagory, checkEnterpriseInfo, checkUsermanager, checkReport, checkSettings});
            return a > 0;
        }
        public bool LockRoleUser(string roleName, byte status)
        {
            if (status == 0) return false;
            else
            {
                int a = DataProvider.Instance.ExcuteNunQuery("exec LockRoleUser @TenNhom ", new object[] { roleName });
                return a>0;
            }
        }
        public bool UnLockRoleUser(string roleName, byte status)
        {
            if (status == 1) return false;
            else
            {
                int a = DataProvider.Instance.ExcuteNunQuery("exec UnLockRoleUser @TenNhom ", new object[] { roleName });
                return a > 0;
            }
        }
    }
}
