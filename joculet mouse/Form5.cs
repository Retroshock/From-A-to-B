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
    public partial class Form5 : Form
    {
        int i;
        bool gresit = false;
        public Form5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
            label4.Visible = true;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label5.Visible = true;
            label18.Visible = true;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label12.Visible = true;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label13.Visible = true;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label14.Visible = true;
            label40.Visible = true;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label15.Visible = true;
            label13.Visible = true;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label22.Visible = true;
        }

        private void label22_MouseEnter(object sender, EventArgs e)
        {
            label23.Visible = true;
            label35.Visible = true;
        }

        private void label35_MouseEnter(object sender, EventArgs e)
        {
            label36.Visible = true;
        }

        private void label36_MouseEnter(object sender, EventArgs e)
        {
            label37.Visible = true;
        }

        private void label37_MouseEnter(object sender, EventArgs e)
        {
            label38.Visible = true;
        }

        private void label38_Click(object sender, EventArgs e)
        {
            label39.Visible = true;
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label20.Visible = true;
            label19.Visible = true;
        }

        private void label20_MouseEnter(object sender, EventArgs e)
        {
            label15.Visible = true;
            label14.Visible = true;
        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            label30.Visible = true;
            label21.Visible = true;
            label20.Visible = true;
            label18.Visible = true;
        }

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            label15.Visible = true;
            label22.Visible = true;
            label19.Visible = true;
        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            label22.Visible = true;
            label35.Visible = true;
            label24.Visible = true;
        }

        private void label30_MouseEnter(object sender, EventArgs e)
        {
            label19.Visible = true;
            label31.Visible = true;
            label29.Visible = true;
        }

        private void label31_MouseEnter(object sender, EventArgs e)
        {
            label26.Visible = true;
            label27.Visible = true;
            label29.Visible = true;
        }

        private void label27_MouseEnter(object sender, EventArgs e)
        {
            label28.Visible = true;
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label29_MouseEnter(object sender, EventArgs e)
        {
            label24.Visible = true;
            label25.Visible = true;
            label30.Visible = true;
            label31.Visible = true;
        }

        private void label24_MouseEnter(object sender, EventArgs e)
        {
            label23.Visible = true;
            label25.Visible = true;
            label32.Visible = true;
            label29.Visible = true;
        }

        private void label32_MouseEnter(object sender, EventArgs e)
        {
            label34.Visible = true;
        }

        private void label34_MouseEnter(object sender, EventArgs e)
        {
            label33.Visible = true;
            label32.Visible = true;

        }

        private void label33_MouseEnter(object sender, EventArgs e)
        {
            label25.Visible = true;
            label25.Visible = true;
            label34.Visible = true; 
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            label27.Visible = true;
            label33.Visible = true;
        }

        private void label28_Click(object sender, EventArgs e)
        {
            label17.Visible = true;
            label16.Visible = true;
            label11.Visible = true;
            var cursor = label17.Location;
            cursor.Offset(25, 25);
            Cursor.Position=PointToScreen(cursor);
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label40.Visible = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            var start = label10.Location;
            start.Offset(30, 20);
            Cursor.Position = PointToScreen(start);
        }

        private void label25_Click(object sender, EventArgs e)
        {
            label26.Visible = true;
        }

        private void Form5_MouseEnter(object sender, EventArgs e)
        {
            if (gresit == false)
            {
                MessageBox.Show("Remember the rules", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                i = 200;
                timer1.Start();
                gresit = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                label41.Text = Convert.ToString(i);
                i--;
            }
            else
            {
                timer1.Stop(); gresit = false;
                label41.Text = " ";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Close();
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
    }
}
