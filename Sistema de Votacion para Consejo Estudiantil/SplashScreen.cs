using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        public void transiciondeinicio()
        {
            decimal a, b;
            for (a = 0; a <= 200; a++)
            {
                b = a / 200;
                this.Opacity = Convert.ToDouble(b);
                this.Refresh();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            transiciondeinicio();
        }

        private void tmrProgressBar_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
