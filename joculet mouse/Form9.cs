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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Form start = new Start();
            start.Show();
            this.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //countdown.start = true; ;
            //countdown.timp = 4578;

            long h, m, s;
            h = m = s = 0;
            s = countdown.timp % 60;
            m = countdown.timp %3600 /60;
            h = countdown.timp / 3600;

            countdown.stop=true;
            if (h > 0)
                if (h == 1)
                    label3.Text = Convert.ToString(h + " hour " + m + " minutes " + s + " seconds ");
                else
                    label3.Text = Convert.ToString(h + " hours " + m + " minutes " + s + " seconds ");
            else
                label3.Text = Convert.ToString(m + " minutes " + s + " seconds ");
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
