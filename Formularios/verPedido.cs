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
    public partial class verPedido : Form
    {
        public verPedido(Pedido pedidoAVer)
        {
            InitializeComponent();
            txtClienteVerPedido.Text = pedidoAVer.ClienteNombre;
            txtDireVerPedido.Text = pedidoAVer.Direccion.DetalleDireccion;
            txtVerTransPedido.Text = pedidoAVer.Transportista.Nombre;
            txtVendVerPedido.Text = pedidoAVer.NombreVendedor;
            PedidoBL p = new PedidoBL();
            BindingList<DetallePedido> listaVerPedido = new BindingList<DetallePedido>();
            listaVerPedido = p.listarDetalle(pedidoAVer.IdVenta);
            dgvVerPedido.AutoGenerateColumns = false;
            dgvVerPedido.AllowUserToAddRows = false;
            dgvVerPedido.DataSource = listaVerPedido;
            double montoTotal = 0;
            foreach (DetallePedido det in listaVerPedido)
            {
                montoTotal = montoTotal + ((1 - det.Desc / 100) * (det.Cantidad * det.proPre));
            }
            txtTotalVerPedido.Text = montoTotal.ToString();
        }
        public verPedido()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarVerPedido_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
