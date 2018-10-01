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
        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void btnaceptarCliente_Click(object sender, EventArgs e)
        {
            if (btnaceptarCliente.Text == "Modificar")
            {
                btnaceptarCliente.Text = "Aceptar";
            }else
            {
                MessageBox.Show("El modifico el cliente satifsfactoriamente");
                this.Dispose();
            }
            txtCelCliente.Enabled = true;
            txtemailCliente.Enabled = true;
            txtrazonCliente.Enabled = true;
            txtrucCliente.Enabled = true;
            txttelfCliente.Enabled = true;
            btndireccionesCliente.Enabled = true;
            cmbvendedorCliente.Enabled = true;
        }

        private void btncancelarCliente_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btndireccionesCliente_Click(object sender, EventArgs e)
        {
            AgregarDirecciones fgd = new AgregarDirecciones();
            fgd.ShowDialog();
        }
    }
}
