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
    public partial class frmAdministrarComisionVendedores : Form
    {
        
        public frmAdministrarComisionVendedores()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var v = MessageBox.Show("¿Desea confirmar el pago al vendedor por el monto de 742.23 S/.", "confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(v == DialogResult.OK)
            {
                //Close();
                //Se hace los cambios de estados d elas facturas 
                // se cambia el estado de las facturas
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
