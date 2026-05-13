using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CDocVenta:CEntidad
    {
        //===============ATRIBUTOS ====================
        //---   Todos heredados de CEntidad        ----
        //=============================================
        //--------constructores -----------------------
        public CDocVenta() : base("TDocVenta")
        {
        }
        //-------Implementacion de Metodos Abstractos--
        public override string[] NombresAtributos()
        {
            return new string[] { "NroDocVenta", "Fecha", "Tipo", "TipoPago", "CodCliente", "CodUsuario" };
        }
        public override int NroDeClaves()
        {
            return 1;///Falta mejores 
        }

        public string UltimoNroDocVenta(string Tipo)
        {
            CConexion C = new CConexion();
            string Consulta = "exec spu_UltimoNroDocVenta '" + Tipo + "'";
            C.EjecutarSelect(Consulta);
            return C.Datos.Tables[0].Rows[0]["Nro"].ToString();
        }

        public object DiasMasVendidos()
        {
            //retorna una tabla con la lista con las unidades de los productos
            CConexion Con = new CConexion();
            string Consulta = "exec spuDiasMasVendidos";
            Con.EjecutarSelect(Consulta);
            return Con.Datos.Tables[0];
        }

        public object ClientesEstrella()
        {
            //retorna una tabla con la lista con las unidades de los productos
            CConexion Con = new CConexion();
            string Consulta = "exec spuClientesEstrella";
            Con.EjecutarSelect(Consulta);
            return Con.Datos.Tables[0];
        }
    }
}
