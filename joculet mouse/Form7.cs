using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace joculet_mouse
{
    public partial class Form7 : Form
    {
        public bool revenire = false;
        bool pas1, pas2, pas3, pas4;
        int i,Rev;
        public Form7(int revenire)
        {
            Rev = revenire;
            InitializeComponent();
            switch (revenire)
            {
                case 0:  
                    pas1=pas2=pas3=pas4=false;
                    break;
                case 1:
                    pas1 = true;
                    pas2 = pas3 = pas4 = false;
                    break;
                case 2:
                    pas1=pas2 = true;
                    pas3 = pas4 = false;
                    break;
                case 3:
                    pas1=pas2=pas3 = true;
                    pas4 = false;
                    break;
                case 4:
                    pas1=pas2=pas3=pas4 = true;
                    break;
            }

            
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form f8 = new Form8();
            f8.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            var start = label10.Location;
            start.Offset(30, 30);
            Cursor.Position = PointToScreen(start);
            if (pas1)
            {
                pictureBox1.Image = Properties.Resources.Mini1;
                label1.Visible = true;
                label2.Visible=false;
            }
            if (pas2)
            {
                pictureBox3.Image = Properties.Resources.Mini2;
                label1.Visible = false;
                label4.Visible = true;
            }
            if (pas3)
            {
                pictureBox4.Image = Properties.Resources.Mini3;
                label1.Visible = false;
                label4.Visible = false;
                label5.Visible = true;
                label11.BackColor = Color.DarkRed;
                label11.Enabled = false;
                //bara laterala neagra sau schimbare de plansa

            }
            if (pas4)
            {
                pictureBox2.Image = Properties.Resources.Mini4;
                label1.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label11.BackColor = Color.Green;
                label11.Enabled = true;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (!pas1)
            {
                MessageBox.Show("Remember the rules", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                i = 50;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                //for (int j = 0; j < 10000; j++)
                //{
                    var start = label10.Location;
                    start.Offset(30, 30);
                    Cursor.Position = PointToScreen(start);
                    label14.Text = Convert.ToString(i);
                //}
                i--;
            }
            else
            {
                timer2.Stop();
                label14.Text = " ";
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            if (!pas2)
            {
                MessageBox.Show("Remember the rules", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                i = 50;
                timer2.Start();
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            if (!pas3)
            {
                MessageBox.Show("Remember the rules", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                i = 50;
                timer2.Start();
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            if (!pas4)
            {
                MessageBox.Show("Remember the rules", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                i = 50;
                timer2.Start();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form pasul1 = new mini1();
            this.Hide();
            
            
            //pas1 = true;
            pasul1.Show();
            //timer1.Start();
            //label2.Visible = false;
        }

        private void Escape_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                    this.Close();
                }
                else
                {
                    var start = label10.Location;
                    start.Offset(30, 30);
                    Cursor.Position = PointToScreen(start);
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (revenire)
            {
                this.Opacity = 1;
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                timer1.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form pasul2 = new Mini2();
            pasul2.Show();
            this.Close();
        }

        private void Form7_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Remember the rules", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            var start = label10.Location;
            start.Offset(30, 30);
            Cursor.Position = PointToScreen(start);
            i = 50;
            timer2.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form pasul3 = new Mini3();
            pasul3.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form pasul4 = new Mini4();
            pasul4.Show();
            this.Hide();
        }
    }
}
