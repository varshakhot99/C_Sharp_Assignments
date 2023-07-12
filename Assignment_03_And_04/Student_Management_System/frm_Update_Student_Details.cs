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
    public partial class frm_Update_Student_Details : Form
    {
        public frm_Update_Student_Details()
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

            
        }

        void Enable_Controls()
        {
            tb_Roll_No.Enabled = false;
            tb_Name.Enabled = true;
            dtp_DOB.Enabled = true;
            tb_Mob_No.Enabled = true;
            cmb_Course.Enabled = true;
        }

        void Disable_Controls()
        {
            tb_Roll_No.Enabled = true;
            tb_Name.Enabled = false;
            dtp_DOB.Enabled = false;
            tb_Mob_No.Enabled = false;
            cmb_Course.Enabled = false;
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
                    cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));

                    Enable_Controls();
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con.Open();

            if (tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = Con;
                cmd.CommandText = "Update Student_Details Set Name = @Nm, DOB = @dob,Mob_No = @MobNo,Course = @Course where Roll_No = @Rno";

                cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;

                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("dob", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Disable_Controls();
            }
            else
            {
                MessageBox.Show("!st Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Only_NUmeric(object sender, KeyPressEventArgs e)
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

        private void frm_Update_Student_Details_Load(object sender, EventArgs e)
        {
            lbl_Uname.Text = Common_Content.Log_UName;
        }
    }
}
