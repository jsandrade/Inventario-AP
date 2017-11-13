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
            //Validar vacios
            if (ValidarVacios())
            {
                //Valido el numero de cédula
                if (ValidarCedula())
                {
                    //Llamo al metodo para modificar el cliente
                    objCliente.guardarCliente();
                    BorrarCampos();
                }
                else
                {
                    MessageBox.Show("El número de cedula ingresado no es valido verifique y " +
                        "vuelva a intentar", "Aviso");
                }
            }
            else
            {
                MessageBox.Show("Para guardar sus datos es encesario que llene todos los campos "
                    ,"Aviso");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Definir los parametros de busqueda
            String parametros = DefinirBusqueda();
            //Si existen los parametros adecuados realizamos la busqueda
            if (parametros!="-1 ")
            {
                //Si encuentra el cliente mandar mensajes y recuperar datos
                if(objCliente.buscarCliente(int.Parse(parametros.Split(' ')[0]), parametros.Split(' ')[1]) == 1)
                {
                    MessageBox.Show("", "que");
                    ObtenerDatos();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar con campos validos la Cédula o el apellido del cliente" +
                    " que desea buscar","Aviso");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarVacios())
            {
                //Recopilacion de los datos a modificar
                RecuperarDatos();
                //Llamo al metodo para modificar el cliente
                if (objCliente.ModificarCliente()==1)
                {
                    MessageBox.Show("Aviso","Los datos han sido modificados correctamente ");
                    BorrarCampos();
                }
                else
                {
                    MessageBox.Show("Aviso", "No se ha podido modificar los datos");
                }
            }
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //VErificar que el campo cedula sea un campo no vacio
            if (!txtCedula.Text.Equals(""))
            {
                //Recopilacion de la cédula del cliente a eliminar
                objCliente.CliCedula = txtCedula.Text;
                //Llamar al metodo que permite borrar al cliente
                if (objCliente.EliminarCliente()==1)
                {
                    MessageBox.Show("Se a eliminado correctamente el usuario", "Operacion");
                    BorrarCampos();
                }
                else
                {
                    MessageBox.Show("No se a podido eliminar el usuario actual", "Operacion");
                }
                
            }
            else
            {
                MessageBox.Show("Aviso","Es necesario que el campo cedula se encuentre lleno para " +
                    "realizar esta opcion.");
            }

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
            if (ValidarCedula())
            {
                Tipo = 0;
                Dato = txtCedula.Text;
            }
            else 
            {
                //Si no hay datos en el campo de cedula o no es valido verifica validez del campo 
                //apellido y define los parametros para su busqueda
                if (!txtApellidos.Text.Equals(""))
                {
                    Tipo = 1;
                    Dato = txtApellidos.Text.Split(' ')[0];
                }
            }
            return Tipo + " " + Dato;
        }

        /// <summary>
        /// Método que permite realizar la validacion de la cedula
        /// </summary>
        /// <returns>Regresa True Si la cedula es valida</returns>
        private bool ValidarCedula()
        {
            string cedula = txtCedula.Text;
            //Cedula debe tener 10 digitos personas naturales y 13 para el RUC
            if (cedula.Length == 10 || cedula.Length == 13)
            {
                //El rango de los 2 primeros digitos no son [1;24]
                int num1 = int.Parse(cedula.Substring(0, 2));
                if (num1>=1 && num1<=24)
                {
                    //Tercer digito un numero menor a 6
                    int num2= int.Parse(cedula.Substring(2, 1));
                    if (num2>=0 && num2<6)
                    {
                        //Obtener el digito verificador
                        int numV = 0;
                        int[] pro = new int[] { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
                        for (int i = 0; i < 9; i++)
                        {
                            int num3 = int.Parse(cedula.Substring(i, 1));
                            if (num3*pro[i]>=10)
                            {
                                numV = numV + num3 * pro[i] - 9;
                            }
                            else
                            {
                                numV = numV + num3 * pro[i];
                            }
                        }
                        //Resta la decena superior
                        numV = numV % 10;
                        if (numV!=0)
                        {
                            numV = 10 - numV;
                        }
                        //Verificar si este digito es igual al 10 dgito
                        int num4 = int.Parse(cedula.Substring(9, 1));
                        if (numV==num4)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return false;
        }

        /// <summary>
        /// Método que permite la verificacion de que ningun campo se encuentr vacio.
        /// </summary>
        /// <returns>Retorna False si algun campo no se encuentra lleno o True en caso contrario</returns>
        private bool ValidarVacios()
        {
            if (txtApellidos.Text.Equals("")||txtNombres.Text.Equals("") ||txtCedula.Text.Equals("") 
                ||txtTelFijo.Text.Equals("") ||txtTelCedular.Text.Equals("") ||txtDireccion.Text.Equals("")
                ||txtCorreo.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Método que permite borrar todos los campos una vez guardado todos los datos
        /// </summary>
        private void BorrarCampos()
        {
            txtCedula.Text="";
            txtApellidos.Text = "";
            txtNombres.Text="";
            txtTelCedular.Text="";
            txtTelFijo.Text="";
            txtDireccion.Text="";
            txtCorreo.Text="";
        }

        /// <summary>
        /// Metodo que perimite mostrar los datos de la clase en el formulario actual.
        /// </summary>
        private void ObtenerDatos()
        {
            txtCedula.Text = objCliente.CliCedula;
            txtApellidos.Text = objCliente.CliApellidoPaterno+" "+objCliente.CliApellidoMaterno;
            txtNombres.Text = objCliente.CliNombres;
            txtTelCedular.Text = objCliente.CliTelCelular;
            txtTelFijo.Text = objCliente.CliTelFijo;
            txtDireccion.Text = objCliente.CliDireccion;
            txtCorreo.Text = objCliente.CliCorreo;
        }
        #endregion

    }
}
