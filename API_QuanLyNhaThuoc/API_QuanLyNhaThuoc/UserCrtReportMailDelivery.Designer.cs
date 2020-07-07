namespace API_QuanLyNhaThuoc
{
    partial class UserCrtReportMailDelivery
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCrtReportMailDelivery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateTimeTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvListMailDelivery = new System.Windows.Forms.DataGridView();
            this.btExportToExcel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbTotalEmailDeliveryThisMonth = new System.Windows.Forms.Label();
            this.lbDoanhSo = new System.Windows.Forms.Label();
            this.lbTotalEmailDeliveryLastMonth = new System.Windows.Forms.Label();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbTotalEmailDeliveryThisDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalBillThisDay = new System.Windows.Forms.Label();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMailDelivery)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 101;
            this.label2.Text = "Báo cáo gửi mail";
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.BackColor = System.Drawing.SystemColors.Control;
            this.dateTimeFrom.BorderRadius = 7;
            this.dateTimeFrom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.ForeColor = System.Drawing.Color.Black;
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeFrom.FormatCustom = "dd/MM/yyyy";
            this.dateTimeFrom.Location = new System.Drawing.Point(282, 178);
            this.dateTimeFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(353, 46);
            this.dateTimeFrom.TabIndex = 100;
            this.dateTimeFrom.Value = new System.DateTime(2020, 6, 20, 2, 3, 16, 869);
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.BackColor = System.Drawing.SystemColors.Control;
            this.dateTimeTo.BorderRadius = 7;
            this.dateTimeTo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.ForeColor = System.Drawing.Color.Black;
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeTo.FormatCustom = "dd/MM/yyyy";
            this.dateTimeTo.Location = new System.Drawing.Point(282, 234);
            this.dateTimeTo.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(353, 45);
            this.dateTimeTo.TabIndex = 99;
            this.dateTimeTo.Value = new System.DateTime(2020, 6, 20, 2, 3, 14, 473);
            // 
            // btFilter
            // 
            this.btFilter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btFilter.BackColor = System.Drawing.SystemColors.Control;
            this.btFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFilter.BorderRadius = 7;
            this.btFilter.ButtonText = "Tìm kiếm";
            this.btFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btFilter.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_search_100;
            this.btFilter.Iconimage_right = null;
            this.btFilter.Iconimage_right_Selected = null;
            this.btFilter.Iconimage_Selected = null;
            this.btFilter.IconMarginLeft = 0;
            this.btFilter.IconMarginRight = 0;
            this.btFilter.IconRightVisible = true;
            this.btFilter.IconRightZoom = 0D;
            this.btFilter.IconVisible = true;
            this.btFilter.IconZoom = 90D;
            this.btFilter.IsTab = false;
            this.btFilter.Location = new System.Drawing.Point(653, 178);
            this.btFilter.Name = "btFilter";
            this.btFilter.Normalcolor = System.Drawing.SystemColors.Control;
            this.btFilter.OnHovercolor = System.Drawing.Color.Gray;
            this.btFilter.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btFilter.selected = false;
            this.btFilter.Size = new System.Drawing.Size(144, 46);
            this.btFilter.TabIndex = 98;
            this.btFilter.Text = "Tìm kiếm";
            this.btFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btFilter.Textcolor = System.Drawing.Color.Black;
            this.btFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // dgvListMailDelivery
            // 
            this.dgvListMailDelivery.AllowUserToDeleteRows = false;
            this.dgvListMailDelivery.AllowUserToResizeColumns = false;
            this.dgvListMailDelivery.AllowUserToResizeRows = false;
            this.dgvListMailDelivery.BackgroundColor = System.Drawing.Color.White;
            this.dgvListMailDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListMailDelivery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListMailDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListMailDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMailDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvListMailDelivery.EnableHeadersVisualStyles = false;
            this.dgvListMailDelivery.Location = new System.Drawing.Point(11, 286);
            this.dgvListMailDelivery.Name = "dgvListMailDelivery";
            this.dgvListMailDelivery.ReadOnly = true;
            this.dgvListMailDelivery.RowHeadersVisible = false;
            this.dgvListMailDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListMailDelivery.Size = new System.Drawing.Size(1057, 322);
            this.dgvListMailDelivery.TabIndex = 97;
            this.dgvListMailDelivery.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvListMailDelivery_RowsAdded);
            // 
            // btExportToExcel
            // 
            this.btExportToExcel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btExportToExcel.BackColor = System.Drawing.SystemColors.Control;
            this.btExportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btExportToExcel.BorderRadius = 7;
            this.btExportToExcel.ButtonText = "Xuất Excel";
            this.btExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExportToExcel.DisabledColor = System.Drawing.Color.Gray;
            this.btExportToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportToExcel.Iconcolor = System.Drawing.Color.Transparent;
            this.btExportToExcel.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_microsoft_excel_100;
            this.btExportToExcel.Iconimage_right = null;
            this.btExportToExcel.Iconimage_right_Selected = null;
            this.btExportToExcel.Iconimage_Selected = null;
            this.btExportToExcel.IconMarginLeft = 0;
            this.btExportToExcel.IconMarginRight = 0;
            this.btExportToExcel.IconRightVisible = true;
            this.btExportToExcel.IconRightZoom = 0D;
            this.btExportToExcel.IconVisible = true;
            this.btExportToExcel.IconZoom = 90D;
            this.btExportToExcel.IsTab = false;
            this.btExportToExcel.Location = new System.Drawing.Point(653, 234);
            this.btExportToExcel.Name = "btExportToExcel";
            this.btExportToExcel.Normalcolor = System.Drawing.SystemColors.Control;
            this.btExportToExcel.OnHovercolor = System.Drawing.Color.Gray;
            this.btExportToExcel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btExportToExcel.selected = false;
            this.btExportToExcel.Size = new System.Drawing.Size(144, 46);
            this.btExportToExcel.TabIndex = 96;
            this.btExportToExcel.Text = "Xuất Excel";
            this.btExportToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btExportToExcel.Textcolor = System.Drawing.Color.Black;
            this.btExportToExcel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExportToExcel.Click += new System.EventHandler(this.btExportToExcel_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbTotalEmailDeliveryThisMonth);
            this.bunifuGradientPanel1.Controls.Add(this.lbDoanhSo);
            this.bunifuGradientPanel1.Controls.Add(this.lbTotalEmailDeliveryLastMonth);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(282, 54);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(244, 107);
            this.bunifuGradientPanel1.TabIndex = 94;
            // 
            // lbTotalEmailDeliveryThisMonth
            // 
            this.lbTotalEmailDeliveryThisMonth.AutoSize = true;
            this.lbTotalEmailDeliveryThisMonth.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalEmailDeliveryThisMonth.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalEmailDeliveryThisMonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalEmailDeliveryThisMonth.Location = new System.Drawing.Point(3, 74);
            this.lbTotalEmailDeliveryThisMonth.Name = "lbTotalEmailDeliveryThisMonth";
            this.lbTotalEmailDeliveryThisMonth.Size = new System.Drawing.Size(85, 18);
            this.lbTotalEmailDeliveryThisMonth.TabIndex = 2;
            this.lbTotalEmailDeliveryThisMonth.Text = "Tháng này:";
            this.lbTotalEmailDeliveryThisMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbDoanhSo
            // 
            this.lbDoanhSo.AutoSize = true;
            this.lbDoanhSo.BackColor = System.Drawing.Color.Transparent;
            this.lbDoanhSo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhSo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDoanhSo.Location = new System.Drawing.Point(3, 16);
            this.lbDoanhSo.Name = "lbDoanhSo";
            this.lbDoanhSo.Size = new System.Drawing.Size(133, 18);
            this.lbDoanhSo.TabIndex = 0;
            this.lbDoanhSo.Text = "BÁO CÁO THÁNG";
            this.lbDoanhSo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalEmailDeliveryLastMonth
            // 
            this.lbTotalEmailDeliveryLastMonth.AutoSize = true;
            this.lbTotalEmailDeliveryLastMonth.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalEmailDeliveryLastMonth.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalEmailDeliveryLastMonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalEmailDeliveryLastMonth.Location = new System.Drawing.Point(3, 51);
            this.lbTotalEmailDeliveryLastMonth.Name = "lbTotalEmailDeliveryLastMonth";
            this.lbTotalEmailDeliveryLastMonth.Size = new System.Drawing.Size(102, 18);
            this.lbTotalEmailDeliveryLastMonth.TabIndex = 1;
            this.lbTotalEmailDeliveryLastMonth.Text = "Tháng trước:";
            this.lbTotalEmailDeliveryLastMonth.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.lbTotalEmailDeliveryThisDay);
            this.bunifuGradientPanel3.Controls.Add(this.label1);
            this.bunifuGradientPanel3.Controls.Add(this.lbTotalBillThisDay);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(553, 54);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(244, 107);
            this.bunifuGradientPanel3.TabIndex = 102;
            // 
            // lbTotalEmailDeliveryThisDay
            // 
            this.lbTotalEmailDeliveryThisDay.AutoSize = true;
            this.lbTotalEmailDeliveryThisDay.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalEmailDeliveryThisDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalEmailDeliveryThisDay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalEmailDeliveryThisDay.Location = new System.Drawing.Point(3, 74);
            this.lbTotalEmailDeliveryThisDay.Name = "lbTotalEmailDeliveryThisDay";
            this.lbTotalEmailDeliveryThisDay.Size = new System.Drawing.Size(66, 18);
            this.lbTotalEmailDeliveryThisDay.TabIndex = 2;
            this.lbTotalEmailDeliveryThisDay.Text = "Lần gửi:";
            this.lbTotalEmailDeliveryThisDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO TRONG NGÀY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalBillThisDay
            // 
            this.lbTotalBillThisDay.AutoSize = true;
            this.lbTotalBillThisDay.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalBillThisDay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBillThisDay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalBillThisDay.Location = new System.Drawing.Point(3, 51);
            this.lbTotalBillThisDay.Name = "lbTotalBillThisDay";
            this.lbTotalBillThisDay.Size = new System.Drawing.Size(73, 18);
            this.lbTotalBillThisDay.TabIndex = 1;
            this.lbTotalBillThisDay.Text = "Hóa đơn:";
            this.lbTotalBillThisDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Column1.DataPropertyName = "MailTo";
            this.Column1.HeaderText = "Người nhận";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "BuyerName";
            this.Column2.HeaderText = "Tên người mua";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 270;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "InvoiceNumber";
            this.Column3.HeaderText = "Số hóa đơn";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SendDate";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm";
            dataGridViewCellStyle2.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Ngày gửi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Status";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DetailError";
            this.Column6.HeaderText = "Chi tiết lỗi";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 285;
            // 
            // UserCrtReportMailDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.btFilter);
            this.Controls.Add(this.dgvListMailDelivery);
            this.Controls.Add(this.btExportToExcel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "UserCrtReportMailDelivery";
            this.Size = new System.Drawing.Size(1080, 660);
            this.Load += new System.EventHandler(this.UserCrtReportMailDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMailDelivery)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimeFrom;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimeTo;
        private Bunifu.Framework.UI.BunifuFlatButton btFilter;
        private System.Windows.Forms.DataGridView dgvListMailDelivery;
        private Bunifu.Framework.UI.BunifuFlatButton btExportToExcel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbTotalEmailDeliveryThisMonth;
        private System.Windows.Forms.Label lbDoanhSo;
        private System.Windows.Forms.Label lbTotalEmailDeliveryLastMonth;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Label lbTotalEmailDeliveryThisDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalBillThisDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
