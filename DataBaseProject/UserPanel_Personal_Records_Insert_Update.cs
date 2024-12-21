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
    public partial class UserPanel_Personal_Records_Insert_Update : Form
    {
        public UserPanel_Personal_Records_Insert_Update()
        {
            InitializeComponent();
        }
        public char choice;
        public string user;
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Muscles; User ID=postgres; Password=112358;");
        private void UserPanel_Personal_Records_Insert_Update_Load(object sender, EventArgs e)
        {
            string exercises = "select *from exercise";
            NpgsqlDataAdapter npgsqlDataAdapter_exercise = new NpgsqlDataAdapter(exercises, conn);
            DataTable dataTable_e = new DataTable();
            npgsqlDataAdapter_exercise.Fill(dataTable_e);
            ExerciseCB.DisplayMember = "exercise_name";
            ExerciseCB.ValueMember = "exercise_id";
            ExerciseCB.DataSource = dataTable_e;
        }

        private void OK_BTN_Click(object sender, EventArgs e)
        {
            if (choice == 'I')
            {
                conn.Close();
                conn.Open();


                string str =
                "INSERT INTO user_exercise (person_id, exercise_id, personal_record)" +
                "SELECT    person_id, " +
                "@exercise_id, " +
                "@personal " +
                "FROM " +
                "public.user  " +
                "WHERE     name = @user;";
                NpgsqlCommand comm = new NpgsqlCommand(str, conn);

                comm.Parameters.AddWithValue("@user", label1.Text);
                comm.Parameters.AddWithValue("@exercise_id", ExerciseCB.SelectedValue);
                comm.Parameters.AddWithValue("@personal", Int16.Parse(Pr_TB.Text));
                comm.ExecuteNonQuery();


                conn.Close();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                conn.Close();
                conn.Open();
                string str =
             "UPDATE user_exercise " +
             "SET  personal_record = @personal " +
             "FROM public.user " +
             "WHERE public.user.name = @user and user_exercise.exercise_id = @exercise_id;";
                NpgsqlCommand comm = new NpgsqlCommand(str, conn);

                comm.Parameters.AddWithValue("@user", label1.Text);
                comm.Parameters.AddWithValue("@exercise_id", ExerciseCB.SelectedValue);
                comm.Parameters.AddWithValue("@personal", Int16.Parse(Pr_TB.Text));
                comm.ExecuteNonQuery();


                conn.Close();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


    }
}
