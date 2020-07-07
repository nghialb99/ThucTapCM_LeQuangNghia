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
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }
        private void AddUserCrt(UserControl f)
        {
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(f);
        }
        private void FrmReports_Load(object sender, EventArgs e)
        {
            AddUserCrt(new UserCrtReportSell());
        }
        private void btReportSell_Click(object sender, EventArgs e)
        {
            AddUserCrt(new UserCrtReportSell());
        }

        private void btReportBuy_Click(object sender, EventArgs e)
        {
            AddUserCrt(new UserCrtReportBuy());
        }

        private void btReportMailDelivery_Click(object sender, EventArgs e)
        {
            AddUserCrt(new UserCrtReportMailDelivery());
        }
    }
}
