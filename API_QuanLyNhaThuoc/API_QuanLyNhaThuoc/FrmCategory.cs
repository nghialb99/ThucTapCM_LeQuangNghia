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
    public partial class FrmCategory : Form
    {
        private Logout Back;
        public FrmCategory(Logout b)
        {
            InitializeComponent();
            Back = b;
        }
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            AddForm(new FrmCategoryProduct());
        }
        private void AddForm(Form f)
        {
            panelLoad.Controls.Clear();
            f.TopLevel = false;
            panelLoad.Controls.Add(f);
            f.Show();
        }
        private void btCategoryProduct_Click(object sender, EventArgs e)
        {
            AddForm(new FrmCategoryProduct());
        }

        private void btCategorySupplier_Click(object sender, EventArgs e)
        {
            AddForm(new FrmCategorySupplier());
        }

        private void btProduct_Click(object sender, EventArgs e)
        {
            AddForm(new FrmProduct(Back));
        }

        private void btSupplier_Click(object sender, EventArgs e)
        {
            AddForm(new FrmSupplier());
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            AddForm(new FrmCustomer());
        }
    }
}
