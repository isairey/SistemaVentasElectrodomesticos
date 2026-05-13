namespace AppSistemaVentas
{
    partial class FrmVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendedor));
            this.pMenuVertical = new System.Windows.Forms.Panel();
            this.btnCerrarSes = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pContendor = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pContendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenuVertical
            // 
            this.pMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.pMenuVertical.Controls.Add(this.btnCerrarSes);
            this.pMenuVertical.Controls.Add(this.lblNombre);
            this.pMenuVertical.Controls.Add(this.pictureBox4);
            this.pMenuVertical.Controls.Add(this.lblCodigo);
            this.pMenuVertical.Controls.Add(this.button1);
            this.pMenuVertical.Controls.Add(this.btnFactura);
            this.pMenuVertical.Controls.Add(this.pictureBox2);
            this.pMenuVertical.Controls.Add(this.btnProductos);
            this.pMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.pMenuVertical.Name = "pMenuVertical";
            this.pMenuVertical.Size = new System.Drawing.Size(250, 450);
            this.pMenuVertical.TabIndex = 5;
            // 
            // btnCerrarSes
            // 
            this.btnCerrarSes.Location = new System.Drawing.Point(71, 229);
            this.btnCerrarSes.Name = "btnCerrarSes";
            this.btnCerrarSes.Size = new System.Drawing.Size(103, 23);
            this.btnCerrarSes.TabIndex = 14;
            this.btnCerrarSes.Text = "CERRAR SESIÓN";
            this.btnCerrarSes.UseVisualStyleBackColor = true;
            this.btnCerrarSes.Click += new System.EventHandler(this.btnCerrarSes_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(81, 195);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 19);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::AppSistemaVentas.Properties.Resources.PGUsuario;
            this.pictureBox4.Location = new System.Drawing.Point(71, 62);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 102);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(87, 167);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 19);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Codigo";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::AppSistemaVentas.Properties.Resources.caja;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "ARQUEO DE CAJA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.White;
            this.btnFactura.Image = global::AppSistemaVentas.Properties.Resources.venta;
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Location = new System.Drawing.Point(0, 312);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(250, 45);
            this.btnFactura.TabIndex = 11;
            this.btnFactura.Text = "FACTURA";
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppSistemaVentas.Properties.Resources.onlinelogomaker_112718_2148_7054;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(-15, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnProductos
            // 
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = global::AppSistemaVentas.Properties.Resources.producto;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 261);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(250, 45);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.DarkGray;
            this.pMenu.Controls.Add(this.label1);
            this.pMenu.Controls.Add(this.btnMinimizar);
            this.pMenu.Controls.Add(this.btnMaximizar);
            this.pMenu.Controls.Add(this.btnCerrar);
            this.pMenu.Controls.Add(this.pictureBox1);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(250, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(550, 46);
            this.pMenu.TabIndex = 6;
            this.pMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pMenu_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(468, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 16);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(494, 6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(16, 16);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(520, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AppSistemaVentas.Properties.Resources.Mobile_Menu_Icon1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pContendor
            // 
            this.pContendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pContendor.Controls.Add(this.pictureBox3);
            this.pContendor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContendor.Location = new System.Drawing.Point(250, 46);
            this.pContendor.Name = "pContendor";
            this.pContendor.Size = new System.Drawing.Size(550, 404);
            this.pContendor.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AppSistemaVentas.Properties.Resources.onlinelogomaker_112718_2152_0500;
            this.pictureBox3.Location = new System.Drawing.Point(160, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(437, 126);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "VENDEDOR";
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pContendor);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVendedor";
            this.Text = "FrmVendedor";
            this.pMenuVertical.ResumeLayout(false);
            this.pMenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pContendor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenuVertical;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pContendor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCerrarSes;
        private System.Windows.Forms.Label label1;
    }
}