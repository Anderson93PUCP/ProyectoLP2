using LogicaNegocio;
using ProyectoLP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{

    public partial class GestionClientes : Form
    {
        ClienteBL clienteBL;
        Cliente cliente;
        public GestionClientes()
        {
            InitializeComponent();
            cargarClientes();
            
        }

        private void ModificarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargarClientes();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente aclientes = new AgregarCliente();

            aclientes.FormClosed += new System.Windows.Forms.FormClosedEventHandler(AgregarCliente_FormClosed);
            if (aclientes.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void AgregarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {

            cargarClientes();

        }


        private void cargarClientes()
        {
            clienteBL = new ClienteBL();
            BindingList<Cliente> clientes = new BindingList<Cliente>();
            clientes = clienteBL.listarCliente();
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = clientes;
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {

            cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            ModificarCliente aclientes = new ModificarCliente(cliente);
            aclientes.FormClosed += new System.Windows.Forms.FormClosedEventHandler(AgregarCliente_FormClosed);
            if (aclientes.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnElimCliente_Click(object sender, EventArgs e)
        {
            //confirmarElimCliente eclientes = new confirmarElimCliente();
            //if (eclientes.ShowDialog() == DialogResult.OK)
            //{
            int id = 0;
            //}
            if (MessageBox.Show("Esta seguro que desea eliminar el Cliente", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                 id= Convert.ToInt32(dgvClientes.Rows[dgvClientes.CurrentRow.Index].Cells[0].Value);
                if (clienteBL.eliminarCliente(id))
                {
                     clienteBL.eliminarDirecciones(id);
                    MessageBox.Show("Se elimino el Cliente satisfactoriamente");
                    cargarClientes();
                }else
                {
                    MessageBox.Show("No se pudo eliminar el cliente");
                }
                // user clicked yes
            }
            else
            {
                // user clicked no
            }
        }

        private void btnBusquedaClientes_Click(object sender, EventArgs e)
        {
            string rucCliente = "";
            string filtro = txtBusqClientes.Text.Trim();
            if(rbtnBusqRucCLiente.Checked)
            {
                if (filtro != "")
                {
                    rucCliente = txtBusqClientes.Text;
                    rucCliente = rucCliente.Trim();
                    clienteBL = new ClienteBL();
                    BindingList<Cliente> clientes = new BindingList<Cliente>();
                    clientes = clienteBL.listarCliente(rucCliente);//Sobrecarga
                    dgvClientes.AutoGenerateColumns = false;
                    dgvClientes.DataSource = clientes;
                }
                else cargarClientes();
            }
        }

        private void rbtnBusqRucCLiente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBusqRucCLiente.Checked)
            {
                txtBusqClientes.Enabled = true;
                btnBusquedaClientes.Enabled = true;
            }else
            {
                txtBusqClientes.Enabled = false;
                btnBusquedaClientes.Enabled = false;
            }
        }
    }
}
