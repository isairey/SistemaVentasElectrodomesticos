namespace LibFormularios
{
    partial class FrmProductos
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.TxtCodProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.CboSeries = new System.Windows.Forms.ComboBox();
            this.BtnAgregarSerie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdbSiSerie = new System.Windows.Forms.RadioButton();
            this.RdbNoSerie = new System.Windows.Forms.RadioButton();
            this.PanTitulo.SuspendLayout();
            this.PanDataView.SuspendLayout();
            this.PanDatos.SuspendLayout();
            this.PanBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Text = "REGISTRO DE PRODUCTOS";
            // 
            // PanDataView
            // 
            this.PanDataView.Controls.Add(this.DgvProductos);
            // 
            // PanDatos
            // 
            this.PanDatos.Controls.Add(this.groupBox1);
            this.PanDatos.Controls.Add(this.BtnAgregarSerie);
            this.PanDatos.Controls.Add(this.CboSeries);
            this.PanDatos.Controls.Add(this.label3);
            this.PanDatos.Controls.Add(this.TxtModelo);
            this.PanDatos.Controls.Add(this.TxtMarca);
            this.PanDatos.Controls.Add(this.label2);
            this.PanDatos.Controls.Add(this.TxtPrecio);
            this.PanDatos.Controls.Add(this.TxtDescripcion);
            this.PanDatos.Controls.Add(this.label9);
            this.PanDatos.Controls.Add(this.TxtStock);
            this.PanDatos.Controls.Add(this.TxtProducto);
            this.PanDatos.Controls.Add(this.TxtCodProducto);
            this.PanDatos.Controls.Add(this.label8);
            this.PanDatos.Controls.Add(this.label7);
            this.PanDatos.Controls.Add(this.label6);
            this.PanDatos.Controls.Add(this.label5);
            this.PanDatos.Controls.Add(this.label4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Modelo:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPrecio.Location = new System.Drawing.Point(148, 148);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(230, 20);
            this.TxtPrecio.TabIndex = 73;
            this.TxtPrecio.Leave += new System.EventHandler(this.TxtPrecio_Leave);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(403, 71);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(284, 72);
            this.TxtDescripcion.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Descripcion :";
            // 
            // TxtStock
            // 
            this.TxtStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtStock.Enabled = false;
            this.TxtStock.Location = new System.Drawing.Point(457, 148);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(230, 20);
            this.TxtStock.TabIndex = 72;
            this.TxtStock.Text = "0";
            // 
            // TxtProducto
            // 
            this.TxtProducto.BackColor = System.Drawing.SystemColors.Window;
            this.TxtProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtProducto.Location = new System.Drawing.Point(148, 37);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(230, 20);
            this.TxtProducto.TabIndex = 71;
            // 
            // TxtCodProducto
            // 
            this.TxtCodProducto.BackColor = System.Drawing.Color.SandyBrown;
            this.TxtCodProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodProducto.Location = new System.Drawing.Point(148, 8);
            this.TxtCodProducto.MaxLength = 5;
            this.TxtCodProducto.Name = "TxtCodProducto";
            this.TxtCodProducto.Size = new System.Drawing.Size(230, 20);
            this.TxtCodProducto.TabIndex = 70;
            this.TxtCodProducto.Text = "P";
            this.TxtCodProducto.TextChanged += new System.EventHandler(this.TxtCodProducto_TextChanged);
            this.TxtCodProducto.Leave += new System.EventHandler(this.TxtCodProducto_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Stock: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Precio: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Codigo del Producto: ";
            // 
            // TxtMarca
            // 
            this.TxtMarca.BackColor = System.Drawing.SystemColors.Window;
            this.TxtMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtMarca.Location = new System.Drawing.Point(148, 63);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(230, 20);
            this.TxtMarca.TabIndex = 77;
            // 
            // TxtModelo
            // 
            this.TxtModelo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtModelo.Location = new System.Drawing.Point(148, 93);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(230, 20);
            this.TxtModelo.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Serie:";
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Location = new System.Drawing.Point(12, 3);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.Size = new System.Drawing.Size(682, 290);
            this.DgvProductos.TabIndex = 0;
            // 
            // CboSeries
            // 
            this.CboSeries.FormattingEnabled = true;
            this.CboSeries.Location = new System.Drawing.Point(148, 121);
            this.CboSeries.Name = "CboSeries";
            this.CboSeries.Size = new System.Drawing.Size(133, 21);
            this.CboSeries.TabIndex = 81;
            this.CboSeries.Leave += new System.EventHandler(this.CboSeries_Leave);
            // 
            // BtnAgregarSerie
            // 
            this.BtnAgregarSerie.Location = new System.Drawing.Point(288, 120);
            this.BtnAgregarSerie.Name = "BtnAgregarSerie";
            this.BtnAgregarSerie.Size = new System.Drawing.Size(90, 23);
            this.BtnAgregarSerie.TabIndex = 82;
            this.BtnAgregarSerie.Text = "Agregar Serie";
            this.BtnAgregarSerie.UseVisualStyleBackColor = true;
            this.BtnAgregarSerie.Click += new System.EventHandler(this.BtnAgregarSerie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbSiSerie);
            this.groupBox1.Controls.Add(this.RdbNoSerie);
            this.groupBox1.Location = new System.Drawing.Point(405, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 41);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serie";
            // 
            // RdbSiSerie
            // 
            this.RdbSiSerie.AutoSize = true;
            this.RdbSiSerie.Location = new System.Drawing.Point(83, 18);
            this.RdbSiSerie.Name = "RdbSiSerie";
            this.RdbSiSerie.Size = new System.Drawing.Size(35, 17);
            this.RdbSiSerie.TabIndex = 1;
            this.RdbSiSerie.TabStop = true;
            this.RdbSiSerie.Text = "SI";
            this.RdbSiSerie.UseVisualStyleBackColor = true;
            this.RdbSiSerie.CheckedChanged += new System.EventHandler(this.RdbSiSerie_CheckedChanged);
            // 
            // RdbNoSerie
            // 
            this.RdbNoSerie.AutoSize = true;
            this.RdbNoSerie.Location = new System.Drawing.Point(6, 18);
            this.RdbNoSerie.Name = "RdbNoSerie";
            this.RdbNoSerie.Size = new System.Drawing.Size(41, 17);
            this.RdbNoSerie.TabIndex = 0;
            this.RdbNoSerie.TabStop = true;
            this.RdbNoSerie.Text = "NO";
            this.RdbNoSerie.UseVisualStyleBackColor = true;
            this.RdbNoSerie.CheckedChanged += new System.EventHandler(this.RdbNoSerie_CheckedChanged);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 640);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.PanTitulo.ResumeLayout(false);
            this.PanDataView.ResumeLayout(false);
            this.PanDatos.ResumeLayout(false);
            this.PanDatos.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.TextBox TxtCodProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboSeries;
        private System.Windows.Forms.Button BtnAgregarSerie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbSiSerie;
        private System.Windows.Forms.RadioButton RdbNoSerie;
    }
}