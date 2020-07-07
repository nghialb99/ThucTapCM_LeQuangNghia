using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DAO
{
    public class Account_DAO
    {
        private static Account_DAO instance;

        public static Account_DAO Instance
        {
            get { if (instance == null) instance = new Account_DAO(); return instance; }
            private set { instance = value; }
        }

        private Account_DAO() { }
        public string Encrypt(string pass)
        {
            byte[] temp = ASCIIEncoding.UTF8.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        //public string Encrypt(string toEncrypt)
        //{
        //    bool useHashing = true;
        //    byte[] keyArray;
        //    byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

        //    if (useHashing)
        //    {
        //        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(toEncrypt));
        //    }
        //    else
        //        keyArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

        //    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //    tdes.Key = keyArray;
        //    tdes.Mode = CipherMode.ECB;
        //    tdes.Padding = PaddingMode.PKCS7;

        //    ICryptoTransform cTransform = tdes.CreateEncryptor();
        //    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

        //    return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        //}
        //public string Decrypt(string toDecrypt)
        //{
        //    bool useHashing = true;
        //    byte[] keyArray;
        //    byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

        //    if (useHashing)
        //    {
        //        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
        //        keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(toDecrypt));
        //    }
        //    else
        //        keyArray = UTF8Encoding.UTF8.GetBytes(toDecrypt);

        //    TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
        //    tdes.Key = keyArray;
        //    tdes.Mode = CipherMode.ECB;
        //    tdes.Padding = PaddingMode.PKCS7;

        //    ICryptoTransform cTransform = tdes.CreateDecryptor();
        //    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

        //    return UTF8Encoding.UTF8.GetString(resultArray);
        //}
        public bool CheckLogin(string username, string password)
        {
            string query = "exec CLogin @username , @password ";
            return DataProvider.Instance.ExcuteQuery(query, new object[] { username, Encrypt(password) }).Rows.Count > 0;
        }
        public string CheckUsername()
        {
            string user = FrmLogin.username;
            user = user.Trim(); // Xóa khoản trắng
            user = user.ToLower(); // chuyển chữ hoa thành chữ thường
            int i = user.IndexOf("_");
            if (i == -1) return user;
            else
            {
                user = user.Substring(0,i);
            }
            return user;
        }
        public string GetSellerTaxcodeByIdInvoice(string id)
        {
            string taxcode = DataProvider.Instance.ExcuteScalar("GetSellerTaxcodeByIdBill @id ",new object[]{ id }).ToString();
            taxcode = taxcode.Trim(); // Xóa khoản trắng
            taxcode = taxcode.ToLower(); // chuyển chữ hoa thành chữ thường
            int i = taxcode.IndexOf("_");
            if (i == -1) return taxcode;
            else
            {
                taxcode = taxcode.Substring(0, i);
            }
            return taxcode;
        }
        public List<UserAccount> GetListUerAccount(string text)
        {
            List<UserAccount> listUser = new List<UserAccount>();
            DataTable data = DataProvider.Instance.ExcuteQuery("exec GetListUser @text ",new object[] { text });

            foreach (DataRow item in data.Rows)
            {
                UserAccount list = new UserAccount(item);
                listUser.Add(list);
            }
            return listUser;
        }
        public UserAccount GetUserAccount(string username)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from nhanvien where username = '" + username + "'");

            foreach (DataRow item in data.Rows)
            {
                return new UserAccount(item);
            }
            return null;
        }
        public bool UpdateUserInfo(string user,string pass,string name,string idCard,string gender,DateTime birthdate,string phone,string email,string address)
        {
            string query = "EXEC UpdateAccountInfo @username , @pass , @name , @cmnd , @gt , @ns , @sdt , @Email , @diachi ";
            return DataProvider.Instance.ExcuteNunQuery(query,new object[] { user,pass,name,idCard,gender,birthdate,phone,email,address }) > 0;
        }
        public bool UpdateRoleForUser(string user, string role)
        {
            string query = "EXEC UpdateRoleForUser @username , @role ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { user, role }) > 0;
        }
        public bool InsertAccount(string user, string pass, string role, string name, string idCard, string gender, DateTime birthdate, string phone, string email, string address)
        {
            user = CheckUsername() + "_" + user;
            string query = "EXEC InsertAccount @USER , @PASS , @NHOMND , @HOTEN , @CMND , @GIOITINH , @NGAYSINH , @SDT , @EMAIL , @DIACHI ";
            try
            {
                return DataProvider.Instance.ExcuteNunQuery(query, new object[] { user, pass, role, name, idCard, gender, birthdate, phone, email, address }) > 0;
            }
            catch { return false; }
        }
        public bool UpdatePass(string user,string pass,string newpass)
        {
            string query = "EXEC UpdatePassAccount @username , @pass , @newpass ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { user,pass,newpass }) > 0;
        }
        public bool ResetPassByAdmin(string user)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC ResetPassByAdmin @user ", new object[] { user }) > 0;
        }
        public bool ChangePassWhenForgetPass( string user, string pass, string veriCode)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC UpdatePassAccountWhenForgetPass @username , @newpass , @MaXacNhan ",
                new object[] { user,pass,veriCode }) > 0;
        }
        public bool LockUser(string user)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC LockAccount @user ",new object[] { user }) > 0;
        }
        public bool UnLockUser(string user)
        {
            return DataProvider.Instance.ExcuteNunQuery("EXEC UnLockAccount @user ", new object[] { user }) > 0;
        }
        public bool CheckForgetPass(string user, string email)
        {
            return DataProvider.Instance.ExcuteQuery("EXEC CheckWhenForgetPass @username , @email ", new object[] { user, email }).Rows.Count > 0;
        }
        public string GetVerificationCode(string user, string email)
        {
            return DataProvider.Instance.ExcuteScalar("EXEC CheckWhenForgetPass @username , @email ", new object[] { user, email }).ToString();
        }
        public bool CheckStatus(string user)
        {
            return DataProvider.Instance.ExcuteQuery("EXEC CheckStatusWhenForgetPass @username ", new object[] { user }).Rows.Count > 0;
        }
    }
}
