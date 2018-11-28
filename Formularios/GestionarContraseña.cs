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
    public partial class GestionarContraseña : Form
    {
        UsuarioBL usuarioBL;
        int restablecer = 0;
        Persona usr;
        public GestionarContraseña()
        {
            InitializeComponent();
        }

        public GestionarContraseña(Persona usuario)
        {
            InitializeComponent();
            usr = usuario;
            txtusuario.Text = usr.IDUsuario1;
        }

        public GestionarContraseña(Persona usuario,int mod)
        {
            InitializeComponent();
            usr = usuario;
            restablecer = mod;
            llenarCampos();
        }

        public void llenarCampos()
        {
            txtusuario.Text = usr.IDUsuario1;
            cmbpregunta.SelectedIndex = usr.Pregunta;
            cmbpregunta.Enabled = false;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //falta la pregunta
            if (restablecer == 0)
            {
                usuarioBL = new UsuarioBL();
                if (txtcontraseña.Text != "" & txtrepetirContra.Text != "" & cmbpregunta.SelectedIndex != -1 & txtrespuesta.Text != "")
                {

                    if (txtcontraseña.Text == txtrepetirContra.Text)
                    {
                        usr.Pregunta = cmbpregunta.SelectedIndex;
                        usr.Respuesta = txtrespuesta.Text.ToUpper();
                        if (usuarioBL.modificarContraseña(usr, txtcontraseña.Text.ToString()))
                        {
                            MessageBox.Show("Se modifico la contraseña correctamente");
                            this.Dispose();
                            usuarioBL.logueadoUsuario(usr.Dni, 0);

                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar la contraseña");
                            this.Dispose();
                            usuarioBL.logueadoUsuario(usr.Dni, 0);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no son iguales");
                        txtrepetirContra.Text = "";
                        txtcontraseña.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }else
            {
                usuarioBL = new UsuarioBL();
                if (txtcontraseña.Text != "" & txtrepetirContra.Text != ""  & txtrespuesta.Text != "")
                {

                    if (txtcontraseña.Text != txtrepetirContra.Text) MessageBox.Show("Las contraseñas no son iguales");
                    else if (usr.Respuesta != txtrespuesta.Text.ToUpper())
                    {
                        MessageBox.Show("La respuesta es incorrecta no se puede restablecer la contraseña,vuelva a intentarlo");
                        txtrespuesta.Text = "";
                    }
                    else
                    {
                        usr.Pregunta = cmbpregunta.SelectedIndex;
                        usr.Respuesta = txtrespuesta.Text.ToUpper();
                        if (usuarioBL.modificarContraseña(usr, txtcontraseña.Text.ToString()))
                        {
                            MessageBox.Show("Se modifico la contraseña correctamente");
                            this.Dispose();
                            usuarioBL.logueadoUsuario(usr.Dni, 0);

                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar la contraseña");
                            this.Dispose();
                            usuarioBL.logueadoUsuario(usr.Dni, 0);
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
        }
    }
}
