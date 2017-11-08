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
    public partial class ProductoCRUD : Form
    {
        public ProductoCRUD()
        {
            InitializeComponent();
        }

        private void ProductoCRUD_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int aux = 0;
            String cod = "3";
            aux = Producto.GuardarProducto(txtNombre.Text, txtSerie.Text, txtModelo.Text, txtMarca.Text, txtPrecio.Text, txtDescripcion.Text, txtStock.Text);
            if (aux == 1)
            {
                MessageBox.Show("Los datos se ingresaron Correctamente");
            }
            else
            {
                MessageBox.Show("Los datos no se ingresaron ");
            }
        }
    }
}
