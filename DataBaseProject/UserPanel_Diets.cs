using System;
using System.Collections;
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
    public partial class UserPanel_Diets : Form
    {
        public UserPanel_Diets()
        {
            InitializeComponent();
        }
        public string username;
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Muscles; User ID=postgres; Password=112358;");
        private string food_name;

        private void  Reaming_Cal_LBL_Updater()
        {
            conn.Close();
            conn.Open();
            string labelquer = "select cal from user_reaming_calorie" +
                         " where " +
                         "user_id=(select person_id from \"user\" where \"user\".name=@user_name) ";

            NpgsqlCommand command = new NpgsqlCommand(labelquer, conn);
            command.Parameters.AddWithValue("@user_name", username);
            var result = command.ExecuteScalar();
            cal_Value_LBL.Text = result.ToString();
            conn.Close();
        }
        private void UserPanel_Diets_Load(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string quer =
             "select  food.name as \"Name (100g)\",fat.satured_fat as \"Satured Fat\",fat.unsatured_fat as \"Unsatured Fat\",carbohydrate.carb as \"Carb\",carbohydrate.sugar as \"Sugar\",protein.bcaa as \"BCAA\",protein.otheraminos as \"Other Aminos\",food.macros as \"Calorie\" from only food inner join protein on food.food_id = protein.food_id inner join carbohydrate on carbohydrate.food_id = food.food_id inner join fat on fat.food_id = food.food_id\r\n";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(quer, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Diet_DG.DataSource = ds.Tables[0];


            string labelquer = "select cal from user_reaming_calorie" +
                " where " +
                "user_id=(select person_id from \"user\" where \"user\".name=@user_name) ";

            NpgsqlCommand command = new NpgsqlCommand(labelquer, conn);
            command.Parameters.AddWithValue("@user_name", username);
            var result = command.ExecuteScalar();
            cal_Value_LBL.Text = result.ToString();
            conn.Close();


            try
            {
                conn.Open();
                string user_diets_quer = " insert into user_diets(user_id) values((select person_id from \"user\" where \"user\".name=@user_name));";

                NpgsqlCommand usercommand = new NpgsqlCommand(user_diets_quer, conn);
                usercommand.Parameters.AddWithValue("@user_name", username);
                usercommand.ExecuteScalar();
                conn.Close();
            } catch { };
   

        }
        public int i = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string quer =
             "select  food.name as \"Name\",fat.satured_fat as \"Satured Fat\",fat.unsatured_fat as \"Unsatured Fat\",carbohydrate.carb as \"Carb\",carbohydrate.sugar as \"Sugar\",protein.bcaa as \"BCAA\",protein.otheraminos as \"Other Aminos\",food.macros as \"Calorie\" from only food inner join protein on food.food_id = protein.food_id inner join carbohydrate on carbohydrate.food_id = food.food_id inner join fat on fat.food_id = food.food_id\r\n where food.name like'"+textBox1.Text+"%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(quer, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Diet_DG.DataSource = ds.Tables[0];
            conn.Close();
        }

      

        private void Delete_Food_Click(object sender, EventArgs e)
        {
            using (UserPanel_Diets_List panel = new UserPanel_Diets_List())
            {
                panel.choice = 2;
                panel.username = this.username;
                this.Hide();
                panel.ShowDialog();
                Reaming_Cal_LBL_Updater();
                this.Show();
            }
        }

        private void Diet_DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;

            food_name = Diet_DG.Rows[selectedRowIndex].Cells[0].Value.ToString();
        }

        private void Add_FoodBTN_Click(object sender, EventArgs e)
        {
           try
            {
                int gram = 0;
                using (UserPanel_Diets_Add_Update panel = new UserPanel_Diets_Add_Update())
                {
                    panel.ShowDialog();
                    if (panel.Gram_TB.Text != " ")
                        gram = Int16.Parse(panel.Gram_TB.Text);
                }

                conn.Close();
                conn.Open();
                string str =
                 "INSERT INTO user_diets_food (diet_id, food_id, gram)\r\n" +
                 "SELECT \r\n    " +
                 "(select id from user_diets where user_diets.user_id=(select person_id from \"user\" where \"user\".name=@user_name)\r\n)," +
                 "\r\n    (SELECT food_id FROM only food WHERE food.name = @food_name),\r\n" +
                 "    @gram;\r\n";
                NpgsqlCommand comm = new NpgsqlCommand(str, conn);

                comm.Parameters.AddWithValue("@food_name", food_name);
                comm.Parameters.AddWithValue("@user_name", username);
                comm.Parameters.AddWithValue("@gram", gram);
                comm.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Yemek Başarıyla Eklendi", "Yemek Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reaming_Cal_LBL_Updater();
            }
            catch
            {
                MessageBox.Show("Var olan Yemek Tekrar Eklenemez(Güncelleme Yapın.)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void List_BTN_Click(object sender, EventArgs e)
        {
            using (UserPanel_Diets_List panel= new UserPanel_Diets_List())
            {
                panel.username = this.username;
                this.Hide();
                panel.ShowDialog();
            Reaming_Cal_LBL_Updater();
                this.Show();
            }
        }

        private void cal_Value_LBL_Click(object sender, EventArgs e)
        {

        }

        private void Update_BTN_Click(object sender, EventArgs e)
        {
            using (UserPanel_Diets_List panel = new UserPanel_Diets_List())
            {
                panel.choice = 1;
                panel.username = this.username;
                this.Hide();
                panel.ShowDialog();
                Reaming_Cal_LBL_Updater();
                this.Show();
            }
        }

        private void Diet_DG_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          
                if (
                    (Diet_DG.Columns[e.ColumnIndex].Name == "Satured Fat" ||
                    Diet_DG.Columns[e.ColumnIndex].Name == "Unsatured Fat" ||
                    Diet_DG.Columns[e.ColumnIndex].Name == "Carb" ||
                    Diet_DG.Columns[e.ColumnIndex].Name == "Sugar" ||
                    Diet_DG.Columns[e.ColumnIndex].Name == "Other Aminos" ||
                    Diet_DG.Columns[e.ColumnIndex].Name == "BCAA") &&
                     e.Value != null
              )
                {
                    e.Value = e.Value.ToString() + "g";
                }
                else if (Diet_DG.Columns[e.ColumnIndex].Name == "Calorie" && e.Value != null)
                {
                    e.Value = e.Value.ToString() + "cal";

                }
        }
    }
}
