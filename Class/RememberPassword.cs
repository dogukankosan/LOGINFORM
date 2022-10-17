using DevExpress.XtraEditors;
using System.Data.SqlClient;
namespace FormStudent.Class
{
    internal class RememberPassword
    {
        private readonly SqlConnection db = new("Data Source=DOGUKAN\\SQLEXPRESS;Initial Catalog=deneme;Integrated Security=True");
        public string[] Result = new string[3];
        public void Control(TextEdit username, TextEdit namesurname)
        {
            if (!string.IsNullOrEmpty(username.Text) || !string.IsNullOrEmpty(namesurname.Text))
            {
                db.Open();
                SqlCommand cmd = new("select Question,Result,User_Password from Tbl_Login where User_Name=@p1 and NameSurname=@p2 ", db);
                cmd.Parameters.AddWithValue("@p1", username.Text);
                cmd.Parameters.AddWithValue("@p2", namesurname.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Result[0] = rd[0] as string;
                    Result[1] = rd[1] as string;
                    Result[2] = rd[2] as string;
                }
                rd.Close();
                db.Close();
            }
        }
        public string ControlResult(TextEdit result)
        {
            if (result.Text == Result[1])
                return Result[2];
            return null;
        }
    }
}