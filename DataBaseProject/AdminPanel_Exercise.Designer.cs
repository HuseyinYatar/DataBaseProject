namespace DataBaseProject
{
    partial class AdminPanel_Exercise
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
            this.OK_BTN = new System.Windows.Forms.Button();
            this.Exercise_TB = new System.Windows.Forms.TextBox();
            this.MuscleLBL = new System.Windows.Forms.Label();
            this.ExerciseLBL = new System.Windows.Forms.Label();
            this.Equipment_CB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OK_BTN
            // 
            this.OK_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_BTN.Location = new System.Drawing.Point(298, 298);
            this.OK_BTN.Name = "OK_BTN";
            this.OK_BTN.Size = new System.Drawing.Size(294, 73);
            this.OK_BTN.TabIndex = 30;
            this.OK_BTN.Text = "OK";
            this.OK_BTN.UseVisualStyleBackColor = true;
            this.OK_BTN.Click += new System.EventHandler(this.OK_BTN_Click);
            // 
            // Exercise_TB
            // 
            this.Exercise_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exercise_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exercise_TB.Location = new System.Drawing.Point(298, 117);
            this.Exercise_TB.Name = "Exercise_TB";
            this.Exercise_TB.Size = new System.Drawing.Size(294, 48);
            this.Exercise_TB.TabIndex = 27;
            // 
            // MuscleLBL
            // 
            this.MuscleLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MuscleLBL.AutoSize = true;
            this.MuscleLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuscleLBL.Location = new System.Drawing.Point(73, 208);
            this.MuscleLBL.Name = "MuscleLBL";
            this.MuscleLBL.Size = new System.Drawing.Size(199, 40);
            this.MuscleLBL.TabIndex = 26;
            this.MuscleLBL.Text = "Equipment:";
            // 
            // ExerciseLBL
            // 
            this.ExerciseLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExerciseLBL.AutoSize = true;
            this.ExerciseLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExerciseLBL.Location = new System.Drawing.Point(107, 120);
            this.ExerciseLBL.Name = "ExerciseLBL";
            this.ExerciseLBL.Size = new System.Drawing.Size(165, 40);
            this.ExerciseLBL.TabIndex = 24;
            this.ExerciseLBL.Text = "Exercise:";
            // 
            // Equipment_CB
            // 
            this.Equipment_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Equipment_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equipment_CB.FormattingEnabled = true;
            this.Equipment_CB.Items.AddRange(new object[] {
            "Dumbell",
            "Barbell",
            "Machine"});
            this.Equipment_CB.Location = new System.Drawing.Point(298, 200);
            this.Equipment_CB.Name = "Equipment_CB";
            this.Equipment_CB.Size = new System.Drawing.Size(294, 48);
            this.Equipment_CB.TabIndex = 31;
            // 
            // AdminPanel_Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 500);
            this.Controls.Add(this.Equipment_CB);
            this.Controls.Add(this.OK_BTN);
            this.Controls.Add(this.Exercise_TB);
            this.Controls.Add(this.MuscleLBL);
            this.Controls.Add(this.ExerciseLBL);
            this.Name = "AdminPanel_Exercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OK_BTN;
        private System.Windows.Forms.TextBox Exercise_TB;
        private System.Windows.Forms.Label MuscleLBL;
        private System.Windows.Forms.Label ExerciseLBL;
        private System.Windows.Forms.ComboBox Equipment_CB;
    }
}