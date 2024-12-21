namespace DataBaseProject
{
    partial class AdminPanel_Foods
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
            this.Insert_FoodBTN = new System.Windows.Forms.Button();
            this.Food_DG = new System.Windows.Forms.DataGridView();
            this.Update_FoodBTN = new System.Windows.Forms.Button();
            this.Delete_Food = new System.Windows.Forms.Button();
            this.List_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Food_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert_FoodBTN
            // 
            this.Insert_FoodBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_FoodBTN.Location = new System.Drawing.Point(1272, 41);
            this.Insert_FoodBTN.Name = "Insert_FoodBTN";
            this.Insert_FoodBTN.Size = new System.Drawing.Size(312, 89);
            this.Insert_FoodBTN.TabIndex = 6;
            this.Insert_FoodBTN.Text = "Insert Food";
            this.Insert_FoodBTN.UseVisualStyleBackColor = true;
            this.Insert_FoodBTN.Click += new System.EventHandler(this.FoodBTN_Click);
            // 
            // Food_DG
            // 
            this.Food_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Food_DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Food_DG.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "----------";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Food_DG.DefaultCellStyle = dataGridViewCellStyle2;
            this.Food_DG.Location = new System.Drawing.Point(65, 41);
            this.Food_DG.Name = "Food_DG";
            this.Food_DG.RowHeadersWidth = 62;
            this.Food_DG.RowTemplate.Height = 28;
            this.Food_DG.Size = new System.Drawing.Size(1096, 735);
            this.Food_DG.TabIndex = 5;
            this.Food_DG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Food_DG_CellClick);
            this.Food_DG.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Food_DG_CellFormatting);
            // 
            // Update_FoodBTN
            // 
            this.Update_FoodBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_FoodBTN.Location = new System.Drawing.Point(1272, 161);
            this.Update_FoodBTN.Name = "Update_FoodBTN";
            this.Update_FoodBTN.Size = new System.Drawing.Size(312, 89);
            this.Update_FoodBTN.TabIndex = 7;
            this.Update_FoodBTN.Text = "Update Food";
            this.Update_FoodBTN.UseVisualStyleBackColor = true;
            this.Update_FoodBTN.Click += new System.EventHandler(this.Update_FoodBTN_Click);
            // 
            // Delete_Food
            // 
            this.Delete_Food.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Food.Location = new System.Drawing.Point(1272, 281);
            this.Delete_Food.Name = "Delete_Food";
            this.Delete_Food.Size = new System.Drawing.Size(312, 89);
            this.Delete_Food.TabIndex = 8;
            this.Delete_Food.Text = "Delete Food";
            this.Delete_Food.UseVisualStyleBackColor = true;
            this.Delete_Food.Click += new System.EventHandler(this.Delete_Food_Click);
            // 
            // List_BTN
            // 
            this.List_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_BTN.Location = new System.Drawing.Point(1272, 401);
            this.List_BTN.Name = "List_BTN";
            this.List_BTN.Size = new System.Drawing.Size(312, 89);
            this.List_BTN.TabIndex = 9;
            this.List_BTN.Text = "List Food";
            this.List_BTN.UseVisualStyleBackColor = true;
            this.List_BTN.Click += new System.EventHandler(this.List_BTN_Click);
            // 
            // AdminPanel_Foods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1648, 816);
            this.Controls.Add(this.List_BTN);
            this.Controls.Add(this.Delete_Food);
            this.Controls.Add(this.Update_FoodBTN);
            this.Controls.Add(this.Insert_FoodBTN);
            this.Controls.Add(this.Food_DG);
            this.Name = "AdminPanel_Foods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel_Foods";
            ((System.ComponentModel.ISupportInitialize)(this.Food_DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Insert_FoodBTN;
        private System.Windows.Forms.DataGridView Food_DG;
        private System.Windows.Forms.Button Update_FoodBTN;
        private System.Windows.Forms.Button Delete_Food;
        private System.Windows.Forms.Button List_BTN;
    }
}