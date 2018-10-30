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
    public partial class frmAddPedido : Form
    {
        private Cliente cliente;
        private Transportista transporte;
        private Direccion direccion;
        private Transportista transporteSeleccionado;
        private BindingList<DetallePedido> listaDetPedido;
        private Pedido pedidoRegistrar;
        private Pedido pedidoMod;
        private double montoTotal;
        private int esModificar;


        public Pedido PedidoRegistrar { get => pedidoRegistrar; set => pedidoRegistrar = value; }

        public frmAddPedido(Pedido pedidoAModificar)
        {
            
            cliente = null;
            direccion = null;
            transporteSeleccionado = null;

            InitializeComponent();
            pedidoRegistrar = new Pedido();
            pedidoMod = new Pedido();//
            pedidoMod = pedidoAModificar;
            pedidoRegistrar = pedidoAModificar;
            btnAceptarAddPedido.Text = "Modificar";
            cbEstadoPedido.Visible = true;
            txtClienteAddPedido.Text = pedidoAModificar.Cliente.Nombre;
            txtDireccAddPedido.Text = pedidoAModificar.Direccion.DetalleDireccion;
            txtTransAddPedido.Text = pedidoAModificar.Transportista.Nombre;
            txtVendedor.Text = pedidoAModificar.NombreVendedor;
            //cbEstadoPedido.DataSource = Enum.GetValues(typeof(EtapaPedido));
            cbEstadoPedido.SelectedValue = EtapaPedido.pendiente;
            // se tiene q cargar el detalle pedido
            dgvAddPedido.AutoGenerateColumns = false;
            listaDetPedido = new BindingList<DetallePedido>();
            montoTotal = 0;
            esModificar = 1;
            PedidoBL p = new PedidoBL();
            listaDetPedido = p.listarDetalle(pedidoAModificar.IdVenta);
            pedidoRegistrar.DetallesPedido = listaDetPedido;
            dgvAddPedido.DataSource = listaDetPedido;
            
            foreach(DetallePedido det in listaDetPedido)
            {
                montoTotal = montoTotal + ((1 - det.Desc / 100) * (det.Cantidad * det.proPre));
            }
            txtTotalAddPedido.Text = montoTotal.ToString();
            // se va a proceder eliminar de la base de datos
            
        }

        public frmAddPedido()
        {
            InitializeComponent();
            cbEstadoPedido.Visible = false;
            btnBuscarDireAddPedido.Enabled = false;
            dgvAddPedido.AutoGenerateColumns = false;
            listaDetPedido = new BindingList<DetallePedido>();
            montoTotal = 0;
            esModificar = 0;
        }

        private void frmAddPedido_Load(object sender, EventArgs e)
        {
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAddPedido_Click(object sender, EventArgs e)
        {
            var v = MessageBox.Show("¿Esta seguro de salir, no se guardara ningun cambio no guardado", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (v == DialogResult.OK)
            {
                
                this.DialogResult = DialogResult.Cancel;
            }

            //confCancelarAddPedido v = new confCancelarAddPedido();
            //v.ShowDialog();

        }

        private void btnAceptarAddPedido_Click(object sender, EventArgs e)
        {
            
            // confirmacionAceptarAddPedido v = new confirmacionAceptarAddPedido();
            //v.ShowDialog();
            var v = MessageBox.Show("¿Desea agregar el pedido?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (v == DialogResult.OK)
            {
                if (esModificar == 1)
                {
                    PedidoBL pAux = new PedidoBL();
                    pAux.eliminarPedido(pedidoMod.IdVenta);
                    if(cliente != null) pedidoRegistrar.Cliente = cliente;
                    if(transporteSeleccionado != null) pedidoRegistrar.Transportista = transporteSeleccionado;
                    if (direccion != null) pedidoRegistrar.Direccion = direccion;
                    pedidoRegistrar.DetallesPedido = listaDetPedido;
                    
                    PedidoBL pedidoBL = new PedidoBL();
                    pedidoBL.agregarPedido(pedidoRegistrar);
                    // se agrega a la base de datos
                    MessageBox.Show("Se agrego correctamente", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pedidoRegistrar = new Pedido();

                    pedidoRegistrar.Cliente = cliente;
                    pedidoRegistrar.Transportista = transporteSeleccionado;
                    pedidoRegistrar.DetallesPedido = listaDetPedido;
                    pedidoRegistrar.Direccion = direccion;
                    PedidoBL pedidoBL = new PedidoBL();
                    pedidoBL.agregarPedido(pedidoRegistrar);
                    // se agrega a la base de datos
                    MessageBox.Show("Se agrego correctamente", "HECHO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DialogResult = DialogResult.OK;

            }
            
            //Close();
        }

        private void btnBuscarCliAddPedido_Click(object sender, EventArgs e)
        {
            buscarCliente v = new buscarCliente();
            cliente = new Cliente();
            if  (v.ShowDialog() == DialogResult.OK)
            {
                cliente = v.ClienteSeleccionado;
                txtClienteAddPedido.Text = v.ClienteSeleccionado.Nombre;
                txtVendedor.Text = cliente.Vendedor.Nombre + " "+cliente.Vendedor.Apellido;
                btnBuscarDireAddPedido.Enabled = true;
            }
            

        }

        private void btnBuscarDireAddPedido_Click(object sender, EventArgs e)
        {
            buscarDireccion ventana = new buscarDireccion(cliente.Id);
            if (ventana.ShowDialog() == DialogResult.OK)
            {
                direccion = new Direccion();
                direccion = ventana.DireccionSeleccionada;
                txtDireccAddPedido.Text = direccion.DetalleDireccion;
            }
        }

        private void btnBuscarTransAddPedido_Click(object sender, EventArgs e)
        {
            buscarTransportista ventana = new buscarTransportista();
            if(ventana.ShowDialog() == DialogResult.OK)
            {
                transporteSeleccionado = new Transportista();
                
                transporteSeleccionado = ventana.TransSeleccionado;
                txtTransAddPedido.Text = transporteSeleccionado.Nombre;

            }
        }

        private void btnAddDetPedido_Click(object sender, EventArgs e)
        {
            
            detallePedido v = new detallePedido();
            if(v.ShowDialog()  == DialogResult.OK)
            {
                int repetido = 0;
                foreach(DetallePedido d in listaDetPedido)
                {
                    if(d.proCod == v.DetPed.proCod)
                    {
                        d.Cantidad = d.Cantidad + v.DetPed.Cantidad;
                        d.Subtotal = d.Subtotal + v.DetPed.Subtotal;
                        repetido = 1;
                    }
                }
                // ver cuando ingresar producto dos veces pero con descuentos diferentes
                if(repetido == 0)
                {
                    listaDetPedido.Add(v.DetPed);
                }
                
                
                dgvAddPedido.DataSource = null;
                dgvAddPedido.DataSource = listaDetPedido;
                montoTotal = montoTotal + v.DetPed.Subtotal;
                txtTotalAddPedido.Text = montoTotal.ToString();
            }

        }

        private void btnElimDetPedido_Click(object sender, EventArgs e)
        {
            var v = MessageBox.Show("¿Seguro desee eliminar el producto", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(v == DialogResult.OK)
            {
                DetallePedido detPedidoEliminar = (DetallePedido)dgvAddPedido.CurrentRow.DataBoundItem;
                listaDetPedido.Remove(detPedidoEliminar);
                dgvAddPedido.DataSource = listaDetPedido;
                montoTotal = montoTotal - detPedidoEliminar.Subtotal;
                txtTotalAddPedido.Text = montoTotal.ToString();
            }
            //confirmarEliminarPedido v = new confirmarEliminarPedido();
            //v.ShowDialog();
        }

        private void btnModDetPedido_Click(object sender, EventArgs e)
        {
            DetallePedido d = new DetallePedido();
            int pos = dgvAddPedido.CurrentRow.Index;
            // dgvAddPedido.CurrentRow.ReadOnly = false;
            d = (DetallePedido)dgvAddPedido.CurrentRow.DataBoundItem;
            detallePedido v = new detallePedido(d);
            montoTotal = montoTotal - d.Subtotal;
            if (v.ShowDialog() == DialogResult.OK)
            {
                //montoTotal = montoTotal - d.Subtotal;
                if (!(d.proCod.Equals(v.DetPed.proCod)))
                {
                    d.Producto = v.DetPed.Producto;
                }
                d.Desc = v.DetPed.Desc;
                d.Cantidad = v.DetPed.Cantidad;
                // se modifico el mismo producto cantidad y/o descuentos
                d.Subtotal = v.DetPed.Subtotal;

                listaDetPedido[pos] = d;
                dgvAddPedido.DataSource = null;
                dgvAddPedido.DataSource = listaDetPedido;
                montoTotal = montoTotal + v.DetPed.Subtotal;
                
                txtTotalAddPedido.Text = montoTotal.ToString();
            }
            else
            {
                montoTotal = montoTotal + d.Subtotal;
            }
        }

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
