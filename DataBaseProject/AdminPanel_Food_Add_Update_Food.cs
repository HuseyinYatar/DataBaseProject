using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Npgsql;

namespace DataBaseProject
{
    public partial class AdminPanel_Food_Add_Update_Food : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; Database=Muscles; User ID=postgres; Password=112358;");

        public char choice;
        public AdminPanel_Food_Add_Update_Food()
        {
            InitializeComponent();
        }

        private void AdminPanel_Add_Update_Food_Load(object sender, EventArgs e)
        {
            string food_quer = "select * from only food";


            NpgsqlDataAdapter npgsqlDataAdapter_curr_f = new NpgsqlDataAdapter(food_quer, conn);
            DataTable dataTable_cf = new DataTable();
            npgsqlDataAdapter_curr_f.Fill(dataTable_cf);
            Curr_Food_CB.DisplayMember = "name";
            Curr_Food_CB.ValueMember = "name";
            Curr_Food_CB.DataSource = dataTable_cf;
        }

        private void OK_BTN_Click(object sender, EventArgs e)
        {
            if (choice == 'I')
            {
                conn.Close();
                conn.Open();
                short Satured_Fat = short.Parse(Satur_FatTB.Text);
                short Unsatured_Fat = short.Parse(UnSatur_TB.Text);

                short Other_Aminos = short.Parse(Other_AminosTB.Text);
                short BCAA = short.Parse(BCAATB.Text);

                short Sugar = short.Parse(SugarTB.Text);
                short Carb = short.Parse(CarbTB.Text);
           
                string query =
                    "insert into food (name) values(@name);" +
                    "select fat_calorie_calc(@name, @satured, @unsatred);" +
                    "select protein_calorie_calc(@name, @bcaa, @otheraminos);" +
                    "select carbohydrate_calorie_calc(@name, @sugar, @carb);"+
                    "select food_calorie_calc(@name);";

                    ;
                string str =
                "insert into food (name) values(@name);" +
                "insert into fat (name,satured_fat,unsatured_fat) values(@name,@satured,@unsatred);" +
                "insert into carbohydrate (name,carb,sugar)  values(@name,@carb,@sugar);" +
                "insert into protein(name,otheraminos,bcaa) values(@name,@otheraminos,@bcaa);"

             ;

                //Benim Burda Gramları alıp Makroların değerleriyle çarpıp herbirisine eklemem gerekiyor
                NpgsqlCommand comm = new NpgsqlCommand(query, conn);

                comm.Parameters.AddWithValue("@name", FoodTB.Text);
                comm.Parameters.AddWithValue("@satured", Satured_Fat);
                comm.Parameters.AddWithValue("@unsatred", Unsatured_Fat);

                comm.Parameters.AddWithValue("@otheraminos", Other_Aminos);
                comm.Parameters.AddWithValue("@bcaa", BCAA);

                comm.Parameters.AddWithValue("@carb", Carb);
                comm.Parameters.AddWithValue("@sugar", Sugar);


                comm.ExecuteNonQuery();


                conn.Close();
                MessageBox.Show("Yemek Kayıt Başarıyla Tamamlandı", "Yemek Kayıt İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
             
                conn.Close();
                conn.Open();
                short Satured_Fat = short.Parse(Satur_FatTB.Text);
                short Unsatured_Fat = short.Parse(UnSatur_TB.Text);


                short Other_Aminos = short.Parse(Other_AminosTB.Text);
                short BCAA = short.Parse(BCAATB.Text);

                short Sugar = short.Parse(Other_AminosTB.Text);
                short Carb = short.Parse(Other_AminosTB.Text);
                string str =

                "update fat set macros=(@satured+@unsatred)*9,satured_fat=@satured,unsatured_fat=@unsatred  where name=@name;" +
                "update carbohydrate set macros=(@carb+@sugar)*4,carb=@carb,sugar=@sugar   where name=@name;" +
                "update protein set macros=(@otheraminos+@bcaa)*4,otheraminos=@otheraminos,bcaa=@bcaa  where name=@name;";





                NpgsqlCommand comm = new NpgsqlCommand(str, conn);
                comm.Parameters.AddWithValue("@name", Curr_Food_CB.SelectedValue.ToString());

                comm.Parameters.AddWithValue("@satured", Satured_Fat);
                comm.Parameters.AddWithValue("@unsatred", Unsatured_Fat);

                comm.Parameters.AddWithValue("@otheraminos", Other_Aminos);
                comm.Parameters.AddWithValue("@bcaa", BCAA);

                comm.Parameters.AddWithValue("@carb", Carb);
                comm.Parameters.AddWithValue("@sugar", Sugar);

                comm.ExecuteNonQuery();


                conn.Close();
                MessageBox.Show("Yemek Güncelleme Başarıyla Tamamlandı", "Yemek Güncelleme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }


    }
}
