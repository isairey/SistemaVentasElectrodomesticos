using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClases;
namespace LibFormularios
{
    public partial class FrmReportes : Form
    {
        CDocVenta aDocVenta = new CDocVenta();
        CDetalleVenta aDetalleVenta = new CDetalleVenta();
        CProducto aProducto = new CProducto();
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void CboReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CboReportes.SelectedIndex)
            {
                case 1:
                    DgvReportes.DataSource = aDetalleVenta.ProductosMasVendidos();
                    break;
                case 2:
                    DgvReportes.DataSource = aDetalleVenta.ProductosMenosVendidos();
                    break;
                case 3:
                    DgvReportes.DataSource = aProducto.ProductosSinStock(); ;
                    break;
                case 4:
                    DgvReportes.DataSource = aDocVenta.DiasMasVendidos();
                    break;
                case 5:
                    DgvReportes.DataSource = aDocVenta.ClientesEstrella();
                    break;
            }
        }
    }
}
