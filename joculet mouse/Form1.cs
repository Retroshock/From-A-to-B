using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace joculet_mouse
{
    public partial class Form1 : Form
    {
        int i;
        bool gresit = false;
        //SoundPlayer sp = new SoundPlayer();
        public Form1()
        {
            
            InitializeComponent();
            timer2.Start();        
            var start = label10.Location;
            start.Offset(30, 30);
            Cursor.Position = PointToScreen(start);
            
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (gresit == false)
            {
                MessageBox.Show("Stay on the red line", "Rule: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                i = 200;
                timer1.Start();
                gresit=true;
            }
                
                
        }

        private void label11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Well Done", "Well done !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
            //sp.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                var start = label10.Location;
                start.Offset(30, 30);
                Cursor.Position = PointToScreen(start);
                label13.Text = Convert.ToString(i);
                i--;
            }
            else
            {
                timer1.Stop();
                gresit = false;
                label13.Text = " ";
            }
        }

        private void Escape_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //sp.Stop();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //sp.Stream = Properties.Resources.Background1;
            //sp.PlayLooping();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
