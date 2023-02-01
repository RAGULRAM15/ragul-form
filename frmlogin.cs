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

namespace IMS
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "USER NAME" && txtpassword.Text == "USER PASSWORD")
            {
                new Frmyearselection().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Try Again...Check Your Username and Password");
                txtuser.Clear();
                txtpassword.Clear();
                txtuser.Focus();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar=='*')
            {
                btnshow.BringToFront();
                txtpassword.PasswordChar = '\0';
                
            }
            else
            {
                btnshow.BringToFront();
                txtpassword.PasswordChar = '*';
            }
            
             //btnshow.FlatStyle = FlatStyle.Flat;
             btnshow.FlatAppearance.BorderSize = 0;

            
        }

        private void panel_login_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (txtpassword.PasswordChar == '\0')
        //    {
        //        btnshow.BringToFront();
        //        txtpassword.PasswordChar = '*';
        //    }
        //}

        //private void showcheck_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (showcheck.Checked == true)
        //    {
        //        txtpassword.UseSystemPasswordChar = false;
        //    }
        //    else
        //    {
        //        txtpassword.UseSystemPasswordChar = true;
        //    }
        //}

        //private void showcheck_CheckedChanged(object sender, EventArgs e)
        //{
        //    
        //}
    }
}
