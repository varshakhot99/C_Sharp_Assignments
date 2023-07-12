using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class frm_Add_Course : Form
    {
        public frm_Add_Course()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NVH3632\SQLEXPRESS;Initial Catalog=Student_Mgt_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Cid.Clear();
            tb_Cname.Clear();

            tb_Cid.Focus();
        }

        void Auto_Incr()
        {
            Con.Open();

            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) from Courses_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Course_Id) from Courses_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1;
            }

            tb_Cid.Text = Convert.ToString(Cnt);

            Con.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Cid.Text != "" && tb_Cname.Text != "") 
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Courses_Details Values(@Cid, @CName)";

                Cmd.Parameters.Add("Cid", SqlDbType.Int).Value = tb_Cid.Text;
                Cmd.Parameters.Add("CName", SqlDbType.VarChar).Value = tb_Cname.Text;

                Con.Open();

                Cmd.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Record Inserted Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("1st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Auto_Incr();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Auto_Incr();
        }

        private void frm_Add_Course_Load(object sender, EventArgs e)
        {
            lbl_Uname.Text = Common_Content.Log_UName;
            tb_Cid.Focus();
            Auto_Incr();
        }
    }
}
