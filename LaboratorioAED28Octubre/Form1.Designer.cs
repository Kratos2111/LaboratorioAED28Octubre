namespace LaboratorioAED28Octubre
{
    partial class Principal
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
            this.btnFerreteria = new System.Windows.Forms.Button();
            this.btnAsignaturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFerreteria
            // 
            this.btnFerreteria.Location = new System.Drawing.Point(31, 70);
            this.btnFerreteria.Name = "btnFerreteria";
            this.btnFerreteria.Size = new System.Drawing.Size(82, 45);
            this.btnFerreteria.TabIndex = 0;
            this.btnFerreteria.Text = "Ferreteria";
            this.btnFerreteria.UseVisualStyleBackColor = true;
            // 
            // btnAsignaturas
            // 
            this.btnAsignaturas.Location = new System.Drawing.Point(119, 70);
            this.btnAsignaturas.Name = "btnAsignaturas";
            this.btnAsignaturas.Size = new System.Drawing.Size(76, 45);
            this.btnAsignaturas.TabIndex = 1;
            this.btnAsignaturas.Text = "Asignaturas";
            this.btnAsignaturas.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 170);
            this.Controls.Add(this.btnAsignaturas);
            this.Controls.Add(this.btnFerreteria);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFerreteria;
        private System.Windows.Forms.Button btnAsignaturas;
    }
}

