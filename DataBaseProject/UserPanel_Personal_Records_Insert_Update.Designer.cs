namespace DataBaseProject
{
    partial class UserPanel_Personal_Records_Insert_Update
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
            this.ExerciseCB = new System.Windows.Forms.ComboBox();
            this.PR_LBL = new System.Windows.Forms.Label();
            this.OK_BTN = new System.Windows.Forms.Button();
            this.ExerciseLBL = new System.Windows.Forms.Label();
            this.Pr_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExerciseCB
            // 
            this.ExerciseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExerciseCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExerciseCB.FormattingEnabled = true;
            this.ExerciseCB.Location = new System.Drawing.Point(253, 100);
            this.ExerciseCB.Name = "ExerciseCB";
            this.ExerciseCB.Size = new System.Drawing.Size(272, 48);
            this.ExerciseCB.TabIndex = 47;
            // 
            // PR_LBL
            // 
            this.PR_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PR_LBL.AutoSize = true;
            this.PR_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PR_LBL.Location = new System.Drawing.Point(68, 174);
            this.PR_LBL.Name = "PR_LBL";
            this.PR_LBL.Size = new System.Drawing.Size(153, 40);
            this.PR_LBL.TabIndex = 44;
            this.PR_LBL.Text = "PR(KG):";
            // 
            // OK_BTN
            // 
            this.OK_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_BTN.Location = new System.Drawing.Point(179, 250);
            this.OK_BTN.Name = "OK_BTN";
            this.OK_BTN.Size = new System.Drawing.Size(346, 73);
            this.OK_BTN.TabIndex = 42;
            this.OK_BTN.Text = "OK";
            this.OK_BTN.UseVisualStyleBackColor = true;
            this.OK_BTN.Click += new System.EventHandler(this.OK_BTN_Click);
            // 
            // ExerciseLBL
            // 
            this.ExerciseLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExerciseLBL.AutoSize = true;
            this.ExerciseLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExerciseLBL.Location = new System.Drawing.Point(56, 103);
            this.ExerciseLBL.Name = "ExerciseLBL";
            this.ExerciseLBL.Size = new System.Drawing.Size(165, 40);
            this.ExerciseLBL.TabIndex = 40;
            this.ExerciseLBL.Text = "Exercise:";
            // 
            // Pr_TB
            // 
            this.Pr_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pr_TB.Location = new System.Drawing.Point(253, 174);
            this.Pr_TB.Name = "Pr_TB";
            this.Pr_TB.Size = new System.Drawing.Size(272, 48);
            this.Pr_TB.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // UserPanel_Personal_Records_Insert_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pr_TB);
            this.Controls.Add(this.ExerciseCB);
            this.Controls.Add(this.PR_LBL);
            this.Controls.Add(this.OK_BTN);
            this.Controls.Add(this.ExerciseLBL);
            this.Name = "UserPanel_Personal_Records_Insert_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Records Insert/Update ";
            this.Load += new System.EventHandler(this.UserPanel_Personal_Records_Insert_Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox ExerciseCB;
        public System.Windows.Forms.Label PR_LBL;
        private System.Windows.Forms.Button OK_BTN;
        public System.Windows.Forms.Label ExerciseLBL;
        private System.Windows.Forms.TextBox Pr_TB;
        public System.Windows.Forms.Label label1;
    }
}