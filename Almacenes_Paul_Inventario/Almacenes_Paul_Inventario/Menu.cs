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

        private void Menu_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoCRUD producto = new ProductoCRUD();
            producto.Show();
            CenterToParent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteCRUD cliente = new ClienteCRUD();
            cliente.Show();

        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasCRUD ventas = new VentasCRUD();
            ventas.Show();
        }
    }
}
