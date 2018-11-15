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
    public partial class AgregarUsuario : Form
    {
        UsuarioBL usuarioBL;
        public AgregarUsuario()
        {
            InitializeComponent();
            validarCampos();
        }

        private void cmbvendedor_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            usuarioBL = new UsuarioBL();
            Persona usuario=null;
            int tipo = cmbrol.SelectedIndex;
            int r, n,n1, te, te1, em,d1;
            r = Regexp(@"^[0-9]+$", txtdni, pbdni);
            n = Regexp(@"^[a-zA-Z\s]+$", txtnombre, pbnombre);
            n1 = Regexp(@"^[a-zA-Z\s]+$", txtapellido, pbapellido);
            te = Regexp(@"^[0-9]+$", txttelf, pbtelefono);
            te1 = Regexp(@"^[0-9]+$", txtedad, pbedad);
            d1 = Regexp(@"^[a-zA-Z0-9_\s]+$", txtusuario , pbusuario);
            em = Regexp(@"^([\w]+)@([\w]+)\.([\w]+)$", txtemail, pbemail);
            int valor = r * n * te * em*d1*te1*n1;
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
            //    Int32.Parse(txtedad.Text);
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
                    break;
                case 1:
                    usuario = new Vendedor();
                    break;
                case 2:
                    usuario = new Operario();
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
                    if(comision <= 0)
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
            usuario.Fecha_ingreso = DateTime.Parse(datetimeFechaI.Text);
            usuario.IDUsuario1 = txtusuario.Text;
            usuario.Password = txtcontraseña.Text;
            usuario.TipoUsuario = tipo;
            usuario.Edad = Int32.Parse(txtedad.Text); 
            if (usuarioBL.registrarUsuario(usuario, salario, comision))
            {
                MessageBox.Show("El usuario se registro satisfactoriamente");
                limpiarCampos();
                
            }
            else MessageBox.Show("El usuario no se registro");

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
        public void limpiarCampos()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txttelf.Text = "";
            txtdni.Text = "";
            txtdni.Text = "";
            txtedad.Text = "";
            txtemail.Text = "";
            datetimeFechaI.Text = "";
            txtusuario.Text = "";
            txtcontraseña.Text = "";
            txtcomision.Text = "";
            txtsalario.Text = "";
            cmbrol.SelectedIndex = -1;

        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            txtcontraseña.Text = txtusuario.Text;
        }

        public void validarCampos()
        {
            ToolTip r = new ToolTip();
            r.SetToolTip(pbdni, "Ingrese un DNI valido");
            r.SetToolTip(pbedad, "Ingrese una edad valida");
            r.SetToolTip(pbnombre, "Ingrese un nombre valido");
            r.SetToolTip(pbapellido, "Ingrese un apellido valido");
            r.SetToolTip(pbtelefono, "Ingrese un numero telefonico valido");
            r.SetToolTip(pbemail, "Ingrese un correo valido");
            r.SetToolTip(pbusuario, "Ingrese un usuario valido");
        }
    }
}
