using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CDetalleVentaCredito:CEntidad
    {
        //===============ATRIBUTOS ====================
        //---   Todos heredados de CEntidad        ----
        //=============================================
        //--------constructores -----------------------
        public CDetalleVentaCredito() : base("TDetalleVentaCredito")
        {
        }
        //-------Implementacion de Metodos Abstractos--
        public override string[] NombresAtributos()
        {
            return new string[] { "NroDocVentaCredito", "CuotaActual", "Fecha", "CodUsuario", "MontoPagado"};
        }
        public override int NroDeClaves()
        {
            return 1;///Falta mejores 
        }

        public object ListarPorCodigo(string nroDocVenta)
        {
            throw new NotImplementedException();
        }
    }
}
