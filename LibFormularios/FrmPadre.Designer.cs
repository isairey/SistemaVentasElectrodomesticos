namespace LibFormularios
{
    partial class FrmPadre
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
            this.PanTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanDataView = new System.Windows.Forms.Panel();
            this.PanDatos = new System.Windows.Forms.Panel();
            this.PanBotones = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.PanTitulo.SuspendLayout();
            this.PanBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanTitulo
            // 
            this.PanTitulo.Controls.Add(this.label1);
            this.PanTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanTitulo.Name = "PanTitulo";
            this.PanTitulo.Size = new System.Drawing.Size(703, 57);
            this.PanTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITULO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanDataView
            // 
            this.PanDataView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanDataView.Location = new System.Drawing.Point(0, 337);
            this.PanDataView.Name = "PanDataView";
            this.PanDataView.Size = new System.Drawing.Size(703, 303);
            this.PanDataView.TabIndex = 1;
            // 
            // PanDatos
            // 
            this.PanDatos.Location = new System.Drawing.Point(0, 63);
            this.PanDatos.Name = "PanDatos";
            this.PanDatos.Size = new System.Drawing.Size(703, 177);
            this.PanDatos.TabIndex = 2;
            // 
            // PanBotones
            // 
            this.PanBotones.Controls.Add(this.BtnEliminar);
            this.PanBotones.Controls.Add(this.BtnNuevo);
            this.PanBotones.Controls.Add(this.BtnGuardar);
            this.PanBotones.Location = new System.Drawing.Point(3, 246);
            this.PanBotones.Name = "PanBotones";
            this.PanBotones.Size = new System.Drawing.Size(700, 85);
            this.PanBotones.TabIndex = 3;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(51, 21);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(156, 42);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.BtnNuevo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(269, 21);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(156, 42);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(140)))), ((int)(((byte)(120)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(495, 21);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(156, 42);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 640);
            this.Controls.Add(this.PanBotones);
            this.Controls.Add(this.PanDatos);
            this.Controls.Add(this.PanDataView);
            this.Controls.Add(this.PanTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPadre";
            this.Text = "FrmPadre";
            this.PanTitulo.ResumeLayout(false);
            this.PanBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel PanTitulo;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel PanDataView;
        protected System.Windows.Forms.Panel PanDatos;
        protected System.Windows.Forms.Panel PanBotones;
        protected System.Windows.Forms.Button BtnEliminar;
        protected System.Windows.Forms.Button BtnNuevo;
        protected System.Windows.Forms.Button BtnGuardar;
    }
}