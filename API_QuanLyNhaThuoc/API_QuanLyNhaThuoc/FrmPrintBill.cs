﻿using API_QuanLyNhaThuoc.DAO;
using API_QuanLyNhaThuoc.DTO;
using Microsoft.Office.Interop.Word;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_QuanLyNhaThuoc
{
    public partial class FrmPrintBill : Form
    {
        public FrmPrintBill()
        {
            InitializeComponent();
        }

        private void FrmPrintBill_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
        }
        private Logout AutoExit;

        public FrmPrintBill(Logout lg)
        {
            InitializeComponent();
            timer1.Enabled = true;
            AutoExit = lg;
        }
        public static int temp = 0;
        public FrmPrintBill(Logout lg,List<Invoice> list,string filePaths)
        {
            InitializeComponent();
            //timer2.Enabled = true;
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    this.reportViewer1.RefreshReport();
                    if (GetFileInvoices(list[i].Id, list[i].InvoiceNumber, filePaths))
                        temp++;
                }
                if (temp == list.Count)
                {
                    lg();
                    this.Close();
                }
            }
            catch { }
            
        }
        private int IdBill;
        private string InvoiceNumber;
        private string ToMail;
        private string filePath;
        public FrmPrintBill(int idBill,string invoiceNumber,string toMaill)
        {
            InitializeComponent();
            IdBill = idBill;
            InvoiceNumber = invoiceNumber;
            ToMail = toMaill;
            filePath = GetFileInvoice(IdBill, InvoiceNumber);
            timer1.Enabled = true;
        }
        public ReportViewer GetReport(int id)
        {
            this.reportViewer1.RefreshReport();
            this.printBillTableAdapter.Fill(this.api_QuanLyNhaThuocDataSet.PrintBill,id);
            this.GetInvoiceItemsInfoTableAdapter.Fill(this.api_QuanLyNhaThuocDataSet.GetInvoiceItemsInfo,id);
            //this.SelectItemsTableAdapter.Fill(this.Api_QuanLyNhaThuocDataSet.SelectItems,id);
            return reportViewer1;
        }
        public string GetFileInvoice(int id,string invoiceNumber)
        {
            this.printBillTableAdapter.Fill(this.api_QuanLyNhaThuocDataSet.PrintBill, id);
            this.GetInvoiceItemsInfoTableAdapter.Fill(this.api_QuanLyNhaThuocDataSet.GetInvoiceItemsInfo, id);
            //this.SelectItemsTableAdapter.Fill(this.Api_QuanLyNhaThuocDataSet.SelectItems, id);
            byte[] temp = reportViewer1.LocalReport.Render("WORDOPENXML");
            File.WriteAllBytes(@"C:\Users\Public\" + invoiceNumber + ".docx", temp);
            ConvretWordToPDF(@"C:\Users\Public\" + invoiceNumber + ".docx");
            return @"C:\Users\Public\" + invoiceNumber + ".pdf";
        }
        public bool GetFileInvoices(int id, string invoiceNumber,string link)
        {
            this.printBillTableAdapter.Fill(this.api_QuanLyNhaThuocDataSet.PrintBill, id);
            this.GetInvoiceItemsInfoTableAdapter.Fill(this.api_QuanLyNhaThuocDataSet.GetInvoiceItemsInfo, id);
            //this.SelectItemsTableAdapter.Fill(this.Api_QuanLyNhaThuocDataSet.SelectItems, id);
            byte[] temp = reportViewer1.LocalReport.Render("WORDOPENXML");
            File.WriteAllBytes(link + @"\HD" + invoiceNumber + ".docx", temp);
            ConvretWordToPDF(link + @"\HD" + invoiceNumber + ".docx");
            return File.Exists(link + @"\HD" + invoiceNumber + ".pdf");
        }
        private void ConvretListWordToPDF()
        {
            Microsoft.Office.Interop.Word.Application Word = new Microsoft.Office.Interop.Word.Application();

            object oMissing = System.Reflection.Missing.Value;

            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\Public");
            FileInfo[] wordFiles = dirInfo.GetFiles("*.docx");

            Word.Visible = false;
            Word.ScreenUpdating = false;

            foreach (FileInfo wordFile in wordFiles)
            {
                Object filename = (Object)wordFile.FullName;

                Document doc = Word.Documents.Open(ref filename, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                doc.Activate();

                object outputFileName = wordFile.FullName.Replace(".docx", ".pdf");
                object fileFormat = WdSaveFormat.wdFormatPDF;

                doc.SaveAs(ref outputFileName,
                    ref fileFormat, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                ((_Document)doc).Close(ref saveChanges, ref oMissing, ref oMissing);
                doc = null;
            }

            ((_Application)Word).Quit(ref oMissing, ref oMissing, ref oMissing);
            Word = null;
        }
        private void ConvretWordToPDF(string fileDocx)
        {
            Microsoft.Office.Interop.Word.Application Word = new Microsoft.Office.Interop.Word.Application();

            object oMissing = System.Reflection.Missing.Value;

            FileInfo wordFile = new FileInfo(fileDocx);

            Word.Visible = false;
            Word.ScreenUpdating = false;

            Object filename = (Object)wordFile.FullName;

            Document doc = Word.Documents.Open(ref filename, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            doc.Activate();

            object outputFileName = wordFile.FullName.Replace(".docx", ".pdf");
            object fileFormat = WdSaveFormat.wdFormatPDF;

            doc.SaveAs(ref outputFileName,
                ref fileFormat, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
            ((_Document)doc).Close(ref saveChanges, ref oMissing, ref oMissing);
            doc = null;

            ((_Application)Word).Quit(ref oMissing, ref oMissing, ref oMissing);
            Word = null;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    if (File.Exists(filePath))
                    {
                        Thread thread = new Thread(() =>
                        {
                            if (Email_DAO.Instance.SendInvoiceToMail(ToMail, new Attachment(filePath)))
                            {
                                //DeleteFileAfterSendMail(filePath);
                            }
                            //CloseF();
                        }
                        );
                        thread.Start();
                        this.Close();
                    }
                }
                catch { }
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
