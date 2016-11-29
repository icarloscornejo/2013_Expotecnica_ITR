using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    
    class Helper
    {

        public static void GuardarImagen(System.Drawing.Image image)
        {

            SaveFileDialog s = new SaveFileDialog();
            s.FileName = frmAgregarVotantes.foto;// El nombre por defecto
            s.DefaultExt = ".Png";// el formato de la foto
            s.Filter = "Foto (.png)|*.png"; // los filtros segun la extension
            
                string filename = s.FileName;
                FileStream fstream = new FileStream(filename, FileMode.Create);
                image.Save(fstream, System.Drawing.Imaging.ImageFormat.Png);
                fstream.Close();
                frmWebcam.direccionfoto = filename;

            

        }
    }
}
