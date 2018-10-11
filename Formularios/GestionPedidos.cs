using LogicaNegocio;
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
    public partial class GestionPedidos : Form
    {
        private BindingList<Pedido> listaPedidosRegistrados;
        public GestionPedidos()
        {
            InitializeComponent();
            listaPedidosRegistrados = new BindingList<Pedido>();
            dgvPedidos.AutoGenerateColumns = false;
            PedidoBL p = new PedidoBL();
            listaPedidosRegistrados = p.listarPedidos();
            dgvPedidos.DataSource = listaPedidosRegistrados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             frmAddPedido ventaAddPedio = new frmAddPedido();
            if (ventaAddPedio.ShowDialog() == DialogResult.Cancel)
            {
                //Pedido pedidoAgregado = ventaAddPedio.PedidoRegistrar;
                //listaPedidosRegistrados.Add(pedidoAgregado);
                dgvPedidos.DataSource = null;
                PedidoBL p = new PedidoBL();
                listaPedidosRegistrados = p.listarPedidos();
                dgvPedidos.DataSource = listaPedidosRegistrados;
            }
           // AgregarPedido ventanaAgregarpedido = new AgregarPedido();
            //this.Hide();
            //ventanaAgregarpedido.ShowDialog();
            
            //this.ShowDialog(); // esto si tenog dudas bueno de casi todo xd 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBusqPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnElimPedido_Click(object sender, EventArgs e)
        {
            //confirmarEliminarPedido v = new confirmarEliminarPedido();
            //v.ShowDialog();
            var v = MessageBox.Show("¿Desea eliminar el pedido?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (v == DialogResult.OK)
            {
                // elimina la la fila seleccionada
            }
            // se actualiza la tabla 
        }

        private void btnModPedido_Click(object sender, EventArgs e)
        {
            modificarPedido ventana = new modificarPedido();
            ventana.ShowDialog();
        }

        private void GestionPedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            verPedido ventana = new verPedido();
            ventana.ShowDialog();
        }
    }
}
