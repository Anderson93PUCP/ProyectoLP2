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
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente aclientes = new AgregarCliente();
            if (aclientes.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }
    }
}
