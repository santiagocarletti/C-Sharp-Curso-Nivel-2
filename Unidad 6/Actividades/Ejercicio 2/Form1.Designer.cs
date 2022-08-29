namespace U6Proyecto1
{
    partial class FormPaises
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
            this.dgvPaises = new System.Windows.Forms.DataGridView();
            this.pbxPaises = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaises
            // 
            this.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaises.Location = new System.Drawing.Point(13, 13);
            this.dgvPaises.Name = "dgvPaises";
            this.dgvPaises.RowHeadersWidth = 51;
            this.dgvPaises.RowTemplate.Height = 24;
            this.dgvPaises.Size = new System.Drawing.Size(858, 262);
            this.dgvPaises.TabIndex = 0;
            this.dgvPaises.SelectionChanged += new System.EventHandler(this.dgvPaises_SelectionChanged);
            // 
            // pbxPaises
            // 
            this.pbxPaises.Location = new System.Drawing.Point(878, 13);
            this.pbxPaises.Name = "pbxPaises";
            this.pbxPaises.Size = new System.Drawing.Size(262, 262);
            this.pbxPaises.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPaises.TabIndex = 1;
            this.pbxPaises.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1195, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 8);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // FormPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 292);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbxPaises);
            this.Controls.Add(this.dgvPaises);
            this.Name = "FormPaises";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPaises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaises;
        private System.Windows.Forms.PictureBox pbxPaises;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

