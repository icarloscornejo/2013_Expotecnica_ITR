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
    public partial class frmEditarAdmins : Form
    {
        OleDbConnection Conexion;
        private AES aes;

        public frmEditarAdmins()
        {
            InitializeComponent();
            Conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data source=Database.accdb;Jet OLEDB:Database Password=votacion2013;");
            aes = new AES();
        }

        void limpiarCampos()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            cbmsexo.SelectedIndex = -1;
            txtCorreo.Clear();
        }

        void mostrarDatos()
        {
            try
            {
                Conexion.Open();
                string consulta = "SELECT usu_adm, nu_adm, correo_adm, nom_adm, ape_adm, sex_adm, adm.usu_sadm FROM Administradores as adm, SuperAdministradores as sadm WHERE adm.usu_sadm = sadm.usu_sadm";
                OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                OleDbDataReader lector = sql.ExecuteReader();
                dgvadmins.Rows.Clear();
                while (lector.Read())
                {
                    dgvadmins.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2), lector.GetValue(3), lector.GetValue(4), lector.GetValue(5), lector.GetValue(6));
                }
                lector.Dispose();
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.Close();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            txtUsuario.Enabled = false;
            dgvadmins.Enabled = true;
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            btnlimpiar.Enabled = true;
            btnagregar.Enabled = false;
            btnconsultar.Enabled = false;
            mostrarDatos();
            btnvercontraseña.Enabled = false;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtUsuario.Text != "" && txtnombre.Text != "" && txtapellido.Text != "" && txtContraseña.Text != "" && cbmsexo.Text != "" && txtCorreo.Text != "")
                {

                    string Passwencrypted = aes.Encriptar(txtContraseña.Text); 
                                 
                    Conexion.Open();
                    string consulta = "INSERT INTO Administradores (usu_adm, nu_adm, correo_adm, nom_adm, ape_adm, sex_adm, usu_sadm) VALUES ('" + txtUsuario.Text + "','" + Passwencrypted + "','" + txtCorreo.Text + "', '" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + cbmsexo.Text + "', '" + frmLogin.usuario2 +"')";
                    OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                    if (sql.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("¡Datos agregados con éxito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
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

        private void dgvadmins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuario.Text = dgvadmins.CurrentRow.Cells[0].Value.ToString();
            txtContraseña.Text = aes.Desencriptar(dgvadmins.CurrentRow.Cells[1].Value.ToString()) ;
            txtCorreo.Text = dgvadmins.CurrentRow.Cells[2].Value.ToString();
            txtnombre.Text = dgvadmins.CurrentRow.Cells[3].Value.ToString();
            txtapellido.Text = dgvadmins.CurrentRow.Cells[4].Value.ToString();
            cbmsexo.Text = dgvadmins.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dgvadmins.Rows.Clear();
            txtUsuario.Enabled = true;
            cbmsexo.Enabled = true;
            dgvadmins.Enabled = false;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            btnlimpiar.Enabled = false;
            btnagregar.Enabled = true;
            btnconsultar.Enabled = true;
            limpiarCampos();
            btnvercontraseña.Enabled = true;
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (MessageBox.Show("¿Desea eliminar los datos?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Conexion.Open();
                    string consulta = "DELETE * FROM Administradores WHERE usu_adm = '" + txtUsuario.Text + "'";
                    OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                    if (sql.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("¡Datos eliminados con éxito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                    }
                }
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.Close();
            mostrarDatos();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text != "" && txtnombre.Text != "" && txtapellido.Text != "" && txtContraseña.Text != "" && txtCorreo.Text != "" && cbmsexo.Text != "")
                {
                    if (MessageBox.Show("¿Desea modificar los datos?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        Conexion.Open();
                        string passencrypted = aes.Encriptar(txtContraseña.Text);
                        string consulta = "UPDATE Administradores SET nom_adm = '" + txtnombre.Text + "', ape_adm = '" + txtapellido.Text + "', nu_adm = '" + passencrypted + "', correo_adm = '" + txtCorreo.Text + "' WHERE usu_adm = '" + txtUsuario.Text + "' ";
                        OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                        if (sql.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("¡Datos modificados con éxito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCampos();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("¡Faltan datos!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.Close();
            mostrarDatos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipalSAdm menprin = new frmMenuPrincipalSAdm();
            menprin.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNU_KeyPress(object sender, KeyPressEventArgs e)
        {
            
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

        private void frmEditarAdmins_Load(object sender, EventArgs e)
        {
            dgvadmins.Rows.Clear();
            txtUsuario.Enabled = true;
            cbmsexo.Enabled = true;
            dgvadmins.Enabled = false;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            btnlimpiar.Enabled = false;
            btnagregar.Enabled = true;
            btnconsultar.Enabled = true;
            limpiarCampos();
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
