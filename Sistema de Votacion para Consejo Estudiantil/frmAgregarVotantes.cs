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
    public partial class frmAgregarVotantes : Form
    {
        OleDbConnection Conexion;
        AES aes;

        public frmAgregarVotantes()
        {
            aes = new AES();
            Conexion = new OleDbConnection(frmLogin.ConexionString);
            InitializeComponent();
        }

        void limpiarCampos()
        {
            txtNIE.Clear();
            txtcarnet.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
            cbmespecialidad.SelectedIndex = -1;
            cbmsexo.SelectedIndex = -1;
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

        private void btnAtras_Click(object sender, EventArgs e)
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

        void verificar()
        {
            string consulta = "SELECT usu_sadm FROM SuperAdministradores WHERE usu_sadm = '" + frmLogin.usuario2 + "'";

            OleDbCommand sql = new OleDbCommand(consulta, Conexion);
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
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcarnet.Text != "" && txtNIE.Text != "" && txtnombre.Text != "" && txtapellido.Text != "" && cbmsexo.Text != "" && txtedad.Text != "" && cbmespecialidad.Text != "" && pctalumnos.Image != null)
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

                    if (txtcarnet.TextLength == 8)
                    {
                        if (txtcarnet.Text.StartsWith("2010") || txtcarnet.Text.StartsWith("2011") || txtcarnet.Text.StartsWith("2012") || txtcarnet.Text.StartsWith("2013"))
                        {
                            if (MessageBox.Show("¿Desea agregar a " +txtnombre.Text +" " +txtapellido.Text +"?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                string passencrypted = aes.Encriptar(txtNIE.Text);
                                Conexion.Open();
                                string consulta = "INSERT INTO Votantes (car_vot, nie_vot, nom_vot, ape_vot, sex_vot, edad_vot, cod_esp, fot_vot) VALUES (" + txtcarnet.Text + ",'" + passencrypted + "', '" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + cbmsexo.Text + "', " + txtedad.Text + " , '" + cbmespecialidad.SelectedValue + "' , '" + url + "')";
                                OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                                if (sql.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("¡Datos agregados con éxito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limpiarCampos();
                                    this.Hide();
                                    verificar();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un carnet valido porfavor.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese los 8 caracteres del carnet, porfavor.");
                    }

                }
                else
                {
                    MessageBox.Show("¡Datos incompletos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datos ya existentes.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void frmAgregarVotantes_Load(object sender, EventArgs e)
        {
            //Muestra las especialidades en un ComboBox.
            cbmespecialidad.DataSource = cargarDatos("SELECT * FROM Especialidad ORDER BY nom_esp");
            //Se toma el campo de la tabla a mostrar en el ComboBox.
            cbmespecialidad.DisplayMember = "nom_esp";
            //Se toma el campo de la tabla a guardar como valor.
            cbmespecialidad.ValueMember = "cod_esp";
            cbmespecialidad.SelectedIndex = -1;
        }

        private void txtcarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
