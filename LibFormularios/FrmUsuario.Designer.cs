namespace LibFormularios
{
    partial class FrmUsuario
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
            this.cmbTipo_Usuario = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtCodigo_Usuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Dgv_Usuario = new System.Windows.Forms.DataGridView();
            this.PanTitulo.SuspendLayout();
            this.PanDataView.SuspendLayout();
            this.PanDatos.SuspendLayout();
            this.PanBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "REGISTRO DE USUARIO";
            // 
            // PanDataView
            // 
            this.PanDataView.Controls.Add(this.Dgv_Usuario);
            this.PanDataView.Location = new System.Drawing.Point(0, 358);
            this.PanDataView.Size = new System.Drawing.Size(703, 282);
            // 
            // PanDatos
            // 
            this.PanDatos.Controls.Add(this.cmbEstado);
            this.PanDatos.Controls.Add(this.label7);
            this.PanDatos.Controls.Add(this.cmbTipo_Usuario);
            this.PanDatos.Controls.Add(this.txtTelefono);
            this.PanDatos.Controls.Add(this.txtEdad);
            this.PanDatos.Controls.Add(this.txtNombres);
            this.PanDatos.Controls.Add(this.txtDNI);
            this.PanDatos.Controls.Add(this.txtContraseña);
            this.PanDatos.Controls.Add(this.txtCodigo_Usuario);
            this.PanDatos.Controls.Add(this.label10);
            this.PanDatos.Controls.Add(this.label9);
            this.PanDatos.Controls.Add(this.label6);
            this.PanDatos.Controls.Add(this.label5);
            this.PanDatos.Controls.Add(this.label4);
            this.PanDatos.Controls.Add(this.label3);
            this.PanDatos.Controls.Add(this.label2);
            this.PanDatos.Size = new System.Drawing.Size(703, 211);
            // 
            // PanBotones
            // 
            this.PanBotones.Location = new System.Drawing.Point(3, 280);
            this.PanBotones.Size = new System.Drawing.Size(700, 72);
            // 
            // cmbTipo_Usuario
            // 
            this.cmbTipo_Usuario.FormattingEnabled = true;
            this.cmbTipo_Usuario.Items.AddRange(new object[] {
            "GERENTE",
            "VENDEDOR",
            "ADMINISTRADOR"});
            this.cmbTipo_Usuario.Location = new System.Drawing.Point(292, 151);
            this.cmbTipo_Usuario.Name = "cmbTipo_Usuario";
            this.cmbTipo_Usuario.Size = new System.Drawing.Size(162, 21);
            this.cmbTipo_Usuario.TabIndex = 31;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(292, 128);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(128, 20);
            this.txtTelefono.TabIndex = 30;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(292, 105);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(90, 20);
            this.txtEdad.TabIndex = 29;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(292, 82);
            this.txtNombres.MaxLength = 30;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(281, 20);
            this.txtNombres.TabIndex = 28;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(292, 59);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(89, 20);
            this.txtDNI.TabIndex = 27;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(292, 33);
            this.txtContraseña.MaxLength = 8;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(147, 20);
            this.txtContraseña.TabIndex = 26;
            // 
            // txtCodigo_Usuario
            // 
            this.txtCodigo_Usuario.Location = new System.Drawing.Point(292, 10);
            this.txtCodigo_Usuario.MaxLength = 5;
            this.txtCodigo_Usuario.Name = "txtCodigo_Usuario";
            this.txtCodigo_Usuario.Size = new System.Drawing.Size(215, 20);
            this.txtCodigo_Usuario.TabIndex = 25;
            this.txtCodigo_Usuario.Text = "U";
            this.txtCodigo_Usuario.TextChanged += new System.EventHandler(this.txtCodigo_Usuario_TextChanged);
            this.txtCodigo_Usuario.Leave += new System.EventHandler(this.txtCodigo_Usuario_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(195, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tipo                    :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Telefono             :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Edad                   :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nombres             :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "DNI                     :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Contraseña         :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Codigo Usuario   :";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "HABIL",
            "DESHA"});
            this.cmbEstado.Location = new System.Drawing.Point(292, 176);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(128, 21);
            this.cmbEstado.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Estado                 :";
            // 
            // Dgv_Usuario
            // 
            this.Dgv_Usuario.AllowUserToAddRows = false;
            this.Dgv_Usuario.AllowUserToDeleteRows = false;
            this.Dgv_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Usuario.Location = new System.Drawing.Point(36, 41);
            this.Dgv_Usuario.Name = "Dgv_Usuario";
            this.Dgv_Usuario.ReadOnly = true;
            this.Dgv_Usuario.Size = new System.Drawing.Size(631, 200);
            this.Dgv_Usuario.TabIndex = 1;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(703, 640);
            this.Name = "FrmUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            this.PanTitulo.ResumeLayout(false);
            this.PanDataView.ResumeLayout(false);
            this.PanDatos.ResumeLayout(false);
            this.PanDatos.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipo_Usuario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtCodigo_Usuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_Usuario;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label7;
    }
}
