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
    public partial class FrmUserManager : Form
    {
        public FrmUserManager()
        {
            InitializeComponent();
        }
        private void FrmUserManager_Load(object sender, EventArgs e)
        {
            AddForm(new FrmAccountManager());
        }
        private void LoadUserCtr(UserControl f)
        {
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(f);
        }
        private void AddForm(Form f)
        {
            this.panelLoad.Controls.Clear();
            f.TopLevel = false;
            this.panelLoad.Controls.Add(f);
            f.Show();
        }
        private void btUserManager_Click(object sender, EventArgs e)
        {
            AddForm(new FrmAccountManager());
        }

        private void btRoleUserManager_Click(object sender, EventArgs e)
        {
            LoadUserCtr(new UserCrtRoleUserManager());
        }
    }
}
