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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int aux = 0;
            String nombre;
            nombre = txtNombre.Text;
            opcion(1);
            aux = Producto.BuscarProducto(nombre,txtSerie,txtModelo,txtMarca,txtPrecio,txtDescripcion,txtStock);
            if (aux == 1)
            {
                MessageBox.Show("Producto Encontrado");
            }
            else
            {
                MessageBox.Show("No se encontre el producto");
                txtNombre.Text = "";
            }

        }

        public void opcion(int a)
        {
            if (a==1)
            {
                txtMarca.Enabled = false;
                txtModelo.Enabled = false;
                txtPrecio.Enabled = false;
                txtStock.Enabled = false;
                txtDescripcion.Enabled = false;
            }
            if (a == 2)
            {
                txtMarca.Text = "";
                txtModelo.Text = "";
                txtPrecio.Text = "";
                txtSerie.Text = "";
                txtStock.Text = "";
                txtDescripcion.Text = "";
                txtNombre.Text = "";
            }
        }
    }
}
