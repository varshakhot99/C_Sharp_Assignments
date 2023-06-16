using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Management_System
{
    public partial class frm_Book_List : Form
    {
        public frm_Book_List()
        {
            InitializeComponent();
        }

        private void frm_Book_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'book_Mgt_System_DBDataSet.Book_Details' table. You can move, or remove it, as needed.
            this.book_DetailsTableAdapter.Fill(this.book_Mgt_System_DBDataSet.Book_Details);

            lbl_UName.Text = Common_Content.Log_UName;

        }

        private void btn_Add_New_Book_Click(object sender, EventArgs e)
        {
            frm_Add_New_Book_Details obj = new frm_Add_New_Book_Details();
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
    }
}
