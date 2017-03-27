using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_Screen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Thread t = new Thread(new ThreadStart(startForm));            
            t.Start();
            Thread.Sleep(2000);

            InitializeComponent();

            t.Abort();
        }

        public void startForm()
        {
            Application.Run(new FormSplashScreen2());

        }
    }
}
