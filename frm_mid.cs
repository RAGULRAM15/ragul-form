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
    public partial class frm_mid : Form
    {
        public frm_mid()
        {
            InitializeComponent();
            //frm_home frm = new frm_home;
            //addfrm_mid(frm);
        }
        private void add_ucontrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnladd_page.Controls.Clear();
            pnladd_page.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if(pnlclose.Width == 310)
            {

                for (int i = 0; i < 10; i++)
                    pnlclose.Width = pnlclose.Width - 30;
                pnltop.Visible = true;
                pnlright.Visible = false;
                pnlclose.Visible = true;
            }
            else
            {
                for (int i = 0; i < 10; i++)
                    pnlclose.Width = pnlclose.Width + 30;

                pnlright.Visible = true;
                pnltop.Visible = false;
                pnlclose.Visible = false;
            }
            Timer.Stop();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            Timer.Start();
            pnlright.Enabled = true;
            pnlright.Visible = true;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Timer.Start();
            pnlright.Enabled = false;
            pnlright.Visible = false;
        }

        private void frm_mid_Load(object sender, EventArgs e)
        {
            pnlclose.Width = 0;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //private void btn_click(object sender, EventArgs e)
        //{
        //    foreach (var pnl in tableLayoutPanel2.Controls.OfType<Panel>())
        //    {
        //        pnl.BackColor = Color.White;
        //    }
        //    Button btn = (Button)sender;
        //    switch(btn.Name)
        //    {
        //        case"btnhome"
        //            {
        //                add_ucontrol(new frm_home());
        //                pnladd_page.BackColor = Color.FromArgb(249, 249, 249);
        //                break;
        //            }

        //        default:
        //            break;
        //    }
        //}

        private void btnhome_Click(object sender, EventArgs e)
        {
            //frm_home mf = new frm_home;
            //addfrm_mid(mf);


        }

        private void btnmaster_Click(object sender, EventArgs e)
        {
            
        }

        private void btnreports_Click(object sender, EventArgs e)
        {

        }

        private void btnform_Click(object sender, EventArgs e)
        {
            

        }

        private void btnsettings_Click(object sender, EventArgs e)
        {

        }

        private void pnladd_page_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
