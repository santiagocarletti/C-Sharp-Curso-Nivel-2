namespace Practica4TextBox
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
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.BackColor = System.Drawing.SystemColors.Window;
            this.txtBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBox1.Location = new System.Drawing.Point(245, 46);
            this.txtBox1.MaxLength = 20;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(331, 22);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox1_KeyPress);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(345, 98);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(106, 49);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Boton1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(300, 170);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox2.Size = new System.Drawing.Size(189, 177);
            this.txtBox2.TabIndex = 2;
            this.txtBox2.Leave += new System.EventHandler(this.txtBox2_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtBox2;
    }
}

