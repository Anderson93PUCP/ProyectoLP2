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
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void cmbvendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbrol.SelectedIndex == 2)
            {
                lblcomision.Visible = true;
                txtcomision.Visible = true;
            }
            else
            {
                lblcomision.Visible = false;
                txtcomision.Visible = false;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El usuario se registro satisfactoriamente");
            this.Dispose();
        }
    }
}
