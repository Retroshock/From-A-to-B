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
    public partial class Form2 : Form
    {
        //bool ok = false,gresit= false;
        int i ;
        //SoundPlayer sp = new SoundPlayer();
        
        public Form2()
        {
            InitializeComponent();
            //sp.Stream = Properties.Resources.Background1;
            //sp.PlayLooping();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            var start = label10.Location;
            start.Offset(30, 30);
            Cursor.Position = PointToScreen(start);
            
        }

        private void Appear_MouseEnter(object sender, EventArgs e)
        {
            label15.Visible = true;
            
            //label14.BackColor = Color.Aqua;

        }

        private void Wall_MouseEnter(object sender, EventArgs e)
        {

            MessageBox.Show("Hmm...", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var start = label10.Location;
            start.Offset(30, 30);
            Cursor.Position = PointToScreen(start);
            i = 200;
            timer1.Start();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("That wasn't hard, was it ?", "Well Done !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form3 f3 = new Form3();
            f3.Show();
            this.Close();
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
                label13.Text = " ";
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
