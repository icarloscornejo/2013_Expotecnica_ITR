using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb; //Se agrega para poder utilizar la base de datos.


namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    public partial class frmEspecialidad : Form
    {


        OleDbConnection conexion;
        public frmEspecialidad()
        {
            conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data source=Database.accdb;Jet OLEDB:Database Password=votacion2013;");
            InitializeComponent();

        }

        private void frmEspecialidad_Load(object sender, EventArgs e)
        {
            mostrarNuevoCodigo();
        }
        void mostrarNuevoCodigo()
        {
            try
            {
                conexion.Open();
                string consulta = "SELECT MAX(cod_esp) FROM Especialidad";
                OleDbCommand sql = new OleDbCommand(consulta, conexion);
                if (sql.ExecuteScalar() != DBNull.Value)
                {
                    txtcodigo.Text = Convert.ToString(Convert.ToInt32(sql.ExecuteScalar()) + 1);
                }
                else
                {
                    txtcodigo.Text = "1";
                }
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }


        void limpiarCampos()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtdescripcion.Clear();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text != "" && txtdescripcion.Text != "")
                {
                    conexion.Open();
                    string consulta = "INSERT INTO Especialidad (cod_esp, nom_esp, des_esp) VALUES ('" + txtcodigo.Text + "', '" + txtnombre.Text + "', '" + txtdescripcion.Text + "')";
                    OleDbCommand sql = new OleDbCommand(consulta, conexion);
                    if (sql.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("¡Datos agregados con éxito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            conexion.Close();
            limpiarCampos();
            mostrarNuevoCodigo();

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtnombre.Text != "" && txtdescripcion.Text != "")
                {
                    if (MessageBox.Show("¿Desea modificar los datos?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        conexion.Open();
                        string consulta = "UPDATE Especialidad SET cod_esp = '" + txtcodigo.Text + "', nom_esp = '" + txtnombre.Text + "', des_esp = '" + txtdescripcion.Text + "' WHERE cod_esp = '" + txtcodigo.Text + "' ";
                        OleDbCommand sql = new OleDbCommand(consulta, conexion);
                        if (sql.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("¡Datos modificados con éxito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCampos();
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
            conexion.Close();
            MostrarDatos();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar los datos?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    conexion.Open();
                    string consulta = "DELETE * FROM Especialidad WHERE cod_esp = '" + txtcodigo.Text + "' ";
                    OleDbCommand sql = new OleDbCommand(consulta, conexion);
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
            conexion.Close();
            MostrarDatos();


        }

        void MostrarDatos()
        {
            try
            {
                conexion.Open();
                string consulta = "SELECT cod_esp, nom_esp, des_esp FROM Especialidad";
                OleDbCommand sql = new OleDbCommand(consulta, conexion);
                OleDbDataReader lector = sql.ExecuteReader();
                dgvespecialidad.Rows.Clear();
                while (lector.Read())
                {
                    dgvespecialidad.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2));
                }
                lector.Dispose();
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }

        void verificar()
        {
            string consulta = "SELECT usu_sadm FROM SuperAdministradores WHERE usu_sadm = '" + frmLogin.usuario2 + "'";

            OleDbCommand sql = new OleDbCommand(consulta, conexion);
            conexion.Open();
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
            conexion.Close();
        }

        private void dgvespecialidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgvespecialidad.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvespecialidad.CurrentRow.Cells[1].Value.ToString();
            txtdescripcion.Text = dgvespecialidad.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            verificar();
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

        private void txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void frmEspecialidad_Load_1(object sender, EventArgs e)
        {
            mostrarNuevoCodigo();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            limpiarCampos();
            dgvespecialidad.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnAgregar.Enabled = false;
            btnConsultar.Enabled = false;
            MostrarDatos();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            dgvespecialidad.Rows.Clear();
            dgvespecialidad.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnAgregar.Enabled = true;
            btnConsultar.Enabled = true;
            limpiarCampos();
            mostrarNuevoCodigo();
        }

        

        private void dgvespecialidad_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dgvespecialidad.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvespecialidad.CurrentRow.Cells[1].Value.ToString();
            txtdescripcion.Text = dgvespecialidad.CurrentRow.Cells[2].Value.ToString();
        }

        

        

       

        
        

        


       
        
    }
}
