using API_QuanLyNhaThuoc.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_QuanLyNhaThuoc
{
    public partial class FrmSendInvoiceToMail : Form
    {
        private int idBill;
        private string invoiceNumber;
        public FrmSendInvoiceToMail(int IdBill,string InvoiceNumber)
        {
            InitializeComponent();
            idBill = IdBill;
            invoiceNumber = InvoiceNumber;
        }
        private void FrmSendInvoiceToMail_Load(object sender, EventArgs e)
        {
            lbNotification.Text = "";
            lbInvoiceId.Text = "HĐ "+invoiceNumber;
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DeleteFileAfterSendMail(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }
        
       //public static string filePath;
        private void btSend_Click(object sender, EventArgs e)
        {
            string toMail = tbToEmail.Text.Trim().ToLower().ToString();
            if (toMail != "")
            {
                if (Email_DAO.Instance.isEmail(toMail))
                {
                    lbNotification.Text = "Hệ thống đã thực hiện gửi mail.";
                    FrmPrintBill f = new FrmPrintBill(idBill, invoiceNumber, toMail);
                    //d = 1;
                    //timer1.Enabled = true;
                    this.Close();
                    //filePath = f.GetFileInvoice(idBill,invoiceNumber);
                    //try
                    //{
                    //    if (File.Exists(filePath))
                    //    {
                    //        Thread thread = new Thread(() =>
                    //        {
                    //            if (Email_DAO.Instance.SendInvoiceToMail(toMail, new Attachment(filePath)))
                    //            {
                    //                //DeleteFileAfterSendMail(filePath);
                    //            }
                    //            else lbNotification.Text = "Gửi mail thất bại";
                    //            //CloseF();
                    //        }
                    //        );
                    //        thread.Start();
                    //        this.Close();
                    //    }
                    //}
                    //catch { }
                }
                else { lbNotification.Text = "Email không đúng định dạng!"; d=5; timer1.Enabled = true; tbToEmail.Text = ""; }
            }
        }
        private int d;
        private void timer1_Tick(object sender, EventArgs e)
        {
            d--;
            if (d == 0) { this.Close(); }
            else if (d == 2) { lbNotification.Text = ""; timer1.Enabled = false; }
        }

        private void tbToEmail_Enter(object sender, EventArgs e)
        {
            tbToEmail.Text = "";
            tbToEmail.HintForeColor = Color.Black;
        }

        private void tbToEmail_Leave(object sender, EventArgs e)
        {
            if(tbToEmail.Text == "")
            {
                tbToEmail.HintForeColor = Color.Silver;
            }
        }
    }
}
