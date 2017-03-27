using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_Screen
{
    public partial class FrmSplashScreen : Form
    {
        public int timerLeft { get; private set; }

        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timerLeft > 0)
            {
                timerLeft = timerLeft - 1;
            }
            else
            {
                timer1.Stop();
                // new MainForm().Show();
                this.Hide();
            }
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            timerLeft = 40;
            timer1.Start();
            new MainForm().Show();
        }
    }
}
