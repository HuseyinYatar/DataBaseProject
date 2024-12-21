namespace DataBaseProject
{
    partial class UserPanel_Diets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cal_LB = new System.Windows.Forms.Label();
            this.cal_Value_LBL = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Diet_DG = new System.Windows.Forms.DataGridView();
            this.Add_FoodBTN = new System.Windows.Forms.Button();
            this.Update_BTN = new System.Windows.Forms.Button();
            this.List_BTN = new System.Windows.Forms.Button();
            this.Delete_FoodBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Diet_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // Cal_LB
            // 
            this.Cal_LB.AutoSize = true;
            this.Cal_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cal_LB.Location = new System.Drawing.Point(1433, 90);
            this.Cal_LB.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            this.Cal_LB.Name = "Cal_LB";
            this.Cal_LB.Size = new System.Drawing.Size(514, 52);
            this.Cal_LB.TabIndex = 0;
            this.Cal_LB.Text = "Remaining Daily Calories";
            // 
            // cal_Value_LBL
            // 
            this.cal_Value_LBL.AutoSize = true;
            this.cal_Value_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cal_Value_LBL.Location = new System.Drawing.Point(1625, 193);
            this.cal_Value_LBL.Name = "cal_Value_LBL";
            this.cal_Value_LBL.Size = new System.Drawing.Size(136, 55);
            this.cal_Value_LBL.TabIndex = 1;
            this.cal_Value_LBL.Text = "0000";
            this.cal_Value_LBL.Click += new System.EventHandler(this.cal_Value_LBL_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1604, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 53);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Diet_DG
            // 
            this.Diet_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Diet_DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Diet_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Diet_DG.DefaultCellStyle = dataGridViewCellStyle2;
            this.Diet_DG.Location = new System.Drawing.Point(38, 45);
            this.Diet_DG.Name = "Diet_DG";
            this.Diet_DG.RowHeadersWidth = 62;
            this.Diet_DG.RowTemplate.Height = 28;
            this.Diet_DG.Size = new System.Drawing.Size(1389, 926);
            this.Diet_DG.TabIndex = 4;
            this.Diet_DG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Diet_DG_CellClick);
            this.Diet_DG.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Diet_DG_CellFormatting);
            // 
            // Add_FoodBTN
            // 
            this.Add_FoodBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_FoodBTN.Location = new System.Drawing.Point(1549, 417);
            this.Add_FoodBTN.Name = "Add_FoodBTN";
            this.Add_FoodBTN.Size = new System.Drawing.Size(312, 89);
            this.Add_FoodBTN.TabIndex = 8;
            this.Add_FoodBTN.Text = "Add Food";
            this.Add_FoodBTN.UseVisualStyleBackColor = true;
            this.Add_FoodBTN.Click += new System.EventHandler(this.Add_FoodBTN_Click);
            // 
            // Update_BTN
            // 
            this.Update_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_BTN.Location = new System.Drawing.Point(1549, 556);
            this.Update_BTN.Name = "Update_BTN";
            this.Update_BTN.Size = new System.Drawing.Size(312, 89);
            this.Update_BTN.TabIndex = 9;
            this.Update_BTN.Text = "Update Food";
            this.Update_BTN.UseVisualStyleBackColor = true;
            this.Update_BTN.Click += new System.EventHandler(this.Update_BTN_Click);
            // 
            // List_BTN
            // 
            this.List_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_BTN.Location = new System.Drawing.Point(1549, 790);
            this.List_BTN.Name = "List_BTN";
            this.List_BTN.Size = new System.Drawing.Size(312, 89);
            this.List_BTN.TabIndex = 11;
            this.List_BTN.Text = "List Food";
            this.List_BTN.UseVisualStyleBackColor = true;
            this.List_BTN.Click += new System.EventHandler(this.List_BTN_Click);
            // 
            // Delete_FoodBTN
            // 
            this.Delete_FoodBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_FoodBTN.Location = new System.Drawing.Point(1549, 670);
            this.Delete_FoodBTN.Name = "Delete_FoodBTN";
            this.Delete_FoodBTN.Size = new System.Drawing.Size(312, 89);
            this.Delete_FoodBTN.TabIndex = 10;
            this.Delete_FoodBTN.Text = "Delete Food";
            this.Delete_FoodBTN.UseVisualStyleBackColor = true;
            this.Delete_FoodBTN.Click += new System.EventHandler(this.Delete_Food_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1597, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 60, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search Food";
            // 
            // UserPanel_Diets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1933, 1007);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_BTN);
            this.Controls.Add(this.Delete_FoodBTN);
            this.Controls.Add(this.Update_BTN);
            this.Controls.Add(this.Add_FoodBTN);
            this.Controls.Add(this.Diet_DG);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cal_Value_LBL);
            this.Controls.Add(this.Cal_LB);
            this.Name = "UserPanel_Diets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Diet Screen";
            this.Load += new System.EventHandler(this.UserPanel_Diets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Diet_DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cal_LB;
        private System.Windows.Forms.Label cal_Value_LBL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView Diet_DG;
        private System.Windows.Forms.Button Add_FoodBTN;
        private System.Windows.Forms.Button Update_BTN;
        private System.Windows.Forms.Button List_BTN;
        private System.Windows.Forms.Button Delete_FoodBTN;
        private System.Windows.Forms.Label label1;
    }
}