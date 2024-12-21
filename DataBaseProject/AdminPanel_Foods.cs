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
    public partial class AdminPanel_Foods : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Muscles; User ID=postgres; Password=112358;");
        public string Food_Name;
        public AdminPanel_Foods()
        {
            InitializeComponent();
        }

        private void FoodBTN_Click(object sender, EventArgs e)
        {
            using (AdminPanel_Food_Add_Update_Food Panel = new AdminPanel_Food_Add_Update_Food())
            {

                Panel.choice = 'I';
                this.Hide();
                Panel.ShowDialog();
                this.Show();
            }
        }

        private void Update_FoodBTN_Click(object sender, EventArgs e)
        {
            using (AdminPanel_Food_Add_Update_Food Panel = new AdminPanel_Food_Add_Update_Food())
            {
                Panel.Curr_FoodLBL.Visible = true;
                Panel.Curr_Food_CB.Visible = true;
                Panel.FoodLBL.Visible = false;
                Panel.FoodTB.Visible = false;
                Panel.choice = 'U';
                this.Hide();
                Panel.ShowDialog();
                this.Show();
            }
        }

        private void Delete_Food_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
                conn.Open();
                string quer = "delete from food where food.name=@name";

                NpgsqlCommand comm = new NpgsqlCommand(quer, conn);

                comm.Parameters.AddWithValue("@name", Food_Name);
                comm.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Yemek Başarıyla Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List_BTN_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Yemek  Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void List_BTN_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            string quer =
             "select  food.name as \"Name\",fat.satured_fat as \"Satured Fat\",fat.unsatured_fat as \"Unsatured Fat\",carbohydrate.carb as \"Carb\",carbohydrate.sugar as \"Sugar\",protein.bcaa as \"BCAA\",protein.otheraminos as \"Other Aminos\",food.macros as \"Calorie\" from only food inner join protein on food.food_id = protein.food_id inner join carbohydrate on carbohydrate.food_id = food.food_id inner join fat on fat.food_id = food.food_id\r\n";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(quer, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            Food_DG.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Food_DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;

            Food_Name = Food_DG.Rows[selectedRowIndex].Cells[0].Value.ToString();
        }

        private void Food_DG_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (
                (Food_DG.Columns[e.ColumnIndex].Name == "Satured Fat" ||
                Food_DG.Columns[e.ColumnIndex].Name == "Unsatured Fat" ||
                Food_DG.Columns[e.ColumnIndex].Name == "Carb" ||
                Food_DG.Columns[e.ColumnIndex].Name == "Sugar" ||
                Food_DG.Columns[e.ColumnIndex].Name == "Other Aminos" ||
                Food_DG.Columns[e.ColumnIndex].Name == "BCAA" )&&
                 e.Value != null
          )
            {
                e.Value = e.Value.ToString() + "g";
            }
            else if (Food_DG.Columns[e.ColumnIndex].Name=="Calorie"&&e.Value!=null)
            {
                e.Value = e.Value.ToString() + "cal";

            }
        }
    }
}
