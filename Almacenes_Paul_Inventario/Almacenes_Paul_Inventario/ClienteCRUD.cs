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
    public partial class ClienteCRUD : Form
    {
        private Cliente objCliente;
        public ClienteCRUD()
        {
            InitializeComponent();
            objCliente = new Cliente();
        }

        private void ClienteCRUD_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CUCliente cUCliente = new CUCliente(1,null);
            cUCliente.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            //Si existen los parametros adecuados realizamos la busqueda
            if (true)
            {
                //Si encuentra el cliente mandar mensajes y recuperar datos
                if (objCliente.buscarCliente(dataGridView1,txtBusqueda.Text) == 1)
                {
                    FormatearTabla();
                }
            }
            else
            {
                MessageBox.Show("Debe llenar con campos validos la Cédula o el apellido del cliente" +
                    " que desea buscar","Aviso");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String[] datosAnteriores=new String[8];
            if (dataGridView1.RowCount!=0)
            {
                datosAnteriores = obtenerDatos();
                CUCliente cUCliente = new CUCliente(2, datosAnteriores);
                cUCliente.ShowDialog();

            }
            else
            {
                MessageBox.Show("Debe de seleccionar un registro de la tabla para poder modificar.", "Aviso");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Verifica que se seleccione un registro para ser borrado
            if (dataGridView1.RowCount != 0)
            {
                //Recopilacion de la cédula del cliente a eliminar
                objCliente.CliCedula = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //Llamar al metodo que permite borrar al cliente
                if (objCliente.EliminarCliente()==1)
                {
                    MessageBox.Show("Se a eliminado correctamente el usuario", "Operacion");
                    btnBuscar_Click(null,null);
                }
                else
                {
                    MessageBox.Show("No se a podido eliminar el usuario actual", "Operacion");
                }
                
            }
            else
            {
                MessageBox.Show("Es necesario que se seleccione un registro de la tabla para proceder a borrar.","Aviso");
            }

        }



        #region METODOS
 
        private void FormatearTabla()
        {
            dataGridView1.Columns[0].Width = 300;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 600;
        }

        /// <summary>
        /// Método que permite recuperar los datos de la celda seleccionada
        /// </summary>
        /// <returns>Retorna un arreglo de string[8] con todos los datos</returns>
        private string[] obtenerDatos()
        {

            String[] datosAnteriores = new String[8];
            datosAnteriores[0] = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            datosAnteriores[1] = dataGridView1.CurrentRow.Cells[1].Value.ToString().Split(' ')[0];
            try
            {
                datosAnteriores[2] = dataGridView1.CurrentRow.Cells[1].Value.ToString().Split(' ')[1];
            }
            catch (Exception)
            {
                datosAnteriores[2] = "";
            }


            datosAnteriores[3] = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            datosAnteriores[4] = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            datosAnteriores[5] = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            datosAnteriores[6] = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            datosAnteriores[7] = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            return datosAnteriores;
        }

        #endregion


    }
}
