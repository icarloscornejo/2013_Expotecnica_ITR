namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmEspecialidad
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblespecialidad = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grpTabla = new System.Windows.Forms.GroupBox();
            this.dgvespecialidad = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grpRegistro.SuspendLayout();
            this.grpTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvespecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRegistro
            // 
            this.grpRegistro.BackColor = System.Drawing.Color.Transparent;
            this.grpRegistro.Controls.Add(this.label3);
            this.grpRegistro.Controls.Add(this.lblespecialidad);
            this.grpRegistro.Controls.Add(this.lblcod);
            this.grpRegistro.Controls.Add(this.txtdescripcion);
            this.grpRegistro.Controls.Add(this.txtnombre);
            this.grpRegistro.Controls.Add(this.txtcodigo);
            this.grpRegistro.Controls.Add(this.btnEliminar);
            this.grpRegistro.Controls.Add(this.btnAgregar);
            this.grpRegistro.Controls.Add(this.btnModificar);
            this.grpRegistro.Location = new System.Drawing.Point(549, 12);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(531, 394);
            this.grpRegistro.TabIndex = 1;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Descripcion:";
            // 
            // lblespecialidad
            // 
            this.lblespecialidad.AutoSize = true;
            this.lblespecialidad.Location = new System.Drawing.Point(7, 61);
            this.lblespecialidad.Name = "lblespecialidad";
            this.lblespecialidad.Size = new System.Drawing.Size(127, 15);
            this.lblespecialidad.TabIndex = 16;
            this.lblespecialidad.Text = "Nombre especialidad:";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(7, 28);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(122, 15);
            this.lblcod.TabIndex = 15;
            this.lblcod.Text = "Codigo especialidad:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(89, 93);
            this.txtdescripcion.MaxLength = 40;
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(303, 272);
            this.txtdescripcion.TabIndex = 2;
            this.txtdescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescripcion_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(156, 58);
            this.txtnombre.MaxLength = 25;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(235, 23);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(156, 25);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(235, 23);
            this.txtcodigo.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(415, 135);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 49);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(415, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 49);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(415, 80);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 49);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(976, 412);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(104, 46);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // grpTabla
            // 
            this.grpTabla.BackColor = System.Drawing.Color.Transparent;
            this.grpTabla.Controls.Add(this.dgvespecialidad);
            this.grpTabla.Controls.Add(this.btnLimpiar);
            this.grpTabla.Controls.Add(this.btnConsultar);
            this.grpTabla.Location = new System.Drawing.Point(12, 12);
            this.grpTabla.Name = "grpTabla";
            this.grpTabla.Size = new System.Drawing.Size(531, 446);
            this.grpTabla.TabIndex = 8;
            this.grpTabla.TabStop = false;
            this.grpTabla.Text = "Tabla";
            // 
            // dgvespecialidad
            // 
            this.dgvespecialidad.AllowUserToAddRows = false;
            this.dgvespecialidad.AllowUserToDeleteRows = false;
            this.dgvespecialidad.AllowUserToOrderColumns = true;
            this.dgvespecialidad.AllowUserToResizeRows = false;
            this.dgvespecialidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvespecialidad.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvespecialidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvespecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvespecialidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvespecialidad.Location = new System.Drawing.Point(26, 63);
            this.dgvespecialidad.MultiSelect = false;
            this.dgvespecialidad.Name = "dgvespecialidad";
            this.dgvespecialidad.ReadOnly = true;
            this.dgvespecialidad.RowHeadersVisible = false;
            this.dgvespecialidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvespecialidad.Size = new System.Drawing.Size(499, 331);
            this.dgvespecialidad.TabIndex = 12;
            this.dgvespecialidad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvespecialidad_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(302, 25);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 27);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(147, 25);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 27);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // frmEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.FondoFrm;
            this.ClientSize = new System.Drawing.Size(1117, 477);
            this.ControlBox = false;
            this.Controls.Add(this.grpTabla);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.grpRegistro);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmEspecialidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidad";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEspecialidad_Load_1);
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            this.grpTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvespecialidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblespecialidad;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox grpTabla;
        private System.Windows.Forms.DataGridView dgvespecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
    }
}