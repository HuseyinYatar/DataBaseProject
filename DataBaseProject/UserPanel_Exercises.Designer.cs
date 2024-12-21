namespace DataBaseProject
{
    partial class UserPanel_Exercises
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
            this.Exercises_DG = new System.Windows.Forms.DataGridView();
            this.UB_BTN = new System.Windows.Forms.Button();
            this.LW_BTN = new System.Windows.Forms.Button();
            this.MuscleGroupLBL = new System.Windows.Forms.Label();
            this.MuscleGroup_CB = new System.Windows.Forms.ComboBox();
            this.MuscleGroup_List_BTN = new System.Windows.Forms.Button();
            this.Place_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Exercises_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // Exercises_DG
            // 
            this.Exercises_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Exercises_DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Exercises_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "---------------";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Exercises_DG.DefaultCellStyle = dataGridViewCellStyle2;
            this.Exercises_DG.Location = new System.Drawing.Point(87, 38);
            this.Exercises_DG.Name = "Exercises_DG";
            this.Exercises_DG.RowHeadersWidth = 62;
            this.Exercises_DG.RowTemplate.Height = 28;
            this.Exercises_DG.Size = new System.Drawing.Size(1181, 966);
            this.Exercises_DG.TabIndex = 0;
            // 
            // UB_BTN
            // 
            this.UB_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UB_BTN.Location = new System.Drawing.Point(1361, 38);
            this.UB_BTN.Name = "UB_BTN";
            this.UB_BTN.Size = new System.Drawing.Size(406, 89);
            this.UB_BTN.TabIndex = 7;
            this.UB_BTN.Text = "UpperBody Exercises";
            this.UB_BTN.UseVisualStyleBackColor = true;
            this.UB_BTN.Click += new System.EventHandler(this.UB_BTN_Click);
            // 
            // LW_BTN
            // 
            this.LW_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LW_BTN.Location = new System.Drawing.Point(1361, 151);
            this.LW_BTN.Margin = new System.Windows.Forms.Padding(3, 3, 60, 3);
            this.LW_BTN.Name = "LW_BTN";
            this.LW_BTN.Size = new System.Drawing.Size(406, 89);
            this.LW_BTN.TabIndex = 8;
            this.LW_BTN.Text = "LowerBody Exercises";
            this.LW_BTN.UseVisualStyleBackColor = true;
            this.LW_BTN.Click += new System.EventHandler(this.LW_BTN_Click);
            // 
            // MuscleGroupLBL
            // 
            this.MuscleGroupLBL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MuscleGroupLBL.AutoSize = true;
            this.MuscleGroupLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuscleGroupLBL.Location = new System.Drawing.Point(1421, 312);
            this.MuscleGroupLBL.Name = "MuscleGroupLBL";
            this.MuscleGroupLBL.Size = new System.Drawing.Size(282, 52);
            this.MuscleGroupLBL.TabIndex = 27;
            this.MuscleGroupLBL.Text = "MuscleGroup";
            // 
            // MuscleGroup_CB
            // 
            this.MuscleGroup_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MuscleGroup_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuscleGroup_CB.FormattingEnabled = true;
            this.MuscleGroup_CB.Location = new System.Drawing.Point(1361, 419);
            this.MuscleGroup_CB.Name = "MuscleGroup_CB";
            this.MuscleGroup_CB.Size = new System.Drawing.Size(406, 60);
            this.MuscleGroup_CB.TabIndex = 28;
            // 
            // MuscleGroup_List_BTN
            // 
            this.MuscleGroup_List_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuscleGroup_List_BTN.Location = new System.Drawing.Point(1375, 774);
            this.MuscleGroup_List_BTN.Margin = new System.Windows.Forms.Padding(3, 3, 60, 3);
            this.MuscleGroup_List_BTN.Name = "MuscleGroup_List_BTN";
            this.MuscleGroup_List_BTN.Size = new System.Drawing.Size(406, 89);
            this.MuscleGroup_List_BTN.TabIndex = 29;
            this.MuscleGroup_List_BTN.Text = "List";
            this.MuscleGroup_List_BTN.UseVisualStyleBackColor = true;
            this.MuscleGroup_List_BTN.Click += new System.EventHandler(this.MuscleGroup_List_BTN_Click);
            // 
            // Place_CB
            // 
            this.Place_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Place_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Place_CB.FormattingEnabled = true;
            this.Place_CB.Items.AddRange(new object[] {
            "Home",
            "Gym"});
            this.Place_CB.Location = new System.Drawing.Point(1361, 641);
            this.Place_CB.Name = "Place_CB";
            this.Place_CB.Size = new System.Drawing.Size(406, 60);
            this.Place_CB.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1494, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 52);
            this.label1.TabIndex = 30;
            this.label1.Text = "Place";
            // 
            // UserPanel_Exercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1903, 1144);
            this.Controls.Add(this.Place_CB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MuscleGroup_List_BTN);
            this.Controls.Add(this.MuscleGroup_CB);
            this.Controls.Add(this.MuscleGroupLBL);
            this.Controls.Add(this.LW_BTN);
            this.Controls.Add(this.UB_BTN);
            this.Controls.Add(this.Exercises_DG);
            this.Name = "UserPanel_Exercises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Exercises Screen";
            this.Load += new System.EventHandler(this.UserPanel_Exercises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Exercises_DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Exercises_DG;
        private System.Windows.Forms.Button UB_BTN;
        private System.Windows.Forms.Button LW_BTN;
        private System.Windows.Forms.Label MuscleGroupLBL;
        private System.Windows.Forms.ComboBox MuscleGroup_CB;
        private System.Windows.Forms.Button MuscleGroup_List_BTN;
        private System.Windows.Forms.ComboBox Place_CB;
        private System.Windows.Forms.Label label1;
    }
}