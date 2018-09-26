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
    public partial class GestionPedidos : Form
    {
        public GestionPedidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddPedido ventaAddPedio = new frmAddPedido();
            ventaAddPedio.ShowDialog();
           // AgregarPedido ventanaAgregarpedido = new AgregarPedido();
            //this.Hide();
            //ventanaAgregarpedido.ShowDialog();
            
            //this.ShowDialog(); // esto si tenog dudas bueno de casi todo xd 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBusqPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
