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
            if (txtNombre.Text != "")
            {
                aux = Producto.BuscarProducto(nombre, txtSerie, txtModelo, txtMarca, txtPrecio, txtDescripcion, txtStock);
                if (aux == 1)
                {
                    MessageBox.Show("Producto Encontrado");
                    opcion(3);
                }
                else
                {
                    MessageBox.Show("No se encontre el producto");
                    txtNombre.Text = "";
                }
            }
            else
            {
                MessageBox.Show("INGRESE DATOS EN EL CAMPO NOMBRE","Error");
                txtNombre.Focus();
            }
            

        }

        public void opcion(int a)
        {
            if (a==1)
            {
                txtSerie.Enabled = false;
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
            if (a == 3)
            {
                txtSerie.Enabled = true;
                txtMarca.Enabled = true;
                txtModelo.Enabled = true;
                txtPrecio.Enabled = true;
                txtStock.Enabled = true;
                txtDescripcion.Enabled = true;
            }
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            int aux = 0;
            

            aux = Producto.ModificarProducto(txtNombre.Text,txtSerie.Text,txtModelo.Text,txtMarca.Text,txtPrecio.Text,txtDescripcion.Text,txtStock.Text);
            if (aux == 1)
            {
                MessageBox.Show("LOS DATOS SE HAN ACTUALIZADO CORRECTAMENTE.", "Mensaje de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                opcion(2);
            }
            else
            {
                MessageBox.Show("LOS DATOS NO SE MODIFICARON","ERROR");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int aux=0;
            String nombre;
            String serie;
            nombre = txtNombre.Text;
            serie = txtSerie.Text;
            if (txtNombre.Text != "" && txtSerie.Text != "")
            {
                aux = Producto.EliminarProducto(nombre,serie);
                if (aux == 1)
                {
                    MessageBox.Show("EL PRODUCTO SE ELIMINO CORRECTAMENTE","CONFIRMACION");
                    opcion(2);
                }
                else
                {
                    MessageBox.Show("EL PRODUCTO NO SE ELIMINO", "ERROR");
                }
            }

        }
    }
}
