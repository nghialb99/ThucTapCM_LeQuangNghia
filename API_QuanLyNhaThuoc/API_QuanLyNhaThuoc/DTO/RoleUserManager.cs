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
        private bool checkImportFromSupplier;
        private bool checkInventory;
        private bool checkImportInventory;
        private bool checkCategoryProduct;
        private bool checkCategorySupplier;
        private bool checkCustomer;
        private bool checkSupplier;
        private bool checkProduct;
        private bool checkUsers;
        private bool checkRoleUser;
        private bool checkReportSell;
        private bool checkReportBuy;
        private bool checkReportImportInventory;
        private bool checkReportSendMail;
        private string status;

        public RoleUserManager(string roleName, string description, DateTime creationDate, bool checkCreateInvoice, bool checkInvoiceManager, bool checkWarehouseManager, bool checkCategory, bool checkEnterpriseInfo, bool checkUserManager, bool checkReport, bool checkSettings, bool checkImportFromSupplier, bool checkInventory, bool checkImportInventory, bool checkCategoryProduct, bool checkCategorySupplier, bool checkCustomer, bool checkSupplier, bool checkProduct, bool checkUsers, bool checkRoleUser, bool checkReportSell, bool checkReportBuy, bool checkReportImportInventory, bool checkReportSendMail, string status)
        {
            this.RoleName = roleName;
            this.Description = description;
            this.CreationDate = creationDate;
            this.CheckCreateInvoice = checkCreateInvoice;
            this.CheckInvoiceManager = checkInvoiceManager;
            this.CheckWarehouseManager = checkWarehouseManager;
            this.CheckCategory = checkCategory;
            this.CheckEnterpriseInfo = checkEnterpriseInfo;
            this.CheckUserManager = checkUserManager;
            this.CheckReport = checkReport;
            this.CheckSettings = checkSettings;
            this.CheckImportFromSupplier = checkImportFromSupplier;
            this.CheckInventory = checkInventory;
            this.CheckImportInventory = checkImportInventory;
            this.CheckCategoryProduct = checkCategoryProduct;
            this.CheckCategorySupplier = checkCategorySupplier;
            this.CheckCustomer = checkCustomer;
            this.CheckSupplier = checkSupplier;
            this.CheckProduct = checkProduct;
            this.CheckUsers = checkUsers;
            this.CheckRoleUser = checkRoleUser;
            this.CheckReportSell = checkReportSell;
            this.CheckReportBuy = checkReportBuy;
            this.CheckReportImportInventory = checkReportImportInventory;
            this.CheckReportSendMail = checkReportSendMail;
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
            this.CheckImportFromSupplier = Convert.ToBoolean(row["NhapTuNhaCungCap"]);
            this.CheckInventory = Convert.ToBoolean(row["TonKho"]);
            this.CheckImportInventory = Convert.ToBoolean(row["NhapTon"]);
            this.CheckCategoryProduct = Convert.ToBoolean(row["NhomSanPham"]);
            this.CheckCategorySupplier = Convert.ToBoolean(row["NhomNhaCungCap"]);
            this.CheckCustomer = Convert.ToBoolean(row["KhachHang"]);
            this.CheckSupplier = Convert.ToBoolean(row["NhaCungCap"]);
            this.CheckProduct = Convert.ToBoolean(row["SanPham"]);
            this.CheckUsers = Convert.ToBoolean(row["NguoiDung"]);
            this.CheckRoleUser = Convert.ToBoolean(row["NhomNguoiDung"]);
            this.CheckReportSell = Convert.ToBoolean(row["BCBanHang"]);
            this.CheckReportBuy = Convert.ToBoolean(row["BCNhapHang"]);
            this.CheckReportImportInventory = Convert.ToBoolean(row["BCNhapTon"]);
            this.CheckReportSendMail = Convert.ToBoolean(row["BCGuiMail"]);
            if (Convert.ToBoolean(row["Status"]))
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
        public bool CheckImportFromSupplier { get => checkImportFromSupplier; set => checkImportFromSupplier = value; }
        public bool CheckInventory { get => checkInventory; set => checkInventory = value; }
        public bool CheckImportInventory { get => checkImportInventory; set => checkImportInventory = value; }
        public bool CheckCategoryProduct { get => checkCategoryProduct; set => checkCategoryProduct = value; }
        public bool CheckCategorySupplier { get => checkCategorySupplier; set => checkCategorySupplier = value; }
        public bool CheckCustomer { get => checkCustomer; set => checkCustomer = value; }
        public bool CheckSupplier { get => checkSupplier; set => checkSupplier = value; }
        public bool CheckProduct { get => checkProduct; set => checkProduct = value; }
        public bool CheckUsers { get => checkUsers; set => checkUsers = value; }
        public bool CheckRoleUser { get => checkRoleUser; set => checkRoleUser = value; }
        public bool CheckReportSell { get => checkReportSell; set => checkReportSell = value; }
        public bool CheckReportBuy { get => checkReportBuy; set => checkReportBuy = value; }
        public bool CheckReportImportInventory { get => checkReportImportInventory; set => checkReportImportInventory = value; }
        public bool CheckReportSendMail { get => checkReportSendMail; set => checkReportSendMail = value; }
        public string Status { get => status; set => status = value; }
    }
}
