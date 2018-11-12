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
    public partial class AgregarTransportista : Form
    {
        TransportistaBL transportistaBL;
        public AgregarTransportista()
        {
            InitializeComponent();
        }

        private void btndirecciones_Click(object sender, EventArgs e)
        {
            AgregarDirecciones fgd = new AgregarDirecciones();
            fgd.ShowDialog();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            transportistaBL = new TransportistaBL();
            if (txtruc.Text == "")
            {
                MessageBox.Show("Por favor ingrese un ruc.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtrazon.Text == "")
            {
                MessageBox.Show("Por favor ingrese un nombre.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txttelf.Text == "")
            {
                MessageBox.Show("Por favor ingrese un telefono.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtdireccion.Text == "")
            {
                MessageBox.Show("Por favor ingrese una direccion.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtemail.Text == "")
            {
                MessageBox.Show("Por favor ingrese un email.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!rbtnacional.Checked & !rbtdepartamento.Checked )
            {
                MessageBox.Show("Por favor seleccione un alcance",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                Int32.Parse(txttelf.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor ingrese el telefono correcto.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            

            Transportista t = new Transportista();
            t.Ruc = txtruc.Text;
            t.Nombre = txtrazon.Text.ToUpper();
            t.Telefono = Int32.Parse(txttelf.Text);
            t.Direccion = txtdireccion.Text;
            t.Email = txtemail.Text;
            if (rbtnacional.Checked) t.Alcance = Alcance.nacional;
            else t.Alcance = Alcance.porDepartamentos;
            if (transportistaBL.agregarTransportista(t))

                MessageBox.Show("El transportista se registro satisfactoriamente",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("El transportista no se registro",
               "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //limpiarCamposCliente();
            this.Dispose();
        }
    }
}
