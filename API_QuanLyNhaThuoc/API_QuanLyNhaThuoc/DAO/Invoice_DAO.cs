using API_QuanLyNhaThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_QuanLyNhaThuoc.DAO
{
    public class Invoice_DAO
    {
        private static Invoice_DAO instance;

        public static Invoice_DAO Instance
        {
            get { if (instance == null) instance = new Invoice_DAO(); return instance; }
            private set { instance = value; }
        }
        private Invoice_DAO() {}

        public List<Invoice> GetListInvoice(string Email, string Phone, bool status, string idBill, string creator, string buyerCode, string buyerName, DateTime fromDate, DateTime toDate)
        {
            List<Invoice> listInvoice = new List<Invoice>();
            DataTable data = DataProvider.Instance.ExcuteQuery("exec GetInvoice @Email , @Phone , @Status , @IdBill , @Creator , @BuyerCode , @BuyerName , @FromDate , @ToDate ",
                new object[] { Email, Phone, status, idBill, creator, buyerCode, buyerName, fromDate, toDate });
            foreach (DataRow item in data.Rows)
            {
                Invoice list = new Invoice(item);
                listInvoice.Add(list);
            }
            return listInvoice;
        }
        public List<Invoice> GetListInvoiceWithTime( DateTime fromDate, DateTime toDate)
        {
            List<Invoice> listInvoice = new List<Invoice>();
            DataTable data = DataProvider.Instance.ExcuteQuery("exec GetInvoiceWithTime  @FromDate , @ToDate ", new object[] { fromDate, toDate });
            foreach (DataRow item in data.Rows)
            {
                Invoice list = new Invoice(item);
                listInvoice.Add(list);
            }
            return listInvoice;
        }
        public List<Invoice> GetListAllInvoice()
        {
            List<Invoice> listInvoice = new List<Invoice>();
            DataTable data = DataProvider.Instance.ExcuteQuery("exec GetFullInvoiceInfo ");
            foreach (DataRow item in data.Rows)
            {
                Invoice list = new Invoice(item);
                listInvoice.Add(list);
            }
            return listInvoice;
        }
        public Invoice GetListInvoiceByInvoiceNumber(string id)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("exec GetInvoiceByInvoiceNumber @InvoiceNumber ", new object[]{id});
            foreach (DataRow item in data.Rows)
            {
                return new Invoice(item);
            }
            return null;
        }

        public List<ItemTemp> GetListItemTemp()
        {
            List<ItemTemp> listItem = new List<ItemTemp>();
            DataTable data = DataProvider.Instance.ExcuteQuery("exec GetItemInvoiceTemp");
            foreach(DataRow item in data.Rows)
            {
                ItemTemp list = new ItemTemp(item);
                listItem.Add(list);
            }
            return listItem;
        }

        public bool InsertItemInvoiceTemp(string idItemCode)
        {
            return DataProvider.Instance.ExcuteNunQuery("exec InsertItemInvoiceTemp @IdItemCode ",
                new object[] { idItemCode }) > 0;
        }
        public bool UpdateItemInvoiceTemp(int id, string unitName, float quantyti, float unitPrice)
        {
            return DataProvider.Instance.ExcuteNunQuery("exec UpdateItemInvoiceTemp @id , @UnitName , @quantity , @unitPrice  ",
                new object[] { id, unitName, quantyti, unitPrice }) > 0;
        }
        public bool DeleteItemInvoiceTemp(int id)
        {
            return DataProvider.Instance.ExcuteNunQuery("exec DeleteItemInvoiceTemp @id ",new object[] { id }) > 0;
        }
        public bool ResetTableItemInvoiceTemp()
        {
            return DataProvider.Instance.ExcuteNunQuery("exec ProcItemInvoiceTemp ") > 0;
        }
        public bool DropTableInvoiceTemp()
        {
            return DataProvider.Instance.ExcuteNunQuery("exec DropTableInvoiceTemp ") > 0;
        }
        public bool InsertBill(string creator, string sellerTaxCode, string buyerCode, float totalAmount, int discount  , string amountInWord , string note)
        {
            string query = "exec CreateInvoice @userName , @sellerTaxCode , @buyerCode , @totalAmount , @discount , @totalAmountInWords , @invoiceNote";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { creator, sellerTaxCode, buyerCode, totalAmount, discount, amountInWord, note }) > 0;
        }
        public bool InsertDetailBill(string idproduct, string unitName, float Quantity, float unitPrice)
        {
            string query = "exec InsertItem @itemCode , @unitName , @quantity , @unitPrice ";
            return DataProvider.Instance.ExcuteNunQuery(query,new object[] { idproduct, unitName, Quantity, unitPrice }) > 0;
        }
        public bool DeleteBill(string id)
        {
            string query = "exec DeleteBillWhenInsertEror @id ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { id }) > 0;
        }
        public bool LockBill(int id, string reasonDelete)
        {
            string query = "exec DeleteInvoice @id , @reasonDelete ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { id, reasonDelete}) > 0;
        }
        public float GetTotalThisMonth()
        {
            object total = DataProvider.Instance.ExcuteScalar("exec Tongtienthangnay");
            return (float)Convert.ToDouble(total.ToString());
        }
        public float GetTotalLastMonth()
        {
            object total = DataProvider.Instance.ExcuteScalar("exec Tongtienthangtruoc");
            float A = (float)Convert.ToDouble(total.ToString());

            return A;
        }
        public DataTable GetTotalMonthOnYear()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("exec Tongtienhangthang");

            return data;
        }
        public DataTable GetTopSPThisMonth()
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("mathuoc_banchaytrongthang");
            return data;
        }
        public float GetTotalBillThisMonth()
        {
            object total = DataProvider.Instance.ExcuteScalar("TongHDthangnay");

            float A = (float)Convert.ToDouble(total.ToString());
            return A;
        }
        public float GetTotalBillLastMonth()
        {
            object total = DataProvider.Instance.ExcuteScalar("TongHDthangtruoc");

            float A = (float)Convert.ToDouble(total.ToString());
            return A;
        }
        public int SoThuocSapHetHanThangNay()
        {
            return Convert.ToInt32(DataProvider.Instance.ExcuteScalar("SoThuocSapHetHSDThangnay"));
        }
        public int SoThuocSapHetHanThangSau()
        {
            return Convert.ToInt32(DataProvider.Instance.ExcuteScalar("SoThuocSapHetHSDThangsau"));
        }
        public int GetTotalBillThisDay()
        {
            object A = DataProvider.Instance.ExcuteScalar("TongHDTrongNgay");

            return (int)A;
        }
        public float GetTotalAmountThisDay()
        {
            return (float)Convert.ToDouble(DataProvider.Instance.ExcuteScalar("TongTienTrongNgay"));
        }
        #region Đọc tiền thành chữ
        public String NumberToTextVN(decimal total)
        {
            try
            {
                string rs = "";
                total = Math.Round(total, 0);
                string[] ch = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
                string[] rch = { "lẻ", "mốt", "", "", "", "lăm" };
                string[] u = { "", "mươi", "trăm", "ngàn", "", "", "triệu", "", "", "tỷ", "", "", "ngàn", "", "", "triệu" };
                string nstr = total.ToString();

                int[] n = new int[nstr.Length];
                int len = n.Length;
                for (int i = 0; i < len; i++)
                {
                    n[len - 1 - i] = Convert.ToInt32(nstr.Substring(i, 1));
                }

                for (int i = len - 1; i >= 0; i--)
                {
                    if (i % 3 == 2)// số 0 ở hàng trăm
                    {
                        if (n[i] == 0 && n[i - 1] == 0 && n[i - 2] == 0) continue;//nếu cả 3 số là 0 thì bỏ qua không đọc
                    }
                    else if (i % 3 == 1) // số ở hàng chục
                    {
                        if (n[i] == 0)
                        {
                            if (n[i - 1] == 0) { continue; }// nếu hàng chục và hàng đơn vị đều là 0 thì bỏ qua.
                            else
                            {
                                rs += " " + rch[n[i]]; continue;// hàng chục là 0 thì bỏ qua, đọc số hàng đơn vị
                            }
                        }
                        if (n[i] == 1)//nếu số hàng chục là 1 thì đọc là mười
                        {
                            rs += " mười"; continue;
                        }
                    }
                    else if (i != len - 1)// số ở hàng đơn vị (không phải là số đầu tiên)
                    {
                        if (n[i] == 0)// số hàng đơn vị là 0 thì chỉ đọc đơn vị
                        {
                            if (i + 2 <= len - 1 && n[i + 2] == 0 && n[i + 1] == 0) continue;
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 1)// nếu là 1 thì tùy vào số hàng chục mà đọc: 0,1: một / còn lại: mốt
                        {
                            rs += " " + ((n[i + 1] == 1 || n[i + 1] == 0) ? ch[n[i]] : rch[n[i]]);
                            rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);
                            continue;
                        }
                        if (n[i] == 5) // cách đọc số 5
                        {
                            if (n[i + 1] != 0) //nếu số hàng chục khác 0 thì đọc số 5 là lăm
                            {
                                rs += " " + rch[n[i]];// đọc số 
                                rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);// đọc đơn vị
                                continue;
                            }
                        }
                    }

                    rs += (rs == "" ? " " : ", ") + ch[n[i]];// đọc số
                    rs += " " + (i % 3 == 0 ? u[i] : u[i % 3]);// đọc đơn vị
                }
                if (rs[rs.Length - 1] != ' ')
                    rs += " đồng";
                else
                    rs += "đồng";

                if (rs.Length > 2)
                {
                    string rs1 = rs.Substring(0, 2);
                    rs1 = rs1.ToUpper();
                    rs = rs.Substring(2);
                    rs = rs1 + rs;
                }
                return rs.Trim().Replace("lẻ,", "lẻ").Replace("mươi,", "mươi").Replace("trăm,", "trăm").Replace("mười,", "mười");
            }
            catch
            {
                return "";
            }

        }
            #endregion
    }
}
