namespace DataBaseProject
{
    partial class UserPanel_Diets_List
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
            this.Diet_DG = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Diet_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // Diet_DG
            // 
            this.Diet_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Diet_DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Diet_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Diet_DG.DefaultCellStyle = dataGridViewCellStyle2;
            this.Diet_DG.Location = new System.Drawing.Point(147, 98);
            this.Diet_DG.Margin = new System.Windows.Forms.Padding(100);
            this.Diet_DG.Name = "Diet_DG";
            this.Diet_DG.RowHeadersWidth = 62;
            this.Diet_DG.RowTemplate.Height = 28;
            this.Diet_DG.Size = new System.Drawing.Size(1389, 926);
            this.Diet_DG.TabIndex = 5;
            this.Diet_DG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Diet_DG_CellClick);
            this.Diet_DG.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Diet_DG_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Diet Screen";
            // 
            // UserPanel_Diets_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1669, 940);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Diet_DG);
            this.Name = "UserPanel_Diets_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diet List Screen";
            this.Load += new System.EventHandler(this.UserPanel_Diets_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Diet_DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView Diet_DG;
        private System.Windows.Forms.Label label1;
    }
}