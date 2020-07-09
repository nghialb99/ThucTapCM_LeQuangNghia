namespace API_QuanLyNhaThuoc
{
    partial class FrmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItems));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btPlus = new Bunifu.Framework.UI.BunifuImageButton();
            this.btMinus = new Bunifu.Framework.UI.BunifuImageButton();
            this.btDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.cbUnitName = new System.Windows.Forms.ComboBox();
            this.lbItemName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.tbQuantity);
            this.bunifuGradientPanel1.Controls.Add(this.btPlus);
            this.bunifuGradientPanel1.Controls.Add(this.btMinus);
            this.bunifuGradientPanel1.Controls.Add(this.btDelete);
            this.bunifuGradientPanel1.Controls.Add(this.lbTotalAmount);
            this.bunifuGradientPanel1.Controls.Add(this.lbUnitPrice);
            this.bunifuGradientPanel1.Controls.Add(this.cbUnitName);
            this.bunifuGradientPanel1.Controls.Add(this.lbItemName);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(735, 54);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantity.Location = new System.Drawing.Point(488, 15);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(69, 21);
            this.tbQuantity.TabIndex = 10;
            this.tbQuantity.Text = "0";
            this.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantity_KeyPress);
            this.tbQuantity.Leave += new System.EventHandler(this.tbQuantity_Leave);
            // 
            // btPlus
            // 
            this.btPlus.BackColor = System.Drawing.Color.Transparent;
            this.btPlus.Image = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_plus_100;
            this.btPlus.ImageActive = null;
            this.btPlus.Location = new System.Drawing.Point(557, 15);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(21, 21);
            this.btPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btPlus.TabIndex = 9;
            this.btPlus.TabStop = false;
            this.btPlus.Zoom = 10;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btMinus
            // 
            this.btMinus.BackColor = System.Drawing.Color.Transparent;
            this.btMinus.Image = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_minus_100;
            this.btMinus.ImageActive = null;
            this.btMinus.Location = new System.Drawing.Point(468, 15);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(21, 21);
            this.btMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMinus.TabIndex = 8;
            this.btMinus.TabStop = false;
            this.btMinus.Zoom = 10;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Transparent;
            this.btDelete.Image = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_waste_100;
            this.btDelete.ImageActive = null;
            this.btDelete.Location = new System.Drawing.Point(699, 16);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(21, 21);
            this.btDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btDelete.TabIndex = 6;
            this.btDelete.TabStop = false;
            this.btDelete.Zoom = 10;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lbTotalAmount.Location = new System.Drawing.Point(584, 14);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(109, 23);
            this.lbTotalAmount.TabIndex = 5;
            this.lbTotalAmount.Text = "0000000";
            this.lbTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUnitPrice.Location = new System.Drawing.Point(368, 14);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(94, 23);
            this.lbUnitPrice.TabIndex = 4;
            this.lbUnitPrice.Text = "0000000";
            this.lbUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbUnitName
            // 
            this.cbUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnitName.FormattingEnabled = true;
            this.cbUnitName.Location = new System.Drawing.Point(290, 16);
            this.cbUnitName.Name = "cbUnitName";
            this.cbUnitName.Size = new System.Drawing.Size(73, 23);
            this.cbUnitName.TabIndex = 2;
            this.cbUnitName.SelectedIndexChanged += new System.EventHandler(this.cbUnitName_SelectedIndexChanged);
            // 
            // lbItemName
            // 
            this.lbItemName.BackColor = System.Drawing.Color.Transparent;
            this.lbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemName.Location = new System.Drawing.Point(58, -1);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(219, 54);
            this.lbItemName.TabIndex = 1;
            this.lbItemName.Text = "Tên sản phẩm";
            this.lbItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 54);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmItems";
            this.Load += new System.EventHandler(this.FrmItems_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.ComboBox cbUnitName;
        private Bunifu.Framework.UI.BunifuCustomLabel lbItemName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton btDelete;
        private Bunifu.Framework.UI.BunifuImageButton btPlus;
        private Bunifu.Framework.UI.BunifuImageButton btMinus;
        private System.Windows.Forms.TextBox tbQuantity;
    }
}