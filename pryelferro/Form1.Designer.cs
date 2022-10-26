namespace pryelferro
{
    partial class frmferrocarril
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
            this.lbldias = new System.Windows.Forms.Label();
            this.lbldistancia = new System.Windows.Forms.Label();
            this.numdias = new System.Windows.Forms.NumericUpDown();
            this.txtdistancia = new System.Windows.Forms.TextBox();
            this.mrccosto = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numdias)).BeginInit();
            this.mrccosto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbldias
            // 
            this.lbldias.AutoSize = true;
            this.lbldias.Location = new System.Drawing.Point(207, 40);
            this.lbldias.Name = "lbldias";
            this.lbldias.Size = new System.Drawing.Size(26, 13);
            this.lbldias.TabIndex = 0;
            this.lbldias.Text = "dias";
            // 
            // lbldistancia
            // 
            this.lbldistancia.AutoSize = true;
            this.lbldistancia.Location = new System.Drawing.Point(207, 84);
            this.lbldistancia.Name = "lbldistancia";
            this.lbldistancia.Size = new System.Drawing.Size(49, 13);
            this.lbldistancia.TabIndex = 1;
            this.lbldistancia.Text = "distancia";
            // 
            // numdias
            // 
            this.numdias.Location = new System.Drawing.Point(284, 40);
            this.numdias.Name = "numdias";
            this.numdias.Size = new System.Drawing.Size(120, 20);
            this.numdias.TabIndex = 2;
            // 
            // txtdistancia
            // 
            this.txtdistancia.Location = new System.Drawing.Point(284, 84);
            this.txtdistancia.Name = "txtdistancia";
            this.txtdistancia.Size = new System.Drawing.Size(100, 20);
            this.txtdistancia.TabIndex = 3;
            this.txtdistancia.TextChanged += new System.EventHandler(this.txtdistancia_TextChanged);
            // 
            // mrccosto
            // 
            this.mrccosto.Controls.Add(this.txttotal);
            this.mrccosto.Controls.Add(this.txtprecio);
            this.mrccosto.Controls.Add(this.lbltotal);
            this.mrccosto.Controls.Add(this.lblprecio);
            this.mrccosto.Location = new System.Drawing.Point(166, 147);
            this.mrccosto.Name = "mrccosto";
            this.mrccosto.Size = new System.Drawing.Size(260, 100);
            this.mrccosto.TabIndex = 4;
            this.mrccosto.TabStop = false;
            this.mrccosto.Text = "costo";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(106, 59);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 3;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(106, 29);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 2;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(55, 59);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(27, 13);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "total";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(55, 32);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(36, 13);
            this.lblprecio.TabIndex = 0;
            this.lblprecio.Text = "precio";
            // 
            // frmferrocarril
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 406);
            this.Controls.Add(this.mrccosto);
            this.Controls.Add(this.txtdistancia);
            this.Controls.Add(this.numdias);
            this.Controls.Add(this.lbldistancia);
            this.Controls.Add(this.lbldias);
            this.Name = "frmferrocarril";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmferrocarril_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numdias)).EndInit();
            this.mrccosto.ResumeLayout(false);
            this.mrccosto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldias;
        private System.Windows.Forms.Label lbldistancia;
        private System.Windows.Forms.NumericUpDown numdias;
        private System.Windows.Forms.TextBox txtdistancia;
        private System.Windows.Forms.GroupBox mrccosto;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblprecio;
    }
}

