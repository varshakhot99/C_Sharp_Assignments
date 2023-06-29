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
    public partial class Use_CheckBox_CheckListBox : Form
    {
        public Use_CheckBox_CheckListBox()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = true;

            if (tb_EName.Text != "")
            {
                Result += tb_EName.Text + " is From Department ";
                lbl_Name.Visible = false;
            }
            else
            {
                lbl_Name.Text = "Enter Employee Name";
                lbl_Name.Visible = true;
                Flag = false;
            }

            if (cmb_Edepartment.Text != "")
            {
                Result += cmb_Edepartment.Text;
                lbl_Dep.Visible = false;
            }
            else
            {
                lbl_Dep.Visible = true;
                Flag = false;
            }

            if (Rd_Male.Checked == true)
            {
                Result += ", is " + Rd_Male.Text + " And He Knowa ";
                lbl_Gen.Visible = false;
            }
            else if (Rd_Female.Checked == true)
            {
                Result += ", is " + Rd_Female.Text + " And She Knows ";
                lbl_Gen.Visible = false;
            }
            else
            {
                lbl_Gen.Visible = true;
                Flag = false;
            }

            if (cb_Marathi.Checked == true)
            {
                Result += cb_Marathi.Text + " ,";
                lbl_Lang.Visible = false;
            }
            else if (cb_Hindi.Checked == true)
            {
                Result += cb_Hindi.Text + " ,";
                lbl_Lang.Visible = false;
            }
            else if (cb_English.Checked == true)
            {
                Result += cb_English.Text + " ,";
                lbl_Lang.Visible = false;
            }
            else if (cb_french.Checked == true)
            {
                Result += cb_french.Text + " ,";
                lbl_Lang.Visible = false;
            }
            else
            {
                lbl_Lang.Visible = true;
                Flag = false;
            }
            int Cnt = clb_Hobbies.CheckedItems.Count;

            if (Cnt > 0)
            {
                lbl_Hobbie.Visible = false;
                Result += " And Has Hobbies as ";
            }
            else
            {
                lbl_Hobbie.Visible = true;
                Flag = false;
            }

            for (int i = 0; i < clb_Hobbies.Items.Count; i++)
            {
                if (clb_Hobbies.GetItemChecked(i))
                {
                    if (Cnt > 1)
                    {
                        Result += clb_Hobbies.Items[i] + " ,";
                    }
                    else
                    {
                        Result += clb_Hobbies.Items[i] + " ,";
                    }

                    Cnt--;
                }
            }

            if (Flag == false)
            {
                tb_Output.Visible = false;
            }
            else
            {
                tb_Output.Text = Result;
                tb_Output.Visible = true;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_EName.Clear();
            cmb_Edepartment.SelectedIndex = -1;

            Rd_Male.Checked = false;
            Rd_Female.Checked = false;

            cb_Marathi.Checked = false;
            cb_Hindi.Checked = false;
            cb_English.Checked = false;
            cb_french.Checked = false;
        }
    }
 }
    

