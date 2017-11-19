using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacenes_Paul_Inventario.Clases
{
    class Compra
    {
        #region Atributos
        Producto pro = new Producto();
        static MySqlCommand comando = new MySqlCommand();
        //private static frmBuscarProductoVenta objBusqProd = new frmBuscarProductoVenta();
        //private static frmRegistrarVenta objregis = new frmRegistrarVenta();
        static int auxiliar = 0;
        static int aux2 = 0;
        private static float valor = 0;
        private static float valorIva = 0;
        private static float iva = 0.15F;
        private static float total = 0;

        #endregion

        #region Get y Set
        public float Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public float IVA
        {
            get { return iva; }
            set { iva = value; }
        }
        public float Total
        {
            get { return total; }
            set { total = value; }
        }
        #endregion

        #region Cliente Venta
        public static Cliente Buscar_Cliente_Venta(string cedula)
        {
            Cliente pCliente = new Cliente();
            comando.Connection = Conexion.getConnection();
            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM pecli_cliente WHERE pecli_cedula ='" + cedula + "'"), comando.Connection);
                MySqlDataReader reader = _comando.ExecuteReader();
                while (reader.Read())
                {
                    pCliente.CliCedula = reader.GetString(1);
                    pCliente.CliNombres = reader.GetString(4);
                    pCliente.CliApellidoPaterno = reader.GetString(2);
                    pCliente.CliApellidoMaterno = reader.GetString(3);
                    pCliente.CliTelFijo = reader.GetString(5);
                    pCliente.CliTelCelular = reader.GetString(6);
                    pCliente.CliDireccion = reader.GetString(7);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return pCliente;

        }
        public static int Verificar_Cliente_Venta(string cedula)
        {
            Cliente pCliente = new Cliente();
            int band1 = 0;
            comando.Connection = Conexion.getConnection();
            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM pecli_cliente WHERE pecli_cedula ='" + cedula + "'"), comando.Connection);
                MySqlDataReader reader = _comando.ExecuteReader();
                while (reader.Read())
                {
                    pCliente.CliCedula = reader.GetString(1);
                    pCliente.CliNombres = reader.GetString(4);
                    pCliente.CliApellidoPaterno = reader.GetString(2);
                    pCliente.CliApellidoMaterno = reader.GetString(3);
                    pCliente.CliTelFijo = reader.GetString(5);
                    pCliente.CliTelCelular = reader.GetString(6);
                    pCliente.CliDireccion = reader.GetString(7);
                    band1 = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return band1;

        }
        #endregion
        public DataTable DatosProd()
        {
            comando.Connection = Conexion.getConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT PEPRO_NOMBRE FROM pepro_produc", comando.Connection);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;
        }
        public void CargarComboGrupo1(ComboBox cmb)
        {
            DataTable dt = DatosProd();
            cmb.Items.Clear();
            foreach (DataRow fila in dt.Rows)
            {
                cmb.Items.Add(Convert.ToString(fila["pepro_nombre"]));

            }
        }

        public static int Cantidad_Productos(String nombre)
        {
            int a = 0;
            Producto pProducto = new Producto();
            comando.Connection = Conexion.getConnection();
            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT `PEPRO_STOCK` FROM `pepro_produc` WHERE `PEPRO_NOMBRE`='" + nombre + "';"), comando.Connection);
                MySqlDataReader reader = _comando.ExecuteReader();
                while (reader.Read())
                {
                    a = reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return a;
        }


        public static float totalP(float tot)
        {
            return tot;
        }
        public static int CargarProd(String producto, int prodSelected, DataGridView dato)
        {
            int aux = 0;
            Producto pProducto = new Producto();
            VentasCRUD ven = new VentasCRUD();
            comando.Connection = Conexion.getConnection();
            auxiliar = dato.RowCount;
            float b = 0;
            float c = 0;
            #region sacar datos
            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format("select pepro_codigo,pepro_descripcion,pepro_precio,pepro_stock  from pepro_produc where PEPRO_NOMBRE='" + producto + "';"), comando.Connection);
                MySqlDataReader reader = _comando.ExecuteReader();
                while (reader.Read())
                {
                    pProducto.ProCodigo = reader.GetString(0);
                    pProducto.ProDescripcion = reader.GetString(1);
                    pProducto.ProPrecio = reader.GetString(2);
                    pProducto.ProStock = reader.GetString(3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
            b = float.Parse(pProducto.ProPrecio);
            //Se ele esta incluyendo el iva en la venta
            c = b * prodSelected;
            for (int j = auxiliar - 1; j < auxiliar; j++)
            {
                //Valido el ingreso de datos al dataGridView

                dato.Rows[j].Cells[0].Value = pProducto.ProCodigo;
                dato.Rows[j].Cells[1].Value = prodSelected;
                dato.Rows[j].Cells[2].Value = pProducto.ProDescripcion;
                dato.Rows[j].Cells[3].Value = pProducto.ProPrecio;
                dato.Rows[j].Cells[4].Value = c.ToString();
            }
            totalP(c);
            return aux;
        }
        public static int numero_Compra()
        {
            int num = 0;
            comando.Connection = Conexion.getConnection();
            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT max(peven_NUMVENTA) from peven_venta;"), comando.Connection);
                MySqlDataReader reader = _comando.ExecuteReader();
                while (reader.Read())
                {
                    num = reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return num;
        }


        public static int registrarCompra(String venta, String cliCedula, String comNumFicha, float comPrecioTotal, DateTime comFecha)
        {
            int band = 0;

            try
            {
                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO peven_venta (PEVEN_CODIGO, PECLI_CEDULA,PEVEN_NUMVENTA, PEVEN_NUMFIC, PEVEN_PRECIOT, PEVEN_FECHA) VALUES(null,@cli_cedula,@ven_numventa,@ven_num_ficha,@ven_preciototal,@ven_fecha)";
                comando.Parameters.AddWithValue("@cli_cedula", cliCedula);
                comando.Parameters.AddWithValue("@ven_numventa", venta);
                comando.Parameters.AddWithValue("@ven_num_ficha", comNumFicha);
                comando.Parameters.AddWithValue("@ven_preciototal", comPrecioTotal);
                comando.Parameters.AddWithValue("@ven_fecha", comFecha);
                comando.Connection = Conexion.getConnection();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                band = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                band = 0;
            }

            return band;
        }

        public static int productoCompra(int producto, String numeroCompra)
        {
            int band = 0;
            try
            {
                comando.Parameters.Clear();
                comando.CommandText = "INSERT INTO pr_peven_venta_pepro_produc(PEPRO_CODIGO, PEVEN_CODIGO) VALUES(@producto,@numeroCompra)";
                comando.Parameters.AddWithValue("@producto", producto);
                comando.Parameters.AddWithValue("@numeroCompra", numeroCompra);
                comando.Connection = Conexion.getConnection();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
                band = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                band = 0;
            }

            return band;
        }

        public static int actualizarStockCodigo(String codigo, int cantidad)
        {
            int aux = 0;
            try
            {
                comando.Connection = Conexion.getConnection();
                MySqlCommand _comando = new MySqlCommand(string.Format("Update pepro_produc set pepro_stock='" + cantidad + "' where PEPRO_NOMBRE='" + codigo + "';"), comando.Connection);
                aux = _comando.ExecuteNonQuery();
                comando.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return aux;
        }

        public static int obtenerCodigo(String tipo, String descripcion)
        {
            int codigo = 0;
            try
            {
                comando.Connection = Conexion.getConnection();
                MySqlCommand _comando = new MySqlCommand(string.Format("select pro_codigo from producto where tip_nombre='" + tipo + "' and PRO_DESCRIPCION='" + descripcion + "';"), comando.Connection);
                MySqlDataReader reader = _comando.ExecuteReader();
                while (reader.Read())
                {
                    codigo = reader.GetInt32(0);
                }
                //MessageBox.Show("Este es el codigo   " + codigo.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return codigo;
        }

        //public static int actualizarStock1(String tipo, String descripcion, String cantidad)
        //{
        //    int aux = 0;
        //    int codigo = 0;
        //    codigo = obtenerCodigo(tipo, descripcion);
        //    //MessageBox.Show("Voy a actualizar este codigo "+codigo+" con este valor "+cantidad);
        //    try
        //    {
        //        comando.Connection = Conexion.getConnection();
        //        MySqlCommand _comando = new MySqlCommand(string.Format("Update producto set pro_stock='" + cantidad + " ' where pro_codigo='" + codigo + "';"), comando.Connection);
        //        aux = _comando.ExecuteNonQuery();
        //        comando.Connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    return aux;
        //}
        public static int CantidadProductosActualizar(String descripcion)
        {
            int cantidad = 0;
            comando.Connection = Conexion.getConnection();
            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format("select pro_stock from producto where pro_descripcion='" + descripcion + "';"), comando.Connection);
                MySqlDataReader reader = _comando.ExecuteReader();
                while (reader.Read())
                {
                    cantidad = reader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            return cantidad;
        }

    }
}
