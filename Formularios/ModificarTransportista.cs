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
    public partial class ModificarTransportista : Form
    {
        public ModificarTransportista()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El modifico el trasnportista satifsfactoriamente");
            this.Dispose();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            txtruc.Enabled = true;
            txtrazon.Enabled = true;
            txttelf.Enabled = true;
            btndirecciones.Enabled = true;
            rbtDepartamentos.Enabled = true;
            rbtNacional.Enabled = true;
        }
    }
}
