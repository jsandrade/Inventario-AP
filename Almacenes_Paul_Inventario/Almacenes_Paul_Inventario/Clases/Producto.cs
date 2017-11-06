using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        //static MySqlCommand comando = new MySqlCommand();

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
        //METODOS

        //cargar datos primer combo
        //public DataTable DatosProd()
        //{
        //    comando.Connection = Conexion.getConnection();
        //    MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT gru_nombre FROM tipo_producto", comando.Connection);
        //    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    adap.Fill(dt);

        //    return dt;
        //}
        //cargar datos segundo combo

        //public DataTable Datos1()
        //{
        //    //comando.Connection = Conexion.getConnection();
        //    //MySqlCommand cmd = new MySqlCommand("SELECT gru_nombre FROM grupo_producto", comando.Connection);
        //    //MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
        //    //DataTable dt = new DataTable();
        //    //adap.Fill(dt);

        //    return dt;
        //}
        public void CargarComboGrupo(ComboBox cmb)
        {
            //DataTable dt = Datos1();
            //foreach (DataRow fila in dt.Rows)
            //{
            //    cmb.Items.Add(Convert.ToString(fila["gru_nombre"]));

            //}
        }
        //cargar datos segundo combo
        //public DataTable Datos2(String nombre)
        //{
        //    //comando.Connection = Conexion.getConnection();
        //    //MySqlCommand cmd = new MySqlCommand("SELECT tip_nombre FROM tipo_producto WHERE gru_nombre='" + nombre + "' ", comando.Connection);
        //    //MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
        //    //DataTable dt = new DataTable();
        //    //adap.Fill(dt);
        //    return dt;
        //}
        public void CargarComboTipo(ComboBox cmbGrupo, ComboBox cmbTipo)
        {
            //cmbTipo.Items.Clear();
            //DataTable dt = Datos2(cmbGrupo.SelectedItem.ToString());
            //foreach (DataRow fila in dt.Rows)
            //{
            //    cmbTipo.Items.Add(Convert.ToString(fila["tip_nombre"]));
            //}
        }

        //Validar si existe serie
        public Boolean VerificarSerie(string serie)
        {
            Boolean band = false;
            //int lista = 0;
            //comando.Connection = Conexion.getConnection();
            //try
            //{
            //    comando.CommandText = "SELECT count(*) FROM producto WHERE pro_serie ='" + serie + "' ";
            //    lista = int.Parse(comando.ExecuteScalar().ToString());
            //    if (lista == 1)
            //    {
            //        band = true;
            //    }
            //    comando.Connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            return band;
        }

        //generar codigo del producto
        public void GenerarCodigo(ComboBox combo1, ComboBox combo2, TextBox grupoTipo, TextBox codigo)
        {
            ////validar si no selecciona
            //String cadena1 = combo1.SelectedItem.ToString();
            //String cadena2 = combo2.SelectedItem.ToString();
            //int antes = 0;
            //comando.Connection = Conexion.getConnection();
            //MySqlCommand _comando = new MySqlCommand(String.Format("SELECT  max(pro_codigo) AS pro_codigo from producto"), comando.Connection);
            //MySqlDataReader reader = _comando.ExecuteReader();
            //while (reader.Read())
            //{
            //    reader.Read();
            //    antes = reader.GetInt32(0);

            //}
            //grupoTipo.Text = cadena2;
            //codigo.Text = cadena1.Substring(0, 3) + "-" + Convert.ToString(antes + 1) + "-" + cadena2;
        }

        //GUARDAR PRODUCTO
        public static int GuardarProducto(string proCodigoCliente, string proSerie, string proModelo, string proMarca, string proPrecio, string proTipo, string proDescripcion, string proStock)
        {
            int band = 0;
            try
            {
                //comando.Parameters.Clear();
                //comando.CommandText = "INSERT INTO producto(pro_codigo_cliente, pro_serie, pro_modelo, pro_marca, pro_precio,tip_nombre, pro_descripcion, pro_stock) values (@proCodigoCliente, @proSerie, @promodelo, @proMarca, @proPrecio, @proTipo, @proDescripcion,@proStock)";
                //comando.Parameters.AddWithValue("@proCodigoCliente", proCodigoCliente);
                //comando.Parameters.AddWithValue("@proSerie", proSerie);
                //comando.Parameters.AddWithValue("@proModelo", proModelo);
                //comando.Parameters.AddWithValue("@proMarca", proMarca);
                //comando.Parameters.AddWithValue("@proPrecio", proPrecio);
                //comando.Parameters.AddWithValue("@proTipo", proTipo);
                //comando.Parameters.AddWithValue("@proDescripcion", proDescripcion);
                //comando.Parameters.AddWithValue("@proStock", proStock);
                //comando.Connection = Conexion.getConnection();
                //comando.ExecuteNonQuery();
                //comando.Connection.Close();
                //band = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return band;
        }
        //HASTA AUI LE ENVIE A CRIS/////////////////////////////////////////////////////////////////////////////////
        //
        //
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
