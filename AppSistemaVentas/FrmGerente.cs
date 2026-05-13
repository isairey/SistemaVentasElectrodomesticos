using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFormularios;
using System.Runtime.InteropServices;
namespace AppSistemaVentas
{
    public partial class FrmGerente : Form
    {
        public FrmGerente(string CodUsuario, string Usuario)
        {
            InitializeComponent();
            lblCodigo.Text = CodUsuario;
            lblNombre.Text = Usuario;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FrmProductos());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FrmCliente());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FrmReportes());
        }

        private void btnPagoLetras_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FrmPagoLetras());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Abrir_Formulario_En_Panel(new FrmUsuario());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pMenuVertical.Width == 250) pMenuVertical.Width = 60;
            else pMenuVertical.Width = 250;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
            else this.WindowState = FormWindowState.Maximized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin L = new FormLogin();
            L.ShowDialog();
        }
        private void Abrir_Formulario_En_Panel(object formhijo)
        {
            if (this.pContendor.Controls.Count > 0)
            {
                this.pContendor.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContendor.Controls.Add(fh);
            this.pContendor.Tag = fh;
            fh.Show();
        }

        private void pMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin L = new FormLogin();
            L.ShowDialog();
        }
    }
}
