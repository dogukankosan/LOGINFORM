
namespace FormStudent
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.Txt_UserName = new DevExpress.XtraEditors.TextEdit();
            this.Txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.Btn_Login = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Btn_Visible = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_Unvisible = new DevExpress.XtraEditors.SimpleButton();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserName.Location = new System.Drawing.Point(0, 33);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Properties.MaxLength = 50;
            this.Txt_UserName.Size = new System.Drawing.Size(170, 20);
            this.Txt_UserName.TabIndex = 0;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Password.Location = new System.Drawing.Point(0, 95);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Properties.MaxLength = 50;
            this.Txt_Password.Size = new System.Drawing.Size(170, 20);
            this.Txt_Password.TabIndex = 1;
            // 
            // Btn_Login
            // 
            this.Btn_Login.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Btn_Login.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Login.Appearance.Options.UseBackColor = true;
            this.Btn_Login.Appearance.Options.UseFont = true;
            this.Btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Login.Location = new System.Drawing.Point(0, 164);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(170, 31);
            this.Btn_Login.TabIndex = 2;
            this.Btn_Login.Text = "GİRİŞ YAP";
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "KULLANICI ADI";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "ŞİFRE";
            // 
            // Btn_Visible
            // 
            this.Btn_Visible.Appearance.Font = new System.Drawing.Font("Tahoma", 5.25F);
            this.Btn_Visible.Appearance.Options.UseFont = true;
            this.Btn_Visible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Visible.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Visible.ImageOptions.Image")));
            this.Btn_Visible.Location = new System.Drawing.Point(36, 76);
            this.Btn_Visible.Name = "Btn_Visible";
            this.Btn_Visible.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btn_Visible.Size = new System.Drawing.Size(20, 14);
            this.Btn_Visible.TabIndex = 4;
            this.Btn_Visible.Click += new System.EventHandler(this.Btn_Visible_Click);
            // 
            // Btn_Unvisible
            // 
            this.Btn_Unvisible.Appearance.Font = new System.Drawing.Font("Tahoma", 5.25F);
            this.Btn_Unvisible.Appearance.Options.UseFont = true;
            this.Btn_Unvisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Unvisible.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Unvisible.ImageOptions.Image")));
            this.Btn_Unvisible.Location = new System.Drawing.Point(36, 76);
            this.Btn_Unvisible.Name = "Btn_Unvisible";
            this.Btn_Unvisible.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.Btn_Unvisible.Size = new System.Drawing.Size(20, 14);
            this.Btn_Unvisible.TabIndex = 3;
            this.Btn_Unvisible.Click += new System.EventHandler(this.Btn_Unvisible_Click);
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.LineColor = System.Drawing.Color.Red;
            this.hyperlinkLabelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(5, 131);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(92, 13);
            this.hyperlinkLabelControl1.TabIndex = 5;
            this.hyperlinkLabelControl1.Text = "ŞİFREMİ UNUTTUM";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(170, 195);
            this.Controls.Add(this.hyperlinkLabelControl1);
            this.Controls.Add(this.Btn_Unvisible);
            this.Controls.Add(this.Btn_Visible);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_UserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ İŞLEMİ";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit Txt_UserName;
        private DevExpress.XtraEditors.SimpleButton Btn_Login;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Btn_Visible;
        private DevExpress.XtraEditors.SimpleButton Btn_Unvisible;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private DevExpress.XtraEditors.TextEdit Txt_Password;
    }
}

