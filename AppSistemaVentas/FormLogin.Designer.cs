namespace AppSistemaVentas
{
    partial class FormLogin
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
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciar_Secion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(335, 128);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(192, 31);
            this.txtContraseña.TabIndex = 15;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(335, 86);
            this.txtUsuario.MaxLength = 5;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(192, 31);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.Text = "U";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Usuario            :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.panel1.Controls.Add(this.pLogo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 54);
            this.panel1.TabIndex = 18;
            // 
            // pLogo
            // 
            this.pLogo.Image = global::AppSistemaVentas.Properties.Resources.onlinelogomaker_112718_2148_7054;
            this.pLogo.Location = new System.Drawing.Point(12, 3);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(167, 50);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLogo.TabIndex = 1;
            this.pLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "INICIAR SESION";
            // 
            // btnIniciar_Secion
            // 
            this.btnIniciar_Secion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.btnIniciar_Secion.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnIniciar_Secion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIniciar_Secion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar_Secion.Location = new System.Drawing.Point(439, 188);
            this.btnIniciar_Secion.Name = "btnIniciar_Secion";
            this.btnIniciar_Secion.Size = new System.Drawing.Size(88, 45);
            this.btnIniciar_Secion.TabIndex = 34;
            this.btnIniciar_Secion.Text = "GO";
            this.btnIniciar_Secion.UseVisualStyleBackColor = false;
            this.btnIniciar_Secion.Click += new System.EventHandler(this.btnIniciar_Secion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(185, 188);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 45);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppSistemaVentas.Properties.Resources.PGUsuario;
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIniciar_Secion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FormLogin";
            this.Text = "REMI 2.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar_Secion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}