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
    public partial class Mini2 : Form
    {
        int i;
        int l1, l2, l3, l4, l5, l6, l7;
        bool gresit = false;
        public Mini2()
        {

            InitializeComponent();
            l1 = l2 = l3 = l4 = l5 = l6 = l7 = 4;
            timer1.Start();
        }

        private void Mini2_MouseEnter(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
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
                timer2.Stop();
                gresit = false;
                label14.Text = " ";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Location.X>6&&label1.Location.X<310)
                label1.Location=new Point(label1.Location.X+l1,label1.Location.Y);
            else
                {
                    l1 *= (-1);
                    label1.Location = new Point(label1.Location.X + l1, label1.Location.Y);
                }
            if (label2.Location.X>6&&label2.Location.X<310)
                label2.Location=new Point(label2.Location.X+l2,label2.Location.Y);
            else
                {
                    l2 *= (-1);
                    label2.Location = new Point(label2.Location.X + l2, label2.Location.Y);
                }
            if (label3.Location.X>6&&label3.Location.X<310)
                label3.Location=new Point(label3.Location.X+l3,label3.Location.Y);
            else
                {
                    l3 *= (-1);
                    label3.Location = new Point(label3.Location.X + l3, label3.Location.Y);
                }
            if (label4.Location.X>6&&label4.Location.X<310)
                label4.Location=new Point(label4.Location.X+l4,label4.Location.Y);
            else
                {
                    l4 *= (-1);
                    label4.Location = new Point(label4.Location.X + l4, label4.Location.Y);
                }
            if (label5.Location.X>6&&label5.Location.X<310)
                label5.Location=new Point(label5.Location.X+l5,label5.Location.Y);
            else
                {
                    l5 *= (-1);
                    label5.Location = new Point(label5.Location.X + l5, label5.Location.Y);
                }
            if (label6.Location.X>6&&label6.Location.X<310)
                label6.Location=new Point(label6.Location.X+l6,label6.Location.Y);
            else
                {
                    l6 *= (-1);
                    label6.Location = new Point(label6.Location.X + l6, label6.Location.Y);
                }
            if (label7.Location.X > 6 && label7.Location.X < 310)
                label7.Location = new Point(label7.Location.X + l7, label7.Location.Y);
            else
                {
                    l7 *= (-1);
                    label7.Location = new Point(label7.Location.X + l7, label7.Location.Y);
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

        private void Mini2_Load(object sender, EventArgs e)
        {

            var start = label10.Location;
            start.Offset(30, 30);
            Cursor.Position = PointToScreen(start);

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(2);
            f7.Show();
            this.Close();
        }
    }
}
