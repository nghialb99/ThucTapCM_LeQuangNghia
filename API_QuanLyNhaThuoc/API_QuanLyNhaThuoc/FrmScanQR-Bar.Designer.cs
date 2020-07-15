namespace API_QuanLyNhaThuoc
{
    partial class FrmScanQR_Bar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScanQR_Bar));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.btConnect = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearch.BackgroundImage")));
            this.tbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSearch.ForeColor = System.Drawing.Color.DarkMagenta;
            this.tbSearch.Icon = ((System.Drawing.Image)(resources.GetObject("tbSearch.Icon")));
            this.tbSearch.Location = new System.Drawing.Point(12, 73);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(250, 34);
            this.tbSearch.TabIndex = 140;
            this.tbSearch.text = "http://192.168.43.1:8080/";
            // 
            // btConnect
            // 
            this.btConnect.Activecolor = System.Drawing.Color.Gray;
            this.btConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConnect.BorderRadius = 7;
            this.btConnect.ButtonText = "Kết nối";
            this.btConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConnect.DisabledColor = System.Drawing.Color.Gray;
            this.btConnect.ForeColor = System.Drawing.Color.Black;
            this.btConnect.Iconcolor = System.Drawing.Color.Transparent;
            this.btConnect.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_connect_100;
            this.btConnect.Iconimage_right = null;
            this.btConnect.Iconimage_right_Selected = null;
            this.btConnect.Iconimage_Selected = null;
            this.btConnect.IconMarginLeft = 0;
            this.btConnect.IconMarginRight = 0;
            this.btConnect.IconRightVisible = true;
            this.btConnect.IconRightZoom = 0D;
            this.btConnect.IconVisible = true;
            this.btConnect.IconZoom = 70D;
            this.btConnect.IsTab = false;
            this.btConnect.Location = new System.Drawing.Point(299, 73);
            this.btConnect.Name = "btConnect";
            this.btConnect.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btConnect.OnHovercolor = System.Drawing.Color.Gray;
            this.btConnect.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btConnect.selected = false;
            this.btConnect.Size = new System.Drawing.Size(87, 34);
            this.btConnect.TabIndex = 139;
            this.btConnect.Text = "Kết nối";
            this.btConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btConnect.Textcolor = System.Drawing.Color.White;
            this.btConnect.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(13, 142);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(372, 232);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.Image = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_cancel_100;
            this.btExit.ImageActive = null;
            this.btExit.Location = new System.Drawing.Point(360, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(39, 40);
            this.btExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btExit.TabIndex = 141;
            this.btExit.TabStop = false;
            this.btExit.Zoom = 10;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FrmScanQR_Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(400, 382);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmScanQR_Bar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmScanQR_Bar";
            this.Load += new System.EventHandler(this.FrmScanQR_Bar_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTextbox tbSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btConnect;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btExit;
    }
}