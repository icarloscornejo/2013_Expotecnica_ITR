using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.IO;

namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    public partial class frmInicioNueva : Form
    {
        OleDbConnection Conexion;
        AES aes;
        
        public frmInicioNueva()
        {
            InitializeComponent();
            Conexion = new OleDbConnection(frmLogin.ConexionString);
            aes = new AES();
        }

        string hoy = DateTime.Today.Day.ToString();
        string mes = DateTime.Today.Month.ToString();
        string año = DateTime.Today.Year.ToString();

        string fechadeborrado = DateTime.Now.ToString();
        void nuevavotacion()
        {
            try
            {
                string consultaVot = "DELETE * FROM Votantes";
                OleDbCommand sqlVot = new OleDbCommand(consultaVot, Conexion);
                string consultaCan = "DELETE * FROM Candidatos";
                OleDbCommand sqlCan = new OleDbCommand(consultaCan, Conexion);

                sqlVot.ExecuteNonQuery();
                sqlCan.ExecuteNonQuery();

                MessageBox.Show("¡Nueva votacion Generada!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        void limpiarcampos()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtContraseña.Text == "")
            {
                MessageBox.Show("No ha ingresado datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiarcampos();
                
            }
            else if (txtUsuario.Text == "" )
            {
                MessageBox.Show("No ha ingresado ningun usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiarcampos();
            }
            else if (txtContraseña.Text == "")
            {
                MessageBox.Show("No ha ingresado ninguna contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                limpiarcampos();
            }
            else
            {
                try
                {
                    if (txtUsuario.Text.Trim() != "" && txtContraseña.Text.Trim() != "")
                    {

                        string fecha = "" + hoy + "-" + mes + "-" + año;
                        string nombrevotacion = ("Votacion" + fecha);

                        string Passwencrypted = aes.Encriptar(txtContraseña.Text);
                        string consulta = "SELECT usu_sadm FROM SuperAdministradores WHERE usu_sadm = '" + txtUsuario.Text + "' AND con_sadm = '" + Passwencrypted + "'";
                        string consulta2 = "INSERT INTO VotacionesGuardadas (nom_votacion, fechadeborrado_votacion, admin_votacion) VALUES ('" + nombrevotacion + "','" + fechadeborrado + "', '" + frmLogin.usuario2 + "')";
                        OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                        OleDbCommand sql2 = new OleDbCommand(consulta2, Conexion);
                        Conexion.Open();
                        if (sql.ExecuteScalar() != null)
                        {
                            if (MessageBox.Show("Se procedera a generar una nueva votacion. \nEsto implica que se reiniciara el sistena.", "Precaucion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                FileInfo Archivo = new FileInfo(@"Database.accdb");
                                Archivo.CopyTo(@"" + nombrevotacion + ".accdb");
                                sql2.ExecuteNonQuery();
                                nuevavotacion();
                                MessageBox.Show("Se procedera a reiniciar el sistema.", "Reinicio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Application.Restart();
                            }
                            else
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña incorrectos, porfavor ingrese nuevamente los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }


                }
                catch (Exception mensaje)
                {
                    MessageBox.Show(mensaje.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Conexion.Close();
                txtContraseña.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnvercontraseña_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void btnvercontraseña_MouseUp(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        
    }
}
