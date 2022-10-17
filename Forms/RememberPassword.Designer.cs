
namespace FormStudent.Forms
{
    partial class RememberPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RememberPassword));
            this.Txt_Username = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_NameSurname = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Lbl_Result = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Result = new DevExpress.XtraEditors.TextEdit();
            this.Lbl_Question = new DevExpress.XtraEditors.LabelControl();
            this.Txt_Question = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NameSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Result.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Question.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Username
            // 
            this.Txt_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Username.Location = new System.Drawing.Point(103, 17);
            this.Txt_Username.Name = "Txt_Username";
            this.Txt_Username.Properties.MaxLength = 50;
            this.Txt_Username.Size = new System.Drawing.Size(128, 20);
            this.Txt_Username.TabIndex = 1;
            this.Txt_Username.EditValueChanged += new System.EventHandler(this.Txt_Username_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(7, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "KULLANICI ADINIZ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(4, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(93, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "ADINIZ SOYADINIZ";
            // 
            // Txt_NameSurname
            // 
            this.Txt_NameSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NameSurname.Location = new System.Drawing.Point(103, 45);
            this.Txt_NameSurname.Name = "Txt_NameSurname";
            this.Txt_NameSurname.Properties.MaxLength = 50;
            this.Txt_NameSurname.Size = new System.Drawing.Size(128, 20);
            this.Txt_NameSurname.TabIndex = 3;
            this.Txt_NameSurname.EditValueChanged += new System.EventHandler(this.Txt_NameSurname_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.Lbl_Result);
            this.groupControl1.Controls.Add(this.Txt_Result);
            this.groupControl1.Controls.Add(this.Lbl_Question);
            this.groupControl1.Controls.Add(this.Txt_Question);
            this.groupControl1.Location = new System.Drawing.Point(7, 92);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(224, 113);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "SORU PANELİ";
            this.groupControl1.Visible = false;
            // 
            // Lbl_Result
            // 
            this.Lbl_Result.Location = new System.Drawing.Point(4, 71);
            this.Lbl_Result.Name = "Lbl_Result";
            this.Lbl_Result.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Result.TabIndex = 8;
            this.Lbl_Result.Text = "CEVAP";
            // 
            // Txt_Result
            // 
            this.Txt_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Result.Location = new System.Drawing.Point(40, 68);
            this.Txt_Result.Name = "Txt_Result";
            this.Txt_Result.Properties.MaxLength = 50;
            this.Txt_Result.Size = new System.Drawing.Size(179, 20);
            this.Txt_Result.TabIndex = 7;
            this.Txt_Result.EditValueChanged += new System.EventHandler(this.Txt_Result_EditValueChanged);
            // 
            // Lbl_Question
            // 
            this.Lbl_Question.Location = new System.Drawing.Point(4, 38);
            this.Lbl_Question.Name = "Lbl_Question";
            this.Lbl_Question.Size = new System.Drawing.Size(28, 13);
            this.Lbl_Question.TabIndex = 6;
            this.Lbl_Question.Text = "SORU";
            // 
            // Txt_Question
            // 
            this.Txt_Question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Question.Enabled = false;
            this.Txt_Question.Location = new System.Drawing.Point(40, 35);
            this.Txt_Question.Name = "Txt_Question";
            this.Txt_Question.Size = new System.Drawing.Size(179, 20);
            this.Txt_Question.TabIndex = 5;
            // 
            // RememberPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(239, 208);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Txt_NameSurname);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Txt_Username);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RememberPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞİFREMİ UNUTTUM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RememberPassword_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RememberPassword_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_NameSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Result.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_Question.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit Txt_Username;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txt_NameSurname;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl Lbl_Result;
        private DevExpress.XtraEditors.TextEdit Txt_Result;
        private DevExpress.XtraEditors.LabelControl Lbl_Question;
        private DevExpress.XtraEditors.TextEdit Txt_Question;
    }
}