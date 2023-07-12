
namespace Student_Management_System
{
    partial class frm_Add_Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_Course));
            this.lbl_Header = new System.Windows.Forms.Label();
            this.tb_Cname = new System.Windows.Forms.TextBox();
            this.tb_Cid = new System.Windows.Forms.TextBox();
            this.lbl_CName = new System.Windows.Forms.Label();
            this.lbl_CourseId = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Uname = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(320, 55);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(240, 36);
            this.lbl_Header.TabIndex = 18;
            this.lbl_Header.Text = "ADD COURSE";
            // 
            // tb_Cname
            // 
            this.tb_Cname.Location = new System.Drawing.Point(489, 280);
            this.tb_Cname.MaxLength = 8;
            this.tb_Cname.Name = "tb_Cname";
            this.tb_Cname.Size = new System.Drawing.Size(223, 20);
            this.tb_Cname.TabIndex = 2;
            // 
            // tb_Cid
            // 
            this.tb_Cid.Enabled = false;
            this.tb_Cid.Location = new System.Drawing.Point(489, 185);
            this.tb_Cid.MaxLength = 10;
            this.tb_Cid.Name = "tb_Cid";
            this.tb_Cid.Size = new System.Drawing.Size(223, 20);
            this.tb_Cid.TabIndex = 1;
            this.tb_Cid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_CName
            // 
            this.lbl_CName.AutoSize = true;
            this.lbl_CName.Font = new System.Drawing.Font("Modern No. 20", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CName.Location = new System.Drawing.Point(204, 280);
            this.lbl_CName.Name = "lbl_CName";
            this.lbl_CName.Size = new System.Drawing.Size(151, 22);
            this.lbl_CName.TabIndex = 22;
            this.lbl_CName.Text = "COURSE NAME";
            // 
            // lbl_CourseId
            // 
            this.lbl_CourseId.AutoSize = true;
            this.lbl_CourseId.Font = new System.Drawing.Font("Modern No. 20", 14.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CourseId.Location = new System.Drawing.Point(204, 185);
            this.lbl_CourseId.Name = "lbl_CourseId";
            this.lbl_CourseId.Size = new System.Drawing.Size(115, 22);
            this.lbl_CourseId.TabIndex = 20;
            this.lbl_CourseId.Text = "COURSE ID";
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(480, 376);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(139, 33);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Uname.Font = new System.Drawing.Font("Modern No. 20", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.Location = new System.Drawing.Point(32, 22);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(149, 24);
            this.lbl_Uname.TabIndex = 24;
            this.lbl_Uname.Text = "LoggedInUser";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(216, 376);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(139, 33);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "REFRESH";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(854, 461);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Cname);
            this.Controls.Add(this.tb_Cid);
            this.Controls.Add(this.lbl_CName);
            this.Controls.Add(this.lbl_CourseId);
            this.Controls.Add(this.lbl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Add_Course";
            this.Text = "frm_Add_Course";
            this.Load += new System.EventHandler(this.frm_Add_Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.TextBox tb_Cname;
        private System.Windows.Forms.TextBox tb_Cid;
        private System.Windows.Forms.Label lbl_CName;
        private System.Windows.Forms.Label lbl_CourseId;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Uname;
        private System.Windows.Forms.Button btn_Refresh;
    }
}