namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmInicioNueva
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNIE = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lbltema = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnvercontraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(175, 211);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 25);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(33, 159);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.ShortcutsEnabled = false;
            this.txtContraseña.Size = new System.Drawing.Size(217, 23);
            this.txtContraseña.TabIndex = 11;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(33, 110);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(217, 23);
            this.txtUsuario.TabIndex = 9;
            // 
            // lblNIE
            // 
            this.lblNIE.AutoSize = true;
            this.lblNIE.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIE.Location = new System.Drawing.Point(30, 142);
            this.lblNIE.Name = "lblNIE";
            this.lblNIE.Size = new System.Drawing.Size(73, 15);
            this.lblNIE.TabIndex = 10;
            this.lblNIE.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(30, 87);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(76, 15);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "SuperAdmin:";
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltema.Location = new System.Drawing.Point(10, 30);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(265, 19);
            this.lbltema.TabIndex = 13;
            this.lbltema.Text = "Loguee el SuperAdministrador porfavor:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(33, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnvercontraseña
            // 
            this.btnvercontraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnvercontraseña.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.Sin_título;
            this.btnvercontraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvercontraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvercontraseña.Location = new System.Drawing.Point(226, 159);
            this.btnvercontraseña.Name = "btnvercontraseña";
            this.btnvercontraseña.Size = new System.Drawing.Size(24, 24);
            this.btnvercontraseña.TabIndex = 15;
            this.btnvercontraseña.UseVisualStyleBackColor = false;
            this.btnvercontraseña.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnvercontraseña_MouseDown);
            this.btnvercontraseña.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnvercontraseña_MouseUp);
            // 
            // frmInicioNueva
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 263);
            this.ControlBox = false;
            this.Controls.Add(this.btnvercontraseña);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lbltema);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblNIE);
            this.Controls.Add(this.lblUsuario);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInicioNueva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva votacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblNIE;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lbltema;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnvercontraseña;
    }
}