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

namespace AppSistemaVentas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.ShowDialog();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            FrmProductos Productitos = new FrmProductos();
            Productitos.ShowDialog();
        }

        private void BtnDocVenta_Click(object sender, EventArgs e)
        {
            FrmDocVenta Ventitas = new FrmDocVenta();
            Ventitas.ShowDialog();
        }

        private void BtnCredito_Click(object sender, EventArgs e)
        {
            FrmPagoLetras Letritas = new FrmPagoLetras();
            Letritas.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario Usuario = new FrmUsuario();
            Usuario.ShowDialog();
        }
    }
}
