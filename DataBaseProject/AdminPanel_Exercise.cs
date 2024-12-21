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
 
    public partial class AdminPanel_Exercise : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Muscles; User ID=postgres; Password=112358;");

        public AdminPanel_Exercise()
        {
            InitializeComponent();
        }

        private void OK_BTN_Click(object sender, EventArgs e)
        {
            string equipment="";
            switch (Equipment_CB.SelectedIndex) {
                case 1:
                    {
                    equipment = "Dumbell";
                        break;
                    }
                
                case 2:
                    {
                        equipment = "Barbell";
                        break;
                    }
                case 3:
                    {
                        equipment = "Machine";
                        break;
                    }
                case -1:
                    {
                        equipment = "None";
                        break;
                    }
            }
            conn.Open();
            string str =
                "WITH new_exercise AS (\r\n    " +
                "INSERT INTO exercise (exercise_name) \r\n    " +
                "VALUES (@exercise_name) \r\n    RETURNING exercise_id\r\n)" +
                "\r\nINSERT INTO equipment (name, exercise_fkey)\r\n" +
                "VALUES (@equip, (SELECT exercise_id FROM new_exercise));";


            NpgsqlCommand comm = new NpgsqlCommand(str, conn);
            comm.Parameters.AddWithValue("@exercise_name", Exercise_TB.Text);
            comm.Parameters.AddWithValue("@equip",equipment);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Egzersiz Kayıtı Başarıyla Tamamlandı", "Egzersiz Kayıt İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
