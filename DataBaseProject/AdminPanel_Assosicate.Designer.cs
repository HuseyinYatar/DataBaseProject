namespace DataBaseProject
{
    partial class AdminPanel_Assosicate
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
            this.Assosicate_DG = new System.Windows.Forms.DataGridView();
            this.Insert_BTN = new System.Windows.Forms.Button();
            this.Update_BTN = new System.Windows.Forms.Button();
            this.Delete_BTN = new System.Windows.Forms.Button();
            this.List_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Assosicate_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // Assosicate_DG
            // 
            this.Assosicate_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Assosicate_DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Assosicate_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Assosicate_DG.DefaultCellStyle = dataGridViewCellStyle2;
            this.Assosicate_DG.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.Assosicate_DG.Location = new System.Drawing.Point(36, 43);
            this.Assosicate_DG.Name = "Assosicate_DG";
            this.Assosicate_DG.RowHeadersWidth = 62;
            this.Assosicate_DG.RowTemplate.Height = 28;
            this.Assosicate_DG.Size = new System.Drawing.Size(1135, 792);
            this.Assosicate_DG.TabIndex = 0;
            this.Assosicate_DG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Assosicate_DG_CellClick);
            // 
            // Insert_BTN
            // 
            this.Insert_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_BTN.Location = new System.Drawing.Point(1261, 43);
            this.Insert_BTN.Name = "Insert_BTN";
            this.Insert_BTN.Size = new System.Drawing.Size(346, 89);
            this.Insert_BTN.TabIndex = 13;
            this.Insert_BTN.Text = "Insert";
            this.Insert_BTN.UseVisualStyleBackColor = true;
            this.Insert_BTN.Click += new System.EventHandler(this.Insert_BTN_Click);
            // 
            // Update_BTN
            // 
            this.Update_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_BTN.Location = new System.Drawing.Point(1261, 166);
            this.Update_BTN.Name = "Update_BTN";
            this.Update_BTN.Size = new System.Drawing.Size(346, 89);
            this.Update_BTN.TabIndex = 14;
            this.Update_BTN.Text = "Update";
            this.Update_BTN.UseVisualStyleBackColor = true;
            this.Update_BTN.Click += new System.EventHandler(this.Update_BTN_Click);
            // 
            // Delete_BTN
            // 
            this.Delete_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_BTN.Location = new System.Drawing.Point(1261, 289);
            this.Delete_BTN.Name = "Delete_BTN";
            this.Delete_BTN.Size = new System.Drawing.Size(346, 89);
            this.Delete_BTN.TabIndex = 15;
            this.Delete_BTN.Text = "Delete";
            this.Delete_BTN.UseVisualStyleBackColor = true;
            this.Delete_BTN.Click += new System.EventHandler(this.Delete_BTN_Click);
            // 
            // List_BTN
            // 
            this.List_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_BTN.Location = new System.Drawing.Point(1261, 412);
            this.List_BTN.Name = "List_BTN";
            this.List_BTN.Size = new System.Drawing.Size(346, 89);
            this.List_BTN.TabIndex = 16;
            this.List_BTN.Text = "List";
            this.List_BTN.UseVisualStyleBackColor = true;
            this.List_BTN.Click += new System.EventHandler(this.List_BTN_Click);
            // 
            // AdminPanel_Assosicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1673, 900);
            this.Controls.Add(this.List_BTN);
            this.Controls.Add(this.Delete_BTN);
            this.Controls.Add(this.Update_BTN);
            this.Controls.Add(this.Insert_BTN);
            this.Controls.Add(this.Assosicate_DG);
            this.Name = "AdminPanel_Assosicate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assosicate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Panel_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Assosicate_DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Assosicate_DG;
        private System.Windows.Forms.Button Insert_BTN;
        private System.Windows.Forms.Button Update_BTN;
        private System.Windows.Forms.Button Delete_BTN;
        private System.Windows.Forms.Button List_BTN;
    }
}