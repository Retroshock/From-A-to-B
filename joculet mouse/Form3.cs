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
    public partial class Form3 : Form
    {
        bool ok1 = false, ok2 = false,gresit=false;
        int i;
        public Form3()
        {
            InitializeComponent();
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {                      
            label24.Enabled = true;
            label24.Visible = true;
        }

        private void label24_Click(object sender, EventArgs e)
        {
            ok1 = true;
            label28.Enabled = true;
        }

        private void label28_MouseEnter(object sender, EventArgs e)
        {
            label26.Enabled = true;
            label26.Visible = true;
        }

        private void label26_Click(object sender, EventArgs e)
        {
            ok2 = true;
            label27.Enabled = true;
            label27.Visible = true;
        }

        private void label27_MouseEnter(object sender, EventArgs e)
        {
            if (ok1 && ok2)
            {
                label11.Enabled = true;
                label11.Visible = true;
            }
        }

        private void Form3_MouseEnter(object sender, EventArgs e)
        {
            if (gresit == false)
            {
                MessageBox.Show("Remember the rules", "Retry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);

                i = 200;
                timer1.Start();
                label11.Visible = false;
                label26.Visible = false;
                label24.Visible = false;
                ok1 = false;
                ok2 = false;
                gresit = true;
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var start = label10.Location;
            start.Offset(30, 30);
            Cursor.Position = PointToScreen(start);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form4 f4=new Form4();
            
            f4.Show();
            
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                label31.Text = Convert.ToString(i);
                i--;
            }
            else
            {
                timer1.Stop();
                gresit = false;
                label31.Text = " ";
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

    }
}
