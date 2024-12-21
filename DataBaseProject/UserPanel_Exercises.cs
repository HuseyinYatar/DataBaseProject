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
    public partial class UserPanel_Exercises : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Muscles; User ID=postgres; Password=112358;");

        public UserPanel_Exercises()
        {
            InitializeComponent();
        }

        private void UserPanel_Exercises_Load(object sender, EventArgs e)
        {
            string muscle_group = "select * from musclegroup";
            NpgsqlDataAdapter npgsqlDataAdapter_curr_exercise = new NpgsqlDataAdapter(muscle_group, conn);
            DataTable dataTable_ce = new DataTable();
            npgsqlDataAdapter_curr_exercise.Fill(dataTable_ce);
            MuscleGroup_CB.DisplayMember = "muscle_name";
            MuscleGroup_CB.ValueMember = "muscle_id";
            MuscleGroup_CB.DataSource = dataTable_ce;
        }

        private void MuscleGroup_List_BTN_Click(object sender, EventArgs e)
        {
            if(Place_CB.SelectedIndex==0)
            {
                conn.Close();
                conn.Open();
                string quer = "SELECT exercise.exercise_name AS \"Exercise Name\", " +
              "equipment.name AS \"Equipment\", " +
              "exercise_musclegroup.first AS \"Primary Group\", " +
              "exercise_musclegroup.second AS \"Seconder Group\" " +
              "FROM exercise_musclegroup " +
              "INNER JOIN exercise ON exercise_musclegroup.exercise_id = exercise.exercise_id " +
              "INNER JOIN equipment ON exercise_musclegroup.exercise_id = equipment.exercise_fkey " +
              "WHERE  equipment.name='None' "+
                 "and exercise_musclegroup.muscle_id=" + MuscleGroup_CB.SelectedValue.ToString(); ;
                ;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(quer, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Exercises_DG.DataSource = ds.Tables[0];
                conn.Close();
            }
            else if(Place_CB.SelectedIndex==1)
            {
                conn.Close();
                conn.Open();
                string quer = "SELECT exercise.exercise_name AS \"Exercise Name\", " +
               "equipment.name AS \"Equipment\", " +
               "exercise_musclegroup.first AS \"Primary Group\", " +
               "exercise_musclegroup.second AS \"Seconder Group\" " +
               "FROM exercise_musclegroup " +
               "INNER JOIN exercise ON exercise_musclegroup.exercise_id = exercise.exercise_id " +
               "INNER JOIN equipment ON exercise_musclegroup.exercise_id = equipment.exercise_fkey " +
               "WHERE not equipment.name='None' "+
                  "and exercise_musclegroup.muscle_id=" + MuscleGroup_CB.SelectedValue.ToString(); ;
    
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(quer, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Exercises_DG.DataSource = ds.Tables[0];
                conn.Close();
            }
            else
            {

                conn.Close();
                conn.Open();
                string quer = "select exercise.exercise_name as \"Exercise Name\",first as \"Primary Group\",second as \"Seconder Group\",equipment.name as\"Equipment\" \r\n" +
                    "from exercise_musclegroup \r\n" +
                    "inner join exercise" +
                    "\r\non" +
                    "\r\nexercise.exercise_id = exercise_musclegroup.exercise_id" +
                    "\r\ninner join equipment\r\n" +
                    "on exercise_musclegroup.exercise_id=equipment.exercise_fkey" +
                    "\r\ninner join musclegroup\r\n" +
                    "on musclegroup.muscle_id = exercise_musclegroup.muscle_id\r\n" +
                    "where exercise_musclegroup.muscle_id=" + MuscleGroup_CB.SelectedValue.ToString();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(quer, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
               

                Exercises_DG.DataSource = ds.Tables[0];
                conn.Close();
            }

        }

        private void UB_BTN_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string quer = "select exercise_name as \"Exercise Name\",equipment.name as \"Equipment\",first as \"Primary Group\",second as \"Seconder Group\" from " +
                "exercise_musclegroup" +
                " \r\ninner join musclegroup on \r\n" +
                "exercise_musclegroup.muscle_id=musclegroup.muscle_id" +
                "\r\ninner join exercise on" +
                "\r\nexercise_musclegroup.exercise_id = exercise.exercise_id " +
                "inner join equipment on "+
                "\r\nexercise.exercise_id = equipment.exercise_fkey"+
                "\r\nwhere\r\n" +
                "musclegroup.muscle_type='U' "
            ;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(quer, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Exercises_DG.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void LW_BTN_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string quer = "select exercise_name as \"Exercise Name\",equipment.name as \"Equipment\",first as \"Primary Group\",second as \"Seconder Group\" from " +
                "exercise_musclegroup" +
                " \r\ninner join musclegroup on \r\n" +
                "exercise_musclegroup.muscle_id=musclegroup.muscle_id" +
                "\r\ninner join exercise on" +
                "\r\nexercise_musclegroup.exercise_id = exercise.exercise_id " +
                "inner join equipment on " +
                "\r\nexercise.exercise_id = equipment.exercise_fkey" +
                "\r\nwhere\r\n" +
                "musclegroup.muscle_type='L' "
            ;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(quer, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Exercises_DG.DataSource = ds.Tables[0];
            conn.Close();
        }
    }
}
