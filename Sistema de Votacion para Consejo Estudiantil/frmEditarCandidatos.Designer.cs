namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmEditarCandidatos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbxbase = new System.Windows.Forms.GroupBox();
            this.btnVotacionesAnteriores = new System.Windows.Forms.Button();
            this.lblVotacionesAnteriores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbVotacionesAnteriores = new System.Windows.Forms.ComboBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.dgvcandidatos = new System.Windows.Forms.DataGridView();
            this.carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Votos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxotocan = new System.Windows.Forms.GroupBox();
            this.btnexaminar = new System.Windows.Forms.Button();
            this.lblfoto = new System.Windows.Forms.Label();
            this.pctcandidatos = new System.Windows.Forms.PictureBox();
            this.gbxinfocandidatos = new System.Windows.Forms.GroupBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtcarnet = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.cbmespecialidad = new System.Windows.Forms.ComboBox();
            this.cbmsexo = new System.Windows.Forms.ComboBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblespecialidad = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcarnet = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.chartVotos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnestadistica = new System.Windows.Forms.Button();
            this.btnImprimirEst = new System.Windows.Forms.Button();
            this.lblEstadistica = new System.Windows.Forms.Label();
            this.gbxbase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcandidatos)).BeginInit();
            this.gbxotocan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctcandidatos)).BeginInit();
            this.gbxinfocandidatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVotos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxbase
            // 
            this.gbxbase.BackColor = System.Drawing.Color.Transparent;
            this.gbxbase.Controls.Add(this.btnVotacionesAnteriores);
            this.gbxbase.Controls.Add(this.lblVotacionesAnteriores);
            this.gbxbase.Controls.Add(this.label1);
            this.gbxbase.Controls.Add(this.cmbVotacionesAnteriores);
            this.gbxbase.Controls.Add(this.btnlimpiar);
            this.gbxbase.Controls.Add(this.btnconsultar);
            this.gbxbase.Controls.Add(this.dgvcandidatos);
            this.gbxbase.Location = new System.Drawing.Point(14, 328);
            this.gbxbase.Name = "gbxbase";
            this.gbxbase.Size = new System.Drawing.Size(770, 300);
            this.gbxbase.TabIndex = 12;
            this.gbxbase.TabStop = false;
            // 
            // btnVotacionesAnteriores
            // 
            this.btnVotacionesAnteriores.Location = new System.Drawing.Point(21, 23);
            this.btnVotacionesAnteriores.Name = "btnVotacionesAnteriores";
            this.btnVotacionesAnteriores.Size = new System.Drawing.Size(198, 23);
            this.btnVotacionesAnteriores.TabIndex = 21;
            this.btnVotacionesAnteriores.Text = "Consultar Votaciones Anteriores";
            this.btnVotacionesAnteriores.UseVisualStyleBackColor = true;
            this.btnVotacionesAnteriores.Click += new System.EventHandler(this.btnVotacionesAnteriores_Click);
            // 
            // lblVotacionesAnteriores
            // 
            this.lblVotacionesAnteriores.AutoSize = true;
            this.lblVotacionesAnteriores.Location = new System.Drawing.Point(18, 29);
            this.lblVotacionesAnteriores.Name = "lblVotacionesAnteriores";
            this.lblVotacionesAnteriores.Size = new System.Drawing.Size(130, 15);
            this.lblVotacionesAnteriores.TabIndex = 20;
            this.lblVotacionesAnteriores.Text = "Votaciones Anteriores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1128, -314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "label1";
            // 
            // cmbVotacionesAnteriores
            // 
            this.cmbVotacionesAnteriores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVotacionesAnteriores.FormattingEnabled = true;
            this.cmbVotacionesAnteriores.Location = new System.Drawing.Point(154, 23);
            this.cmbVotacionesAnteriores.Name = "cmbVotacionesAnteriores";
            this.cmbVotacionesAnteriores.Size = new System.Drawing.Size(121, 23);
            this.cmbVotacionesAnteriores.TabIndex = 18;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Enabled = false;
            this.btnlimpiar.Location = new System.Drawing.Point(412, 21);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(86, 27);
            this.btnlimpiar.TabIndex = 16;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Location = new System.Drawing.Point(321, 21);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(84, 27);
            this.btnconsultar.TabIndex = 17;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // dgvcandidatos
            // 
            this.dgvcandidatos.AllowUserToAddRows = false;
            this.dgvcandidatos.AllowUserToDeleteRows = false;
            this.dgvcandidatos.AllowUserToOrderColumns = true;
            this.dgvcandidatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvcandidatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcandidatos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvcandidatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvcandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carnet,
            this.nombre,
            this.apellido,
            this.edad,
            this.sexo,
            this.especialidad,
            this.Votos,
            this.foto});
            this.dgvcandidatos.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvcandidatos.Enabled = false;
            this.dgvcandidatos.Location = new System.Drawing.Point(0, 64);
            this.dgvcandidatos.MultiSelect = false;
            this.dgvcandidatos.Name = "dgvcandidatos";
            this.dgvcandidatos.ReadOnly = true;
            this.dgvcandidatos.RowHeadersVisible = false;
            this.dgvcandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcandidatos.Size = new System.Drawing.Size(770, 235);
            this.dgvcandidatos.TabIndex = 0;
            this.dgvcandidatos.TabStop = false;
            this.dgvcandidatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcandidatos_CellClick);
            // 
            // carnet
            // 
            this.carnet.HeaderText = "Carnet";
            this.carnet.Name = "carnet";
            this.carnet.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // especialidad
            // 
            this.especialidad.HeaderText = "Especialidad";
            this.especialidad.Name = "especialidad";
            this.especialidad.ReadOnly = true;
            // 
            // Votos
            // 
            this.Votos.HeaderText = "Votos";
            this.Votos.Name = "Votos";
            this.Votos.ReadOnly = true;
            // 
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Visible = false;
            // 
            // gbxotocan
            // 
            this.gbxotocan.BackColor = System.Drawing.Color.Transparent;
            this.gbxotocan.Controls.Add(this.btnexaminar);
            this.gbxotocan.Controls.Add(this.lblfoto);
            this.gbxotocan.Controls.Add(this.pctcandidatos);
            this.gbxotocan.Location = new System.Drawing.Point(519, 16);
            this.gbxotocan.Name = "gbxotocan";
            this.gbxotocan.Size = new System.Drawing.Size(265, 304);
            this.gbxotocan.TabIndex = 11;
            this.gbxotocan.TabStop = false;
            this.gbxotocan.Text = "Foto Candidato";
            // 
            // btnexaminar
            // 
            this.btnexaminar.Location = new System.Drawing.Point(112, 238);
            this.btnexaminar.Name = "btnexaminar";
            this.btnexaminar.Size = new System.Drawing.Size(87, 40);
            this.btnexaminar.TabIndex = 16;
            this.btnexaminar.Text = "Examinar";
            this.btnexaminar.UseVisualStyleBackColor = true;
            this.btnexaminar.Click += new System.EventHandler(this.btnexaminar_Click);
            // 
            // lblfoto
            // 
            this.lblfoto.AutoSize = true;
            this.lblfoto.Location = new System.Drawing.Point(17, 28);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(34, 15);
            this.lblfoto.TabIndex = 1;
            this.lblfoto.Text = "Foto:";
            // 
            // pctcandidatos
            // 
            this.pctcandidatos.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.sinfoto1;
            this.pctcandidatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctcandidatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctcandidatos.Location = new System.Drawing.Point(73, 28);
            this.pctcandidatos.Name = "pctcandidatos";
            this.pctcandidatos.Size = new System.Drawing.Size(161, 195);
            this.pctcandidatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctcandidatos.TabIndex = 0;
            this.pctcandidatos.TabStop = false;
            // 
            // gbxinfocandidatos
            // 
            this.gbxinfocandidatos.BackColor = System.Drawing.Color.Transparent;
            this.gbxinfocandidatos.Controls.Add(this.txtedad);
            this.gbxinfocandidatos.Controls.Add(this.txtcarnet);
            this.gbxinfocandidatos.Controls.Add(this.btnmodificar);
            this.gbxinfocandidatos.Controls.Add(this.btneliminar);
            this.gbxinfocandidatos.Controls.Add(this.btnagregar);
            this.gbxinfocandidatos.Controls.Add(this.cbmespecialidad);
            this.gbxinfocandidatos.Controls.Add(this.cbmsexo);
            this.gbxinfocandidatos.Controls.Add(this.txtapellido);
            this.gbxinfocandidatos.Controls.Add(this.txtnombre);
            this.gbxinfocandidatos.Controls.Add(this.lblespecialidad);
            this.gbxinfocandidatos.Controls.Add(this.lbledad);
            this.gbxinfocandidatos.Controls.Add(this.lblsexo);
            this.gbxinfocandidatos.Controls.Add(this.lblapellido);
            this.gbxinfocandidatos.Controls.Add(this.lblnombre);
            this.gbxinfocandidatos.Controls.Add(this.lblcarnet);
            this.gbxinfocandidatos.Location = new System.Drawing.Point(14, 14);
            this.gbxinfocandidatos.Name = "gbxinfocandidatos";
            this.gbxinfocandidatos.Size = new System.Drawing.Size(498, 306);
            this.gbxinfocandidatos.TabIndex = 10;
            this.gbxinfocandidatos.TabStop = false;
            this.gbxinfocandidatos.Text = "Info Candidatos";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(127, 183);
            this.txtedad.MaxLength = 2;
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(189, 23);
            this.txtedad.TabIndex = 5;
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtedad_KeyPress_1);
            // 
            // txtcarnet
            // 
            this.txtcarnet.Location = new System.Drawing.Point(127, 62);
            this.txtcarnet.MaxLength = 8;
            this.txtcarnet.Name = "txtcarnet";
            this.txtcarnet.Size = new System.Drawing.Size(189, 23);
            this.txtcarnet.TabIndex = 1;
            this.txtcarnet.TextChanged += new System.EventHandler(this.txtcarnet_TextChanged_1);
            this.txtcarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcarnet_KeyPress_1);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Location = new System.Drawing.Point(369, 122);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(86, 55);
            this.btnmodificar.TabIndex = 15;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Location = new System.Drawing.Point(369, 183);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(87, 55);
            this.btneliminar.TabIndex = 14;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(369, 62);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(86, 48);
            this.btnagregar.TabIndex = 13;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // cbmespecialidad
            // 
            this.cbmespecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmespecialidad.FormattingEnabled = true;
            this.cbmespecialidad.Location = new System.Drawing.Point(127, 213);
            this.cbmespecialidad.Name = "cbmespecialidad";
            this.cbmespecialidad.Size = new System.Drawing.Size(189, 23);
            this.cbmespecialidad.TabIndex = 6;
            // 
            // cbmsexo
            // 
            this.cbmsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmsexo.FormattingEnabled = true;
            this.cbmsexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.cbmsexo.Location = new System.Drawing.Point(127, 152);
            this.cbmsexo.Name = "cbmsexo";
            this.cbmsexo.Size = new System.Drawing.Size(189, 23);
            this.cbmsexo.TabIndex = 4;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(127, 122);
            this.txtapellido.MaxLength = 25;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(189, 23);
            this.txtapellido.TabIndex = 3;
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(127, 92);
            this.txtnombre.MaxLength = 25;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(189, 23);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // lblespecialidad
            // 
            this.lblespecialidad.AutoSize = true;
            this.lblespecialidad.Location = new System.Drawing.Point(38, 216);
            this.lblespecialidad.Name = "lblespecialidad";
            this.lblespecialidad.Size = new System.Drawing.Size(81, 15);
            this.lblespecialidad.TabIndex = 5;
            this.lblespecialidad.Text = "Especialidad:";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(78, 186);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(37, 15);
            this.lbledad.TabIndex = 4;
            this.lbledad.Text = "Edad:";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(79, 155);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(35, 15);
            this.lblsexo.TabIndex = 3;
            this.lblsexo.Text = "Sexo:";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(65, 125);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(56, 15);
            this.lblapellido.TabIndex = 2;
            this.lblapellido.Text = "Apellido:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(65, 95);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(53, 15);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblcarnet
            // 
            this.lblcarnet.AutoSize = true;
            this.lblcarnet.Location = new System.Drawing.Point(72, 65);
            this.lblcarnet.Name = "lblcarnet";
            this.lblcarnet.Size = new System.Drawing.Size(46, 15);
            this.lblcarnet.TabIndex = 0;
            this.lblcarnet.Text = "Carnet:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(1119, 594);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(87, 27);
            this.btnRegresar.TabIndex = 13;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // chartVotos
            // 
            this.chartVotos.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartVotos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVotos.Legends.Add(legend1);
            this.chartVotos.Location = new System.Drawing.Point(804, 136);
            this.chartVotos.Name = "chartVotos";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Votos";
            series1.YValuesPerPoint = 6;
            this.chartVotos.Series.Add(series1);
            this.chartVotos.Size = new System.Drawing.Size(440, 321);
            this.chartVotos.TabIndex = 14;
            this.chartVotos.Text = "chart1";
            // 
            // btnestadistica
            // 
            this.btnestadistica.Location = new System.Drawing.Point(846, 515);
            this.btnestadistica.Name = "btnestadistica";
            this.btnestadistica.Size = new System.Drawing.Size(161, 25);
            this.btnestadistica.TabIndex = 15;
            this.btnestadistica.Text = "Cargar Estadistica";
            this.btnestadistica.UseVisualStyleBackColor = true;
            this.btnestadistica.Click += new System.EventHandler(this.btnestadistica_Click);
            // 
            // btnImprimirEst
            // 
            this.btnImprimirEst.Location = new System.Drawing.Point(1046, 514);
            this.btnImprimirEst.Name = "btnImprimirEst";
            this.btnImprimirEst.Size = new System.Drawing.Size(160, 25);
            this.btnImprimirEst.TabIndex = 16;
            this.btnImprimirEst.Text = "Imprimir Estadistica";
            this.btnImprimirEst.UseVisualStyleBackColor = true;
            this.btnImprimirEst.Click += new System.EventHandler(this.btnImprimirEst_Click);
            // 
            // lblEstadistica
            // 
            this.lblEstadistica.AutoSize = true;
            this.lblEstadistica.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadistica.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadistica.Location = new System.Drawing.Point(982, 63);
            this.lblEstadistica.Name = "lblEstadistica";
            this.lblEstadistica.Size = new System.Drawing.Size(80, 19);
            this.lblEstadistica.TabIndex = 17;
            this.lblEstadistica.Text = "Estadistica";
            // 
            // frmEditarCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.FondoFrm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1258, 640);
            this.ControlBox = false;
            this.Controls.Add(this.lblEstadistica);
            this.Controls.Add(this.btnImprimirEst);
            this.Controls.Add(this.btnestadistica);
            this.Controls.Add(this.chartVotos);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.gbxbase);
            this.Controls.Add(this.gbxotocan);
            this.Controls.Add(this.gbxinfocandidatos);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEditarCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Candidatos";
            this.Load += new System.EventHandler(this.frmeditarcandidatos_Load);
            this.gbxbase.ResumeLayout(false);
            this.gbxbase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcandidatos)).EndInit();
            this.gbxotocan.ResumeLayout(false);
            this.gbxotocan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctcandidatos)).EndInit();
            this.gbxinfocandidatos.ResumeLayout(false);
            this.gbxinfocandidatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxbase;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.DataGridView dgvcandidatos;
        private System.Windows.Forms.GroupBox gbxotocan;
        private System.Windows.Forms.Button btnexaminar;
        private System.Windows.Forms.Label lblfoto;
        private System.Windows.Forms.PictureBox pctcandidatos;
        private System.Windows.Forms.GroupBox gbxinfocandidatos;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ComboBox cbmespecialidad;
        private System.Windows.Forms.ComboBox cbmsexo;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblespecialidad;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcarnet;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtcarnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Votos;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVotos;
        private System.Windows.Forms.Button btnestadistica;
        private System.Windows.Forms.Button btnImprimirEst;
        private System.Windows.Forms.Label lblEstadistica;
        private System.Windows.Forms.ComboBox cmbVotacionesAnteriores;
        private System.Windows.Forms.Label lblVotacionesAnteriores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVotacionesAnteriores;
    }
}

