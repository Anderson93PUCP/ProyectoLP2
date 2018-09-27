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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El cliente se registro satisfactoriamente");
            this.Dispose();
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtruc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtrazon_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltelefono_Click(object sender, EventArgs e)
        {

        }

        private void txttelf_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblruc_Click(object sender, EventArgs e)
        {

        }

        private void lsboxdireccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbldirecciones_Click(object sender, EventArgs e)
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
    }
}
