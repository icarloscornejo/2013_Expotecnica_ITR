namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmBuscarVotantes
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
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grpvotante = new System.Windows.Forms.GroupBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblespecialidad = new System.Windows.Forms.Label();
            this.txtespecialidad = new System.Windows.Forms.TextBox();
            this.lblcarnet = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellidos = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtFecNac = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.pctFotVot = new System.Windows.Forms.PictureBox();
            this.grpBuscar.SuspendLayout();
            this.grpvotante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotVot)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscador
            // 
            this.txtBuscador.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBuscador.Location = new System.Drawing.Point(26, 39);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(227, 22);
            this.txtBuscador.TabIndex = 0;
            this.txtBuscador.Text = "Busca por carnet, nombres o apellidos";
            this.txtBuscador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscador_MouseClick);
            this.txtBuscador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscador_KeyPress);
            // 
            // grpBuscar
            // 
            this.grpBuscar.BackColor = System.Drawing.Color.Transparent;
            this.grpBuscar.Controls.Add(this.btnAtras);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Controls.Add(this.txtBuscador);
            this.grpBuscar.Location = new System.Drawing.Point(12, 12);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(316, 477);
            this.grpBuscar.TabIndex = 3;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.Location = new System.Drawing.Point(114, 427);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(77, 34);
            this.btnAtras.TabIndex = 45;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.esa;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(250, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 22);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grpvotante
            // 
            this.grpvotante.BackColor = System.Drawing.Color.Transparent;
            this.grpvotante.Controls.Add(this.lblFoto);
            this.grpvotante.Controls.Add(this.btnModificar);
            this.grpvotante.Controls.Add(this.btnEliminar);
            this.grpvotante.Controls.Add(this.lblespecialidad);
            this.grpvotante.Controls.Add(this.txtespecialidad);
            this.grpvotante.Controls.Add(this.lblcarnet);
            this.grpvotante.Controls.Add(this.lblnombre);
            this.grpvotante.Controls.Add(this.lblapellidos);
            this.grpvotante.Controls.Add(this.txtCarnet);
            this.grpvotante.Controls.Add(this.lblsexo);
            this.grpvotante.Controls.Add(this.lbledad);
            this.grpvotante.Controls.Add(this.txtNom);
            this.grpvotante.Controls.Add(this.txtFecNac);
            this.grpvotante.Controls.Add(this.txtApe);
            this.grpvotante.Controls.Add(this.txtSex);
            this.grpvotante.Controls.Add(this.pctFotVot);
            this.grpvotante.Location = new System.Drawing.Point(334, 12);
            this.grpvotante.Name = "grpvotante";
            this.grpvotante.Size = new System.Drawing.Size(507, 476);
            this.grpvotante.TabIndex = 4;
            this.grpvotante.TabStop = false;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(28, 33);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(41, 19);
            this.lblFoto.TabIndex = 45;
            this.lblFoto.Text = "Foto:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.Location = new System.Drawing.Point(121, 427);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(77, 34);
            this.btnModificar.TabIndex = 44;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Location = new System.Drawing.Point(334, 427);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 34);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblespecialidad
            // 
            this.lblespecialidad.AutoSize = true;
            this.lblespecialidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblespecialidad.Location = new System.Drawing.Point(231, 349);
            this.lblespecialidad.Name = "lblespecialidad";
            this.lblespecialidad.Size = new System.Drawing.Size(95, 19);
            this.lblespecialidad.TabIndex = 41;
            this.lblespecialidad.Text = "Especialidad:";
            // 
            // txtespecialidad
            // 
            this.txtespecialidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtespecialidad.Location = new System.Drawing.Point(235, 371);
            this.txtespecialidad.Name = "txtespecialidad";
            this.txtespecialidad.ReadOnly = true;
            this.txtespecialidad.Size = new System.Drawing.Size(202, 27);
            this.txtespecialidad.TabIndex = 42;
            // 
            // lblcarnet
            // 
            this.lblcarnet.AutoSize = true;
            this.lblcarnet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcarnet.Location = new System.Drawing.Point(236, 33);
            this.lblcarnet.Name = "lblcarnet";
            this.lblcarnet.Size = new System.Drawing.Size(129, 19);
            this.lblcarnet.TabIndex = 31;
            this.lblcarnet.Text = "Numero de carnet:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(236, 96);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(71, 19);
            this.lblnombre.TabIndex = 32;
            this.lblnombre.Text = "Nombres:";
            // 
            // lblapellidos
            // 
            this.lblapellidos.AutoSize = true;
            this.lblapellidos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellidos.Location = new System.Drawing.Point(236, 158);
            this.lblapellidos.Name = "lblapellidos";
            this.lblapellidos.Size = new System.Drawing.Size(73, 19);
            this.lblapellidos.TabIndex = 33;
            this.lblapellidos.Text = "Apellidos:";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(235, 55);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.ReadOnly = true;
            this.txtCarnet.Size = new System.Drawing.Size(202, 27);
            this.txtCarnet.TabIndex = 40;
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsexo.Location = new System.Drawing.Point(236, 217);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(43, 19);
            this.lblsexo.TabIndex = 34;
            this.lblsexo.Text = "Sexo:";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(236, 282);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(45, 19);
            this.lbledad.TabIndex = 35;
            this.lbledad.Text = "Edad:";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(235, 118);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(202, 27);
            this.txtNom.TabIndex = 36;
            // 
            // txtFecNac
            // 
            this.txtFecNac.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecNac.Location = new System.Drawing.Point(235, 304);
            this.txtFecNac.Name = "txtFecNac";
            this.txtFecNac.ReadOnly = true;
            this.txtFecNac.Size = new System.Drawing.Size(202, 27);
            this.txtFecNac.TabIndex = 39;
            // 
            // txtApe
            // 
            this.txtApe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApe.Location = new System.Drawing.Point(235, 180);
            this.txtApe.Name = "txtApe";
            this.txtApe.ReadOnly = true;
            this.txtApe.Size = new System.Drawing.Size(202, 27);
            this.txtApe.TabIndex = 37;
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.Location = new System.Drawing.Point(235, 239);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(202, 27);
            this.txtSex.TabIndex = 38;
            // 
            // pctFotVot
            // 
            this.pctFotVot.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.sinfoto1;
            this.pctFotVot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctFotVot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctFotVot.Location = new System.Drawing.Point(32, 55);
            this.pctFotVot.Name = "pctFotVot";
            this.pctFotVot.Size = new System.Drawing.Size(166, 216);
            this.pctFotVot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFotVot.TabIndex = 2;
            this.pctFotVot.TabStop = false;
            // 
            // frmBuscarVotantes
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.FondoFrm;
            this.ClientSize = new System.Drawing.Size(865, 501);
            this.ControlBox = false;
            this.Controls.Add(this.grpvotante);
            this.Controls.Add(this.grpBuscar);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBuscarVotantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Votantes";
            this.Load += new System.EventHandler(this.frmBuscarVotantes_Load);
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.grpvotante.ResumeLayout(false);
            this.grpvotante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotVot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.PictureBox pctFotVot;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.GroupBox grpvotante;
        private System.Windows.Forms.Label lblespecialidad;
        private System.Windows.Forms.TextBox txtespecialidad;
        private System.Windows.Forms.Label lblcarnet;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtFecNac;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblFoto;
    }
}