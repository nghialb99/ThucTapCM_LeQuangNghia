namespace API_QuanLyNhaThuoc
{
    partial class FrmPrintBill
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrintBill));
            this.PrintBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Api_QuanLyNhaThuocDataSet = new API_QuanLyNhaThuoc.Api_QuanLyNhaThuocDataSet();
            this.SelectItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PrintBillTableAdapter = new API_QuanLyNhaThuoc.Api_QuanLyNhaThuocDataSetTableAdapters.PrintBillTableAdapter();
            this.SelectItemsTableAdapter = new API_QuanLyNhaThuoc.Api_QuanLyNhaThuocDataSetTableAdapters.SelectItemsTableAdapter();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PrintBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Api_QuanLyNhaThuocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintBillBindingSource
            // 
            this.PrintBillBindingSource.DataMember = "PrintBill";
            this.PrintBillBindingSource.DataSource = this.Api_QuanLyNhaThuocDataSet;
            // 
            // Api_QuanLyNhaThuocDataSet
            // 
            this.Api_QuanLyNhaThuocDataSet.DataSetName = "Api_QuanLyNhaThuocDataSet";
            this.Api_QuanLyNhaThuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectItemsBindingSource
            // 
            this.SelectItemsBindingSource.DataMember = "SelectItems";
            this.SelectItemsBindingSource.DataSource = this.Api_QuanLyNhaThuocDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PrintBillBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SelectItemsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "API_QuanLyNhaThuoc.ReportPrintBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(911, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PrintBillTableAdapter
            // 
            this.PrintBillTableAdapter.ClearBeforeFill = true;
            // 
            // SelectItemsTableAdapter
            // 
            this.SelectItemsTableAdapter.ClearBeforeFill = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmPrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 661);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrintBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.FrmPrintBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PrintBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Api_QuanLyNhaThuocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PrintBillBindingSource;
        private Api_QuanLyNhaThuocDataSet Api_QuanLyNhaThuocDataSet;
        private System.Windows.Forms.BindingSource SelectItemsBindingSource;
        private Api_QuanLyNhaThuocDataSetTableAdapters.PrintBillTableAdapter PrintBillTableAdapter;
        private Api_QuanLyNhaThuocDataSetTableAdapters.SelectItemsTableAdapter SelectItemsTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}