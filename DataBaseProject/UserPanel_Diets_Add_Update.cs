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
    public partial class UserPanel_Diets_Add_Update : Form
    {
        public UserPanel_Diets_Add_Update()
        {
            InitializeComponent();
        }
        public char choice;
        private void UserPanel_Diets_Add_Update_Load(object sender, EventArgs e)
        {

        }

        private void Gram_TB_KeyDown(object sender, KeyEventArgs e)
        {
             
            if(e.KeyCode==Keys.Enter)
                this.Close();
        }

        private void Gram_TB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
