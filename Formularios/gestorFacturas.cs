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
        private Factura facturaSeleccionada;
        private BindingList<Factura> listaFacturas; 
        public gestorFacturas()
        {
            InitializeComponent();
            dgwFacturas.AutoGenerateColumns = false;
            listaFacturas = new BindingList<Factura>();
            FacturaBL fact = new FacturaBL();
            listaFacturas = fact.listarFacturas();
            dgwFacturas.DataSource = listaFacturas;
        }

        private void btnCancelarFactura_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnElimFactura_Click(object sender, EventArgs e)
        {
            //confirmarElimFactura ventana = new confirmarElimFactura();
            //ventana.ShowDialog();
            var v = MessageBox.Show("¿Desea eliminar la factura seleccionada?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (v == DialogResult.OK)
            {
                // se actualiza la tabla 
            }

            // se tiene q actualizar la tabla y tmb el estado del pedido 
        }

        private void btnAddFactura_Click(object sender, EventArgs e)
        {
            agregarFactura ventana = new agregarFactura();
            ventana.ShowDialog();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            verFactura ventana = new verFactura();
            ventana.ShowDialog();
        }
    }
}
