using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacenes_Paul_Inventario
{
    class Cliente
    {
        private String cliCedula;
        private String cliApellidoPaterno;
        private String cliApellidoMaterno;
        private String cliNombres;
        private String cliTelCelular;
        private String cliTelFijo;
        private String cliDireccion;
        private String cliCorreo;

        public Cliente() {
        }
        
        #region Getters & Setters

        public string CliCedula {
            get => cliCedula;
            set => cliCedula = value;
        }
        public string CliApellidoPaterno {
            get => cliApellidoPaterno;
            set => cliApellidoPaterno = value;
        }
        public string CliApellidoMaterno {
            get => cliApellidoMaterno;
            set => cliApellidoMaterno = value;
        }
        public string CliNombres {
            get => cliNombres;
            set => cliNombres = value;
        }
        public string CliTelCelular {
            get => cliTelCelular;
            set => cliTelCelular = value;
        }
        public string CliTelFijo {
            get => cliTelFijo;
            set => cliTelFijo = value;
        }
        public string CliDireccion {
            get => cliDireccion;
            set => cliDireccion = value;
        }
        public string CliCorreo {
            get => cliCorreo;
            set => cliCorreo = value;
        }
        #endregion

        /// <summary>
        /// Método que permite guardar los datos del cliente en la base. 
        /// </summary>
        /// <returns></returns>
        public int guardarCliente()
        {
            return 0;
        }

        /// <summary>
        /// Verifica si el cliente existe dentro de la base de datos.
        /// </summary>
        /// <returns></returns>
        public bool verificarCliente()
        {
            return true;
        }

        /// <summary>
        /// Realiza la busqueda de clientes dentro de la base de datos.
        /// </summary>
        /// <param name="tipo">0: Cédula ; 1: Apellido</param>
        /// <param name="dato">Envia el parametro de busqueda sea la cédula o el apellido</param>
        public void buscarCliente(int tipo,string dato)
        {

        }

        /// <summary>
        /// Guarda los cambios en los datos del cliente
        /// </summary>
        /// <returns></returns>
        public int ModificarCliente()
        {
            return 1;
        }

        /// <summary>
        /// Elmina el registro del cliente de la base de datos.
        /// </summary>
        /// <returns></returns>
        public int EliminarCliente()
        {
            return 1;
        }
    }
}
