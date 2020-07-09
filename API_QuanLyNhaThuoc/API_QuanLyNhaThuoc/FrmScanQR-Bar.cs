using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace API_QuanLyNhaThuoc
{
    public partial class FrmScanQR_Bar : Form
    {
        public FrmScanQR_Bar()
        {
            InitializeComponent();
        }

        private void FrmScanQR_Bar_Load(object sender, EventArgs e)
        {

        }
        private MJPEGStream Stream;

        private void stream_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;
        }
        private void btConnect_Click(object sender, EventArgs e)
        {
            if (btConnect.Text == "Kết nối")
            {
                //if (tbSearch.Text.Trim() == "" || tbSearch.Text.Trim() == null)
                //{
                //    MessageBox.Show("Bạn chưa kết nối ứng dụng");
                //}
                //else
                //{
                    pictureBox1.Visible = true;
                    Stream = new MJPEGStream(tbSearch.text);
                    Stream.NewFrame += stream_NewFrame;
                    Stream.Start();
                    timer1.Enabled = true;
                    timer1.Start();
                
                btConnect.Text = "Ngắt ứng dụng";
                    //btConnect.Iconimage = Image.FromFile("..//..//..//..//image//icondis.png");
                //}
            }
            else
            {
                pictureBox1.Visible = false;
                btConnect.Text = "Kết nối ứng dụng";
                //btConnect.Iconimage = Image.FromFile("..//..//..//..//image//iconconnect.png");
                timer1.Stop();
                Stream.Stop();
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    BarcodeReader Reader = new BarcodeReader();
                    if (Reader.Decode((Bitmap)pictureBox1.Image) != null)
                    {
                        Result result = Reader.Decode((Bitmap)pictureBox1.Image);
                        if (result != null)
                        {
                            MessageBox.Show(result.ToString());
                        }
                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
