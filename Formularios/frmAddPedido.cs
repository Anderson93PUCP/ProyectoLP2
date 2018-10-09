using ProyectoLP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmAddPedido : Form
    {
        private Cliente cliente;
        private Transportista transporte;
        private Direccion direccion;
        public frmAddPedido()
        {
            InitializeComponent();
            btnBuscarDireAddPedido.Enabled = false;

        }

        private void frmAddPedido_Load(object sender, EventArgs e)
        {
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAddPedido_Click(object sender, EventArgs e)
        {
            var v = MessageBox.Show("¿Esta seguro de salir, no se guardara ningun cambio no guardado", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (v == DialogResult.OK)
            {
                Close();
            }

            //confCancelarAddPedido v = new confCancelarAddPedido();
            //v.ShowDialog();

        }

        private void btnAceptarAddPedido_Click(object sender, EventArgs e)
        {
            // confirmacionAceptarAddPedido v = new confirmacionAceptarAddPedido();
            //v.ShowDialog();
            var v = MessageBox.Show("¿Desea agregar el pedido?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (v == DialogResult.OK)
            {
                // se agrega a la base de datos
            }
            //Close();
        }

        private void btnBuscarCliAddPedido_Click(object sender, EventArgs e)
        {
            buscarCliente v = new buscarCliente();
            cliente = new Cliente();
            if  (v.ShowDialog() == DialogResult.OK)
            {
                cliente = v.ClienteSeleccionado;
                txtClienteAddPedido.Text = v.ClienteSeleccionado.Nombre;
                txtVendedor.Text = cliente.Dni_vendedor.ToString();
                btnBuscarDireAddPedido.Enabled = true;
            }
            

        }

        private void btnBuscarDireAddPedido_Click(object sender, EventArgs e)
        {
            buscarDireccion ventana = new buscarDireccion(cliente.Id);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                direccion = new Direccion();
                direccion = ventana.DireccionSeleccionada;
                txtDireccAddPedido.Text = direccion.DetalleDireccion;
            }
        }

        private void btnBuscarTransAddPedido_Click(object sender, EventArgs e)
        {
            buscarTransportista ventana = new buscarTransportista();
            if(ventana.ShowDialog() == DialogResult.OK)
            {
                transporte = new Transportista();
                transporte = ventana.TransSeleccionado;
                txtTransAddPedido.Text = transporte.Nombre;

            }
        }

        private void btnAddDetPedido_Click(object sender, EventArgs e)
        {
            detallePedido v = new detallePedido();
            v.ShowDialog();

        }

        private void btnElimDetPedido_Click(object sender, EventArgs e)
        {
            var v = MessageBox.Show("¿Seguro desee eliminar el producto", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(v == DialogResult.OK)
            {
                // se actualiza la tabla ps S
            }
            //confirmarEliminarPedido v = new confirmarEliminarPedido();
            //v.ShowDialog();
        }

        private void btnModDetPedido_Click(object sender, EventArgs e)
        {
                detallePedido v = new detallePedido();
            v.ShowDialog();
        }

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
