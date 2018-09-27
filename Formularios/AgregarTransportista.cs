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
    public partial class AgregarTransportista : Form
    {
        public AgregarTransportista()
        {
            InitializeComponent();
        }

        private void btndirecciones_Click(object sender, EventArgs e)
        {
            AgregarDirecciones fgd = new AgregarDirecciones();
            fgd.ShowDialog();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
