namespace API_QuanLyNhaThuoc
{
    partial class FrmUnitName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnitName));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.btEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btCancle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbUnitName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvButtonDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.dgvCategory);
            this.bunifuGradientPanel1.Controls.Add(this.btExit);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.tbSearch);
            this.bunifuGradientPanel1.Controls.Add(this.btEdit);
            this.bunifuGradientPanel1.Controls.Add(this.btSave);
            this.bunifuGradientPanel1.Controls.Add(this.btCancle);
            this.bunifuGradientPanel1.Controls.Add(this.btNew);
            this.bunifuGradientPanel1.Controls.Add(this.tbUnitName);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label15);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(725, 303);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.Image = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_cancel_100;
            this.btExit.ImageActive = null;
            this.btExit.Location = new System.Drawing.Point(686, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(39, 40);
            this.btExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btExit.TabIndex = 164;
            this.btExit.TabStop = false;
            this.btExit.Zoom = 10;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(161, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 138;
            this.label4.Text = "*";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearch.BackgroundImage")));
            this.tbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSearch.ForeColor = System.Drawing.Color.DarkMagenta;
            this.tbSearch.Icon = ((System.Drawing.Image)(resources.GetObject("tbSearch.Icon")));
            this.tbSearch.Location = new System.Drawing.Point(30, 115);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(259, 48);
            this.tbSearch.TabIndex = 136;
            this.tbSearch.text = "";
            this.tbSearch.OnTextChange += new System.EventHandler(this.tbSearch_OnTextChange);
            // 
            // btEdit
            // 
            this.btEdit.Activecolor = System.Drawing.Color.Gray;
            this.btEdit.BackColor = System.Drawing.Color.Silver;
            this.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEdit.BorderRadius = 7;
            this.btEdit.ButtonText = "Sửa";
            this.btEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btEdit.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_update_100;
            this.btEdit.Iconimage_right = null;
            this.btEdit.Iconimage_right_Selected = null;
            this.btEdit.Iconimage_Selected = null;
            this.btEdit.IconMarginLeft = 0;
            this.btEdit.IconMarginRight = 0;
            this.btEdit.IconRightVisible = true;
            this.btEdit.IconRightZoom = 0D;
            this.btEdit.IconVisible = true;
            this.btEdit.IconZoom = 90D;
            this.btEdit.IsTab = false;
            this.btEdit.Location = new System.Drawing.Point(165, 169);
            this.btEdit.Name = "btEdit";
            this.btEdit.Normalcolor = System.Drawing.Color.Silver;
            this.btEdit.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btEdit.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btEdit.selected = false;
            this.btEdit.Size = new System.Drawing.Size(124, 48);
            this.btEdit.TabIndex = 134;
            this.btEdit.Text = "Sửa";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btEdit.Textcolor = System.Drawing.Color.Black;
            this.btEdit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btSave
            // 
            this.btSave.Activecolor = System.Drawing.Color.Gray;
            this.btSave.BackColor = System.Drawing.Color.Silver;
            this.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSave.BorderRadius = 7;
            this.btSave.ButtonText = "Lưu";
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.DisabledColor = System.Drawing.Color.Gray;
            this.btSave.ForeColor = System.Drawing.Color.Black;
            this.btSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btSave.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_save_close_100;
            this.btSave.Iconimage_right = null;
            this.btSave.Iconimage_right_Selected = null;
            this.btSave.Iconimage_Selected = null;
            this.btSave.IconMarginLeft = 0;
            this.btSave.IconMarginRight = 0;
            this.btSave.IconRightVisible = true;
            this.btSave.IconRightZoom = 0D;
            this.btSave.IconVisible = true;
            this.btSave.IconZoom = 90D;
            this.btSave.IsTab = false;
            this.btSave.Location = new System.Drawing.Point(30, 223);
            this.btSave.Name = "btSave";
            this.btSave.Normalcolor = System.Drawing.Color.Silver;
            this.btSave.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btSave.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btSave.selected = false;
            this.btSave.Size = new System.Drawing.Size(124, 48);
            this.btSave.TabIndex = 133;
            this.btSave.Text = "Lưu";
            this.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btSave.Textcolor = System.Drawing.Color.Black;
            this.btSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancle
            // 
            this.btCancle.Activecolor = System.Drawing.Color.Gray;
            this.btCancle.BackColor = System.Drawing.Color.Silver;
            this.btCancle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancle.BorderRadius = 7;
            this.btCancle.ButtonText = "Hủy";
            this.btCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancle.DisabledColor = System.Drawing.Color.Gray;
            this.btCancle.ForeColor = System.Drawing.Color.Black;
            this.btCancle.Iconcolor = System.Drawing.Color.Transparent;
            this.btCancle.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_cancel_100;
            this.btCancle.Iconimage_right = null;
            this.btCancle.Iconimage_right_Selected = null;
            this.btCancle.Iconimage_Selected = null;
            this.btCancle.IconMarginLeft = 0;
            this.btCancle.IconMarginRight = 0;
            this.btCancle.IconRightVisible = true;
            this.btCancle.IconRightZoom = 0D;
            this.btCancle.IconVisible = true;
            this.btCancle.IconZoom = 90D;
            this.btCancle.IsTab = false;
            this.btCancle.Location = new System.Drawing.Point(165, 223);
            this.btCancle.Name = "btCancle";
            this.btCancle.Normalcolor = System.Drawing.Color.Silver;
            this.btCancle.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btCancle.OnHoverTextColor = System.Drawing.Color.Red;
            this.btCancle.selected = false;
            this.btCancle.Size = new System.Drawing.Size(124, 48);
            this.btCancle.TabIndex = 132;
            this.btCancle.Text = "Hủy";
            this.btCancle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCancle.Textcolor = System.Drawing.Color.Black;
            this.btCancle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancle.Click += new System.EventHandler(this.btCancle_Click);
            // 
            // btNew
            // 
            this.btNew.Activecolor = System.Drawing.Color.Gray;
            this.btNew.BackColor = System.Drawing.Color.Silver;
            this.btNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNew.BorderRadius = 7;
            this.btNew.ButtonText = "Thêm mới";
            this.btNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNew.DisabledColor = System.Drawing.Color.Gray;
            this.btNew.ForeColor = System.Drawing.Color.Black;
            this.btNew.Iconcolor = System.Drawing.Color.Transparent;
            this.btNew.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_plus_100;
            this.btNew.Iconimage_right = null;
            this.btNew.Iconimage_right_Selected = null;
            this.btNew.Iconimage_Selected = null;
            this.btNew.IconMarginLeft = 0;
            this.btNew.IconMarginRight = 0;
            this.btNew.IconRightVisible = true;
            this.btNew.IconRightZoom = 0D;
            this.btNew.IconVisible = true;
            this.btNew.IconZoom = 90D;
            this.btNew.IsTab = false;
            this.btNew.Location = new System.Drawing.Point(30, 169);
            this.btNew.Name = "btNew";
            this.btNew.Normalcolor = System.Drawing.Color.Silver;
            this.btNew.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btNew.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btNew.selected = false;
            this.btNew.Size = new System.Drawing.Size(124, 48);
            this.btNew.TabIndex = 130;
            this.btNew.Text = "Thêm mới";
            this.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btNew.Textcolor = System.Drawing.Color.Black;
            this.btNew.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // tbUnitName
            // 
            this.tbUnitName.BackColor = System.Drawing.Color.White;
            this.tbUnitName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUnitName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnitName.ForeColor = System.Drawing.Color.Blue;
            this.tbUnitName.HintForeColor = System.Drawing.Color.Empty;
            this.tbUnitName.HintText = "";
            this.tbUnitName.isPassword = false;
            this.tbUnitName.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbUnitName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbUnitName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbUnitName.LineThickness = 3;
            this.tbUnitName.Location = new System.Drawing.Point(183, 62);
            this.tbUnitName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUnitName.Name = "tbUnitName";
            this.tbUnitName.Size = new System.Drawing.Size(512, 35);
            this.tbUnitName.TabIndex = 127;
            this.tbUnitName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 126;
            this.label2.Text = "Tên đơn vị tính";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(7, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 19);
            this.label15.TabIndex = 96;
            this.label15.Text = "Đơn vị tính";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.AllowUserToResizeColumns = false;
            this.dgvCategory.AllowUserToResizeRows = false;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column5,
            this.Column4,
            this.dgvButtonDelete});
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.Location = new System.Drawing.Point(314, 115);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.RowHeadersVisible = false;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(381, 156);
            this.dgvCategory.TabIndex = 165;
            this.dgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellClick);
            this.dgvCategory.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCategory_RowsAdded);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "STT";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 30;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Id";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Name";
            this.Column4.FillWeight = 113.0288F;
            this.Column4.HeaderText = "Tên";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 300;
            // 
            // dgvButtonDelete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            this.dgvButtonDelete.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvButtonDelete.HeaderText = "Xóa";
            this.dgvButtonDelete.Name = "dgvButtonDelete";
            this.dgvButtonDelete.ReadOnly = true;
            this.dgvButtonDelete.Text = "Xóa";
            this.dgvButtonDelete.UseColumnTextForButtonValue = true;
            this.dgvButtonDelete.Width = 50;
            // 
            // FrmUnitName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 303);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUnitName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUnitName";
            this.Load += new System.EventHandler(this.FrmUnitName_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuTextbox tbSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btSave;
        private Bunifu.Framework.UI.BunifuFlatButton btCancle;
        private Bunifu.Framework.UI.BunifuFlatButton btNew;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUnitName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuImageButton btExit;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn dgvButtonDelete;
    }
}