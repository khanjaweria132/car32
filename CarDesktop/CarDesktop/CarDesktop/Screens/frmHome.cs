﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDesktop.Screens
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 8)
            {
                imageNumber = 1;
            }
            pictureBoxSlider.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void movepanel(Control btn)
        {
            panelHeader.Width = btn.Width;
            panelHeader.Left = btn.Left;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            movepanel(btnHome);
            this.Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnHome);
        }

        private void btnCategory_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnCategory);
            panelDropDown.Visible = true;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            movepanel(btnProduct);
            this.Hide();
            frmProduct p = new frmProduct();
            p.Show();
        }

        private void btnProduct_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnProduct);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            movepanel(btnAbout);
            this.Hide();
            frmAbout b = new frmAbout();
            b.Show();
        }

        private void btnAbout_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnAbout);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            movepanel(btnContact);
            this.Hide();
            frmContact b = new frmContact();
            b.Show();
        }

        private void btnContact_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnContact);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void AppClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panelDropDown_MouseEnter(object sender, EventArgs e)
        {
            panelDropDown.Visible = true;

        }

        private void panelDropDown_MouseLeave(object sender, EventArgs e)
        {
            panelDropDown.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmBuyer home = new frmBuyer();
            home.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmHistory home = new frmHistory();
            home.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmPower home = new frmPower();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFirst home = new frmFirst();
            home.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmModels home = new frmModels();
            home.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFuseBox home = new frmFuseBox();
            home.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBolt home = new frmBolt();
            home.Show();
        }
    }
}
