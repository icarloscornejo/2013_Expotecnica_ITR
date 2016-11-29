namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmWebcam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpWebcam = new System.Windows.Forms.GroupBox();
            this.pctWebcam = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cmbWebcam = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnGuardarImagen = new System.Windows.Forms.Button();
            this.grpWebcam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctWebcam)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWebcam
            // 
            this.grpWebcam.BackColor = System.Drawing.Color.Transparent;
            this.grpWebcam.Controls.Add(this.pctWebcam);
            this.grpWebcam.Location = new System.Drawing.Point(399, 17);
            this.grpWebcam.Margin = new System.Windows.Forms.Padding(4);
            this.grpWebcam.Name = "grpWebcam";
            this.grpWebcam.Padding = new System.Windows.Forms.Padding(4);
            this.grpWebcam.Size = new System.Drawing.Size(500, 403);
            this.grpWebcam.TabIndex = 0;
            this.grpWebcam.TabStop = false;
            this.grpWebcam.Text = "Webcam";
            // 
            // pctWebcam
            // 
            this.pctWebcam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctWebcam.Location = new System.Drawing.Point(4, 23);
            this.pctWebcam.Margin = new System.Windows.Forms.Padding(4);
            this.pctWebcam.Name = "pctWebcam";
            this.pctWebcam.Size = new System.Drawing.Size(492, 376);
            this.pctWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctWebcam.TabIndex = 0;
            this.pctWebcam.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(135, 168);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(147, 72);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // cmbWebcam
            // 
            this.cmbWebcam.FormattingEnabled = true;
            this.cmbWebcam.Location = new System.Drawing.Point(31, 42);
            this.cmbWebcam.Margin = new System.Windows.Forms.Padding(4);
            this.cmbWebcam.Name = "cmbWebcam";
            this.cmbWebcam.Size = new System.Drawing.Size(343, 26);
            this.cmbWebcam.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Estado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(915, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Estado
            // 
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(10, 17);
            this.Estado.Text = ".";
            // 
            // btnGuardarImagen
            // 
            this.btnGuardarImagen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarImagen.Location = new System.Drawing.Point(135, 264);
            this.btnGuardarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarImagen.Name = "btnGuardarImagen";
            this.btnGuardarImagen.Size = new System.Drawing.Size(147, 72);
            this.btnGuardarImagen.TabIndex = 4;
            this.btnGuardarImagen.Text = "Guardar";
            this.btnGuardarImagen.UseVisualStyleBackColor = true;
            this.btnGuardarImagen.Click += new System.EventHandler(this.btnGuardarImagen_Click);
            // 
            // frmWebcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.FondoFrm;
            this.ClientSize = new System.Drawing.Size(915, 451);
            this.Controls.Add(this.btnGuardarImagen);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbWebcam);
            this.Controls.Add(this.grpWebcam);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWebcam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foto";
            this.Load += new System.EventHandler(this.Foto_Load);
            this.grpWebcam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctWebcam)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWebcam;
        private System.Windows.Forms.PictureBox pctWebcam;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox cmbWebcam;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Estado;
        private System.Windows.Forms.Button btnGuardarImagen;
    }
}