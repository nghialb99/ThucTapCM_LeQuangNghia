using com.sun.imageio.plugins.jpeg;
using sun.net.www.content.image;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_QuanLyNhaThuoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataProvider.Instance.ExcuteQuery("select * from ThongTinDoanhNghiep");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.UtcNow;
            DateTime date1 = DateTime.Now;

            label1.Text = TimeZoneInfo.ConvertTime(date, TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time")).ToString();
            label2.Text = date1.ToString();
            label3.Text = date.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                byte[] imageData = null;
                using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read))
                {
                    imageData = new Byte[fs.Length];
                    fs.Read(imageData, 0, Convert.ToInt32(fs.Length));
                }
                richTextBox1.Text = Convert.ToBase64String(imageData);
                if (DataProvider.Instance.ExcuteNunQuery("exec inserttest @image ", new object[] { imageData }) > 0)
                {
                    MessageBox.Show("lưu thành công");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //byte[] img = null;
            //MemoryStream str = new MemoryStream(img);
            DataTable data = DataProvider.Instance.ExcuteQuery("select * from test where id = 6");
            foreach(DataRow item in data.Rows)
            {
                Byte[] image = (Byte[])item["image"];
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
                ms.Close();
            }


            
            //pictureBox1.Image = ByteToImg(DataProvider.Instance.ExcuteScalar("select image from test where id = 4").ToString());

        }
        private Image ByteToImg(string byteString)
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            try
            {
                if (e.ColumnIndex == dataGridView1.Columns["Column3"].Index && row >= 0)
                {
                    if (MessageBox.Show("Bạn có chắc muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        dataGridView1.Rows.Clear();
                    }
                }
            }
            catch {}
        }
        private int k = 0;
        void ComputeTotalAmountWhenUpdateItem()
        {
            k++;
            textBox1.Text = k.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FrmItems f = new FrmItems(ComputeTotalAmountWhenUpdateItem, 1, "HH000012");
            f.TopLevel = false;
            panel1.Controls.Add(f);
            f.Dock = DockStyle.Top;
            //f.TopMost = true;
            f.Show();
        }
    }
}
