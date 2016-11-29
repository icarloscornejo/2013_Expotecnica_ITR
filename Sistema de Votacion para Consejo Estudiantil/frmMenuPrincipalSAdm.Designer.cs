namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmMenuPrincipalSAdm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEditCand = new System.Windows.Forms.Label();
            this.lblEspecialidades = new System.Windows.Forms.Label();
            this.lblAdmins = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblReiniciar = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.lblAgregarVotantes = new System.Windows.Forms.Label();
            this.lblBuscarVotantes = new System.Windows.Forms.Label();
            this.pctAgregarVotantes = new System.Windows.Forms.PictureBox();
            this.pctBuscarVotantes = new System.Windows.Forms.PictureBox();
            this.pctEditarAdministradores = new System.Windows.Forms.PictureBox();
            this.pctEditarCandidatos = new System.Windows.Forms.PictureBox();
            this.pctEditarEspecialidades = new System.Windows.Forms.PictureBox();
            this.btnIniNuevaVot = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.pctDescripcion = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctSalir = new System.Windows.Forms.PictureBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAgregarVotantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscarVotantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEditarAdministradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEditarCandidatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEditarEspecialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bienvenido SuperAdmin, ¿Que desea hacer?";
            // 
            // lblEditCand
            // 
            this.lblEditCand.AutoSize = true;
            this.lblEditCand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCand.Location = new System.Drawing.Point(162, 109);
            this.lblEditCand.Name = "lblEditCand";
            this.lblEditCand.Size = new System.Drawing.Size(124, 19);
            this.lblEditCand.TabIndex = 10;
            this.lblEditCand.Text = "Editar Candidatos";
            this.lblEditCand.MouseHover += new System.EventHandler(this.pctEditarCandidatos_MouseHover);
            // 
            // lblEspecialidades
            // 
            this.lblEspecialidades.AutoSize = true;
            this.lblEspecialidades.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidades.Location = new System.Drawing.Point(162, 384);
            this.lblEspecialidades.Name = "lblEspecialidades";
            this.lblEspecialidades.Size = new System.Drawing.Size(148, 19);
            this.lblEspecialidades.TabIndex = 12;
            this.lblEspecialidades.Text = "Editar Especialidades";
            this.lblEspecialidades.MouseHover += new System.EventHandler(this.lblEspecialidades_MouseHover);
            // 
            // lblAdmins
            // 
            this.lblAdmins.AutoSize = true;
            this.lblAdmins.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmins.Location = new System.Drawing.Point(162, 511);
            this.lblAdmins.Name = "lblAdmins";
            this.lblAdmins.Size = new System.Drawing.Size(157, 19);
            this.lblAdmins.TabIndex = 13;
            this.lblAdmins.Text = "Editar Administradores";
            this.lblAdmins.MouseHover += new System.EventHandler(this.pctEditarAdministradores_MouseHover);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.Color.Transparent;
            this.lblSalir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.Location = new System.Drawing.Point(67, 712);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(37, 19);
            this.lblSalir.TabIndex = 15;
            this.lblSalir.Text = "Salir";
            // 
            // lblReiniciar
            // 
            this.lblReiniciar.AutoSize = true;
            this.lblReiniciar.BackColor = System.Drawing.Color.Transparent;
            this.lblReiniciar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReiniciar.Location = new System.Drawing.Point(176, 712);
            this.lblReiniciar.Name = "lblReiniciar";
            this.lblReiniciar.Size = new System.Drawing.Size(95, 19);
            this.lblReiniciar.TabIndex = 17;
            this.lblReiniciar.Text = "Cerrar Sesión";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(801, 330);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(489, 220);
            this.txtDescripcion.TabIndex = 18;
            this.txtDescripcion.Text = "Porfavor, seleccione una de las opciones a su izquierda para continuar..";
            // 
            // grpMain
            // 
            this.grpMain.BackColor = System.Drawing.Color.Transparent;
            this.grpMain.Controls.Add(this.lblAgregarVotantes);
            this.grpMain.Controls.Add(this.lblBuscarVotantes);
            this.grpMain.Controls.Add(this.pctAgregarVotantes);
            this.grpMain.Controls.Add(this.pctBuscarVotantes);
            this.grpMain.Controls.Add(this.pctEditarAdministradores);
            this.grpMain.Controls.Add(this.pctEditarCandidatos);
            this.grpMain.Controls.Add(this.pctEditarEspecialidades);
            this.grpMain.Controls.Add(this.label1);
            this.grpMain.Controls.Add(this.lblEditCand);
            this.grpMain.Controls.Add(this.lblAdmins);
            this.grpMain.Controls.Add(this.lblEspecialidades);
            this.grpMain.Location = new System.Drawing.Point(140, 21);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(477, 610);
            this.grpMain.TabIndex = 19;
            this.grpMain.TabStop = false;
            // 
            // lblAgregarVotantes
            // 
            this.lblAgregarVotantes.AutoSize = true;
            this.lblAgregarVotantes.Location = new System.Drawing.Point(213, 210);
            this.lblAgregarVotantes.Name = "lblAgregarVotantes";
            this.lblAgregarVotantes.Size = new System.Drawing.Size(99, 14);
            this.lblAgregarVotantes.TabIndex = 19;
            this.lblAgregarVotantes.Text = "Agregar Votantes";
            this.lblAgregarVotantes.MouseHover += new System.EventHandler(this.lblAgregarVotantes_MouseHover);
            // 
            // lblBuscarVotantes
            // 
            this.lblBuscarVotantes.AutoSize = true;
            this.lblBuscarVotantes.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblBuscarVotantes.Location = new System.Drawing.Point(161, 259);
            this.lblBuscarVotantes.Name = "lblBuscarVotantes";
            this.lblBuscarVotantes.Size = new System.Drawing.Size(114, 19);
            this.lblBuscarVotantes.TabIndex = 18;
            this.lblBuscarVotantes.Text = "Buscar Votantes";
            this.lblBuscarVotantes.Click += new System.EventHandler(this.lblBuscarVotantes_Click);
            this.lblBuscarVotantes.MouseHover += new System.EventHandler(this.lblBuscarVotantes_MouseHover);
            // 
            // pctAgregarVotantes
            // 
            this.pctAgregarVotantes.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.xD;
            this.pctAgregarVotantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctAgregarVotantes.Location = new System.Drawing.Point(166, 199);
            this.pctAgregarVotantes.Name = "pctAgregarVotantes";
            this.pctAgregarVotantes.Size = new System.Drawing.Size(41, 42);
            this.pctAgregarVotantes.TabIndex = 17;
            this.pctAgregarVotantes.TabStop = false;
            this.pctAgregarVotantes.Click += new System.EventHandler(this.pctAgregarVotantes_Click);
            this.pctAgregarVotantes.MouseHover += new System.EventHandler(this.pctAgregarVotantes_MouseHover);
            // 
            // pctBuscarVotantes
            // 
            this.pctBuscarVotantes.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.buscar;
            this.pctBuscarVotantes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBuscarVotantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBuscarVotantes.Location = new System.Drawing.Point(24, 193);
            this.pctBuscarVotantes.Name = "pctBuscarVotantes";
            this.pctBuscarVotantes.Size = new System.Drawing.Size(133, 129);
            this.pctBuscarVotantes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBuscarVotantes.TabIndex = 16;
            this.pctBuscarVotantes.TabStop = false;
            this.pctBuscarVotantes.Click += new System.EventHandler(this.pctBuscarVotantes_Click);
            this.pctBuscarVotantes.MouseHover += new System.EventHandler(this.pctBuscarVotantes_MouseHover);
            // 
            // pctEditarAdministradores
            // 
            this.pctEditarAdministradores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctEditarAdministradores.Image = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources._4;
            this.pctEditarAdministradores.Location = new System.Drawing.Point(24, 463);
            this.pctEditarAdministradores.Name = "pctEditarAdministradores";
            this.pctEditarAdministradores.Size = new System.Drawing.Size(132, 122);
            this.pctEditarAdministradores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEditarAdministradores.TabIndex = 8;
            this.pctEditarAdministradores.TabStop = false;
            this.pctEditarAdministradores.Click += new System.EventHandler(this.pctEditarAdministradores_Click);
            this.pctEditarAdministradores.MouseHover += new System.EventHandler(this.pctEditarAdministradores_MouseHover);
            // 
            // pctEditarCandidatos
            // 
            this.pctEditarCandidatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctEditarCandidatos.Image = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources._1;
            this.pctEditarCandidatos.Location = new System.Drawing.Point(24, 58);
            this.pctEditarCandidatos.Name = "pctEditarCandidatos";
            this.pctEditarCandidatos.Size = new System.Drawing.Size(132, 129);
            this.pctEditarCandidatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEditarCandidatos.TabIndex = 5;
            this.pctEditarCandidatos.TabStop = false;
            this.pctEditarCandidatos.Click += new System.EventHandler(this.pctEditarCandidatos_Click);
            this.pctEditarCandidatos.MouseHover += new System.EventHandler(this.pctEditarCandidatos_MouseHover);
            // 
            // pctEditarEspecialidades
            // 
            this.pctEditarEspecialidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctEditarEspecialidades.Image = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources._2;
            this.pctEditarEspecialidades.Location = new System.Drawing.Point(24, 328);
            this.pctEditarEspecialidades.Name = "pctEditarEspecialidades";
            this.pctEditarEspecialidades.Size = new System.Drawing.Size(132, 129);
            this.pctEditarEspecialidades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEditarEspecialidades.TabIndex = 7;
            this.pctEditarEspecialidades.TabStop = false;
            this.pctEditarEspecialidades.Click += new System.EventHandler(this.pctEditarEspecialidades_Click);
            this.pctEditarEspecialidades.MouseHover += new System.EventHandler(this.lblEspecialidades_MouseHover);
            // 
            // btnIniNuevaVot
            // 
            this.btnIniNuevaVot.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniNuevaVot.Location = new System.Drawing.Point(319, 713);
            this.btnIniNuevaVot.Name = "btnIniNuevaVot";
            this.btnIniNuevaVot.Size = new System.Drawing.Size(146, 47);
            this.btnIniNuevaVot.TabIndex = 14;
            this.btnIniNuevaVot.Text = "Iniciar Nueva Votacion";
            this.btnIniNuevaVot.UseVisualStyleBackColor = true;
            this.btnIniNuevaVot.Click += new System.EventHandler(this.btnIniNuevaVot_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(839, 241);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTitulo.Size = new System.Drawing.Size(413, 43);
            this.txtTitulo.TabIndex = 20;
            this.txtTitulo.Text = "Bienvenido";
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pctDescripcion
            // 
            this.pctDescripcion.BackColor = System.Drawing.Color.White;
            this.pctDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctDescripcion.Image = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.sa1;
            this.pctDescripcion.Location = new System.Drawing.Point(956, 35);
            this.pctDescripcion.Name = "pctDescripcion";
            this.pctDescripcion.Size = new System.Drawing.Size(182, 173);
            this.pctDescripcion.TabIndex = 21;
            this.pctDescripcion.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.e6;
            this.pictureBox1.Location = new System.Drawing.Point(136, 712);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pctSalir
            // 
            this.pctSalir.Image = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.e5;
            this.pctSalir.Location = new System.Drawing.Point(27, 712);
            this.pctSalir.Name = "pctSalir";
            this.pctSalir.Size = new System.Drawing.Size(34, 35);
            this.pctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSalir.TabIndex = 14;
            this.pctSalir.TabStop = false;
            this.pctSalir.Click += new System.EventHandler(this.pctSalir_Click);
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(801, 556);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(100, 22);
            this.txtIndice.TabIndex = 22;
            this.txtIndice.Visible = false;
            // 
            // frmMenuPrincipalSAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.Fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.ControlBox = false;
            this.Controls.Add(this.btnIniNuevaVot);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.pctDescripcion);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.grpMain);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblReiniciar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.pctSalir);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPrincipalSAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAgregarVotantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscarVotantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEditarAdministradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEditarCandidatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEditarEspecialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctEditarCandidatos;
        private System.Windows.Forms.PictureBox pctEditarEspecialidades;
        private System.Windows.Forms.PictureBox pctEditarAdministradores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEditCand;
        private System.Windows.Forms.Label lblEspecialidades;
        private System.Windows.Forms.Label lblAdmins;
        private System.Windows.Forms.PictureBox pctSalir;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblReiniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox grpMain;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.PictureBox pctDescripcion;
        private System.Windows.Forms.Button btnIniNuevaVot;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.PictureBox pctAgregarVotantes;
        private System.Windows.Forms.Label lblBuscarVotantes;
        private System.Windows.Forms.Label lblAgregarVotantes;
        private System.Windows.Forms.PictureBox pctBuscarVotantes;
    }
}