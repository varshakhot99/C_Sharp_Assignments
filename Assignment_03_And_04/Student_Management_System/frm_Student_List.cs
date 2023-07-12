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
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
        {
            InitializeComponent();
        }

        private void frm_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Mgt_System_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Mgt_System_DBDataSet.Student_Details);

            lbl_Uname.Text = Common_Content.Log_UName;

        }

        private void btn_Add_New_Stud_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student();
            obj.Show();
            this.Hide();
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
