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
    public partial class ModificarCliente : Form
    {
        UsuarioBL usuarioBL;
        ClienteBL clienteBL;
        Cliente cliente;

        BindingList<Direccion> listaDirecciones;
        public ModificarCliente()
        {
            InitializeComponent();

            
        }

        public ModificarCliente(Cliente cl)
        {
            InitializeComponent();
            cliente = new Cliente();
            cliente = cl;
            CargarVendedores();
            llenarCampos(cl);
        }

        private void btnaceptarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                clienteBL = new ClienteBL();
                if (txtrazonCliente.Text == "")
                {
                    MessageBox.Show("Por favor ingrese un nombre.",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                try
                {
                    Int32.Parse(txttelfCliente.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor ingrese el telefono correctamente.",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtemailCliente.Text == "")
                {
                    MessageBox.Show("Por favor ingrese un nombre.",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtrucCliente.Text == "")
                {
                    MessageBox.Show("Por favor ingrese un nombre.",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Cliente a = new Cliente();
                a.Id = cliente.Id;
                a.Nombre = txtrazonCliente.Text.ToUpper();
                a.Ruc = txtrucCliente.Text;
                a.Email = txtemailCliente.Text;
                a.Telefono = Int32.Parse(txttelfCliente.Text);
                a.Dni_vendedor = cmbvendedorCliente.SelectedValue.ToString();
                //int idCliente = clienteBL.registrarCliente(a);
                if (clienteBL.modificarCliente(a))
                {
                    clienteBL.eliminarDirecciones(cliente.Id);
                    int cont = 0;
                    foreach (Direccion d in listaDirecciones)
                    {
                        if (cont == 0)
                        {
                            clienteBL.registrarDireccionesCliente(cliente.Id, d, 1);
                            cont = 1;
                        }
                        else clienteBL.registrarDireccionesCliente(cliente.Id, d, 0);

                    }
                    MessageBox.Show("El cliente se registro satisfactoriamente",
                        "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El cliente no se registro",
                   "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                //limpiarCamposCliente();
                this.Dispose();
            }
            catch { }
        }

        private void btncancelarCliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btndireccionesCliente_Click(object sender, EventArgs e)
        {
            AgregarDirecciones fgd = new AgregarDirecciones();
            if (fgd.ShowDialog() == DialogResult.OK)
            {
                listaDirecciones = fgd.listadirecciones();
            }

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            btnaceptarCliente.Enabled = true;
            txtCelCliente.Enabled = true;
            txtemailCliente.Enabled = true;
            txtrazonCliente.Enabled = true;
            txtrucCliente.Enabled = true;
            txttelfCliente.Enabled = true;
            btndireccionesCliente.Enabled = true;
            cmbvendedorCliente.Enabled = true;
        }


        public void llenarCampos(Cliente cliente)
        {
            txtCelCliente.Text = "";
            txtemailCliente.Text = cliente.Email;
            txtrazonCliente.Text = cliente.Nombre;
            txtrucCliente.Text = cliente.Ruc;
            txttelfCliente.Text = cliente.Telefono.ToString();
            cmbvendedorCliente.SelectedValue = cliente.Dni_vendedor;
        }

        public void CargarVendedores()
        {
            usuarioBL = new UsuarioBL();
            BindingList<Persona> vendedores = new BindingList<Persona>();
            vendedores = usuarioBL.listarVendedores();
            cmbvendedorCliente.ValueMember = "Dni";
            cmbvendedorCliente.DisplayMember = "Nombre";
            cmbvendedorCliente.DataSource = vendedores;
            cmbvendedorCliente.SelectedIndex = -1;

        }
    }
}
