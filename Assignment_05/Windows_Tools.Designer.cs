
namespace Controls_Assignment
{
    partial class Windows_Tools
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
            this.lbl_Ename = new System.Windows.Forms.Label();
            this.lbl_Edepartment = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_STime = new System.Windows.Forms.Label();
            this.lbl_output = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_EName = new System.Windows.Forms.TextBox();
            this.cmb_Edepartment = new System.Windows.Forms.ComboBox();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.Gr_Gender = new System.Windows.Forms.GroupBox();
            this.Rd_Female = new System.Windows.Forms.RadioButton();
            this.Rd_Male = new System.Windows.Forms.RadioButton();
            this.Gr_STime = new System.Windows.Forms.GroupBox();
            this.Rd_Night = new System.Windows.Forms.RadioButton();
            this.Rd_Evening = new System.Windows.Forms.RadioButton();
            this.Rd_Morning = new System.Windows.Forms.RadioButton();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.Gr_Gender.SuspendLayout();
            this.Gr_STime.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(267, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE INFORMATION";
            // 
            // lbl_Ename
            // 
            this.lbl_Ename.AutoSize = true;
            this.lbl_Ename.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_Ename.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ename.Location = new System.Drawing.Point(57, 117);
            this.lbl_Ename.Name = "lbl_Ename";
            this.lbl_Ename.Size = new System.Drawing.Size(160, 25);
            this.lbl_Ename.TabIndex = 1;
            this.lbl_Ename.Text = "Employee Name";
            // 
            // lbl_Edepartment
            // 
            this.lbl_Edepartment.AutoSize = true;
            this.lbl_Edepartment.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_Edepartment.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edepartment.Location = new System.Drawing.Point(57, 188);
            this.lbl_Edepartment.Name = "lbl_Edepartment";
            this.lbl_Edepartment.Size = new System.Drawing.Size(216, 25);
            this.lbl_Edepartment.TabIndex = 2;
            this.lbl_Edepartment.Text = "Employee Department";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_Gender.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(57, 259);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(77, 25);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_STime
            // 
            this.lbl_STime.AutoSize = true;
            this.lbl_STime.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_STime.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_STime.Location = new System.Drawing.Point(57, 321);
            this.lbl_STime.Name = "lbl_STime";
            this.lbl_STime.Size = new System.Drawing.Size(112, 25);
            this.lbl_STime.TabIndex = 4;
            this.lbl_STime.Text = "Shift Time";
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_output.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(58, 479);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(76, 25);
            this.lbl_output.TabIndex = 5;
            this.lbl_output.Text = "Output";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(587, 411);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(125, 35);
            this.btn_Submit.TabIndex = 10;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tb_EName
            // 
            this.tb_EName.Location = new System.Drawing.Point(359, 121);
            this.tb_EName.Name = "tb_EName";
            this.tb_EName.Size = new System.Drawing.Size(391, 20);
            this.tb_EName.TabIndex = 1;
            this.tb_EName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // cmb_Edepartment
            // 
            this.cmb_Edepartment.FormattingEnabled = true;
            this.cmb_Edepartment.Items.AddRange(new object[] {
            "Designing",
            "Testing",
            "Developing"});
            this.cmb_Edepartment.Location = new System.Drawing.Point(359, 191);
            this.cmb_Edepartment.Name = "cmb_Edepartment";
            this.cmb_Edepartment.Size = new System.Drawing.Size(391, 21);
            this.cmb_Edepartment.TabIndex = 2;
            // 
            // tb_Output
            // 
            this.tb_Output.Location = new System.Drawing.Point(359, 479);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(501, 20);
            this.tb_Output.TabIndex = 11;
            // 
            // Gr_Gender
            // 
            this.Gr_Gender.BackColor = System.Drawing.Color.FloralWhite;
            this.Gr_Gender.Controls.Add(this.Rd_Female);
            this.Gr_Gender.Controls.Add(this.Rd_Male);
            this.Gr_Gender.Location = new System.Drawing.Point(359, 258);
            this.Gr_Gender.Name = "Gr_Gender";
            this.Gr_Gender.Size = new System.Drawing.Size(391, 50);
            this.Gr_Gender.TabIndex = 3;
            this.Gr_Gender.TabStop = false;
            this.Gr_Gender.Text = "G";
            // 
            // Rd_Female
            // 
            this.Rd_Female.AutoSize = true;
            this.Rd_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Female.Location = new System.Drawing.Point(215, 19);
            this.Rd_Female.Name = "Rd_Female";
            this.Rd_Female.Size = new System.Drawing.Size(72, 21);
            this.Rd_Female.TabIndex = 5;
            this.Rd_Female.TabStop = true;
            this.Rd_Female.Text = "Female";
            this.Rd_Female.UseVisualStyleBackColor = true;
            // 
            // Rd_Male
            // 
            this.Rd_Male.AutoSize = true;
            this.Rd_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Male.Location = new System.Drawing.Point(47, 19);
            this.Rd_Male.Name = "Rd_Male";
            this.Rd_Male.Size = new System.Drawing.Size(56, 21);
            this.Rd_Male.TabIndex = 4;
            this.Rd_Male.TabStop = true;
            this.Rd_Male.Text = "Male";
            this.Rd_Male.UseVisualStyleBackColor = true;
            // 
            // Gr_STime
            // 
            this.Gr_STime.BackColor = System.Drawing.Color.FloralWhite;
            this.Gr_STime.Controls.Add(this.Rd_Night);
            this.Gr_STime.Controls.Add(this.Rd_Evening);
            this.Gr_STime.Controls.Add(this.Rd_Morning);
            this.Gr_STime.Location = new System.Drawing.Point(359, 321);
            this.Gr_STime.Name = "Gr_STime";
            this.Gr_STime.Size = new System.Drawing.Size(445, 69);
            this.Gr_STime.TabIndex = 6;
            this.Gr_STime.TabStop = false;
            this.Gr_STime.Text = "Shift Time";
            // 
            // Rd_Night
            // 
            this.Rd_Night.AutoSize = true;
            this.Rd_Night.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Night.Location = new System.Drawing.Point(335, 30);
            this.Rd_Night.Name = "Rd_Night";
            this.Rd_Night.Size = new System.Drawing.Size(59, 21);
            this.Rd_Night.TabIndex = 9;
            this.Rd_Night.TabStop = true;
            this.Rd_Night.Text = "Night";
            this.Rd_Night.UseVisualStyleBackColor = true;
            // 
            // Rd_Evening
            // 
            this.Rd_Evening.AutoSize = true;
            this.Rd_Evening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Evening.Location = new System.Drawing.Point(191, 30);
            this.Rd_Evening.Name = "Rd_Evening";
            this.Rd_Evening.Size = new System.Drawing.Size(77, 21);
            this.Rd_Evening.TabIndex = 8;
            this.Rd_Evening.TabStop = true;
            this.Rd_Evening.Text = "Evening";
            this.Rd_Evening.UseVisualStyleBackColor = true;
            // 
            // Rd_Morning
            // 
            this.Rd_Morning.AutoSize = true;
            this.Rd_Morning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Morning.Location = new System.Drawing.Point(37, 30);
            this.Rd_Morning.Name = "Rd_Morning";
            this.Rd_Morning.Size = new System.Drawing.Size(77, 21);
            this.Rd_Morning.TabIndex = 7;
            this.Rd_Morning.TabStop = true;
            this.Rd_Morning.Text = "Morning";
            this.Rd_Morning.UseVisualStyleBackColor = true;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(396, 413);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(125, 35);
            this.btn_Reset.TabIndex = 12;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Windows_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 542);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.Gr_STime);
            this.Controls.Add(this.Gr_Gender);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.cmb_Edepartment);
            this.Controls.Add(this.tb_EName);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_STime);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Edepartment);
            this.Controls.Add(this.lbl_Ename);
            this.Controls.Add(this.label1);
            this.Name = "Windows_Tools";
            this.Text = "Use Windows Controls";
            this.Load += new System.EventHandler(this.Windows_Tools_Load);
            this.Gr_Gender.ResumeLayout(false);
            this.Gr_Gender.PerformLayout();
            this.Gr_STime.ResumeLayout(false);
            this.Gr_STime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Ename;
        private System.Windows.Forms.Label lbl_Edepartment;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_STime;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tb_EName;
        private System.Windows.Forms.ComboBox cmb_Edepartment;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.GroupBox Gr_Gender;
        private System.Windows.Forms.GroupBox Gr_STime;
        private System.Windows.Forms.RadioButton Rd_Female;
        private System.Windows.Forms.RadioButton Rd_Male;
        private System.Windows.Forms.RadioButton Rd_Night;
        private System.Windows.Forms.RadioButton Rd_Evening;
        private System.Windows.Forms.RadioButton Rd_Morning;
        private System.Windows.Forms.Button btn_Reset;
    }
}

