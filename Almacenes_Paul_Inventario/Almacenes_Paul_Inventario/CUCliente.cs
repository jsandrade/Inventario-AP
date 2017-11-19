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
    public partial class CUCliente : Form
    {
        private int Opcion;
        private Cliente objCliente;
        private String[] datosAnteriores;

        public CUCliente(int Opcion, string[] dCliente)
        {
            InitializeComponent();
            this.Opcion = Opcion;
            objCliente = new Cliente();
            //
            if (Opcion!=1)
            {
                datosAnteriores = dCliente;
                txtCedula.Text = dCliente[0];
                txtCedula.Enabled = false;
                txtApellidos.Text = dCliente[1]+ " " + dCliente[2];
                txtNombres.Text =dCliente[3];
                txtTelFijo.Text = dCliente[4];
                txtTelCedular.Text = dCliente[5];
                txtDireccion.Text = dCliente[6];
                txtCorreo.Text = dCliente[7];
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Opcion==1)
            {
                //Recopilacion de datos a guardar
                RecuperarDatos();
                //Validar vacios
                if (ValidarVacios())
                {
                    //Valido el numero de cédula
                    if (ValidarCedula())
                    {
                        //Validar Correo
                        if (ValidarCorreo())
                        {
                            if (ValidarTelCelular() && ValidarTelFijo())
                            {
                                //Llamo al metodo para modificar el cliente
                                if (objCliente.guardarCliente() == 1)
                                {
                                    BorrarCampos();
                                    MessageBox.Show("Datos guardados exitosamente.", "Aviso");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido guardar los datos.", "Aviso");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Los numeros de telefono deben tener 10 digitos", "Aviso");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El correo electronico que desea ingresar no es valido", "Aviso");
                        }
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
                        , "Aviso");
                }
            }
            else
            {
                if (ValidarVacios())
                {
                    if (ValidarCambios())
                    {
                        //Recopilacion de los datos a modificar
                        RecuperarDatos();
                        //Valido el correo
                        if (ValidarCorreo())
                        {
                            if (ValidarTelCelular()&&ValidarTelFijo())
                            {
                                //Llamo al metodo para modificar el cliente
                                if (objCliente.ModificarCliente() == 1)
                                {
                                    MessageBox.Show("Los datos han sido modificados correctamente ", "Aviso");
                                    BorrarCampos();
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido modificar los datos", "Aviso");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Los numeros de telefono deben tener 10 digitos", "Aviso");
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show("El correo electronico que desea ingresar no es valido", "Aviso");
                        }

                    }
                    else
                    {
                        MessageBox.Show("No se ha podido actualizar los datos porque no a realizado ningun cambio", "Aviso");
                    }

                }
                else
                {
                    MessageBox.Show("Es necesario que llene todos los campos para ser modificados.", "Aviso");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region METODOS
        /// <summary>
        /// Método que permite verificar si se a modificado algun parametro para guardar.
        /// </summary>
        /// <returns></returns>
        private bool ValidarCambios()
        {

            if (txtApellidos.Text.Equals(datosAnteriores[1]+" "+datosAnteriores[2])|| datosAnteriores[3].Equals(txtNombres.Text)
                ||datosAnteriores[4].Equals(txtTelFijo.Text)||datosAnteriores[5].Equals(txtTelCedular.Text)
                ||datosAnteriores[6].Equals(txtDireccion.Text)||datosAnteriores[7].Equals(txtCorreo.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

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
                if (num1 >= 1 && num1 <= 24)
                {
                    //Tercer digito un numero menor a 6
                    int num2 = int.Parse(cedula.Substring(2, 1));
                    if (num2 >= 0 && num2 < 6)
                    {
                        //Obtener el digito verificador
                        int numV = 0;
                        int[] pro = new int[] { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
                        for (int i = 0; i < 9; i++)
                        {
                            int num3 = int.Parse(cedula.Substring(i, 1));
                            if (num3 * pro[i] >= 10)
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
                        if (numV != 0)
                        {
                            numV = 10 - numV;
                        }
                        //Verificar si este digito es igual al 10 dgito
                        int num4 = int.Parse(cedula.Substring(9, 1));
                        if (numV == num4)
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
            if (txtApellidos.Text.Equals("") || txtNombres.Text.Equals("") || txtCedula.Text.Equals("")
                || txtTelFijo.Text.Equals("") || txtTelCedular.Text.Equals("") || txtDireccion.Text.Equals("")
                || txtCorreo.Text.Equals(""))
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
            txtCedula.Text = "";
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtTelCedular.Text = "";
            txtTelFijo.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
        }

        /// <summary>
        /// Metodo que perimite mostrar los datos de la clase en el formulario actual.
        /// </summary>
        private void ObtenerDatos()
        {
            txtCedula.Text = objCliente.CliCedula;
            txtApellidos.Text = objCliente.CliApellidoPaterno + " " + objCliente.CliApellidoMaterno;
            txtNombres.Text = objCliente.CliNombres;
            txtTelCedular.Text = objCliente.CliTelCelular;
            txtTelFijo.Text = objCliente.CliTelFijo;
            txtDireccion.Text = objCliente.CliDireccion;
            txtCorreo.Text = objCliente.CliCorreo;
        }
        #endregion

        #region VALIDACIONES
        private void txtTelFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void numerosYletras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void NumerosLetrasyArroba(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('@') && txtCorreo.Text.Contains('@'))
            {
                e.Handled = true;
            }
            else if (Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.Equals('@')|| e.KeyChar.Equals('_')||
                e.KeyChar.Equals('.')|| e.KeyChar.Equals('-'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            
        }


        private bool ValidarCorreo()
        {
            string correo = txtCorreo.Text;
            //Debe contener al menos un simbolo de @
            if (correo.Contains('@'))
            {
                String[] Separacion = correo.Split('@');
                if (Separacion.Length==2)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ValidarTelCelular()
        {
            if (txtTelCedular.Text.Length>9)
            {
                return true;
            }
            return false;
        }
        private bool ValidarTelFijo()
        {
            if (txtTelFijo.Text.Length > 9)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
