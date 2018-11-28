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
    public partial class Login : Form
    {
        UsuarioBL usuarioBL;
        public Login()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            String usr = txtusuario.Text;
            String psw = txtcontraseña.Text;

            if (usr == "" & psw == ""/*usr=="adm" & psw == "adm"*/)
            {
                this.Hide();
                //Panel fb = new Panel();
                Menu fb = new Menu();
                if (fb.ShowDialog() ==DialogResult.OK)
                {   

                }

                this.Dispose();

            }else
            {
                try
                {
                    usuarioBL = new UsuarioBL();
                    string user = txtusuario.Text.ToString();
                    Persona usuario = usuarioBL.getUsuario(user);
                    if (usuario.IDUsuario1 == txtusuario.Text & usuario.Password == txtcontraseña.Text)
                    {

                        if (usuario.Ingreso == 0)
                        {
                            txtcontraseña.Text = "";
                            GestionarContraseña frmp = new GestionarContraseña(usuario);
                            if (frmp.ShowDialog() == DialogResult.OK)
                            {

                            }

                        }
                        else
                        {
                            this.Hide();

                            //Menu fb = new Menu();
                            Menu fb = new Menu(usuario.IDUsuario1);
                            if (fb.ShowDialog() == DialogResult.OK)
                            {

                            }

                            this.Dispose();
                        }
                    }
                    else
                        MessageBox.Show("La contraseña no es valida");
                }
                catch
                {
                    MessageBox.Show("Ingrese un usuario correcto");
                    txtusuario.Text = "";
                    txtcontraseña.Text = "";
                }
            }
        }

        private void lblcontraseña_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            // se va hacer el flujo de la pregunta (3 preguntas y se selecciona cual deseas contestas)
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String usr = txtusuario.Text;
                String psw = txtcontraseña.Text;

                if (usr == "" & psw == ""/*usr=="adm" & psw == "adm"*/)
                {
                    this.Hide();
                    //Panel fb = new Panel();
                    Menu fb = new Menu();
                    if (fb.ShowDialog() == DialogResult.OK)
                    {

                    }

                    this.Dispose();

                }
                else
                {
                    try
                    {
                        usuarioBL = new UsuarioBL();
                        string user = txtusuario.Text.ToString();
                        Persona usuario = usuarioBL.getUsuario(user);
                        if (usuario.IDUsuario1 == txtusuario.Text & usuario.Password == txtcontraseña.Text)
                        {

                            if (usuario.Ingreso == 0)
                            {
                                txtcontraseña.Text = "";
                                GestionarContraseña frmp = new GestionarContraseña(usuario);
                                if (frmp.ShowDialog() == DialogResult.OK)
                                {

                                }

                            }
                            else
                            {
                                this.Hide();

                                //Menu fb = new Menu();
                                Menu fb = new Menu(usuario.IDUsuario1);
                                if (fb.ShowDialog() == DialogResult.OK)
                                {

                                }

                                this.Dispose();
                            }
                        }
                        else
                            MessageBox.Show("Ingrese un usuario correcto");
                    }
                    catch
                    {
                        MessageBox.Show("Ingrese un usuario correcto");
                        txtusuario.Text = "";
                        txtcontraseña.Text = "";
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtusuario.Text == "")
            {
                MessageBox.Show("El usuario no es valido, ingrese un usuario");
            }else
            {
                usuarioBL = new UsuarioBL();
                string user = txtusuario.Text.ToString();
                Persona usuario = usuarioBL.getUsuario(user);
                if (usuario != null)
                {

                    GestionarContraseña fgvpsw = new GestionarContraseña(usuario,1);
                    if (fgvpsw.ShowDialog() == DialogResult.OK)
                    {

                    }

                }
                else
                {
                    MessageBox.Show("El usuario no se encuentra registrado");
                    txtusuario.Text = "";
                }
            }
        }
    }
}
