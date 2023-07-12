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
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
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

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "31-12-2009";
            cmb_Course.SelectedIndex = -1;

            tb_Name.Focus();
        }

        void Auto_Incr()
        {
            Con.Open();

            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) from Student_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if( Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Roll_No) from Student_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1;
            }

            tb_Roll_No.Text = Convert.ToString(Cnt);

            Con.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
        

            if(tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Details Values(@Roll_No, @Nm, @MobNo, @Dob, @Course)";

                Cmd.Parameters.Add("Roll_No", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

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

        private void btn_Stud_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
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

        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            lbl_Uname.Text = Common_Content.Log_UName;
            tb_Name.Focus();
            Auto_Incr();
        }
    }
}
