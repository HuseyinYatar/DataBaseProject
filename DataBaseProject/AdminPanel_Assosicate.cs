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
    public partial class AdminPanel_Assosicate : Form
    {
        public AdminPanel_Assosicate()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Muscles; User ID=postgres; Password=112358;");
        public string Exercise_name;
        public string Muscle_name;
      


        private void List_BTN_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string quer = "select exercise_name as \"Exercise Name\"" +
                ",first as \"Primary Group\"" +
                ",second as \"Seconder Group\"" +
                " from exercise_musclegroup inner join musclegroup" +
                " on " +
                "musclegroup.muscle_id = exercise_musclegroup.muscle_id" +
                "\tinner join exercise on " +
                "exercise.exercise_id = exercise_musclegroup.exercise_id";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(quer, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Assosicate_DG.DataSource = ds.Tables[0];
            conn.Close();

        }

        private void Insert_BTN_Click(object sender, EventArgs e)
        {


            using (AdminPanel_Assosicate_Insert_Update inputForm = new AdminPanel_Assosicate_Insert_Update())
            {
                inputForm.choice = 'I';
                inputForm.ExerciseCB.Visible = true;
                inputForm.ExerciseLBL.Visible= true;    
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Kayıt Başarıyla Eklendi");
                }
                else
                {
                    MessageBox.Show("Kullanıcı işlemden vazgeçti.", "Bilgi");
                }
            }

        }

        private void Update_BTN_Click(object sender, EventArgs e)
        {
            using (AdminPanel_Assosicate_Insert_Update input = new AdminPanel_Assosicate_Insert_Update())
            {
                input.choice = 'U';
                input.Curr_Exercise_NameCB.Visible = true;
                input.Exercise_CR_LBL.Visible= true;


                if (input.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Kayıt Başarıyla Güncellendi");
                }
                else
                {
                    MessageBox.Show("Kullanıcı işlemden vazgeçti.", "Bilgi");
                }
            }
        }



        private void Admin_Panel_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Delete_BTN_Click(object sender, EventArgs e)
        {

          try
            {
                conn.Open();
                string quer = "delete from exercise_musclegroup where exercise_musclegroup.exercise_id=(select exercise_id from exercise where exercise_name=@p1) and exercise_musclegroup.muscle_id=(select muscle_id from musclegroup where muscle_name=@p2)";

                NpgsqlCommand comm = new NpgsqlCommand(quer, conn);

                comm.Parameters.AddWithValue("@p1", Exercise_name);
                comm.Parameters.AddWithValue("@p2", Muscle_name);
                comm.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("İlişki Başarıyla Silindi.", "Bilgilendirme");
                List_BTN_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("İlişki  Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Assosicate_DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int selectedRowIndex = e.RowIndex;
            
            Exercise_name = Assosicate_DG.Rows[selectedRowIndex].Cells[0].Value.ToString();
             Muscle_name = Assosicate_DG.Rows[selectedRowIndex].Cells[1].Value.ToString();
           
            
        }

      
    }
}
