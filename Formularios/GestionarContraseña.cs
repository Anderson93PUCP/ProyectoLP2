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
        Persona usr;
        public GestionarContraseña()
        {
            InitializeComponent();
        }

        public GestionarContraseña(Persona usuario)
        {
            InitializeComponent();
            usr = usuario;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //falta la pregunta
            usuarioBL = new UsuarioBL();
            if (txtcontraseña.Text == txtrepetirContra.Text)
            {
                if (usuarioBL.modificarContraseña(usr, txtcontraseña.Text.ToString()))
                {
                    MessageBox.Show("Se modifico la contraseña correctamente");
                    this.Dispose();

                }
                else
                {
                    MessageBox.Show("No se pudo modificar la contraseña");
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales");
                txtrepetirContra.Text = "";
                txtcontraseña.Text = "";
            }
        }
    }
}
