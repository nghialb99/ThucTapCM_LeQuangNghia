using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class EnterpriseInfo
    {
        private string enterpriseName;
        private string enterpriseTaxCode;
        private string enterpriseAddress;
        private string enterpriseEmail;
        private string enterprisePhone;
        private string enterpriseWeb;
        private string enterpriseAccNo;
        private string enterpriseAccName;

        public EnterpriseInfo(string enterpriseName, string enterpriseTaxCode, string enterpriseAddress, string enterpriseEmail, string enterprisePhone, string enterpriseWeb, string enterpriseAccNo, string enterpriseAccName)
        {
            this.EnterpriseName = enterpriseName;
            this.EnterpriseTaxCode = enterpriseTaxCode;
            this.EnterpriseAddress = enterpriseAddress;
            this.EnterpriseEmail = enterpriseEmail;
            this.EnterprisePhone = enterprisePhone;
            this.EnterpriseWeb = enterpriseWeb;
            this.EnterpriseAccNo = enterpriseAccNo;
            this.EnterpriseAccName = enterpriseAccName;
        }
        public EnterpriseInfo(DataRow row)
        {
            this.EnterpriseName = row["TenDoanhNghiep"].ToString();
            this.EnterpriseTaxCode = row["MST"].ToString();
            this.EnterpriseAddress = row["DiaChi"].ToString();
            this.EnterpriseEmail = row["Email"].ToString();
            this.EnterprisePhone = row["SoDienThoai"].ToString();
            this.EnterpriseWeb = row["Website"].ToString();
            this.EnterpriseAccNo = row["SoTaiKhoan"].ToString();
            this.EnterpriseAccName = row["TenNganHang"].ToString();
        }

        public string EnterpriseName { get => enterpriseName; set => enterpriseName = value; }
        public string EnterpriseTaxCode { get => enterpriseTaxCode; set => enterpriseTaxCode = value; }
        public string EnterpriseAddress { get => enterpriseAddress; set => enterpriseAddress = value; }
        public string EnterpriseEmail { get => enterpriseEmail; set => enterpriseEmail = value; }
        public string EnterprisePhone { get => enterprisePhone; set => enterprisePhone = value; }
        public string EnterpriseWeb { get => enterpriseWeb; set => enterpriseWeb = value; }
        public string EnterpriseAccNo { get => enterpriseAccNo; set => enterpriseAccNo = value; }
        public string EnterpriseAccName { get => enterpriseAccName; set => enterpriseAccName = value; }
    }
}
