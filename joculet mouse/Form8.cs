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
    public partial class Form8 : Form
    {
        int pas = 1;//14
        bool gresit = false;
        int b, r, o, k, E, n;
        void reset()
        {
                b = 0;
                r = 0;
                o = 0;
                k = 0;
                E = 0;
                n = 0;
                label18.Text = " ";
                label19.Text = " ";
                label28.Text = " ";
                label31.Text = " ";
                label35.Text = " ";
                label37.Text = " ";
        
        }
        void afisare(int pas)
        {
            if (pas == 1)
                label1.Visible = true;
            if (pas == 2)
                label2.Visible = true;
            if (pas == 3)
                label3.Visible = true;
            if (pas == 4)
                label4.Visible = true;
            if (pas == 5)
                label5.Visible = true;
            if (pas == 6)
                label6.Visible = true;
            if (pas == 7)
                label7.Visible = true;
            if (pas == 8)
                label8.Visible = true;
            if (pas == 9)
                label9.Visible = true;
            if (pas == 10)
                label12.Visible = true;
            if (pas == 11)
                label13.Visible = true;
            if (pas == 12)
                label15.Visible = true;
            if (pas == 13)
                label16.Visible = true;
            if (pas == 14)
            {
                label17.Visible = true;
                //egg
            }
        }
        int i;
        public Form8()
        {
            InitializeComponent();

        }
   
        private void Form8_KeyDown(object sender, KeyEventArgs e)
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
            if (n != 1)
            {
                
                if (e.KeyCode == Keys.A)
                {
                    label18.Text = " ";
                    label19.Text = " ";
                    label28.Text = " ";
                    label31.Text = " ";
                    label35.Text = " ";
                    label37.Text = " ";
                    label22.Visible = true;
                    label25.Visible = true;
                }
                if (e.KeyCode == Keys.B)
                {
                    label18.Text = "B";
                    b = 1;
                }
                if (e.KeyCode == Keys.R)
                {
                    if (r == 1)
                    {
                        //r = 0;
                        reset();
                    }
                    else
                        if (b == 1)
                        {
                            label19.Text = "R";
                            r = 1;
                        }
                        else
                        {
                            reset();
                        }
                }
                if (e.KeyCode == Keys.O)
                {
                    if (o == 1)
                    {
                        reset();
                    }
                    else
                        if (r == 1)
                        {
                            o = 1;
                            label31.Text = "O";
                        }
                        else
                        {
                            reset();
                        }
                }
                if (e.KeyCode == Keys.K)
                {
                    if (k == 1)
                    {
                        reset();
                    }
                    else
                        if (o == 1)
                        {
                            k = 1;
                            label28.Text = "K";
                        }
                        else
                        {
                            reset();
                        }
                }
                if (e.KeyCode == Keys.E)
                {
                    if (E == 1)
                    {
                        reset();
                    }
                    else
                        if (k == 1)
                        {
                            E = 1;
                            label35.Text = "E";
                        }
                        else
                        {
                            reset();
                        }
                }
                if (e.KeyCode == Keys.N)
                {
                    if (n == 1)
                    {
                        reset();
                    }
                    else
                        if (E == 1)
                        {
                            n = 1;
                            label37.Text = "N";
                        }
                        else
                        {
                            reset();
                        }
                }

                if (e.KeyCode == Keys.C)
                {

                    reset();
                    label20.Visible = true;
                }
                if (e.KeyCode == Keys.D)
                {

                    reset();
                    label36.Visible = true;
                }
                if (e.KeyCode == Keys.Q)
                {

                    reset();
                    label23.Visible = true;
                }
                if (e.KeyCode == Keys.F)
                {

                    reset();
                    label34.Visible = true;
                }
                if (e.KeyCode == Keys.G)
                {
                    reset();
                    label33.Visible = true;
                }
                if (e.KeyCode == Keys.H)
                {
                    reset();
                    label21.Visible = true;
                }
                if (e.KeyCode == Keys.I)
                {
                    reset();
                    label26.Visible = true;
                }
                if (e.KeyCode == Keys.J)
                {
                    reset();
                    label32.Visible = true;
                }
                if (e.KeyCode == Keys.P)
                {
                    reset();
                    label30.Visible = true;
                }
                if (e.KeyCode == Keys.L)
                {
                    reset();
                    label40.Visible = true;
                }
                if (e.KeyCode == Keys.M)
                {
                    reset();
                    label38.Visible = true;
                }
                if (e.KeyCode == Keys.Q)
                {
                    reset();
                    label44.Visible = true;
                }
                if (e.KeyCode == Keys.Z)
                {
                    reset();
                    label27.Visible = true;
                }
                if (e.KeyCode == Keys.W)
                {
                    reset();
                    label45.Visible = true;
                }
                if (e.KeyCode == Keys.T)
                {
                    reset();
                    label46.Visible = true;
                }
                if (e.KeyCode == Keys.Y)
                {
                    reset();
                    label49.Visible = true;
                    label29.Visible = true;
                }
                if (e.KeyCode == Keys.U)
                {
                    reset();
                    label39.Visible = true;
                }
                //if (e.KeyCode == Keys.)
                //{
                //    label27.Visible = true;
                //}
            }
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                label14.Text = Convert.ToString(i);
                i--;
            }
            else
            {
                timer2.Stop(); gresit = false;
                label14.Text = " ";
            }
        }

        private void Form8_MouseEnter(object sender, EventArgs e)
        {
            if (gresit == false)
            {
                MessageBox.Show("Remember the rules", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                i = 200;
                timer2.Start();
                gresit = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n != 0)
                if (pas <= 14)
                {
                    afisare(pas);
                    pas++;
                }
                else
                    timer1.Stop();
                
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            var start = label10.Location;
            start.Offset(30, 30);
            Cursor.Position = PointToScreen(start);
            timer1.Start();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            countdown.stop = true;
            Form f9 = new Form9();
            f9.Show();
            this.Close();
        }
    }
}
