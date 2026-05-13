namespace LibFormularios
{
    partial class FrmDocPadre
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
            this.components = new System.ComponentModel.Container();
            this.PanDetalleProductos = new System.Windows.Forms.Panel();
            this.PanProductos = new System.Windows.Forms.Panel();
            this.PanCliente = new System.Windows.Forms.Panel();
            this.PanDetalleDoc = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GroupTipo = new System.Windows.Forms.GroupBox();
            this.RdbFactura = new System.Windows.Forms.RadioButton();
            this.RdbBoleta = new System.Windows.Forms.RadioButton();
            this.BtnBuscarDoc = new System.Windows.Forms.Button();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNroDoc = new System.Windows.Forms.TextBox();
            this.PanBotones = new System.Windows.Forms.Panel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtIGV = new System.Windows.Forms.TextBox();
            this.LblIGV = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtTotalLetra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanDetalleDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GroupTipo.SuspendLayout();
            this.PanBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanDetalleProductos
            // 
            this.PanDetalleProductos.Location = new System.Drawing.Point(5, 477);
            this.PanDetalleProductos.Name = "PanDetalleProductos";
            this.PanDetalleProductos.Size = new System.Drawing.Size(680, 164);
            this.PanDetalleProductos.TabIndex = 7;
            // 
            // PanProductos
            // 
            this.PanProductos.Location = new System.Drawing.Point(4, 319);
            this.PanProductos.Name = "PanProductos";
            this.PanProductos.Size = new System.Drawing.Size(681, 156);
            this.PanProductos.TabIndex = 6;
            // 
            // PanCliente
            // 
            this.PanCliente.Location = new System.Drawing.Point(4, 156);
            this.PanCliente.Name = "PanCliente";
            this.PanCliente.Size = new System.Drawing.Size(681, 157);
            this.PanCliente.TabIndex = 5;
            // 
            // PanDetalleDoc
            // 
            this.PanDetalleDoc.Controls.Add(this.pictureBox1);
            this.PanDetalleDoc.Controls.Add(this.BtnNuevo);
            this.PanDetalleDoc.Controls.Add(this.GroupTipo);
            this.PanDetalleDoc.Controls.Add(this.BtnBuscarDoc);
            this.PanDetalleDoc.Controls.Add(this.TxtFecha);
            this.PanDetalleDoc.Controls.Add(this.label2);
            this.PanDetalleDoc.Controls.Add(this.label1);
            this.PanDetalleDoc.Controls.Add(this.TxtNroDoc);
            this.PanDetalleDoc.Location = new System.Drawing.Point(4, 1);
            this.PanDetalleDoc.Name = "PanDetalleDoc";
            this.PanDetalleDoc.Size = new System.Drawing.Size(681, 152);
            this.PanDetalleDoc.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Enabled = false;
            this.BtnNuevo.Location = new System.Drawing.Point(578, 51);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(93, 32);
            this.BtnNuevo.TabIndex = 26;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // GroupTipo
            // 
            this.GroupTipo.Controls.Add(this.RdbFactura);
            this.GroupTipo.Controls.Add(this.RdbBoleta);
            this.GroupTipo.Location = new System.Drawing.Point(327, 89);
            this.GroupTipo.Name = "GroupTipo";
            this.GroupTipo.Size = new System.Drawing.Size(233, 39);
            this.GroupTipo.TabIndex = 25;
            this.GroupTipo.TabStop = false;
            this.GroupTipo.Text = "Tipo";
            // 
            // RdbFactura
            // 
            this.RdbFactura.AutoSize = true;
            this.RdbFactura.Location = new System.Drawing.Point(134, 16);
            this.RdbFactura.Name = "RdbFactura";
            this.RdbFactura.Size = new System.Drawing.Size(61, 17);
            this.RdbFactura.TabIndex = 1;
            this.RdbFactura.TabStop = true;
            this.RdbFactura.Text = "Factura";
            this.RdbFactura.UseVisualStyleBackColor = true;
            // 
            // RdbBoleta
            // 
            this.RdbBoleta.AutoSize = true;
            this.RdbBoleta.Checked = true;
            this.RdbBoleta.Location = new System.Drawing.Point(17, 16);
            this.RdbBoleta.Name = "RdbBoleta";
            this.RdbBoleta.Size = new System.Drawing.Size(55, 17);
            this.RdbBoleta.TabIndex = 0;
            this.RdbBoleta.TabStop = true;
            this.RdbBoleta.Text = "Boleta";
            this.RdbBoleta.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarDoc
            // 
            this.BtnBuscarDoc.Location = new System.Drawing.Point(578, 8);
            this.BtnBuscarDoc.Name = "BtnBuscarDoc";
            this.BtnBuscarDoc.Size = new System.Drawing.Size(93, 37);
            this.BtnBuscarDoc.TabIndex = 23;
            this.BtnBuscarDoc.Text = "Ir a Doc ";
            this.BtnBuscarDoc.UseVisualStyleBackColor = true;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Enabled = false;
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(368, 53);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(203, 30);
            this.TxtFecha.TabIndex = 22;
            this.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nro: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fecha:";
            // 
            // TxtNroDoc
            // 
            this.TxtNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroDoc.Location = new System.Drawing.Point(368, 8);
            this.TxtNroDoc.Name = "TxtNroDoc";
            this.TxtNroDoc.Size = new System.Drawing.Size(203, 38);
            this.TxtNroDoc.TabIndex = 24;
            this.TxtNroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PanBotones
            // 
            this.PanBotones.Controls.Add(this.BtnGuardar);
            this.PanBotones.Controls.Add(this.TxtTotal);
            this.PanBotones.Controls.Add(this.label18);
            this.PanBotones.Controls.Add(this.TxtIGV);
            this.PanBotones.Controls.Add(this.LblIGV);
            this.PanBotones.Controls.Add(this.TxtSubTotal);
            this.PanBotones.Controls.Add(this.label16);
            this.PanBotones.Controls.Add(this.label15);
            this.PanBotones.Controls.Add(this.TxtTotalLetra);
            this.PanBotones.Controls.Add(this.label14);
            this.PanBotones.Location = new System.Drawing.Point(4, 647);
            this.PanBotones.Name = "PanBotones";
            this.PanBotones.Size = new System.Drawing.Size(679, 85);
            this.PanBotones.TabIndex = 8;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardar.Location = new System.Drawing.Point(126, 32);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(162, 49);
            this.BtnGuardar.TabIndex = 13;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(550, 55);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(94, 20);
            this.TxtTotal.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(478, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Total :";
            // 
            // TxtIGV
            // 
            this.TxtIGV.Enabled = false;
            this.TxtIGV.Location = new System.Drawing.Point(550, 29);
            this.TxtIGV.Name = "TxtIGV";
            this.TxtIGV.Size = new System.Drawing.Size(94, 20);
            this.TxtIGV.TabIndex = 17;
            // 
            // LblIGV
            // 
            this.LblIGV.AutoSize = true;
            this.LblIGV.Location = new System.Drawing.Point(478, 32);
            this.LblIGV.Name = "LblIGV";
            this.LblIGV.Size = new System.Drawing.Size(31, 13);
            this.LblIGV.TabIndex = 16;
            this.LblIGV.Text = "IGV :";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Enabled = false;
            this.TxtSubTotal.Location = new System.Drawing.Point(550, 3);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(94, 20);
            this.TxtSubTotal.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(478, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "SubTotal :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(385, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Soles";
            // 
            // TxtTotalLetra
            // 
            this.TxtTotalLetra.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTotalLetra.Enabled = false;
            this.TxtTotalLetra.Location = new System.Drawing.Point(72, 6);
            this.TxtTotalLetra.Name = "TxtTotalLetra";
            this.TxtTotalLetra.Size = new System.Drawing.Size(307, 20);
            this.TxtTotalLetra.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Son :";
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmDocPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 735);
            this.Controls.Add(this.PanBotones);
            this.Controls.Add(this.PanDetalleProductos);
            this.Controls.Add(this.PanProductos);
            this.Controls.Add(this.PanCliente);
            this.Controls.Add(this.PanDetalleDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDocPadre";
            this.Text = "FrmDocPadre";
            this.PanDetalleDoc.ResumeLayout(false);
            this.PanDetalleDoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GroupTipo.ResumeLayout(false);
            this.GroupTipo.PerformLayout();
            this.PanBotones.ResumeLayout(false);
            this.PanBotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel PanDetalleProductos;
        protected System.Windows.Forms.Panel PanProductos;
        protected System.Windows.Forms.Panel PanCliente;
        protected System.Windows.Forms.Panel PanDetalleDoc;
        protected System.Windows.Forms.Button BtnNuevo;
        protected System.Windows.Forms.Button BtnBuscarDoc;
        protected System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox TxtNroDoc;
        protected System.Windows.Forms.Panel PanBotones;
        protected System.Windows.Forms.Button BtnGuardar;
        protected System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label18;
        protected System.Windows.Forms.TextBox TxtIGV;
        protected System.Windows.Forms.TextBox TxtSubTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        protected System.Windows.Forms.TextBox TxtTotalLetra;
        private System.Windows.Forms.Label label14;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.GroupBox GroupTipo;
        protected System.Windows.Forms.RadioButton RdbFactura;
        protected System.Windows.Forms.RadioButton RdbBoleta;
        protected System.Windows.Forms.Timer Timer1;
        protected System.Windows.Forms.Label LblIGV;
    }
}