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
    public partial class gestorFacturas : Form
    {
        //private Factura facturaSeleccionada;
        private BindingList<Factura> listaFacturas; 
        public gestorFacturas()
        {
            InitializeComponent();
            dgwFacturas.AutoGenerateColumns = false;
            listaFacturas = new BindingList<Factura>();
            FacturaBL fact = new FacturaBL();
            listaFacturas = fact.listarFacturas();
            dgwFacturas.DataSource = listaFacturas;
            rbtnRUC.Checked = true;
        }

        private void btnCancelarFactura_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnElimFactura_Click(object sender, EventArgs e)
        {
            //confirmarElimFactura ventana = new confirmarElimFactura();
            //ventana.ShowDialog();
            Factura facturaAEliminar = new Factura();
            facturaAEliminar = (Factura)dgwFacturas.CurrentRow.DataBoundItem;
            if (facturaAEliminar.EstadoPagoCliente == EstadoPagoCliente.pendiente_de_pago)
            {
                var v = MessageBox.Show("¿Desea eliminar la factura seleccionada?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (v == DialogResult.OK)
                {
                    Factura facturaSeleccionada = new Factura();
                    facturaSeleccionada = (Factura)dgwFacturas.CurrentRow.DataBoundItem;
                    FacturaBL f = new FacturaBL();
                    f.eliminarFactura(facturaSeleccionada);

                    listaFacturas = f.listarFacturas();
                    dgwFacturas.DataSource = listaFacturas;
                }
            }
            else
            {
                MessageBox.Show("La factura ya fue pagada por el cliente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

            // se tiene q actualizar la tabla y tmb el estado del pedido 
        }

        private void btnAddFactura_Click(object sender, EventArgs e)
        {
            agregarFactura ventana = new agregarFactura();
            ventana.ShowDialog();
            FacturaBL fact = new FacturaBL();
            listaFacturas = fact.listarFacturas();
            dgwFacturas.DataSource = listaFacturas;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Factura facturaSeleccionada = new Factura();
            facturaSeleccionada = (Factura)dgwFacturas.CurrentRow.DataBoundItem;
            verFactura ventana = new verFactura(facturaSeleccionada);
            ventana.ShowDialog();
        }

        private void btnPagoCliente_Click(object sender, EventArgs e)
        {
            Factura facturaSeleccionada = new Factura();
            facturaSeleccionada = (Factura)dgwFacturas.CurrentRow.DataBoundItem;
            FacturaBL f = new FacturaBL();
            f.pagoCliente(facturaSeleccionada.IdVenta);
            listaFacturas = f.listarFacturas();
            dgwFacturas.DataSource = listaFacturas;
        }
    }
}
