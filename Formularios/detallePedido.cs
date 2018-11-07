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
        private DetallePedido detPed;
        private BindingList<Producto> listaPro;

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
            dgvProductos.CurrentCell = dgvProductos.Rows[indice].Cells[0];
            dgvProductos.Rows[indice].Selected = true;
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
            if (numCant.Value == 0)
            {
                MessageBox.Show("Ingrese cantidad valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                productoSeleccionado = new Producto();
                productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                if(detPed == null)
                {
                    detPed = new DetallePedido();
                }
                

                detPed.Producto = productoSeleccionado;
                detPed.Cantidad = Int32.Parse(numCant.Value.ToString());
                detPed.Desc = Int32.Parse(numDesc.Value.ToString());
                detPed.Subtotal = (1 - (detPed.Desc / 100)) * (detPed.Cantidad * productoSeleccionado.Precio);


                this.DialogResult = DialogResult.OK;
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
    }
}
