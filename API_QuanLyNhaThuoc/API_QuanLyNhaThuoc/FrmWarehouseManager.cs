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
    public partial class FrmWarehouseManager : Form
    {
        public FrmWarehouseManager()
        {
            InitializeComponent();
        }
        private void FrmWarehouseManager_Load(object sender, EventArgs e)
        {
            AddForm(new FrmInventory());
        }
        private void AddForm(Form f)
        {
            this.panelLoad.Controls.Clear();
            f.TopLevel = false;
            this.panelLoad.Controls.Add(f);
            f.Show();
        }
        private void btReportBuy_Click(object sender, EventArgs e)
        {
            AddForm(new FrmInventory());
        }

        private void btImportFromSupplier_Click(object sender, EventArgs e)
        {
            AddForm(new FrmImportFromSupplier());
        }
    }
}
