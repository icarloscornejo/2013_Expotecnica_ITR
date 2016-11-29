namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmEditarVotantes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcontador = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnWebcam = new System.Windows.Forms.Button();
            this.btnexaminar = new System.Windows.Forms.Button();
            this.pctalumnos = new System.Windows.Forms.PictureBox();
            this.lblfoto = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.grpalu = new System.Windows.Forms.GroupBox();
            this.txtcarnet = new System.Windows.Forms.TextBox();
            this.txtNIE = new System.Windows.Forms.TextBox();
            this.lblNIE = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cbmespecialidad = new System.Windows.Forms.ComboBox();
            this.lblcarnet = new System.Windows.Forms.Label();
            this.lblespecialidad = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.lblapellido = new System.Windows.Forms.Label();
            this.cbmsexo = new System.Windows.Forms.ComboBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctalumnos)).BeginInit();
            this.grpalu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblcontador);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.grpalu);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 346);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            // 
            // lblcontador
            // 
            this.lblcontador.AutoSize = true;
            this.lblcontador.Location = new System.Drawing.Point(524, 111);
            this.lblcontador.Name = "lblcontador";
            this.lblcontador.Size = new System.Drawing.Size(0, 15);
            this.lblcontador.TabIndex = 31;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWebcam);
            this.groupBox3.Controls.Add(this.btnexaminar);
            this.groupBox3.Controls.Add(this.pctalumnos);
            this.groupBox3.Controls.Add(this.lblfoto);
            this.groupBox3.Location = new System.Drawing.Point(371, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 288);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // btnWebcam
            // 
            this.btnWebcam.Location = new System.Drawing.Point(126, 252);
            this.btnWebcam.Name = "btnWebcam";
            this.btnWebcam.Size = new System.Drawing.Size(87, 29);
            this.btnWebcam.TabIndex = 4;
            this.btnWebcam.Text = "Webcam";
            this.btnWebcam.UseVisualStyleBackColor = true;
            this.btnWebcam.Click += new System.EventHandler(this.btnWebcam_Click);
            // 
            // btnexaminar
            // 
            this.btnexaminar.Location = new System.Drawing.Point(126, 219);
            this.btnexaminar.Name = "btnexaminar";
            this.btnexaminar.Size = new System.Drawing.Size(87, 27);
            this.btnexaminar.TabIndex = 2;
            this.btnexaminar.Text = "Examinar";
            this.btnexaminar.UseVisualStyleBackColor = true;
            this.btnexaminar.Click += new System.EventHandler(this.btnexaminar_Click_1);
            // 
            // pctalumnos
            // 
            this.pctalumnos.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.sinfoto1;
            this.pctalumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctalumnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctalumnos.Location = new System.Drawing.Point(65, 27);
            this.pctalumnos.Name = "pctalumnos";
            this.pctalumnos.Size = new System.Drawing.Size(148, 184);
            this.pctalumnos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctalumnos.TabIndex = 1;
            this.pctalumnos.TabStop = false;
            // 
            // lblfoto
            // 
            this.lblfoto.AutoSize = true;
            this.lblfoto.Location = new System.Drawing.Point(22, 27);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(34, 15);
            this.lblfoto.TabIndex = 0;
            this.lblfoto.Text = "Foto:";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(678, 42);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(87, 49);
            this.btnmodificar.TabIndex = 13;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // grpalu
            // 
            this.grpalu.Controls.Add(this.txtcarnet);
            this.grpalu.Controls.Add(this.txtNIE);
            this.grpalu.Controls.Add(this.lblNIE);
            this.grpalu.Controls.Add(this.txtnombre);
            this.grpalu.Controls.Add(this.cbmespecialidad);
            this.grpalu.Controls.Add(this.lblcarnet);
            this.grpalu.Controls.Add(this.lblespecialidad);
            this.grpalu.Controls.Add(this.lblnombre);
            this.grpalu.Controls.Add(this.txtedad);
            this.grpalu.Controls.Add(this.lblapellido);
            this.grpalu.Controls.Add(this.cbmsexo);
            this.grpalu.Controls.Add(this.txtapellido);
            this.grpalu.Controls.Add(this.lbledad);
            this.grpalu.Controls.Add(this.lblsexo);
            this.grpalu.Location = new System.Drawing.Point(45, 32);
            this.grpalu.Name = "grpalu";
            this.grpalu.Size = new System.Drawing.Size(320, 252);
            this.grpalu.TabIndex = 29;
            this.grpalu.TabStop = false;
            this.grpalu.Text = " ";
            // 
            // txtcarnet
            // 
            this.txtcarnet.Location = new System.Drawing.Point(105, 15);
            this.txtcarnet.MaxLength = 8;
            this.txtcarnet.Name = "txtcarnet";
            this.txtcarnet.Size = new System.Drawing.Size(180, 23);
            this.txtcarnet.TabIndex = 1;
            this.txtcarnet.TextChanged += new System.EventHandler(this.txtcarnet_TextChanged);
            this.txtcarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcarnet_KeyPress_1);
            // 
            // txtNIE
            // 
            this.txtNIE.Location = new System.Drawing.Point(105, 46);
            this.txtNIE.MaxLength = 25;
            this.txtNIE.Name = "txtNIE";
            this.txtNIE.Size = new System.Drawing.Size(180, 23);
            this.txtNIE.TabIndex = 2;
            this.txtNIE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIE_KeyPress_1);
            // 
            // lblNIE
            // 
            this.lblNIE.AutoSize = true;
            this.lblNIE.Location = new System.Drawing.Point(57, 49);
            this.lblNIE.Name = "lblNIE";
            this.lblNIE.Size = new System.Drawing.Size(28, 15);
            this.lblNIE.TabIndex = 30;
            this.lblNIE.Text = "NIE:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(105, 79);
            this.txtnombre.MaxLength = 25;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(180, 23);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress_1);
            // 
            // cbmespecialidad
            // 
            this.cbmespecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmespecialidad.FormattingEnabled = true;
            this.cbmespecialidad.Location = new System.Drawing.Point(105, 201);
            this.cbmespecialidad.Name = "cbmespecialidad";
            this.cbmespecialidad.Size = new System.Drawing.Size(180, 23);
            this.cbmespecialidad.TabIndex = 7;
            // 
            // lblcarnet
            // 
            this.lblcarnet.AutoSize = true;
            this.lblcarnet.Location = new System.Drawing.Point(50, 18);
            this.lblcarnet.Name = "lblcarnet";
            this.lblcarnet.Size = new System.Drawing.Size(46, 15);
            this.lblcarnet.TabIndex = 16;
            this.lblcarnet.Text = "Carnet:";
            // 
            // lblespecialidad
            // 
            this.lblespecialidad.AutoSize = true;
            this.lblespecialidad.Location = new System.Drawing.Point(16, 206);
            this.lblespecialidad.Name = "lblespecialidad";
            this.lblespecialidad.Size = new System.Drawing.Size(81, 15);
            this.lblespecialidad.TabIndex = 27;
            this.lblespecialidad.Text = "Especialidad:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(43, 84);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(53, 15);
            this.lblnombre.TabIndex = 18;
            this.lblnombre.Text = "Nombre:";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(105, 171);
            this.txtedad.MaxLength = 2;
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(180, 23);
            this.txtedad.TabIndex = 6;
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress_1);
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(36, 114);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(56, 15);
            this.lblapellido.TabIndex = 20;
            this.lblapellido.Text = "Apellido:";
            // 
            // cbmsexo
            // 
            this.cbmsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmsexo.FormattingEnabled = true;
            this.cbmsexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbmsexo.Location = new System.Drawing.Point(105, 140);
            this.cbmsexo.Name = "cbmsexo";
            this.cbmsexo.Size = new System.Drawing.Size(180, 23);
            this.cbmsexo.TabIndex = 5;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(105, 110);
            this.txtapellido.MaxLength = 25;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(180, 23);
            this.txtapellido.TabIndex = 4;
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(57, 176);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(37, 15);
            this.lbledad.TabIndex = 24;
            this.lbledad.Text = "Edad:";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(58, 145);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(35, 15);
            this.lblsexo.TabIndex = 22;
            this.lblsexo.Text = "Sexo:";
            // 
            // frmEditarVotantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.FondoFrm;
            this.ClientSize = new System.Drawing.Size(916, 394);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEditarVotantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Votantes";
            this.Load += new System.EventHandler(this.frmEditarAlumnos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctalumnos)).EndInit();
            this.grpalu.ResumeLayout(false);
            this.grpalu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnexaminar;
        private System.Windows.Forms.PictureBox pctalumnos;
        private System.Windows.Forms.Label lblfoto;
        private System.Windows.Forms.GroupBox grpalu;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cbmespecialidad;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label lblcarnet;
        private System.Windows.Forms.Label lblespecialidad;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.ComboBox cbmsexo;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtNIE;
        private System.Windows.Forms.Label lblNIE;
        private System.Windows.Forms.TextBox txtcarnet;
        private System.Windows.Forms.Label lblcontador;
        private System.Windows.Forms.Button btnWebcam;

    }
}

