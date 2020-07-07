using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class UserAccount
    {
        private string userName;
        private string userDisplayName;
        private string roleUser;
        private string userIdCard;
        private string userGender;
        private DateTime? userBirthDate;
        private string userPhoneNumber;
        private string userEmail;
        private string userAddress;
        private string userStatus;
        public UserAccount(string userName, string userDisplayName, string roleUser, string userIdCard, string userGender, DateTime? userBirthDate, string userPhoneNumber, string userEmail, string userAddress, string userStatus)
        {
            this.UserName = userName;
            this.UserDisplayName = userDisplayName;
            this.RoleUser = roleUser;
            this.UserIdCard = userIdCard;
            this.UserGender = userGender;
            this.UserBirthDate = userBirthDate;
            this.UserPhoneNumber = userPhoneNumber;
            this.UserEmail = userEmail;
            this.UserAddress = userAddress;
            this.UserStatus = userStatus;
        }
        public UserAccount(DataRow row)
        {
            this.UserName = row["username"].ToString();
            //this.Password = row["password"].ToString();
            this.RoleUser = row["NhomNguoiDung"].ToString();
            this.UserDisplayName = row["hoten"].ToString();
            this.UserIdCard = row["cmnd"].ToString();
            this.UserGender = row["gioitinh"].ToString();
            this.UserBirthDate = (DateTime?)row["ngaysinh"];
            this.UserPhoneNumber = row["sdt"].ToString();
            this.UserEmail = row["Email"].ToString();
            this.UserAddress = row["diachi"].ToString();
            bool t = Convert.ToBoolean(row["status"].ToString());
            if (t)
                this.UserStatus = "Hoạt động";
            else this.UserStatus = "Bị khóa";
        }
        public string UserName { get => userName; set => userName = value; }
        public string UserDisplayName { get => userDisplayName; set => userDisplayName = value; }
        public string RoleUser { get => roleUser; set => roleUser = value; }
        public string UserIdCard { get => userIdCard; set => userIdCard = value; }
        public string UserGender { get => userGender; set => userGender = value; }
        public DateTime? UserBirthDate { get => userBirthDate; set => userBirthDate = value; }
        public string UserPhoneNumber { get => userPhoneNumber; set => userPhoneNumber = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string UserAddress { get => userAddress; set => userAddress = value; }
        public string UserStatus { get => userStatus; set => userStatus = value; }
    }
}
