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
    public partial class Start : Form
    {
        int originalX;
        int  pasi = 5,music=0;

        SoundPlayer sp = new SoundPlayer();
        
        public Start()
        {
            //timer3.Start();
            InitializeComponent();
            originalX = label6.Location.X;
            timer1.Start();
            timer2.Start();
            sp.Stream= Properties.Resources.Background;
            sp.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Location = new Point(label6.Location.X + pasi, label6.Location.Y);
            if (label6.Location.X <= label8.Location.X + 114)
            {
                pasi = 5;
            }
            else
                if (label6.Location.X > originalX)
                {
                    pasi = -5;
                }
               
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form dm = new Dummy(music);
            dm.Show();
            countdown.start = true;
            Form1 showform = new Form1();
            showform.Show();
            this.Hide();
            timer3.Stop();
            sp.Stop();
        }

        private void Escape_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timer2.Stop();
                if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                    this.Close();
                }
                else
                {
                    timer2.Start();
                    var start = label10.Location;
                    start.Offset(30, 30);
                    Cursor.Position = PointToScreen(start);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //this.TopMost = true ;
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (music == 0)
            {
                music = 1;
                label18.BackColor = Color.Green;
            }
            else
            {
                music = 0;
                label18.BackColor = Color.DimGray;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
