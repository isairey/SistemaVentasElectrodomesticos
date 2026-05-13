namespace LibFormularios
{
    partial class FrmArqueoCaja
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
            this.components = new System.ComponentModel.Container();
            this.PanDatosArqueo = new System.Windows.Forms.Panel();
            this.TxtCodUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtNroArqueo = new System.Windows.Forms.TextBox();
            this.BtnBuscarDoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSolesInicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PanDetalleArqueo = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvDetalleArqueoCredito = new System.Windows.Forms.DataGridView();
            this.DgvDetalleArqueoContado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtSolesFinal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanDatosArqueo.SuspendLayout();
            this.PanDetalleArqueo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleArqueoCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleArqueoContado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanDatosArqueo
            // 
            this.PanDatosArqueo.Controls.Add(this.TxtCodUsuario);
            this.PanDatosArqueo.Controls.Add(this.label3);
            this.PanDatosArqueo.Controls.Add(this.BtnLimpiar);
            this.PanDatosArqueo.Controls.Add(this.TxtNroArqueo);
            this.PanDatosArqueo.Controls.Add(this.BtnBuscarDoc);
            this.PanDatosArqueo.Controls.Add(this.label1);
            this.PanDatosArqueo.Controls.Add(this.TxtFecha);
            this.PanDatosArqueo.Controls.Add(this.label2);
            this.PanDatosArqueo.Location = new System.Drawing.Point(2, 1);
            this.PanDatosArqueo.Name = "PanDatosArqueo";
            this.PanDatosArqueo.Size = new System.Drawing.Size(704, 104);
            this.PanDatosArqueo.TabIndex = 0;
            // 
            // TxtCodUsuario
            // 
            this.TxtCodUsuario.Enabled = false;
            this.TxtCodUsuario.Location = new System.Drawing.Point(133, 33);
            this.TxtCodUsuario.MaxLength = 10;
            this.TxtCodUsuario.Name = "TxtCodUsuario";
            this.TxtCodUsuario.Size = new System.Drawing.Size(194, 20);
            this.TxtCodUsuario.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Codigo del Usuario:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Enabled = false;
            this.BtnLimpiar.Location = new System.Drawing.Point(595, 54);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(93, 32);
            this.BtnLimpiar.TabIndex = 32;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtNroArqueo
            // 
            this.TxtNroArqueo.Enabled = false;
            this.TxtNroArqueo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroArqueo.Location = new System.Drawing.Point(385, 11);
            this.TxtNroArqueo.MaxLength = 10;
            this.TxtNroArqueo.Name = "TxtNroArqueo";
            this.TxtNroArqueo.Size = new System.Drawing.Size(203, 38);
            this.TxtNroArqueo.TabIndex = 31;
            this.TxtNroArqueo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnBuscarDoc
            // 
            this.BtnBuscarDoc.Location = new System.Drawing.Point(595, 11);
            this.BtnBuscarDoc.Name = "BtnBuscarDoc";
            this.BtnBuscarDoc.Size = new System.Drawing.Size(93, 37);
            this.BtnBuscarDoc.TabIndex = 30;
            this.BtnBuscarDoc.Text = "Ir a Doc ";
            this.BtnBuscarDoc.UseVisualStyleBackColor = true;
            this.BtnBuscarDoc.Click += new System.EventHandler(this.BtnBuscarDoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha:";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Enabled = false;
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(385, 56);
            this.TxtFecha.MaxLength = 10;
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(203, 30);
            this.TxtFecha.TabIndex = 29;
            this.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nro: ";
            // 
            // TxtSolesInicio
            // 
            this.TxtSolesInicio.Location = new System.Drawing.Point(527, 41);
            this.TxtSolesInicio.Name = "TxtSolesInicio";
            this.TxtSolesInicio.Size = new System.Drawing.Size(160, 20);
            this.TxtSolesInicio.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Monto inicial:";
            // 
            // PanDetalleArqueo
            // 
            this.PanDetalleArqueo.Controls.Add(this.label8);
            this.PanDetalleArqueo.Controls.Add(this.label7);
            this.PanDetalleArqueo.Controls.Add(this.DgvDetalleArqueoCredito);
            this.PanDetalleArqueo.Controls.Add(this.DgvDetalleArqueoContado);
            this.PanDetalleArqueo.Location = new System.Drawing.Point(3, 112);
            this.PanDetalleArqueo.Name = "PanDetalleArqueo";
            this.PanDetalleArqueo.Size = new System.Drawing.Size(702, 251);
            this.PanDetalleArqueo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Credito :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Contado :";
            // 
            // DgvDetalleArqueoCredito
            // 
            this.DgvDetalleArqueoCredito.AllowUserToAddRows = false;
            this.DgvDetalleArqueoCredito.AllowUserToDeleteRows = false;
            this.DgvDetalleArqueoCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleArqueoCredito.Location = new System.Drawing.Point(6, 143);
            this.DgvDetalleArqueoCredito.Name = "DgvDetalleArqueoCredito";
            this.DgvDetalleArqueoCredito.ReadOnly = true;
            this.DgvDetalleArqueoCredito.Size = new System.Drawing.Size(696, 105);
            this.DgvDetalleArqueoCredito.TabIndex = 1;
            // 
            // DgvDetalleArqueoContado
            // 
            this.DgvDetalleArqueoContado.AllowUserToAddRows = false;
            this.DgvDetalleArqueoContado.AllowUserToDeleteRows = false;
            this.DgvDetalleArqueoContado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleArqueoContado.Location = new System.Drawing.Point(6, 17);
            this.DgvDetalleArqueoContado.Name = "DgvDetalleArqueoContado";
            this.DgvDetalleArqueoContado.ReadOnly = true;
            this.DgvDetalleArqueoContado.Size = new System.Drawing.Size(696, 107);
            this.DgvDetalleArqueoContado.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtSolesInicio);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BtnGuardar);
            this.panel1.Controls.Add(this.TxtSolesFinal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(2, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 99);
            this.panel1.TabIndex = 2;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(51, 19);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(252, 56);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtSolesFinal
            // 
            this.TxtSolesFinal.Location = new System.Drawing.Point(527, 73);
            this.TxtSolesFinal.Name = "TxtSolesFinal";
            this.TxtSolesFinal.Size = new System.Drawing.Size(160, 20);
            this.TxtSolesFinal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Monto Final: ";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(527, 12);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(160, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmArqueoCaja
            // 
            this.ClientSize = new System.Drawing.Size(706, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanDetalleArqueo);
            this.Controls.Add(this.PanDatosArqueo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArqueoCaja";
            this.Text = "Arqueo de Caja ";
            this.PanDatosArqueo.ResumeLayout(false);
            this.PanDatosArqueo.PerformLayout();
            this.PanDetalleArqueo.ResumeLayout(false);
            this.PanDetalleArqueo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleArqueoCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleArqueoContado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanDatosArqueo;
        private System.Windows.Forms.TextBox TxtSolesInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCodUsuario;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Button BtnLimpiar;
        protected System.Windows.Forms.TextBox TxtNroArqueo;
        protected System.Windows.Forms.Button BtnBuscarDoc;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanDetalleArqueo;
        private System.Windows.Forms.DataGridView DgvDetalleArqueoContado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtSolesFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvDetalleArqueoCredito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
    }
}
