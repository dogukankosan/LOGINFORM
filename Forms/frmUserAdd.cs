using DevExpress.XtraEditors;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormStudent.Forms
{
    public partial class frmUserAdd : Form
    {
        public frmUserAdd()
        {
            InitializeComponent();
        }
        private readonly char? nullChar = null;
        private readonly char? nullChar2 = null;
        private readonly SqlConnection db = new("Data Source=DOGUKAN\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True");
        private void frmStok_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Btn_Visible_Click(object sender, System.EventArgs e)
        {
            Btn_Visible.Visible = false;
            Btn_Unvisible.Visible = true;
            Txt_Password.Properties.PasswordChar = Convert.ToChar(nullChar);
            Txt_Password.Focus();
        }
        private void Btn_Unvisible_Click(object sender, System.EventArgs e)
        {
            Btn_Unvisible.Visible = false;
            Btn_Visible.Visible = true;
            Txt_Password.Properties.PasswordChar = '*';
            Txt_Password.Focus();
        }
        private void Btn_Unvisible2_Click(object sender, System.EventArgs e)
        {
            Btn_Unvisible2.Visible = false;
            Btn_Visible2.Visible = true;
            Txt_Password2.Properties.PasswordChar = '*';
            Txt_Password2.Focus();
        }
        private void Btn_Visible2_Click(object sender, System.EventArgs e)
        {
            Btn_Visible2.Visible = false;
            Btn_Unvisible2.Visible = true;
            Txt_Password2.Properties.PasswordChar = Convert.ToChar(nullChar2);
            Txt_Password2.Focus();
        }
        private void frmUserAdd_Load(object sender, System.EventArgs e)
        {
            Btn_Unvisible.Visible = false;
            Txt_Password.Properties.PasswordChar = '*';
            Btn_Unvisible2.Visible = false;
            Txt_Password2.Properties.PasswordChar = '*';
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_UserName.Text) || string.IsNullOrEmpty(Txt_NameSurname.Text) || string.IsNullOrEmpty(Txt_Password.Text) || string.IsNullOrEmpty(Txt_Password2.Text) || string.IsNullOrEmpty(Txt_Question.Text) || string.IsNullOrEmpty(Txt_Result.Text))
            {

                XtraMessageBox.Show("METİN KUTULARINI BOŞ GEÇMEYİNİZ TAMAMINI DOLDURUNUZ !!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Txt_UserName.Focus();
                return;
            }
            //PASSWORD EŞLEŞİYOR MU KONTROL
            if (Txt_Password2.Text != Txt_Password.Text)
            {

                XtraMessageBox.Show("GİRİLEN ŞİFRELER UYUŞMUYOR TEKRAR GİRİNİZ!!", "HATALI", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Txt_Password.Focus();
                Txt_Password.Text = string.Empty;
                Txt_Password2.Text = string.Empty;
                return;
            }
            //DAHA ÖNCEDEN TANIMLANMIŞ MI username and password
            db.Open();
            SqlCommand cmd = new("select User_Name,User_Password from Tbl_Login", db);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (Txt_UserName != null && Txt_UserName.Text == rd[0] as string)
                {
                    XtraMessageBox.Show("GİRİLEN KULLANICI ADI DAHA ÖNCE TANIMLANMIŞ TEKRAR GİRİNİZ !!",
                        "HATALI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_UserName.Text = string.Empty;
                    Txt_UserName.Focus();
                    rd.Close();
                    db.Close();
                    return;
                }
            }
            rd.Close();
            db.Close();


            //KAYIT ET
            db.Open();
            SqlCommand cmd2 = new("insert into Tbl_Login values (@p1,@p2,@p3,@p4,@p5)", db);
            cmd2.Parameters.AddWithValue("@p1", Txt_UserName.Text);
            cmd2.Parameters.AddWithValue("@p2", Txt_Password.Text);
            cmd2.Parameters.AddWithValue("@p3", Txt_NameSurname.Text);
            cmd2.Parameters.AddWithValue("@p4", Txt_Question.Text);
            cmd2.Parameters.AddWithValue("@p5", Txt_Result.Text);
            cmd2.ExecuteNonQuery();
            db.Close();
            XtraMessageBox.Show("KAYIT İŞLEMİ BAŞARILI !!", "BAŞARILI", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Application.Restart();
        }
    }
}