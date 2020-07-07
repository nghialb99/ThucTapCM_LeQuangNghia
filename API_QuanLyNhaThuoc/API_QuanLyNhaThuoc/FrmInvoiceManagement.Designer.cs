namespace API_QuanLyNhaThuoc
{
    partial class FrmInvoiceManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dgvListInvoice = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSellerTaxcode = new System.Windows.Forms.TextBox();
            this.tbCreator = new System.Windows.Forms.TextBox();
            this.tbBuyerEmail = new System.Windows.Forms.TextBox();
            this.tbBuyerName = new System.Windows.Forms.TextBox();
            this.tbInvoiceId = new System.Windows.Forms.TextBox();
            this.tbBuyerPhone = new System.Windows.Forms.TextBox();
            this.tbBuyerCode = new System.Windows.Forms.TextBox();
            this.cbInvoiceStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btSendMail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btClear = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvButtonView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInvoice)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CustomFormat = "dd/MM/yyyy";
            this.dateTimeFrom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.Location = new System.Drawing.Point(136, 25);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(369, 21);
            this.dateTimeFrom.TabIndex = 50;
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "dd/MM/yyyy";
            this.dateTimeTo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTo.Location = new System.Drawing.Point(671, 25);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(369, 21);
            this.dateTimeTo.TabIndex = 49;
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
            this.Column1,
            this.NL,
            this.Column3,
            this.Column8,
            this.Column6,
            this.Column2,
            this.Column5,
            this.Column4,
            this.dgvButtonView,
            this.dgvButtonDelete,
            this.Column9});
            this.dgvListInvoice.EnableHeadersVisualStyles = false;
            this.dgvListInvoice.Location = new System.Drawing.Point(12, 338);
            this.dgvListInvoice.Name = "dgvListInvoice";
            this.dgvListInvoice.ReadOnly = true;
            this.dgvListInvoice.RowHeadersVisible = false;
            this.dgvListInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListInvoice.Size = new System.Drawing.Size(1056, 300);
            this.dgvListInvoice.TabIndex = 64;
            this.dgvListInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListInvoice_CellClick);
            this.dgvListInvoice.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvListInvoice_RowsAdded);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.tbSellerTaxcode);
            this.groupBox2.Controls.Add(this.tbCreator);
            this.groupBox2.Controls.Add(this.tbBuyerEmail);
            this.groupBox2.Controls.Add(this.tbBuyerName);
            this.groupBox2.Controls.Add(this.tbInvoiceId);
            this.groupBox2.Controls.Add(this.tbBuyerPhone);
            this.groupBox2.Controls.Add(this.tbBuyerCode);
            this.groupBox2.Controls.Add(this.cbInvoiceStatus);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimeTo);
            this.groupBox2.Controls.Add(this.dateTimeFrom);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Teal;
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1056, 228);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // tbSellerTaxcode
            // 
            this.tbSellerTaxcode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellerTaxcode.Location = new System.Drawing.Point(136, 195);
            this.tbSellerTaxcode.Name = "tbSellerTaxcode";
            this.tbSellerTaxcode.ReadOnly = true;
            this.tbSellerTaxcode.Size = new System.Drawing.Size(369, 21);
            this.tbSellerTaxcode.TabIndex = 63;
            // 
            // tbCreator
            // 
            this.tbCreator.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCreator.Location = new System.Drawing.Point(671, 195);
            this.tbCreator.Name = "tbCreator";
            this.tbCreator.Size = new System.Drawing.Size(369, 21);
            this.tbCreator.TabIndex = 62;
            // 
            // tbBuyerEmail
            // 
            this.tbBuyerEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyerEmail.Location = new System.Drawing.Point(671, 153);
            this.tbBuyerEmail.Name = "tbBuyerEmail";
            this.tbBuyerEmail.Size = new System.Drawing.Size(369, 21);
            this.tbBuyerEmail.TabIndex = 61;
            // 
            // tbBuyerName
            // 
            this.tbBuyerName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyerName.Location = new System.Drawing.Point(671, 111);
            this.tbBuyerName.Name = "tbBuyerName";
            this.tbBuyerName.Size = new System.Drawing.Size(369, 21);
            this.tbBuyerName.TabIndex = 60;
            // 
            // tbInvoiceId
            // 
            this.tbInvoiceId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInvoiceId.Location = new System.Drawing.Point(671, 69);
            this.tbInvoiceId.Name = "tbInvoiceId";
            this.tbInvoiceId.Size = new System.Drawing.Size(369, 21);
            this.tbInvoiceId.TabIndex = 59;
            // 
            // tbBuyerPhone
            // 
            this.tbBuyerPhone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyerPhone.Location = new System.Drawing.Point(136, 153);
            this.tbBuyerPhone.Name = "tbBuyerPhone";
            this.tbBuyerPhone.Size = new System.Drawing.Size(369, 21);
            this.tbBuyerPhone.TabIndex = 58;
            // 
            // tbBuyerCode
            // 
            this.tbBuyerCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyerCode.Location = new System.Drawing.Point(136, 111);
            this.tbBuyerCode.Name = "tbBuyerCode";
            this.tbBuyerCode.Size = new System.Drawing.Size(369, 21);
            this.tbBuyerCode.TabIndex = 57;
            // 
            // cbInvoiceStatus
            // 
            this.cbInvoiceStatus.DisplayMember = "1";
            this.cbInvoiceStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInvoiceStatus.FormattingEnabled = true;
            this.cbInvoiceStatus.Location = new System.Drawing.Point(136, 69);
            this.cbInvoiceStatus.Name = "cbInvoiceStatus";
            this.cbInvoiceStatus.Size = new System.Drawing.Size(369, 23);
            this.cbInvoiceStatus.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(6, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "Mã số thuế (NCC)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "Số điện thoại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(568, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 53;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 52;
            this.label1.Text = "Mã người mua";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "Trạng thái hóa đơn";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(568, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "Đến ngày lập";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(568, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "Tên người mua";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(568, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "Mã hóa đơn";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(6, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 15);
            this.label16.TabIndex = 27;
            this.label16.Text = "Từ ngày lập";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(568, 199);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 15);
            this.label18.TabIndex = 26;
            this.label18.Text = "Người lập";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btSearch
            // 
            this.btSearch.Activecolor = System.Drawing.Color.Gray;
            this.btSearch.BackColor = System.Drawing.Color.Silver;
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSearch.BorderRadius = 7;
            this.btSearch.ButtonText = "Tìm kiếm";
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btSearch.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_search_100;
            this.btSearch.Iconimage_right = null;
            this.btSearch.Iconimage_right_Selected = null;
            this.btSearch.Iconimage_Selected = null;
            this.btSearch.IconMarginLeft = 0;
            this.btSearch.IconMarginRight = 0;
            this.btSearch.IconRightVisible = true;
            this.btSearch.IconRightZoom = 0D;
            this.btSearch.IconVisible = true;
            this.btSearch.IconZoom = 90D;
            this.btSearch.IsTab = false;
            this.btSearch.Location = new System.Drawing.Point(347, 282);
            this.btSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Normalcolor = System.Drawing.Color.Silver;
            this.btSearch.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btSearch.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btSearch.selected = false;
            this.btSearch.Size = new System.Drawing.Size(124, 48);
            this.btSearch.TabIndex = 112;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSearch.Textcolor = System.Drawing.Color.Black;
            this.btSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btSendMail
            // 
            this.btSendMail.Activecolor = System.Drawing.Color.Gray;
            this.btSendMail.BackColor = System.Drawing.Color.Silver;
            this.btSendMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSendMail.BorderRadius = 7;
            this.btSendMail.ButtonText = "Gửi mail";
            this.btSendMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSendMail.DisabledColor = System.Drawing.Color.Gray;
            this.btSendMail.ForeColor = System.Drawing.Color.Black;
            this.btSendMail.Iconcolor = System.Drawing.Color.Transparent;
            this.btSendMail.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_save_close_100;
            this.btSendMail.Iconimage_right = null;
            this.btSendMail.Iconimage_right_Selected = null;
            this.btSendMail.Iconimage_Selected = null;
            this.btSendMail.IconMarginLeft = 0;
            this.btSendMail.IconMarginRight = 0;
            this.btSendMail.IconRightVisible = true;
            this.btSendMail.IconRightZoom = 0D;
            this.btSendMail.IconVisible = true;
            this.btSendMail.IconZoom = 90D;
            this.btSendMail.IsTab = false;
            this.btSendMail.Location = new System.Drawing.Point(487, 282);
            this.btSendMail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btSendMail.Name = "btSendMail";
            this.btSendMail.Normalcolor = System.Drawing.Color.Silver;
            this.btSendMail.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btSendMail.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btSendMail.selected = false;
            this.btSendMail.Size = new System.Drawing.Size(124, 48);
            this.btSendMail.TabIndex = 111;
            this.btSendMail.Text = "Gửi mail";
            this.btSendMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSendMail.Textcolor = System.Drawing.Color.Black;
            this.btSendMail.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSendMail.Click += new System.EventHandler(this.btSendMail_Click);
            // 
            // btClear
            // 
            this.btClear.Activecolor = System.Drawing.Color.Gray;
            this.btClear.BackColor = System.Drawing.Color.Silver;
            this.btClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClear.BorderRadius = 7;
            this.btClear.ButtonText = "Làm sạch";
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.DisabledColor = System.Drawing.Color.Gray;
            this.btClear.ForeColor = System.Drawing.Color.Black;
            this.btClear.Iconcolor = System.Drawing.Color.Transparent;
            this.btClear.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_clear_100;
            this.btClear.Iconimage_right = null;
            this.btClear.Iconimage_right_Selected = null;
            this.btClear.Iconimage_Selected = null;
            this.btClear.IconMarginLeft = 0;
            this.btClear.IconMarginRight = 0;
            this.btClear.IconRightVisible = true;
            this.btClear.IconRightZoom = 0D;
            this.btClear.IconVisible = true;
            this.btClear.IconZoom = 90D;
            this.btClear.IsTab = false;
            this.btClear.Location = new System.Drawing.Point(627, 282);
            this.btClear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btClear.Name = "btClear";
            this.btClear.Normalcolor = System.Drawing.Color.Silver;
            this.btClear.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btClear.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btClear.selected = false;
            this.btClear.Size = new System.Drawing.Size(124, 48);
            this.btClear.TabIndex = 110;
            this.btClear.Text = "Làm sạch";
            this.btClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btClear.Textcolor = System.Drawing.Color.Black;
            this.btClear.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(7, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 19);
            this.label6.TabIndex = 113;
            this.label6.Text = "Quản lý hóa đơn";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "STT";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 30;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "InvoiceNumber";
            this.Column1.FillWeight = 60.9137F;
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 90;
            // 
            // NL
            // 
            this.NL.DataPropertyName = "InvoiceIssuedDate";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.NL.DefaultCellStyle = dataGridViewCellStyle2;
            this.NL.FillWeight = 113.0288F;
            this.NL.HeaderText = "Ngày lập";
            this.NL.Name = "NL";
            this.NL.ReadOnly = true;
            this.NL.Width = 85;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "UserName";
            this.Column3.FillWeight = 113.0288F;
            this.Column3.HeaderText = "Người lập";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 135;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "BuyerLegalName";
            this.Column8.HeaderText = "Tên người mua";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Discount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column6.HeaderText = "Giảm giá (%)";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TotalAmountAfterDiscount";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Tông tiền";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Status";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "InvoiceNote";
            this.Column4.FillWeight = 113.0288F;
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 245;
            // 
            // dgvButtonView
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvButtonView.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvButtonView.HeaderText = "Xem";
            this.dgvButtonView.Name = "dgvButtonView";
            this.dgvButtonView.ReadOnly = true;
            this.dgvButtonView.Text = "Xem";
            this.dgvButtonView.UseColumnTextForButtonValue = true;
            this.dgvButtonView.Width = 35;
            // 
            // dgvButtonDelete
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red;
            this.dgvButtonDelete.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvButtonDelete.HeaderText = "Xóa";
            this.dgvButtonDelete.Name = "dgvButtonDelete";
            this.dgvButtonDelete.ReadOnly = true;
            this.dgvButtonDelete.Text = "Xóa";
            this.dgvButtonDelete.UseColumnTextForButtonValue = true;
            this.dgvButtonDelete.Width = 35;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Id";
            this.Column9.HeaderText = "invoiceId";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // FrmInvoiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 646);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btSendMail);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvListInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInvoiceManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInvoiceManagement";
            this.Load += new System.EventHandler(this.FrmInvoiceManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInvoice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.DataGridView dgvListInvoice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbSellerTaxcode;
        private System.Windows.Forms.TextBox tbCreator;
        private System.Windows.Forms.TextBox tbBuyerEmail;
        private System.Windows.Forms.TextBox tbBuyerName;
        private System.Windows.Forms.TextBox tbInvoiceId;
        private System.Windows.Forms.TextBox tbBuyerPhone;
        private System.Windows.Forms.TextBox tbBuyerCode;
        private System.Windows.Forms.ComboBox cbInvoiceStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btSendMail;
        private Bunifu.Framework.UI.BunifuFlatButton btClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn dgvButtonView;
        private System.Windows.Forms.DataGridViewButtonColumn dgvButtonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}