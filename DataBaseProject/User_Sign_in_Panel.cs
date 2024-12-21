using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;

namespace DataBaseProject
{
    public partial class User_Sign_in_Panel : Form
    {

        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432;" +
            "Database=Muscles; user Id=postgres; password=112358");
        public User_Sign_in_Panel()
        {
            InitializeComponent();
        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string str =
              "insert into public.user (name, password, weight, height, age) values (@name, @pass, @wei, @hei, @age);" +
              "SELECT user_daily_calorie_calc(u) FROM \"user\" u WHERE name = @name;" +
              "insert into user_reaming_calorie (user_id, cal) " +
              "values ((select person_id from \"user\" where name = @name), " +
              "(select cal from user_calories where user_id = (select person_id from \"user\" where name = @name)));";
            NpgsqlCommand comm = new NpgsqlCommand(str, conn);

            comm.Parameters.AddWithValue("@name", NameTB.Text);
            comm.Parameters.AddWithValue("@pass", PasswordTB.Text);
            comm.Parameters.AddWithValue("@wei", Int16.Parse(WeightTB.Text));
            comm.Parameters.AddWithValue("@hei", Int16.Parse(HeightTB.Text));
            comm.Parameters.AddWithValue("@age", Int16.Parse(AgeTB.Text));
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kullanıcı Kayıt İşlemi Başarıyla Tamamlandı", "Kullanıcı Kayıt İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
