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
    public partial class frmAdministrarComisionVendedores : Form
    {
        private UsuarioBL usuarioBL;
        
        public frmAdministrarComisionVendedores()
        {
            InitializeComponent();
            CargarVendedores();
        }

        private void CargarVendedores()
        {
            usuarioBL = new UsuarioBL();
            BindingList<Persona> vendedores = new BindingList<Persona>();
            vendedores = usuarioBL.listarVendedores();
            cbxvendedores.ValueMember = "Dni";
            cbxvendedores.DisplayMember = "Nombre";
            cbxvendedores.DataSource = vendedores;
            cbxvendedores.SelectedIndex = -1;

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
