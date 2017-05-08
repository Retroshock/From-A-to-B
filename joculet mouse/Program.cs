using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
//using System.Threading.Tasks;

namespace joculet_mouse
{
    
    static class Program
    {
        //countdown ctdwn = new countdown();
        //public bool stop = false;
        //Form form7 = new Form7();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //SoundPlayer sp = new SoundPlayer(Properties.Resources.Background1);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start());

        }

    }

}
