namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmEditarAdmins
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grpAdmins = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.grpalu = new System.Windows.Forms.GroupBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.cbmsexo = new System.Windows.Forms.ComboBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.lblsexo = new System.Windows.Forms.Label();
            this.dgvadmins = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creadopor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnvercontraseña = new System.Windows.Forms.Button();
            this.grpAdmins.SuspendLayout();
            this.grpalu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadmins)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(516, 605);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(156, 28);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Ir al Menu Principal";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // grpAdmins
            // 
            this.grpAdmins.BackColor = System.Drawing.Color.Transparent;
            this.grpAdmins.Controls.Add(this.btnlimpiar);
            this.grpAdmins.Controls.Add(this.btnconsultar);
            this.grpAdmins.Controls.Add(this.grpalu);
            this.grpAdmins.Controls.Add(this.dgvadmins);
            this.grpAdmins.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdmins.Location = new System.Drawing.Point(14, 14);
            this.grpAdmins.Name = "grpAdmins";
            this.grpAdmins.Size = new System.Drawing.Size(735, 585);
            this.grpAdmins.TabIndex = 7;
            this.grpAdmins.TabStop = false;
            this.grpAdmins.Text = "Administradores";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(334, 310);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(87, 27);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(239, 310);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(87, 27);
            this.btnconsultar.TabIndex = 10;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // grpalu
            // 
            this.grpalu.Controls.Add(this.btnvercontraseña);
            this.grpalu.Controls.Add(this.lblCorreo);
            this.grpalu.Controls.Add(this.txtCorreo);
            this.grpalu.Controls.Add(this.txtUsuario);
            this.grpalu.Controls.Add(this.txtContraseña);
            this.grpalu.Controls.Add(this.lblContraseña);
            this.grpalu.Controls.Add(this.btnagregar);
            this.grpalu.Controls.Add(this.txtnombre);
            this.grpalu.Controls.Add(this.btneliminar);
            this.grpalu.Controls.Add(this.btnmodificar);
            this.grpalu.Controls.Add(this.lblUsuario);
            this.grpalu.Controls.Add(this.lblnombre);
            this.grpalu.Controls.Add(this.lblapellido);
            this.grpalu.Controls.Add(this.cbmsexo);
            this.grpalu.Controls.Add(this.txtapellido);
            this.grpalu.Controls.Add(this.lblsexo);
            this.grpalu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpalu.Location = new System.Drawing.Point(36, 32);
            this.grpalu.Name = "grpalu";
            this.grpalu.Size = new System.Drawing.Size(661, 252);
            this.grpalu.TabIndex = 29;
            this.grpalu.TabStop = false;
            this.grpalu.Text = " ";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(43, 106);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(47, 15);
            this.lblCorreo.TabIndex = 32;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(101, 103);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(180, 23);
            this.txtCorreo.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(101, 41);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(180, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(101, 72);
            this.txtContraseña.MaxLength = 25;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(160, 23);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNU_KeyPress);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(17, 75);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(73, 15);
            this.lblContraseña.TabIndex = 30;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(322, 55);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(84, 54);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(101, 131);
            this.txtnombre.MaxLength = 25;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(180, 23);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(455, 144);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(87, 55);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(322, 145);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(84, 54);
            this.btnmodificar.TabIndex = 8;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(36, 44);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 15);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(40, 135);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(53, 15);
            this.lblnombre.TabIndex = 18;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.BackColor = System.Drawing.Color.Transparent;
            this.lblapellido.Location = new System.Drawing.Point(37, 165);
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
            this.cbmsexo.Location = new System.Drawing.Point(101, 192);
            this.cbmsexo.Name = "cbmsexo";
            this.cbmsexo.Size = new System.Drawing.Size(180, 23);
            this.cbmsexo.TabIndex = 6;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(101, 162);
            this.txtapellido.MaxLength = 25;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(180, 23);
            this.txtapellido.TabIndex = 5;
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress);
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(55, 195);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(35, 15);
            this.lblsexo.TabIndex = 22;
            this.lblsexo.Text = "Sexo:";
            // 
            // dgvadmins
            // 
            this.dgvadmins.AllowUserToAddRows = false;
            this.dgvadmins.AllowUserToDeleteRows = false;
            this.dgvadmins.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(192)))));
            this.dgvadmins.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvadmins.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvadmins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvadmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvadmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NU,
            this.Correo,
            this.Nombre,
            this.Apellido,
            this.Sexo,
            this.Creadopor});
            this.dgvadmins.Location = new System.Drawing.Point(7, 343);
            this.dgvadmins.Name = "dgvadmins";
            this.dgvadmins.ReadOnly = true;
            this.dgvadmins.RowHeadersVisible = false;
            this.dgvadmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvadmins.Size = new System.Drawing.Size(722, 236);
            this.dgvadmins.TabIndex = 0;
            this.dgvadmins.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvadmins_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // NU
            // 
            this.NU.HeaderText = "NU";
            this.NU.Name = "NU";
            this.NU.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Creadopor
            // 
            this.Creadopor.HeaderText = "Creado por";
            this.Creadopor.Name = "Creadopor";
            this.Creadopor.ReadOnly = true;
            // 
            // btnvercontraseña
            // 
            this.btnvercontraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnvercontraseña.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.Sin_título;
            this.btnvercontraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvercontraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvercontraseña.Location = new System.Drawing.Point(257, 72);
            this.btnvercontraseña.Name = "btnvercontraseña";
            this.btnvercontraseña.Size = new System.Drawing.Size(24, 23);
            this.btnvercontraseña.TabIndex = 33;
            this.btnvercontraseña.UseVisualStyleBackColor = false;
            this.btnvercontraseña.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnvercontraseña_MouseDown);
            this.btnvercontraseña.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnvercontraseña_MouseUp);
            // 
            // frmEditarAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.FondoFrm;
            this.ClientSize = new System.Drawing.Size(761, 646);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.grpAdmins);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEditarAdmins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Administradores";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEditarAdmins_Load);
            this.grpAdmins.ResumeLayout(false);
            this.grpalu.ResumeLayout(false);
            this.grpalu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvadmins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox grpAdmins;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.GroupBox grpalu;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.ComboBox cbmsexo;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DataGridView dgvadmins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creadopor;
        private System.Windows.Forms.Button btnvercontraseña;
    }
}