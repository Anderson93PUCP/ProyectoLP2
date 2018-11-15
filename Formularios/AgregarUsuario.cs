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
    public partial class AgregarUsuario : Form
    {
        UsuarioBL usuarioBL;
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void cmbvendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbrol.SelectedIndex == 1)
            {
                lblcomision.Visible = true;
                txtcomision.Visible = true;
                lblsalario.Visible = false;
                txtsalario.Visible = false;
            }
            else
            {
                lblcomision.Visible = false;
                txtcomision.Visible = false;
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
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Por favor ingrese un nombre.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtapellido.Text == "")
            {
                MessageBox.Show("Por favor ingrese un apellido.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            

            try
            {
                Int32.Parse(txttelf.Text);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese un telefono valido.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtdni.Text == "")
            {
                MessageBox.Show("Por favor ingrese un DNI.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Int32.Parse(txtedad.Text);
            }
            catch
            {
                MessageBox.Show("Por favor ingrese una edad.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtemail.Text == "")
            {
                MessageBox.Show("Por favor ingrese un correo.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (txtusuario.Text == "")
            {
                MessageBox.Show("Por favor ingrese un usuario.",
                "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
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
            if (txtsalario.Text != "")
            {
                try
                {
                    salario = Double.Parse(txtsalario.Text);
                    usuario.Monto = salario;
                }
                catch
                {
                    MessageBox.Show("Por favor ingrese un salario valido.",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (txtcomision.Text != "")
            {
                try
                {
                    comision = Double.Parse(txtcomision.Text);
                    usuario.Monto = comision;
                }
                catch
                {
                    MessageBox.Show("Por favor ingrese una comision valido.",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
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
    }
}
