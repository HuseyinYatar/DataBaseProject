namespace DataBaseProject
{
    partial class AdminPanel
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
            this.Add_MuscleBTN = new System.Windows.Forms.Button();
            this.Add_ExerciseBTN = new System.Windows.Forms.Button();
            this.Assosicate_BTN = new System.Windows.Forms.Button();
            this.FoodBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_MuscleBTN
            // 
            this.Add_MuscleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_MuscleBTN.Location = new System.Drawing.Point(152, 89);
            this.Add_MuscleBTN.Name = "Add_MuscleBTN";
            this.Add_MuscleBTN.Size = new System.Drawing.Size(312, 89);
            this.Add_MuscleBTN.TabIndex = 0;
            this.Add_MuscleBTN.Text = "Add Muscle";
            this.Add_MuscleBTN.UseVisualStyleBackColor = true;
            this.Add_MuscleBTN.Click += new System.EventHandler(this.Add_MuscleBTN_Click);
            // 
            // Add_ExerciseBTN
            // 
            this.Add_ExerciseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_ExerciseBTN.Location = new System.Drawing.Point(152, 212);
            this.Add_ExerciseBTN.Name = "Add_ExerciseBTN";
            this.Add_ExerciseBTN.Size = new System.Drawing.Size(312, 89);
            this.Add_ExerciseBTN.TabIndex = 1;
            this.Add_ExerciseBTN.Text = "Add Exercise";
            this.Add_ExerciseBTN.UseVisualStyleBackColor = true;
            this.Add_ExerciseBTN.Click += new System.EventHandler(this.Add_ExerciseBTN_Click);
            // 
            // Assosicate_BTN
            // 
            this.Assosicate_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Assosicate_BTN.Location = new System.Drawing.Point(152, 335);
            this.Assosicate_BTN.Name = "Assosicate_BTN";
            this.Assosicate_BTN.Size = new System.Drawing.Size(312, 89);
            this.Assosicate_BTN.TabIndex = 2;
            this.Assosicate_BTN.Text = "Assosicate";
            this.Assosicate_BTN.UseVisualStyleBackColor = true;
            this.Assosicate_BTN.Click += new System.EventHandler(this.Assosicate_BTN_Click);
            // 
            // FoodBTN
            // 
            this.FoodBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodBTN.Location = new System.Drawing.Point(152, 458);
            this.FoodBTN.Name = "FoodBTN";
            this.FoodBTN.Size = new System.Drawing.Size(312, 89);
            this.FoodBTN.TabIndex = 3;
            this.FoodBTN.Text = "Food";
            this.FoodBTN.UseVisualStyleBackColor = true;
            this.FoodBTN.Click += new System.EventHandler(this.FoodBTN_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 675);
            this.Controls.Add(this.FoodBTN);
            this.Controls.Add(this.Assosicate_BTN);
            this.Controls.Add(this.Add_ExerciseBTN);
            this.Controls.Add(this.Add_MuscleBTN);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_MuscleBTN;
        private System.Windows.Forms.Button Add_ExerciseBTN;
        private System.Windows.Forms.Button Assosicate_BTN;
        private System.Windows.Forms.Button FoodBTN;
    }
}