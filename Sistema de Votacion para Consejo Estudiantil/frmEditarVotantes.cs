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
    public partial class frmEditarVotantes : Form
    {
        OleDbConnection Conexion;
        AES aes;

        public frmEditarVotantes()
        {
            InitializeComponent();
            Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data source=Database.accdb;Jet OLEDB:Database Password=votacion2013;");
            aes = new AES();
        }

        void limpiarCampos()
        {
            txtcarnet.Clear();
            txtNIE.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
            cbmsexo.SelectedIndex = -1;
            cbmespecialidad.SelectedIndex = -1;
            pctalumnos.Image = null;
        }

        DataTable cargarDatos(string consulta)
        {
            DataTable datos = new DataTable();

            try
            {
                Conexion.Open();

                OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                OleDbDataReader lector = sql.ExecuteReader();

                datos.Load(lector);

            }
            catch (Exception mensaje)
            {

                MessageBox.Show(mensaje.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Conexion.Close();
            return (datos);
        }

        int contador;
       

        private void txtcarnet_TextChanged(object sender, EventArgs e)
        {            
            contador = Convert.ToInt32(txtcarnet.Text.Length);
        }

        public string carnetviejo = "";

        private void frmEditarAlumnos_Load(object sender, EventArgs e)
        {
            
            //Muestra las especialidades en un ComboBox.
            cbmespecialidad.DataSource = cargarDatos("SELECT * FROM Especialidad ORDER BY nom_esp");
            //Se toma el campo de la tabla a mostrar en el ComboBox.
            cbmespecialidad.DisplayMember = "nom_esp";
            //Se toma el campo de la tabla a guardar como valor.
            cbmespecialidad.ValueMember = "cod_esp";
            cbmespecialidad.SelectedIndex = -1;
            

            
            try
            {
                string carnet = "";
                string nombres = "";
                string apellidos = "";
                int edad = 0;
                string foto = "";
                string nievot="";
                string especialidad = "";
                string sexo = "";
                string codesp = "";

                Conexion.Open();
                string consulta = "SELECT car_vot, nom_vot, ape_vot, edad_vot, fot_vot, nie_vot, vot.cod_esp, sex_vot FROM Votantes AS vot, Especialidad AS esp WHERE car_vot = '" + frmBuscarVotantes.carnetmod + "'  ";
                OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                OleDbDataReader lector = sql.ExecuteReader();
                lector.Read();

                carnet = lector.GetValue(0).ToString();
                nombres = lector.GetValue(1).ToString();
                apellidos = lector.GetValue(2).ToString();
                edad = Convert.ToInt32(lector.GetValue(3));
                foto = lector.GetValue(4).ToString();
                nievot = aes.Desencriptar(lector.GetValue(5).ToString());
                codesp = lector.GetValue(6).ToString();
                sexo = lector.GetValue(7).ToString();

                 

                txtcarnet.Text = carnet;
                carnetviejo = txtcarnet.Text;
                txtnombre.Text = nombres;
                txtapellido.Text = apellidos;
                txtedad.Text = Convert.ToString(edad);
                pctalumnos.ImageLocation = foto;
                txtNIE.Text = nievot;
                cbmsexo.Text = sexo;

                string consulta2 = "SELECT nom_esp FROM Especialidad WHERE cod_esp = '" + codesp + "'";
                OleDbCommand sql2 = new OleDbCommand(consulta2, Conexion);
                OleDbDataReader lector2 = sql2.ExecuteReader();
                lector2.Read();

                especialidad = lector2.GetValue(0).ToString();

                cbmespecialidad.Text = especialidad;
            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            Conexion.Close();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcarnet.TextLength == 8)
                {
                    if (txtcarnet.Text.StartsWith("2010") || txtcarnet.Text.StartsWith("2011") || txtcarnet.Text.StartsWith("2012") || txtcarnet.Text.StartsWith("2013"))
                    {
                        if (txtcarnet.Text != "" && txtNIE.Text != "" && txtnombre.Text != "" && txtapellido.Text != "" && cbmsexo.Text != "" && cbmespecialidad.Text != "" && txtedad.Text != "" && pctalumnos.Image != null)
                        {
                            if (MessageBox.Show("¿Desea modificar los datos?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                try
                                {
                                    string url;
                                    if (pctalumnos.Image != null)
                                    {
                                        url = "imagenes/" + txtcarnet.Text + ".png";
                                        pctalumnos.Image.Save(url, System.Drawing.Imaging.ImageFormat.Png);
                                    }
                                    else
                                    {
                                        url = "imagenes/no_disponible.png";
                                    }

                                    Conexion.Open();
                                    string passencrypted = aes.Encriptar(txtNIE.Text);
                                    string consulta = "UPDATE Votantes SET nom_vot = '" + txtnombre.Text + "', nie_vot = '" + passencrypted + "', ape_vot = '" + txtapellido.Text + "', edad_vot = " + txtedad.Text + ", sex_vot = '" + cbmsexo.Text + "' , cod_esp = '" + cbmespecialidad.SelectedValue + "', fot_vot = '" + url + "', car_vot = '"+ txtcarnet.Text +"' WHERE car_vot = '" + carnetviejo + "'";
                                    OleDbCommand sql = new OleDbCommand(consulta, Conexion);


                                    if (sql.ExecuteNonQuery() > 0)
                                    {
                                        MessageBox.Show("¡Datos modificados con éxito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        limpiarCampos();
                                        this.Hide();
                                        frmBuscarVotantes bus = new frmBuscarVotantes();
                                        bus.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Datos no modificados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show("" + ex);
                                }

                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("¡Datos incompletos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.Close();
        }    

       
        

        void verificar()
        {
            string consulta = "SELECT usu_sadm FROM SuperAdministradores WHERE usu_sadm = '" + frmLogin.usuario2 + "'";

            OleDbCommand sql = new OleDbCommand(consulta, Conexion);
            Conexion.Open();
            if (sql.ExecuteScalar() != null)
            {
                this.Hide();
                frmMenuPrincipalSAdm menprin = new frmMenuPrincipalSAdm();
                menprin.Show();
            }
            else
            {
                this.Hide();
                frmMenuPrincipalAdm menprin = new frmMenuPrincipalAdm();
                menprin.Show();
            }
            Conexion.Close();
        }
       

        private void btnexaminar_Click(object sender, EventArgs e)
        {
            //Se abre una ventana de dialogo para buscar la imagen.
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Title = "Seleccionar imagen";
            imagen.Filter = "Archivos de imagen (*.jpg, *.png, *.bmp, *.gif)|*.jpg; *.png; *.bmp; *.gif";
            if (imagen.ShowDialog() == DialogResult.OK)
            {
                //Se muestra la imagen seleccionada en el PictureBox.
                pctalumnos.ImageLocation = imagen.FileName;
            }
        }

        

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            verificar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        

        private void txtNIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            frmBuscarVotantes bus = new frmBuscarVotantes();
            bus.Show();
            this.Hide();
        }

        private void txtcarnet_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNIE_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtnombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public static string foto = "";

        private void btnWebcam_Click(object sender, EventArgs e)
        {
            if (txtcarnet.Text == "")
            {
                MessageBox.Show("Ingrese el carnet del votante.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtcarnet.TextLength == 8)
            {
                if (txtcarnet.Text.StartsWith("2010") || txtcarnet.Text.StartsWith("2011") || txtcarnet.Text.StartsWith("2012") || txtcarnet.Text.StartsWith("2013"))
                {
                    foto = "";
                    foto = txtcarnet.Text;
                    frmWebcam web = new frmWebcam();
                    web.ShowDialog();
                    if (frmWebcam.comprobacion == 1)
                    {
                        pctalumnos.ImageLocation = frmWebcam.direccionfoto;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un carnet valido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los 8 caracteres del carnet.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnexaminar_Click_1(object sender, EventArgs e)
        {
            //Se abre una ventana de dialogo para buscar la imagen.
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Title = "Seleccionar imagen";
            imagen.Filter = "Archivos de imagen (*.jpg, *.png, *.bmp, *.gif)|*.jpg; *.png; *.bmp; *.gif";
            if (imagen.ShowDialog() == DialogResult.OK)
            {
                //Se muestra la imagen seleccionada en el PictureBox.
                pctalumnos.ImageLocation = imagen.FileName;
            }
        }

        private void txtedad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        

        

        
    }
}
