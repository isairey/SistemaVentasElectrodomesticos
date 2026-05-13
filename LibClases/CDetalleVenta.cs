using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CDetalleVenta:CEntidad
    {
        //===============ATRIBUTOS ====================
        //---   Todos heredados de CEntidad        ----
        //=============================================
        //--------constructores -----------------------
        public CDetalleVenta() : base("TDetalleVenta")
        {
        }
        //-------Implementacion de Metodos Abstractos--
        public override string[] NombresAtributos()
        {
            return new string[] { "NroDocVenta", "CodProducto","Serie","Cantidad", "PrecioUnitario" };
        }
        public override int NroDeClaves()
        {
            return 2;///Falta mejores 
        }

        public object ProductosMasVendidos()
        {
            //retorna una tabla con la lista con las unidades de los productos
            CConexion Con = new CConexion();
            string Consulta = "exec spuProductosMasVendidos ";
            Con.EjecutarSelect(Consulta);
            return Con.Datos.Tables[0];
        }

        public object ProductosMenosVendidos()
        {
            //retorna una tabla con la lista con las unidades de los productos
            CConexion Con = new CConexion();
            string Consulta = "exec spuProductosMasVendidos";
            Con.EjecutarSelect(Consulta);
            return Con.Datos.Tables[0];
        }

        public object ListarPorCodigo(string nroDocVenta)
        {
            //retorna una tabla con la lista con las unidades de los productos
            CConexion Con = new CConexion();
            string Consulta = "exec spuTDetalleVenta_ListaPorCodigo '" + nroDocVenta + "'";
            Con.EjecutarSelect(Consulta);
            return Con.Datos.Tables[0];
        }
    }
}
