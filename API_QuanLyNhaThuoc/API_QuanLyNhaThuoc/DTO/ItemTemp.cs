using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DTO
{
    public class ItemTemp
    {
        //id int identity,IdItemCode nvarchar(8),UnitName nvarchar(200),quantity float,unitPrice float
        private int id;
        private string idItemCode;
        private string unitName;
        private int exchangeValue;
        private float quantity;
        private float unitPrice;

        public ItemTemp(int id, string idItemCode, string unitName, int exchangeValue, float quantity, float unitPrice)
        {
            this.Id = id;
            this.IdItemCode = idItemCode;
            this.UnitName = unitName;
            this.ExchangeValue = exchangeValue;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
        }
        public ItemTemp(DataRow row)
        {
            this.Id = Convert.ToInt32(row["id"]);
            this.IdItemCode = row["idItemCode"].ToString();
            this.UnitName = row["unitName"].ToString();
            this.ExchangeValue = (int)row["exchangeValue"];
            this.Quantity = (float)Convert.ToDouble(row["quantity"]);
            this.UnitPrice = (float)Convert.ToDouble(row["unitPrice"]);
        }
        public int Id { get => id; set => id = value; }
        public string IdItemCode { get => idItemCode; set => idItemCode = value; }
        public string UnitName { get => unitName; set => unitName = value; }
        public float Quantity { get => quantity; set => quantity = value; }
        public float UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int ExchangeValue { get => exchangeValue; set => exchangeValue = value; }
    }
}
