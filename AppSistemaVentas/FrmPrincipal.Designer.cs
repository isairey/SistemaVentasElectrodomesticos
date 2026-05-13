namespace AppSistemaVentas
{
    partial class FrmPrincipal
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
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnDocVenta = new System.Windows.Forms.Button();
            this.BtnCredito = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCliente
            // 
            this.BtnCliente.Location = new System.Drawing.Point(56, 39);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(75, 23);
            this.BtnCliente.TabIndex = 0;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnProducto
            // 
            this.BtnProducto.Location = new System.Drawing.Point(56, 73);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(83, 33);
            this.BtnProducto.TabIndex = 1;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.UseVisualStyleBackColor = true;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click);
            // 
            // BtnDocVenta
            // 
            this.BtnDocVenta.Location = new System.Drawing.Point(57, 112);
            this.BtnDocVenta.Name = "BtnDocVenta";
            this.BtnDocVenta.Size = new System.Drawing.Size(81, 33);
            this.BtnDocVenta.TabIndex = 2;
            this.BtnDocVenta.Text = "Doc Venta";
            this.BtnDocVenta.UseVisualStyleBackColor = true;
            this.BtnDocVenta.Click += new System.EventHandler(this.BtnDocVenta_Click);
            // 
            // BtnCredito
            // 
            this.BtnCredito.Location = new System.Drawing.Point(60, 154);
            this.BtnCredito.Name = "BtnCredito";
            this.BtnCredito.Size = new System.Drawing.Size(77, 34);
            this.BtnCredito.TabIndex = 3;
            this.BtnCredito.Text = "Credito";
            this.BtnCredito.UseVisualStyleBackColor = true;
            this.BtnCredito.Click += new System.EventHandler(this.BtnCredito_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(60, 195);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnUsuario.TabIndex = 4;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.BtnCredito);
            this.Controls.Add(this.BtnDocVenta);
            this.Controls.Add(this.BtnProducto);
            this.Controls.Add(this.BtnCliente);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnProducto;
        private System.Windows.Forms.Button BtnDocVenta;
        private System.Windows.Forms.Button BtnCredito;
        private System.Windows.Forms.Button btnUsuario;
    }
}

