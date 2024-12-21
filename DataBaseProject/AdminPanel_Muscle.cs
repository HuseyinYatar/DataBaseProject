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
    public partial class AdminPanel_Muscle : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Muscles; User ID=postgres; Password=112358;");

        public AdminPanel_Muscle()
        {
            InitializeComponent();
        }

        private void OK_BTN_Click(object sender, EventArgs e)
        {
            char muscle_type = '\0';
            if (Upper_RDBTN.Checked)
                muscle_type = 'U';
            else if (Lower_RDBTN.Checked)
                muscle_type = 'L';
            conn.Open();
            string str = "insert into musclegroup (muscle_name,muscle_type) values(@p1,@p2)";
            NpgsqlCommand comm = new NpgsqlCommand(str, conn);
            comm.Parameters.AddWithValue("@p1", Muscle_TB.Text);
            comm.Parameters.AddWithValue("@p2", muscle_type);
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kas Grubu Kayıtı Başarıyla Tamamlandı", "Kas Grubu Kayıt İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
