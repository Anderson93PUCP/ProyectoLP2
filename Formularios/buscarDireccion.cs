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
    public partial class buscarDireccion : Form
    {
        public buscarDireccion()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelarBuscarDire_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAcpetarBuscDire_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
