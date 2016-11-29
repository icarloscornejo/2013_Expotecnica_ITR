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
    public partial class frmMenuPrincipalSAdm : Form
    {
        OleDbConnection conexion;

        public frmMenuPrincipalSAdm()
        {
            InitializeComponent();
            conexion = new OleDbConnection(frmLogin.ConexionString);
        }


        private void pctEditarCandidatos_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEditarCandidatos cand = new frmEditarCandidatos();
            cand.Show();
        }

        private void pctEditarVotantes_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEditarVotantes alum = new frmEditarVotantes();
            alum.Show();
        }

        private void pctEditarEspecialidades_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEspecialidad esp = new frmEspecialidad();
            esp.Show();
        }

        private void pctEditarAdministradores_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEditarAdmins adm = new frmEditarAdmins();
            adm.Show();
        }

        private void pctSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Restart();
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

        private void pctEditarCandidatos_MouseHover(object sender, EventArgs e)
        {
            txtIndice.Text = Convert.ToString(1);
            mostrardescripcion();
            txtTitulo.Text = lblEditCand.Text;
        }

        

        private void lblEspecialidades_MouseHover(object sender, EventArgs e)
        {
            txtIndice.Text = Convert.ToString(3);
            mostrardescripcion();
            txtTitulo.Text = lblEspecialidades.Text;
        }

        private void pctEditarAdministradores_MouseHover(object sender, EventArgs e)
        {
            txtIndice.Text = Convert.ToString(4);
            mostrardescripcion();
            txtTitulo.Text = lblAdmins.Text;
        }

        

        private void pctBuscarVotantes_Click(object sender, EventArgs e)
        {
            frmBuscarVotantes bus = new frmBuscarVotantes();
            bus.Show();
            this.Hide();
        }

        private void pctBuscarVotantes_MouseHover(object sender, EventArgs e)
        {
            txtIndice.Text = Convert.ToString(5);
            mostrardescripcion();
            txtTitulo.Text = lblBuscarVotantes.Text;
        }

        private void lblBuscarVotantes_MouseHover(object sender, EventArgs e)
        {
            txtIndice.Text = Convert.ToString(5);
            mostrardescripcion();
            txtTitulo.Text = lblBuscarVotantes.Text;
        }

        private void btnIniNuevaVot_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea generar una nueva votacion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                frmInicioNueva log = new frmInicioNueva();
                log.ShowDialog();
            }
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

        private void lblAgregarVotantes_MouseHover(object sender, EventArgs e)
        {
            txtIndice.Text = Convert.ToString(6);
            mostrardescripcion();
            txtTitulo.Text = lblAgregarVotantes.Text;
        }

        private void lblBuscarVotantes_Click(object sender, EventArgs e)
        {

        }

        
    }
}
