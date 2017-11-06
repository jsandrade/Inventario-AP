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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoCRUD producto = new ProductoCRUD();
            producto.Show();
            CenterToParent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
