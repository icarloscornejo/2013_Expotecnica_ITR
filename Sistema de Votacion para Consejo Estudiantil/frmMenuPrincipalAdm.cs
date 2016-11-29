using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    public partial class frmMenuPrincipalAdm : Form
    {
        OleDbConnection conexion;
        public frmMenuPrincipalAdm()
        {
            InitializeComponent();
            conexion = new OleDbConnection(frmLogin.ConexionString);
        }

        

        public static string descripcion, imagendescripcion;

        void mostrardescripcion()
        {
            string consulta = "SELECT * FROM Descripciones WHERE cod_des = '" + txtIndice.Text + "'";
            OleDbCommand sql = new OleDbCommand(consulta, conexion);
            OleDbDataReader lector;

            try
            {
                conexion.Open();
                lector = sql.ExecuteReader();

                lector.Read();

                descripcion = lector["des_des"].ToString();
                imagendescripcion = lector["img_des"].ToString();

                txtDescripcion.Text = descripcion;
                pctDescripcion.ImageLocation = imagendescripcion;

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            conexion.Close();
        }

        private void pctEditarCandidatos_Click(object sender, EventArgs e)
        {
            frmEditarCandidatos editcan = new frmEditarCandidatos();
            editcan.Show();
            this.Hide();
        }

        private void pctEditarVotantes_Click(object sender, EventArgs e)
        {
            frmEditarVotantes editvot = new frmEditarVotantes();
            editvot.Show();
            this.Hide();
        }

        private void pctEditarEspecialidades_Click(object sender, EventArgs e)
        {
            frmEspecialidad editesp = new frmEspecialidad();
            editesp.Show();
            this.Hide();
        }

        private void pctEditarCandidatos_MouseHover(object sender, EventArgs e)
        {
            txtIndice.Text = Convert.ToString(1);
            mostrardescripcion();
            txtTitulo.Text = lblEditCand.Text;
        }

        private void pctEditarEspecialidades_MouseHover(object sender, EventArgs e)
        {
            txtIndice.Text = Convert.ToString(3);
            mostrardescripcion();
            txtTitulo.Text = lblEspecialidades.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pctSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctBuscarVotantes_Click(object sender, EventArgs e)
        {
            frmBuscarVotantes bus = new frmBuscarVotantes();
            bus.Show();
            this.Hide();
        }

        private void pctAgregarVotantes_Click(object sender, EventArgs e)
        {
            frmAgregarVotantes bus = new frmAgregarVotantes();
            bus.Show();
            this.Hide();
        }

        private void pctAgregarVotantes_MouseHover(object sender, EventArgs e)
        {
            txtIndice.Text = Convert.ToString(6);
            mostrardescripcion();
            txtTitulo.Text = lblAgregarVotantes.Text;
        }

        private void pctBuscarVotantes_MouseHover(object sender, EventArgs e)
        {
            txtIndice.Text = Convert.ToString(5);
            mostrardescripcion();
            txtTitulo.Text = lblBuscarVotantes.Text;
        }        
    }
}
