namespace _6._7DiscosPract1
{
    partial class frmAltaDisco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtFechaLanzamiento = new System.Windows.Forms.TextBox();
            this.lblCantCanciones = new System.Windows.Forms.Label();
            this.txtCantidadCanciones = new System.Windows.Forms.TextBox();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(28, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(182, 27);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(158, 22);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtFechaLanzamiento
            // 
            this.txtFechaLanzamiento.Location = new System.Drawing.Point(182, 91);
            this.txtFechaLanzamiento.Name = "txtFechaLanzamiento";
            this.txtFechaLanzamiento.Size = new System.Drawing.Size(158, 22);
            this.txtFechaLanzamiento.TabIndex = 3;
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Location = new System.Drawing.Point(28, 166);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(148, 16);
            this.lblCantCanciones.TabIndex = 2;
            this.lblCantCanciones.Text = "Cantidad de canciones:";
            // 
            // txtCantidadCanciones
            // 
            this.txtCantidadCanciones.Location = new System.Drawing.Point(182, 160);
            this.txtCantidadCanciones.Name = "txtCantidadCanciones";
            this.txtCantidadCanciones.Size = new System.Drawing.Size(158, 22);
            this.txtCantidadCanciones.TabIndex = 5;
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(28, 97);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(142, 16);
            this.lblFechaLanzamiento.TabIndex = 4;
            this.lblFechaLanzamiento.Text = "Fecha de lanzamiento:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(31, 224);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(229, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 282);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCantidadCanciones);
            this.Controls.Add(this.lblFechaLanzamiento);
            this.Controls.Add(this.txtFechaLanzamiento);
            this.Controls.Add(this.lblCantCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAltaDisco";
            this.Text = "Alta Disco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtFechaLanzamiento;
        private System.Windows.Forms.Label lblCantCanciones;
        private System.Windows.Forms.TextBox txtCantidadCanciones;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}