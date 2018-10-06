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
        private BindingList<Cliente> clientes;
        public GestionClientes()
        {
            InitializeComponent();
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
            clientes = new BindingList<Cliente>();
            /*
            FileStream fs = new FileStream("clientes.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (true)
            {
                String linea = sr.ReadLine();
                if (linea == null) { break; }
                Cliente a = new Cliente();
                a.Nombre = linea;
                a.Ruc = sr.ReadLine();
                a.Telefono = Int32.Parse(sr.ReadLine());
                a.Email = sr.ReadLine();
                clientes.Add(a);
            }
            sr.Close();
            fs.Close();
            dgvClientes.DataSource = clientes;
            dgvClientes.Columns[0].HeaderText = "ID";
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[5].Visible = false;
            dgvClientes.Columns[1].HeaderText = "NOMBRE";
            dgvClientes.Columns[2].HeaderText = "RUC";
            dgvClientes.Columns[3].HeaderText = "EMAIL";
            dgvClientes.Columns[4].HeaderText = "TELEFONO";
            */
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {
            ModificarCliente aclientes = new ModificarCliente();
            if (aclientes.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnElimCliente_Click(object sender, EventArgs e)
        {
            confirmarElimCliente eclientes = new confirmarElimCliente();
            if (eclientes.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
