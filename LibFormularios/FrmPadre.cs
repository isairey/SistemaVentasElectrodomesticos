using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClases;
namespace LibFormularios
{
    public partial class FrmPadre : Form
    {
        //===================Atributos=========================
        protected CEntidad aEntidad;
        //===================Metodos========================
        //-------------------Constructor--------------------
        public FrmPadre()
        {
            InitializeComponent();
        }
        //------------------Metodos base---------------------
        /// <summary>
        /// Metodo VIRTUAL que permite indicar que valores del fromulario
        /// deben ir a la tabla relacionada. Los valores deben ser definidos
        /// en el mismo orden en que estan considerador en la base de datos
        /// Es obligatorio redefinir este metodo en todos los herederos de FrmPadre.
        /// </summary>
        /// <returns>Arreglo de Strings con los valores qeu deben ir a la tabla</returns>
        public virtual string[] AsignarValoresAtributos()
        {
            return null;
        }
        //------------------------------------------------
        public void IniciarEntidad(CEntidad pEntidad)
        {
            //-----Indicar con que entidad trabajara el formulario
            aEntidad = pEntidad;
        }
        //-------------------------------------------------
        public virtual void InicializarAtributoClave()
        {   //--Dar valores a los controles relacionados al atributo clave
        }
        //-------------------------------------------------
        public virtual void InicializarAtributosNoClave()
        {   //--Dar valores a los controles relacioados a los tributos no clave
        }
        //-----------------------------------------------------
        public virtual void InicializarAtributos()
        {   //--Dar valor inicial a todos los atributos del formulario
            InicializarAtributoClave();
            InicializarAtributosNoClave();
        }
        //------------------------------------------------------
        public virtual void MostrarDatos()
        {   //----Visualiza la informacion de un registro en el formulario
        }
        public virtual void ListaRegistros()
        {   //----Lista todos los registros de la tbala relacionada
        }
        //--------------------------------------------------------
        public virtual bool EsRegistroValido()
        {   //---Verifica que los datos esten completos en el formulario
            return true;
        }
        //---------------------------------------------------------
        public virtual void ProcesarClave()
        {
            //-----Recuperar atributos,el primer atributo es clave 
            string[] Atributos = AsignarValoresAtributos();
            //-----Verificar si existe clave primaria 
            if (aEntidad.ExisteClavePrimaria(Atributos))
            {   //--------Registro existente,Recuperar Atributos y mostrarlos
                MostrarDatos();
                aEntidad.Nuevo = false;
            }
            else
            {   //----Registro nuevo, inicializar atributos no clave
                InicializarAtributosNoClave();
            }
        }
        public virtual void Grabar()
        {
            try
            {
                if (EsRegistroValido())
                {   //-----Recuperar atributos,el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    //----Verificar si existe clave primaria
                    if (aEntidad.ExisteClavePrimaria(Atributos))
                    {
                        aEntidad.Actualizar(Atributos);
                    }
                    else
                    {
                        aEntidad.Insertar(Atributos);
                        if (aEntidad.ValorAtributo("CodError") == "0")
                        {
                            //---Inicializar el formulario
                            MessageBox.Show(aEntidad.ValorAtributo("Mensaje"), "CONFIRMACION");
                        }
                        else
                            MessageBox.Show(aEntidad.ValorAtributo("Mensaje"), "ERROR");
                    }


                    InicializarAtributos();
                    ListaRegistros();
                }
                else MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO", "ALERTA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }
        public virtual void Borrar()
        {
            try
            {
                if (EsRegistroValido())
                {   //-----Recuperar atributos,el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    aEntidad.Eliminar(Atributos);
                    //---Inicializar el formulario
                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE", "CONFIRMACION");
                    InicializarAtributos();
                    ListaRegistros();
                }
                else MessageBox.Show("DEBE COMPLETAR EL LLENADO DEL FORMULARIO", "ALERTA");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR AL REALIZAR LA OPERACION");
            }
        }
        //-----------------------EVENTOS--------------------
        private void BtnGuardar_Click(object sender, System.EventArgs e)
        {
            Grabar();
        }
        //-------------------------------------------------
        /*private void BtnSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }*/
        //-------------------------------------------------
        private void BtnNuevo_Click(object sender, System.EventArgs e)
        {
            InicializarAtributos();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Borrar();
        }
    }
}
