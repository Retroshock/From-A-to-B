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
    
    public partial class Form6 : Form
    {
        int caramida; bool gresit = false;
        Point original1,original2,original3,original4 = new Point();
        bool first = true;
        int i,j,di,dj;
        public Form6()
        {
            InitializeComponent();
            original1 = label1.Location;
            original2 = label4.Location;
            original3 = label5.Location;
            original4 = label7.Location;
            label1.Location = new Point(label1.Location.X, label6.Location.Y);
            label4.Location = new Point(label4.Location.X, label6.Location.Y);
            label5.Location = new Point(label5.Location.X, label6.Location.Y);
            label7.Location = new Point(label7.Location.X, label6.Location.Y);

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Location.Y > original1.Y)
                label1.Location = new Point(label1.Location.X, label1.Location.Y - 1);
            else
                if (label4.Location.Y > original2.Y)
                    label4.Location = new Point(label4.Location.X, label4.Location.Y - 1);
                else
                    if (label5.Location.Y > original3.Y)
                        label5.Location = new Point(label5.Location.X, label5.Location.Y - 1);
                    else
                        if (label7.Location.Y < original4.Y)
                            label7.Location = new Point(label7.Location.X, label7.Location.Y + 1);
                        else
                        {
                            timer1.Stop();
                            label3.Visible = true;
                            panel1.Visible = true;
                            label2.Visible = true;
                        }
        }

        private void label11_Click(object sender, EventArgs e)
        {


            Form7 urmator = new Form7(0);
            urmator.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            var start = label10.Location;
            start.Offset(30, 30);
            Cursor.Position = PointToScreen(start);
            
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {

            if (first)
            {
                timer1.Start();
                first = false;
                
            }
        }

        private void Form6_MouseEnter(object sender, EventArgs e)
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

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            caramida = 1;
            Escape_KeyDown(sender,e);
            if (e.KeyCode == Keys.W && label1.Location.Y - 40 >= label6.Location.Y - 100)
            {
                i = 40; di = 1; j = 20; dj = -1;
                timer14.Start();
            }
            else
                if (e.KeyCode == Keys.S && label1.Location.Y + 40 <= label6.Location.Y + 100)
                {
                    i = 40; di = -1; j = 20; dj = 1;
                    timer14.Start();
                }
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            label1.Location = original1;
            label4.Location = original2;
            label5.Location = original3;
            label7.Location = original4;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            label13.Visible = true;
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            caramida = 2;
            Escape_KeyDown(sender, e);
            if (e.KeyCode == Keys.W&& label5.Location.Y>=label6.Location.Y-100)
            {
                i = 20; di = 1; j = 40; dj = -1;
                timer14.Start();
            }
            else
                if (e.KeyCode == Keys.S && label5.Location.Y <= label6.Location.Y + 100)
                {
                    i = 20; di = -1; j = 40; ; dj = 1;
                    timer14.Start();
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            label13.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            label13.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            label13.Visible = true;
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            caramida = 3;
            Escape_KeyDown(sender, e);
            if (e.KeyCode == Keys.W )
            {
                i = 20; di = -1; j = 40; dj = 1;
                timer14.Start();
            }
            else
                if (e.KeyCode == Keys.S )
                {
                    i = 20; di = 1; j = 40; ; dj = -1;
                    timer14.Start();
                }
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {
            caramida = 4;
            Escape_KeyDown(sender, e);
            if (e.KeyCode == Keys.W)
            {
                i = 60; di = 1; j = 20; dj = -1;
                timer14.Start();
            }
            else
                if (e.KeyCode == Keys.S)
                {
                    i = 60; di = -1; j = 20; ; dj = 1;
                    timer14.Start();
                }
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            Escape_KeyDown(sender, e);
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            if (caramida == 1)
            {
                button1.Enabled = false;
                button6.Focus();
                if (i>0)
                {
                    if (j > 0)
                    {
                        label7.Location = new Point(label7.Location.X, label7.Location.Y + di);
                        j--;
                    }
                    label1.Location=new Point(label1.Location.X,label1.Location.Y+dj);
                    i--;
                }
                if (i == 0 && j == 0)
                {                    
                    button1.Enabled = true;
                    button1.Focus();
                    timer14.Stop();
                }
            }
            if (caramida == 2)
            {
                button2.Enabled = false;
                button6.Focus();
                if (j > 0)
                {
                    if (i > 0)
                    {
                        label4.Location = new Point(label4.Location.X, label4.Location.Y + di);
                        i--;
                    }
                    label5.Location = new Point(label5.Location.X, label5.Location.Y + dj);
                    j--;
                }
                if (i == 0 && j == 0)
                {
                    button2.Enabled = true;
                    button2.Focus();
                    timer14.Stop();
                }
            }
            if (caramida==3)
            {
                button3.Enabled = false;
                button6.Focus();
                if (j > 0)
                {
                    if (i > 0)
                    {
                        label1.Location = new Point(label1.Location.X, label1.Location.Y + di);
                        i--;
                    }
                    label5.Location = new Point(label5.Location.X, label5.Location.Y + dj);
                    j--;
                }
                if (i == 0 && j == 0)
                {
                    button3.Enabled = true;
                    button3.Focus();
                    timer14.Stop();
                }
            }
            if (caramida == 4)
            {
                button4.Enabled = false;
                button6.Focus();
                if (i > 0)
                {
                    if (j > 0)
                    {
                        label5.Location = new Point(label5.Location.X, label5.Location.Y + di);
                        j--;
                    }
                    label4.Location = new Point(label4.Location.X, label4.Location.Y + dj);
                    i--;
                }
                if (i == 0 && j == 0)
                {
                    button4.Enabled = true;
                    button4.Focus();
                    timer14.Stop();
                }
            }

        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            Escape_KeyDown(sender, e);
        }
        
        
        
        /*class miscare 
        {
            public int i, distanta,directie;
            public Label copie, referinta;
            void initializare()
            {
                i=distanta;
            }
            
        }*/
        
        
            
            
            
            
            
        
    }
}
