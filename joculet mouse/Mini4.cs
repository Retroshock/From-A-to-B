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
    public partial class Mini4 : Form
    {
        int i; bool gresit = false;
        //int p1, p2, p3;
        public Mini4()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form pasul4 = new Form7(4);
            pasul4.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Mini4_MouseEnter(object sender, EventArgs e)
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

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
            //label10.Visible = false;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label5.Visible = true;
            label1.Visible = false;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
            label6.Visible = false;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
            label5.Visible = false;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
            label4.Visible = false;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label15.Visible = true;
            label3.Visible = false;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label13.Visible = true;
            label2.Visible = false;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label12.Visible = true;
            label15.Visible = false;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label9.Visible = true;
            label13.Visible = false;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label28.Visible = true;
            label12.Visible = false;
        }

        private void label28_MouseEnter(object sender, EventArgs e)
        {
            label16.Visible = true;
            label9.Visible = false;
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label17.Visible = true;
            label28.Visible = false;
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label18.Visible = true;
            label16.Visible = false;
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label20.Visible = true;
            label17.Visible = false;
        }

        private void label20_MouseEnter(object sender, EventArgs e)
        {
            label19.Visible = true;
            label18.Visible = false;
        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            label22.Visible = true;
            label20.Visible = false;
        }

        private void label22_MouseEnter(object sender, EventArgs e)
        {
            label21.Visible = true;
            label19.Visible = false;
        }

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            label8.Visible = true;
            label22.Visible = false;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label7.Visible = true;
            label21.Visible = false;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label23.Visible = true;
            label8.Visible = false;
        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            label24.Visible = true;
            label7.Visible = false;
        }

        private void label24_MouseEnter(object sender, EventArgs e)
        {
            label25.Visible = true;
            label23.Visible = false;
        }

        private void label25_MouseEnter(object sender, EventArgs e)
        {
            label26.Visible = true;
            label24.Visible = false;
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            label30.Visible = true;
            label25.Visible = false;
        }

        private void label30_MouseEnter(object sender, EventArgs e)
        {
            label27.Visible = true;
            label26.Visible = false;
        }

        private void label27_MouseEnter(object sender, EventArgs e)
        {
            label29.Visible = true;
            label30.Visible = false;
        }

        private void label29_MouseEnter(object sender, EventArgs e)
        {
            label32.Visible = true;
            label27.Visible = false;
        }

        private void label32_MouseEnter(object sender, EventArgs e)
        {
            label31.Visible = true;
            label29.Visible = false;
        }

        private void label31_MouseEnter(object sender, EventArgs e)
        {
            label33.Visible = true;
            label32.Visible = false;
        }

        private void label33_MouseEnter(object sender, EventArgs e)
        {
            label34.Visible = true;
            label31.Visible = false;
        }

        private void label34_MouseEnter(object sender, EventArgs e)
        {
            label35.Visible = true;
            label33.Visible = false;
        }

        private void label35_MouseEnter(object sender, EventArgs e)
        {
            label11.Visible = true;
            label34.Visible = false;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            label35.Visible = false;
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
                Form reset = new Mini4();
                reset.Show();
                this.Hide();
                //this.Close();
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            var st = new Point();
            st = label16.Location;
            st.Offset(30, 20);
            Cursor.Position = PointToScreen(st);
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Mini4_Load(object sender, EventArgs e)
        {
            var start = label10.Location;
            start.Offset(30, 30);
            Cursor.Position = PointToScreen(start);
        }
    }
}
