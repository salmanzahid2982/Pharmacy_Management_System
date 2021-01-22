using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketProject
{
    public partial class Form1 : Form
    {
        
         
          
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            btnitem.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
        }

        private void btnitem_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel3.Controls.Clear();
            Item intrfrm = new Item();
            intrfrm.TopLevel = false;
            panel3.Controls.Add(intrfrm);
            intrfrm.Dock = DockStyle.Fill;
            intrfrm.BringToFront();
            intrfrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            Sales intrfrm = new Sales();
            intrfrm.TopLevel = false;
            panel3.Controls.Add(intrfrm);
            intrfrm.Dock = DockStyle.Fill;
            intrfrm.BringToFront();
            intrfrm.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            panel7.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;

            panel3.Controls.Clear();
            Accounts intrfrm = new Accounts();
            intrfrm.TopLevel = false;
            panel3.Controls.Add(intrfrm);
            intrfrm.Dock = DockStyle.Fill;
            intrfrm.BringToFront();
            intrfrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void btnitem_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void btnitem_MouseCaptureChanged(object sender, EventArgs e)
        {
         
        }

        private void btnitem_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void btnitem_MouseHover(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel6.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel4.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;


        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
        }
    }
}

