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
    public partial class AdminPanel_Assosicate_Insert_Update : Form
    {
        public char choice;
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Muscles; User ID=postgres; Password=112358;");
        public AdminPanel_Assosicate_Insert_Update()
        {
            InitializeComponent();
        }

        private void Temp_Load(object sender, EventArgs e)
        {

            string new_exercise_name = "select * from exercise";
            string curr_exercise_name = "select exercise_id,exercise_name from exercise" +
                " where" +
                " exercise_id in (select exercise_id from exercise_musclegroup)";

            string seconder_muscle_quer = "select * from musclegroup";
            string musclename_quer = "select * from musclegroup";



            NpgsqlDataAdapter npgsqlDataAdapter_curr_exercise = new NpgsqlDataAdapter(curr_exercise_name, conn);
            DataTable dataTable_ce = new DataTable();
            npgsqlDataAdapter_curr_exercise.Fill(dataTable_ce);
            Curr_Exercise_NameCB.DisplayMember = "exercise_name";
            Curr_Exercise_NameCB.ValueMember = "exercise_id";
            Curr_Exercise_NameCB.DataSource = dataTable_ce;

            NpgsqlDataAdapter npgsqlDataAdapter_new_muscle= new NpgsqlDataAdapter(musclename_quer, conn);
            DataTable dataTable_nm = new DataTable();
            npgsqlDataAdapter_new_muscle.Fill(dataTable_nm);
            MuscleCB.DisplayMember = "muscle_name";
            MuscleCB.ValueMember = "muscle_name";
            MuscleCB.DataSource = dataTable_nm;


            NpgsqlDataAdapter npgsqlDataAdapter_new_exercise = new NpgsqlDataAdapter(new_exercise_name, conn);
            DataTable dataTable_ne = new DataTable();
            npgsqlDataAdapter_new_exercise.Fill(dataTable_ne);
            ExerciseCB.DisplayMember = "exercise_name";
            ExerciseCB.ValueMember = "exercise_id";
            ExerciseCB.DataSource = dataTable_ne;

            NpgsqlDataAdapter npgsqlDataAdapter_seconder_muscle= new NpgsqlDataAdapter(seconder_muscle_quer, conn);
            DataTable dataTable_sm= new DataTable();
            npgsqlDataAdapter_seconder_muscle.Fill(dataTable_sm);
            SeconderCB.DisplayMember = "muscle_name";
            SeconderCB.ValueMember = "muscle_name";
            SeconderCB.DataSource = dataTable_sm;

          

        }

        private void OK_BTN_Click(object sender, EventArgs e)
        {
            if (choice == 'I')
            {
                conn.Close();
                conn.Open();
                string str =
                  "INSERT INTO exercise_musclegroup (exercise_id, muscle_id, first, second)" +
                  "SELECT " +
                  "    e.exercise_id," +
                  "    m.muscle_id," +
                  "    @first AS first,    " +
                  "@second AS second FROM     exercise e JOIN     musclegroup m ON " +
                  "     e.exercise_id = @exercise " +
                  "AND m.muscle_name= @first;";
                NpgsqlCommand comm = new NpgsqlCommand(str, conn);
                
                comm.Parameters.AddWithValue("@first", MuscleCB.SelectedValue);
                comm.Parameters.AddWithValue("@second", SeconderCB.SelectedValue);
                comm.Parameters.AddWithValue("@exercise", ExerciseCB.SelectedValue);
                comm.ExecuteNonQuery();


                conn.Close();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {

                conn.Open();
                string str =
                "UPDATE exercise_musclegroup\r\nSET \r\n    first = @first,\r\n    second = @second,\r\n    muscle_id = (SELECT muscle_id FROM musclegroup WHERE muscle_name = @first),\r\n    exercise_id = @exerciseid\r\nWHERE \r\n    muscle_id = (SELECT muscle_id FROM exercise_musclegroup WHERE exercise_id = @exerciseid)\r\n    AND exercise_id = @exerciseid;";
                NpgsqlCommand comm = new NpgsqlCommand(str, conn);
                comm.Parameters.AddWithValue("@first", MuscleCB.SelectedValue);
                comm.Parameters.AddWithValue("@second", SeconderCB.SelectedValue);
                comm.Parameters.AddWithValue("@exerciseid", Curr_Exercise_NameCB.SelectedValue);
                comm.ExecuteNonQuery();


                conn.Close();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
