using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DataBaseProject
{
    public partial class Main : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432;" +
            "Database=Muscles; user Id=postgres; password=112358");
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sign_UP_BTN_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string name = Name_TB.Text;
            string password = Password_TB.Text;

            
            string str = "select * from public.user where \"user\".name=@p1 and \"user\".password=@p2";
            NpgsqlCommand comm = new NpgsqlCommand(str, conn);

            comm.Parameters.AddWithValue("@p1", name);
            comm.Parameters.AddWithValue("@p2", password);

            NpgsqlDataReader npgsqlDataReader = comm.ExecuteReader();
            if (npgsqlDataReader.Read())
            {
                
                using (UserPanel Panel = new UserPanel())
                {
                    Panel.username = name;
                    this.Hide();
                    Panel.ShowDialog();
                    Name_TB.Clear();
                    Password_TB.Clear();
                    this.Show();

                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı/Şifre Yanlış", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }

        private void Sign_In_BTN_Click(object sender, EventArgs e)
        {
            using (User_Sign_in_Panel Panel = new User_Sign_in_Panel())
            {
                this.Hide();
                Panel.ShowDialog();
                this.Show();

            }
        }

        private void AdminBTN_Click(object sender, EventArgs e)
        {
            using (Admin_Login_Panel Panel = new Admin_Login_Panel())
            {
                this.Hide();
                Panel.ShowDialog();
                this.Show();

            }
        }
    }
}
