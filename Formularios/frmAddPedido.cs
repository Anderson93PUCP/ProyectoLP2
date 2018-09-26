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
        public frmAddPedido()
        {
            InitializeComponent();
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
            confCancelarAddPedido v = new confCancelarAddPedido();
            v.ShowDialog();

        }

        private void btnAceptarAddPedido_Click(object sender, EventArgs e)
        {
            confirmacionAceptarAddPedido v = new confirmacionAceptarAddPedido();
            v.ShowDialog();
        }

        private void btnBuscarCliAddPedido_Click(object sender, EventArgs e)
        {
            buscarCliente v = new buscarCliente();
            v.ShowDialog();

        }

        private void btnBuscarDireAddPedido_Click(object sender, EventArgs e)
        {
            buscarTransportista ventana = new buscarTransportista();
            ventana.ShowDialog();
        }

        private void btnBuscarTransAddPedido_Click(object sender, EventArgs e)
        {
            buscarTransportista ventana = new buscarTransportista();
            ventana.ShowDialog();
        }

        private void btnAddDetPedido_Click(object sender, EventArgs e)
        {
            detallePedido v = new detallePedido();
            v.ShowDialog();

        }
    }
}
