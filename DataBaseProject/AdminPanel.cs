using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProject
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Assosicate_BTN_Click(object sender, EventArgs e)
        {
            using (AdminPanel_Assosicate Panel = new AdminPanel_Assosicate())
            {
                this.Hide();
                Panel.ShowDialog();
                this.Show();
            }
        }

        private void Add_ExerciseBTN_Click(object sender, EventArgs e)
        {
            using (AdminPanel_Exercise Panel = new AdminPanel_Exercise())
            {
                this.Hide();
                Panel.ShowDialog();
                this.Show();
            }
        }

        private void Add_MuscleBTN_Click(object sender, EventArgs e)
        {
            using (AdminPanel_Muscle Panel = new AdminPanel_Muscle())
            {
                this.Hide();
                Panel.ShowDialog();
                this.Show();
            }
        }

        private void FoodBTN_Click(object sender, EventArgs e)
        {
            using (AdminPanel_Foods Panel = new AdminPanel_Foods())
            {   
                this.Hide();
                Panel.ShowDialog();
                this.Show();
            }
        }
    }
}
