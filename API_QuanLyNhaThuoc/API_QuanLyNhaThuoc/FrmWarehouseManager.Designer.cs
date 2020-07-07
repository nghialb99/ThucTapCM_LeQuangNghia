namespace API_QuanLyNhaThuoc
{
    partial class FrmWarehouseManager
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
            this.btReportBuy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btImportFromSupplier = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panelLoad.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btImportFromSupplier);
            this.panel1.Controls.Add(this.btReportBuy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 46);
            this.panel1.TabIndex = 5;
            // 
            // btReportBuy
            // 
            this.btReportBuy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btReportBuy.BackColor = System.Drawing.SystemColors.Control;
            this.btReportBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReportBuy.BorderRadius = 7;
            this.btReportBuy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btReportBuy.ButtonText = "Tồn kho";
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
            this.btReportBuy.Location = new System.Drawing.Point(0, 0);
            this.btReportBuy.Name = "btReportBuy";
            this.btReportBuy.Normalcolor = System.Drawing.SystemColors.Control;
            this.btReportBuy.OnHovercolor = System.Drawing.Color.Gray;
            this.btReportBuy.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btReportBuy.selected = false;
            this.btReportBuy.Size = new System.Drawing.Size(165, 46);
            this.btReportBuy.TabIndex = 10;
            this.btReportBuy.Text = "Tồn kho";
            this.btReportBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReportBuy.Textcolor = System.Drawing.Color.Black;
            this.btReportBuy.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportBuy.Click += new System.EventHandler(this.btReportBuy_Click);
            // 
            // btImportFromSupplier
            // 
            this.btImportFromSupplier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btImportFromSupplier.BackColor = System.Drawing.SystemColors.Control;
            this.btImportFromSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImportFromSupplier.BorderRadius = 7;
            this.btImportFromSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btImportFromSupplier.ButtonText = "Nhập từ nhà cung cấp";
            this.btImportFromSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImportFromSupplier.DisabledColor = System.Drawing.Color.Gray;
            this.btImportFromSupplier.Dock = System.Windows.Forms.DockStyle.Left;
            this.btImportFromSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImportFromSupplier.Iconcolor = System.Drawing.Color.Transparent;
            this.btImportFromSupplier.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_bill_1001;
            this.btImportFromSupplier.Iconimage_right = null;
            this.btImportFromSupplier.Iconimage_right_Selected = null;
            this.btImportFromSupplier.Iconimage_Selected = null;
            this.btImportFromSupplier.IconMarginLeft = 0;
            this.btImportFromSupplier.IconMarginRight = 0;
            this.btImportFromSupplier.IconRightVisible = true;
            this.btImportFromSupplier.IconRightZoom = 0D;
            this.btImportFromSupplier.IconVisible = true;
            this.btImportFromSupplier.IconZoom = 90D;
            this.btImportFromSupplier.IsTab = false;
            this.btImportFromSupplier.Location = new System.Drawing.Point(165, 0);
            this.btImportFromSupplier.Name = "btImportFromSupplier";
            this.btImportFromSupplier.Normalcolor = System.Drawing.SystemColors.Control;
            this.btImportFromSupplier.OnHovercolor = System.Drawing.Color.Gray;
            this.btImportFromSupplier.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btImportFromSupplier.selected = false;
            this.btImportFromSupplier.Size = new System.Drawing.Size(165, 46);
            this.btImportFromSupplier.TabIndex = 9;
            this.btImportFromSupplier.Text = "Nhập từ nhà cung cấp";
            this.btImportFromSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btImportFromSupplier.Textcolor = System.Drawing.Color.Black;
            this.btImportFromSupplier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImportFromSupplier.Click += new System.EventHandler(this.btImportFromSupplier_Click);
            // 
            // FrmWarehouseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.Controls.Add(this.panelLoad);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWarehouseManager";
            this.Text = "FrmWarehouseManager";
            this.Load += new System.EventHandler(this.FrmWarehouseManager_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btReportBuy;
        private Bunifu.Framework.UI.BunifuFlatButton btImportFromSupplier;
    }
}