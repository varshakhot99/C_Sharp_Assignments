using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls_Assignment
{
    public partial class Windows_Tools : Form
    {
        public Windows_Tools()
        {
            InitializeComponent();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Windows_Tools_Load(object sender, EventArgs e)
        {
            tb_EName.Focus();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool flag = false;

            if(tb_EName.Text != "")
            {
                Result = tb_EName.Text;

                if(cmb_Edepartment.Text != "")
                {
                    Result += " from Department " + cmb_Edepartment.Text + " is ";

                    if(Rd_Male.Checked == true)
                    {
                        Result += Rd_Male.Text + " candidate, Prefers shift timing";
                    }
                    else if(Rd_Female.Checked == true)
                    {
                        Result += Rd_Female.Text + " candidate, Prefers shift timing ";
                    }
                    else
                    {
                        MessageBox.Show("Select Gender of Employee");
                        flag = true;
                    }

                    if(Rd_Morning.Checked == true)
                    {
                        Result += Rd_Morning.Text + ".";
                    }
                    else if(Rd_Evening.Checked == true)
                    {
                        Result += Rd_Evening.Text + ".";
                    }
                    else if(Rd_Night.Checked == true)
                    {
                        Result += Rd_Night.Text + ".";
                    }
                    else
                    {
                        MessageBox.Show("Select Shift Time");
                        flag = true;
                    }
                }
                else
                {
                    MessageBox.Show("Enter Name Of Employee");
                    flag = true;
                }

                if(flag == false)
                {
                    tb_Output.Text = Result;
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_EName.Clear();
            tb_Output.Clear();
            cmb_Edepartment.SelectedIndex = -1;

            Rd_Male.Checked = false;
            Rd_Female.Checked = false;

            Rd_Morning.Checked = false;
            Rd_Evening.Checked = false;
            Rd_Night.Checked = false;
        }
    }
}
