namespace API_QuanLyNhaThuoc
{
    partial class FrmCreateInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbNotification = new System.Windows.Forms.Label();
            this.timerResetNtf = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.dgvSearchItem = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.btAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelLoadItem = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.rtbAmountInWord = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.btCreateAndPrintInvoice = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btCreateInvoice = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbTotalPayment = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.lbIdBill = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nbDisCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCreator = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSellerEmail = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbSellerAddress = new System.Windows.Forms.Label();
            this.lbSellerLegalName = new System.Windows.Forms.Label();
            this.lbSellerPhoneNumber = new System.Windows.Forms.Label();
            this.lbSellerTaxCode = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btNewBuyer = new Bunifu.Framework.UI.BunifuImageButton();
            this.tbBuyerPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBuyerEmail = new System.Windows.Forms.TextBox();
            this.tbBuyerAddress = new System.Windows.Forms.TextBox();
            this.tbBuyerName = new System.Windows.Forms.TextBox();
            this.cbBuyerCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchItem)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDisCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btNewBuyer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNotification
            // 
            this.lbNotification.AutoSize = true;
            this.lbNotification.BackColor = System.Drawing.Color.Transparent;
            this.lbNotification.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification.ForeColor = System.Drawing.Color.Red;
            this.lbNotification.Location = new System.Drawing.Point(569, 237);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(66, 15);
            this.lbNotification.TabIndex = 33;
            this.lbNotification.Text = "Thông báo";
            // 
            // timerResetNtf
            // 
            this.timerResetNtf.Interval = 1000;
            this.timerResetNtf.Tick += new System.EventHandler(this.timerResetNtf_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(7, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 95;
            this.label9.Text = "Lập hóa đơn";
            // 
            // dgvSearchItem
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSearchItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvSearchItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSearchItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column6,
            this.gg,
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column4});
            this.dgvSearchItem.EnableHeadersVisualStyles = false;
            this.dgvSearchItem.Location = new System.Drawing.Point(7, 0);
            this.dgvSearchItem.Name = "dgvSearchItem";
            this.dgvSearchItem.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSearchItem.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchItem.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSearchItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchItem.Size = new System.Drawing.Size(802, 221);
            this.dgvSearchItem.TabIndex = 163;
            this.dgvSearchItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchItem_CellClick);
            this.dgvSearchItem.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSearchItem_RowsAdded);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(13, 273);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 15);
            this.label14.TabIndex = 164;
            this.label14.Text = "Stt";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(46, 273);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 15);
            this.label17.TabIndex = 165;
            this.label17.Text = "Sản phẩm";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(316, 273);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 15);
            this.label19.TabIndex = 166;
            this.label19.Text = "Đơn vị tính";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(429, 273);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 15);
            this.label20.TabIndex = 167;
            this.label20.Text = "Đơn giá";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(624, 273);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 15);
            this.label21.TabIndex = 168;
            this.label21.Text = "Thành tiền";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(717, 273);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 15);
            this.label22.TabIndex = 169;
            this.label22.Text = "Xóa";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(522, 273);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 15);
            this.label23.TabIndex = 35;
            this.label23.Text = "Số lượng";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearch.BackgroundImage")));
            this.tbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSearch.ForeColor = System.Drawing.Color.DarkMagenta;
            this.tbSearch.Icon = ((System.Drawing.Image)(resources.GetObject("tbSearch.Icon")));
            this.tbSearch.Location = new System.Drawing.Point(11, 227);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(250, 34);
            this.tbSearch.TabIndex = 138;
            this.tbSearch.text = "";
            this.tbSearch.OnTextChange += new System.EventHandler(this.tbSearch_OnTextChange);
            // 
            // btAdd
            // 
            this.btAdd.Activecolor = System.Drawing.Color.Gray;
            this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAdd.BorderRadius = 7;
            this.btAdd.ButtonText = "Thêm";
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btAdd.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_plus_100;
            this.btAdd.Iconimage_right = null;
            this.btAdd.Iconimage_right_Selected = null;
            this.btAdd.Iconimage_Selected = null;
            this.btAdd.IconMarginLeft = 0;
            this.btAdd.IconMarginRight = 0;
            this.btAdd.IconRightVisible = true;
            this.btAdd.IconRightZoom = 0D;
            this.btAdd.IconVisible = true;
            this.btAdd.IconZoom = 70D;
            this.btAdd.IsTab = false;
            this.btAdd.Location = new System.Drawing.Point(278, 227);
            this.btAdd.Name = "btAdd";
            this.btAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAdd.OnHovercolor = System.Drawing.Color.Gray;
            this.btAdd.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btAdd.selected = false;
            this.btAdd.Size = new System.Drawing.Size(80, 34);
            this.btAdd.TabIndex = 137;
            this.btAdd.Text = "Thêm";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btAdd.Textcolor = System.Drawing.Color.White;
            this.btAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // PanelLoadItem
            // 
            this.PanelLoadItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelLoadItem.BackgroundImage")));
            this.PanelLoadItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelLoadItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLoadItem.GradientBottomLeft = System.Drawing.Color.White;
            this.PanelLoadItem.GradientBottomRight = System.Drawing.Color.White;
            this.PanelLoadItem.GradientTopLeft = System.Drawing.Color.White;
            this.PanelLoadItem.GradientTopRight = System.Drawing.Color.White;
            this.PanelLoadItem.Location = new System.Drawing.Point(4, 291);
            this.PanelLoadItem.Name = "PanelLoadItem";
            this.PanelLoadItem.Quality = 10;
            this.PanelLoadItem.Size = new System.Drawing.Size(745, 366);
            this.PanelLoadItem.TabIndex = 96;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.rtbAmountInWord);
            this.bunifuGradientPanel1.Controls.Add(this.label12);
            this.bunifuGradientPanel1.Controls.Add(this.btCreateAndPrintInvoice);
            this.bunifuGradientPanel1.Controls.Add(this.btCreateInvoice);
            this.bunifuGradientPanel1.Controls.Add(this.lbTotalPayment);
            this.bunifuGradientPanel1.Controls.Add(this.lbTotalAmount);
            this.bunifuGradientPanel1.Controls.Add(this.rtbNote);
            this.bunifuGradientPanel1.Controls.Add(this.lbIdBill);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.nbDisCount);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.lbCreator);
            this.bunifuGradientPanel1.Controls.Add(this.lbTime);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(136)))), ((int)(((byte)(144)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(755, 268);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(317, 389);
            this.bunifuGradientPanel1.TabIndex = 34;
            // 
            // rtbAmountInWord
            // 
            this.rtbAmountInWord.BackColor = System.Drawing.Color.Transparent;
            this.rtbAmountInWord.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAmountInWord.Location = new System.Drawing.Point(104, 155);
            this.rtbAmountInWord.Name = "rtbAmountInWord";
            this.rtbAmountInWord.Size = new System.Drawing.Size(205, 40);
            this.rtbAmountInWord.TabIndex = 46;
            this.rtbAmountInWord.Text = "Tiền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(7, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "Tiền bằng chữ:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btCreateAndPrintInvoice
            // 
            this.btCreateAndPrintInvoice.Activecolor = System.Drawing.Color.LightGray;
            this.btCreateAndPrintInvoice.BackColor = System.Drawing.Color.LightGray;
            this.btCreateAndPrintInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCreateAndPrintInvoice.BorderRadius = 7;
            this.btCreateAndPrintInvoice.ButtonText = "LẬP VÀ IN HÓA ĐƠN";
            this.btCreateAndPrintInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCreateAndPrintInvoice.DisabledColor = System.Drawing.Color.LightGray;
            this.btCreateAndPrintInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateAndPrintInvoice.Iconcolor = System.Drawing.Color.Transparent;
            this.btCreateAndPrintInvoice.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_print_100;
            this.btCreateAndPrintInvoice.Iconimage_right = null;
            this.btCreateAndPrintInvoice.Iconimage_right_Selected = null;
            this.btCreateAndPrintInvoice.Iconimage_Selected = null;
            this.btCreateAndPrintInvoice.IconMarginLeft = 0;
            this.btCreateAndPrintInvoice.IconMarginRight = 0;
            this.btCreateAndPrintInvoice.IconRightVisible = true;
            this.btCreateAndPrintInvoice.IconRightZoom = 0D;
            this.btCreateAndPrintInvoice.IconVisible = true;
            this.btCreateAndPrintInvoice.IconZoom = 90D;
            this.btCreateAndPrintInvoice.IsTab = false;
            this.btCreateAndPrintInvoice.Location = new System.Drawing.Point(10, 333);
            this.btCreateAndPrintInvoice.Name = "btCreateAndPrintInvoice";
            this.btCreateAndPrintInvoice.Normalcolor = System.Drawing.Color.LightGray;
            this.btCreateAndPrintInvoice.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCreateAndPrintInvoice.OnHoverTextColor = System.Drawing.Color.Black;
            this.btCreateAndPrintInvoice.selected = false;
            this.btCreateAndPrintInvoice.Size = new System.Drawing.Size(299, 47);
            this.btCreateAndPrintInvoice.TabIndex = 43;
            this.btCreateAndPrintInvoice.Text = "LẬP VÀ IN HÓA ĐƠN";
            this.btCreateAndPrintInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCreateAndPrintInvoice.Textcolor = System.Drawing.Color.Black;
            this.btCreateAndPrintInvoice.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateAndPrintInvoice.Click += new System.EventHandler(this.btCreateAndPrintInvoice_Click);
            // 
            // btCreateInvoice
            // 
            this.btCreateInvoice.Activecolor = System.Drawing.Color.LightGray;
            this.btCreateInvoice.BackColor = System.Drawing.Color.LightGray;
            this.btCreateInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCreateInvoice.BorderRadius = 7;
            this.btCreateInvoice.ButtonText = "LẬP HÓA ĐƠN";
            this.btCreateInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCreateInvoice.DisabledColor = System.Drawing.Color.LightGray;
            this.btCreateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateInvoice.Iconcolor = System.Drawing.Color.Transparent;
            this.btCreateInvoice.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_create_document_100;
            this.btCreateInvoice.Iconimage_right = null;
            this.btCreateInvoice.Iconimage_right_Selected = null;
            this.btCreateInvoice.Iconimage_Selected = null;
            this.btCreateInvoice.IconMarginLeft = 0;
            this.btCreateInvoice.IconMarginRight = 0;
            this.btCreateInvoice.IconRightVisible = true;
            this.btCreateInvoice.IconRightZoom = 0D;
            this.btCreateInvoice.IconVisible = true;
            this.btCreateInvoice.IconZoom = 90D;
            this.btCreateInvoice.IsTab = false;
            this.btCreateInvoice.Location = new System.Drawing.Point(10, 278);
            this.btCreateInvoice.Name = "btCreateInvoice";
            this.btCreateInvoice.Normalcolor = System.Drawing.Color.LightGray;
            this.btCreateInvoice.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCreateInvoice.OnHoverTextColor = System.Drawing.Color.Black;
            this.btCreateInvoice.selected = false;
            this.btCreateInvoice.Size = new System.Drawing.Size(299, 47);
            this.btCreateInvoice.TabIndex = 42;
            this.btCreateInvoice.Text = "LẬP HÓA ĐƠN";
            this.btCreateInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCreateInvoice.Textcolor = System.Drawing.Color.Black;
            this.btCreateInvoice.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateInvoice.Click += new System.EventHandler(this.btCreateInvoice_Click);
            // 
            // lbTotalPayment
            // 
            this.lbTotalPayment.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalPayment.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotalPayment.Location = new System.Drawing.Point(218, 119);
            this.lbTotalPayment.Name = "lbTotalPayment";
            this.lbTotalPayment.Size = new System.Drawing.Size(91, 15);
            this.lbTotalPayment.TabIndex = 41;
            this.lbTotalPayment.Text = "000000";
            this.lbTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalAmount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTotalAmount.Location = new System.Drawing.Point(218, 50);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(91, 15);
            this.lbTotalAmount.TabIndex = 40;
            this.lbTotalAmount.Text = "000000";
            this.lbTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rtbNote
            // 
            this.rtbNote.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbNote.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNote.Location = new System.Drawing.Point(10, 213);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(299, 56);
            this.rtbNote.TabIndex = 39;
            this.rtbNote.Text = "";
            // 
            // lbIdBill
            // 
            this.lbIdBill.AutoSize = true;
            this.lbIdBill.BackColor = System.Drawing.Color.Transparent;
            this.lbIdBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdBill.ForeColor = System.Drawing.Color.Red;
            this.lbIdBill.Location = new System.Drawing.Point(118, 23);
            this.lbIdBill.Name = "lbIdBill";
            this.lbIdBill.Size = new System.Drawing.Size(87, 19);
            this.lbIdBill.TabIndex = 38;
            this.lbIdBill.Text = "HD000000";
            this.lbIdBill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(7, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 15);
            this.label7.TabIndex = 37;
            this.label7.Text = "Tổng tiền thanh toán";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nbDisCount
            // 
            this.nbDisCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nbDisCount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbDisCount.Location = new System.Drawing.Point(262, 81);
            this.nbDisCount.Name = "nbDisCount";
            this.nbDisCount.Size = new System.Drawing.Size(47, 25);
            this.nbDisCount.TabIndex = 32;
            this.nbDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbDisCount.ValueChanged += new System.EventHandler(this.nbDisCount_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ghi chú";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Giảm giá (%)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cộng tiền hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbCreator
            // 
            this.lbCreator.AutoSize = true;
            this.lbCreator.BackColor = System.Drawing.Color.Transparent;
            this.lbCreator.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbCreator.Location = new System.Drawing.Point(7, 5);
            this.lbCreator.Name = "lbCreator";
            this.lbCreator.Size = new System.Drawing.Size(40, 15);
            this.lbCreator.TabIndex = 33;
            this.lbCreator.Text = "Name";
            this.lbCreator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTime.Location = new System.Drawing.Point(238, 5);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(71, 15);
            this.lbTime.TabIndex = 31;
            this.lbTime.Text = "01-01-2020";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::API_QuanLyNhaThuoc.Properties.Resources.translate;
            this.groupBox2.Controls.Add(this.lbSellerEmail);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbSellerAddress);
            this.groupBox2.Controls.Add(this.lbSellerLegalName);
            this.groupBox2.Controls.Add(this.lbSellerPhoneNumber);
            this.groupBox2.Controls.Add(this.lbSellerTaxCode);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(540, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 194);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin người bán";
            // 
            // lbSellerEmail
            // 
            this.lbSellerEmail.AutoSize = true;
            this.lbSellerEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbSellerEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSellerEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSellerEmail.Location = new System.Drawing.Point(87, 166);
            this.lbSellerEmail.Name = "lbSellerEmail";
            this.lbSellerEmail.Size = new System.Drawing.Size(99, 15);
            this.lbSellerEmail.TabIndex = 34;
            this.lbSellerEmail.Text = "abc@email.com";
            this.lbSellerEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(10, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "Email:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSellerAddress
            // 
            this.lbSellerAddress.AutoSize = true;
            this.lbSellerAddress.BackColor = System.Drawing.Color.Transparent;
            this.lbSellerAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSellerAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSellerAddress.Location = new System.Drawing.Point(87, 100);
            this.lbSellerAddress.Name = "lbSellerAddress";
            this.lbSellerAddress.Size = new System.Drawing.Size(33, 15);
            this.lbSellerAddress.TabIndex = 32;
            this.lbSellerAddress.Text = "HCM";
            this.lbSellerAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSellerLegalName
            // 
            this.lbSellerLegalName.AutoSize = true;
            this.lbSellerLegalName.BackColor = System.Drawing.Color.Transparent;
            this.lbSellerLegalName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSellerLegalName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSellerLegalName.Location = new System.Drawing.Point(87, 31);
            this.lbSellerLegalName.Name = "lbSellerLegalName";
            this.lbSellerLegalName.Size = new System.Drawing.Size(36, 15);
            this.lbSellerLegalName.TabIndex = 29;
            this.lbSellerLegalName.Text = "Cty A";
            this.lbSellerLegalName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSellerPhoneNumber
            // 
            this.lbSellerPhoneNumber.AutoSize = true;
            this.lbSellerPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbSellerPhoneNumber.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSellerPhoneNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSellerPhoneNumber.Location = new System.Drawing.Point(87, 135);
            this.lbSellerPhoneNumber.Name = "lbSellerPhoneNumber";
            this.lbSellerPhoneNumber.Size = new System.Drawing.Size(77, 15);
            this.lbSellerPhoneNumber.TabIndex = 31;
            this.lbSellerPhoneNumber.Text = "0123456789";
            this.lbSellerPhoneNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSellerTaxCode
            // 
            this.lbSellerTaxCode.AutoSize = true;
            this.lbSellerTaxCode.BackColor = System.Drawing.Color.Transparent;
            this.lbSellerTaxCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSellerTaxCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbSellerTaxCode.Location = new System.Drawing.Point(87, 64);
            this.lbSellerTaxCode.Name = "lbSellerTaxCode";
            this.lbSellerTaxCode.Size = new System.Drawing.Size(77, 15);
            this.lbSellerTaxCode.TabIndex = 30;
            this.lbSellerTaxCode.Text = "0123456789";
            this.lbSellerTaxCode.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(10, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Địa chỉ:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(10, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "Đơn vị bán:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(10, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 27;
            this.label16.Text = "Điện thoại:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(10, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 15);
            this.label18.TabIndex = 26;
            this.label18.Text = "Mã số thuế:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::API_QuanLyNhaThuoc.Properties.Resources.translate;
            this.groupBox1.Controls.Add(this.btNewBuyer);
            this.groupBox1.Controls.Add(this.tbBuyerPhone);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbBuyerEmail);
            this.groupBox1.Controls.Add(this.tbBuyerAddress);
            this.groupBox1.Controls.Add(this.tbBuyerName);
            this.groupBox1.Controls.Add(this.cbBuyerCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(4, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 194);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btNewBuyer
            // 
            this.btNewBuyer.BackColor = System.Drawing.Color.Transparent;
            this.btNewBuyer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btNewBuyer.Image = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_plus_100;
            this.btNewBuyer.ImageActive = null;
            this.btNewBuyer.Location = new System.Drawing.Point(492, 28);
            this.btNewBuyer.Name = "btNewBuyer";
            this.btNewBuyer.Size = new System.Drawing.Size(25, 23);
            this.btNewBuyer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btNewBuyer.TabIndex = 31;
            this.btNewBuyer.TabStop = false;
            this.btNewBuyer.Zoom = 10;
            this.btNewBuyer.Click += new System.EventHandler(this.btNewBuyer_Click);
            // 
            // tbBuyerPhone
            // 
            this.tbBuyerPhone.Enabled = false;
            this.tbBuyerPhone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyerPhone.Location = new System.Drawing.Point(113, 163);
            this.tbBuyerPhone.Name = "tbBuyerPhone";
            this.tbBuyerPhone.Size = new System.Drawing.Size(404, 21);
            this.tbBuyerPhone.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(8, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Số điện thoại:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbBuyerEmail
            // 
            this.tbBuyerEmail.Enabled = false;
            this.tbBuyerEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyerEmail.Location = new System.Drawing.Point(113, 132);
            this.tbBuyerEmail.Name = "tbBuyerEmail";
            this.tbBuyerEmail.Size = new System.Drawing.Size(404, 21);
            this.tbBuyerEmail.TabIndex = 28;
            // 
            // tbBuyerAddress
            // 
            this.tbBuyerAddress.Enabled = false;
            this.tbBuyerAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyerAddress.Location = new System.Drawing.Point(113, 97);
            this.tbBuyerAddress.Name = "tbBuyerAddress";
            this.tbBuyerAddress.Size = new System.Drawing.Size(404, 21);
            this.tbBuyerAddress.TabIndex = 27;
            // 
            // tbBuyerName
            // 
            this.tbBuyerName.Enabled = false;
            this.tbBuyerName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyerName.Location = new System.Drawing.Point(113, 61);
            this.tbBuyerName.Name = "tbBuyerName";
            this.tbBuyerName.Size = new System.Drawing.Size(404, 21);
            this.tbBuyerName.TabIndex = 26;
            // 
            // cbBuyerCode
            // 
            this.cbBuyerCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuyerCode.FormattingEnabled = true;
            this.cbBuyerCode.Location = new System.Drawing.Point(113, 28);
            this.cbBuyerCode.Name = "cbBuyerCode";
            this.cbBuyerCode.Size = new System.Drawing.Size(380, 23);
            this.cbBuyerCode.TabIndex = 25;
            this.cbBuyerCode.SelectedIndexChanged += new System.EventHandler(this.cbBuyerCode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Địa chỉ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(8, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mã khách hàng:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(8, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tên người mua:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(8, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Column8
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column8.HeaderText = "Stt";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 30;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Id";
            this.Column6.HeaderText = "Mã sản phẩm";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // gg
            // 
            this.gg.DataPropertyName = "SyntheticName";
            this.gg.HeaderText = "Thông tin sản phẩm";
            this.gg.Name = "gg";
            this.gg.ReadOnly = true;
            this.gg.Width = 250;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Image";
            this.Column7.HeaderText = "Hình ảnh";
            this.Column7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UnitName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "Đơn vị cơ bản";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ExpDate";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column2.HeaderText = "Hạn sử dụng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "InventoryNumber";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Số lượng tồn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FrmCreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgvSearchItem);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.PanelLoadItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.lbNotification);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreateInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreateInvoice";
            this.Load += new System.EventHandler(this.FrmCreateInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchItem)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbDisCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btNewBuyer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbBuyerCode;
        private System.Windows.Forms.Label lbSellerAddress;
        private System.Windows.Forms.Label lbSellerLegalName;
        private System.Windows.Forms.Label lbSellerPhoneNumber;
        private System.Windows.Forms.Label lbSellerTaxCode;
        private System.Windows.Forms.TextBox tbBuyerEmail;
        private System.Windows.Forms.TextBox tbBuyerAddress;
        private System.Windows.Forms.TextBox tbBuyerName;
        private System.Windows.Forms.Label lbSellerEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbBuyerPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbNotification;
        private System.Windows.Forms.Timer timerResetNtf;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuFlatButton btCreateAndPrintInvoice;
        private Bunifu.Framework.UI.BunifuFlatButton btCreateInvoice;
        private System.Windows.Forms.Label lbTotalPayment;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label lbIdBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nbDisCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCreator;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuImageButton btNewBuyer;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelLoadItem;
        private Bunifu.Framework.UI.BunifuTextbox tbSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btAdd;
        private System.Windows.Forms.DataGridView dgvSearchItem;
        private Bunifu.Framework.UI.BunifuCustomLabel rtbAmountInWord;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn gg;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}