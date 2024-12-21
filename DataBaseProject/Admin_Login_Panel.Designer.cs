namespace DataBaseProject
{
    partial class Admin_Login_Panel
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
            this.Name_LBL = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.Pass_LBL = new System.Windows.Forms.Label();
            this.Sign_inBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_LBL
            // 
            this.Name_LBL.AutoSize = true;
            this.Name_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_LBL.Location = new System.Drawing.Point(103, 106);
            this.Name_LBL.Name = "Name_LBL";
            this.Name_LBL.Size = new System.Drawing.Size(112, 37);
            this.Name_LBL.TabIndex = 0;
            this.Name_LBL.Text = "Name:";
            // 
            // NameTB
            // 
            this.NameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(245, 99);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(213, 44);
            this.NameTB.TabIndex = 2;
            // 
            // PassTB
            // 
            this.PassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTB.Location = new System.Drawing.Point(245, 170);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(213, 44);
            this.PassTB.TabIndex = 4;
            // 
            // Pass_LBL
            // 
            this.Pass_LBL.AutoSize = true;
            this.Pass_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_LBL.Location = new System.Drawing.Point(48, 170);
            this.Pass_LBL.Name = "Pass_LBL";
            this.Pass_LBL.Size = new System.Drawing.Size(167, 37);
            this.Pass_LBL.TabIndex = 3;
            this.Pass_LBL.Text = "Password:";
            // 
            // Sign_inBTN
            // 
            this.Sign_inBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_inBTN.Location = new System.Drawing.Point(245, 234);
            this.Sign_inBTN.Name = "Sign_inBTN";
            this.Sign_inBTN.Size = new System.Drawing.Size(213, 80);
            this.Sign_inBTN.TabIndex = 5;
            this.Sign_inBTN.Text = "Sign In";
            this.Sign_inBTN.UseVisualStyleBackColor = true;
            this.Sign_inBTN.Click += new System.EventHandler(this.Sign_inBTN_Click);
            // 
            // Admin_Login_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(581, 405);
            this.Controls.Add(this.Sign_inBTN);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.Pass_LBL);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.Name_LBL);
            this.Name = "Admin_Login_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_LBL;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Label Pass_LBL;
        private System.Windows.Forms.Button Sign_inBTN;
    }
}