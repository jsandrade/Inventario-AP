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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLoginIngresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            CenterToScreen();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
