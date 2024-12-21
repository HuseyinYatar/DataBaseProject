namespace DataBaseProject
{
    partial class AdminPanel_Muscle
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
            this.label1 = new System.Windows.Forms.Label();
            this.Muscle_TB = new System.Windows.Forms.TextBox();
            this.OK_BTN = new System.Windows.Forms.Button();
            this.Lower_RDBTN = new System.Windows.Forms.RadioButton();
            this.Upper_RDBTN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 40);
            this.label1.TabIndex = 37;
            this.label1.Text = "Muscle:";
            // 
            // Muscle_TB
            // 
            this.Muscle_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Muscle_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Muscle_TB.Location = new System.Drawing.Point(303, 96);
            this.Muscle_TB.Name = "Muscle_TB";
            this.Muscle_TB.Size = new System.Drawing.Size(260, 48);
            this.Muscle_TB.TabIndex = 36;
            // 
            // OK_BTN
            // 
            this.OK_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_BTN.Location = new System.Drawing.Point(217, 279);
            this.OK_BTN.Name = "OK_BTN";
            this.OK_BTN.Size = new System.Drawing.Size(346, 73);
            this.OK_BTN.TabIndex = 40;
            this.OK_BTN.Text = "OK";
            this.OK_BTN.UseVisualStyleBackColor = true;
            this.OK_BTN.Click += new System.EventHandler(this.OK_BTN_Click);
            // 
            // Lower_RDBTN
            // 
            this.Lower_RDBTN.AutoSize = true;
            this.Lower_RDBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lower_RDBTN.Location = new System.Drawing.Point(374, 193);
            this.Lower_RDBTN.Name = "Lower_RDBTN";
            this.Lower_RDBTN.Size = new System.Drawing.Size(210, 41);
            this.Lower_RDBTN.TabIndex = 39;
            this.Lower_RDBTN.TabStop = true;
            this.Lower_RDBTN.Text = "Lower Body";
            this.Lower_RDBTN.UseVisualStyleBackColor = true;
            // 
            // Upper_RDBTN
            // 
            this.Upper_RDBTN.AutoSize = true;
            this.Upper_RDBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upper_RDBTN.Location = new System.Drawing.Point(163, 193);
            this.Upper_RDBTN.Name = "Upper_RDBTN";
            this.Upper_RDBTN.Size = new System.Drawing.Size(210, 41);
            this.Upper_RDBTN.TabIndex = 38;
            this.Upper_RDBTN.TabStop = true;
            this.Upper_RDBTN.Text = "Upper Body";
            this.Upper_RDBTN.UseVisualStyleBackColor = true;
            // 
            // AdminPanel_Muscle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.OK_BTN);
            this.Controls.Add(this.Lower_RDBTN);
            this.Controls.Add(this.Upper_RDBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Muscle_TB);
            this.Name = "AdminPanel_Muscle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel Muscle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Muscle_TB;
        private System.Windows.Forms.Button OK_BTN;
        private System.Windows.Forms.RadioButton Lower_RDBTN;
        private System.Windows.Forms.RadioButton Upper_RDBTN;
    }
}