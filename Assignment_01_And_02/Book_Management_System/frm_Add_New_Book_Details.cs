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

namespace Book_Management_System
{
    public partial class frm_Add_New_Book_Details : Form
    {
        public frm_Add_New_Book_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NVH3632\SQLEXPRESS;Initial Catalog=Book_Mgt_System_DB;Integrated Security=True");

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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_B_Id.Clear();
            tb_B_Name.Clear();
            dtp_Pdate.Text = "31-12-2009";
            tb_B_Price.Clear();

            tb_B_Name.Focus();
        }

        void Auto_Incr()
        {
            Con.Open();

            int Cnt = 0;
            SqlCommand Cmd= new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count (*) from Book_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if(Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Book_Id) from Book_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1;
            }

            tb_B_Id.Text = Convert.ToString(Cnt);
            
            Con.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           

            if(tb_B_Id.Text != "" && tb_B_Name.Text != "" && tb_B_Price.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Book_Details Values(@Id,@Nm,@Pdate,@Price)";

                Cmd.Parameters.Add("@Id", SqlDbType.Int).Value = tb_B_Id.Text;
                Cmd.Parameters.Add("@Nm", SqlDbType.VarChar).Value = tb_B_Name.Text;
                Cmd.Parameters.Add("@Pdate", SqlDbType.Date).Value = dtp_Pdate.Value.Date;
                Cmd.Parameters.Add("@Price", SqlDbType.Money).Value = tb_B_Price.Text;

                Con.Open();

                Cmd.ExecuteNonQuery();

                Con.Close();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btn_View_Book_List_Click(object sender, EventArgs e)
        {
            frm_Book_List obj = new frm_Book_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = (MessageBox.Show("LOGOUT", "Are You Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question));

            if(Res == DialogResult.Yes)
            {
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }
        }

        private void frm_Add_New_Book_Details_Load(object sender, EventArgs e)
        {
            lbl_UName.Text = Common_Content.Log_UName;
            tb_B_Name.Focus();
            Auto_Incr();
        }
    }
}
