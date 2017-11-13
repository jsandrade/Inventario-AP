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
        private string proNombre;
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
        public Producto(string proCodigo, string proNombre, string proSerie, string proModelo, string proMarca, string proPrecio, string proTipo, string proDescripcion, string proStock)
        {
            this.proCodigo = proCodigo;
            this.proNombre = proNombre;
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

        public static int BuscarProducto(string proNombre, TextBox serie, TextBox modelo,TextBox marca, TextBox precio, TextBox descri, TextBox stock)
        {
            int band = 0;

            comando.Connection = Clases.Conexion.getConnection();
            try
            {
                MySqlCommand cmd = new MySqlCommand(String.Format("SELECT PEPRO_SERIE ,PEPRO_MODELO,PEPRO_MARCA,PEPRO_PRECIO,PEPRO_DESCRIPCION ,PEPRO_STOCK FROM pepro_produc WHERE  PEPRO_NOMBRE= '" + proNombre + "'"), comando.Connection);
                //aux = Convert.ToString(cmd.ExecuteScalar());
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Estoy aqui");
                while (reader.Read())
                {
                    serie.Text = reader.GetString(0);
                    modelo.Text = reader.GetString(1);
                    marca.Text = reader.GetString(2);
                    precio.Text = reader.GetString(3);
                    descri.Text = reader.GetString(4);
                    stock.Text = reader.GetString(5);
                }
                band = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return band;
        }
        public static String Codigo(string proNombre, string proSerie)
        {
            String retorno="";

            try
            {
                comando.Connection = Clases.Conexion.getConnection();
                MySqlCommand _comando = new MySqlCommand(string.Format("SELECT PEPRO_CODIGO FROM pepro_produc WHERE PEPRO_NOMBRE= '" + proNombre + "' and PEPRO_SERIE= '" + proSerie + "';"), comando.Connection);
                MySqlDataReader reader = _comando.ExecuteReader();
                while (reader.Read())
                {
                    retorno = reader.GetString(0);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return retorno;
        }
        public static int EliminarProducto(String proNombre, String proSerie)
        {
            int retorno = 0;
            String proCodigo = Codigo(proNombre,proSerie);
            try
            {
                comando.Connection = Clases.Conexion.getConnection();
                MySqlCommand _comando = new MySqlCommand(string.Format("DELETE FROM pepro_produc WHERE pepro_codigo='" + proCodigo + "'"), comando.Connection);
                retorno = _comando.ExecuteNonQuery();
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return retorno;
        }
        //modificar producto
        public static int ModificarProducto( string proNombre,string proSerie, string proModelo, string proMarca, string proPrecio, string proDescripcion,String proStock)
        {
            Producto pProducto = new Producto();

            int aux = 0;
            //a se refiere a la variable que realizara el casting para el precio
            float a = 0; 
            int stk = 0;
            a = float.Parse(proPrecio);
            stk = int.Parse(proStock);
            String proCodigo = Codigo(proNombre, proSerie);
            try
            {
                if (proNombre!=pProducto.proNombre||proPrecio != pProducto.ProPrecio  || proSerie != pProducto.proSerie || proModelo != pProducto.proModelo || proMarca != pProducto.ProMarca || proDescripcion != pProducto.ProDescripcion)
                {
                    comando.Connection = Clases.Conexion.getConnection();
                    //MySqlCommand _comando = new MySqlCommand(string.Format("Update producto set pro_serie='" + proSerie + "', pro_modelo='" + proModelo + "', pro_marca='" + proMarca + "', pro_precio='" + a + "', pro_descripcion='" + proDescripcion + "' where pro_codigo_cliente='" + proCodigo + "'"), comando.Connection);

                    MySqlCommand _comando = new MySqlCommand(string.Format("UPDATE pepro_produc SET PEPRO_NOMBRE='"+proNombre+"',PEPRO_SERIE='"+proSerie+"',PEPRO_MODELO='"+proModelo+"',PEPRO_MARCA='"+proMarca+"',PEPRO_PRECIO='"+a+"',PEPRO_DESCRIPCION='"+proDescripcion+"',PEPRO_STOCK='"+stk+"' WHERE PEPRO_CODIGO='"+proCodigo+"';"), comando.Connection);
                    aux = _comando.ExecuteNonQuery();
                    comando.Connection.Close();
                    aux = 1;
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

        public static int BuscarUser(string usu, string pas)//Para el login
        {
            int band = 0;
            int lista = 0;
            comando.Connection = Clases.Conexion.getConnection();
            try
            {
                comando.CommandText = "SELECT count(*) FROM pelog_login where pelog_user ='" + usu + "' and pelog_password='" + pas + "'";
                lista = int.Parse(comando.ExecuteScalar().ToString());
                if (lista == 1)
                {
                    band = 1;
                }
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            return band;
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
                return proNombre;
            }

            set
            {
                proNombre = value;
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
