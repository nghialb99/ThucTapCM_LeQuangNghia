using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class UnitNames
    {
        private int id;
        private string name;

        public UnitNames(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public UnitNames(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.Name = row["Ten"].ToString(); ;
        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
