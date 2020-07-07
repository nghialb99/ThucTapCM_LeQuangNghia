namespace API_QuanLyNhaThuoc
{
    partial class FrmDeleteInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeleteInvoice));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.btCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.rtb1);
            this.bunifuGradientPanel1.Controls.Add(this.btCancel);
            this.bunifuGradientPanel1.Controls.Add(this.btDelete);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(136)))), ((int)(((byte)(144)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(533, 265);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(347, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "LÝ DO XÓA BỎ";
            // 
            // rtb1
            // 
            this.rtb1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb1.Location = new System.Drawing.Point(34, 75);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(465, 96);
            this.rtb1.TabIndex = 13;
            this.rtb1.Text = "";
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
            this.btCancel.Location = new System.Drawing.Point(308, 187);
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
            // btDelete
            // 
            this.btDelete.Activecolor = System.Drawing.Color.Gray;
            this.btDelete.BackColor = System.Drawing.Color.Silver;
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDelete.BorderRadius = 7;
            this.btDelete.ButtonText = "Xóa bỏ";
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btDelete.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_update_100;
            this.btDelete.Iconimage_right = null;
            this.btDelete.Iconimage_right_Selected = null;
            this.btDelete.Iconimage_Selected = null;
            this.btDelete.IconMarginLeft = 0;
            this.btDelete.IconMarginRight = 0;
            this.btDelete.IconRightVisible = true;
            this.btDelete.IconRightZoom = 0D;
            this.btDelete.IconVisible = true;
            this.btDelete.IconZoom = 90D;
            this.btDelete.IsTab = false;
            this.btDelete.Location = new System.Drawing.Point(99, 187);
            this.btDelete.Name = "btDelete";
            this.btDelete.Normalcolor = System.Drawing.Color.Silver;
            this.btDelete.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btDelete.OnHoverTextColor = System.Drawing.Color.Red;
            this.btDelete.selected = false;
            this.btDelete.Size = new System.Drawing.Size(124, 48);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Xóa bỏ";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btDelete.Textcolor = System.Drawing.Color.Black;
            this.btDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FrmDeleteInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 265);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDeleteInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDeleteInvoice";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb1;
        private Bunifu.Framework.UI.BunifuFlatButton btCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btDelete;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
    }
}