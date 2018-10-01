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
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario fga = new AgregarUsuario();
            fga.ShowDialog();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
