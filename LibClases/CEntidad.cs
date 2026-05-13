using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
    public abstract class CEntidad
    {
        //==================Atributos=========================
        private CConexion aConexion;
        private string aNombreTabla;
        string[] aNombres = null;//----------Nombres de los campos de la tabla
        string[] aValores = null;//----------Valores de los valores de la tabla
        private bool aNuevo;
        private int NroClaves;
        //==================Metodos===========================
        //-----------------Constructores------------------------------
        public CEntidad(string pNombreTabla)
        {
            //inicializar los atributos
            aNuevo = true;
            aNombreTabla = pNombreTabla;
            aConexion = new CConexion();
            aNombres = NombresAtributos();
            aValores = null;
            NroClaves = NroDeClaves();
        }
        //------------------Propiedades-----------------------------
        public bool Nuevo
        {
            get { return aNuevo; }
            set { aNuevo = false; }
        }
        //-----------Metodos de soporte de BD------------------------
        //-----------------------------------------------------------
        // --Metodo abstracto encargado de establecer los nombres de 
        //----de los campos (atributos) de la tabla. Se deben implementar
        // --necesariamente en lso herederos como arreglos de cadenas.
        //--Estos atributos deben concidir con los existentes en la base de datos
        public abstract string[] NombresAtributos();
        //Metodo abstracto para establecer el Nro de claves de una determinada tabla
        public abstract int NroDeClaves();
        //--------------------------------------------------------------------
        //------Metodos para el mantenimiento de la tabla
        //--------------------------------------------------------------------

        //-----------------Insercion de nuevos registros----------------------
        public virtual void Insertar(params string[] Atributos)
        {
            /*//-----Permite insertar informacion de un registro en la tabla 
            //-----Recuperar los valores de los atributos
            aValores = Atributos;
            //-----Formar la cadena de inserccion---------------
            string CadenaInsertar = "insert into " + aNombreTabla + "values ('";
            for (int k = 0; k < aValores.Length; k++)
            {
                //-----Incluir los atributos en la consulta 
                CadenaInsertar += aValores[k];
                if (k == aValores.Length - 1)
                    //------se concateno el ultimo atributo.Terminar la consulta
                    CadenaInsertar += "')";
                else
                    //------dejar la consulta lista para el siguiente atributo
                    CadenaInsertar += "','";
            }
            //Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(CadenaInsertar);
            aNuevo = false;*/
            aValores = Atributos;
            string CadenaInsertar = "exec spu_" + aNombreTabla + "_Insertar '";
            for (int k = 0; k < aValores.Length; k++)
            {
                //-----Incluir los atributos en la consulta 
                CadenaInsertar += aValores[k];
                if (k == aValores.Length - 1)
                    //------se concateno el ultimo atributo.Terminar la consulta
                    CadenaInsertar += "'";
                else
                    //------dejar la consulta lista para el siguiente atributo
                    CadenaInsertar += "', '";
            }
            aConexion.EjecutarSelect(CadenaInsertar);
            if (ValorAtributo("CodError") == "0")
            {
                aNuevo = true;
            }
        }
        //-----------------Actualizacion de Registros--------------
        public void Actualizar(params string[] Atributos)
        {
            /*//-----Permite insertar informacion de un registro en la tabla 

            //-----Recuperar los valores de los atributos
            aNombres = NombresAtributos();
            aValores = Atributos;

            //-----Formar la cadena de inserccion---------------
            string CadenaActualizar = "update " + aNombreTabla + " set ";
            for (int k = NroClaves; k < aValores.Length; k++)
            {
                //-----Incluir los atributos en la consulta 
                CadenaActualizar += aNombres[k] + "= '" + aValores[k];
                if (k == aValores.Length - 1)
                    //------se concateno el ultimo atributo.Terminar la consulta
                    CadenaActualizar += "'";
                else
                    //------dejar la consulta lista para el siguiente atributo
                    CadenaActualizar += "', ";
            }
            //-------------Agregar a la consulta la clausula WHERE
            CadenaActualizar += " where ";
            for (int i = 0; i < NroClaves; i++)
            {
                if (i == NroClaves - 1)
                    //----se concateno la ultima clave.Terminar consulta
                    CadenaActualizar += aNombres[i] + "= '" + aValores[i] + "'";
                else
                    //--------Dejar la consulta lista para el siguiente atributo
                    CadenaActualizar += aNombres[i] + "= '" + aValores[i] + "' and ";
            }
            //Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(CadenaActualizar);*/
            aNombres = NombresAtributos();
            aValores = Atributos;

            //-----Formar la cadena de inserccion---------------
            string CadenaActualizar = "exec spu_" + aNombreTabla + "_Actualizar '";
            for (int k = 0; k < aValores.Length; k++)
            {
                //-----Incluir los atributos en la consulta 
                CadenaActualizar += aValores[k];
                if (k == aValores.Length - 1)
                    //------se concateno el ultimo atributo.Terminar la consulta
                    CadenaActualizar += "'";
                else
                    //------dejar la consulta lista para el siguiente atributo
                    CadenaActualizar += "','";
            }
            aConexion.EjecutarSelect(CadenaActualizar);
            if (ValorAtributo("CodError") == "0")
            {
                aNuevo = false;
            }
        }
        public void Eliminar(params string[] Atributos)
        {
            /* //-----Permite eliminar informacion de un registro en la tabla 
             //-----Recuperar los valores de los atributos
             aValores = Atributos;
             aNombres = NombresAtributos();
             //-----Formar la cadena de inserccion---------------
             string CadenaEliminar = "delete from " + aNombreTabla;
             //-----------Agregar a la consulta la clausula where 
             CadenaEliminar += " where ";
             for (int i = 0; i < NroClaves; i++)
             {
                 if (i == NroClaves - 1)
                     //----se concateno la ultima clave.Terminar consulta
                     CadenaEliminar += aNombres[i] + "= '" + aValores[i] + "'";
                 else
                     //--------Dejar la consulta lista para el siguiente atributo
                     CadenaEliminar += aNombres[i] + "= '" + aValores[i] + "' and ";
             }
             //Ejecutar la consulta para eliminar el registro
             aConexion.EjecutarComando(CadenaEliminar);
             aNuevo = false;*/
            aValores = Atributos;
            aNombres = NombresAtributos();
            //-----Formar la cadena de inserccion---------------
            string CadenaEliminar = "exec spu_" + aNombreTabla + "_Eliminar '";
            for (int k = 0; k < NroClaves; k++)
            {
                //-----Incluir los atributos en la consulta 
                CadenaEliminar += aValores[k];
                if (k == NroClaves - 1)
                    //------se concateno el ultimo atributo.Terminar la consulta
                    CadenaEliminar += "'";
                else
                    //------dejar la consulta lista para el siguiente atributo
                    CadenaEliminar += "','";
            }
            aConexion.EjecutarSelect(CadenaEliminar);
            if (ValorAtributo("CodError") == "0")
            {
                aNuevo = false;
            }
        }
        public bool ExisteClavePrimaria(params string[] Atributos)
        {
            //Verificar si un registro existe
            //----Recuperar los nombres y valores de los atributos de la tabla
            aNombres = NombresAtributos();
            aValores = Atributos;
            ///Formar la consulta
            string CadenaConsulta = "Select * from " + aNombreTabla + " where " + aNombres[0] + "='" + aValores[0] + "'";
            //Ejecutar la consulta
            aConexion.EjecutarSelect(CadenaConsulta);
            //si existen registros en la tabla 0 del dataset,lacalve primaria existe
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }
        public DataTable Registro(params string[] Atributos)
        {
            //Recupera la informacion de un registro
            //------Recuperar los nombres y valores de los atributos de la tabla
            aNombres = NombresAtributos();
            aValores = Atributos;
            //Formar la consulta
            string CadenaConsulta = "select * from " + aNombreTabla + " where " + aNombres[0] + "='" + aValores[0] + "'";
            //ejacutra la cadena de conexion y devolver el resultado
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }
        //------------------------------------------------
        public string ValorAtributo(string pNombreCampo)
        {
            //--Recuopara el valor de un atributo del datset
            return aConexion.Datos.Tables[0].Rows[0][pNombreCampo].ToString();
        }
        public DataTable ListaGeneral()
        {
            //-- Retorna una tabla con la lsita completam de libros
            //string Consulta = "select * from " + aNombreTabla;
            string Consulta = "exec spu" + aNombreTabla + "_ListaGeneral";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        public bool Login(string Codigo, string Contraseña)
        {
            string Consulta = "exec spuLogin '" + Codigo + "','" + Contraseña + "'";
            aConexion.EjecutarSelect(Consulta);
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }
        public DataTable CargarArqueoCajaContado(string CodUsuario)
        {
            //-- Retorna una tabla con la lsita completam de libros
            //string Consulta = "select * from " + aNombreTabla;
            string Consulta = "exec spu_CargarDatosContadoArqueoCaja " + "'" + CodUsuario + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable CargarArqueoCajaCredito(string CodUsuario)
        {
            //-- Retorna una tabla con la lsita completam de libros
            //string Consulta = "select * from " + aNombreTabla;
            string Consulta = "exec spu_CargarDatosCreditoArqueoCaja " + "'" + CodUsuario + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        public bool VerificarSiHizoDocVenta(string CodUsuario)
        {
            //-- Retorna una tabla con la lsita completam de libros
            //string Consulta = "select * from " + aNombreTabla;
            string Consulta = "exec spu_CargarDatosContadoArqueoCaja " + "'" + CodUsuario + "'";
            aConexion.EjecutarSelect(Consulta);
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }
        public bool VerificarSiHizoDocVentaCredito(string CodUsuario)
        {
            //-- Retorna una tabla con la lsita completam de libros
            //string Consulta = "select * from " + aNombreTabla;
            string Consulta = "exec spu_CargarDatosCreditoArqueoCaja " + "'" + CodUsuario + "'";
            aConexion.EjecutarSelect(Consulta);
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }
        public bool VerificarSiHizoArqueo(string CodUsuario)
        {
            //-- Retorna una tabla con la lsita completam de libros
            //string Consulta = "select * from " + aNombreTabla;
            string Consulta = "exec spu_VerificarArqueoCaja " + "'" + CodUsuario + "'";
            aConexion.EjecutarSelect(Consulta);
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }
        public DataTable CargarArqueoCajaNroArqueo(string NroArqueo, string CodUsuario)
        {
            //-- Retorna una tabla con la lsita completam de libros
            //string Consulta = "select * from " + aNombreTabla;
            string Consulta = "exec spu_IrCargarDatosContadoArqueoCaja " + "'" + NroArqueo + "'," + "'" + CodUsuario +"'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable CargarArqueoCajaContadoNroArqueo(string Fecha, string CodUsuario)
        {
            //-- Retorna una tabla con la lsita completam de libros
            //string Consulta = "select * from " + aNombreTabla;
            string Consulta = "exec spu_RecuperarCargarDatosContadoArqueoCaja " + "'" + Fecha + "'," + "'" + CodUsuario + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
        public DataTable CargarArqueoCajaCreditoNroArqueo(string Fecha, string CodUsuario)
        {
            //-- Retorna una tabla con la lsita completam de libros
            //string Consulta = "select * from " + aNombreTabla;
            string Consulta = "exec spu_RecuperarCargarDatosCreditoArqueoCaja " + "'" + Fecha + "'," + "'" + CodUsuario + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
