namespace API_QuanLyNhaThuoc
{
    partial class FrmSettings
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
            this.panelLoad = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btEmailForm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btEmail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLoad
            // 
            this.panelLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoad.Location = new System.Drawing.Point(0, 46);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(1080, 614);
            this.panelLoad.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btEmailForm);
            this.panel1.Controls.Add(this.btEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 46);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // btEmailForm
            // 
            this.btEmailForm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btEmailForm.BackColor = System.Drawing.SystemColors.Control;
            this.btEmailForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEmailForm.BorderRadius = 0;
            this.btEmailForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btEmailForm.ButtonText = "Biểu mẫu mail";
            this.btEmailForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEmailForm.DisabledColor = System.Drawing.Color.Gray;
            this.btEmailForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEmailForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmailForm.Iconcolor = System.Drawing.Color.Transparent;
            this.btEmailForm.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_new_message_100;
            this.btEmailForm.Iconimage_right = null;
            this.btEmailForm.Iconimage_right_Selected = null;
            this.btEmailForm.Iconimage_Selected = null;
            this.btEmailForm.IconMarginLeft = 0;
            this.btEmailForm.IconMarginRight = 0;
            this.btEmailForm.IconRightVisible = true;
            this.btEmailForm.IconRightZoom = 0D;
            this.btEmailForm.IconVisible = true;
            this.btEmailForm.IconZoom = 90D;
            this.btEmailForm.IsTab = false;
            this.btEmailForm.Location = new System.Drawing.Point(266, 0);
            this.btEmailForm.Name = "btEmailForm";
            this.btEmailForm.Normalcolor = System.Drawing.SystemColors.Control;
            this.btEmailForm.OnHovercolor = System.Drawing.Color.Gray;
            this.btEmailForm.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btEmailForm.selected = false;
            this.btEmailForm.Size = new System.Drawing.Size(266, 46);
            this.btEmailForm.TabIndex = 10;
            this.btEmailForm.Text = "Biểu mẫu mail";
            this.btEmailForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEmailForm.Textcolor = System.Drawing.Color.Black;
            this.btEmailForm.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmailForm.Click += new System.EventHandler(this.btEmailForm_Click);
            // 
            // btEmail
            // 
            this.btEmail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btEmail.BackColor = System.Drawing.SystemColors.Control;
            this.btEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btEmail.BorderRadius = 0;
            this.btEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btEmail.ButtonText = "Email";
            this.btEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEmail.DisabledColor = System.Drawing.Color.Gray;
            this.btEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.btEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmail.Iconcolor = System.Drawing.Color.Transparent;
            this.btEmail.Iconimage = global::API_QuanLyNhaThuoc.Properties.Resources.icons8_email_100;
            this.btEmail.Iconimage_right = null;
            this.btEmail.Iconimage_right_Selected = null;
            this.btEmail.Iconimage_Selected = null;
            this.btEmail.IconMarginLeft = 0;
            this.btEmail.IconMarginRight = 0;
            this.btEmail.IconRightVisible = true;
            this.btEmail.IconRightZoom = 0D;
            this.btEmail.IconVisible = true;
            this.btEmail.IconZoom = 90D;
            this.btEmail.IsTab = false;
            this.btEmail.Location = new System.Drawing.Point(0, 0);
            this.btEmail.Name = "btEmail";
            this.btEmail.Normalcolor = System.Drawing.SystemColors.Control;
            this.btEmail.OnHovercolor = System.Drawing.Color.Gray;
            this.btEmail.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btEmail.selected = false;
            this.btEmail.Size = new System.Drawing.Size(266, 46);
            this.btEmail.TabIndex = 9;
            this.btEmail.Text = "Email";
            this.btEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEmail.Textcolor = System.Drawing.Color.Black;
            this.btEmail.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmail.Click += new System.EventHandler(this.btEmail_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 660);
            this.Controls.Add(this.panelLoad);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSettings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btEmailForm;
        private Bunifu.Framework.UI.BunifuFlatButton btEmail;
    }
}