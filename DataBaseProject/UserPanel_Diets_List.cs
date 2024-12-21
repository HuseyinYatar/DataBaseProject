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
    public partial class UserPanel_Diets_List : Form
    {
        public UserPanel_Diets_List()
        {
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Muscles; User ID=postgres; Password=112358;");
        public string username;
        public string selected_food_name;
        public int choice;
        private int gram;

        private void UserPanel_Diets_List_Load(object sender, EventArgs e)
        {

            conn.Open();

            string quer =
               "select * from get_user_diets_list((select person_id from \"user\" where \"user\".name =@username))\r\n";
            NpgsqlCommand cmd = new NpgsqlCommand(quer, conn);
            cmd.Parameters.AddWithValue("@username", username);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Diet_DG.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void Diet_DG_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((Diet_DG.Columns[e.ColumnIndex].Name == "Fat" || Diet_DG.Columns[e.ColumnIndex].Name == "Protein" || Diet_DG.Columns[e.ColumnIndex].Name == "Carb") && e.Value != null)
            {
                e.Value = e.Value.ToString() + "gr";
            }
        }

        private void Diet_DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            selected_food_name = Diet_DG.Rows[row].Cells[0].Value.ToString();

            if (choice == 1)
            {
                using (UserPanel_Diets_Add_Update panel = new UserPanel_Diets_Add_Update())
                {
                    conn.Open();
                    panel.ShowDialog();
                    gram = Int16.Parse(panel.Gram_TB.Text);

                    string querry =
                  "update user_diets_food set gram=@gram where diet_id=" +
                  "(select id from user_diets where user_id=" +
                  "(select person_id from \"user\" where \"user\".name=@user_name))" +
                  "and " +
                  "food_id=" +
                  "(select food_id from only food where name=@food_name)";

                    NpgsqlCommand comm = new NpgsqlCommand(querry, conn);


                    comm.Parameters.AddWithValue("@food_name", selected_food_name);
                    comm.Parameters.AddWithValue("@user_name", username);
                    comm.Parameters.AddWithValue("@gram", gram);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Güncelleme Başarıyla Tamamlandı", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Open();

                    string quer =
                       "select * from get_user_diets_list((select person_id from \"user\" where \"user\".name =@username))\r\n";
                    NpgsqlCommand cmd = new NpgsqlCommand(quer, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    Diet_DG.DataSource = ds.Tables[0];

                    conn.Close();
                }
            }
                 if (choice == 2)
                {
                    conn.Open();


                    string quer =
                        "delete from user_diets_food where user_diets_food.diet_id=" +
                        "(select id from user_diets where user_diets.user_id=" +
                        "(select person_id from \"user\" where \"user\".name=@user_name))" +
                        "and " +
                        "user_diets_food.food_id=" +
                        "(select food_id from only food where food.name=@food_name)";


                    NpgsqlCommand comm = new NpgsqlCommand(quer, conn);


                    comm.Parameters.AddWithValue("@food_name", selected_food_name);
                    comm.Parameters.AddWithValue("@user_name", username);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Silme Başarıyla Tamamlandı", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                conn.Open();

                string quer2 =
                   "select * from get_user_diets_list((select person_id from \"user\" where \"user\".name =@username))\r\n";
                NpgsqlCommand cmd = new NpgsqlCommand(quer2, conn);
                cmd.Parameters.AddWithValue("@username", username);

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                Diet_DG.DataSource = ds.Tables[0];

                conn.Close();
            }

        }
    }
}
