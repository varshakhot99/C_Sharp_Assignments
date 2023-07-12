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
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
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

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "31-12-2009";
            cmb_Course.SelectedIndex = -1;

           // tb_Roll_No.Focus();
        }

        private void Search_Student_Load(object sender, EventArgs e)
        {
            tb_Roll_No.Focus();
            lbl_Uname.Text = Common_Content.Log_UName;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con.Open();

            if (tb_Roll_No.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Select * From Student_Details where Roll_No = @RNo";

                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader Dr = cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                    tb_Mob_No.Text = (Dr["Mob_No"].ToString());
                    dtp_DOB.Text = (Dr["DOB"].ToString());
                    //cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
                }
                else
                {
                    MessageBox.Show("No Student Found With Given Roll No", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tb_Roll_No.Clear();
                    tb_Roll_No.Focus();
                }
            }
            else
            {
                MessageBox.Show("1st Enter Roll No", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Con.Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
    }
}
