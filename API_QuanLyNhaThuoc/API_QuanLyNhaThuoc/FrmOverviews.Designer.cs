namespace API_QuanLyNhaThuoc
{
    partial class FrmOverviews
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOverviews));
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvTopSP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbSPHetHanThangToi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSPHetHanThangNay = new System.Windows.Forms.Label();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbDSHomNay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHDHomNay = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tbHDThangNay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbHDThangTruoc = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbDSThangNay = new System.Windows.Forms.Label();
            this.lbDoanhSo = new System.Windows.Forms.Label();
            this.lbDSThangTruoc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.bunifuGradientPanel4.SuspendLayout();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(216, 603);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Biểu đồ doanh số năm";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(695, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(315, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "TOP SẢN PHẨM ĐƯỢC BÁN CHẠY NHẤT TRONG THÁNG";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalAmount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTotalAmount.Location = new System.Drawing.Point(226, 143);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(28, 15);
            this.lbTotalAmount.TabIndex = 18;
            this.lbTotalAmount.Text = "000";
            this.lbTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(9, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "DOANH SỐ BÁN HÀNG THÁNG NÀY  →";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTopSP
            // 
            this.dgvTopSP.AllowUserToAddRows = false;
            this.dgvTopSP.AllowUserToDeleteRows = false;
            this.dgvTopSP.AllowUserToResizeColumns = false;
            this.dgvTopSP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvTopSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTopSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTopSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvTopSP.EnableHeadersVisualStyles = false;
            this.dgvTopSP.Location = new System.Drawing.Point(698, 184);
            this.dgvTopSP.Name = "dgvTopSP";
            this.dgvTopSP.ReadOnly = true;
            this.dgvTopSP.RowHeadersVisible = false;
            this.dgvTopSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopSP.Size = new System.Drawing.Size(374, 398);
            this.dgvTopSP.TabIndex = 20;
            this.dgvTopSP.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTopSP_RowsAdded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(14, 184);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh số";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(661, 398);
            this.chart1.TabIndex = 22;
            this.chart1.Text = "chart1";
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.lbSPHetHanThangToi);
            this.bunifuGradientPanel4.Controls.Add(this.label9);
            this.bunifuGradientPanel4.Controls.Add(this.lbSPHetHanThangNay);
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(823, 12);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(244, 107);
            this.bunifuGradientPanel4.TabIndex = 87;
            // 
            // lbSPHetHanThangToi
            // 
            this.lbSPHetHanThangToi.AutoSize = true;
            this.lbSPHetHanThangToi.BackColor = System.Drawing.Color.Transparent;
            this.lbSPHetHanThangToi.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSPHetHanThangToi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSPHetHanThangToi.Location = new System.Drawing.Point(3, 74);
            this.lbSPHetHanThangToi.Name = "lbSPHetHanThangToi";
            this.lbSPHetHanThangToi.Size = new System.Drawing.Size(81, 18);
            this.lbSPHetHanThangToi.TabIndex = 2;
            this.lbSPHetHanThangToi.Text = "Tháng tới:";
            this.lbSPHetHanThangToi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(3, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "THUỐC SẮP HẾT HẠN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSPHetHanThangNay
            // 
            this.lbSPHetHanThangNay.AutoSize = true;
            this.lbSPHetHanThangNay.BackColor = System.Drawing.Color.Transparent;
            this.lbSPHetHanThangNay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSPHetHanThangNay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSPHetHanThangNay.Location = new System.Drawing.Point(3, 51);
            this.lbSPHetHanThangNay.Name = "lbSPHetHanThangNay";
            this.lbSPHetHanThangNay.Size = new System.Drawing.Size(85, 18);
            this.lbSPHetHanThangNay.TabIndex = 1;
            this.lbSPHetHanThangNay.Text = "Tháng này:";
            this.lbSPHetHanThangNay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.lbDSHomNay);
            this.bunifuGradientPanel3.Controls.Add(this.label2);
            this.bunifuGradientPanel3.Controls.Add(this.lbHDHomNay);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(552, 12);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(244, 107);
            this.bunifuGradientPanel3.TabIndex = 88;
            // 
            // lbDSHomNay
            // 
            this.lbDSHomNay.AutoSize = true;
            this.lbDSHomNay.BackColor = System.Drawing.Color.Transparent;
            this.lbDSHomNay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSHomNay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDSHomNay.Location = new System.Drawing.Point(3, 74);
            this.lbDSHomNay.Name = "lbDSHomNay";
            this.lbDSHomNay.Size = new System.Drawing.Size(79, 18);
            this.lbDSHomNay.TabIndex = 2;
            this.lbDSHomNay.Text = "Doanh số:";
            this.lbDSHomNay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "BÁO CÁO TRONG NGÀY";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHDHomNay
            // 
            this.lbHDHomNay.AutoSize = true;
            this.lbHDHomNay.BackColor = System.Drawing.Color.Transparent;
            this.lbHDHomNay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHDHomNay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbHDHomNay.Location = new System.Drawing.Point(3, 51);
            this.lbHDHomNay.Name = "lbHDHomNay";
            this.lbHDHomNay.Size = new System.Drawing.Size(73, 18);
            this.lbHDHomNay.TabIndex = 1;
            this.lbHDHomNay.Text = "Hóa đơn:";
            this.lbHDHomNay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.tbHDThangNay);
            this.bunifuGradientPanel2.Controls.Add(this.label6);
            this.bunifuGradientPanel2.Controls.Add(this.lbHDThangTruoc);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.PaleTurquoise;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Aquamarine;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(281, 12);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(244, 107);
            this.bunifuGradientPanel2.TabIndex = 89;
            // 
            // tbHDThangNay
            // 
            this.tbHDThangNay.AutoSize = true;
            this.tbHDThangNay.BackColor = System.Drawing.Color.Transparent;
            this.tbHDThangNay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHDThangNay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbHDThangNay.Location = new System.Drawing.Point(3, 74);
            this.tbHDThangNay.Name = "tbHDThangNay";
            this.tbHDThangNay.Size = new System.Drawing.Size(85, 18);
            this.tbHDThangNay.TabIndex = 2;
            this.tbHDThangNay.Text = "Tháng này:";
            this.tbHDThangNay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "HÓA ĐƠN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbHDThangTruoc
            // 
            this.lbHDThangTruoc.AutoSize = true;
            this.lbHDThangTruoc.BackColor = System.Drawing.Color.Transparent;
            this.lbHDThangTruoc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHDThangTruoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbHDThangTruoc.Location = new System.Drawing.Point(3, 51);
            this.lbHDThangTruoc.Name = "lbHDThangTruoc";
            this.lbHDThangTruoc.Size = new System.Drawing.Size(102, 18);
            this.lbHDThangTruoc.TabIndex = 1;
            this.lbHDThangTruoc.Text = "Tháng trước:";
            this.lbHDThangTruoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lbDSThangNay);
            this.bunifuGradientPanel1.Controls.Add(this.lbDoanhSo);
            this.bunifuGradientPanel1.Controls.Add(this.lbDSThangTruoc);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(10, 12);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(244, 107);
            this.bunifuGradientPanel1.TabIndex = 86;
            // 
            // lbDSThangNay
            // 
            this.lbDSThangNay.AutoSize = true;
            this.lbDSThangNay.BackColor = System.Drawing.Color.Transparent;
            this.lbDSThangNay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSThangNay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDSThangNay.Location = new System.Drawing.Point(5, 74);
            this.lbDSThangNay.Name = "lbDSThangNay";
            this.lbDSThangNay.Size = new System.Drawing.Size(85, 18);
            this.lbDSThangNay.TabIndex = 2;
            this.lbDSThangNay.Text = "Tháng này:";
            this.lbDSThangNay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbDoanhSo
            // 
            this.lbDoanhSo.AutoSize = true;
            this.lbDoanhSo.BackColor = System.Drawing.Color.Transparent;
            this.lbDoanhSo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoanhSo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDoanhSo.Location = new System.Drawing.Point(5, 16);
            this.lbDoanhSo.Name = "lbDoanhSo";
            this.lbDoanhSo.Size = new System.Drawing.Size(88, 18);
            this.lbDoanhSo.TabIndex = 0;
            this.lbDoanhSo.Text = "DOANH SỐ";
            this.lbDoanhSo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbDSThangTruoc
            // 
            this.lbDSThangTruoc.AutoSize = true;
            this.lbDSThangTruoc.BackColor = System.Drawing.Color.Transparent;
            this.lbDSThangTruoc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSThangTruoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDSThangTruoc.Location = new System.Drawing.Point(5, 51);
            this.lbDSThangTruoc.Name = "lbDSThangTruoc";
            this.lbDSThangTruoc.Size = new System.Drawing.Size(102, 18);
            this.lbDSThangTruoc.TabIndex = 1;
            this.lbDSThangTruoc.Text = "Tháng trước:";
            this.lbDSThangTruoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmOverviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::API_QuanLyNhaThuoc.Properties.Resources.backgrOverView;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbTotalAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvTopSP);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOverviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmTongQuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel4.PerformLayout();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvTopSP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private System.Windows.Forms.Label lbSPHetHanThangToi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSPHetHanThangNay;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Label lbDSHomNay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHDHomNay;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label tbHDThangNay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbHDThangTruoc;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label lbDSThangNay;
        private System.Windows.Forms.Label lbDoanhSo;
        private System.Windows.Forms.Label lbDSThangTruoc;
    }
}