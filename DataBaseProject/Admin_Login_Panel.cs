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
    public partial class Admin_Login_Panel : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("server=localHost; port=5432;" +
            "Database=Muscles; user Id=postgres; password=112358");
        public Admin_Login_Panel()
        {
            InitializeComponent();
        }

        private void Sign_inBTN_Click(object sender, EventArgs e)
        {

            conn.Close();
            conn.Open();
            string name = NameTB.Text;
            string password = PassTB.Text;


            string str = "select * from public.admin where admin.name=@p1 and admin.password=@p2";

            NpgsqlCommand comm = new NpgsqlCommand(str, conn);

            comm.Parameters.AddWithValue("@p1", name);
            comm.Parameters.AddWithValue("@p2", password);

            NpgsqlDataReader npgsqlDataReader = comm.ExecuteReader();
            if (npgsqlDataReader.Read())
            {
                using (AdminPanel Panel = new AdminPanel())
                {
                    this.Hide();
                    Panel.ShowDialog();
                    NameTB.Clear();
                    PassTB.Clear();
                    this.Show();

                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı/Şifre Yanlış", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }
    }
}
