using System;
using System.Windows.Forms;
using Lib;

namespace English_Learning_Management_System
{
    public partial class frmLFFirstLoad : Form
    {
        Form frmMain;
        public frmLFFirstLoad()
        {
            InitializeComponent();
             clsLib.ChangeFormProperties(this,Convert.ToInt16( this.Width), Convert.ToInt16(this.Height));
             frmMain= new frmMainScreen(this);
            frmMain.Opacity = 0.0;
            this.ShowInTaskbar = false;
            frmMain.Show();
        }

        private void frmLFFirstLoad_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0.0)
            this.Opacity = 100.0;

            CircleProgressBar1.Increment(10);
            if (CircleProgressBar1.Value == CircleProgressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                frmMain.Opacity = 100.0;
            }
        }

        private void frmLFFirstLoad_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
