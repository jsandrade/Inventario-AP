using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacenes_Paul_Inventario
{
    public partial class ClienteCRUD : Form
    {
        private Cliente objCliente;
        public ClienteCRUD()
        {
            InitializeComponent();
            objCliente = new Cliente();
        }

        private void ClienteCRUD_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Recopilacion de datos a guardar
            RecuperarDatos();
            //Llamo al metodo para modificar el cliente
            objCliente.guardarCliente();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Definir los parametros de busqueda
            String parametros = DefinirBusqueda();
            //Si existen los parametros adecuados realizamos la busqueda
            if (parametros!="-1 ")
            {
                //Si encuentra el cliente mandar mensajes y recuperar datos
                objCliente.buscarCliente(int.Parse(parametros.Split(' ')[0]), parametros.Split(' ')[1]);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Recopilacion de los datos a modificar
            RecuperarDatos();
            //Llamo al metodo para modificar el cliente
            objCliente.ModificarCliente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Recopilacion de la cédula del cliente a eliminar
            objCliente.CliCedula = txtCedula.Text;
            objCliente.EliminarCliente();
        }

        #region METODOS
        /// <summary>
        /// Método  que permite leer todos los datos de los campos de cliente y los guarda en 
        /// el objeto actual del cliente.
        /// </summary>
        private void RecuperarDatos()
        {
            objCliente.CliCedula = txtCedula.Text;
            objCliente.CliApellidoPaterno = txtApellidos.Text.Split(' ')[0];
            try
            {
                objCliente.CliApellidoMaterno = txtApellidos.Text.Split(' ')[1];
            }
            catch
            {
                objCliente.CliApellidoMaterno = "";
            }
            objCliente.CliNombres = txtNombres.Text;
            objCliente.CliTelCelular = txtTelCedular.Text;
            objCliente.CliTelFijo = txtTelFijo.Text;
            objCliente.CliDireccion = txtDireccion.Text;
            objCliente.CliCorreo = txtCorreo.Text;
        }

        /// <summary>
        /// Permite definir los parametros para la realizaci{on de la busqueda ya sea por cedula o por apellido.
        /// </summary>
        /// <returns>Retorna "-1 ": cuando no existen los parametros necesarios para la busqueda.</returns>
        private string DefinirBusqueda()
        {
            int Tipo=-1;
            String Dato="";
            //Lee el dato de cedula si esta lleno y validado definira los parametros para busqueda
            //por cedula
            if (true)
            {
                Tipo = 0;
                Dato = txtCedula.Text;
            }
            else 
            {
                //Si no hay datos en el campo de cedula o no es valido verifica validez del campo 
                //apellido y define los parametros para su busqueda
                if (true)
                {
                    Tipo = 1;
                    Dato = txtApellidos.Text.Split(' ')[0];
                }
            }
            return Tipo + " " + Dato;
        }

        #endregion
    }
}
