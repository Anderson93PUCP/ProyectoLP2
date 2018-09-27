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
    public partial class reporteclientes : Form
    {
        public reporteclientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExportReporte_Click(object sender, EventArgs e)
        {
            var result =MessageBox.Show("Se Exprto correctamente", "Confirmacion de Exportacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {

            }
        }
    }
}
