using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
/*
    Observatii : 
 *  De pus sunet pe form
 *  De setat ca Form.TopMost

*/

namespace joculet_mouse
{
    public partial class mini1 : Form
    {
        int cntdwn,i, originalX, originalY;
        bool ok = true, fundal=true;
        
        public mini1()
        {
            InitializeComponent();
            
            var start = label10.Location;
            start.Offset(30, 20);
            Cursor.Position = PointToScreen(start);
            originalX = panel1.Location.X;
            originalY = panel1.Location.Y;
        }
        
        
        //System.Media.SoundPlayer startSound = new System.Media.SoundPlayer();

        private void button2_Click(object sender, EventArgs e)
        {
            if (ok)
            {
                
                button2.BackColor = Color.Red;
                cntdwn = 3;
                SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.Door);
                sp.Play();
                //pornire suner de inchidere                
                timer1.Start();
                ok = false;
            }
            else
            {
                button2.BackColor = Color.Red;
                //cntdwn = 3;            
                SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.Door);
                sp.Play();
                //pornire suner de inchidere                
                timer1.Start();
                ok = true ;
            }
        }

        private void mini1_MouseEnter(object sender, EventArgs e)
        {
            if (fundal)
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
                for (int j = 0; j < 10000; j++)
                {
                    var start = label10.Location;
                    start.Offset(30, 30);
                    Cursor.Position = PointToScreen(start);
                    label14.Text = Convert.ToString(i);
                }
                i--;
            }
            else
            {
                timer2.Stop();
                label14.Text = " ";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cntdwn > 0)
            {
                label2.Text = cntdwn.ToString();                
                cntdwn--;
            }
            else
            {
                label2.Text = null;
                SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.Bossa);
                sp.Play();
                //pornire muzica lift
                fundal = false;
                timer3.Start(); 
                timer1.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (ok==false)
                if (panel1.Location.Y < 259)
                {
                   //for (long j = 1; j <= 90000; j++)
                    //{
                        var hold = panel1.Location;
                        hold.Offset(50, 30);
                        Cursor.Position = PointToScreen(hold);
                    //}
                    panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 1);
                    
                }
                else
                {
                    button2.BackColor = Color.LightSeaGreen;
                    timer3.Stop();
                    fundal = true;
                    SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.Door);
                    sp.Play();
                    //pornire muzica deschidere oprire si deschidere usi
                }
            else
                if (panel1.Location.Y >12)
                {
                    panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 1);
                    fundal = true;
                }
                else
                {
                    button2.BackColor = Color.LightSeaGreen;
                    timer3.Stop();
                    fundal = true;
                    SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.Door);                   
                    sp.Play();
                    //pornire muzica deschidere oprire si deschidere usi
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

        private void label10_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer3.Stop();
            button2.BackColor = Color.LightSeaGreen;
            label2.Text = null;
            ok = false;
            button2_Click(sender, e);
            //panel1.Location = new Point(originalX, originalY);

        }

        private void mini1_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            // Form7(); loading the old form... 
            Form s = new Form7(1);
            s.Show();
            this.Close();

        }

    }
}
