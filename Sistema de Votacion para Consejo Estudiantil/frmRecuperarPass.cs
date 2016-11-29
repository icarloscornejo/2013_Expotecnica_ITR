using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;


namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    public partial class frmRecuperarPass : Form
    {
        OleDbConnection Conexion;
        AES aes;

        public frmRecuperarPass()
        {
            InitializeComponent();
            Conexion = new OleDbConnection(frmLogin.ConexionString);
            aes = new AES();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "" && txtUsuario.Text != "")
            {
                try
                {
                    string consulta = "SELECT nu_adm FROM Administradores WHERE usu_adm = '" + txtUsuario.Text + "' AND correo_adm = '" + txtCorreo.Text + "'";

                    OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                    Conexion.Open();
                    if (sql.ExecuteScalar() != null)
                    {
                        string cuenta = "sistemadevotacion2013@gmail.com";
                        string contraseña = aes.Desencriptar(sql.ExecuteScalar().ToString());
                        MailMessage correo = new MailMessage();
                        correo.From = new MailAddress(cuenta);

                        correo.To.Add(txtCorreo.Text);
                        correo.Subject = "Recuperacion de contraseña";
                        correo.Body = "Su contraseña es: '" + contraseña + "'";
                        correo.IsBodyHtml = false;
                        correo.Priority = MailPriority.Normal;
                        SmtpClient smtp = new SmtpClient();
                        smtp.Credentials = new NetworkCredential(cuenta, "votacion2013");
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.Send(correo);
                        MessageBox.Show("Su contraseña ha sido enviada a su correo.");
                    }
                    else
                    {
                        MessageBox.Show("Usuario o correo inexistentes, porfavor ingrese nuevamente los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No posee una conexion de red en este momento, intente mas tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Conexion.Close();
            }
            else
            {
                MessageBox.Show("Porfavor, proporcione sus datos.");
            }
        }
    }
}
