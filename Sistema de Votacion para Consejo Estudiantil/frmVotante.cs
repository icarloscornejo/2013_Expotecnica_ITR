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
    public partial class frmVotante : Form
    {
        OleDbConnection Conexion;
        

        public frmVotante()
        {
            InitializeComponent();
            Conexion = new OleDbConnection(frmLogin.ConexionString);
        }

        public static string nombrevot, apellidovot, fotovot, especialidadvot;
        public static int edadvot;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "SELECT compro_vot FROM Votantes WHERE car_vot = '" + frmLogin.usuario + "'";
                OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                Conexion.Open();
                if (Convert.ToInt32(sql.ExecuteScalar()) == 0)
                {
                    frmVotacionCandidato infocan = new frmVotacionCandidato();
                    this.Hide();
                    infocan.Show();
                }
                else
                {
                    MessageBox.Show("Usted ya ha hecho su voto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Restart();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex );                
            }
            Conexion.Close();
        }

        private void frmVotante_Load(object sender, EventArgs e)
        {
            try
            {
                string carnet = "";
                string nombres = "";
                string apellidos = "";
                int edad = 0;
                string foto = "";
                string codesp = "";
                string especialidad = "";

                Conexion.Open();
                string consulta = "SELECT car_vot, nom_vot, ape_vot, edad_vot, fot_vot, vot.cod_esp FROM Votantes AS vot, Especialidad AS esp WHERE car_vot = '" + frmLogin.usuario + "'  ";
                
                OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                OleDbDataReader lector = sql.ExecuteReader();
                lector.Read();

                carnet = lector.GetValue(0).ToString();
                nombres = lector.GetValue(1).ToString();
                apellidos = lector.GetValue(2).ToString();
                edad = Convert.ToInt32(lector.GetValue(3));
                foto = lector.GetValue(4).ToString();
                codesp = lector.GetValue(5).ToString();
                
                txtCarnet.Text = carnet;
                txtNombre.Text = nombres;
                txtApellidos.Text = apellidos;
                txtEdad.Text = Convert.ToString(edad);
                pctVotante.ImageLocation = foto;

                string consulta2 = "SELECT nom_esp FROM Especialidad WHERE cod_esp = '" + codesp +"'";
                OleDbCommand sql2 = new OleDbCommand(consulta2, Conexion);
                OleDbDataReader lector2 = sql2.ExecuteReader();
                lector2.Read();

                especialidad = lector2.GetValue(0).ToString();

                txtEspecialidad.Text = especialidad;

                nombrevot = nombres;
                apellidovot = apellidos;
                edadvot = edad;
                fotovot = foto;
                especialidadvot = especialidad;
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            Conexion.Close();
        }

              
       
        

    }
}
