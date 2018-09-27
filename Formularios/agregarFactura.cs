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
                Close();
                // se genera una factura y se muestra en la tabla gestor de facturas

            }
        }
    }
}
