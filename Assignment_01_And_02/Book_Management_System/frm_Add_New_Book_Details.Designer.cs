
namespace Book_Management_System
{
    partial class frm_Add_New_Book_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Book_Details));
            this.lbl_Header = new System.Windows.Forms.Label();
            this.lbl_Book_Id = new System.Windows.Forms.Label();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.tb_B_Id = new System.Windows.Forms.TextBox();
            this.tb_B_Name = new System.Windows.Forms.TextBox();
            this.dtp_Pdate = new System.Windows.Forms.DateTimePicker();
            this.tb_B_Price = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_View_Book_List = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_UName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Header.Location = new System.Drawing.Point(260, 32);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(353, 34);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "ADD BOOK DETAILS";
            // 
            // lbl_Book_Id
            // 
            this.lbl_Book_Id.AutoSize = true;
            this.lbl_Book_Id.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Id.Location = new System.Drawing.Point(188, 131);
            this.lbl_Book_Id.Name = "lbl_Book_Id";
            this.lbl_Book_Id.Size = new System.Drawing.Size(88, 24);
            this.lbl_Book_Id.TabIndex = 2;
            this.lbl_Book_Id.Text = "Book_Id";
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.Location = new System.Drawing.Point(188, 204);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(118, 24);
            this.lbl_Book_Name.TabIndex = 3;
            this.lbl_Book_Name.Text = "Book_Name";
            // 
            // dtp_date
            // 
            this.dtp_date.AutoSize = true;
            this.dtp_date.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Location = new System.Drawing.Point(188, 267);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(132, 24);
            this.dtp_date.TabIndex = 4;
            this.dtp_date.Text = "Publish_Date";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(188, 334);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(114, 24);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "Book_Price";
            // 
            // tb_B_Id
            // 
            this.tb_B_Id.Enabled = false;
            this.tb_B_Id.Location = new System.Drawing.Point(396, 134);
            this.tb_B_Id.Name = "tb_B_Id";
            this.tb_B_Id.Size = new System.Drawing.Size(300, 20);
            this.tb_B_Id.TabIndex = 1;
            this.tb_B_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_B_Name
            // 
            this.tb_B_Name.Location = new System.Drawing.Point(396, 209);
            this.tb_B_Name.MaxLength = 200;
            this.tb_B_Name.Name = "tb_B_Name";
            this.tb_B_Name.Size = new System.Drawing.Size(300, 20);
            this.tb_B_Name.TabIndex = 2;
            this.tb_B_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // dtp_Pdate
            // 
            this.dtp_Pdate.Location = new System.Drawing.Point(396, 270);
            this.dtp_Pdate.Name = "dtp_Pdate";
            this.dtp_Pdate.Size = new System.Drawing.Size(300, 20);
            this.dtp_Pdate.TabIndex = 3;
            // 
            // tb_B_Price
            // 
            this.tb_B_Price.Location = new System.Drawing.Point(396, 334);
            this.tb_B_Price.MaxLength = 50;
            this.tb_B_Price.Name = "tb_B_Price";
            this.tb_B_Price.Size = new System.Drawing.Size(300, 20);
            this.tb_B_Price.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Save.Location = new System.Drawing.Point(367, 419);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 35);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Refresh.Location = new System.Drawing.Point(98, 419);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(162, 35);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "REFRESH";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_View_Book_List
            // 
            this.btn_View_Book_List.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_View_Book_List.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Book_List.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_View_Book_List.Location = new System.Drawing.Point(585, 419);
            this.btn_View_Book_List.Name = "btn_View_Book_List";
            this.btn_View_Book_List.Size = new System.Drawing.Size(247, 35);
            this.btn_View_Book_List.TabIndex = 7;
            this.btn_View_Book_List.Text = "VIEW BOOK LIST";
            this.btn_View_Book_List.UseVisualStyleBackColor = false;
            this.btn_View_Book_List.Click += new System.EventHandler(this.btn_View_Book_List_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Logout.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Logout.Location = new System.Drawing.Point(737, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(128, 35);
            this.btn_Logout.TabIndex = 8;
            this.btn_Logout.Text = "LOGOUT";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_UName
            // 
            this.lbl_UName.AutoSize = true;
            this.lbl_UName.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_UName.Location = new System.Drawing.Point(12, 20);
            this.lbl_UName.Name = "lbl_UName";
            this.lbl_UName.Size = new System.Drawing.Size(130, 21);
            this.lbl_UName.TabIndex = 9;
            this.lbl_UName.Text = "LoggedInUser";
            // 
            // frm_Add_New_Book_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(891, 516);
            this.Controls.Add(this.lbl_UName);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_View_Book_List);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_B_Price);
            this.Controls.Add(this.dtp_Pdate);
            this.Controls.Add(this.tb_B_Name);
            this.Controls.Add(this.tb_B_Id);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.lbl_Book_Name);
            this.Controls.Add(this.lbl_Book_Id);
            this.Controls.Add(this.lbl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Add_New_Book_Details";
            this.Text = "frm_Add_New_Book_Details";
            this.Load += new System.EventHandler(this.frm_Add_New_Book_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Book_Id;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.Label dtp_date;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox tb_B_Id;
        private System.Windows.Forms.TextBox tb_B_Name;
        private System.Windows.Forms.DateTimePicker dtp_Pdate;
        private System.Windows.Forms.TextBox tb_B_Price;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_View_Book_List;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_UName;
    }
}