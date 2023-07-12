
namespace Student_Management_System
{
    partial class frm_Add_New_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Student));
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Stud_List = new System.Windows.Forms.Button();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(278, 54);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(362, 36);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "ADD NEW STUDENT";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Modern No. 20", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_Roll_No.Location = new System.Drawing.Point(162, 154);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(79, 24);
            this.lbl_Roll_No.TabIndex = 2;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Modern No. 20", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_Name.Location = new System.Drawing.Point(162, 215);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(61, 24);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(162, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mobile No";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Font = new System.Drawing.Font("Modern No. 20", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dob.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_dob.Location = new System.Drawing.Point(162, 339);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(66, 24);
            this.lbl_dob.TabIndex = 5;
            this.lbl_dob.Text = "D.O.B";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Modern No. 20", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.FloralWhite;
            this.lbl_Course.Location = new System.Drawing.Point(162, 398);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(69, 24);
            this.lbl_Course.TabIndex = 6;
            this.lbl_Course.Text = "Course";
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Enabled = false;
            this.tb_Roll_No.Location = new System.Drawing.Point(383, 154);
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(310, 20);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(383, 220);
            this.tb_Name.MaxLength = 60;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(310, 20);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Location = new System.Drawing.Point(383, 280);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(310, 20);
            this.tb_Mob_No.TabIndex = 3;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Location = new System.Drawing.Point(383, 339);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(310, 20);
            this.dtp_DOB.TabIndex = 4;
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCA",
            "BCS",
            "B.Sc",
            "B.Com"});
            this.cmb_Course.Location = new System.Drawing.Point(383, 398);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(310, 21);
            this.cmb_Course.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(330, 474);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(139, 33);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(66, 474);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(139, 33);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "REFRESH";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Stud_List
            // 
            this.btn_Stud_List.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stud_List.Location = new System.Drawing.Point(577, 474);
            this.btn_Stud_List.Name = "btn_Stud_List";
            this.btn_Stud_List.Size = new System.Drawing.Size(209, 33);
            this.btn_Stud_List.TabIndex = 8;
            this.btn_Stud_List.Text = "STUDENT LIST";
            this.btn_Stud_List.UseVisualStyleBackColor = true;
            this.btn_Stud_List.Click += new System.EventHandler(this.btn_Stud_List_Click);
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Uname.Font = new System.Drawing.Font("Modern No. 20", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.Location = new System.Drawing.Point(24, 16);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(149, 24);
            this.lbl_Uname.TabIndex = 12;
            this.lbl_Uname.Text = "LoggedInUser";
            // 
            // frm_Add_New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.btn_Stud_List);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Add_New_Student";
            this.Text = "frm_Add_New_Student";
            this.Load += new System.EventHandler(this.frm_Add_New_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Stud_List;
        private System.Windows.Forms.Label lbl_Uname;
    }
}