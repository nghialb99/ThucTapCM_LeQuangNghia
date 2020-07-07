using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class UnitPrices
    {
        private int id;
        private string unitName;
        private int exchangeValue;
        private float unitprice;

        public UnitPrices(int id, string unitName, int exchangeValue, float unitprice)
        {
            this.Id = id;
            this.UnitName = unitName;
            this.ExchangeValue = exchangeValue;
            this.Unitprice = unitprice;
        }
        public UnitPrices(DataRow row)
        {
            this.Id = Convert.ToInt32(row["Id"]);
            this.UnitName = row["UnitName"].ToString();
            this.ExchangeValue = Convert.ToInt32(row["exchangeValue"]);
            this.Unitprice = (float)Convert.ToDouble(row["Unitprice"]);
        }

        public int Id { get => id; set => id = value; }
        public string UnitName { get => unitName; set => unitName = value; }
        public int ExchangeValue { get => exchangeValue; set => exchangeValue = value; }
        public float Unitprice { get => unitprice; set => unitprice = value; }
    }
}
