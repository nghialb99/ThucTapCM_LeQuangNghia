using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class ConfigurationEmail
    {
        private string configurationName;
        private string emailAddress;
        private string pass;
        private string server;
        private int port;
        private string status;

        public ConfigurationEmail(string configurationName, string emailAddress, string pass, string server, int port, string status)
        {
            this.ConfigurationName = configurationName;
            this.EmailAddress = emailAddress;
            this.Pass = pass;
            this.Server = server;
            this.Port = port;
            this.Status = status;
        }
        public ConfigurationEmail(DataRow row)
        {
            this.ConfigurationName = row["configurationName"].ToString();
            this.EmailAddress = row["email"].ToString();
            this.Pass = row["pass"].ToString();
            this.Server = row["sever"].ToString();
            this.Port = Convert.ToInt32(row["port"]);
            bool temp = Convert.ToBoolean(row["status"]);
            if (temp) this.Status = "Hoạt động";
            else this.Status = "Không hoạt động";

        }
        public string ConfigurationName { get => configurationName; set => configurationName = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string Server { get => server; set => server = value; }
        public int Port { get => port; set => port = value; }
        public string Status { get => status; set => status = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}
