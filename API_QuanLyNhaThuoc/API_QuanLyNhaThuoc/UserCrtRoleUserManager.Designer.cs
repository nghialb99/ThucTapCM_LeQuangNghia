namespace API_QuanLyNhaThuoc
{
    partial class UserCrtRoleUserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCrtRoleUserManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearch = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbStatus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btCancle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btRestore = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btLock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescription = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRoleName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelCheckBox = new System.Windows.Forms.Panel();
            this.checkBoxSettings = new System.Windows.Forms.CheckBox();
            this.checkBoxReport = new System.Windows.Forms.CheckBox();
            this.checkBoxUserManager = new System.Windows.Forms.CheckBox();
            this.checkBoxEnterpriseInfo = new System.Windows.Forms.CheckBox();
            this.checkBoxCategory = new System.Windows.Forms.CheckBox();
            this.checkBoxWarehouseManager = new System.Windows.Forms.CheckBox();
            this.checkBoxInvoiceManager = new System.Windows.Forms.CheckBox();
            this.checkBoxCreateInvoice = new System.Windows.Forms.CheckBox();
            this.dgvRoleUser = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelCheckBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Controls.Add(this.tbStatus);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.btCancle);
            this.panel1.Controls.Add(this.btRestore);
            this.panel1.Controls.Add(this.btNew);
            this.panel1.Controls.Add(this.btLock);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbRoleName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panelCheckBox);
            this.panel1.Controls.Add(this.dgvRoleUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 660);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 19);
            this.label3.TabIndex = 107;
            this.label3.Text = "Quản lý nhóm người dùng";
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.White;
            this.tbSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearch.BackgroundImage")));
            this.tbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbSearch.ForeColor = System.Drawing.Color.DarkMagenta;
            this.tbSearch.Icon = ((System.Drawing.Image)(resources.GetObject("tbSearch.Icon")));
            this.tbSearch.Location = new System.Drawing.Point(18, 253);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(250, 48);
            this.tbSearch.TabIndex = 106;
            this.tbSearch.text = "";
            this.tbSearch.OnTextChange += new System.EventHandler(this.tbSearch_OnTextChange);
            this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
            // 
            // tbStatus
            // 
            this.tbStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStatus.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatus.ForeColor = System.Drawing.Color.Blue;
            this.tbStatus.HintForeColor = System.Drawing.Color.Empty;
            this.tbStatus.HintText = "";
            this.tbStatus.isPassword = false;
            this.tbStatus.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbStatus.LineIdleColor = System.Drawing.Color.Gray;
            this.tbStatus.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbStatus.LineThickness = 3;
            this.tbStatus.Location = new System.Drawing.Point(301, 181);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(354, 33);
            this.tbStatus.TabIndex = 105;
            this.tbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btEdit.Location = new System.Drawing.Point(406, 253);
            this.btEdit.Name = "btEdit";
            this.btEdit.Normalcolor = System.Drawing.Color.Silver;
            this.btEdit.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btEdit.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btEdit.selected = false;
            this.btEdit.Size = new System.Drawing.Size(124, 48);
            this.btEdit.TabIndex = 104;
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
            this.btSave.Location = new System.Drawing.Point(537, 253);
            this.btSave.Name = "btSave";
            this.btSave.Normalcolor = System.Drawing.Color.Silver;
            this.btSave.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btSave.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btSave.selected = false;
            this.btSave.Size = new System.Drawing.Size(124, 48);
            this.btSave.TabIndex = 103;
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
            this.btCancle.Location = new System.Drawing.Point(668, 253);
            this.btCancle.Name = "btCancle";
            this.btCancle.Normalcolor = System.Drawing.Color.Silver;
            this.btCancle.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btCancle.OnHoverTextColor = System.Drawing.Color.Red;
            this.btCancle.selected = false;
            this.btCancle.Size = new System.Drawing.Size(124, 48);
            this.btCancle.TabIndex = 102;
            this.btCancle.Text = "Hủy";
            this.btCancle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btCancle.Textcolor = System.Drawing.Color.Black;
            this.btCancle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancle.Click += new System.EventHandler(this.btCancle_Click);
            // 
            // btRestore
            // 
            this.btRestore.Activecolor = System.Drawing.Color.Gray;
            this.btRestore.BackColor = System.Drawing.Color.Silver;
            this.btRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRestore.BorderRadius = 7;
            this.btRestore.ButtonText = "Khôi phục";
            this.btRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRestore.DisabledColor = System.Drawing.Color.Gray;
            this.btRestore.ForeColor = System.Drawing.Color.Black;
            this.btRestore.Iconcolor = System.Drawing.Color.Transparent;
            this.btRestore.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_padlock_100;
            this.btRestore.Iconimage_right = null;
            this.btRestore.Iconimage_right_Selected = null;
            this.btRestore.Iconimage_Selected = null;
            this.btRestore.IconMarginLeft = 0;
            this.btRestore.IconMarginRight = 0;
            this.btRestore.IconRightVisible = true;
            this.btRestore.IconRightZoom = 0D;
            this.btRestore.IconVisible = true;
            this.btRestore.IconZoom = 90D;
            this.btRestore.IsTab = false;
            this.btRestore.Location = new System.Drawing.Point(930, 253);
            this.btRestore.Name = "btRestore";
            this.btRestore.Normalcolor = System.Drawing.Color.Silver;
            this.btRestore.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btRestore.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btRestore.selected = false;
            this.btRestore.Size = new System.Drawing.Size(124, 48);
            this.btRestore.TabIndex = 101;
            this.btRestore.Text = "Khôi phục";
            this.btRestore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btRestore.Textcolor = System.Drawing.Color.Black;
            this.btRestore.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
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
            this.btNew.Location = new System.Drawing.Point(275, 253);
            this.btNew.Name = "btNew";
            this.btNew.Normalcolor = System.Drawing.Color.Silver;
            this.btNew.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btNew.OnHoverTextColor = System.Drawing.Color.Lime;
            this.btNew.selected = false;
            this.btNew.Size = new System.Drawing.Size(124, 48);
            this.btNew.TabIndex = 100;
            this.btNew.Text = "Thêm mới";
            this.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btNew.Textcolor = System.Drawing.Color.Black;
            this.btNew.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btLock
            // 
            this.btLock.Activecolor = System.Drawing.Color.Gray;
            this.btLock.BackColor = System.Drawing.Color.Silver;
            this.btLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLock.BorderRadius = 7;
            this.btLock.ButtonText = "Khóa";
            this.btLock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLock.DisabledColor = System.Drawing.Color.Gray;
            this.btLock.ForeColor = System.Drawing.Color.Black;
            this.btLock.Iconcolor = System.Drawing.Color.Transparent;
            this.btLock.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_lock_100;
            this.btLock.Iconimage_right = null;
            this.btLock.Iconimage_right_Selected = null;
            this.btLock.Iconimage_Selected = null;
            this.btLock.IconMarginLeft = 0;
            this.btLock.IconMarginRight = 0;
            this.btLock.IconRightVisible = true;
            this.btLock.IconRightZoom = 0D;
            this.btLock.IconVisible = true;
            this.btLock.IconZoom = 90D;
            this.btLock.IsTab = false;
            this.btLock.Location = new System.Drawing.Point(799, 253);
            this.btLock.Name = "btLock";
            this.btLock.Normalcolor = System.Drawing.Color.Silver;
            this.btLock.OnHovercolor = System.Drawing.SystemColors.Control;
            this.btLock.OnHoverTextColor = System.Drawing.Color.Red;
            this.btLock.selected = false;
            this.btLock.Size = new System.Drawing.Size(124, 48);
            this.btLock.TabIndex = 99;
            this.btLock.Text = "Khóa";
            this.btLock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLock.Textcolor = System.Drawing.Color.Black;
            this.btLock.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLock.Click += new System.EventHandler(this.btLock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 97;
            this.label1.Text = "Trạng thái";
            // 
            // tbDescription
            // 
            this.tbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDescription.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.ForeColor = System.Drawing.Color.Blue;
            this.tbDescription.HintForeColor = System.Drawing.Color.Empty;
            this.tbDescription.HintText = "";
            this.tbDescription.isPassword = false;
            this.tbDescription.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbDescription.LineIdleColor = System.Drawing.Color.Gray;
            this.tbDescription.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbDescription.LineThickness = 3;
            this.tbDescription.Location = new System.Drawing.Point(301, 125);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(354, 33);
            this.tbDescription.TabIndex = 96;
            this.tbDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 95;
            this.label2.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(277, 83);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 94;
            this.label4.Text = "*";
            // 
            // tbRoleName
            // 
            this.tbRoleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRoleName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoleName.ForeColor = System.Drawing.Color.Blue;
            this.tbRoleName.HintForeColor = System.Drawing.Color.Empty;
            this.tbRoleName.HintText = "";
            this.tbRoleName.isPassword = false;
            this.tbRoleName.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbRoleName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbRoleName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbRoleName.LineThickness = 3;
            this.tbRoleName.Location = new System.Drawing.Point(301, 73);
            this.tbRoleName.Margin = new System.Windows.Forms.Padding(4);
            this.tbRoleName.Name = "tbRoleName";
            this.tbRoleName.Size = new System.Drawing.Size(354, 33);
            this.tbRoleName.TabIndex = 93;
            this.tbRoleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbRoleName.OnValueChanged += new System.EventHandler(this.tbRoleName_OnValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 19);
            this.label7.TabIndex = 92;
            this.label7.Text = "Tên nhóm người dùng";
            // 
            // panelCheckBox
            // 
            this.panelCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCheckBox.Controls.Add(this.checkBoxSettings);
            this.panelCheckBox.Controls.Add(this.checkBoxReport);
            this.panelCheckBox.Controls.Add(this.checkBoxUserManager);
            this.panelCheckBox.Controls.Add(this.checkBoxEnterpriseInfo);
            this.panelCheckBox.Controls.Add(this.checkBoxCategory);
            this.panelCheckBox.Controls.Add(this.checkBoxWarehouseManager);
            this.panelCheckBox.Controls.Add(this.checkBoxInvoiceManager);
            this.panelCheckBox.Controls.Add(this.checkBoxCreateInvoice);
            this.panelCheckBox.Location = new System.Drawing.Point(760, 73);
            this.panelCheckBox.Name = "panelCheckBox";
            this.panelCheckBox.Size = new System.Drawing.Size(209, 162);
            this.panelCheckBox.TabIndex = 91;
            // 
            // checkBoxSettings
            // 
            this.checkBoxSettings.AutoSize = true;
            this.checkBoxSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSettings.Location = new System.Drawing.Point(0, 140);
            this.checkBoxSettings.Name = "checkBoxSettings";
            this.checkBoxSettings.Size = new System.Drawing.Size(207, 20);
            this.checkBoxSettings.TabIndex = 8;
            this.checkBoxSettings.Text = "Thiết lập";
            this.checkBoxSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxReport
            // 
            this.checkBoxReport.AutoSize = true;
            this.checkBoxReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxReport.Location = new System.Drawing.Point(0, 120);
            this.checkBoxReport.Name = "checkBoxReport";
            this.checkBoxReport.Size = new System.Drawing.Size(207, 20);
            this.checkBoxReport.TabIndex = 7;
            this.checkBoxReport.Text = "Báo cáo";
            this.checkBoxReport.UseVisualStyleBackColor = true;
            // 
            // checkBoxUserManager
            // 
            this.checkBoxUserManager.AutoSize = true;
            this.checkBoxUserManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxUserManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUserManager.Location = new System.Drawing.Point(0, 100);
            this.checkBoxUserManager.Name = "checkBoxUserManager";
            this.checkBoxUserManager.Size = new System.Drawing.Size(207, 20);
            this.checkBoxUserManager.TabIndex = 6;
            this.checkBoxUserManager.Text = "Quản lý người dùng";
            this.checkBoxUserManager.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnterpriseInfo
            // 
            this.checkBoxEnterpriseInfo.AutoSize = true;
            this.checkBoxEnterpriseInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxEnterpriseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnterpriseInfo.Location = new System.Drawing.Point(0, 80);
            this.checkBoxEnterpriseInfo.Name = "checkBoxEnterpriseInfo";
            this.checkBoxEnterpriseInfo.Size = new System.Drawing.Size(207, 20);
            this.checkBoxEnterpriseInfo.TabIndex = 5;
            this.checkBoxEnterpriseInfo.Text = "Thông tin doanh nghiệp";
            this.checkBoxEnterpriseInfo.UseVisualStyleBackColor = true;
            // 
            // checkBoxCategory
            // 
            this.checkBoxCategory.AutoSize = true;
            this.checkBoxCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCategory.Location = new System.Drawing.Point(0, 60);
            this.checkBoxCategory.Name = "checkBoxCategory";
            this.checkBoxCategory.Size = new System.Drawing.Size(207, 20);
            this.checkBoxCategory.TabIndex = 4;
            this.checkBoxCategory.Text = "Danh mục";
            this.checkBoxCategory.UseVisualStyleBackColor = true;
            // 
            // checkBoxWarehouseManager
            // 
            this.checkBoxWarehouseManager.AutoSize = true;
            this.checkBoxWarehouseManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxWarehouseManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWarehouseManager.Location = new System.Drawing.Point(0, 40);
            this.checkBoxWarehouseManager.Name = "checkBoxWarehouseManager";
            this.checkBoxWarehouseManager.Size = new System.Drawing.Size(207, 20);
            this.checkBoxWarehouseManager.TabIndex = 3;
            this.checkBoxWarehouseManager.Text = "Quản lý kho";
            this.checkBoxWarehouseManager.UseVisualStyleBackColor = true;
            // 
            // checkBoxInvoiceManager
            // 
            this.checkBoxInvoiceManager.AutoSize = true;
            this.checkBoxInvoiceManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxInvoiceManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxInvoiceManager.Location = new System.Drawing.Point(0, 20);
            this.checkBoxInvoiceManager.Name = "checkBoxInvoiceManager";
            this.checkBoxInvoiceManager.Size = new System.Drawing.Size(207, 20);
            this.checkBoxInvoiceManager.TabIndex = 2;
            this.checkBoxInvoiceManager.Text = "Quản lý hóa đơn";
            this.checkBoxInvoiceManager.UseVisualStyleBackColor = true;
            // 
            // checkBoxCreateInvoice
            // 
            this.checkBoxCreateInvoice.AutoSize = true;
            this.checkBoxCreateInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxCreateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCreateInvoice.Location = new System.Drawing.Point(0, 0);
            this.checkBoxCreateInvoice.Name = "checkBoxCreateInvoice";
            this.checkBoxCreateInvoice.Size = new System.Drawing.Size(207, 20);
            this.checkBoxCreateInvoice.TabIndex = 1;
            this.checkBoxCreateInvoice.Text = "Lập hóa đơn";
            this.checkBoxCreateInvoice.UseVisualStyleBackColor = true;
            // 
            // dgvRoleUser
            // 
            this.dgvRoleUser.AllowUserToDeleteRows = false;
            this.dgvRoleUser.AllowUserToResizeColumns = false;
            this.dgvRoleUser.AllowUserToResizeRows = false;
            this.dgvRoleUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoleUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRoleUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoleUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoleUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.type,
            this.name,
            this.colum3,
            this.Column1});
            this.dgvRoleUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRoleUser.EnableHeadersVisualStyles = false;
            this.dgvRoleUser.Location = new System.Drawing.Point(0, 331);
            this.dgvRoleUser.Name = "dgvRoleUser";
            this.dgvRoleUser.ReadOnly = true;
            this.dgvRoleUser.RowHeadersVisible = false;
            this.dgvRoleUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRoleUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoleUser.Size = new System.Drawing.Size(1080, 329);
            this.dgvRoleUser.TabIndex = 85;
            this.dgvRoleUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoleUser_CellClick);
            this.dgvRoleUser.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvRoleUser_RowsAdded);
            // 
            // username
            // 
            this.username.HeaderText = "STT";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Width = 55;
            // 
            // type
            // 
            this.type.DataPropertyName = "RoleName";
            this.type.HeaderText = "Tên nhóm người dùng";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 350;
            // 
            // name
            // 
            this.name.DataPropertyName = "Description";
            this.name.HeaderText = "Mô tả";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 350;
            // 
            // colum3
            // 
            this.colum3.DataPropertyName = "CreationDate";
            this.colum3.HeaderText = "Ngày tạo";
            this.colum3.Name = "colum3";
            this.colum3.ReadOnly = true;
            this.colum3.Width = 160;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Status";
            this.Column1.HeaderText = "Trạng thái";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 140;
            // 
            // UserCrtRoleUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserCrtRoleUserManager";
            this.Size = new System.Drawing.Size(1080, 660);
            this.Load += new System.EventHandler(this.UserCrtRoleUserManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCheckBox.ResumeLayout(false);
            this.panelCheckBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvRoleUser;
        private System.Windows.Forms.Panel panelCheckBox;
        private System.Windows.Forms.CheckBox checkBoxSettings;
        private System.Windows.Forms.CheckBox checkBoxReport;
        private System.Windows.Forms.CheckBox checkBoxUserManager;
        private System.Windows.Forms.CheckBox checkBoxEnterpriseInfo;
        private System.Windows.Forms.CheckBox checkBoxCategory;
        private System.Windows.Forms.CheckBox checkBoxWarehouseManager;
        private System.Windows.Forms.CheckBox checkBoxInvoiceManager;
        private System.Windows.Forms.CheckBox checkBoxCreateInvoice;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbRoleName;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btSave;
        private Bunifu.Framework.UI.BunifuFlatButton btCancle;
        private Bunifu.Framework.UI.BunifuFlatButton btRestore;
        private Bunifu.Framework.UI.BunifuFlatButton btNew;
        private Bunifu.Framework.UI.BunifuFlatButton btLock;
        private Bunifu.Framework.UI.BunifuFlatButton btEdit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbStatus;
        private Bunifu.Framework.UI.BunifuTextbox tbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label3;
    }
}
