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
    public partial class confirmacionAceptarAddPedido : Form
    {
        public confirmacionAceptarAddPedido()
        {
            InitializeComponent();
        }

        private void btnCancelarConfAddPedido_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarConfirmacionCancelAddp_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
