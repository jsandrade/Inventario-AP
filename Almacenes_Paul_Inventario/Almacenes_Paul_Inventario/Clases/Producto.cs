using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Almacenes_Paul_Inventario
{
   class Producto
    {
        private string proCodigo;
        private string proCodigoCliente;
        private string proSerie;
        private string proModelo;
        private string proMarca;
        private string proPrecio;
        private string proTipo;
        private string proDescripcion;
        private string proStock;
        static MySqlCommand comando = new MySqlCommand();

        public Producto() { }

        /// <summary>
        /// Inicializando las variables 
        /// </summary>
        /// <returns></returns>
        public Producto(string proCodigo, string proCodigoCliente, string proSerie, string proModelo, string proMarca, string proPrecio, string proTipo, string proDescripcion, string proStock)
        {
            this.proCodigo = proCodigo;
            this.proCodigoCliente = proCodigoCliente;
            this.proSerie = proSerie;
            this.proModelo = proModelo;
            this.proMarca = proMarca;
            this.proPrecio = proPrecio;
            this.proTipo = proTipo;
            this.proDescripcion = proDescripcion;
            this.proStock = proStock;
        }
        

        
        public static int GuardarProducto( string proNombre, string proSerie, string proModelo, string proMarca, string proPrecio, string proDescripcion, string proStock)
        {
            int band = 0;
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO pepro_produc(PEPRO_CODIGO, PEPRO_NOMBRE, PEPRO_SERIE, PEPRO_MODELO, PEPRO_MARCA, PEPRO_PRECIO, PEPRO_DESCRIPCION, PEPRO_STOCK) values (NULL,@proNombre, @proSerie, @promodelo, @proMarca, @proPrecio, @proDescripcion,@proStock)";
                //comando.Parameters.AddWithValue("@proCodigo", proCodigo);
                comando.Parameters.AddWithValue("@proNombre", proNombre);
                comando.Parameters.AddWithValue("@proSerie", proSerie);
                comando.Parameters.AddWithValue("@proModelo", proModelo);
                comando.Parameters.AddWithValue("@proMarca", proMarca);
                comando.Parameters.AddWithValue("@proPrecio", proPrecio);
                comando.Parameters.AddWithValue("@proDescripcion", proDescripcion);
                comando.Parameters.AddWithValue("@proStock", proStock);
                comando.Connection = Clases.Conexion.getConnection();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                band = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return band;
        }

        public static int EliminarProducto(string proCodigo)
        {
            int retorno = 0;
            try
            {
                //comando.Connection = Conexion.getConnection();
                //MySqlCommand _comando = new MySqlCommand(string.Format("DELETE FROM producto WHERE pro_codigo_cliente='" + proCodigo + "'"), comando.Connection);
                //retorno = _comando.ExecuteNonQuery();
                //comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return retorno;
        }
        //modificar producto
        public static int ModificarProducto(string proCodigo, string proSerie, string proModelo, string proMarca, string proPrecio, string proDescripcion)
        {
            Producto pProducto = new Producto();

            int aux = 0;
            float a = 0;
            //pProducto = producto;
            a = float.Parse(proPrecio);
            try
            {
                if (proPrecio != pProducto.ProPrecio || proCodigo != pProducto.proCodigo || proSerie != pProducto.proSerie || proModelo != pProducto.proModelo || proMarca != pProducto.ProMarca || proDescripcion != pProducto.ProDescripcion)
                {
                    //comando.Connection = Conexion.getConnection();
                    //MySqlCommand _comando = new MySqlCommand(string.Format("Update producto set pro_serie='" + proSerie + "', pro_modelo='" + proModelo + "', pro_marca='" + proMarca + "', pro_precio='" + a + "', pro_descripcion='" + proDescripcion + "' where pro_codigo_cliente='" + proCodigo + "'"), comando.Connection);
                    //aux = _comando.ExecuteNonQuery();
                    //comando.Connection.Close();
                }
                else
                {
                    MessageBox.Show("NO SE HA MOFICADO NINGUN CAMPO", "Mensaje de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aux = -99;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return aux;
        }


#region Get y set
        //set y get

        public string ProCodigo
        {
            get
            {
                return proCodigo;
            }

            set
            {
                proCodigo = value;
            }
        }
        public string ProCodigoCliente
        {
            get
            {
                return proCodigoCliente;
            }

            set
            {
                proCodigoCliente = value;
            }
        }
        public string ProSerie
        {
            get
            {
                return proSerie;
            }

            set
            {
                proSerie = value;
            }
        }
        public string ProModelo
        {
            get
            {
                return proModelo;
            }

            set
            {
                proModelo = value;
            }
        }
        public string ProMarca
        {
            get
            {
                return proMarca;
            }

            set
            {
                proMarca = value;
            }
        }
        public string ProPrecio
        {
            get
            {
                return proPrecio;
            }

            set
            {
                proPrecio = value;
            }
        }
        public string ProDescripcion
        {
            get
            {
                return proDescripcion;
            }

            set
            {
                proDescripcion = value;
            }
        }
        public string ProTipo
        {
            get
            {
                return proTipo;
            }

            set
            {
                proTipo = value;
            }
        }
        public string ProStock
        {
            get
            {
                return proStock;
            }

            set
            {
                proStock = value;
            }
        }
    #endregion
    }

}
