namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmVotante
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
            this.lblCarnet = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.pctVotante = new System.Windows.Forms.PictureBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.btnProxVotar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVotante)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(257, 58);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(46, 15);
            this.lblCarnet.TabIndex = 0;
            this.lblCarnet.Text = "Carnet:";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(317, 55);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.ReadOnly = true;
            this.txtCarnet.Size = new System.Drawing.Size(116, 23);
            this.txtCarnet.TabIndex = 1;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(241, 97);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(59, 15);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "Nombres:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(317, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(116, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtEspecialidad);
            this.groupBox1.Controls.Add(this.lblEspecialidad);
            this.groupBox1.Controls.Add(this.pctVotante);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.lblEdad);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.lblApellidos);
            this.groupBox1.Controls.Add(this.txtCarnet);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblCarnet);
            this.groupBox1.Controls.Add(this.lblNombres);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 295);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtEspecialidad.Location = new System.Drawing.Point(317, 217);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(116, 23);
            this.txtEspecialidad.TabIndex = 15;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(217, 220);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(81, 15);
            this.lblEspecialidad.TabIndex = 14;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // pctVotante
            // 
            this.pctVotante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctVotante.Location = new System.Drawing.Point(41, 49);
            this.pctVotante.Name = "pctVotante";
            this.pctVotante.Size = new System.Drawing.Size(136, 191);
            this.pctVotante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVotante.TabIndex = 1;
            this.pctVotante.TabStop = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(317, 133);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(116, 23);
            this.txtApellidos.TabIndex = 13;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(266, 180);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(37, 15);
            this.lblEdad.TabIndex = 12;
            this.lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(317, 177);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(116, 23);
            this.txtEdad.TabIndex = 11;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(236, 136);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(62, 15);
            this.lblApellidos.TabIndex = 10;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // btnProxVotar
            // 
            this.btnProxVotar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProxVotar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProxVotar.Location = new System.Drawing.Point(282, 348);
            this.btnProxVotar.Name = "btnProxVotar";
            this.btnProxVotar.Size = new System.Drawing.Size(202, 27);
            this.btnProxVotar.TabIndex = 9;
            this.btnProxVotar.Text = "Ir a votar";
            this.btnProxVotar.UseVisualStyleBackColor = true;
            this.btnProxVotar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVotante
            // 
            this.AcceptButton = this.btnProxVotar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.FondoFrm;
            this.CancelButton = this.btnProxVotar;
            this.ClientSize = new System.Drawing.Size(506, 404);
            this.ControlBox = false;
            this.Controls.Add(this.btnProxVotar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVotante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.frmVotante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVotante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.PictureBox pctVotante;
        private System.Windows.Forms.Button btnProxVotar;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
    }
}