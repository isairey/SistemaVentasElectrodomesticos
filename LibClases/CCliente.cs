using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CCliente:CEntidad
    {
        //===============ATRIBUTOS ====================
        //---   Todos heredados de CEntidad        ----
        //=============================================
        //--------constructores -----------------------
        public CCliente() : base("TCliente")
        {
        }        
        //-------Implementacion de Metodos Abstractos--
        public override string[] NombresAtributos()
        {
            return new string[] { "CodCliente", "DNI", "Nombre","Direccion","Email","Telefono" };
        }
        public override int NroDeClaves()
        {
            return 1;///Falta mejores 
        }
        public string BuscarDNI(string text)
        {
            //retorna una tabla con la lista con las unidades de los productos
            CConexion Con = new CConexion();
            string Consulta = "exec spu_BuscarDNI '" + text + "'";
            Con.EjecutarSelect(Consulta);
            if (Con.Datos.Tables[0].Rows.Count>0)
                return Con.Datos.Tables[0].Rows[0]["CodCliente"].ToString();
            else return "";
        }

    }
}
