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
    public partial class modificarPedido : Form
    {
        public modificarPedido()
        {
            InitializeComponent();
        }

        private void btnBuscarCliModPedido_Click(object sender, EventArgs e)
        {
            buscarCliente v = new buscarCliente();
            v.ShowDialog();

        }

        private void btnBuscarDireModPedido_Click(object sender, EventArgs e)
        {
            buscarDireccion v = new buscarDireccion();
            v.ShowDialog();

        }

        private void btnBuscarTransModPedido_Click(object sender, EventArgs e)
        {
            buscarTransportista v = new buscarTransportista();
            v.ShowDialog();

        }

        private void btnCancelarModPedido_Click(object sender, EventArgs e)
        {
            confCancelarAddPedido v = new confCancelarAddPedido();
            v.ShowDialog();
            Close();
        }

        private void btnAceptarModPedido_Click(object sender, EventArgs e)
        {
            confirmacionAceptarAddPedido v = new confirmacionAceptarAddPedido();
            v.ShowDialog();
            Close();
        }

        private void btnAddModDetPed_Click(object sender, EventArgs e)
        {
            detallePedido v = new detallePedido();
            v.ShowDialog();
        }

        private void btnModModDetPedido_Click(object sender, EventArgs e)
        {
            detallePedido v = new detallePedido();
            v.ShowDialog();
        }

        private void btnElimModDetPedido_Click(object sender, EventArgs e)
        {
            confirmarEliminarPedido v = new confirmarEliminarPedido();
            v.ShowDialog();
        }
    }
}
