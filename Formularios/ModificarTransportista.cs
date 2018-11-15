using LogicaNegocio;
using ProyectoLP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class ModificarTransportista : Form
    {
        TransportistaBL transportistaBL;
        Transportista transportista;
        public ModificarTransportista()
        {
            InitializeComponent();
            validarCampos();
        }

        public ModificarTransportista(Transportista t)
        {
            InitializeComponent();
            transportista = new Transportista();
            transportista = t;
            llenarCampos(t);

        }

        public void llenarCampos(Transportista t)
        {
            txtdireccion.Text = t.Direccion;
            txtruc.Text = t.Ruc;
            txtrazon.Text = t.Nombre;
            txtEmail.Text = t.Email;
            txttelf.Text = t.Telefono.ToString();
            if (t.Alcance == Alcance.nacional) rbtNacional.Checked=true;
            else rbtDepartamentos.Checked = true;
        }


        private void btnaceptar_Click(object sender, EventArgs e)
        {
            transportistaBL = new TransportistaBL();
            int r, n, te, d, em;
            r = Regexp(@"^[0-9]+$", txtruc, pbrucmod);
            n = Regexp(@"^[a-zA-Z\s]+$", txtrazon, pbnombremod);
            te = Regexp(@"^[0-9]+$", txttelf, pbtelefonomod);
            d = Regexp(@"^[a-zA-Z0-9_\s]+$", txtdireccion, pbdirecmod);
            em = Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", txtEmail, pbemailmod);
            int valor = r * n * te * d * em;
            if (valor == 0) return;
            //if (txtruc.Text == "")
            //{
            //    MessageBox.Show("Por favor ingrese un ruc.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //if (txtrazon.Text == "")
            //{
            //    MessageBox.Show("Por favor ingrese un nombre.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //if (txttelf.Text == "")
            //{
            //    MessageBox.Show("Por favor ingrese un telefono.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //if (txtdireccion.Text == "")
            //{
            //    MessageBox.Show("Por favor ingrese una direccion.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //if (txtEmail.Text == "")
            //{
            //    MessageBox.Show("Por favor ingrese un email.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            if (!rbtNacional.Checked & !rbtDepartamentos.Checked)
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
            t.Id = transportista.Id;
            t.Ruc = txtruc.Text;
            t.Nombre = txtrazon.Text.ToUpper();
            t.Telefono = Int32.Parse(txttelf.Text);
            t.Direccion = txtdireccion.Text;
            t.Email = txtEmail.Text;
            if (rbtNacional.Checked) t.Alcance = Alcance.nacional;
            else t.Alcance = Alcance.porDepartamentos;
            if (transportistaBL.modificarTransportista(t))
            MessageBox.Show("El transportista se modifico satisfactoriamente",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("El transportista no se modifico",
               "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //limpiarCamposCliente();
            this.Dispose();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            txtruc.Enabled = true;
            txtrazon.Enabled = true;
            txttelf.Enabled = true;
            txtEmail.Enabled = true;
            txtdireccion.Enabled = true;
            rbtDepartamentos.Enabled = true;
            rbtNacional.Enabled = true;
            btnaceptar.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public int Regexp(string re, TextBox tb, PictureBox pc)
        {
            Regex regex = new Regex(re);

            if (regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.check;
                return 1;
            }
            else
            {
                pc.Image = Properties.Resources.cross;
                return 0;
            }
        }

        public void validarCampos()
        {
            ToolTip r1 = new ToolTip();
            r1.SetToolTip(pbrucmod, "Ingrese un ruc de 11 digitos");
            r1.SetToolTip(pbnombremod, "Ingrese un nombre");
            r1.SetToolTip(pbtelefonomod, "Ingrese un numero telefonico valido");
            r1.SetToolTip(pbdirecmod, "Ingrese una direccion valida");
            r1.SetToolTip(pbemailmod, "Ingrese un correo valido");
        }
    }
}
