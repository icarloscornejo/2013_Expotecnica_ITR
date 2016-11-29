using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Security.Cryptography;

namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    
    static class Program
    {
        
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
           [STAThread]
        static void Main()

        {
            OleDbConnection Conexion = new OleDbConnection(frmLogin.ConexionString);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                                
                string consulta = "SELECT usu_sadm FROM SuperAdministradores WHERE usu_sadm = usu_sadm";
                

                OleDbCommand sql = new OleDbCommand(consulta, Conexion);
                Conexion.Open();
                if (sql.ExecuteScalar() != null)
                {
                    Application.Run(new frmLogin());
                }
                else
                {
                    Application.Run(new frmBienvenida());
                }

            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                Conexion.Close();
            }
            
        }

}

