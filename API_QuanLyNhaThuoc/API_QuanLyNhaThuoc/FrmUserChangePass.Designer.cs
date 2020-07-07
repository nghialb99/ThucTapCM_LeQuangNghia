namespace API_QuanLyNhaThuoc
{
    partial class FrmUserChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserChangePass));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tbReEnterPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbNewPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOutPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.button1);
            this.bunifuGradientPanel1.Controls.Add(this.tbReEnterPass);
            this.bunifuGradientPanel1.Controls.Add(this.tbNewPass);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.tbOutPass);
            this.bunifuGradientPanel1.Controls.Add(this.btCancel);
            this.bunifuGradientPanel1.Controls.Add(this.btUpdate);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(136)))), ((int)(((byte)(144)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(374, 342);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // tbReEnterPass
            // 
            this.tbReEnterPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbReEnterPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbReEnterPass.ForeColor = System.Drawing.Color.Black;
            this.tbReEnterPass.HintForeColor = System.Drawing.Color.Empty;
            this.tbReEnterPass.HintText = "Nhập lại mật khẩu";
            this.tbReEnterPass.isPassword = true;
            this.tbReEnterPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbReEnterPass.LineIdleColor = System.Drawing.Color.Black;
            this.tbReEnterPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbReEnterPass.LineThickness = 3;
            this.tbReEnterPass.Location = new System.Drawing.Point(21, 212);
            this.tbReEnterPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbReEnterPass.Name = "tbReEnterPass";
            this.tbReEnterPass.Size = new System.Drawing.Size(333, 33);
            this.tbReEnterPass.TabIndex = 4;
            this.tbReEnterPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbReEnterPass.OnValueChanged += new System.EventHandler(this.tbReEnterPass_OnValueChanged);
            // 
            // tbNewPass
            // 
            this.tbNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNewPass.ForeColor = System.Drawing.Color.Black;
            this.tbNewPass.HintForeColor = System.Drawing.Color.Empty;
            this.tbNewPass.HintText = "Mật khẩu mới";
            this.tbNewPass.isPassword = true;
            this.tbNewPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbNewPass.LineIdleColor = System.Drawing.Color.Black;
            this.tbNewPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbNewPass.LineThickness = 3;
            this.tbNewPass.Location = new System.Drawing.Point(21, 142);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(333, 33);
            this.tbNewPass.TabIndex = 3;
            this.tbNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNewPass.OnValueChanged += new System.EventHandler(this.tbNewPass_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "------------------------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thay đổi mật khẩu";
            // 
            // tbOutPass
            // 
            this.tbOutPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOutPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbOutPass.ForeColor = System.Drawing.Color.Black;
            this.tbOutPass.HintForeColor = System.Drawing.Color.Empty;
            this.tbOutPass.HintText = "Mật khẩu cũ";
            this.tbOutPass.isPassword = true;
            this.tbOutPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbOutPass.LineIdleColor = System.Drawing.Color.Black;
            this.tbOutPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbOutPass.LineThickness = 3;
            this.tbOutPass.Location = new System.Drawing.Point(21, 72);
            this.tbOutPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbOutPass.Name = "tbOutPass";
            this.tbOutPass.Size = new System.Drawing.Size(333, 33);
            this.tbOutPass.TabIndex = 2;
            this.tbOutPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbOutPass.OnValueChanged += new System.EventHandler(this.tbOutPass_OnValueChanged);
            // 
            // btCancel
            // 
            this.btCancel.Activecolor = System.Drawing.Color.Gray;
            this.btCancel.BackColor = System.Drawing.Color.Silver;
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancel.BorderRadius = 7;
            this.btCancel.ButtonText = "Thoát";
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
            this.btCancel.Location = new System.Drawing.Point(230, 278);
            this.btCancel.Name = "btCancel";
            this.btCancel.Normalcolor = System.Drawing.Color.Silver;
            this.btCancel.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btCancel.OnHoverTextColor = System.Drawing.Color.Red;
            this.btCancel.selected = false;
            this.btCancel.Size = new System.Drawing.Size(124, 48);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Thoát";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCancel.Textcolor = System.Drawing.Color.Black;
            this.btCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Activecolor = System.Drawing.Color.Gray;
            this.btUpdate.BackColor = System.Drawing.Color.Silver;
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUpdate.BorderRadius = 7;
            this.btUpdate.ButtonText = "Cập nhật";
            this.btUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btUpdate.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_update_100;
            this.btUpdate.Iconimage_right = null;
            this.btUpdate.Iconimage_right_Selected = null;
            this.btUpdate.Iconimage_Selected = null;
            this.btUpdate.IconMarginLeft = 0;
            this.btUpdate.IconMarginRight = 0;
            this.btUpdate.IconRightVisible = true;
            this.btUpdate.IconRightZoom = 0D;
            this.btUpdate.IconVisible = true;
            this.btUpdate.IconZoom = 90D;
            this.btUpdate.IsTab = false;
            this.btUpdate.Location = new System.Drawing.Point(21, 278);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Normalcolor = System.Drawing.Color.Silver;
            this.btUpdate.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btUpdate.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btUpdate.selected = false;
            this.btUpdate.Size = new System.Drawing.Size(124, 48);
            this.btUpdate.TabIndex = 5;
            this.btUpdate.Text = "Cập nhật";
            this.btUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btUpdate.Textcolor = System.Drawing.Color.Black;
            this.btUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // FrmUserChangePass
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 342);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(374, 342);
            this.MinimumSize = new System.Drawing.Size(374, 342);
            this.Name = "FrmUserChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.FrmUserChangePass_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbReEnterPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbOutPass;
        private Bunifu.Framework.UI.BunifuFlatButton btCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btUpdate;
        private System.Windows.Forms.Button button1;
    }
}