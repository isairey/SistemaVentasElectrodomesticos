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
namespace AppSistemaVentas
{

    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Secion_Click(object sender, EventArgs e)
        {
           CEntidad P=new CProducto() as CEntidad;
            if (P.Login(txtUsuario.Text, txtContraseña.Text))
            {
                this.Hide();    
                string tipo = P.ValorAtributo("Tipo").ToString();
                string Nombre = P.ValorAtributo("Nombre").ToString();
                if (tipo == "ADMINISTRADOR")
                {
                    FrmAdministrador FA = new FrmAdministrador(txtUsuario.Text, Nombre);
                    FA.Size = new System.Drawing.Size(969, 725);
                    FA.ShowDialog();
                }
                else if (tipo == "VENDEDOR")
                {

                    FrmVendedor FV = new FrmVendedor(txtUsuario.Text, Nombre);
                    FV.Size = new System.Drawing.Size(969, 725);
                    FV.ShowDialog();
                    
                }
                else if (tipo == "GERENTE")
                {
                    FrmGerente FG = new FrmGerente(txtUsuario.Text, Nombre);
                    FG.Size = new System.Drawing.Size(969, 725);
                    FG.ShowDialog();
                }
                
            }
            else {
                MessageBox.Show("Ingrese Datos Validos,Error en usuario o contraseña", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Clear();
                txtContraseña.Focus();
            } 

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (!textBox.Text.StartsWith("U")) {
                textBox.Text = "U";
                textBox.Select(textBox.Text.Length, 0);
            }


        }
    }
}
