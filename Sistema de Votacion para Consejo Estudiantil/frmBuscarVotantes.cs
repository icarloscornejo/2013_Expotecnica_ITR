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
    public partial class frmBuscarVotantes : Form
    {
        OleDbConnection Conexion;
        public frmBuscarVotantes()
        {
            InitializeComponent();
            Conexion = new OleDbConnection(frmLogin.ConexionString);
        }

        void limpiarCampos()
        {
            txtCarnet.Clear();
            txtNom.Clear();
            txtApe.Clear();
            txtSex.Clear();
            txtFecNac.Clear();
            txtespecialidad.Clear();
            pctFotVot.Image = null;
            txtBuscador.Clear();
            txtBuscador.Focus();
        }

        void buscarporcarnet()
        {
            int carvot;
            string consulta = "SELECT car_vot FROM Votantes WHERE car_vot = '" + txtBuscador.Text + "'";
            OleDbCommand sql = new OleDbCommand(consulta, Conexion);
            Conexion.Open();
            if (sql.ExecuteScalar() != null)
            {

                try
                {
                    carvot = Convert.ToInt32(sql.ExecuteScalar());

                    string carnet = "";
                    string nombres = "";
                    string apellidos = "";
                    string sexo = "";
                    string edad = "";
                    string foto = "";
                    string especialidad = "";
                    string codesp = "";


                    string consulta2 = "SELECT car_vot, nom_vot, ape_vot, sex_vot, edad_vot, fot_vot, vot.cod_esp FROM Votantes AS vot, Especialidad AS esp WHERE car_vot LIKE '%" + carvot + "%'";
                    OleDbCommand sql2 = new OleDbCommand(consulta2, Conexion);

                    OleDbDataReader lector;
                    lector = sql2.ExecuteReader();


                    if (lector.Read())
                    {
                        carnet = lector["car_vot"].ToString();
                        nombres = lector["nom_vot"].ToString();
                        apellidos = lector["ape_vot"].ToString();
                        sexo = lector["sex_vot"].ToString();
                        edad = lector["edad_vot"].ToString();
                        foto = lector["fot_vot"].ToString();
                        codesp = lector.GetValue(6).ToString();

                        txtCarnet.Text = carnet;
                        txtNom.Text = nombres;
                        txtApe.Text = apellidos;
                        txtSex.Text = sexo;
                        txtFecNac.Text = edad;
                        pctFotVot.ImageLocation = foto;

                        string consulta3 = "SELECT nom_esp FROM Especialidad WHERE cod_esp = '" + codesp + "'";
                        OleDbCommand sql3 = new OleDbCommand(consulta3, Conexion);
                        OleDbDataReader lector3 = sql3.ExecuteReader();
                        lector3.Read();

                        especialidad = lector3.GetValue(0).ToString();

                        txtespecialidad.Text = especialidad;
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
            {
            }
            Conexion.Close(); 
        }

        void buscarpornombre()
        {
            int carvot;
            string consulta = "SELECT car_vot FROM Votantes WHERE (nom_vot +' ' +ape_vot) = '" + txtBuscador.Text + "'";
            OleDbCommand sql = new OleDbCommand(consulta, Conexion);
            Conexion.Open();
            if (sql.ExecuteScalar() != null)
            {

                try
                {
                    carvot = Convert.ToInt32(sql.ExecuteScalar());

                    string carnet = "";
                    string nombres = "";
                    string apellidos = "";
                    string sexo = "";
                    string edad = "";
                    string foto = "";
                    string especialidad = "";
                    string codesp = "";


                    string consulta2 = "SELECT car_vot, nom_vot, ape_vot, sex_vot, edad_vot, fot_vot, vot.cod_esp FROM Votantes AS vot, Especialidad AS esp WHERE car_vot LIKE '%" + carvot + "%'";
                    OleDbCommand sql2 = new OleDbCommand(consulta2, Conexion);

                    OleDbDataReader lector;
                    lector = sql2.ExecuteReader();


                    if (lector.Read())
                    {
                        carnet = lector["car_vot"].ToString();
                        nombres = lector["nom_vot"].ToString();
                        apellidos = lector["ape_vot"].ToString();
                        sexo = lector["sex_vot"].ToString();
                        edad = lector["edad_vot"].ToString();
                        foto = lector["fot_vot"].ToString();
                        codesp = lector.GetValue(6).ToString();

                        txtCarnet.Text = carnet;
                        txtNom.Text = nombres;
                        txtApe.Text = apellidos;
                        txtSex.Text = sexo;
                        txtFecNac.Text = edad;
                        pctFotVot.ImageLocation = foto;
                        

                        string consulta3 = "SELECT nom_esp FROM Especialidad WHERE cod_esp = '" + codesp + "'";
                        OleDbCommand sql3 = new OleDbCommand(consulta3, Conexion);
                        OleDbDataReader lector3 = sql3.ExecuteReader();
                        lector3.Read();

                        especialidad = lector3.GetValue(0).ToString();

                        txtespecialidad.Text = especialidad;
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
            {
            }
            Conexion.Close();
        }

        void buscarporapellido()
        {

            int carvot;
            string consulta = "SELECT car_vot FROM Votantes WHERE (ape_vot +', ' +nom_vot) = '" + txtBuscador.Text + "'";
            OleDbCommand sql = new OleDbCommand(consulta, Conexion);
            Conexion.Open();
            if (sql.ExecuteScalar() != null)
            {

                try
                {
                    carvot = Convert.ToInt32(sql.ExecuteScalar());

                    string carnet = "";
                    string nombres = "";
                    string apellidos = "";
                    string sexo = "";
                    string edad = "";
                    string foto = "";
                    string especialidad = "";
                    string codesp = "";


                    string consulta2 = "SELECT car_vot, nom_vot, ape_vot, sex_vot, edad_vot, fot_vot, vot.cod_esp FROM Votantes AS vot, Especialidad AS esp WHERE car_vot LIKE '%" + carvot + "%'";
                    OleDbCommand sql2 = new OleDbCommand(consulta2, Conexion);

                    OleDbDataReader lector;
                    lector = sql2.ExecuteReader();


                    if (lector.Read())
                    {
                        carnet = lector["car_vot"].ToString();
                        nombres = lector["nom_vot"].ToString();
                        apellidos = lector["ape_vot"].ToString();
                        sexo = lector["sex_vot"].ToString();
                        edad = lector["edad_vot"].ToString();
                        foto = lector["fot_vot"].ToString();
                        codesp = lector.GetValue(6).ToString();

                        txtCarnet.Text = carnet;
                        txtNom.Text = nombres;
                        txtApe.Text = apellidos;
                        txtSex.Text = sexo;
                        txtFecNac.Text = edad;
                        pctFotVot.ImageLocation = foto;

                        string consulta3 = "SELECT nom_esp FROM Especialidad WHERE cod_esp = '" + codesp + "'";
                        OleDbCommand sql3 = new OleDbCommand(consulta3, Conexion);
                        OleDbDataReader lector3 = sql3.ExecuteReader();
                        lector3.Read();

                        especialidad = lector3.GetValue(0).ToString();

                       txtespecialidad.Text = especialidad;
                    }
                    

                }

                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
            else
            {
            }
            Conexion.Close(); 
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

        private void cargar()
        {
            try
            {
                AutoCompleteStringCollection buscador = new AutoCompleteStringCollection();
                
                string consulta = "SELECT car_vot, nom_vot, ape_vot FROM Votantes";
                OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                OleDbDataReader reader;
                Conexion.Open();
                reader = sql.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        buscador.Add(reader["car_vot"].ToString());
                        buscador.Add((reader["nom_vot"].ToString()) +" " +(reader["ape_vot"].ToString()));
                        buscador.Add((reader["ape_vot"].ToString()) +", " +(reader["nom_vot"].ToString()));
                    }
                }

                txtBuscador.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscador.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBuscador.AutoCompleteCustomSource = buscador;
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            Conexion.Close();
        }

        private void frmBuscarVotantes_Load(object sender, EventArgs e)
        {
            cargar();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            buscarporcarnet();
            buscarpornombre();
            buscarporapellido();
            btnBuscar.Focus();
            if (txtBuscador.Text != "Busca por carnet, nombres o apellidos")
            {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            }
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            verificar();   
        }

        private void txtBuscador_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscador.SelectAll();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar el votante?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Conexion.Open();
                    string consulta = "DELETE * FROM Votantes WHERE car_vot = '" + txtCarnet.Text + "'";
                    OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                    if (sql.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("¡Datos eliminados con éxito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                        this.Hide();
                        frmBuscarVotantes bus = new frmBuscarVotantes();
                        bus.Show();
                    }
                }
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.Close();
        }

        public static string carnetmod = "";

        private void btnModificar_Click(object sender, EventArgs e)
        {
            carnetmod = txtCarnet.Text;
            frmEditarVotantes edit = new frmEditarVotantes();
            edit.Show();
            this.Close();
        }

        private void txtBuscador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }

        
    }
}
