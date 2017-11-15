using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        static MySqlCommand comando;

        public Cliente() {
            comando = new MySqlCommand();
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
        /// <returns>Retorna 0 si hubo una excepcion al guardar los datos del cliente o 1 en caso contrario.</returns>
        public int guardarCliente()
        {
            int band=0;
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO pecli_cliente(PECLI_CEDULA,PECLI_APELLIDOPATERNO," +
                    "PECLI_APELLIDOMATERNO, PECLI_NOMBRES, PECLI_FIJO, PECLI_CELULAR, PECLI_DIRECCION,PECLI_CORREO)" +
                    " values (@cliCedula, @cliApellidoPaterno, @cliApellidoMaterno, @cliNombres, @cliTelFijo," +
                    " @cliTelCelular,@cliDireccion,@cliCorreo)";
                comando.Parameters.AddWithValue("@cliCedula", cliCedula);
                comando.Parameters.AddWithValue("@cliApellidoPaterno", cliApellidoPaterno);
                comando.Parameters.AddWithValue("@cliApellidoMaterno", cliApellidoMaterno);
                comando.Parameters.AddWithValue("@cliNombres", cliNombres);
                comando.Parameters.AddWithValue("@cliTelFijo", cliTelFijo);
                comando.Parameters.AddWithValue("@cliTelCelular", cliTelCelular);
                comando.Parameters.AddWithValue("@cliDireccion", cliDireccion);
                comando.Parameters.AddWithValue("@cliCorreo", cliCorreo);
                comando.Connection = Clases.Conexion.getConnection();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                band = 1;
            }
            catch (Exception ex)
            {
                band = 0;
                MessageBox.Show(ex.ToString());
            }
            return band;
        }

        /// <summary>
        /// Verifica si el cliente existe dentro de la base de datos para realizar cualquier operacion.
        /// </summary>
        /// <returns>Retorna True si la cedula del cliente se encuentra registrada dentro de la abse de datos.</returns>
        public bool verificarCliente()
        {
            Boolean band=false;
            string formato = "SELECT * WHERE  PECLI_CEDULA LIKE '" + cliCedula + "'";
            comando.Connection = Clases.Conexion.getConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format(formato), comando.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    band = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                band = false;
            }
            return band;
        }

        /// <summary>
        /// Realiza la busqueda de clientes dentro de la base de datos.
        /// </summary>
        /// <param name="dgvTabla">DataGridView en el que se llenaran los campos.</param>
        /// <param name="dato">Envia el parametro de busqueda sea la cédula o el apellido</param>
        public int buscarCliente(DataGridView dgvTabla,string dato)
        {
            int band = 0;
            String formato="";
        
                // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos
                // al DataGridView
                DataTable dtDatos = new DataTable();
                formato = "SELECT PECLI_CEDULA as 'Cedula',  concat(PECLI_APELLIDOPATERNO ,' ', PECLI_APELLIDOMATERNO) as 'Apellidos'," +
                    " PECLI_NOMBRES as 'Nombres', PECLI_FIJO as 'Tel. Fijo', PECLI_CELULAR as 'Tel. Celular', PECLI_DIRECCION as 'Direccion',PECLI_CORREO  as 'Correo'" +
                    "FROM pecli_cliente WHERE  PECLI_CEDULA like '%" + dato + "%'";
                comando.Connection = Clases.Conexion.getConnection();
                try
                {
                    // Se crea un MySqlAdapter para obtener los datos de la base
                    MySqlDataAdapter mdaDatos = new MySqlDataAdapter(String.Format(formato), comando.Connection);

                    // Con la información del adaptador se rellena el DataTable
                    mdaDatos.Fill(dtDatos);

                    // Se asigna el DataTable como origen de datos del DataGridView
                    dgvTabla.DataSource = dtDatos;
                    //MySqlCommand cmd = new MySqlCommand(String.Format(formato), comando.Connection);
                    //aux = Convert.ToString(cmd.ExecuteScalar());
                    //MySqlDataReader reader = cmd.ExecuteReader();

                    //while (reader.Read())
                    //{
                    //    cliCedula = dato;
                    //    cliApellidoPaterno = reader.GetString(0);
                    //    cliApellidoMaterno = reader.GetString(1);
                    //    cliNombres = reader.GetString(2);
                    //    cliTelFijo = reader.GetString(3);
                    //    cliTelCelular = reader.GetString(4);
                    //    cliDireccion = reader.GetString(5);
                    //    cliCorreo = reader.GetString(6);
                    //    band = 1;
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    band = 0;
                }
            



            return band;
        }

        /// <summary>
        /// Guarda los cambios en los datos del cliente
        /// </summary>
        /// <returns>Retorna 1 si se logro modificar</returns>
        public int ModificarCliente()
        {
            int band;
            try
            {

                    comando.Connection = Clases.Conexion.getConnection();
                    MySqlCommand _comando = new MySqlCommand(string.Format("Update pecli_cliente set " +
                        "PECLI_APELLIDOPATERNO='" + cliApellidoPaterno + "', PECLI_APELLIDOMATERNO='" + CliApellidoMaterno +
                        "', PECLI_NOMBRES='" + cliNombres + "', PECLI_FIJO='" + cliTelFijo + "', PECLI_CELULAR='" +
                        cliTelCelular + "',PECLI_DIRECCION='"+ cliDireccion+ "',PECLI_CORREO='" + cliCorreo + "' where PECLI_CEDULA like '" + cliCedula + "'"), comando.Connection);
                    band = _comando.ExecuteNonQuery();
                    comando.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                band = 0;
            }

            return band;
        }

        /// <summary>
        /// Elmina el registro del cliente de la base de datos.
        /// </summary>
        /// <returns></returns>
        public int EliminarCliente()
        {
            int band = 0;
            try
            {
                comando.Connection = Clases.Conexion.getConnection();
                MySqlCommand _comando = new MySqlCommand(string.Format("DELETE FROM pecli_cliente WHERE pecli_cedula like'" +
                    cliCedula + "'"), comando.Connection);
                band = _comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                band = 0;
                MessageBox.Show(ex.ToString());
            }
            return band;
        }
    }
}
