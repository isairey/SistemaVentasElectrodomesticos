using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    class CProveedor:CEntidad
    {
        //===============ATRIBUTOS ====================
        //---   Todos heredados de CEntidad        ----
        //=============================================
        //--------constructores -----------------------
        public CProveedor() : base("TProveedor")
        {
        }
        //-------Implementacion de Metodos Abstractos--
        public override string[] NombresAtributos()
        {
            return new string[] { "CodProveedor", "RazonSocial", "Direccion", "RUC", "Telefono" };
        }
        public override int NroDeClaves()
        {
            return 1;///Falta mejores 
        }
    }
}
