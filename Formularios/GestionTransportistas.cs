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
        public GestionTransportistas()
        {
            InitializeComponent();
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
    }
}
