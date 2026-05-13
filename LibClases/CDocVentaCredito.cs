using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CDocVentaCredito:CEntidad
    {
        //===============ATRIBUTOS ====================
        //---   Todos heredados de CEntidad        ----
        //=============================================
        //--------constructores -----------------------
        public CDocVentaCredito() : base("TDocVentaCredito")
        {
        }
        //-------Implementacion de Metodos Abstractos--
        public override string[] NombresAtributos()
        {
            return new string[] { "NroDocVentaCredito", "NroDocVenta", "NroCuotas", "FechaPago", "Observaciones","Estado" };
        }
        public override int NroDeClaves()
        {
            return 1;///Falta mejores 
        }

        public string UltimoNroDocCredito()
        {
            CConexion C = new CConexion();
            string Consulta = "exec spu_UltimoNroDocVentaCredito";
            C.EjecutarSelect(Consulta);
            return C.Datos.Tables[0].Rows[0]["Nro"].ToString();
        }
    }
}
