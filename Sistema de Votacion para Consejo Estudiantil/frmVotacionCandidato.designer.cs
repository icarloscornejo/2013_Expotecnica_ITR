namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmVotacionCandidato
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
            this.InfCandidato = new System.Windows.Forms.GroupBox();
            this.grpCandidato = new System.Windows.Forms.GroupBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.pctFotCand = new System.Windows.Forms.PictureBox();
            this.lblcarnet = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellidos = new System.Windows.Forms.Label();
            this.btnvot = new System.Windows.Forms.Button();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblnac = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtFecNac = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.cmbSelectCand = new System.Windows.Forms.Label();
            this.cmbSelecCand = new System.Windows.Forms.ComboBox();
            this.btnregre = new System.Windows.Forms.Button();
            this.InfCandidato.SuspendLayout();
            this.grpCandidato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotCand)).BeginInit();
            this.SuspendLayout();
            // 
            // InfCandidato
            // 
            this.InfCandidato.BackColor = System.Drawing.Color.Transparent;
            this.InfCandidato.Controls.Add(this.grpCandidato);
            this.InfCandidato.Controls.Add(this.cmbSelectCand);
            this.InfCandidato.Controls.Add(this.cmbSelecCand);
            this.InfCandidato.Controls.Add(this.btnregre);
            this.InfCandidato.Controls.Add(this.btnvot);
            this.InfCandidato.Location = new System.Drawing.Point(25, 14);
            this.InfCandidato.Name = "InfCandidato";
            this.InfCandidato.Size = new System.Drawing.Size(722, 481);
            this.InfCandidato.TabIndex = 1;
            this.InfCandidato.TabStop = false;
            this.InfCandidato.Text = "Información de candidato";
            // 
            // grpCandidato
            // 
            this.grpCandidato.Controls.Add(this.lblEspecialidad);
            this.grpCandidato.Controls.Add(this.txtEspecialidad);
            this.grpCandidato.Controls.Add(this.pctFotCand);
            this.grpCandidato.Controls.Add(this.lblcarnet);
            this.grpCandidato.Controls.Add(this.lblnombre);
            this.grpCandidato.Controls.Add(this.lblapellidos);
            this.grpCandidato.Controls.Add(this.txtCarnet);
            this.grpCandidato.Controls.Add(this.lblsexo);
            this.grpCandidato.Controls.Add(this.lblnac);
            this.grpCandidato.Controls.Add(this.txtNom);
            this.grpCandidato.Controls.Add(this.txtFecNac);
            this.grpCandidato.Controls.Add(this.txtApe);
            this.grpCandidato.Controls.Add(this.txtSex);
            this.grpCandidato.Location = new System.Drawing.Point(248, 21);
            this.grpCandidato.Name = "grpCandidato";
            this.grpCandidato.Size = new System.Drawing.Size(452, 376);
            this.grpCandidato.TabIndex = 36;
            this.grpCandidato.TabStop = false;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(295, 322);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(81, 14);
            this.lblEspecialidad.TabIndex = 36;
            this.lblEspecialidad.Text = "Especialidad:";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(256, 339);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.ReadOnly = true;
            this.txtEspecialidad.Size = new System.Drawing.Size(167, 22);
            this.txtEspecialidad.TabIndex = 37;
            // 
            // pctFotCand
            // 
            this.pctFotCand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pctFotCand.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.sinfoto1;
            this.pctFotCand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctFotCand.Location = new System.Drawing.Point(37, 54);
            this.pctFotCand.Name = "pctFotCand";
            this.pctFotCand.Size = new System.Drawing.Size(186, 271);
            this.pctFotCand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFotCand.TabIndex = 35;
            this.pctFotCand.TabStop = false;
            // 
            // lblcarnet
            // 
            this.lblcarnet.AutoSize = true;
            this.lblcarnet.Location = new System.Drawing.Point(289, 14);
            this.lblcarnet.Name = "lblcarnet";
            this.lblcarnet.Size = new System.Drawing.Size(107, 14);
            this.lblcarnet.TabIndex = 16;
            this.lblcarnet.Text = "Numero de carnet:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(313, 76);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(59, 14);
            this.lblnombre.TabIndex = 17;
            this.lblnombre.Text = "Nombres:";
            // 
            // lblapellidos
            // 
            this.lblapellidos.AutoSize = true;
            this.lblapellidos.Location = new System.Drawing.Point(313, 139);
            this.lblapellidos.Name = "lblapellidos";
            this.lblapellidos.Size = new System.Drawing.Size(63, 14);
            this.lblapellidos.TabIndex = 18;
            this.lblapellidos.Text = "Apellidos:";
            // 
            // btnvot
            // 
            this.btnvot.BackColor = System.Drawing.Color.Transparent;
            this.btnvot.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvot.Location = new System.Drawing.Point(610, 432);
            this.btnvot.Name = "btnvot";
            this.btnvot.Size = new System.Drawing.Size(90, 43);
            this.btnvot.TabIndex = 28;
            this.btnvot.Text = "Votar";
            this.btnvot.UseVisualStyleBackColor = false;
            this.btnvot.Click += new System.EventHandler(this.btnvot_Click);
            // 
            // txtCarnet
            // 
            this.txtCarnet.Location = new System.Drawing.Point(256, 31);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.ReadOnly = true;
            this.txtCarnet.Size = new System.Drawing.Size(167, 22);
            this.txtCarnet.TabIndex = 30;
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(322, 198);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(35, 14);
            this.lblsexo.TabIndex = 20;
            this.lblsexo.Text = "Sexo:";
            // 
            // lblnac
            // 
            this.lblnac.AutoSize = true;
            this.lblnac.Location = new System.Drawing.Point(322, 263);
            this.lblnac.Name = "lblnac";
            this.lblnac.Size = new System.Drawing.Size(37, 14);
            this.lblnac.TabIndex = 21;
            this.lblnac.Text = "Edad:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(256, 94);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(167, 22);
            this.txtNom.TabIndex = 23;
            // 
            // txtFecNac
            // 
            this.txtFecNac.Location = new System.Drawing.Point(256, 280);
            this.txtFecNac.Name = "txtFecNac";
            this.txtFecNac.ReadOnly = true;
            this.txtFecNac.Size = new System.Drawing.Size(167, 22);
            this.txtFecNac.TabIndex = 27;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(256, 156);
            this.txtApe.Name = "txtApe";
            this.txtApe.ReadOnly = true;
            this.txtApe.Size = new System.Drawing.Size(167, 22);
            this.txtApe.TabIndex = 24;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(256, 215);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(167, 22);
            this.txtSex.TabIndex = 25;
            // 
            // cmbSelectCand
            // 
            this.cmbSelectCand.AutoSize = true;
            this.cmbSelectCand.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelectCand.Location = new System.Drawing.Point(15, 102);
            this.cmbSelectCand.Name = "cmbSelectCand";
            this.cmbSelectCand.Size = new System.Drawing.Size(198, 26);
            this.cmbSelectCand.TabIndex = 32;
            this.cmbSelectCand.Text = "Seleccione candidato:";
            // 
            // cmbSelecCand
            // 
            this.cmbSelecCand.BackColor = System.Drawing.Color.White;
            this.cmbSelecCand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecCand.FormattingEnabled = true;
            this.cmbSelecCand.Location = new System.Drawing.Point(20, 145);
            this.cmbSelecCand.Name = "cmbSelecCand";
            this.cmbSelecCand.Size = new System.Drawing.Size(203, 22);
            this.cmbSelecCand.TabIndex = 31;
            this.cmbSelecCand.SelectionChangeCommitted += new System.EventHandler(this.cmbSelecCand_SelectionChangeCommitted);
            // 
            // btnregre
            // 
            this.btnregre.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregre.Location = new System.Drawing.Point(248, 432);
            this.btnregre.Name = "btnregre";
            this.btnregre.Size = new System.Drawing.Size(90, 43);
            this.btnregre.TabIndex = 29;
            this.btnregre.Text = "Regresar";
            this.btnregre.UseVisualStyleBackColor = true;
            this.btnregre.Click += new System.EventHandler(this.btnregre_Click);
            // 
            // frmVotacionCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.FondoFrm;
            this.ClientSize = new System.Drawing.Size(803, 508);
            this.ControlBox = false;
            this.Controls.Add(this.InfCandidato);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVotacionCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informacion del candidato";
            this.Load += new System.EventHandler(this.frmInfoCandidato_Load);
            this.InfCandidato.ResumeLayout(false);
            this.InfCandidato.PerformLayout();
            this.grpCandidato.ResumeLayout(false);
            this.grpCandidato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotCand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InfCandidato;
        private System.Windows.Forms.Button btnregre;
        private System.Windows.Forms.Button btnvot;
        private System.Windows.Forms.TextBox txtFecNac;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblnac;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcarnet;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label cmbSelectCand;
        private System.Windows.Forms.ComboBox cmbSelecCand;
        private System.Windows.Forms.PictureBox pctFotCand;
        private System.Windows.Forms.GroupBox grpCandidato;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.TextBox txtEspecialidad;
        
    }
}