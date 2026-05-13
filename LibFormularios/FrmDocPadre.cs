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
    public partial class FrmDocPadre : Form
    {
        //===================Atributos=========================
        protected CEntidad aEntidad;
        //===================Metodos========================
        //-------------------Constructor--------------------
        public FrmDocPadre()
        {
            InitializeComponent();
            FechaActual();
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
                MessageBox.Show("Error no existe el Documento Venta");
            }
        }
        public virtual void Grabar()
        {

        }
        public virtual void CalcularTotales()
        {

        }
        public virtual void BuscarDoc()
        {

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
        public string ConvertirALetra(string Numero)
        {
            //Verificamos si hay punto decimal
            int Punto = Numero.IndexOf('.');
            int NumeroDeseado = -1;
            int ParteDecimal = -1;
            if (Punto != -1)
            {
                //Debemos convertir numero mas su parte decimal
                int ParteEntera = int.Parse(Numero.Substring(0, Punto));
                ParteDecimal = int.Parse(Numero.Substring(Punto + 1, Numero.Length - (ParteEntera.ToString().Length + 1)));
                NumeroDeseado = ParteEntera;
            }
            else NumeroDeseado = int.Parse(Numero);
            //Procesar con la Parte entera y si es que hubiera la parte Decimal
            //Dividir en unidades,decenas , centenas y millares
            int Millares = NumeroDeseado / 1000;
            int Centenas = (NumeroDeseado % 1000) / 100;
            int Decenas = ((NumeroDeseado % 1000) % 100) / 10;
            int Unidades = ((NumeroDeseado % 1000) % 100) % 10;
            string Resultado = "";
            switch (Millares)
            {
                case 2: Resultado += "Dos"; break;
                case 3: Resultado += "Tres"; break;
                case 4: Resultado += "Cuatro"; break;
                case 5: Resultado += "Cinco"; break;
                case 6: Resultado += "Seis"; break;
                case 7: Resultado += "Siete"; break;
                case 8: Resultado += "Ocho"; break;
                case 9: Resultado += "Nueve"; break;
            }
            if (Millares != 0) Resultado += " Mil ";
            switch (Centenas)
            {
                case 1: Resultado += "Ciento "; break;
                case 2: Resultado += "Dos"; break;
                case 3: Resultado += "Tres"; break;
                case 4: Resultado += "Cuatro"; break;
                case 5: Resultado += "Quinientos "; break;
                case 6: Resultado += "Seis"; break;
                case 7: Resultado += "Sete"; break;
                case 8: Resultado += "Ocho"; break;
                case 9: Resultado += "Nove"; break;
            }
            if (Centenas != 0 && Centenas != 5 && Centenas != 1) Resultado += "cientos ";
            switch (Decenas)
            {
                case 1:
                    if (Unidades != 5 && Unidades != 4 && Unidades != 3 && Unidades != 2 && Unidades != 1)
                    {
                        Resultado += "Diez ";
                    }
                    break;
                case 2:
                    if (Unidades == 0) Resultado += "Venti";
                    else Resultado += "Veinte";
                    break;
                case 3: Resultado += "Treinta"; break;
                case 4: Resultado += "Cuarenta"; break;
                case 5: Resultado += "Cincuenta"; break;
                case 6: Resultado += "Sesenta"; break;
                case 7: Resultado += "Setenta"; break;
                case 8: Resultado += "Ochenta"; break;
                case 9: Resultado += "Noventa"; break;
            }
            if (Unidades != 0 && Decenas != 0) Resultado += " Y ";
            switch (Unidades)
            {
                case 1:
                    if (Decenas == 1) Resultado += "Once";
                    else Resultado += "Uno";
                    break;
                case 2:
                    if (Decenas == 1) Resultado += "Doce";
                    else Resultado += "Dos";
                    break;
                case 3:
                    if (Decenas == 1) Resultado += "Trece";
                    else Resultado += "Tres";
                    break;
                case 4:
                    if (Decenas == 1) Resultado += "Catorce";
                    else Resultado += "Cuatro";
                    break;
                case 5:
                    if (Decenas == 1) Resultado += "Quince";
                    else Resultado += "Cinco";
                    break;
                case 6: Resultado += "Seis"; break;
                case 7: Resultado += "Siete"; break;
                case 8: Resultado += "Ocho"; break;
                case 9: Resultado += "Nueve"; break;
            }
            if (ParteDecimal != -1)
            {
                Decenas = ParteDecimal / 10;
                Unidades = ParteDecimal % 10;
                if (Decenas != 0 || Unidades != 0)
                {
                    Resultado += " con ";
                    switch (Decenas)
                    {
                        case 1:
                            if (Unidades != 5 && Unidades != 4 && Unidades != 3 && Unidades != 2 && Unidades != 1)
                            {
                                Resultado += "Diez ";
                            }
                            break;
                        case 2:
                            if (Unidades != 0) Resultado += "Venti";
                            else Resultado += "Veinte";
                            break;
                        case 3: Resultado += "Treinta"; break;
                        case 4: Resultado += "Cuarenta"; break;
                        case 5: Resultado += "Cincuenta"; break;
                        case 6: Resultado += "Sesenta"; break;
                        case 7: Resultado += "Setenta"; break;
                        case 8: Resultado += "Ochenta"; break;
                        case 9: Resultado += "Noventa"; break;
                    }
                    if (Decenas != 2) Resultado += " Y ";
                    switch (Unidades)
                    {
                        case 1:
                            if (Decenas == 1) Resultado += "Once";
                            else Resultado += "Uno";
                            break;
                        case 2:
                            if (Decenas == 1) Resultado += "Doce";
                            else Resultado += "Dos";
                            break;
                        case 3:
                            if (Decenas == 1) Resultado += "Trece";
                            else Resultado += "Tres";
                            break;
                        case 4:
                            if (Decenas == 1) Resultado += "Catorce";
                            else Resultado += "Cuatro";
                            break;
                        case 5:
                            if (Decenas == 1) Resultado += "Quince";
                            else Resultado += "Cinco";
                            break;
                        case 6: Resultado += "Seis"; break;
                        case 7: Resultado += "Siete"; break;
                        case 8: Resultado += "Ocho"; break;
                        case 9: Resultado += "Nueve"; break;
                    }
                }
            }
            return Resultado;

        }
        private void RdbBoleta_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbBoleta.Checked == true) GenerarNroDoc("BOLETA");
        }

        private void RdbFactura_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbFactura.Checked) GenerarNroDoc("FACTURA");
        }
        public virtual void GenerarNroDoc(string Tipo)
        {

        }
        public void FechaActual()
        {
            TxtFecha.Text = string.Format(DateTime.Now.ToString());
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TxtFecha.Text = string.Format(DateTime.Now.ToString());
        }

        private void BtnBuscarDoc_Click(object sender, EventArgs e)
        {
            ProcesarClave();
        }
    }
}
