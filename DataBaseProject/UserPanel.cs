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
    public partial class UserPanel : Form
    {
        public UserPanel()
        {
            InitializeComponent();
        }

        public string username;
      
        private void Exercises_BTN_Click(object sender, EventArgs e)
        {
            using (UserPanel_Exercises Panel = new UserPanel_Exercises())
            {
                this.Hide();
                Panel.ShowDialog();
                this.Show();
            }
        }

        private void PersonBTN_Click(object sender, EventArgs e)
        {
            using (UserPanel_Personal_Records Panel = new UserPanel_Personal_Records())
            {
                Panel.username = username;
                this.Hide();
                Panel.ShowDialog();
                this.Show();
            }



        }

        private void DietsBTN_Click(object sender, EventArgs e)
        {
            using (UserPanel_Diets Panel = new UserPanel_Diets())
            {
                Panel.username = username;
                this.Hide();
                Panel.ShowDialog();
                this.Show();
            }
        }
    }
}
