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
using System.Text.RegularExpressions;

namespace Formularios
{
    public partial class detallePedido : Form
    {

        private Producto productoSeleccionado;
        private DetallePedido detPed;
        private BindingList<Producto> listaPro;
        private int agregar_pedido;

        public Producto ProductoSeleccionado { get => productoSeleccionado; set => productoSeleccionado = value; }
        public DetallePedido DetPed { get => detPed; set => detPed = value; }

        public detallePedido()
        {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = false;
            ProductoBL pro = new ProductoBL();
            listaPro = new BindingList<Producto>();
            listaPro = pro.listarProducto();
            dgvProductos.DataSource = listaPro;
            rbtnID.Checked = true;
            agregar_pedido = 0;
        }


        public detallePedido(DetallePedido detModificar)
        {
            InitializeComponent();
            detPed = new DetallePedido();
            detPed = detModificar;
            dgvProductos.AutoGenerateColumns = false;
            ProductoBL pro = new ProductoBL();
            listaPro = new BindingList<Producto>();
            listaPro = pro.listarProducto();
            dgvProductos.DataSource = listaPro;
            rbtnID.Checked = true;
            txtBuscarProducto.Text = detModificar.proCod;
            numCant.Value = detModificar.Cantidad;
            numDesc.Value = (int)detModificar.Desc;
            txtCantidad.Text= detModificar.Cantidad.ToString();
            txtDescuento.Text = detModificar.Desc.ToString();
            //dgvProductos.SelectedRows.Clear();
            int indice = 0;
            foreach (Producto p in listaPro)
            {
                if (p.Codigo.Equals(detModificar.Producto.Codigo)) {
                    break;
                } else indice++;
            }
            /*dataGridView1.CurrentCell = dataGridView1.Rows[2].Cells[0];
            dataGridView1.Rows[2].Selected = true;*/
            dgvProductos.CurrentCell = dgvProductos.Rows[0].Cells[0];
            dgvProductos.Rows[0].Selected = true;
            agregar_pedido = 1;
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
            int cantidad, descuento;
            Int32.TryParse(txtCantidad.Text,out cantidad);
            Int32.TryParse(txtDescuento.Text, out descuento);
            if (txtCantidad.Text == "") numCant.Value = 0;
            if (txtDescuento.Text == "") numDesc.Value = 0;
            try
            {
                numCant.Value = cantidad;
            }catch(Exception exi)
            {
                //MessageBox.Show("Cantidad Invalida");
            }
            
            numDesc.Value = descuento;
            
            if (numCant.Value == 0)
            {
                MessageBox.Show("Ingrese cantidad valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                productoSeleccionado = new Producto();
                try
                {
                    productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                    if (detPed == null)
                    {
                        detPed = new DetallePedido();
                    }

                    /*
                        if (productoSeleccionado.Stock - (int)numCant.Value <0)
                        {
                            MessageBox.Show("Stock insuficiente.Saldo disponible: " + productoSeleccionado.Stock);
                            return;
                        }
                    */
                   
                    detPed.Producto = productoSeleccionado;
                    detPed.Cantidad = Int32.Parse(numCant.Value.ToString());
                    detPed.Desc = Int32.Parse(numDesc.Value.ToString());
                    detPed.Subtotal = (1 - (detPed.Desc / 100)) * (detPed.Cantidad * productoSeleccionado.Precio);
                    this.DialogResult = DialogResult.OK;

                } catch(Exception ex1)
                {
                    MessageBox.Show("Seleccione producto");
                }
            }
           

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscarProducto.Text== "")
            {
                dgvProductos.DataSource = listaPro;
            }
            else
            {
                string criterio = txtBuscarProducto.Text;
                BindingList<Producto> listaBusqueda = new BindingList<Producto>();
                if(rbtnDescp.Checked == true)
                {
                    foreach (Producto p in listaPro)
                    {
                        if (p.Descripcion.Contains(criterio))
                        {
                            Producto proB = new Producto();
                            proB = p;
                            listaBusqueda.Add(proB);
                        }
                    }
                    dgvProductos.DataSource = listaBusqueda;
                }
                if(rbtnID.Checked == true)
                {
                    foreach (Producto p in listaPro)
                    {
                        if (p.Codigo.Contains(criterio))
                        {
                            Producto proB = new Producto();
                            proB = p;
                            listaBusqueda.Add(proB);
                        }
                    }
                    dgvProductos.DataSource = listaBusqueda;
                }
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Text == "")
            {
                dgvProductos.DataSource = listaPro;
            }
            else
            {
                string criterio = txtBuscarProducto.Text;
                BindingList<Producto> listaBusqueda = new BindingList<Producto>();
                if (rbtnDescp.Checked == true)
                {
                    foreach (Producto p in listaPro)
                    {
                        if (p.Descripcion.Contains(criterio))
                        {
                            Producto proB = new Producto();
                            proB = p;
                            listaBusqueda.Add(proB);
                        }
                    }
                    dgvProductos.DataSource = listaBusqueda;
                }
                if (rbtnID.Checked == true)
                {
                    foreach (Producto p in listaPro)
                    {
                        if (p.Codigo.Contains(criterio))
                        {
                            Producto proB = new Producto();
                            proB = p;
                            listaBusqueda.Add(proB);
                        }
                    }
                    dgvProductos.DataSource = listaBusqueda;
                }
            }
        }

        private void numDesc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numCant_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

            int numero;
                if (Int32.TryParse(txtDescuento.Text,out numero))
                {
                if (numero > 15)
                    txtDescuento.ForeColor = Color.Red;
                else
                    txtDescuento.ForeColor = Color.Black;
                }
            
            

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
