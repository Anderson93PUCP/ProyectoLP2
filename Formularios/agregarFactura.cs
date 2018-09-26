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
        public agregarFactura()
        {
            InitializeComponent();
        }

        private void rbtnRuc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            confirmarCancelarAddFact ventana = new confirmarCancelarAddFact();
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            confirmaAceptarAddFactura ventana = new confirmaAceptarAddFactura();
            ventana.ShowDialog();
        }
    }
}
