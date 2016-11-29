namespace Sistema_de_Votacion_para_Consejo_Estudiantil
{
    partial class frmFondo
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
            this.lblcerrar = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcerrar
            // 
            this.lblcerrar.AutoSize = true;
            this.lblcerrar.BackColor = System.Drawing.Color.Transparent;
            this.lblcerrar.Location = new System.Drawing.Point(1335, 634);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(15, 13);
            this.lblcerrar.TabIndex = 0;
            this.lblcerrar.Text = "O";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblx.Location = new System.Drawing.Point(1231, 634);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(14, 13);
            this.lblx.TabIndex = 1;
            this.lblx.Text = "X";
            this.lblx.Click += new System.EventHandler(this.lblx_Click);
            // 
            // frmFondo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_Votacion_para_Consejo_Estudiantil.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.lblcerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFondo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fondo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Label lblx;
    }
}