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
    public partial class buscarCliente : Form
    {
        private Cliente clienteSeleccionado;
        private BindingList<Cliente> lista;

        public Cliente ClienteSeleccionado { get => clienteSeleccionado; set => clienteSeleccionado = value; }
        public BindingList<Cliente> Lista { get => lista; set => lista = value; }

        public buscarCliente()
        {
            InitializeComponent();
            ClienteBL c = new ClienteBL();
            lista = new BindingList<Cliente>();
            lista = c.listarCliente();
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = lista;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Close();
            this.DialogResult = DialogResult.No ;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Close();
            
            clienteSeleccionado = new Cliente();
            clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text == "") dgvClientes.DataSource = lista;
            else
            {

                BindingList<Cliente> listaBusq = new BindingList<Cliente>();
                String criterio;
                if (rbtnBusqRuc.Checked == true)
                {
                    criterio = txtBuscarCliente.Text;
                    foreach (Cliente c in lista)
                    {
                        if (c.Ruc.Contains(criterio))
                        {
                            Cliente aux = new Cliente();
                            aux = c;
                            listaBusq.Add(aux);
                        }
                    }
                    dgvClientes.DataSource = listaBusq;
                }

                if (rbtnNombre.Checked == true)
                {
                    criterio = txtBuscarCliente.Text;
                    foreach (Cliente c in lista)
                    {
                        if (c.Nombre.Contains(criterio))
                        {
                            Cliente aux = new Cliente();
                            aux = c;
                            listaBusq.Add(aux);
                        }
                    }
                    dgvClientes.DataSource = listaBusq;

                }
                
            }
        }
    }
}
