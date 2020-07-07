namespace API_QuanLyNhaThuoc
{
    partial class FrmSendInvoiceToMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSendInvoiceToMail));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbNotification = new System.Windows.Forms.Label();
            this.tbToEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbInvoiceId = new System.Windows.Forms.Label();
            this.btCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btSend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbNotification);
            this.bunifuGradientPanel1.Controls.Add(this.tbToEmail);
            this.bunifuGradientPanel1.Controls.Add(this.lbInvoiceId);
            this.bunifuGradientPanel1.Controls.Add(this.btCancel);
            this.bunifuGradientPanel1.Controls.Add(this.btSend);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(136)))), ((int)(((byte)(144)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(483, 187);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // lbNotification
            // 
            this.lbNotification.AutoSize = true;
            this.lbNotification.BackColor = System.Drawing.Color.Transparent;
            this.lbNotification.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification.ForeColor = System.Drawing.Color.Red;
            this.lbNotification.Location = new System.Drawing.Point(42, 159);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(93, 19);
            this.lbNotification.TabIndex = 17;
            this.lbNotification.Text = "Thông báo";
            // 
            // tbToEmail
            // 
            this.tbToEmail.BackColor = System.Drawing.Color.White;
            this.tbToEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbToEmail.Font = new System.Drawing.Font("Arial Narrow", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToEmail.ForeColor = System.Drawing.Color.Black;
            this.tbToEmail.HintForeColor = System.Drawing.Color.Silver;
            this.tbToEmail.HintText = "Email@example.com";
            this.tbToEmail.isPassword = false;
            this.tbToEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbToEmail.LineIdleColor = System.Drawing.Color.Black;
            this.tbToEmail.LineMouseHoverColor = System.Drawing.Color.Lime;
            this.tbToEmail.LineThickness = 4;
            this.tbToEmail.Location = new System.Drawing.Point(46, 46);
            this.tbToEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbToEmail.Name = "tbToEmail";
            this.tbToEmail.Size = new System.Drawing.Size(386, 40);
            this.tbToEmail.TabIndex = 16;
            this.tbToEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbToEmail.Enter += new System.EventHandler(this.tbToEmail_Enter);
            this.tbToEmail.Leave += new System.EventHandler(this.tbToEmail_Leave);
            // 
            // lbInvoiceId
            // 
            this.lbInvoiceId.AutoSize = true;
            this.lbInvoiceId.BackColor = System.Drawing.Color.Transparent;
            this.lbInvoiceId.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvoiceId.Location = new System.Drawing.Point(174, 14);
            this.lbInvoiceId.Name = "lbInvoiceId";
            this.lbInvoiceId.Size = new System.Drawing.Size(129, 24);
            this.lbInvoiceId.TabIndex = 14;
            this.lbInvoiceId.Text = "HD 0000000";
            // 
            // btCancel
            // 
            this.btCancel.Activecolor = System.Drawing.Color.Gray;
            this.btCancel.BackColor = System.Drawing.Color.Silver;
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancel.BorderRadius = 7;
            this.btCancel.ButtonText = "Hủy";
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btCancel.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_close_window_100;
            this.btCancel.Iconimage_right = null;
            this.btCancel.Iconimage_right_Selected = null;
            this.btCancel.Iconimage_Selected = null;
            this.btCancel.IconMarginLeft = 0;
            this.btCancel.IconMarginRight = 0;
            this.btCancel.IconRightVisible = true;
            this.btCancel.IconRightZoom = 0D;
            this.btCancel.IconVisible = true;
            this.btCancel.IconZoom = 90D;
            this.btCancel.IsTab = false;
            this.btCancel.Location = new System.Drawing.Point(308, 102);
            this.btCancel.Name = "btCancel";
            this.btCancel.Normalcolor = System.Drawing.Color.Silver;
            this.btCancel.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btCancel.OnHoverTextColor = System.Drawing.Color.Red;
            this.btCancel.selected = false;
            this.btCancel.Size = new System.Drawing.Size(124, 48);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Hủy";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCancel.Textcolor = System.Drawing.Color.Black;
            this.btCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSend
            // 
            this.btSend.Activecolor = System.Drawing.Color.Gray;
            this.btSend.BackColor = System.Drawing.Color.Silver;
            this.btSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSend.BorderRadius = 7;
            this.btSend.ButtonText = "Gửi";
            this.btSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSend.DisabledColor = System.Drawing.Color.Gray;
            this.btSend.Iconcolor = System.Drawing.Color.Transparent;
            this.btSend.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_update_100;
            this.btSend.Iconimage_right = null;
            this.btSend.Iconimage_right_Selected = null;
            this.btSend.Iconimage_Selected = null;
            this.btSend.IconMarginLeft = 0;
            this.btSend.IconMarginRight = 0;
            this.btSend.IconRightVisible = true;
            this.btSend.IconRightZoom = 0D;
            this.btSend.IconVisible = true;
            this.btSend.IconZoom = 90D;
            this.btSend.IsTab = false;
            this.btSend.Location = new System.Drawing.Point(46, 102);
            this.btSend.Name = "btSend";
            this.btSend.Normalcolor = System.Drawing.Color.Silver;
            this.btSend.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btSend.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btSend.selected = false;
            this.btSend.Size = new System.Drawing.Size(124, 48);
            this.btSend.TabIndex = 11;
            this.btSend.Text = "Gửi";
            this.btSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSend.Textcolor = System.Drawing.Color.Black;
            this.btSend.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSendInvoiceToMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 187);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSendInvoiceToMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSendInvoiceToMail";
            this.Load += new System.EventHandler(this.FrmSendInvoiceToMail_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbInvoiceId;
        private Bunifu.Framework.UI.BunifuFlatButton btCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btSend;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbToEmail;
        private System.Windows.Forms.Label lbNotification;
        private System.Windows.Forms.Timer timer1;
    }
}