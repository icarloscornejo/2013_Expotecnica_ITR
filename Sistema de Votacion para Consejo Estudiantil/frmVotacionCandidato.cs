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

namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    public partial class frmVotacionCandidato : Form
    {
        OleDbConnection Conexion;



        public frmVotacionCandidato()
        {
            Conexion = new OleDbConnection(frmLogin.ConexionString);
            InitializeComponent();
        }

        //Obtiene el origen de datos para los ComboBox.
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

        //Limpia los campos del formulario.
        void limpiarCampos()
        {
            txtCarnet.Clear();
            cmbSelecCand.SelectedIndex = -1;
            txtNom.Clear();
            txtApe.Clear();
            txtSex.Clear();
            txtFecNac.Clear();
        }

        private void btnregre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea regresar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmVotante vot = new frmVotante();
                vot.Show();

            }
        }
        private void frmInfoCandidato_Load(object sender, EventArgs e)
        {
            //Muestra los candidatos en un ComboBox.
            cmbSelecCand.DataSource = cargarDatos("SELECT (nom_can + ' ' + ape_can) as Nombre, car_can FROM Candidatos ORDER BY nom_can");
            cmbSelecCand.DisplayMember = "Nombre";
            cmbSelecCand.ValueMember = "car_can";
            cmbSelecCand.SelectedIndex = -1;
            limpiarCampos();
        }


        private void btnvot_Click(object sender, EventArgs e)
        {
            if (cmbSelecCand.SelectedIndex >= 0)
            {
                if (MessageBox.Show("¿Está seguro que desea votar por " + txtNom.Text + " " + txtApe.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        Conexion.Open();
                        string consulta = "UPDATE Candidatos SET vot_can = (vot_can + 1) WHERE car_can = '" + txtCarnet.Text + "' ";
                        OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                        if (sql.ExecuteNonQuery() > 0)
                        {
                            consulta = "UPDATE Votantes SET compro_vot = 1 WHERE car_vot = '" + frmLogin.usuario + "' ";
                            sql = new OleDbCommand(consulta, Conexion);
                            if (sql.ExecuteNonQuery() > 0)
                            {
                                if (MessageBox.Show("Su voto ha sido efectuado \n ¿Desea imprimir comprobante?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    generarcomprobante();
                                    Application.Restart();
                                }
                                else
                                {
                                    Application.Restart();
                                }
                            }

                        }


                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }

                    Conexion.Close();
                }

            }

            else
            {
                MessageBox.Show("Usted no ha votado por nadie, por favor efectue el voto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }
        void generarcomprobante()
        {
            string nombreArchivo = "Comprobante.pdf"; 
            Document documento = new Document(PageSize.LETTER, 50, 50, 50, 100); 
            PdfWriter.GetInstance(documento, new FileStream(nombreArchivo, FileMode.Create)); 
            documento.Open(); 
            
            PdfPTable encabezado = new PdfPTable(2); 
            encabezado.SetWidthPercentage(new float[] { 100, 400 }, PageSize.LETTER); //Se crean las celdas para la tabla.
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
            
            documento.Add(new Paragraph("\n"));
            

            Paragraph paragraph = new Paragraph();
            paragraph.Alignment = Element.ALIGN_LEFT;
            paragraph.Font = FontFactory.GetFont("Calibri", 9);
            paragraph.Add("Carnet: " + frmLogin.usuario);
            paragraph.Add("\nNombres: " + frmVotante.nombrevot);
            paragraph.Add("\nApellidos: " + frmVotante.apellidovot);
            paragraph.Add("\nEdad: " + frmVotante.edadvot);
            paragraph.Add("\nEspecialidad: " + frmVotante.especialidadvot);

            PdfPTable cuerpo = new PdfPTable(2);
            cuerpo.SetWidthPercentage(new float[] { 75, 200 }, PageSize.LETTER); 
            
            cuerpo.AddCell(iTextSharp.text.Image.GetInstance(frmVotante.fotovot));
            cuerpo.AddCell(paragraph);



            
            foreach (PdfPCell celda in cuerpo.Rows[0].GetCells())
            {
                celda.BackgroundColor = BaseColor.LIGHT_GRAY; 
                celda.HorizontalAlignment = 0; 
                celda.VerticalAlignment = 5; 
                celda.Border = 4;
            }

            

            PdfPCell cell = new PdfPCell(new Phrase("¡Gracias por votar!", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 15f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255);
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            documento.Add(new Paragraph("\n"));
            documento.Add(new Paragraph("\n"));
            cuerpo.AddCell(cell);
            documento.Add(cuerpo);

           



            documento.Close(); 
            Process archivo = new Process(); 
            archivo.StartInfo.FileName = nombreArchivo; 
            archivo.Start(); 
        }
        private void cmbSelecCand_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

            string carnet = "";
            string nombres = "";
            string apellidos = "";
            string sexo = "";
            string edad = "";
            string foto = "";
            string especialidad = "";
            string codesp = "";

            string consulta = "SELECT car_can, nom_can, ape_can, sex_can, edad_can, fot_can, can.cod_esp FROM Candidatos AS can, Especialidad AS esp WHERE car_can= '" + cmbSelecCand.SelectedValue + "'";
            OleDbCommand sql = new OleDbCommand(consulta, Conexion);
            OleDbDataReader lector;

            
                Conexion.Open();
                lector = sql.ExecuteReader();
                lector.Read();

                carnet = lector.GetValue(0).ToString();
                nombres = lector.GetValue(1).ToString();
                apellidos = lector.GetValue(2).ToString();
                sexo = lector.GetValue(3).ToString();
                edad = lector.GetValue(4).ToString();
                foto = lector.GetValue(5).ToString();
                codesp = lector.GetValue(6).ToString();

                txtCarnet.Text = carnet;
                txtNom.Text = nombres;
                txtApe.Text = apellidos;
                txtSex.Text = sexo;
                txtFecNac.Text = edad;
                pctFotCand.ImageLocation = foto;
                

                string consulta2 = "SELECT nom_esp FROM Especialidad WHERE cod_esp = '" + codesp + "'";
                OleDbCommand sql2 = new OleDbCommand(consulta2, Conexion);
                OleDbDataReader lector2 = sql2.ExecuteReader();
                lector2.Read();

                especialidad = lector2.GetValue(0).ToString();

                txtEspecialidad.Text = especialidad;

            }

            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            Conexion.Close();

        }

        
    }
}
