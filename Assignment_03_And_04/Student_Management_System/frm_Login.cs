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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NVH3632\SQLEXPRESS;Initial Catalog=Student_Mgt_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if(Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Enter Valid Username && Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Con.Open();

            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) from Login_Details where Username = @Unm And Password = @Pwd";

            Cmd.Parameters.Add("Unm", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

           /* if(tb_Username.Text == "SGM" && tb_Password.Text =="karad")
            {
                MessageBox.Show("Login Successful");

                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();
            }*/

            if(Cnt>0)
            {
                MessageBox.Show("Login Successful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Common_Content.Log_UName = tb_Username.Text;

                MDI_Student_App obj = new MDI_Student_App();
                obj.Show();
                this.Hide();

              /*  frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();*/
            }
            else
            {
                lbl_Note.Text = "Incorrect Username Or Password";
                lbl_Note.ForeColor = Color.Red;
            }

            tb_Username.Clear();
            tb_Password.Clear();

          //  tb_Password.Enabled = false;
          //  btn_Submit.Enabled = false;

            tb_Username.Focus();

            Con.Close();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            lbl_Note.Visible = true;
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }
    }
}
