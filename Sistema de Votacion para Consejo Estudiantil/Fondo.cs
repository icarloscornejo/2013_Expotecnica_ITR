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
    public partial class frmFondo : Form
    {
        public frmFondo()
        {
            InitializeComponent();
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblx_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
        
    }
}
