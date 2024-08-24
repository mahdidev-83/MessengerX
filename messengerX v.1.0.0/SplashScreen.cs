using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messengerX_v._1._0._0
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 100;
            if(panel1.Width >= 534)
            {
                timer1.Stop();
                this.Hide();
                // opening Main window

                MainWindow mainwindow1 = new MainWindow();
                mainwindow1.Show();
            }
        }
    }
}
