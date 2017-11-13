using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacenes_Paul_Inventario.Clases
{
    class Compra
    {
        /// <summary>
        /// declaracion variables clase compra 
        /// </summary>
        /// <returns></returns>
        public String com_numVenta;
        public String com_numFicha;
        public String com_tipo;
        public Double com_preciototal;
        public DateTime com_fecha;

        /// <summary>
        /// constructor 
        /// </summary>
        /// <returns></returns>
        public Compra() { 
        
        }

        /// <summary>
        /// devuelve com_numventa 
        /// </summary>
        /// <returns></returns>
        public String comnumventa()
        {
            return com_numVenta;
        }
        /// <summary>
        /// devuelve com_ficha 
        /// </summary>
        /// <returns></returns>
        public String numficha()
        {
            return com_numFicha;
        }
        /// <summary>
        /// devuelve com_comtipo
        /// </summary>
        /// <returns></returns>
        public String comtipo()
        {
            return com_tipo;
        }
        /// <summary>
        /// devuelve preciototal
        /// </summary>
        /// <returns></returns>
        public Double compreciototal()
        {
            return com_preciototal;
        }
        /// <summary>
        /// devuelve comfecha
        /// </summary>
        /// <returns></returns>
        public DateTime comfecha()
        {
            return com_fecha;
        }


        public int buscarcliente(String cedula)
        {
            return 0;
            //;

        }
        public int buscarproducto(int procodigo)
        {
            return 0;
            //;

        }

        /// <summary>
        /// devuelve seleccionarcleinte
        /// </summary>
        /// <returns></returns>
        public Cliente seleccionarcliente(String cedula)
        {
            return null;
            //;
            
        }

        public Producto seleccionarproducto(int procodigo)
        {
            return null;
            //;

        }

        public void seleccionargarante(int cedula)
        {
            
            //;

        }

        //public int validarcliente (int cedula)
        //{
        //    //return Cliente;
        //}

        //public int registrarcompra(int cedula)
        //{
        //    //return Cliente;
        //}

    }
}
