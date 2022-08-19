namespace Practica3LabelYLinkLabel
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEtiqueta1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEtiqueta1
            // 
            this.labelEtiqueta1.AutoSize = true;
            this.labelEtiqueta1.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtiqueta1.Location = new System.Drawing.Point(142, 56);
            this.labelEtiqueta1.Name = "labelEtiqueta1";
            this.labelEtiqueta1.Size = new System.Drawing.Size(171, 28);
            this.labelEtiqueta1.TabIndex = 0;
            this.labelEtiqueta1.Text = "labelEtiqueta";
            this.labelEtiqueta1.MouseLeave += new System.EventHandler(this.labelEtiqueta1_MouseLeave);
            this.labelEtiqueta1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelEtiqueta1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEtiqueta1);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEtiqueta1;
    }
}

