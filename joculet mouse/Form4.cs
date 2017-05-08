using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joculet_mouse
{
    public partial class Form4 : Form
    {
        int i;
        bool gresit = false;
        public Form4()
        {
            InitializeComponent();
        }

        int pasi = -5;
        int originalX;

        private void Form4_Load(object sender, EventArgs e)
        {
            originalX = label6.Location.X;
            var start = label10.Location;
            start.Offset(30, 20);
            Cursor.Position = PointToScreen(start);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Location = new Point(label6.Location.X + pasi, label6.Location.Y);
            if (label6.Location.X <= label5.Location.X + 32)
            {
                pasi = 5;
            }
            else
                if (label6.Location.X > originalX)
                {
                    pasi = -5;
                }
                else
                    if (label6.Location.X == originalX)
                    {
                        if (timer1.Interval == 100)
                            timer1.Interval = 1000;
                        else
                            timer1.Interval = 100;
                    }
        }

        private void Form4_MouseEnter(object sender, EventArgs e)
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

        private void label11_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();

            f4.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form5 f5= new Form5();
            f5.Show();
            this.Hide();
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        

    }
}
