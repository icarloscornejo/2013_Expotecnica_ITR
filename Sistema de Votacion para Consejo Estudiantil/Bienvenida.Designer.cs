namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmBienvenida
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
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.pctdescbien = new System.Windows.Forms.PictureBox();
            this.pctBienvenida = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctdescbien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBienvenida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(602, 404);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(94, 32);
            this.btnsiguiente.TabIndex = 5;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Location = new System.Drawing.Point(447, 272);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 19);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Location = new System.Drawing.Point(447, 335);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(87, 19);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(451, 294);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(173, 27);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(451, 357);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(173, 27);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // pctdescbien
            // 
            this.pctdescbien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctdescbien.Image = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.bienvenido;
            this.pctdescbien.Location = new System.Drawing.Point(28, 148);
            this.pctdescbien.Name = "pctdescbien";
            this.pctdescbien.Size = new System.Drawing.Size(375, 267);
            this.pctdescbien.TabIndex = 6;
            this.pctdescbien.TabStop = false;
            // 
            // pctBienvenida
            // 
            this.pctBienvenida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctBienvenida.Image = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.a1;
            this.pctBienvenida.Location = new System.Drawing.Point(192, 23);
            this.pctBienvenida.Name = "pctBienvenida";
            this.pctBienvenida.Size = new System.Drawing.Size(279, 99);
            this.pctBienvenida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctBienvenida.TabIndex = 0;
            this.pctBienvenida.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Location = new System.Drawing.Point(447, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 19);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Location = new System.Drawing.Point(447, 209);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 19);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(451, 166);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(451, 231);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 27);
            this.txtApellido.TabIndex = 2;
            // 
            // frmBienvenida
            // 
            this.AcceptButton = this.btnsiguiente;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.FondoFrm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(708, 448);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pctdescbien);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.pctBienvenida);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.pctdescbien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBienvenida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBienvenida;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox pctdescbien;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
    }
}