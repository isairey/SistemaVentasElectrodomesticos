namespace LibFormularios
{
    partial class FrmReportes
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
            this.CboReportes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvReportes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // CboReportes
            // 
            this.CboReportes.FormattingEnabled = true;
            this.CboReportes.Items.AddRange(new object[] {
            "Productos Mas Vendidos",
            "Productos Menos Vendidos",
            "Productos Sin Stock",
            "Dias Mas Vendidos",
            "Clientes Estrella",
            "",
            ""});
            this.CboReportes.Location = new System.Drawing.Point(115, 12);
            this.CboReportes.Name = "CboReportes";
            this.CboReportes.Size = new System.Drawing.Size(395, 21);
            this.CboReportes.TabIndex = 0;
            this.CboReportes.SelectedIndexChanged += new System.EventHandler(this.CboReportes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Reporte:";
            // 
            // DgvReportes
            // 
            this.DgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReportes.Location = new System.Drawing.Point(13, 77);
            this.DgvReportes.Name = "DgvReportes";
            this.DgvReportes.Size = new System.Drawing.Size(525, 313);
            this.DgvReportes.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reporte:";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvReportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.DgvReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboReportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvReportes;
        private System.Windows.Forms.Label label2;
    }
}