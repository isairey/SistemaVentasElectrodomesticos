using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
    public class CConexion
    {
        //=============Atributos======================
        private SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        private DataSet aDatos;
        //=============Metodos========================
        public CConexion()
        {
            //Iniciar la conexion
            aDatos = new DataSet();
            aAdaptador = new SqlDataAdapter();
            //Realizar la conexion
            string CadenaConexion = "Data Source= DESKTOP-MAPN2EN\\SQLEXPRESS;Initial Catalog=BDSistemaVentas;Integrated Security=SSPI;";
            aConexion = new SqlConnection(CadenaConexion);
        }
        //-------Propiedades-----------------
        public SqlDataAdapter Adaptador
        {
            get { return aAdaptador; }
        }
        public SqlConnection Conexion
        {
            get { return aConexion; }
        }
        public DataSet Datos
        {
            get { return aDatos; }
        }
        //--------------------Servicios-----------------------
        //------------Metodos para ejecutar comandos sql server----
        //---------Devuelve el resultado en la tabla cero del dataset---
        public virtual DataSet EjecutarSelect(string pConsulta)
        {
            //Metodo para ejecutar consultas del tipo Select
            aAdaptador.SelectCommand = new SqlCommand(pConsulta, aConexion);
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }
        //-------------------------------------------------------------
        //---Metodo para jecutar instrucciones DMl, No retorna resultado----
        public virtual void EjecutarComando(string pComando)
        {
            ///metodo para ejecutar consultas del tipo isert,update,delete
            SqlCommand oComando = new SqlCommand(pComando, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
    }
}
