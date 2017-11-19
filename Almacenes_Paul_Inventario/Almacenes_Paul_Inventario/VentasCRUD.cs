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
    public partial class VentasCRUD : Form
    {
        Clases.Validacion val = new Clases.Validacion();
        private DateTime dt = DateTime.Now;
        private TextBox cedula = new TextBox();
        private TextBox cliente = new TextBox();
        private TextBox telf = new TextBox();
        private TextBox direc = new TextBox();
        private TextBox fechaR = new TextBox();
        private TextBox subTotal = new TextBox();
        private TextBox total = new TextBox();
        private TextBox iva = new TextBox();
        private Button llenarCli = new Button();
        private DataGridView datos = new DataGridView();
        private Label labelAdd = new Label();
        private Label labelDel = new Label();
        private int cont;
        private int numero;
        private int numeroVenta;
        private string totalAnt;
        private int band;

        #region Get y Set de textbox
        public int Band
        {
            get { return band; }
            set { band = value; }
        }
        public Label LabelAdd
        {
            get { return labelAdd; }
            set { labelAdd = value; }
        }
        public Label LabelDel
        {
            get { return labelDel; }
            set { labelDel = value; }
        }
        public int NumeroVenta
        {
            get { return numeroVenta; }
            set { numeroVenta = value; }
        }
        public TextBox Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public TextBox Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public TextBox Telf
        {
            get { return telf; }
            set { telf = value; }
        }
        public TextBox Direc
        {
            get { return direc; }
            set { direc = value; }
        }
        public TextBox FechaR
        {
            get { return fechaR; }
            set { fechaR = value; }
        }

        public TextBox SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }
        public TextBox Total
        {
            get { return total; }
            set { total = value; }
        }
        public TextBox IVA
        {
            get { return iva; }
            set { iva = value; }
        }
        public int Cont
        {
            get { return cont; }
            set { cont = value; }
        }
        public Button LlenarCli
        {
            get { return llenarCli; }
            set { llenarCli = value; }
        }
        public DataGridView Datos
        {
            get { return datos; }
            set { datos = value; }
        }
        #endregion
        public VentasCRUD()
        {
            InitializeComponent();
            //Cargar datos cuando se busca desde VentasBuscar
            cedula = txt_CIVen;
            cliente = txt_CliVen;
            telf = txt_TelfVen;
            direc = txt_DirecVen;
            datos = dvgVenta;
            llenarCli = btnBuscarCliente;
            fechaR = txt_Fecha;
            labelAdd = label1;
            labelDel = label2;
            numero = Clases.Compra.numero_Compra();
            numeroVenta = numero;
            btnRegistrarVenta.Enabled = false;

        }

        private void VentasCRUD_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
        
 

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BuscarProducto objBP = new BuscarProducto();
            Clases.Compra comp = new Clases.Compra();
            int auxiliar = dvgVenta.RowCount;
            //float valor = 0, iva = 0;
            label1.Enabled = false;
            label2.Enabled = false;
            if (dvgVenta.RowCount == 0)
            {
                comp.IVA = 0;
                comp.Total = 0;
                comp.Valor = 0;
            }
            if (dvgVenta.RowCount > 1)
            {
                dvgVenta.FirstDisplayedScrollingRowIndex = dvgVenta.RowCount - 1;
                //dvgVenta.Rows[dvgVenta.RowCount - 1].Select = true;
                //int indiceUltimaFila = this.dvgVenta.Rows.Count - 1;
                //DataGridViewRow row2 = this.dvgVenta.Rows[indiceUltimaFila];
            }
            if (txt_CliVen.Text != "" && txt_Fecha.Text != "" && txt_CIVen.Text != "" && txt_TelfVen.Text != "" && txt_DirecVen.Text != "")
            {
                objBP.Show();
                objBP.VentasP = this;
                dvgVenta.Rows.Add(1);
                btnRegistrarVenta.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos del cliente primero", "Caja de información");
            }
        }

        private void grbDatosCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txt_CIVen.Text = "";
            txt_CliVen.Text = "";
            txt_Fecha.Text = "";
            txt_TelfVen.Text = "";
            txt_DirecVen.Text = "";
            dvgVenta.Rows.Clear();
        }

        private void btnCancelVen_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }

        //Ingresar clientes en el formulario
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            int aux = 0;
            Cliente cli = new Cliente();
            if (txt_CIVen.Text == "")
            {
                MessageBox.Show("Ingrese la Cédula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (val.VerificarCedula(txt_CIVen.Text) == false || (txt_CIVen.Text == "1212121212" || txt_CIVen.Text == "1616161616" || txt_CIVen.Text == "1818181818" ||
                    txt_CIVen.Text == "0606060606" || txt_CIVen.Text == "1010101010" || txt_CIVen.Text == "2020202020" ||
                    txt_CIVen.Text == "0404040404" || txt_CIVen.Text == "0808080808"))
            {
                MessageBox.Show("Cédula Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_CIVen.Text = "";
            }
            else
            {
                cli = Clases.Compra.Buscar_Cliente_Venta(txt_CIVen.Text);
                aux = Clases.Compra.Verificar_Cliente_Venta(txt_CIVen.Text);

            }
            if (aux == 1)
            {
                DialogResult result = MessageBox.Show("Cliente encontrado", "Caja de información", MessageBoxButtons.OK);
                switch (result)
                {
                    case DialogResult.OK:
                        txt_CliVen.Text = cli.CliNombres + " " + cli.CliApellidoPaterno;
                        txt_TelfVen.Text = cli.CliTelCelular;
                        txt_DirecVen.Text = cli.CliDireccion;
                        txt_Fecha.Text = DateTime.Now.ToString("d");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
                txt_CIVen.Text = "";
                txt_CIVen.Focus();
            }

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            BuscarProducto objBP = new BuscarProducto();
            Clases.Compra comp = new Clases.Compra();
            int auxiliar = dvgVenta.RowCount;
            //float valor = 0, iva = 0;
            label1.Enabled = false;
            label2.Enabled = false;
            if (dvgVenta.RowCount == 0)
            {
                comp.IVA = 0;
                comp.Total = 0;
                comp.Valor = 0;
            }
            if (dvgVenta.RowCount > 1)
            {
                dvgVenta.FirstDisplayedScrollingRowIndex = dvgVenta.RowCount - 1;
                //dvgVenta.Rows[dvgVenta.RowCount - 1].Select = true;
                //int indiceUltimaFila = this.dvgVenta.Rows.Count - 1;
                //DataGridViewRow row2 = this.dvgVenta.Rows[indiceUltimaFila];
            }
            if (txt_CliVen.Text != "" && txt_Fecha.Text != "" && txt_CIVen.Text != "" && txt_TelfVen.Text != "" && txt_DirecVen.Text != "")
            {
                objBP.Show();
                objBP.VentasP = this;
                dvgVenta.Rows.Add(1);
                btnRegistrarVenta.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe ingresar los datos del cliente primero", "Caja de información");
            }
        }

        private void btnRegistrarVenta_Click_1(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            DateTime fecha = Convert.ToDateTime(txt_Fecha.Text);
            int auxiliar = dvgVenta.RowCount;
            String codigo = "";
            String comNumFicha = "";
            String numeroVen = "";
            float total = 0F;
            int numVen = 0;
            numVen = Clases.Compra.numero_Compra();
            numeroVen = numVen.ToString();
            int codigovent = 0;
            Clases.Compra.totalP(total);
            numero = Clases.Compra.numero_Compra();
            numero = numero + 1;
            numeroVen = numero.ToString();
            if (dvgVenta.Rows.Count != 0)
            {
                a = Clases.Compra.registrarCompra(numeroVen, txt_CIVen.Text, comNumFicha, total, fecha);
                for (int i = 0; i < (auxiliar); i++)
                {
                    codigo = dvgVenta.Rows[i].Cells[0].Value.ToString();
                    codigovent = int.Parse(codigo);
                }
                b = Clases.Compra.productoCompra(codigovent, numero.ToString());
                if (a == 1 && b == 1)
                {
                    MessageBox.Show("Se ha registrado correctamente su compra");
                    Limpiar();
                }
            }
        }



        private void btnCancelVen_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            this.Close();
        }
    }
}

