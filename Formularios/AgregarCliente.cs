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
    public partial class AgregarCliente : Form
    {
        UsuarioBL usuarioBL;
        ClienteBL clienteBL;
        public AgregarCliente()
        {
            InitializeComponent();
            CargarVendedores();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
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
            a.Nombre = txtrazonCliente.Text;
            a.Ruc = txtrucCliente.Text;
            a.Email = txtemailCliente.Text;
            a.Telefono = Int32.Parse(txttelfCliente.Text);
            a.Dni_vendedor = cmbvendedorCliente.SelectedValue.ToString();
            if (clienteBL.registrarCliente(a))

            MessageBox.Show("El cliente se registro satisfactoriamente",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else {
                MessageBox.Show("El cliente no se registro",
               "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            limpiarCamposCliente();
            //this.Dispose();
        }
        
        public void limpiarCamposCliente()
        {
            txtCelCliente.Clear();
            txtemailCliente.Clear();
            txtrazonCliente.Clear();
            txtrucCliente.Clear();
            txttelfCliente.Clear();
            cmbvendedorCliente.SelectedIndex = -1;
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void lsboxdireccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtxvendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndirecciones_Click(object sender, EventArgs e)
        {
            AgregarDirecciones fgd = new AgregarDirecciones();
            fgd.ShowDialog();
        }

        private void CargarVendedores()
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
