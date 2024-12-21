namespace DataBaseProject
{
    partial class UserPanel
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
            this.Exercises_BTN = new System.Windows.Forms.Button();
            this.PersonBTN = new System.Windows.Forms.Button();
            this.DietsBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exercises_BTN
            // 
            this.Exercises_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exercises_BTN.Location = new System.Drawing.Point(140, 320);
            this.Exercises_BTN.Name = "Exercises_BTN";
            this.Exercises_BTN.Size = new System.Drawing.Size(350, 89);
            this.Exercises_BTN.TabIndex = 5;
            this.Exercises_BTN.Text = "Exercises";
            this.Exercises_BTN.UseVisualStyleBackColor = true;
            this.Exercises_BTN.Click += new System.EventHandler(this.Exercises_BTN_Click);
            // 
            // PersonBTN
            // 
            this.PersonBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonBTN.Location = new System.Drawing.Point(140, 198);
            this.PersonBTN.Name = "PersonBTN";
            this.PersonBTN.Size = new System.Drawing.Size(350, 89);
            this.PersonBTN.TabIndex = 4;
            this.PersonBTN.Text = "Personal Records";
            this.PersonBTN.UseVisualStyleBackColor = true;
            this.PersonBTN.Click += new System.EventHandler(this.PersonBTN_Click);
            // 
            // DietsBTN
            // 
            this.DietsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DietsBTN.Location = new System.Drawing.Point(140, 67);
            this.DietsBTN.Name = "DietsBTN";
            this.DietsBTN.Size = new System.Drawing.Size(350, 89);
            this.DietsBTN.TabIndex = 3;
            this.DietsBTN.Text = "Diets";
            this.DietsBTN.UseVisualStyleBackColor = true;
            this.DietsBTN.Click += new System.EventHandler(this.DietsBTN_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(639, 511);
            this.Controls.Add(this.Exercises_BTN);
            this.Controls.Add(this.PersonBTN);
            this.Controls.Add(this.DietsBTN);
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exercises_BTN;
        private System.Windows.Forms.Button PersonBTN;
        private System.Windows.Forms.Button DietsBTN;
    }
}