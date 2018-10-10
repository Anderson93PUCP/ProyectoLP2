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
    public partial class detallePedido : Form
    {

        private Producto productoSeleccionado;
        public detallePedido()
        {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = false;
            ProductoBL pro = new ProductoBL();
            dgvProductos.DataSource = pro.listarProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarAddDetPedido_Click(object sender, EventArgs e)
        {


            this.DialogResult = DialogResult.OK;

        }

        private void btnCancelarAddDetPedido_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dudCantidadPro_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void detallePedido_Load(object sender, EventArgs e)
        {

        }
    }
}
