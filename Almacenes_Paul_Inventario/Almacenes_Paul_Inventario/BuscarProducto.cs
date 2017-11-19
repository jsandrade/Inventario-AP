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
    public partial class BuscarProducto : Form
    {
        VentasCRUD ventasp = new VentasCRUD();
        private Clases.Compra comp = new Clases.Compra();
        Producto prod = new Producto();
        private ComboBox producto = new ComboBox();
        private ComboBox cantidad = new ComboBox();
        #region get y set
        public VentasCRUD VentasP
        {
            get { return ventasp; }
            set { ventasp = value; }
        }
        public ComboBox Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public ComboBox Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
#endregion

        public BuscarProducto()
        {
            InitializeComponent();
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //Cargo en el primer combo
            cmbProducto.Items.Clear();
            comp.CargarComboGrupo1(cmbProducto);
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAñadir_Click_1(object sender, EventArgs e)
        {
            VentasCRUD objVC = new VentasCRUD();
            Producto objp = new Producto();
            int aux = 0;
            int aux1 = 0;
            int cantElegir = 0;
            int cantidadTotal = 0;
            int cantNuevo = 0;
            String NombreP;
            String descripcion1;
            NombreP = cmbProducto.SelectedItem.ToString();
            cantidadTotal = int.Parse(lblCant.Text);
            cantElegir = int.Parse(txtNumP.Text);

            if (cmbProducto.Text == "" || txtNumP.Text == "")
            {
                MessageBox.Show("Llene los campos necesarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbProducto.Focus();
            }
            if (cantElegir > cantidadTotal || cantElegir < 0)
            {
                MessageBox.Show("NO PUEDE ESCOGER ESA CANTIDAD DE PRODUCTOS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cantNuevo = cantidadTotal - cantElegir;
                aux = Clases.Compra.CargarProd(NombreP, cantElegir, ventasp.Datos);
                aux1 = Clases.Compra.actualizarStockCodigo(NombreP, cantNuevo);
                this.Hide();
            }
        }

        private void cmbProducto_TextChanged_1(object sender, EventArgs e)
        {
            int aux = 0;
            string prod;
            prod = cmbProducto.SelectedItem.ToString();
            aux = Clases.Compra.Cantidad_Productos(prod);
            lblCant.Text = aux.ToString();
            if (lblCant.Text != "")
            {
                txtNumP.ReadOnly = false;
            }
            else
            {
                txtNumP.ReadOnly = true;
            }
        }
    }
}
