using API_QuanLyNhaThuoc.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_QuanLyNhaThuoc
{
    public partial class FrmDeleteInvoice : Form
    {
        private Logout Exit;
        private int id = 0;
        private string invoiceNumber = "";
        public FrmDeleteInvoice(Logout exit,int idBill,string InvoiceNumber)
        {
            InitializeComponent();
            Exit = exit;
            id = idBill;
            invoiceNumber = InvoiceNumber;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (rtb1.Text == null || rtb1.Text == "")
            {
                MessageBox.Show("Lý do xóa bỏ không được để trống!", "Thông báo!");
            }
            else
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn xóa bỏ hóa đơn "+ invoiceNumber+ " ?", "Thông báo!",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Invoice_DAO.Instance.LockBill(id, rtb1.Text))
                    {
                        MessageBox.Show("Xóa bỏ hóa đơn " + invoiceNumber + " thành công!", "Thông báo!");
                        Exit();
                        this.Close();
                    }
                }
            }
        }
    }
}
