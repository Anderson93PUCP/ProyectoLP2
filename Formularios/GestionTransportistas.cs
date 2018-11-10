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
    public partial class GestionTransportistas : Form
    {
        TransportistaBL transportistaBL;
        Transportista transportista;
          
        public GestionTransportistas()
        {
            InitializeComponent();
            cargarTransportistas();
        }

        private void btnagregarTransp_Click(object sender, EventArgs e)
        {
            AgregarTransportista agt = new AgregarTransportista();
            agt.ShowDialog();
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            AgregarTransportista fga = new AgregarTransportista();
            fga.ShowDialog();
        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {
            ModificarTransportista fga = new ModificarTransportista();
            fga.ShowDialog();
        }

        private void cargarTransportistas()
        {
            transportistaBL = new TransportistaBL();
            BindingList<Transportista> transportistas = new BindingList<Transportista>();
            transportistas = transportistaBL.listarTrans();
            dgvTransportistas.AutoGenerateColumns = false;
            dgvTransportistas.DataSource = transportistas;
        }
    }
}
