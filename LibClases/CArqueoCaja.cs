using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class CArqueoCaja : CEntidad
    {
        //===============ATRIBUTOS ====================
        //---   Todos heredados de CEntidad        ----
        //=============================================
        //--------constructores -----------------------
        public CArqueoCaja() : base("TArqueoCaja")
        {
        }
        //-------Implementacion de Metodos Abstractos--
        public override string[] NombresAtributos()
        {
            return new string[] { "NroArqueoCaja", "Fecha", "TotalSolesInicio", "TotalSolesFinal", "CodUsuario" };
        }
        public override int NroDeClaves()
        {
            return 1;///Falta mejores 
        }
        public string UltimoArqueoCaja()
        {
            CConexion C = new CConexion();
            string Consulta = "exec spu_UltimoArqueoDeCaja";
            C.EjecutarSelect(Consulta);
            return C.Datos.Tables[0].Rows[0]["Nro"].ToString();

        }
    }
    }
