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
    public partial class frmBienvenida : Form
    {
        OleDbConnection Conexion;
        AES aes;
        public frmBienvenida()
        {
            InitializeComponent();
            aes = new AES();
            Conexion = new OleDbConnection(frmLogin.ConexionString);
            frmFondo fon = new frmFondo();
            fon.Show();
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text != "" && txtContraseña.Text != "")
                {
                    string Passwencrypted = aes.Encriptar(txtContraseña.Text);

                    Conexion.Open();
                    string consulta = "INSERT INTO SuperAdministradores (usu_sadm, con_sadm, nom_sadm, ape_sadm) VALUES ('" + txtUsuario.Text + "','" + Passwencrypted + "','" + txtNombre.Text + "','" + txtApellido.Text + "')";
                    OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                    if (sql.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("¡SuperAdministrador agregado con éxito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmEditarAdmins edit = new frmEditarAdmins();
                        this.Hide();
                        frmLogin.usuario2 = txtUsuario.Text;
                        edit.Show();
                        MessageBox.Show("Proceda a agregar administradores para el control del programa.", "Siguiente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("¡Datos incompletos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.Close();
        }
    }
}