using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    public partial class frmWebcam : Form
    {
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;

        public frmWebcam()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        public static string direccionfoto = "";

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cmbWebcam.Items.Add(Dispositivos[0].Name.ToString());
            cmbWebcam.Text = cmbWebcam.Items[0].ToString();

        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }

            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);

            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }

        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pctWebcam.Image = Imagen;

        }

        private void Foto_Load(object sender, EventArgs e)
        {
            btnGuardarImagen.Enabled = false;
            direccionfoto = "";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {
                if (ExisteDispositivo)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cmbWebcam.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    Estado.Text = "Ejecutando Dispositivo…";
                    btnIniciar.Text = "Detener";
                    cmbWebcam.Enabled = false;
                    btnGuardarImagen.Enabled = false;
                    grpWebcam.Text = DispositivoDeVideo[cmbWebcam.SelectedIndex].Name.ToString();
                }
                else
                {
                    Estado.Text = "Error: No se encuenta el Dispositivo";
                }
            }

            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    btnGuardarImagen.Enabled = true;
                    Estado.Text = "Dispositivo Detenido…";
                    btnIniciar.Text = "Iniciar";
                    cmbWebcam.Enabled = true;

                }
            }
        }

        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            Helper.GuardarImagen(pctWebcam.Image);
        }

        public static int comprobacion = 0;

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            TerminarFuenteDeVideo();
            this.Close();
            comprobacion = 1;
            
        }
    }
}
