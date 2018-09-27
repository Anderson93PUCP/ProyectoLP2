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
    public partial class AgregarDirecciones : Form
    {
        public AgregarDirecciones()
        {
            InitializeComponent();
        }

        private void btnagregarDireccion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se agrego la direccion satisfactoriamente ");
        }

        private void btncancelarDireccion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
