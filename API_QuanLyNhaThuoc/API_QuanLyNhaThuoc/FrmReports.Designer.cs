namespace API_QuanLyNhaThuoc
{
    partial class FrmReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLoad = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btReportMailDelivery = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btReportBuy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btReportSell = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btReportImportInventory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoad
            // 
            this.panelLoad.BackColor = System.Drawing.Color.White;
            this.panelLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoad.Location = new System.Drawing.Point(0, 46);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(1080, 614);
            this.panelLoad.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btReportImportInventory);
            this.panel1.Controls.Add(this.btReportMailDelivery);
            this.panel1.Controls.Add(this.btReportBuy);
            this.panel1.Controls.Add(this.btReportSell);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 46);
            this.panel1.TabIndex = 3;
            // 
            // btReportMailDelivery
            // 
            this.btReportMailDelivery.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btReportMailDelivery.BackColor = System.Drawing.SystemColors.Control;
            this.btReportMailDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReportMailDelivery.BorderRadius = 7;
            this.btReportMailDelivery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btReportMailDelivery.ButtonText = "Báo cáo gửi mail";
            this.btReportMailDelivery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReportMailDelivery.DisabledColor = System.Drawing.Color.Gray;
            this.btReportMailDelivery.Dock = System.Windows.Forms.DockStyle.Left;
            this.btReportMailDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportMailDelivery.Iconcolor = System.Drawing.Color.Transparent;
            this.btReportMailDelivery.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_buy_100;
            this.btReportMailDelivery.Iconimage_right = null;
            this.btReportMailDelivery.Iconimage_right_Selected = null;
            this.btReportMailDelivery.Iconimage_Selected = null;
            this.btReportMailDelivery.IconMarginLeft = 0;
            this.btReportMailDelivery.IconMarginRight = 0;
            this.btReportMailDelivery.IconRightVisible = true;
            this.btReportMailDelivery.IconRightZoom = 0D;
            this.btReportMailDelivery.IconVisible = true;
            this.btReportMailDelivery.IconZoom = 90D;
            this.btReportMailDelivery.IsTab = false;
            this.btReportMailDelivery.Location = new System.Drawing.Point(330, 0);
            this.btReportMailDelivery.Name = "btReportMailDelivery";
            this.btReportMailDelivery.Normalcolor = System.Drawing.SystemColors.Control;
            this.btReportMailDelivery.OnHovercolor = System.Drawing.Color.Gray;
            this.btReportMailDelivery.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btReportMailDelivery.selected = false;
            this.btReportMailDelivery.Size = new System.Drawing.Size(165, 46);
            this.btReportMailDelivery.TabIndex = 11;
            this.btReportMailDelivery.Text = "Báo cáo gửi mail";
            this.btReportMailDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReportMailDelivery.Textcolor = System.Drawing.Color.Black;
            this.btReportMailDelivery.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportMailDelivery.Click += new System.EventHandler(this.btReportMailDelivery_Click);
            // 
            // btReportBuy
            // 
            this.btReportBuy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btReportBuy.BackColor = System.Drawing.SystemColors.Control;
            this.btReportBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReportBuy.BorderRadius = 7;
            this.btReportBuy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btReportBuy.ButtonText = "Báo cáo nhập hàng";
            this.btReportBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReportBuy.DisabledColor = System.Drawing.Color.Gray;
            this.btReportBuy.Dock = System.Windows.Forms.DockStyle.Left;
            this.btReportBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportBuy.Iconcolor = System.Drawing.Color.Transparent;
            this.btReportBuy.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_buy_100;
            this.btReportBuy.Iconimage_right = null;
            this.btReportBuy.Iconimage_right_Selected = null;
            this.btReportBuy.Iconimage_Selected = null;
            this.btReportBuy.IconMarginLeft = 0;
            this.btReportBuy.IconMarginRight = 0;
            this.btReportBuy.IconRightVisible = true;
            this.btReportBuy.IconRightZoom = 0D;
            this.btReportBuy.IconVisible = true;
            this.btReportBuy.IconZoom = 90D;
            this.btReportBuy.IsTab = false;
            this.btReportBuy.Location = new System.Drawing.Point(165, 0);
            this.btReportBuy.Name = "btReportBuy";
            this.btReportBuy.Normalcolor = System.Drawing.SystemColors.Control;
            this.btReportBuy.OnHovercolor = System.Drawing.Color.Gray;
            this.btReportBuy.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btReportBuy.selected = false;
            this.btReportBuy.Size = new System.Drawing.Size(165, 46);
            this.btReportBuy.TabIndex = 10;
            this.btReportBuy.Text = "Báo cáo nhập hàng";
            this.btReportBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReportBuy.Textcolor = System.Drawing.Color.Black;
            this.btReportBuy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportBuy.Click += new System.EventHandler(this.btReportBuy_Click);
            // 
            // btReportSell
            // 
            this.btReportSell.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btReportSell.BackColor = System.Drawing.SystemColors.Control;
            this.btReportSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReportSell.BorderRadius = 7;
            this.btReportSell.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btReportSell.ButtonText = "Báo cáo bán hàng";
            this.btReportSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReportSell.DisabledColor = System.Drawing.Color.Gray;
            this.btReportSell.Dock = System.Windows.Forms.DockStyle.Left;
            this.btReportSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportSell.Iconcolor = System.Drawing.Color.Transparent;
            this.btReportSell.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_bill_1001;
            this.btReportSell.Iconimage_right = null;
            this.btReportSell.Iconimage_right_Selected = null;
            this.btReportSell.Iconimage_Selected = null;
            this.btReportSell.IconMarginLeft = 0;
            this.btReportSell.IconMarginRight = 0;
            this.btReportSell.IconRightVisible = true;
            this.btReportSell.IconRightZoom = 0D;
            this.btReportSell.IconVisible = true;
            this.btReportSell.IconZoom = 90D;
            this.btReportSell.IsTab = false;
            this.btReportSell.Location = new System.Drawing.Point(0, 0);
            this.btReportSell.Name = "btReportSell";
            this.btReportSell.Normalcolor = System.Drawing.SystemColors.Control;
            this.btReportSell.OnHovercolor = System.Drawing.Color.Gray;
            this.btReportSell.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btReportSell.selected = false;
            this.btReportSell.Size = new System.Drawing.Size(165, 46);
            this.btReportSell.TabIndex = 9;
            this.btReportSell.Text = "Báo cáo bán hàng";
            this.btReportSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReportSell.Textcolor = System.Drawing.Color.Black;
            this.btReportSell.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportSell.Click += new System.EventHandler(this.btReportSell_Click);
            // 
            // btReportImportInventory
            // 
            this.btReportImportInventory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btReportImportInventory.BackColor = System.Drawing.SystemColors.Control;
            this.btReportImportInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReportImportInventory.BorderRadius = 7;
            this.btReportImportInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btReportImportInventory.ButtonText = "Báo cáo nhập tồn";
            this.btReportImportInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReportImportInventory.DisabledColor = System.Drawing.Color.Gray;
            this.btReportImportInventory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btReportImportInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportImportInventory.Iconcolor = System.Drawing.Color.Transparent;
            this.btReportImportInventory.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_buy_100;
            this.btReportImportInventory.Iconimage_right = null;
            this.btReportImportInventory.Iconimage_right_Selected = null;
            this.btReportImportInventory.Iconimage_Selected = null;
            this.btReportImportInventory.IconMarginLeft = 0;
            this.btReportImportInventory.IconMarginRight = 0;
            this.btReportImportInventory.IconRightVisible = true;
            this.btReportImportInventory.IconRightZoom = 0D;
            this.btReportImportInventory.IconVisible = true;
            this.btReportImportInventory.IconZoom = 90D;
            this.btReportImportInventory.IsTab = false;
            this.btReportImportInventory.Location = new System.Drawing.Point(495, 0);
            this.btReportImportInventory.Name = "btReportImportInventory";
            this.btReportImportInventory.Normalcolor = System.Drawing.SystemColors.Control;
            this.btReportImportInventory.OnHovercolor = System.Drawing.Color.Gray;
            this.btReportImportInventory.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btReportImportInventory.selected = false;
            this.btReportImportInventory.Size = new System.Drawing.Size(165, 46);
            this.btReportImportInventory.TabIndex = 12;
            this.btReportImportInventory.Text = "Báo cáo nhập tồn";
            this.btReportImportInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReportImportInventory.Textcolor = System.Drawing.Color.Black;
            this.btReportImportInventory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportImportInventory.Click += new System.EventHandler(this.btReportImportInventory_Click);
            // 
            // FrmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.Controls.Add(this.panelLoad);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReports";
            this.Load += new System.EventHandler(this.FrmReports_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btReportBuy;
        private Bunifu.Framework.UI.BunifuFlatButton btReportSell;
        private Bunifu.Framework.UI.BunifuFlatButton btReportMailDelivery;
        private Bunifu.Framework.UI.BunifuFlatButton btReportImportInventory;
    }
}