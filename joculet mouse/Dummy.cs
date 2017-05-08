using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
   
namespace joculet_mouse
{
    public partial class Dummy : Form
    {

        int muzica ;
        public Dummy(int music)
        {
            InitializeComponent();
            muzica = music;
            
        }
        SoundPlayer sp = new SoundPlayer();

        private void Dummy_Load(object sender, EventArgs e)
        {
            //countdown.timp = 0;
            //if (countdown.start == true)
            //label1.BackColor = Color.Aqua;
                timer1.Start();
                this.Opacity = 0;
                timer2.Start();
                if (muzica == 1)
                {
                    sp.Stream = Properties.Resources.Background1;
                    sp.PlayLooping();
                }
                

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (countdown.stop == false)
                {
                    countdown.timp++;
                    label1.Text = Convert.ToString(countdown.timp);
                }
                else
                {
                    timer1.Stop();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Are you still there?", "?!");
            }
                
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //sp.PlayLooping();
        }
    }
}
