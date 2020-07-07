namespace API_QuanLyNhaThuoc
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelFogetPass = new System.Windows.Forms.Panel();
            this.btContinue = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbUserEmail = new System.Windows.Forms.TextBox();
            this.lbNotification1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btBack = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbUserNameForget = new System.Windows.Forms.TextBox();
            this.panelTransparen = new System.Windows.Forms.Panel();
            this.btLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.lbNotification = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbForgetPass = new System.Windows.Forms.LinkLabel();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.panelChangePass = new System.Windows.Forms.Panel();
            this.tbReEnterPass = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.lbNotification2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btChangePass = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbVerificationCode = new System.Windows.Forms.TextBox();
            this.panelFogetPass.SuspendLayout();
            this.panelTransparen.SuspendLayout();
            this.panelChangePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelFogetPass
            // 
            this.panelFogetPass.BackColor = System.Drawing.Color.Transparent;
            this.panelFogetPass.BackgroundImage = global::API_QuanLyNhaThuoc.Properties.Resources.translate;
            this.panelFogetPass.Controls.Add(this.btContinue);
            this.panelFogetPass.Controls.Add(this.tbUserEmail);
            this.panelFogetPass.Controls.Add(this.lbNotification1);
            this.panelFogetPass.Controls.Add(this.button2);
            this.panelFogetPass.Controls.Add(this.btBack);
            this.panelFogetPass.Controls.Add(this.tbUserNameForget);
            this.panelFogetPass.Location = new System.Drawing.Point(176, 175);
            this.panelFogetPass.Name = "panelFogetPass";
            this.panelFogetPass.Size = new System.Drawing.Size(450, 244);
            this.panelFogetPass.TabIndex = 2;
            // 
            // btContinue
            // 
            this.btContinue.Activecolor = System.Drawing.Color.LightGray;
            this.btContinue.BackColor = System.Drawing.Color.LightGray;
            this.btContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btContinue.BorderRadius = 7;
            this.btContinue.ButtonText = "Tiếp tục";
            this.btContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btContinue.DisabledColor = System.Drawing.Color.LightGray;
            this.btContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContinue.Iconcolor = System.Drawing.Color.Transparent;
            this.btContinue.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_next_page_100;
            this.btContinue.Iconimage_right = null;
            this.btContinue.Iconimage_right_Selected = null;
            this.btContinue.Iconimage_Selected = null;
            this.btContinue.IconMarginLeft = 0;
            this.btContinue.IconMarginRight = 0;
            this.btContinue.IconRightVisible = true;
            this.btContinue.IconRightZoom = 0D;
            this.btContinue.IconVisible = true;
            this.btContinue.IconZoom = 90D;
            this.btContinue.IsTab = false;
            this.btContinue.Location = new System.Drawing.Point(40, 143);
            this.btContinue.Name = "btContinue";
            this.btContinue.Normalcolor = System.Drawing.Color.LightGray;
            this.btContinue.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btContinue.OnHoverTextColor = System.Drawing.Color.Black;
            this.btContinue.selected = false;
            this.btContinue.Size = new System.Drawing.Size(142, 47);
            this.btContinue.TabIndex = 14;
            this.btContinue.Text = "Tiếp tục";
            this.btContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btContinue.Textcolor = System.Drawing.Color.Black;
            this.btContinue.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserEmail.Location = new System.Drawing.Point(40, 84);
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Size = new System.Drawing.Size(371, 33);
            this.tbUserEmail.TabIndex = 3;
            this.tbUserEmail.Enter += new System.EventHandler(this.tbUserEmail_Enter);
            this.tbUserEmail.Leave += new System.EventHandler(this.tbUserEmail_Leave);
            // 
            // lbNotification1
            // 
            this.lbNotification1.AutoSize = true;
            this.lbNotification1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification1.ForeColor = System.Drawing.Color.Red;
            this.lbNotification1.Location = new System.Drawing.Point(37, 199);
            this.lbNotification1.Name = "lbNotification1";
            this.lbNotification1.Size = new System.Drawing.Size(68, 13);
            this.lbNotification1.TabIndex = 13;
            this.lbNotification1.Text = "Thông báo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(336, 1000);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btBack
            // 
            this.btBack.Activecolor = System.Drawing.Color.Gray;
            this.btBack.BackColor = System.Drawing.Color.LightGray;
            this.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBack.BorderRadius = 7;
            this.btBack.ButtonText = "Trở lại";
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.DisabledColor = System.Drawing.Color.Gray;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Iconcolor = System.Drawing.Color.Transparent;
            this.btBack.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_back_arrow_100;
            this.btBack.Iconimage_right = null;
            this.btBack.Iconimage_right_Selected = null;
            this.btBack.Iconimage_Selected = null;
            this.btBack.IconMarginLeft = 0;
            this.btBack.IconMarginRight = 0;
            this.btBack.IconRightVisible = true;
            this.btBack.IconRightZoom = 0D;
            this.btBack.IconVisible = true;
            this.btBack.IconZoom = 90D;
            this.btBack.IsTab = false;
            this.btBack.Location = new System.Drawing.Point(269, 143);
            this.btBack.Name = "btBack";
            this.btBack.Normalcolor = System.Drawing.Color.LightGray;
            this.btBack.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btBack.OnHoverTextColor = System.Drawing.Color.Black;
            this.btBack.selected = false;
            this.btBack.Size = new System.Drawing.Size(142, 47);
            this.btBack.TabIndex = 5;
            this.btBack.Text = "Trở lại";
            this.btBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btBack.Textcolor = System.Drawing.Color.Black;
            this.btBack.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // tbUserNameForget
            // 
            this.tbUserNameForget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserNameForget.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserNameForget.Location = new System.Drawing.Point(40, 23);
            this.tbUserNameForget.Name = "tbUserNameForget";
            this.tbUserNameForget.Size = new System.Drawing.Size(371, 33);
            this.tbUserNameForget.TabIndex = 2;
            this.tbUserNameForget.Enter += new System.EventHandler(this.tbUserNameForget_Enter);
            this.tbUserNameForget.Leave += new System.EventHandler(this.tbUserNameForget_Leave);
            // 
            // panelTransparen
            // 
            this.panelTransparen.BackColor = System.Drawing.Color.Transparent;
            this.panelTransparen.BackgroundImage = global::API_QuanLyNhaThuoc.Properties.Resources.translate;
            this.panelTransparen.Controls.Add(this.btLogin);
            this.panelTransparen.Controls.Add(this.tbPassWord);
            this.panelTransparen.Controls.Add(this.lbNotification);
            this.panelTransparen.Controls.Add(this.button1);
            this.panelTransparen.Controls.Add(this.btExit);
            this.panelTransparen.Controls.Add(this.lbForgetPass);
            this.panelTransparen.Controls.Add(this.tbUserName);
            this.panelTransparen.Location = new System.Drawing.Point(176, 175);
            this.panelTransparen.Name = "panelTransparen";
            this.panelTransparen.Size = new System.Drawing.Size(450, 244);
            this.panelTransparen.TabIndex = 14;
            // 
            // btLogin
            // 
            this.btLogin.Activecolor = System.Drawing.Color.LightGray;
            this.btLogin.BackColor = System.Drawing.Color.LightGray;
            this.btLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLogin.BorderRadius = 7;
            this.btLogin.ButtonText = "Đăng nhập";
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.DisabledColor = System.Drawing.Color.LightGray;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btLogin.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_login_100;
            this.btLogin.Iconimage_right = null;
            this.btLogin.Iconimage_right_Selected = null;
            this.btLogin.Iconimage_Selected = null;
            this.btLogin.IconMarginLeft = 0;
            this.btLogin.IconMarginRight = 0;
            this.btLogin.IconRightVisible = true;
            this.btLogin.IconRightZoom = 0D;
            this.btLogin.IconVisible = true;
            this.btLogin.IconZoom = 90D;
            this.btLogin.IsTab = false;
            this.btLogin.Location = new System.Drawing.Point(40, 143);
            this.btLogin.Name = "btLogin";
            this.btLogin.Normalcolor = System.Drawing.Color.LightGray;
            this.btLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btLogin.OnHoverTextColor = System.Drawing.Color.Black;
            this.btLogin.selected = false;
            this.btLogin.Size = new System.Drawing.Size(142, 47);
            this.btLogin.TabIndex = 14;
            this.btLogin.Text = "Đăng nhập";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLogin.Textcolor = System.Drawing.Color.Black;
            this.btLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbPassWord
            // 
            this.tbPassWord.BackColor = System.Drawing.SystemColors.Window;
            this.tbPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassWord.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassWord.Location = new System.Drawing.Point(40, 84);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(371, 33);
            this.tbPassWord.TabIndex = 3;
            this.tbPassWord.Text = "1";
            this.tbPassWord.UseSystemPasswordChar = true;
            this.tbPassWord.Enter += new System.EventHandler(this.tbPassWord_Enter);
            this.tbPassWord.Leave += new System.EventHandler(this.tbPassWord_Leave);
            // 
            // lbNotification
            // 
            this.lbNotification.AutoSize = true;
            this.lbNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification.ForeColor = System.Drawing.Color.Red;
            this.lbNotification.Location = new System.Drawing.Point(37, 199);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(68, 13);
            this.lbNotification.TabIndex = 13;
            this.lbNotification.Text = "Thông báo";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(336, 1000);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btExit
            // 
            this.btExit.Activecolor = System.Drawing.Color.Gray;
            this.btExit.BackColor = System.Drawing.Color.LightGray;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExit.BorderRadius = 7;
            this.btExit.ButtonText = "Thoát";
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.DisabledColor = System.Drawing.Color.Gray;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btExit.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_shutdown_100;
            this.btExit.Iconimage_right = null;
            this.btExit.Iconimage_right_Selected = null;
            this.btExit.Iconimage_Selected = null;
            this.btExit.IconMarginLeft = 0;
            this.btExit.IconMarginRight = 0;
            this.btExit.IconRightVisible = true;
            this.btExit.IconRightZoom = 0D;
            this.btExit.IconVisible = true;
            this.btExit.IconZoom = 90D;
            this.btExit.IsTab = false;
            this.btExit.Location = new System.Drawing.Point(269, 143);
            this.btExit.Name = "btExit";
            this.btExit.Normalcolor = System.Drawing.Color.LightGray;
            this.btExit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btExit.OnHoverTextColor = System.Drawing.Color.Black;
            this.btExit.selected = false;
            this.btExit.Size = new System.Drawing.Size(142, 47);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Thoát";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btExit.Textcolor = System.Drawing.Color.Black;
            this.btExit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbForgetPass
            // 
            this.lbForgetPass.ActiveLinkColor = System.Drawing.Color.Black;
            this.lbForgetPass.AutoSize = true;
            this.lbForgetPass.Location = new System.Drawing.Point(37, 217);
            this.lbForgetPass.Name = "lbForgetPass";
            this.lbForgetPass.Size = new System.Drawing.Size(89, 13);
            this.lbForgetPass.TabIndex = 6;
            this.lbForgetPass.TabStop = true;
            this.lbForgetPass.Text = "Quên mật khẩu ?";
            this.lbForgetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbForgetPass_LinkClicked);
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(40, 23);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(371, 33);
            this.tbUserName.TabIndex = 2;
            this.tbUserName.Text = "0302666666";
            this.tbUserName.Enter += new System.EventHandler(this.tbUserName_Enter);
            this.tbUserName.Leave += new System.EventHandler(this.tbUserName_Leave);
            // 
            // panelChangePass
            // 
            this.panelChangePass.BackColor = System.Drawing.Color.Transparent;
            this.panelChangePass.BackgroundImage = global::API_QuanLyNhaThuoc.Properties.Resources.translate;
            this.panelChangePass.Controls.Add(this.tbReEnterPass);
            this.panelChangePass.Controls.Add(this.tbNewPass);
            this.panelChangePass.Controls.Add(this.lbNotification2);
            this.panelChangePass.Controls.Add(this.button3);
            this.panelChangePass.Controls.Add(this.btCancel);
            this.panelChangePass.Controls.Add(this.btChangePass);
            this.panelChangePass.Controls.Add(this.tbVerificationCode);
            this.panelChangePass.Location = new System.Drawing.Point(176, 175);
            this.panelChangePass.Name = "panelChangePass";
            this.panelChangePass.Size = new System.Drawing.Size(450, 244);
            this.panelChangePass.TabIndex = 15;
            // 
            // tbReEnterPass
            // 
            this.tbReEnterPass.BackColor = System.Drawing.SystemColors.Window;
            this.tbReEnterPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbReEnterPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReEnterPass.Location = new System.Drawing.Point(40, 98);
            this.tbReEnterPass.Name = "tbReEnterPass";
            this.tbReEnterPass.Size = new System.Drawing.Size(371, 33);
            this.tbReEnterPass.TabIndex = 4;
            this.tbReEnterPass.UseSystemPasswordChar = true;
            this.tbReEnterPass.Enter += new System.EventHandler(this.tbReEnterPass_Enter);
            this.tbReEnterPass.Leave += new System.EventHandler(this.tbReEnterPass_Leave);
            // 
            // tbNewPass
            // 
            this.tbNewPass.BackColor = System.Drawing.SystemColors.Window;
            this.tbNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass.Location = new System.Drawing.Point(40, 57);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Size = new System.Drawing.Size(371, 33);
            this.tbNewPass.TabIndex = 3;
            this.tbNewPass.UseSystemPasswordChar = true;
            this.tbNewPass.Enter += new System.EventHandler(this.tbNewPass_Enter);
            this.tbNewPass.Leave += new System.EventHandler(this.tbNewPass_Leave);
            // 
            // lbNotification2
            // 
            this.lbNotification2.AutoSize = true;
            this.lbNotification2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification2.ForeColor = System.Drawing.Color.Red;
            this.lbNotification2.Location = new System.Drawing.Point(37, 199);
            this.lbNotification2.Name = "lbNotification2";
            this.lbNotification2.Size = new System.Drawing.Size(68, 13);
            this.lbNotification2.TabIndex = 13;
            this.lbNotification2.Text = "Thông báo";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 1000);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Activecolor = System.Drawing.Color.Gray;
            this.btCancel.BackColor = System.Drawing.Color.LightGray;
            this.btCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancel.BorderRadius = 7;
            this.btCancel.ButtonText = "Hủy";
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btCancel.Location = new System.Drawing.Point(269, 143);
            this.btCancel.Name = "btCancel";
            this.btCancel.Normalcolor = System.Drawing.Color.LightGray;
            this.btCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancel.OnHoverTextColor = System.Drawing.Color.Black;
            this.btCancel.selected = false;
            this.btCancel.Size = new System.Drawing.Size(142, 47);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Hủy";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCancel.Textcolor = System.Drawing.Color.Black;
            this.btCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btChangePass
            // 
            this.btChangePass.Activecolor = System.Drawing.Color.LightGray;
            this.btChangePass.BackColor = System.Drawing.Color.LightGray;
            this.btChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btChangePass.BorderRadius = 7;
            this.btChangePass.ButtonText = "Đổi mật khẩu";
            this.btChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChangePass.DisabledColor = System.Drawing.Color.LightGray;
            this.btChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangePass.Iconcolor = System.Drawing.Color.Transparent;
            this.btChangePass.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_change_100;
            this.btChangePass.Iconimage_right = null;
            this.btChangePass.Iconimage_right_Selected = null;
            this.btChangePass.Iconimage_Selected = null;
            this.btChangePass.IconMarginLeft = 0;
            this.btChangePass.IconMarginRight = 0;
            this.btChangePass.IconRightVisible = true;
            this.btChangePass.IconRightZoom = 0D;
            this.btChangePass.IconVisible = true;
            this.btChangePass.IconZoom = 90D;
            this.btChangePass.IsTab = false;
            this.btChangePass.Location = new System.Drawing.Point(40, 143);
            this.btChangePass.Name = "btChangePass";
            this.btChangePass.Normalcolor = System.Drawing.Color.LightGray;
            this.btChangePass.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btChangePass.OnHoverTextColor = System.Drawing.Color.Black;
            this.btChangePass.selected = false;
            this.btChangePass.Size = new System.Drawing.Size(142, 47);
            this.btChangePass.TabIndex = 5;
            this.btChangePass.Text = "Đổi mật khẩu";
            this.btChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btChangePass.Textcolor = System.Drawing.Color.Black;
            this.btChangePass.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangePass.Click += new System.EventHandler(this.btChangePass_Click);
            // 
            // tbVerificationCode
            // 
            this.tbVerificationCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbVerificationCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVerificationCode.Location = new System.Drawing.Point(40, 16);
            this.tbVerificationCode.Name = "tbVerificationCode";
            this.tbVerificationCode.Size = new System.Drawing.Size(371, 33);
            this.tbVerificationCode.TabIndex = 2;
            this.tbVerificationCode.Enter += new System.EventHandler(this.tbVerificationCode_Enter);
            this.tbVerificationCode.Leave += new System.EventHandler(this.tbVerificationCode_Leave);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::API_QuanLyNhaThuoc.Properties.Resources.image_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.panelTransparen);
            this.Controls.Add(this.panelFogetPass);
            this.Controls.Add(this.panelChangePass);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 500);
            this.MinimumSize = new System.Drawing.Size(816, 500);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panelFogetPass.ResumeLayout(false);
            this.panelFogetPass.PerformLayout();
            this.panelTransparen.ResumeLayout(false);
            this.panelTransparen.PerformLayout();
            this.panelChangePass.ResumeLayout(false);
            this.panelChangePass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelFogetPass;
        private System.Windows.Forms.TextBox tbUserEmail;
        private System.Windows.Forms.Label lbNotification1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuFlatButton btBack;
        private System.Windows.Forms.TextBox tbUserNameForget;
        private System.Windows.Forms.Panel panelTransparen;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Label lbNotification;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuFlatButton btExit;
        private System.Windows.Forms.LinkLabel lbForgetPass;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Panel panelChangePass;
        private System.Windows.Forms.TextBox tbReEnterPass;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.Label lbNotification2;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuFlatButton btCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btChangePass;
        private System.Windows.Forms.TextBox tbVerificationCode;
        private Bunifu.Framework.UI.BunifuFlatButton btLogin;
        private Bunifu.Framework.UI.BunifuFlatButton btContinue;
    }
}