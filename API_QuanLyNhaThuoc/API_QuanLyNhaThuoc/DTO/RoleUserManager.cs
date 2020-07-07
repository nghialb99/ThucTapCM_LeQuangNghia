using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class RoleUserManager
    {
        private string roleName; // Crt + R + E
        private string description;
        private DateTime creationDate;
        private bool checkCreateInvoice;
        private bool checkInvoiceManager;
        private bool checkWarehouseManager;
        private bool checkCategory;
        private bool checkEnterpriseInfo;
        private bool checkUserManager;
        private bool checkReport;
        private bool checkSettings;
        private string status;

        public RoleUserManager(string roleName, string description, DateTime creationDate, bool checkCreateInvoice, bool checkInvoiceManager, bool checkWarehouseManager, bool checkCatagory, bool checkEnterpriseInfo, bool checkUsermanager, bool checkReport, bool checkSettings, string status)
        {
            this.RoleName = roleName;
            this.Description = description;
            this.CreationDate = creationDate;
            this.CheckCreateInvoice = checkCreateInvoice;
            this.CheckInvoiceManager = checkInvoiceManager;
            this.CheckWarehouseManager = checkWarehouseManager;
            this.CheckCategory = checkCatagory;
            this.CheckEnterpriseInfo = checkEnterpriseInfo;
            this.CheckUserManager = checkUsermanager;
            this.CheckReport = checkReport;
            this.CheckSettings = checkSettings;
            this.Status = status;
        }
        public RoleUserManager(DataRow row)
        {
            this.RoleName = row["TenNhom"].ToString();
            this.Description = row["Mota"].ToString();
            this.CreationDate = (DateTime)row["NgayTao"];
            this.CheckCreateInvoice = Convert.ToBoolean(row["LapHoaDon"]);
            this.CheckInvoiceManager = Convert.ToBoolean(row["QuanLyHoaDon"]);
            this.CheckWarehouseManager = Convert.ToBoolean(row["QuanLyKho"]);
            this.CheckCategory = Convert.ToBoolean(row["DanhMuc"]);
            this.CheckEnterpriseInfo = Convert.ToBoolean(row["ThongTinDoanhNghiep"]);
            this.CheckUserManager = Convert.ToBoolean(row["QuanLyNguoiDung"]);
            this.CheckReport = Convert.ToBoolean(row["BaoCao"]);
            this.CheckSettings = Convert.ToBoolean(row["ThietLap"]);
            if(Convert.ToBoolean(row["Status"]))
                 this.Status = "Hoạt động";
            else this.Status = "Bị khóa";
        }

        public string RoleName { get => roleName; set => roleName = value; }
        public string Description { get => description; set => description = value; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }
        public bool CheckCreateInvoice { get => checkCreateInvoice; set => checkCreateInvoice = value; }
        public bool CheckInvoiceManager { get => checkInvoiceManager; set => checkInvoiceManager = value; }
        public bool CheckWarehouseManager { get => checkWarehouseManager; set => checkWarehouseManager = value; }
        public bool CheckCategory { get => checkCategory; set => checkCategory = value; }
        public bool CheckEnterpriseInfo { get => checkEnterpriseInfo; set => checkEnterpriseInfo = value; }
        public bool CheckUserManager { get => checkUserManager; set => checkUserManager = value; }
        public bool CheckReport { get => checkReport; set => checkReport = value; }
        public bool CheckSettings { get => checkSettings; set => checkSettings = value; }
        public string Status { get => status; set => status = value; }
    }
}
