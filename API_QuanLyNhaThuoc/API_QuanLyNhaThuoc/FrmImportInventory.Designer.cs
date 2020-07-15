namespace API_QuanLyNhaThuoc
{
    partial class FrmImportInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportInventory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btCreateInvoice = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rtbNote = new System.Windows.Forms.RichTextBox();
            this.lbIdImportBill = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCreator = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.dgvListInvoice = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvButtonImport = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvButtonView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gdvButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.lbNotification = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbPNThangNay = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbPNThangTruoc = new System.Windows.Forms.Label();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbTCThangNay = new System.Windows.Forms.Label();
            this.lbDoanhSo = new System.Windows.Forms.Label();
            this.lbTCThangTruoc = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInvoice)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.btCreateInvoice);
            this.bunifuGradientPanel2.Controls.Add(this.rtbNote);
            this.bunifuGradientPanel2.Controls.Add(this.lbIdImportBill);
            this.bunifuGradientPanel2.Controls.Add(this.label3);
            this.bunifuGradientPanel2.Controls.Add(this.lbCreator);
            this.bunifuGradientPanel2.Controls.Add(this.lbTime);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(204)))), ((int)(((byte)(216)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(136)))), ((int)(((byte)(144)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(12, 61);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(317, 229);
            this.bunifuGradientPanel2.TabIndex = 101;
            // 
            // btCreateInvoice
            // 
            this.btCreateInvoice.Activecolor = System.Drawing.Color.LightGray;
            this.btCreateInvoice.BackColor = System.Drawing.Color.LightGray;
            this.btCreateInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCreateInvoice.BorderRadius = 7;
            this.btCreateInvoice.ButtonText = "THÊM PHIẾU NHẬP TỒN";
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
            this.btCreateInvoice.Location = new System.Drawing.Point(10, 162);
            this.btCreateInvoice.Name = "btCreateInvoice";
            this.btCreateInvoice.Normalcolor = System.Drawing.Color.LightGray;
            this.btCreateInvoice.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCreateInvoice.OnHoverTextColor = System.Drawing.Color.Black;
            this.btCreateInvoice.selected = false;
            this.btCreateInvoice.Size = new System.Drawing.Size(299, 47);
            this.btCreateInvoice.TabIndex = 42;
            this.btCreateInvoice.Text = "THÊM PHIẾU NHẬP TỒN";
            this.btCreateInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCreateInvoice.Textcolor = System.Drawing.Color.Black;
            this.btCreateInvoice.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateInvoice.Click += new System.EventHandler(this.btCreateInvoice_Click);
            // 
            // rtbNote
            // 
            this.rtbNote.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbNote.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNote.Location = new System.Drawing.Point(10, 72);
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.Size = new System.Drawing.Size(299, 75);
            this.rtbNote.TabIndex = 39;
            this.rtbNote.Text = "";
            // 
            // lbIdImportBill
            // 
            this.lbIdImportBill.AutoSize = true;
            this.lbIdImportBill.BackColor = System.Drawing.Color.Transparent;
            this.lbIdImportBill.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdImportBill.ForeColor = System.Drawing.Color.Red;
            this.lbIdImportBill.Location = new System.Drawing.Point(118, 23);
            this.lbIdImportBill.Name = "lbIdImportBill";
            this.lbIdImportBill.Size = new System.Drawing.Size(85, 19);
            this.lbIdImportBill.TabIndex = 38;
            this.lbIdImportBill.Text = "NT000000";
            this.lbIdImportBill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ghi chú";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // dgvListInvoice
            // 
            this.dgvListInvoice.AllowUserToDeleteRows = false;
            this.dgvListInvoice.AllowUserToResizeColumns = false;
            this.dgvListInvoice.AllowUserToResizeRows = false;
            this.dgvListInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dgvListInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.dgvButtonImport,
            this.dgvButtonView,
            this.Column1,
            this.NL,
            this.Column3,
            this.Column2,
            this.Column5,
            this.Column4,
            this.gdvButtonDelete});
            this.dgvListInvoice.EnableHeadersVisualStyles = false;
            this.dgvListInvoice.Location = new System.Drawing.Point(12, 307);
            this.dgvListInvoice.Name = "dgvListInvoice";
            this.dgvListInvoice.ReadOnly = true;
            this.dgvListInvoice.RowHeadersVisible = false;
            this.dgvListInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListInvoice.Size = new System.Drawing.Size(1056, 315);
            this.dgvListInvoice.TabIndex = 102;
            this.dgvListInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListInvoice_CellClick);
            this.dgvListInvoice.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvListInvoice_RowsAdded);
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "STT";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 30;
            // 
            // dgvButtonImport
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvButtonImport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvButtonImport.Frozen = true;
            this.dgvButtonImport.HeaderText = "Nhập SP";
            this.dgvButtonImport.Name = "dgvButtonImport";
            this.dgvButtonImport.ReadOnly = true;
            this.dgvButtonImport.Text = "Nhập SP";
            this.dgvButtonImport.UseColumnTextForButtonValue = true;
            this.dgvButtonImport.Width = 80;
            // 
            // dgvButtonView
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvButtonView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvButtonView.Frozen = true;
            this.dgvButtonView.HeaderText = "Xem";
            this.dgvButtonView.Name = "dgvButtonView";
            this.dgvButtonView.ReadOnly = true;
            this.dgvButtonView.Text = "Xem";
            this.dgvButtonView.UseColumnTextForButtonValue = true;
            this.dgvButtonView.Width = 35;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.FillWeight = 60.9137F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Mã phiếu nhập tồn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // NL
            // 
            this.NL.DataPropertyName = "DateCreate";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            dataGridViewCellStyle4.NullValue = null;
            this.NL.DefaultCellStyle = dataGridViewCellStyle4;
            this.NL.FillWeight = 113.0288F;
            this.NL.Frozen = true;
            this.NL.HeaderText = "Ngày lập";
            this.NL.Name = "NL";
            this.NL.ReadOnly = true;
            this.NL.Width = 85;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Creator";
            this.Column3.FillWeight = 113.0288F;
            this.Column3.HeaderText = "Người lập";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 170;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TotalAmountWithVat";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column2.HeaderText = "Tông tiền";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Status";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Note";
            this.Column4.FillWeight = 113.0288F;
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 280;
            // 
            // gdvButtonDelete
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gdvButtonDelete.DefaultCellStyle = dataGridViewCellStyle7;
            this.gdvButtonDelete.HeaderText = "Xóa";
            this.gdvButtonDelete.Name = "gdvButtonDelete";
            this.gdvButtonDelete.ReadOnly = true;
            this.gdvButtonDelete.Text = "Xóa";
            this.gdvButtonDelete.UseColumnTextForButtonValue = true;
            this.gdvButtonDelete.Width = 35;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearch.BackgroundImage")));
            this.tbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSearch.ForeColor = System.Drawing.Color.DarkMagenta;
            this.tbSearch.Icon = ((System.Drawing.Image)(resources.GetObject("tbSearch.Icon")));
            this.tbSearch.Location = new System.Drawing.Point(353, 256);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(250, 34);
            this.tbSearch.TabIndex = 140;
            this.tbSearch.text = "";
            this.tbSearch.OnTextChange += new System.EventHandler(this.tbSearch_OnTextChange);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            // 
            // lbNotification
            // 
            this.lbNotification.AutoSize = true;
            this.lbNotification.BackColor = System.Drawing.Color.Transparent;
            this.lbNotification.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification.ForeColor = System.Drawing.Color.Red;
            this.lbNotification.Location = new System.Drawing.Point(350, 223);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(66, 15);
            this.lbNotification.TabIndex = 141;
            this.lbNotification.Text = "Thông báo";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 144;
            this.label2.Text = "Nhập tồn";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbPNThangNay);
            this.bunifuGradientPanel1.Controls.Add(this.label11);
            this.bunifuGradientPanel1.Controls.Add(this.lbPNThangTruoc);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.PaleTurquoise;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Aquamarine;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(801, 61);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(244, 107);
            this.bunifuGradientPanel1.TabIndex = 143;
            // 
            // lbPNThangNay
            // 
            this.lbPNThangNay.AutoSize = true;
            this.lbPNThangNay.BackColor = System.Drawing.Color.Transparent;
            this.lbPNThangNay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPNThangNay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPNThangNay.Location = new System.Drawing.Point(3, 74);
            this.lbPNThangNay.Name = "lbPNThangNay";
            this.lbPNThangNay.Size = new System.Drawing.Size(85, 18);
            this.lbPNThangNay.TabIndex = 2;
            this.lbPNThangNay.Text = "Tháng này:";
            this.lbPNThangNay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(3, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "PHIẾU NHẬP TỒN";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPNThangTruoc
            // 
            this.lbPNThangTruoc.AutoSize = true;
            this.lbPNThangTruoc.BackColor = System.Drawing.Color.Transparent;
            this.lbPNThangTruoc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPNThangTruoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPNThangTruoc.Location = new System.Drawing.Point(3, 51);
            this.lbPNThangTruoc.Name = "lbPNThangTruoc";
            this.lbPNThangTruoc.Size = new System.Drawing.Size(102, 18);
            this.lbPNThangTruoc.TabIndex = 1;
            this.lbPNThangTruoc.Text = "Tháng trước:";
            this.lbPNThangTruoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.lbTCThangNay);
            this.bunifuGradientPanel3.Controls.Add(this.lbDoanhSo);
            this.bunifuGradientPanel3.Controls.Add(this.lbTCThangTruoc);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(530, 61);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(244, 107);
            this.bunifuGradientPanel3.TabIndex = 142;
            // 
            // lbTCThangNay
            // 
            this.lbTCThangNay.AutoSize = true;
            this.lbTCThangNay.BackColor = System.Drawing.Color.Transparent;
            this.lbTCThangNay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTCThangNay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTCThangNay.Location = new System.Drawing.Point(3, 74);
            this.lbTCThangNay.Name = "lbTCThangNay";
            this.lbTCThangNay.Size = new System.Drawing.Size(85, 18);
            this.lbTCThangNay.TabIndex = 2;
            this.lbTCThangNay.Text = "Tháng này:";
            this.lbTCThangNay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbDoanhSo
            // 
            this.lbDoanhSo.AutoSize = true;
            this.lbDoanhSo.BackColor = System.Drawing.Color.Transparent;
            this.lbDoanhSo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhSo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDoanhSo.Location = new System.Drawing.Point(3, 16);
            this.lbDoanhSo.Name = "lbDoanhSo";
            this.lbDoanhSo.Size = new System.Drawing.Size(174, 18);
            this.lbDoanhSo.TabIndex = 0;
            this.lbDoanhSo.Text = "TỔNG TIỀN NHẬP TỒN";
            this.lbDoanhSo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTCThangTruoc
            // 
            this.lbTCThangTruoc.AutoSize = true;
            this.lbTCThangTruoc.BackColor = System.Drawing.Color.Transparent;
            this.lbTCThangTruoc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTCThangTruoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTCThangTruoc.Location = new System.Drawing.Point(3, 51);
            this.lbTCThangTruoc.Name = "lbTCThangTruoc";
            this.lbTCThangTruoc.Size = new System.Drawing.Size(102, 18);
            this.lbTCThangTruoc.TabIndex = 1;
            this.lbTCThangTruoc.Text = "Tháng trước:";
            this.lbTCThangTruoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmImportInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.lbNotification);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.dgvListInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmImportInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImportInventory";
            this.Load += new System.EventHandler(this.FrmImportInventory_Load);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInvoice)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuFlatButton btCreateInvoice;
        private System.Windows.Forms.RichTextBox rtbNote;
        private System.Windows.Forms.Label lbIdImportBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCreator;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.DataGridView dgvListInvoice;
        private Bunifu.Framework.UI.BunifuTextbox tbSearch;
        private System.Windows.Forms.Label lbNotification;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn dgvButtonImport;
        private System.Windows.Forms.DataGridViewButtonColumn dgvButtonView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn gdvButtonDelete;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbPNThangNay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbPNThangTruoc;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Label lbTCThangNay;
        private System.Windows.Forms.Label lbDoanhSo;
        private System.Windows.Forms.Label lbTCThangTruoc;
    }
}