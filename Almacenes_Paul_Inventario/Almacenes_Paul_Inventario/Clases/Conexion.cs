using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Almacenes_Paul_Inventario.Clases
{
    public class Conexion
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=cccli; Uid=root; pwd=1234;");
            conectar.Open();
            return conectar;
        }
    }
}
