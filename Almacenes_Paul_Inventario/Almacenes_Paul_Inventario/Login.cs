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
        String server = "localhost";
        String usuario = "root";
        String password = "1234";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLoginIngresar_Click(object sender, EventArgs e)
        {

            int aux=0;
            if (txtLoginContraseña.Text == "" || txtLoginUsuario.Text == "")
            {
                MessageBox.Show("LLENAR TODOS LOS CAMPOS", "Mensaje de información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clases.Conexion.getConnection();
                aux = Producto.BuscarUser(txtLoginUsuario.Text, txtLoginContraseña.Text);
                if (aux == 1)
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("DATOS INCORRECTOS", "Mensaje de información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLoginUsuario.Text = "";
                    txtLoginContraseña.Text = "";
                }
            }
            }

    private void Login_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
