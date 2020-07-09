using API_QuanLyNhaThuoc.DAO;
using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_QuanLyNhaThuoc
{
    public partial class FrmItems : Form
    {
        private string itemCode;
        private int id;
        private Logout UpdateTotalAmount;
        private CultureInfo culture = new CultureInfo("vi-VN");
        public FrmItems(Logout dl,int Id,string ItemCode)
        {
            InitializeComponent();
            UpdateTotalAmount = dl;
            itemCode = ItemCode;
            id = Id;
        }
        private void FrmItems_Load(object sender, EventArgs e)
        {
            Product pr = Product_DAO.Instance.GetProductWhenCreateInvoice(itemCode);
            pictureBox1.Image = pr.Image;
            lbItemName.Text = pr.ShortName;
            InventoryNumber = pr.InventoryNumber;
            tbQuantity.Text = "1";

            List<UnitPrices> price = Product_DAO.Instance.GetUnitPrice(itemCode,"");
            cbUnitName.ValueMember = "Id";
            cbUnitName.DisplayMember = "UnitName";
            cbUnitName.DataSource = price;
        }
        private int InventoryNumber = 0;

        private void btDelete_Click(object sender, EventArgs e)
        {
            DataProvider.Instance.ExcuteNunQuery("exec DeleteItemInvoiceTemp @id ",new object[] { id });
            UpdateTotalAmount();
            this.Close();
        }
        private void UpdateItemWhenEdit()
        {
            lbTotalAmount.Text = (Convert.ToDouble(tbQuantity.Text) * unitPrice).ToString("C0", culture);
            Invoice_DAO.Instance.UpdateItemInvoiceTemp(id, cbUnitName.Text, (float)Convert.ToDouble(tbQuantity.Text), unitPrice);
        }

        private float unitPrice;
        private void cbUnitName_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitPrices unit = Product_DAO.Instance.GetUnitPriceWhenCreateInvoice(Convert.ToInt32(cbUnitName.SelectedValue));
            lbUnitPrice.Text = unit.Unitprice.ToString("C0",culture);
            unitPrice = unit.Unitprice;

            UpdateItemWhenEdit();
            UpdateTotalAmount();
        }
        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                if (Convert.ToInt32(tbQuantity.Text) >= 1 && Convert.ToInt32(tbQuantity.Text) <= InventoryNumber)
                {
                    tbQuantity.Text = (Convert.ToDouble(tbQuantity.Text)).ToString();
                    UpdateItemWhenEdit();
                    UpdateTotalAmount();
                }
                else
                {
                    tbQuantity.Text = InventoryNumber.ToString();
                    UpdateItemWhenEdit();
                    UpdateTotalAmount();
                }
            }
        }
        private void btMinus_Click(object sender, EventArgs e)
        {
            if(tbQuantity.Text != "")
            {
                if (Convert.ToInt32(tbQuantity.Text) > 1)
                {
                    tbQuantity.Text = (Convert.ToDouble(tbQuantity.Text) - 1).ToString();
                    UpdateItemWhenEdit();
                    UpdateTotalAmount();
                }
            }
        }
        private void btPlus_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                if (Convert.ToInt32(tbQuantity.Text) < InventoryNumber)
                {
                    tbQuantity.Text = (Convert.ToDouble(tbQuantity.Text) + 1).ToString();
                    UpdateItemWhenEdit();
                    UpdateTotalAmount();
                }
            }
        }
        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void tbQuantity_Leave(object sender, EventArgs e)
        {
            if(tbQuantity.Text == "")
            {
                tbQuantity.Text = "1";
            }
        }
    }
}
