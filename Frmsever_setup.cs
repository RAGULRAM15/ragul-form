using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Frmserver_setup : Form
    {
        public Frmserver_setup()
        {
            InitializeComponent();
        }
        void Selecttxt(TextBox txt)
        {
            txt.BackColor = Color.FromArgb(139, 199, 255);
        }
        void leavetxt(TextBox txt)
        {
            txt.BackColor = Color.White;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtdatabase.Text = "";
            txtservername.Text = "";
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void txtdatabase_MouseClick(object sender, MouseEventArgs e)
        {
            Selecttxt(txtdatabase);
        }

        private void txtservername_MouseClick(object sender, MouseEventArgs e)
        {
            Selecttxt(txtservername);
        }

        private void txtusername_MouseClick(object sender, MouseEventArgs e)
        {
            Selecttxt(txtusername);
        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            Selecttxt(txtpassword);
        }

        private void txtdatabase_Leave(object sender, EventArgs e)
        {
            leavetxt(txtdatabase);
        }

        private void txtservername_Leave(object sender, EventArgs e)
        {
            leavetxt(txtservername);
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            leavetxt(txtusername);
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            leavetxt(txtpassword);
        }

        private void btnok_Click(object sender, EventArgs e)
        {

        }
    }
}
