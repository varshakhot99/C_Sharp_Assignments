using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class MDI_Student_App : Form
    {
        private int childFormNumber = 0;

        public MDI_Student_App()
        {
            InitializeComponent();
        }

        private void MDI_Student_App_Load(object sender, EventArgs e)
        {
            lbl_Uname.Text = Common_Content.Log_UName;
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details obj = new frm_Update_Student_Details();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Search_Student obj = new frm_Search_Student();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Course obj = new frm_Add_Course();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void courseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Courses_List obj = new frm_Courses_List();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.Exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.Exe");
        }

        private void maximumFromTwoNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\To find maximum from two numbers using if-else.exe");
        }

        private void bookShopAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\Project Assignment\Book_Management_System\bin\Debug\Book_Management_System.exe");
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = (MessageBox.Show("LOGOUT", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            if (Res == DialogResult.Yes)
            {
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }
        }
    }
}
