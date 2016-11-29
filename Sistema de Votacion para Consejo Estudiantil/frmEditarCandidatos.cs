using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;


namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    public partial class frmEditarCandidatos : Form
    {
        OleDbConnection Conexion;

        public frmEditarCandidatos()
        {
            Conexion = new OleDbConnection(frmLogin.ConexionString);
            InitializeComponent();            
        }

        void limpiarCampos()
        {
            txtcarnet.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtedad.Clear();
            cbmsexo.SelectedIndex = -1;
            cbmespecialidad.SelectedIndex = -1;
            pctcandidatos.Image = null;

            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txtedad.Enabled = true;
            cbmespecialidad.Enabled = true;
            cbmsexo.Enabled = true;
        }

        int contador;

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

        void graficar()
        {
            this.chartVotos.Series["Votos"].Points.Clear();

            OleDbCommand sql = new OleDbCommand("SELECT nom_can, ape_can, vot_can FROM Candidatos;", Conexion);
            OleDbDataReader myReader;
            try
            {
                Conexion.Open();
                myReader = sql.ExecuteReader();

                while (myReader.Read())
                {                  

                    string nombre = myReader.GetValue(0).ToString();
                    string apellido = myReader.GetValue(1).ToString();

                    string nomcom = nombre +" " + apellido;
                    this.chartVotos.Series["Votos"].Points.AddXY(nomcom, myReader.GetValue(2));
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            Conexion.Close();
        }

        private void frmeditarcandidatos_Load(object sender, EventArgs e)
        {
            btnImprimirEst.Enabled = false;
            cbmespecialidad.DataSource = cargarDatos("SELECT * FROM Especialidad ORDER BY nom_esp");
            cbmespecialidad.DisplayMember = "nom_esp";
            cbmespecialidad.ValueMember = "cod_esp";
            cbmespecialidad.SelectedIndex = -1;

            cmbVotacionesAnteriores.DataSource = cargarDatos("SELECT * FROM VotacionesGuardadas ORDER BY nom_votacion");
            cmbVotacionesAnteriores.DisplayMember = "nom_votacion";
            cmbVotacionesAnteriores.ValueMember = "cod_votacion";
            cmbVotacionesAnteriores.SelectedIndex = -1;
            cmbVotacionesAnteriores.Visible = false;
            lblVotacionesAnteriores.Visible = false;
        }

        void mostrarvotacionesanteriores()
        {
            if (cmbVotacionesAnteriores.SelectedIndex > -1)
            {
                string esa = "Provider=Microsoft.ACE.OLEDB.12.0; Data source= " + cmbVotacionesAnteriores.Text + ".accdb;Jet OLEDB:Database Password=votacion2013;";
                
                OleDbConnection Conexion2 = new OleDbConnection(esa);
                try
                {
                    Conexion2.Open();
                    string consulta = "SELECT car_can, nom_can, ape_can, edad_can, sex_can, esp.nom_esp, vot_can, fot_can FROM Candidatos AS can, Especialidad AS esp WHERE can.cod_esp = esp.cod_esp";
                    OleDbCommand sql = new OleDbCommand(consulta, Conexion2);
                    OleDbDataReader lector = sql.ExecuteReader();
                    dgvcandidatos.Rows.Clear();
                    while (lector.Read())
                    {
                        dgvcandidatos.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2), lector.GetValue(3), lector.GetValue(4), lector.GetValue(5), lector.GetValue(6), lector.GetValue(7));
                    }
                    lector.Dispose();

                    btnagregar.Enabled = false;
                    btneliminar.Enabled = false;
                    btnmodificar.Enabled = false;
                    btnexaminar.Enabled = false;
                    btnImprimirEst.Enabled = false;
                    btnestadistica.Enabled = false;
                    btnconsultar.Enabled = false;
                    txtnombre.Enabled = false;
                    txtapellido.Enabled = false;
                    txtedad.Enabled = false;
                    cbmespecialidad.Enabled = false;
                    cbmsexo.Enabled = false;
                }
                catch (Exception mensaje)
                {
                    MessageBox.Show(mensaje.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Conexion2.Close();
            }
            
        }

        void mostrarDatos()
        {
            try
            {
                Conexion.Open();
                string consulta = "SELECT car_can, nom_can, ape_can, edad_can, sex_can, esp.nom_esp, vot_can, fot_can FROM Candidatos AS can, Especialidad AS esp WHERE esp.cod_esp = can.cod_esp";
                OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                OleDbDataReader lector = sql.ExecuteReader();
                dgvcandidatos.Rows.Clear();
                while (lector.Read())
                {
                    
                    dgvcandidatos.Rows.Add(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2), lector.GetValue(3), lector.GetValue(4), lector.GetValue(5), lector.GetValue(6), lector.GetValue(7));
                }
                lector.Dispose();

            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.Close();
        }

        
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcarnet.Text != "" && txtnombre.Text != "" && txtapellido.Text != "" && cbmsexo.Text != "" && cbmespecialidad.Text != "" && txtedad.Text != "")
                {
                    string url;
                    if (pctcandidatos.Image != null)
                    {
                        url = "imagenes/" + txtcarnet.Text + ".png";
                        pctcandidatos.Image.Save(url, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    else
                    {
                        url = "imagenes/no_disponible.png";
                    }

                    if (contador == 8)
                    {
                        if (txtcarnet.Text.StartsWith("2010") || txtcarnet.Text.StartsWith("2011") || txtcarnet.Text.StartsWith("2012") || txtcarnet.Text.StartsWith("2013"))
                        {
                            Conexion.Open();
                            string consulta = "INSERT INTO Candidatos (car_can, nom_can, ape_can, sex_can, edad_can, cod_esp, fot_can) VALUES (" + txtcarnet.Text + ", '" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + cbmsexo.Text + "', " + txtedad.Text + " , '" + cbmespecialidad.SelectedValue + "' , '" + url + "')";
                            OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                            if (sql.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("¡Datos agregados con éxito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarCampos();

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
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.Close();
            
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcarnet.Text != "" && txtnombre.Text != "" && txtapellido.Text != "" && cbmsexo.Text != "" && cbmespecialidad.Text != "" && txtedad.Text != "")
                {
                    if (MessageBox.Show("¿Desea modificar los datos?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string url;
                        if (pctcandidatos.Image != null)
                        {
                            url = "imagenes/" + txtcarnet.Text + ".png";
                            pctcandidatos.Image.Save(url, System.Drawing.Imaging.ImageFormat.Png);
                        }
                        else
                        {
                            url = "imagenes/no_disponible.png";
                        }
                        Conexion.Open();
                        string consulta = "UPDATE Candidatos SET nom_can = '" + txtnombre.Text + "', ape_can = '" + txtapellido.Text + "', edad_can = " + txtedad.Text + ", cod_esp = '" + cbmespecialidad.SelectedValue + "', fot_can = '" + url + "' WHERE car_can = '" + txtcarnet.Text + "' ";
                        OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                        if (sql.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("¡Datos modificados con éxito!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarCampos();
                        }
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea eliminar los datos?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Conexion.Open();
                    string consulta = "DELETE * FROM Candidatos WHERE car_can = '" + txtcarnet.Text + "'";
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

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cbmsexo.Enabled = false;
            txtcarnet.Enabled = false;
            dgvcandidatos.Enabled = true;
            btnmodificar.Enabled = true;
            btneliminar.Enabled = true;
            btnlimpiar.Enabled = true;
            btnagregar.Enabled = false;
            btnconsultar.Enabled = false;
            if(cmbVotacionesAnteriores.SelectedIndex > -1)
            {
            mostrarvotacionesanteriores();
            }
            else
            {
            mostrarDatos();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            dgvcandidatos.Rows.Clear();
            txtcarnet.Enabled = true;
            cbmsexo.Enabled = true;
            dgvcandidatos.Enabled = false;
            btnmodificar.Enabled = false;
            btneliminar.Enabled = false;
            btnlimpiar.Enabled = false;
            btnagregar.Enabled = true;
            btnconsultar.Enabled = true;
            btnVotacionesAnteriores.Visible = true;
            lblVotacionesAnteriores.Visible = false;
            cmbVotacionesAnteriores.Visible = false;
            cmbVotacionesAnteriores.SelectedIndex = -1;
            limpiarCampos();
            
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
                pctcandidatos.ImageLocation = imagen.FileName;
            }
        }

        private void dgvcandidatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcarnet.Text = dgvcandidatos.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvcandidatos.CurrentRow.Cells[1].Value.ToString();
            txtapellido.Text = dgvcandidatos.CurrentRow.Cells[2].Value.ToString();
            txtedad.Text = dgvcandidatos.CurrentRow.Cells[3].Value.ToString();
            cbmsexo.Text = dgvcandidatos.CurrentRow.Cells[4].Value.ToString();
            cbmespecialidad.Text = dgvcandidatos.CurrentRow.Cells[5].Value.ToString();
            pctcandidatos.ImageLocation = dgvcandidatos.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            verificar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txtcarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar == (char)Keys.Back) && (e.KeyChar == (char)Keys.Enter) && (e.KeyChar == (char)13))
            {                
                e.Handled = false;
                return;
            }
            else
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

        private void txtcarnet_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
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

        

        private void btnestadistica_Click(object sender, EventArgs e)
        {
            graficar();
            btnImprimirEst.Enabled = true;
        }

        private void btnImprimirEst_Click(object sender, EventArgs e)
        {
            
            string nombreArchivo = "Estadistica.pdf"; 
            Document documento = new Document(PageSize.LETTER, 50, 50, 50, 100); 
            PdfWriter.GetInstance(documento, new FileStream(nombreArchivo, FileMode.Create)); 
            documento.Open(); 
            PdfPTable encabezado = new PdfPTable(2); 
            encabezado.SetWidthPercentage(new float[] { 100, 400 }, PageSize.LETTER); 
            
            encabezado.AddCell(iTextSharp.text.Image.GetInstance("imagenes/Logo.jpg"));
            encabezado.AddCell(new Paragraph("Sistema de Votacion para el Consejo Estudiantil\n Instituto Tecnico Ricaldone\nSalesianos", FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD)));
            
            foreach (PdfPCell celda in encabezado.Rows[0].GetCells())
            {
                celda.BackgroundColor = BaseColor.LIGHT_GRAY; 
                celda.HorizontalAlignment = 1; 
                celda.VerticalAlignment = 5; 
                celda.Border = 0; 
            }
            documento.Add(encabezado); 
            documento.Add(new Paragraph(" "));
            documento.Add(new Paragraph(" "));



            Paragraph frase = new Paragraph("Estadisticas de votos", FontFactory.GetFont("Calibri", 17, iTextSharp.text.Font.BOLD));
            frase.Alignment = Element.ALIGN_CENTER;
            documento.Add(frase);

            var chartimage = new MemoryStream();
            chartVotos.SaveImage(chartimage, ChartImageFormat.Png);
            iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
            Chart_image.Alignment = Element.ALIGN_CENTER;

            documento.Add(Chart_image);




            documento.Close(); 
            Process archivo = new Process(); 
            archivo.StartInfo.FileName = nombreArchivo; 
            archivo.Start(); 

            btnImprimirEst.Enabled = false;
        }

        private void txtcarnet_TextChanged_1(object sender, EventArgs e)
        {
            contador = Convert.ToInt32(txtcarnet.Text.Length);
        }

        private void btnVotacionesAnteriores_Click(object sender, EventArgs e)
        {
            btnVotacionesAnteriores.Visible = false;
            lblVotacionesAnteriores.Visible = true;
            cmbVotacionesAnteriores.Visible = true;
        }

        

        
    }
}
