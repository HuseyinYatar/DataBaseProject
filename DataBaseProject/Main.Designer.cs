namespace DataBaseProject
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sign_UP_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.Sign_In_BTN = new System.Windows.Forms.Button();
            this.AdminBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sign_UP_BTN
            // 
            this.Sign_UP_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_UP_BTN.Location = new System.Drawing.Point(193, 325);
            this.Sign_UP_BTN.Name = "Sign_UP_BTN";
            this.Sign_UP_BTN.Size = new System.Drawing.Size(343, 73);
            this.Sign_UP_BTN.TabIndex = 45;
            this.Sign_UP_BTN.Text = "Sign Up";
            this.Sign_UP_BTN.UseVisualStyleBackColor = true;
            this.Sign_UP_BTN.Click += new System.EventHandler(this.Sign_UP_BTN_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 40);
            this.label1.TabIndex = 42;
            this.label1.Text = "Name:";
            // 
            // Name_TB
            // 
            this.Name_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_TB.Location = new System.Drawing.Point(316, 111);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(220, 48);
            this.Name_TB.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 40);
            this.label2.TabIndex = 47;
            this.label2.Text = "Password:";
            // 
            // Password_TB
            // 
            this.Password_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TB.Location = new System.Drawing.Point(316, 189);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.PasswordChar = '*';
            this.Password_TB.Size = new System.Drawing.Size(220, 48);
            this.Password_TB.TabIndex = 46;
            // 
            // Sign_In_BTN
            // 
            this.Sign_In_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_In_BTN.Location = new System.Drawing.Point(193, 424);
            this.Sign_In_BTN.Name = "Sign_In_BTN";
            this.Sign_In_BTN.Size = new System.Drawing.Size(343, 65);
            this.Sign_In_BTN.TabIndex = 48;
            this.Sign_In_BTN.Text = "Sign In";
            this.Sign_In_BTN.UseVisualStyleBackColor = true;
            this.Sign_In_BTN.Click += new System.EventHandler(this.Sign_In_BTN_Click);
            // 
            // AdminBTN
            // 
            this.AdminBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBTN.Location = new System.Drawing.Point(502, 30);
            this.AdminBTN.Name = "AdminBTN";
            this.AdminBTN.Size = new System.Drawing.Size(169, 54);
            this.AdminBTN.TabIndex = 49;
            this.AdminBTN.Text = "Admin ";
            this.AdminBTN.UseVisualStyleBackColor = true;
            this.AdminBTN.Click += new System.EventHandler(this.AdminBTN_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(683, 555);
            this.Controls.Add(this.AdminBTN);
            this.Controls.Add(this.Sign_In_BTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.Sign_UP_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_TB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Sign_UP_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.Button Sign_In_BTN;
        private System.Windows.Forms.Button AdminBTN;
    }
}

