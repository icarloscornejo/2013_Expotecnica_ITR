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
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    public partial class frmLogin : Form
    {
        OleDbConnection Conexion;
        AES aes;

        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(splashscreen));
            t.Start();
            Thread.Sleep(3000);
            t.Abort();
            
            Conexion = new OleDbConnection(ConexionString);
            InitializeComponent();
            aes = new AES();
            frmFondo fon = new frmFondo();
            fon.Show();
        }

        public static string ConexionString = ("Provider=Microsoft.ACE.OLEDB.12.0; Data source=Database.accdb;Jet OLEDB:Database Password=votacion2013;");

        public void splashscreen()
        {
            Application.Run(new frmSplashScreen());
        }

        public void transiciondeinicio()
        {
            decimal a, b;
            for (a = 0; a <= 50; a++)
            {
                b = a / 50;
                this.Opacity = Convert.ToDouble(b);
                this.Refresh();
            }
        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblNIE.Visible = false;
            txtNIE.Visible = false;
            lblUsuario.Visible = false;
            txtUsuario.Visible = false;
            lblEsperando.Visible = true;
            lklNIE.Visible = true;
            lnkOlvideContraseña.Visible = false;
            transiciondeinicio();
            txtUsuCarnet.Focus();
            btnvercontraseña.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static int usuario;
        public static string usuario2;

        void limpiar()
        {
            txtNIE.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
            txtUsuCarnet.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                     

            if ((lblNIE.Visible == false) && (txtNIE.Visible == false) && (lblUsuario.Visible == false) && (txtUsuario.Visible == false))
            {
                try
                {
                    if (txtUsuCarnet.Text == "")
                    {
                        MessageBox.Show("No ha identificado a ningun usuario todavia, favor identificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string consulta = "SELECT car_vot FROM Votantes WHERE car_vot = '" + txtUsuCarnet.Text + "'";
                        OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                        Conexion.Open();
                        if (sql.ExecuteScalar() != null)
                        {
                            usuario = Convert.ToInt32(sql.ExecuteScalar());
                            frmVotante votante = new frmVotante();
                            votante.Show();
                            this.Hide();
                           
                        }
                        else
                        {
                            MessageBox.Show("Usuario incorrecto, porfavor ingrese nuevamente los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            limpiar();
                        }
                    }


                                           
                }
                catch (Exception msj)
                {
                    MessageBox.Show(msj.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Conexion.Close();
                txtNIE.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();
            }
            else if (txtNIE.Text == "" && txtUsuario.Text == "")
            {
                MessageBox.Show("No ha ingresado nada en ninguno de los campos, porfavor ingrese datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiar();                
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("No ha ingresado nada en el campo usuario, porfavor ingrese datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiar();
            }
            else if (txtNIE.Text == "")
            {
                MessageBox.Show("No ha ingresado nada en el campo NIE, porfavor ingrese datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiar();
            }        
            else
            {

                try
                {


                    if (txtUsuario.Text.Trim() != "" && txtNIE.Text.Trim() != "")
                    {
                        string Passwencrypted = aes.Encriptar(txtNIE.Text);

                        string consulta = "SELECT car_vot FROM Votantes WHERE car_vot = '" + txtUsuario.Text + "' AND nie_vot = '" + Passwencrypted + "'";
                        OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                        Conexion.Open();
                        if (sql.ExecuteScalar() != null)
                        {
                            usuario = Convert.ToInt32(sql.ExecuteScalar());
                            this.Hide();
                            frmVotante vot = new frmVotante();
                            vot.Show();
                        }
                        else
                        {
                            Passwencrypted = aes.Encriptar(txtNIE.Text);
                            
                            consulta = "SELECT usu_adm FROM Administradores WHERE usu_adm = '" + txtUsuario.Text + "' AND nu_adm = '" + Passwencrypted + "'";

                            

                            sql = new OleDbCommand(consulta, Conexion);
                            
                            if (sql.ExecuteScalar() != null)
                            {
                                usuario2 = Convert.ToString(sql.ExecuteScalar());
                                MessageBox.Show("Bienvenido " + usuario2, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                frmMenuPrincipalAdm MenPrin = new frmMenuPrincipalAdm();
                                MenPrin.Show();
                            }
                            else
                            {
                                
                                Passwencrypted = aes.Encriptar(txtNIE.Text);


                                consulta = "SELECT usu_sadm FROM SuperAdministradores WHERE usu_sadm = '" + txtUsuario.Text + "' AND con_sadm = '" + Passwencrypted + "'";

                                

                                sql = new OleDbCommand(consulta, Conexion);
                                
                                if (sql.ExecuteScalar() != null)
                                {
                                    usuario2 = Convert.ToString(sql.ExecuteScalar());
                                    MessageBox.Show("Bienvenido " + usuario2, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    frmMenuPrincipalSAdm MenPrin = new frmMenuPrincipalSAdm();
                                    MenPrin.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Usuario o NIE incorrectos, porfavor ingrese nuevamente los datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Datos no permitidos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Conexion.Close();
                txtNIE.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();
            }
            
        
        }

        

        private void lklNIE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblNIE.Visible = true;
            txtNIE.Visible = true;
            lklNIE.Visible = false;
            lblUsuario.Visible = true;
            txtUsuario.Visible = true;
            lblEsperando.Visible = false;
            lnkOlvideContraseña.Visible = true;
            txtUsuario.Focus();
            btnvercontraseña.Visible = true;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void btnCancelar1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //e.Handled = true;
                //return;
            }
        }

        

        private void lnkOlvideContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarPass rec = new frmRecuperarPass();
            rec.ShowDialog();
        }

        private void txtUsuCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }    
        }

        

        private void btnvercontraseña_MouseDown(object sender, MouseEventArgs e)
        {
            txtNIE.UseSystemPasswordChar = false;
        }

        private void btnvercontraseña_MouseUp(object sender, MouseEventArgs e)
        {
            txtNIE.UseSystemPasswordChar = true;
        }

        
    }
}
