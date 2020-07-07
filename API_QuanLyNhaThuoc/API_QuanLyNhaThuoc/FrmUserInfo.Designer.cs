namespace API_QuanLyNhaThuoc
{
    partial class FrmUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserInfo));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DatepickerBirthday = new Bunifu.Framework.UI.BunifuDatepicker();
            this.tbUserAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUserPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbGender = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbDisplayName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbUserEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbUserPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbIdCard = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbUers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.bunifuGradientPanel1.Controls.Add(this.DatepickerBirthday);
            this.bunifuGradientPanel1.Controls.Add(this.tbUserAddress);
            this.bunifuGradientPanel1.Controls.Add(this.label9);
            this.bunifuGradientPanel1.Controls.Add(this.tbUserPass);
            this.bunifuGradientPanel1.Controls.Add(this.tbGender);
            this.bunifuGradientPanel1.Controls.Add(this.tbDisplayName);
            this.bunifuGradientPanel1.Controls.Add(this.tbUserEmail);
            this.bunifuGradientPanel1.Controls.Add(this.tbUserPhone);
            this.bunifuGradientPanel1.Controls.Add(this.tbIdCard);
            this.bunifuGradientPanel1.Controls.Add(this.tbUserName);
            this.bunifuGradientPanel1.Controls.Add(this.label10);
            this.bunifuGradientPanel1.Controls.Add(this.lbUers);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1080, 450);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // DatepickerBirthday
            // 
            this.DatepickerBirthday.BackColor = System.Drawing.Color.White;
            this.DatepickerBirthday.BorderRadius = 0;
            this.DatepickerBirthday.ForeColor = System.Drawing.Color.Black;
            this.DatepickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatepickerBirthday.FormatCustom = "dd/MM/yyyy";
            this.DatepickerBirthday.Location = new System.Drawing.Point(714, 194);
            this.DatepickerBirthday.Name = "DatepickerBirthday";
            this.DatepickerBirthday.Size = new System.Drawing.Size(354, 36);
            this.DatepickerBirthday.TabIndex = 5;
            this.DatepickerBirthday.Value = new System.DateTime(2020, 5, 27, 0, 57, 5, 774);
            // 
            // tbUserAddress
            // 
            this.tbUserAddress.BackColor = System.Drawing.Color.White;
            this.tbUserAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserAddress.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserAddress.ForeColor = System.Drawing.Color.Blue;
            this.tbUserAddress.HintForeColor = System.Drawing.Color.Empty;
            this.tbUserAddress.HintText = "";
            this.tbUserAddress.isPassword = false;
            this.tbUserAddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbUserAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.tbUserAddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbUserAddress.LineThickness = 3;
            this.tbUserAddress.Location = new System.Drawing.Point(146, 321);
            this.tbUserAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserAddress.Name = "tbUserAddress";
            this.tbUserAddress.Size = new System.Drawing.Size(922, 33);
            this.tbUserAddress.TabIndex = 7;
            this.tbUserAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 88;
            this.label9.Text = "Địa chỉ";
            // 
            // tbUserPass
            // 
            this.tbUserPass.BackColor = System.Drawing.Color.White;
            this.tbUserPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserPass.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserPass.ForeColor = System.Drawing.Color.Blue;
            this.tbUserPass.HintForeColor = System.Drawing.Color.Empty;
            this.tbUserPass.HintText = "Mật khẩu";
            this.tbUserPass.isPassword = true;
            this.tbUserPass.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbUserPass.LineIdleColor = System.Drawing.Color.Gray;
            this.tbUserPass.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbUserPass.LineThickness = 3;
            this.tbUserPass.Location = new System.Drawing.Point(714, 259);
            this.tbUserPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserPass.Name = "tbUserPass";
            this.tbUserPass.Size = new System.Drawing.Size(354, 33);
            this.tbUserPass.TabIndex = 8;
            this.tbUserPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUserPass.OnValueChanged += new System.EventHandler(this.tbUserPass_OnValueChanged);
            // 
            // tbGender
            // 
            this.tbGender.BackColor = System.Drawing.Color.White;
            this.tbGender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGender.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGender.ForeColor = System.Drawing.Color.Blue;
            this.tbGender.HintForeColor = System.Drawing.Color.Empty;
            this.tbGender.HintText = "";
            this.tbGender.isPassword = false;
            this.tbGender.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbGender.LineIdleColor = System.Drawing.Color.Gray;
            this.tbGender.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbGender.LineThickness = 3;
            this.tbGender.Location = new System.Drawing.Point(714, 135);
            this.tbGender.Margin = new System.Windows.Forms.Padding(4);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(354, 33);
            this.tbGender.TabIndex = 3;
            this.tbGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.BackColor = System.Drawing.Color.White;
            this.tbDisplayName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDisplayName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplayName.ForeColor = System.Drawing.Color.Blue;
            this.tbDisplayName.HintForeColor = System.Drawing.Color.Empty;
            this.tbDisplayName.HintText = "";
            this.tbDisplayName.isPassword = false;
            this.tbDisplayName.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbDisplayName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbDisplayName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbDisplayName.LineThickness = 3;
            this.tbDisplayName.Location = new System.Drawing.Point(714, 73);
            this.tbDisplayName.Margin = new System.Windows.Forms.Padding(4);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(354, 33);
            this.tbDisplayName.TabIndex = 1;
            this.tbDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.BackColor = System.Drawing.Color.White;
            this.tbUserEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserEmail.ForeColor = System.Drawing.Color.Blue;
            this.tbUserEmail.HintForeColor = System.Drawing.Color.Empty;
            this.tbUserEmail.HintText = "";
            this.tbUserEmail.isPassword = false;
            this.tbUserEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbUserEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.tbUserEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbUserEmail.LineThickness = 3;
            this.tbUserEmail.Location = new System.Drawing.Point(146, 259);
            this.tbUserEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Size = new System.Drawing.Size(354, 33);
            this.tbUserEmail.TabIndex = 6;
            this.tbUserEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUserPhone
            // 
            this.tbUserPhone.BackColor = System.Drawing.Color.White;
            this.tbUserPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserPhone.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserPhone.ForeColor = System.Drawing.Color.Blue;
            this.tbUserPhone.HintForeColor = System.Drawing.Color.Empty;
            this.tbUserPhone.HintText = "";
            this.tbUserPhone.isPassword = false;
            this.tbUserPhone.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbUserPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.tbUserPhone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbUserPhone.LineThickness = 3;
            this.tbUserPhone.Location = new System.Drawing.Point(146, 197);
            this.tbUserPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserPhone.Name = "tbUserPhone";
            this.tbUserPhone.Size = new System.Drawing.Size(354, 33);
            this.tbUserPhone.TabIndex = 4;
            this.tbUserPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbIdCard
            // 
            this.tbIdCard.BackColor = System.Drawing.Color.White;
            this.tbIdCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdCard.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdCard.ForeColor = System.Drawing.Color.Blue;
            this.tbIdCard.HintForeColor = System.Drawing.Color.Empty;
            this.tbIdCard.HintText = "";
            this.tbIdCard.isPassword = false;
            this.tbIdCard.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbIdCard.LineIdleColor = System.Drawing.Color.Gray;
            this.tbIdCard.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbIdCard.LineThickness = 3;
            this.tbIdCard.Location = new System.Drawing.Point(146, 135);
            this.tbIdCard.Margin = new System.Windows.Forms.Padding(4);
            this.tbIdCard.Name = "tbIdCard";
            this.tbIdCard.Size = new System.Drawing.Size(354, 33);
            this.tbIdCard.TabIndex = 2;
            this.tbIdCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.White;
            this.tbUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserName.Enabled = false;
            this.tbUserName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.Color.Blue;
            this.tbUserName.HintForeColor = System.Drawing.Color.Empty;
            this.tbUserName.HintText = "";
            this.tbUserName.isPassword = false;
            this.tbUserName.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbUserName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbUserName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbUserName.LineThickness = 3;
            this.tbUserName.Location = new System.Drawing.Point(146, 73);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(354, 33);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(609, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 19);
            this.label10.TabIndex = 81;
            this.label10.Text = "Tên hiển thị";
            // 
            // lbUers
            // 
            this.lbUers.AutoSize = true;
            this.lbUers.BackColor = System.Drawing.Color.Transparent;
            this.lbUers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUers.Location = new System.Drawing.Point(12, 139);
            this.lbUers.Name = "lbUers";
            this.lbUers.Size = new System.Drawing.Size(58, 19);
            this.lbUers.TabIndex = 82;
            this.lbUers.Text = "CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 83;
            this.label3.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 84;
            this.label6.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(609, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 85;
            this.label8.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(609, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 86;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 87;
            this.label5.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 80;
            this.label7.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(787, 24);
            this.label2.TabIndex = 79;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "------------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 78;
            this.label1.Text = "Thông tin tài khoản";
            // 
            // btCancel
            // 
            this.btCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btCancel.BackColor = System.Drawing.Color.Red;
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancel.BorderRadius = 7;
            this.btCancel.ButtonText = "Thoát";
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btCancel.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_cancel_100;
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
            this.btCancel.Location = new System.Drawing.Point(595, 392);
            this.btCancel.Name = "btCancel";
            this.btCancel.Normalcolor = System.Drawing.Color.Red;
            this.btCancel.OnHovercolor = System.Drawing.Color.Maroon;
            this.btCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btCancel.selected = false;
            this.btCancel.Size = new System.Drawing.Size(124, 48);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Thoát";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Textcolor = System.Drawing.Color.White;
            this.btCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btUpdate.BackColor = System.Drawing.Color.Blue;
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
            this.btUpdate.Location = new System.Drawing.Point(386, 392);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Normalcolor = System.Drawing.Color.Blue;
            this.btUpdate.OnHovercolor = System.Drawing.Color.Navy;
            this.btUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btUpdate.selected = false;
            this.btUpdate.Size = new System.Drawing.Size(124, 48);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "Cập nhật";
            this.btUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUpdate.Textcolor = System.Drawing.Color.White;
            this.btUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // FrmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.FrmUserInfo_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerBirthday;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUserAddress;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUserPass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbGender;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbDisplayName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUserEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUserPhone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbIdCard;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbUers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btUpdate;
    }
}