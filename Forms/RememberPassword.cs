using DevExpress.XtraEditors;
using System.Windows.Forms;
namespace FormStudent.Forms
{
    public partial class RememberPassword : Form
    {
        public RememberPassword()
        {
            InitializeComponent();
        }
        private string Result = string.Empty;
        public string PasswordReturn = string.Empty;
        private Class.RememberPassword eRememberPassword = new();
        void Control()
        {
            eRememberPassword.Control(Txt_Username, Txt_NameSurname);
            if (!string.IsNullOrEmpty(eRememberPassword.Result[0]) ||
                !string.IsNullOrEmpty(eRememberPassword.Result[1]))
            {
                Txt_Question.Text = eRememberPassword.Result[0];
                Result = eRememberPassword.Result[1];
                groupControl1.Visible = true;
                Txt_Username.Enabled = false;
                Txt_NameSurname.Enabled = false;
                Txt_Result.Focus();
            }
        }
        private void RememberPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        private void Txt_Username_EditValueChanged(object sender, System.EventArgs e)
        {
            Control();
        }
        private void Txt_NameSurname_EditValueChanged(object sender, System.EventArgs e)
        {
            Control();
        }
        private void RememberPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void Txt_Result_EditValueChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(eRememberPassword.ControlResult(Txt_Result)))
            {
                XtraMessageBox.Show($"ŞİFRENİZ= {eRememberPassword.ControlResult(Txt_Result)}", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PasswordReturn = eRememberPassword.ControlResult(Txt_Result);
                this.Close();
            }
        }
    }
}