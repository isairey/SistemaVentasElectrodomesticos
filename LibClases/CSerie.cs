using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CSerie:CEntidad
    {
        //===============ATRIBUTOS ====================
        //---   Todos heredados de CEntidad        ----
        //=============================================
        //--------constructores -----------------------
        public CSerie() : base("TSerieProducto")
        {
        }
        //-------Implementacion de Metodos Abstractos--
        public override string[] NombresAtributos()
        {
            return new string[] {"CodProducto","Serie"};
        }
        public override int NroDeClaves()
        {
            return 2;///Falta mejores 
        }

        public DataTable ListarPorCodigo(string codProducto)
        {
            CConexion Con = new CConexion();
            string Consulta = "select * from TSerieProducto where CodProducto='"+codProducto+"'";
            Con.EjecutarSelect(Consulta);
            return Con.Datos.Tables[0];
        }
    }
}
