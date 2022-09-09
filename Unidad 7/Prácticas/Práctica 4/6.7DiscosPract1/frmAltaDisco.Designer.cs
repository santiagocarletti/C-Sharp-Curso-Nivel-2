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
            this.lblEstilo = new System.Windows.Forms.Label();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.cboTipoEdicion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.txtFechaLanzamiento.Location = new System.Drawing.Point(182, 65);
            this.txtFechaLanzamiento.Name = "txtFechaLanzamiento";
            this.txtFechaLanzamiento.Size = new System.Drawing.Size(158, 22);
            this.txtFechaLanzamiento.TabIndex = 3;
            // 
            // lblCantCanciones
            // 
            this.lblCantCanciones.AutoSize = true;
            this.lblCantCanciones.Location = new System.Drawing.Point(28, 109);
            this.lblCantCanciones.Name = "lblCantCanciones";
            this.lblCantCanciones.Size = new System.Drawing.Size(148, 16);
            this.lblCantCanciones.TabIndex = 2;
            this.lblCantCanciones.Text = "Cantidad de canciones:";
            // 
            // txtCantidadCanciones
            // 
            this.txtCantidadCanciones.Location = new System.Drawing.Point(182, 103);
            this.txtCantidadCanciones.Name = "txtCantidadCanciones";
            this.txtCantidadCanciones.Size = new System.Drawing.Size(158, 22);
            this.txtCantidadCanciones.TabIndex = 5;
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(28, 71);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(142, 16);
            this.lblFechaLanzamiento.TabIndex = 4;
            this.lblFechaLanzamiento.Text = "Fecha de lanzamiento:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(182, 245);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(65, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(275, 245);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(131, 151);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(43, 16);
            this.lblEstilo.TabIndex = 8;
            this.lblEstilo.Text = "Estilo:";
            // 
            // cboEstilo
            // 
            this.cboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(182, 142);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(158, 24);
            this.cboEstilo.TabIndex = 9;
            // 
            // cboTipoEdicion
            // 
            this.cboTipoEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEdicion.FormattingEnabled = true;
            this.cboTipoEdicion.Location = new System.Drawing.Point(182, 181);
            this.cboTipoEdicion.Name = "cboTipoEdicion";
            this.cboTipoEdicion.Size = new System.Drawing.Size(158, 24);
            this.cboTipoEdicion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo de edición:";
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 307);
            this.Controls.Add(this.cboTipoEdicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.lblEstilo);
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
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
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
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.ComboBox cboTipoEdicion;
        private System.Windows.Forms.Label label1;
    }
}