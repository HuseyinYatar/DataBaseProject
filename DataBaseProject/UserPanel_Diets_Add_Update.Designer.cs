namespace DataBaseProject
{
    partial class UserPanel_Diets_Add_Update
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
            this.Gram_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gram_TB
            // 
            this.Gram_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gram_TB.Location = new System.Drawing.Point(89, 118);
            this.Gram_TB.Name = "Gram_TB";
            this.Gram_TB.Size = new System.Drawing.Size(294, 57);
            this.Gram_TB.TabIndex = 0;
            this.Gram_TB.TextChanged += new System.EventHandler(this.Gram_TB_TextChanged);
            this.Gram_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gram_TB_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gram";
            // 
            // UserPanel_Diets_Add_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(455, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gram_TB);
            this.Name = "UserPanel_Diets_Add_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Panel Diet Add/Update";
            this.Load += new System.EventHandler(this.UserPanel_Diets_Add_Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Gram_TB;
    }
}