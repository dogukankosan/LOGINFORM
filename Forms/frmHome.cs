using DevExpress.XtraEditors;
using FormStudent.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormStudent
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private readonly SqlConnection db = new("Data Source=DOGUKAN\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True");
        private readonly char? nullChar = null;
        private bool statusLogin = default;
        private void frmHome_Load(object sender, EventArgs e)
        {
            Btn_Unvisible.Visible = false;
            Txt_Password.Properties.PasswordChar = '*';
        }
        private void Btn_Visible_Click(object sender, EventArgs e)
        {
            Btn_Visible.Visible = false;
            Btn_Unvisible.Visible = true;
            Txt_Password.Properties.PasswordChar = Convert.ToChar(nullChar);
            Txt_Password.Focus();
        }
        private void Btn_Unvisible_Click(object sender, EventArgs e)
        {
            Btn_Unvisible.Visible = false;
            Btn_Visible.Visible = true;
            Txt_Password.Properties.PasswordChar = '*';
            Txt_Password.Focus();
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_UserName.Text) || string.IsNullOrEmpty(Txt_Password.Text))
            {
                XtraMessageBox.Show("KULLANICI ADI VEYA ŞİFRE BOŞ GEÇMEYİNİZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Txt_UserName.Focus();
                return;
            }
            db.Open();
            SqlCommand cmd = new("select User_Name,User_Password from Tbl_Login", db);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (Txt_Password != null && Txt_UserName != null && Txt_UserName.Text == rd[0] as string &&
                    Txt_Password.Text == rd[1] as string)
                {
                    statusLogin = true;
                    break;
                }
            }
            rd.Close();
            db.Close();
            if (statusLogin)
            {
                XtraMessageBox.Show("GİRİŞ İŞLEMİ BAŞARILI HOŞGELDİNİZ !!", "BAŞARILI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                frmUserAdd frs = new();
                frs.Show();
                this.Hide();

            }
            else
            {
                XtraMessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI TEKRAR GİRİŞ YAPINIZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                foreach (Control item in Controls)
                {
                    if (item is TextEdit)
                        item.Text = string.Empty;
                }
                Txt_UserName.Focus();
            }
        }
        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            RememberPassword ps = new ();
            ps.ShowDialog();
            if (!string.IsNullOrEmpty(ps.PasswordReturn))
                Txt_Password.Text = ps.PasswordReturn;
            Txt_UserName.Focus();
        }
    }
}