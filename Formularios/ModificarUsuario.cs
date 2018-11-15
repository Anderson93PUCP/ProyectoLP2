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
    public partial class ModificarUsuario : Form
    {
        UsuarioBL usuarioBL;
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        public ModificarUsuario(Persona usuario)
        {
            InitializeComponent();
            llenarCampos(usuario);
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            usuarioBL = new UsuarioBL();
            Persona usuario = null;
            int tipo = cmbrol.SelectedIndex;  
            int r, n, n1, te, te1, em, d1;
            r = Regexp(@"^[0-9]+$", txtdni, pbdni);
            n = Regexp(@"^[a-zA-Z\s]+$", txtnombre, pbnombre);
            n1 = Regexp(@"^[a-zA-Z\s]+$", txtapellido, pbapellido);
            te = Regexp(@"^[0-9]+$", txttelf, pbtelefono);

            int valor = r * n * te  * n1;
            if (valor == 0) return;
            //if (txtnombre.Text == "")
            //{
            //    MessageBox.Show("Por favor ingrese un nombre.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //if (txtapellido.Text == "")
            //{
            //    MessageBox.Show("Por favor ingrese un apellido.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}



            //try
            //{
            //    Int32.Parse(txttelf.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Por favor ingrese un telefono valido.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //if (txtdni.Text == "")
            //{
            //    MessageBox.Show("Por favor ingrese un DNI.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //try
            //{
            //    Int32.Parse(txte.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Por favor ingrese una edad.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            //if (txtemail.Text == "")
            //{
            //    MessageBox.Show("Por favor ingrese un correo.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}


            //if (txtusuario.Text == "")
            //{
            //    MessageBox.Show("Por favor ingrese un usuario.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
            switch (tipo)
            {
                case 0:
                    usuario = new Administrador();
                    cmbrol.SelectedItem =0;
                    break;
                case 1:
                    usuario = new Vendedor();
                    cmbrol.SelectedItem = 1;
                    break;
                case 2:
                    usuario = new Operario();
                    cmbrol.SelectedItem = 2;
                    break;
                case -1:
                    MessageBox.Show("Por favor ingrese un rol.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
            }

            //if (txtcontraseña.Text == "")
            //{
            //    MessageBox.Show("Por favor ingrese una contraseña.",
            //    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}
            double salario = 0, comision = 0;
            if (txtsalario.Text != "" & txtsalario.Visible)
            {
                try
                {
                    salario = Double.Parse(txtsalario.Text);
                    if (salario <= 0)
                    {
                        MessageBox.Show("Por favor ingrese un salario valido.",
   "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    usuario.Monto = salario;
                }
                catch
                {
                    MessageBox.Show("Por favor ingrese un salario valido.",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (txtcomision.Text != "" & txtcomision.Visible)
            {
                try
                {
                    comision = Double.Parse(txtcomision.Text);
                    if (comision <= 0)
                    {
                        MessageBox.Show("Por favor ingrese un comision valido.",
   "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    usuario.Monto = comision;
                }
                catch
                {
                    MessageBox.Show("Por favor ingrese una comision valido.",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (txtsalario.Visible & txtsalario.Text == "")
            {
                MessageBox.Show("Por favor ingrese un salario valido.",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtcomision.Visible & txtcomision.Text == "")
            {
                MessageBox.Show("Por favor ingrese una comision valida.",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            usuario.Nombre = txtnombre.Text;
            usuario.Apellido = txtapellido.Text;
            usuario.Telefono = Int32.Parse(txttelf.Text);//
            usuario.Dni = txtdni.Text;
            usuario.Email = txtemail.Text;
            usuario.Fecha_ingreso = DateTime.Parse(datetimeFecha.Text);
            usuario.TipoUsuario = tipo;
            
            if (usuarioBL.modificarUsuario(usuario, salario, comision))
            {
                MessageBox.Show("El usuario se modifico satisfactoriamente");
                
            }
            else MessageBox.Show("El usuario no se modifico");

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

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            btnaceptar.Enabled = true;
            txtcomision.Enabled = true;
            txtemail.Enabled = true;
            txtapellido.Enabled = true;
            txtnombre.Enabled = true;
            txtsalario.Enabled = true;
            txttelf.Enabled = true;
            txtdni.Enabled = true;
            cmbrol.Enabled = true;
            datetimeFecha.Enabled = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void llenarCampos(Persona u)
        {
            txtnombre.Text = u.Nombre;
            txtapellido.Text = u.Apellido;
            txttelf.Text = u.Telefono.ToString();
            txtdni.Text = u.Dni;
            datetimeFecha.Value = u.Fecha_ingreso;
            cmbrol.SelectedIndex = u.TipoUsuario;
            if (u.TipoUsuario == 1) { lblcomision.Visible = true; lblsalario.Visible = false; txtcomision.Visible = true; txtsalario.Visible = false; txtcomision.Text = u.Monto.ToString(); }
                else { lblcomision.Visible = false; lblsalario.Visible = true; txtcomision.Visible = false; txtsalario.Visible = true; txtsalario.Text = u.Monto.ToString(); }

        }

        private void cmbrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbrol.SelectedIndex == 1)
            {
                lblcomision.Visible = true;
                txtcomision.Visible = true;
                lblsalario.Visible = false;
                txtsalario.Visible = false;
                txtsalario.Text = "";
            }
            else
            {
                lblcomision.Visible = false;
                txtcomision.Visible = false;

                txtcomision.Text = "";
                lblsalario.Visible = true;
                txtsalario.Visible = true;

            }
        }
    }
}
