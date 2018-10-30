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
            if (ventaAddPedio.ShowDialog() == DialogResult.OK)
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
                Pedido pedidoAEliminar = (Pedido)dgvPedidos.CurrentRow.DataBoundItem;
                if(pedidoAEliminar.Etapa == EtapaPedido.pendiente)
                {
                    PedidoBL p = new PedidoBL();
                    p.eliminarPedido(pedidoAEliminar.IdVenta); // se elimino en la base de datos
                    listaPedidosRegistrados.Remove(pedidoAEliminar);
                    dgvPedidos.Refresh();
                }
                
                
            }
            // se actualiza la tabla 
        }

        private void btnModPedido_Click(object sender, EventArgs e)
        {
            Pedido pedidoAModificar = new Pedido();
            pedidoAModificar = (Pedido)dgvPedidos.CurrentRow.DataBoundItem;
            frmAddPedido ventana = new frmAddPedido(pedidoAModificar);
            if(ventana.ShowDialog() == DialogResult.OK)
            {
                /*
                listaPedidosRegistrados.Remove(pedidoAModificar);
                listaPedidosRegistrados.Add(ventana.PedidoRegistrar);
                dgvPedidos.Update();
                dgvPedidos.Refresh();*/
                PedidoBL p = new PedidoBL();
                listaPedidosRegistrados = p.listarPedidos();
                dgvPedidos.DataSource = listaPedidosRegistrados;
            }
            
            
        }

        private void GestionPedidos_Load(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            verPedido ventana = new verPedido((Pedido)dgvPedidos.CurrentRow.DataBoundItem);

            ventana.ShowDialog();
        }

        private void rbtnBusqRuc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBusquedaPedido_Click(object sender, EventArgs e)
        {
            if(txtBusqPedido.Text == "")
            {
                dgvPedidos.DataSource = listaPedidosRegistrados;
            }
            else
            {
                BindingList<Pedido> listaBusqueda = new BindingList<Pedido>();
                String criterio;
                criterio = txtBusqPedido.Text;
                if (rbtnBusqRuc.Checked == true)
                {
                    
                    foreach(Pedido p in listaPedidosRegistrados)
                    {
                        if (p.ClienteRUC.Contains(criterio))
                        {
                            Pedido aux = new Pedido();
                            aux = p;
                            listaBusqueda.Add(p);
                        }
                    }
                    dgvPedidos.DataSource = listaBusqueda;
                }
                if(rbtnRazonSocial.Checked == true)
                {
                    foreach(Pedido p in listaPedidosRegistrados)
                    {
                        if (p.Cliente.Nombre.Contains(criterio))
                        {
                            Pedido aux = new Pedido();
                            aux = p;
                            listaBusqueda.Add(p);
                        }
                    }
                    dgvPedidos.DataSource = listaBusqueda;
                }
                if(rbtnVendedor.Checked == true)
                {
                    foreach(Pedido p in listaPedidosRegistrados)
                    {
                        if (p.Vendedor.Nombre.Contains(criterio))
                        {
                            Pedido aux = new Pedido();
                            aux = p;
                            listaBusqueda.Add(p);
                        }
                    }
                    dgvPedidos.DataSource = listaBusqueda;
                }
            }
        }
    }
}
