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
    public partial class FrmItems : Form
    {
        public FrmItems()
        {
            InitializeComponent();
        }
        private void FrmItems_Load(object sender, EventArgs e)
        {

        }


        private void btDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbUnitName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
