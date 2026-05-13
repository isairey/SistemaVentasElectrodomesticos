using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CUsuario:CEntidad
    {
        //===============ATRIBUTOS ====================
        //---   Todos heredados de CEntidad        ----
        //=============================================
        //--------constructores -----------------------
        public CUsuario() : base("TUsuario")
        {
        }
        //-------Implementacion de Metodos Abstractos--
        public override string[] NombresAtributos()
        {
            return new string[] { "CodUsuario", "Contraseña", "DNI", "Nombre", "Edad", "Telefono", "Tipo","Estado" };
        }
        public override int NroDeClaves()
        {
            return 1;///Falta mejores 
        }
    }
}
