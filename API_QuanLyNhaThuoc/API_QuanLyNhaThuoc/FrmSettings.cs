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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            LoadUserCtr(new UserCrtEmail());
            panel1.Visible = false;
        }
        private void LoadUserCtr(UserControl f)
        {
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(f);
        }

        private void btEmail_Click(object sender, EventArgs e)
        {
            LoadUserCtr(new UserCrtEmail());
        }

        private void btEmailForm_Click(object sender, EventArgs e)
        {
            LoadUserCtr(new UserCrtEmailForm());
        }
    }
}
