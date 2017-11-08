using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Almacenes_Paul_Inventario
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection();
        String connectionString;
        String server = "localhost:3308";
        String usuario = "root";
        String password = "1234";

        //Creacion del metodo para conexion a la bae de datos y obtener usuario login
        private void iniciarConexion()
        {
            try
            {
                //connectionString = "Server=127.0.0.1; database=cccli; Uid=root; Pwd=1234;";
                connectionString = "Server="+server+"; Database=cccli; Uid="+usuario+"; Pwd="+password+";";
                connection.ConnectionString = connectionString;
                connection.Open();

                MessageBox.Show("CONEXION EXITOSA");
            }
            catch (MySqlException e)
            {
                MessageBox.Show("ERROR DE CONEXION, :( "+e);
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnLoginIngresar_Click(object sender, EventArgs e)
        {
            if (txtLoginUsuario.Text == "" || txtLoginContraseña.Text == "")
            {
                MessageBox.Show("ERROR- CAMPOS VACIOS INGRESE DATOS");
                txtLoginUsuario.Focus();
            }
            else
            {
                try
                {
                    IDbCommand comando = connection.CreateCommand();
                    connection.Open();
                    connectionString = "select * from login  where pelog_user='" + txtLoginUsuario.Text + "'AND pelog_password='" + txtLoginContraseña.Text + "';";
                    comando.ExecuteNonQuery();
                    //Si 
                    Menu menu = new Menu();
                    menu.Show();
                    CenterToScreen();
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR--NO EXISTE USUARIO");
                }
            }

           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            iniciarConexion();

            CenterToScreen();
        }
    }
}
