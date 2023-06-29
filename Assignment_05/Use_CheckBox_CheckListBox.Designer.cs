
namespace Controls_Assignment
{
    partial class Use_CheckBox_CheckListBox
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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.Gr_Gender = new System.Windows.Forms.GroupBox();
            this.Rd_Female = new System.Windows.Forms.RadioButton();
            this.Rd_Male = new System.Windows.Forms.RadioButton();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.cmb_Edepartment = new System.Windows.Forms.ComboBox();
            this.tb_EName = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Edepartment = new System.Windows.Forms.Label();
            this.lbl_Ename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_knownlanguages = new System.Windows.Forms.GroupBox();
            this.cb_french = new System.Windows.Forms.CheckBox();
            this.cb_Hindi = new System.Windows.Forms.CheckBox();
            this.cb_English = new System.Windows.Forms.CheckBox();
            this.cb_Marathi = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clb_Hobbies = new System.Windows.Forms.CheckedListBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Gen = new System.Windows.Forms.Label();
            this.lbl_Dep = new System.Windows.Forms.Label();
            this.lbl_Hobbie = new System.Windows.Forms.Label();
            this.lbl_Lang = new System.Windows.Forms.Label();
            this.Gr_Gender.SuspendLayout();
            this.gb_knownlanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(361, 440);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(125, 35);
            this.btn_Reset.TabIndex = 16;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Gr_Gender
            // 
            this.Gr_Gender.BackColor = System.Drawing.Color.FloralWhite;
            this.Gr_Gender.Controls.Add(this.Rd_Female);
            this.Gr_Gender.Controls.Add(this.Rd_Male);
            this.Gr_Gender.Location = new System.Drawing.Point(274, 308);
            this.Gr_Gender.Name = "Gr_Gender";
            this.Gr_Gender.Size = new System.Drawing.Size(316, 37);
            this.Gr_Gender.TabIndex = 3;
            this.Gr_Gender.TabStop = false;
            this.Gr_Gender.Text = "G";
            // 
            // Rd_Female
            // 
            this.Rd_Female.AutoSize = true;
            this.Rd_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rd_Female.Location = new System.Drawing.Point(211, 10);
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
            this.Rd_Male.Location = new System.Drawing.Point(47, 10);
            this.Rd_Male.Name = "Rd_Male";
            this.Rd_Male.Size = new System.Drawing.Size(56, 21);
            this.Rd_Male.TabIndex = 4;
            this.Rd_Male.TabStop = true;
            this.Rd_Male.Text = "Male";
            this.Rd_Male.UseVisualStyleBackColor = true;
            // 
            // tb_Output
            // 
            this.tb_Output.Location = new System.Drawing.Point(225, 494);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(777, 20);
            this.tb_Output.TabIndex = 18;
            // 
            // cmb_Edepartment
            // 
            this.cmb_Edepartment.FormattingEnabled = true;
            this.cmb_Edepartment.Items.AddRange(new object[] {
            "Designing",
            "Testing",
            "Developing"});
            this.cmb_Edepartment.Location = new System.Drawing.Point(274, 222);
            this.cmb_Edepartment.Name = "cmb_Edepartment";
            this.cmb_Edepartment.Size = new System.Drawing.Size(316, 21);
            this.cmb_Edepartment.TabIndex = 2;
            // 
            // tb_EName
            // 
            this.tb_EName.Location = new System.Drawing.Point(274, 122);
            this.tb_EName.Name = "tb_EName";
            this.tb_EName.Size = new System.Drawing.Size(316, 20);
            this.tb_EName.TabIndex = 1;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(737, 437);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(125, 35);
            this.btn_Submit.TabIndex = 17;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_output.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(44, 489);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(76, 25);
            this.lbl_output.TabIndex = 21;
            this.lbl_output.Text = "Output";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_Gender.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(22, 308);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(77, 25);
            this.lbl_Gender.TabIndex = 19;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Edepartment
            // 
            this.lbl_Edepartment.AutoSize = true;
            this.lbl_Edepartment.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_Edepartment.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edepartment.Location = new System.Drawing.Point(22, 216);
            this.lbl_Edepartment.Name = "lbl_Edepartment";
            this.lbl_Edepartment.Size = new System.Drawing.Size(216, 25);
            this.lbl_Edepartment.TabIndex = 17;
            this.lbl_Edepartment.Text = "Employee Department";
            // 
            // lbl_Ename
            // 
            this.lbl_Ename.AutoSize = true;
            this.lbl_Ename.BackColor = System.Drawing.Color.Cornsilk;
            this.lbl_Ename.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ename.Location = new System.Drawing.Point(22, 122);
            this.lbl_Ename.Name = "lbl_Ename";
            this.lbl_Ename.Size = new System.Drawing.Size(160, 25);
            this.lbl_Ename.TabIndex = 15;
            this.lbl_Ename.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(336, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "EMPLOYEE GENERAL INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(644, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Known Languages";
            // 
            // gb_knownlanguages
            // 
            this.gb_knownlanguages.BackColor = System.Drawing.Color.FloralWhite;
            this.gb_knownlanguages.Controls.Add(this.cb_french);
            this.gb_knownlanguages.Controls.Add(this.cb_Hindi);
            this.gb_knownlanguages.Controls.Add(this.cb_English);
            this.gb_knownlanguages.Controls.Add(this.cb_Marathi);
            this.gb_knownlanguages.Location = new System.Drawing.Point(868, 116);
            this.gb_knownlanguages.Name = "gb_knownlanguages";
            this.gb_knownlanguages.Size = new System.Drawing.Size(235, 109);
            this.gb_knownlanguages.TabIndex = 10;
            this.gb_knownlanguages.TabStop = false;
            this.gb_knownlanguages.Text = "Known Languages";
            // 
            // cb_french
            // 
            this.cb_french.AutoSize = true;
            this.cb_french.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_french.Location = new System.Drawing.Point(126, 70);
            this.cb_french.Name = "cb_french";
            this.cb_french.Size = new System.Drawing.Size(70, 21);
            this.cb_french.TabIndex = 14;
            this.cb_french.Text = "French";
            this.cb_french.UseVisualStyleBackColor = true;
            // 
            // cb_Hindi
            // 
            this.cb_Hindi.AutoSize = true;
            this.cb_Hindi.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Hindi.Location = new System.Drawing.Point(25, 70);
            this.cb_Hindi.Name = "cb_Hindi";
            this.cb_Hindi.Size = new System.Drawing.Size(64, 21);
            this.cb_Hindi.TabIndex = 12;
            this.cb_Hindi.Text = "Hindi";
            this.cb_Hindi.UseVisualStyleBackColor = true;
            // 
            // cb_English
            // 
            this.cb_English.AutoSize = true;
            this.cb_English.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_English.Location = new System.Drawing.Point(126, 31);
            this.cb_English.Name = "cb_English";
            this.cb_English.Size = new System.Drawing.Size(75, 21);
            this.cb_English.TabIndex = 13;
            this.cb_English.Text = "English";
            this.cb_English.UseVisualStyleBackColor = true;
            // 
            // cb_Marathi
            // 
            this.cb_Marathi.AutoSize = true;
            this.cb_Marathi.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Marathi.Location = new System.Drawing.Point(25, 31);
            this.cb_Marathi.Name = "cb_Marathi";
            this.cb_Marathi.Size = new System.Drawing.Size(78, 21);
            this.cb_Marathi.TabIndex = 11;
            this.cb_Marathi.Text = "Marathi";
            this.cb_Marathi.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(644, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hobbies";
            // 
            // clb_Hobbies
            // 
            this.clb_Hobbies.Font = new System.Drawing.Font("Modern No. 20", 11.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_Hobbies.FormattingEnabled = true;
            this.clb_Hobbies.Items.AddRange(new object[] {
            "Cycling",
            "Driving",
            "Travelling",
            "Gaming ",
            "Cooking",
            "Reading"});
            this.clb_Hobbies.Location = new System.Drawing.Point(868, 253);
            this.clb_Hobbies.Name = "clb_Hobbies";
            this.clb_Hobbies.Size = new System.Drawing.Size(126, 137);
            this.clb_Hobbies.TabIndex = 15;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Name.Location = new System.Drawing.Point(472, 153);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(37, 15);
            this.lbl_Name.TabIndex = 30;
            this.lbl_Name.Text = "Error";
            // 
            // lbl_Gen
            // 
            this.lbl_Gen.AutoSize = true;
            this.lbl_Gen.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Gen.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Gen.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gen.ForeColor = System.Drawing.Color.Red;
            this.lbl_Gen.Location = new System.Drawing.Point(472, 363);
            this.lbl_Gen.Name = "lbl_Gen";
            this.lbl_Gen.Size = new System.Drawing.Size(37, 15);
            this.lbl_Gen.TabIndex = 31;
            this.lbl_Gen.Text = "Error";
            // 
            // lbl_Dep
            // 
            this.lbl_Dep.AutoSize = true;
            this.lbl_Dep.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Dep.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Dep.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dep.ForeColor = System.Drawing.Color.Red;
            this.lbl_Dep.Location = new System.Drawing.Point(472, 261);
            this.lbl_Dep.Name = "lbl_Dep";
            this.lbl_Dep.Size = new System.Drawing.Size(37, 15);
            this.lbl_Dep.TabIndex = 32;
            this.lbl_Dep.Text = "Error";
            // 
            // lbl_Hobbie
            // 
            this.lbl_Hobbie.AutoSize = true;
            this.lbl_Hobbie.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Hobbie.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Hobbie.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hobbie.ForeColor = System.Drawing.Color.Red;
            this.lbl_Hobbie.Location = new System.Drawing.Point(920, 393);
            this.lbl_Hobbie.Name = "lbl_Hobbie";
            this.lbl_Hobbie.Size = new System.Drawing.Size(37, 15);
            this.lbl_Hobbie.TabIndex = 34;
            this.lbl_Hobbie.Text = "Error";
            // 
            // lbl_Lang
            // 
            this.lbl_Lang.AutoSize = true;
            this.lbl_Lang.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Lang.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Lang.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lang.ForeColor = System.Drawing.Color.Red;
            this.lbl_Lang.Location = new System.Drawing.Point(991, 228);
            this.lbl_Lang.Name = "lbl_Lang";
            this.lbl_Lang.Size = new System.Drawing.Size(37, 15);
            this.lbl_Lang.TabIndex = 35;
            this.lbl_Lang.Text = "Error";
            // 
            // Use_CheckBox_CheckListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 538);
            this.Controls.Add(this.lbl_Lang);
            this.Controls.Add(this.lbl_Hobbie);
            this.Controls.Add(this.lbl_Dep);
            this.Controls.Add(this.lbl_Gen);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.clb_Hobbies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gb_knownlanguages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.Gr_Gender);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.cmb_Edepartment);
            this.Controls.Add(this.tb_EName);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Edepartment);
            this.Controls.Add(this.lbl_Ename);
            this.Controls.Add(this.label1);
            this.Name = "Use_CheckBox_CheckListBox";
            this.Text = "Use_CheckBox_CheckListBox";
            this.Gr_Gender.ResumeLayout(false);
            this.Gr_Gender.PerformLayout();
            this.gb_knownlanguages.ResumeLayout(false);
            this.gb_knownlanguages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.GroupBox Gr_Gender;
        private System.Windows.Forms.RadioButton Rd_Female;
        private System.Windows.Forms.RadioButton Rd_Male;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.ComboBox cmb_Edepartment;
        private System.Windows.Forms.TextBox tb_EName;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Edepartment;
        private System.Windows.Forms.Label lbl_Ename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_knownlanguages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clb_Hobbies;
        private System.Windows.Forms.CheckBox cb_french;
        private System.Windows.Forms.CheckBox cb_Hindi;
        private System.Windows.Forms.CheckBox cb_English;
        private System.Windows.Forms.CheckBox cb_Marathi;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Gen;
        private System.Windows.Forms.Label lbl_Dep;
        private System.Windows.Forms.Label lbl_Hobbie;
        private System.Windows.Forms.Label lbl_Lang;
    }
}