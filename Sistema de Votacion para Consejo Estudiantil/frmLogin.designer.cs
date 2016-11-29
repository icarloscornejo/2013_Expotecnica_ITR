namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNIE = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNIE = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lklNIE = new System.Windows.Forms.LinkLabel();
            this.lblEsperando = new System.Windows.Forms.Label();
            this.lnkOlvideContraseña = new System.Windows.Forms.LinkLabel();
            this.txtUsuCarnet = new System.Windows.Forms.TextBox();
            this.btnvercontraseña = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(32, 145);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 14);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblNIE
            // 
            this.lblNIE.AutoSize = true;
            this.lblNIE.Location = new System.Drawing.Point(32, 208);
            this.lblNIE.Name = "lblNIE";
            this.lblNIE.Size = new System.Drawing.Size(28, 14);
            this.lblNIE.TabIndex = 1;
            this.lblNIE.Text = "NIE:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(35, 162);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(233, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtNIE
            // 
            this.txtNIE.Location = new System.Drawing.Point(35, 225);
            this.txtNIE.Name = "txtNIE";
            this.txtNIE.ShortcutsEnabled = false;
            this.txtNIE.Size = new System.Drawing.Size(217, 22);
            this.txtNIE.TabIndex = 2;
            this.txtNIE.UseSystemPasswordChar = true;
            this.txtNIE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIE_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(106, 296);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 25);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lklNIE
            // 
            this.lklNIE.AutoSize = true;
            this.lklNIE.Location = new System.Drawing.Point(38, 228);
            this.lklNIE.Name = "lklNIE";
            this.lklNIE.Size = new System.Drawing.Size(106, 14);
            this.lklNIE.TabIndex = 5;
            this.lklNIE.TabStop = true;
            this.lklNIE.Text = "No puedo accesar.";
            this.lklNIE.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklNIE_LinkClicked);
            // 
            // lblEsperando
            // 
            this.lblEsperando.AutoSize = true;
            this.lblEsperando.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsperando.Location = new System.Drawing.Point(38, 164);
            this.lblEsperando.Name = "lblEsperando";
            this.lblEsperando.Size = new System.Drawing.Size(214, 15);
            this.lblEsperando.TabIndex = 7;
            this.lblEsperando.Text = "Esperando identificacion de usuario...";
            // 
            // lnkOlvideContraseña
            // 
            this.lnkOlvideContraseña.AutoSize = true;
            this.lnkOlvideContraseña.Location = new System.Drawing.Point(32, 266);
            this.lnkOlvideContraseña.Name = "lnkOlvideContraseña";
            this.lnkOlvideContraseña.Size = new System.Drawing.Size(129, 14);
            this.lnkOlvideContraseña.TabIndex = 9;
            this.lnkOlvideContraseña.TabStop = true;
            this.lnkOlvideContraseña.Text = "Olvide mi contraseña..";
            this.lnkOlvideContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkOlvideContraseña_LinkClicked);
            // 
            // txtUsuCarnet
            // 
            this.txtUsuCarnet.Location = new System.Drawing.Point(334, 164);
            this.txtUsuCarnet.Name = "txtUsuCarnet";
            this.txtUsuCarnet.Size = new System.Drawing.Size(100, 22);
            this.txtUsuCarnet.TabIndex = 10;
            this.txtUsuCarnet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuCarnet_KeyPress);
            // 
            // btnvercontraseña
            // 
            this.btnvercontraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnvercontraseña.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.Sin_título;
            this.btnvercontraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvercontraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvercontraseña.Location = new System.Drawing.Point(244, 225);
            this.btnvercontraseña.Name = "btnvercontraseña";
            this.btnvercontraseña.Size = new System.Drawing.Size(24, 24);
            this.btnvercontraseña.TabIndex = 11;
            this.btnvercontraseña.UseVisualStyleBackColor = false;
            this.btnvercontraseña.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnvercontraseña_MouseDown);
            this.btnvercontraseña.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnvercontraseña_MouseUp);
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(25, 23);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(243, 82);
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(295, 376);
            this.ControlBox = false;
            this.Controls.Add(this.btnvercontraseña);
            this.Controls.Add(this.txtUsuCarnet);
            this.Controls.Add(this.lnkOlvideContraseña);
            this.Controls.Add(this.lblEsperando);
            this.Controls.Add(this.lklNIE);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtNIE);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblNIE);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNIE;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNIE;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.LinkLabel lklNIE;
        private System.Windows.Forms.Label lblEsperando;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.LinkLabel lnkOlvideContraseña;
        private System.Windows.Forms.TextBox txtUsuCarnet;
        private System.Windows.Forms.Button btnvercontraseña;
    }
}

