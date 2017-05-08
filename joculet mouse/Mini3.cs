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
    public partial class Mini3 : Form
    {
        int i; bool gresit = false;
        int p1, p2, p3;
        public Mini3()
        {
            
            InitializeComponent();
        }

        private void Mini3_Load(object sender, EventArgs e)
        {
            var start = label10.Location;
            start.Offset(30, 30);
            Cursor.Position = PointToScreen(start);
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            if (p1 == 0)
            {
                p1 = 1;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (p1 < 200)
            {
                if (p1 % 4 == 0 && label1.Visible == true)
                    label1.Visible = false;
                else
                    if (p1 % 4 == 0)
                        label1.Visible = true;
                if (p1 % 7 == 0 && label7.Visible == true)
                    label7.Visible = false;
                else
                    if (p1 % 7 == 0)
                        label7.Visible = true;
                if (p1 % 5 == 0)
                    if (label9.Visible == true)
                        label9.Visible = false;
                    else
                        label9.Visible = true;
                p1++;

            }
            else p1 = 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                label22.Text = Convert.ToString(i);
                i--;
            }
            else
            {
                timer2.Stop();
                gresit = false;
                label22.Text = " ";
            }
        }

        private void Mini3_MouseEnter(object sender, EventArgs e)
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

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            timer1.Stop();
            label9.Visible = true;
            label1.Visible = true;
            label7.Visible = true;
            timer3.Start();
            timer4.Start();
            p3 = 1;
            p2 = 1;
            label6.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (p2 < 200)
            {
                if (p2 % 4 == 0 && label13.Visible == true)
                    label13.Visible = false;
                else
                    if (p2 % 4 == 0)
                        label13.Visible = true;
                if (p2 % 7 == 0 && label12.Visible == true)
                {
                    label12.Visible = false;
                    label17.Visible = false;
                }
                else
                    if (p2 % 7 == 0)
                    {
                        label17.Visible = true;
                        label12.Visible = true;
                    }
                if (p2 % 5 == 0)
                    if (label14.Visible == true)
                        label14.Visible = false;
                    else
                        label14.Visible = true;
                p2++;

            }
            else p2 = 1;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (p3 < 200)
            {
                if (p3 % 100 == 0 && label6.Visible == true)
                {
                    label6.Visible = false;
                    label15.Visible = false;
                    label16.Visible = false;

                }
                else
                    if (p3 % 100 == 0)
                    {
                        label6.Visible = true;
                        label16.Visible = true;
                        label15.Visible = true;
                    }
                p3++;
            }
            else
                p3=1;

            
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label17.Visible = true;
            label12.Visible = true;
            label14.Visible = true;
            label13.Visible = true;
            timer3.Stop();
            timer4.Stop();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form f7 = new Form7(3);
            f7.Show();
            this.Close();
        }
    }
}
