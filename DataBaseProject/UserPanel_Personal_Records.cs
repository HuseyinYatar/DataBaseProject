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
    public partial class UserPanel_Personal_Records : Form
    {
        public UserPanel_Personal_Records()
        {
            InitializeComponent();
        }
        public string username;
        string exercise_name;
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Muscles; User ID=postgres; Password=112358;");


        private void Add_PR_BTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show(username);
            using (UserPanel_Personal_Records_Insert_Update Panel = new UserPanel_Personal_Records_Insert_Update())
            {
                Panel.label1.Text = username;
                Panel.choice = 'I';
                this.Hide();
                Panel.ShowDialog();
                this.Show();
                Panel.user = username;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UserPanel_Personal_Records_Insert_Update Panel = new UserPanel_Personal_Records_Insert_Update())
            {
                Panel.label1.Text = username;
                Panel.choice = 'U';
                this.Hide();
                Panel.ShowDialog();
                this.Show();
                Panel.user = username;
            }
        }

        private void List_BTN_Click(object sender, EventArgs e)
        {

            conn.Close();
            conn.Open();

            string quer =
           "select exercise_name as \"Exercise Name\",user_exercise.personal_record as \"Personal Record\" from user_exercise\r\ninner join exercise on exercise.exercise_id=user_exercise.exercise_id\r\nwhere person_id=\r\n(select person_id from \"user\" where \"user\".name=@user_name)";
             NpgsqlCommand comm = new NpgsqlCommand(quer, conn);
            comm.Parameters.AddWithValue("@user_name", username);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);

            PR_DG.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void PR_DG_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (PR_DG.Columns[e.ColumnIndex].Name == "Personal Record" && e.Value != null)
            {
                e.Value = e.Value.ToString() + "KG";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string quer = "delete from user_exercise where person_id=(select person_id from public.\"user\" where public.\"user\".name=@username)and exercise_id=(select exercise_id from exercise where exercise_name=@exercise_name)";

                NpgsqlCommand comm = new NpgsqlCommand(quer, conn);

                comm.Parameters.AddWithValue("@username",username);
                comm.Parameters.AddWithValue("@exercise_name", exercise_name);
                comm.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("İlişki Başarıyla Silindi.", "Bilgilendirme");


                conn.Close();
                conn.Open();

                string quer2 =
               "select exercise_name as \"Exercise Name\",user_exercise.personal_record as \"Personal Record\" from user_exercise\r\ninner join exercise on exercise.exercise_id=user_exercise.exercise_id\r\nwhere person_id=\r\n(select person_id from \"user\" where \"user\".name=@user_name)";
                NpgsqlCommand comm2 = new NpgsqlCommand(quer2, conn);
                comm2.Parameters.AddWithValue("@user_name", username);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm2);
                DataSet ds = new DataSet();
                da.Fill(ds);

                PR_DG.DataSource = ds.Tables[0];
                conn.Close();
            }
            catch
            {
                MessageBox.Show("İlişki  Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
}

        private void PR_DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;

            exercise_name = PR_DG.Rows[row_index].Cells[0].Value.ToString();
        }

        private void UserPanel_Personal_Records_Load(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();

            string quer =
           "select exercise_name as \"Exercise Name\",user_exercise.personal_record as \"Personal Record\" from user_exercise\r\ninner join exercise on exercise.exercise_id=user_exercise.exercise_id\r\nwhere person_id=\r\n(select person_id from \"user\" where \"user\".name=@user_name)";
            NpgsqlCommand comm = new NpgsqlCommand(quer, conn);
            comm.Parameters.AddWithValue("@user_name", username);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);

            PR_DG.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void UserPanel_Personal_Records_VisibleChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();

            string quer =
           "select exercise_name as \"Exercise Name\",user_exercise.personal_record as \"Personal Record\" from user_exercise\r\ninner join exercise on exercise.exercise_id=user_exercise.exercise_id\r\nwhere person_id=\r\n(select person_id from \"user\" where \"user\".name=@user_name)";
            NpgsqlCommand comm = new NpgsqlCommand(quer, conn);
            comm.Parameters.AddWithValue("@user_name", username);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);

            PR_DG.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
