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
    public partial class verFactura : Form
    {
        public verFactura()
        {
            InitializeComponent();
        }
        public verFactura(Factura facturaVer)
        {
            InitializeComponent();
            txtCliente.Text = facturaVer.Pedido.ClienteNombre;
            txtDireccion.Text = facturaVer.Pedido.Direccion.DetalleDireccion;
            txtImpuesto.Text = facturaVer.Total_imp.ToString();
            txtTotal.Text = facturaVer.Neto_pagar.ToString();
            txtValorVenta.Text = facturaVer.Valor_neto.ToString();
            txtVendedor.Text = facturaVer.VendedorFactura;
            txtTransporte.Text = facturaVer.Pedido.Transportista.Nombre;
            BindingList<DetallePedido> listaDetalle = new BindingList<DetallePedido>();
            PedidoBL pbl = new PedidoBL();
            listaDetalle = pbl.listarDetalle(facturaVer.Pedido.IdVenta);
            dgwDetalleFactura.AutoGenerateColumns = false;
            dgwDetalleFactura.DataSource = listaDetalle;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
