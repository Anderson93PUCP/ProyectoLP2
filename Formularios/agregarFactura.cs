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
    
    public partial class agregarFactura : Form
    {
        
        private BindingList<Pedido> listaPedidoAfacturar;
        public agregarFactura()
        {
            InitializeComponent();
            rbtnRuc.Checked = true;
            listaPedidoAfacturar = new BindingList<Pedido>();
            dgwListaPedidos.AutoGenerateColumns = false;
            PedidoBL p = new PedidoBL();
            
            listaPedidoAfacturar = p.listarPedidos(3);
            dgwListaPedidos.DataSource = listaPedidoAfacturar;

        }

        private void rbtnRuc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //confirmarCancelarAddFact ventana = new confirmarCancelarAddFact();
            //ventana.ShowDialog();
            var v = MessageBox.Show("¿Seguro que desea salir?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (v == DialogResult.OK)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //confirmaAceptarAddFactura ventana = new confirmaAceptarAddFactura();
            //ventana.ShowDialog();
            var v = MessageBox.Show("Generar factura del pedido seleccionado", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (v == DialogResult.OK)
            {
                Pedido pedidoSeleccionado = new Pedido();
                try
                {
                    pedidoSeleccionado = (Pedido)dgwListaPedidos.CurrentRow.DataBoundItem;

                    PedidoBL p = new PedidoBL();
                    p.generarFactura(pedidoSeleccionado);
                    DialogResult = DialogResult.OK;
                }
                catch(Exception ex2)
                {
                    MessageBox.Show("Seleccione una factura");
                }

            }
        }

        private void txtbuscarPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if(txtbuscarPedido.Text == "")
            {
                dgwListaPedidos.DataSource = listaPedidoAfacturar;
            }
            else
            {
                BindingList<Pedido> listaBusqueda = new BindingList<Pedido>();
                String criterio;
                criterio = txtbuscarPedido.Text.ToUpper();
                if (rbtnRuc.Checked == true)
                {

                    foreach (Pedido p in listaPedidoAfacturar)
                    {
                        if (p.ClienteRUC.Contains(criterio))
                        {
                            Pedido aux = new Pedido();
                            aux = p;
                            listaBusqueda.Add(p);
                        }
                    }
                    dgwListaPedidos.DataSource = listaBusqueda;
                }
                if (rbtnCliente.Checked == true)
                {
                    foreach (Pedido p in listaPedidoAfacturar)
                    {
                        if (p.Cliente.Nombre.Contains(criterio))
                        {
                            Pedido aux = new Pedido();
                            aux = p;
                            listaBusqueda.Add(p);
                        }
                    }
                    dgwListaPedidos.DataSource = listaBusqueda;
                }
                if (rbtnVendedor.Checked == true)
                {
                    foreach (Pedido p in listaPedidoAfacturar)
                    {
                        if (p.Vendedor.Nombre.Contains(criterio))
                        {
                            Pedido aux = new Pedido();
                            aux = p;
                            listaBusqueda.Add(p);
                        }
                    }
                    dgwListaPedidos.DataSource = listaBusqueda;
                }
            }
        }
    }
}
