namespace DataBaseProject
{
    partial class UserPanel_Personal_Records
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.List_BTN = new System.Windows.Forms.Button();
            this.PR_DG = new System.Windows.Forms.DataGridView();
            this.Add_PR_BTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PR_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // List_BTN
            // 
            this.List_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List_BTN.Location = new System.Drawing.Point(1437, 460);
            this.List_BTN.Margin = new System.Windows.Forms.Padding(0, 60, 60, 0);
            this.List_BTN.Name = "List_BTN";
            this.List_BTN.Size = new System.Drawing.Size(406, 89);
            this.List_BTN.TabIndex = 33;
            this.List_BTN.Text = "List ";
            this.List_BTN.UseVisualStyleBackColor = true;
            this.List_BTN.Click += new System.EventHandler(this.List_BTN_Click);
            // 
            // PR_DG
            // 
            this.PR_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PR_DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PR_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "---------------";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PR_DG.DefaultCellStyle = dataGridViewCellStyle4;
            this.PR_DG.Location = new System.Drawing.Point(149, 43);
            this.PR_DG.Name = "PR_DG";
            this.PR_DG.RowHeadersWidth = 62;
            this.PR_DG.RowTemplate.Height = 28;
            this.PR_DG.Size = new System.Drawing.Size(1181, 966);
            this.PR_DG.TabIndex = 32;
            this.PR_DG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PR_DG_CellClick);
            this.PR_DG.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.PR_DG_CellFormatting);
            // 
            // Add_PR_BTN
            // 
            this.Add_PR_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_PR_BTN.Location = new System.Drawing.Point(1437, 43);
            this.Add_PR_BTN.Margin = new System.Windows.Forms.Padding(0, 60, 60, 0);
            this.Add_PR_BTN.Name = "Add_PR_BTN";
            this.Add_PR_BTN.Size = new System.Drawing.Size(406, 89);
            this.Add_PR_BTN.TabIndex = 34;
            this.Add_PR_BTN.Text = "Insert ";
            this.Add_PR_BTN.UseVisualStyleBackColor = true;
            this.Add_PR_BTN.Click += new System.EventHandler(this.Add_PR_BTN_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1437, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 60, 60, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 89);
            this.button1.TabIndex = 35;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete_BTN
            // 
            this.Delete_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_BTN.Location = new System.Drawing.Point(1437, 320);
            this.Delete_BTN.Margin = new System.Windows.Forms.Padding(0, 60, 60, 0);
            this.Delete_BTN.Name = "Delete_BTN";
            this.Delete_BTN.Size = new System.Drawing.Size(406, 89);
            this.Delete_BTN.TabIndex = 36;
            this.Delete_BTN.Text = "Delete";
            this.Delete_BTN.UseVisualStyleBackColor = true;
            this.Delete_BTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserPanel_Personal_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1881, 1144);
            this.Controls.Add(this.Delete_BTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_PR_BTN);
            this.Controls.Add(this.List_BTN);
            this.Controls.Add(this.PR_DG);
            this.Name = "UserPanel_Personal_Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Records Screen";
            this.Load += new System.EventHandler(this.UserPanel_Personal_Records_Load);
            this.VisibleChanged += new System.EventHandler(this.UserPanel_Personal_Records_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.PR_DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button List_BTN;
        private System.Windows.Forms.DataGridView PR_DG;
        private System.Windows.Forms.Button Add_PR_BTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete_BTN;
    }
}