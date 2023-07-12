
namespace Student_Management_System
{
    partial class frm_Courses_List
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Courses_List));
            this.lbl_Header = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.courseIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.student_Mgt_System_DBDataSet1 = new Student_Management_System.Student_Mgt_System_DBDataSet1();
            this.courses_DetailsTableAdapter = new Student_Management_System.Student_Mgt_System_DBDataSet1TableAdapters.Courses_DetailsTableAdapter();
            this.lbl_Uname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Mgt_System_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Header.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(322, 41);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(264, 36);
            this.lbl_Header.TabIndex = 19;
            this.lbl_Header.Text = "COURSES LIST";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIdDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coursesDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(120, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(672, 324);
            this.dataGridView1.TabIndex = 20;
            // 
            // courseIdDataGridViewTextBoxColumn
            // 
            this.courseIdDataGridViewTextBoxColumn.DataPropertyName = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.HeaderText = "Course_Id";
            this.courseIdDataGridViewTextBoxColumn.Name = "courseIdDataGridViewTextBoxColumn";
            this.courseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesDetailsBindingSource
            // 
            this.coursesDetailsBindingSource.DataMember = "Courses_Details";
            this.coursesDetailsBindingSource.DataSource = this.student_Mgt_System_DBDataSet1;
            // 
            // student_Mgt_System_DBDataSet1
            // 
            this.student_Mgt_System_DBDataSet1.DataSetName = "Student_Mgt_System_DBDataSet1";
            this.student_Mgt_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courses_DetailsTableAdapter
            // 
            this.courses_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_Uname
            // 
            this.lbl_Uname.AutoSize = true;
            this.lbl_Uname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Uname.Font = new System.Drawing.Font("Modern No. 20", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname.Location = new System.Drawing.Point(22, 21);
            this.lbl_Uname.Name = "lbl_Uname";
            this.lbl_Uname.Size = new System.Drawing.Size(149, 24);
            this.lbl_Uname.TabIndex = 21;
            this.lbl_Uname.Text = "LoggedInUser";
            // 
            // frm_Courses_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(854, 461);
            this.Controls.Add(this.lbl_Uname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Courses_List";
            this.Text = "frm_Courses_List";
            this.Load += new System.EventHandler(this.frm_Courses_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_Mgt_System_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Student_Mgt_System_DBDataSet1 student_Mgt_System_DBDataSet1;
        private System.Windows.Forms.BindingSource coursesDetailsBindingSource;
        private Student_Mgt_System_DBDataSet1TableAdapters.Courses_DetailsTableAdapter courses_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_Uname;
    }
}