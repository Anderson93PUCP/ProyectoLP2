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
    public partial class GestionTransportistas : Form
    {
        TransportistaBL transportistaBL;
        Transportista transportista;
          
        public GestionTransportistas()
        {
            InitializeComponent();
            cargarTransportistas();
        }

        private void btnagregarTransp_Click(object sender, EventArgs e)
        {
            AgregarTransportista agt = new AgregarTransportista();
            agt.ShowDialog();
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            AgregarTransportista fga = new AgregarTransportista();
            fga.FormClosed += new System.Windows.Forms.FormClosedEventHandler(fga_FormClosed);

            if (fga.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void fga_FormClosed(object sender, FormClosedEventArgs e)
        {

            cargarTransportistas();

        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {
            transportista = (Transportista)dgvTransportistas.CurrentRow.DataBoundItem;
            ModificarTransportista fga = new ModificarTransportista(transportista);
            fga.FormClosed += new System.Windows.Forms.FormClosedEventHandler(fga_FormClosed);
            if (fga.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void cargarTransportistas()
        {
            transportistaBL = new TransportistaBL();
            BindingList<Transportista> transportistas = new BindingList<Transportista>();
            transportistas = transportistaBL.listarTrans();
            dgvTransportistas.AutoGenerateColumns = false;
            dgvTransportistas.DataSource = transportistas;
        }

        private void btnElimCliente_Click(object sender, EventArgs e)
        {
            int id = -1;
            //}
            if (MessageBox.Show("Esta seguro que desea eliminar el Transportista", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Int32.Parse(dgvTransportistas.Rows[dgvTransportistas.CurrentRow.Index].Cells[0].Value.ToString());
                if (transportistaBL.eliminarTransportista(id))
                {
                    MessageBox.Show("Se elimino el Transportista satisfactoriamente");
                    cargarTransportistas();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Transportista");
                }
                // user clicked yes
            }
            else
            {
                // user clicked no
            }
        }

        private void rbtnBusqRuc_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBusqRuc.Checked)
            {
                txtBusqTrans.Enabled = true;
                btnBusquedaTrans.Enabled = true;
            }
            else
            {
                txtBusqTrans.Enabled = false;
                btnBusquedaTrans.Enabled = false;
            }
        }

        private void btnBusquedaTrans_Click(object sender, EventArgs e)
        {
            string rucCliente = "";
            string filtro = txtBusqTrans.Text.Trim();
            if (rbtnBusqRuc.Checked)
            {
                if (filtro != "")
                {
                    rucCliente = txtBusqTrans.Text;
                    rucCliente = rucCliente.Trim();
                    transportistaBL = new TransportistaBL();
                    BindingList<Transportista> transportistas1 = new BindingList<Transportista>();
                    transportistas1 = transportistaBL.listarTrans(rucCliente);//Sobrecarga
                    dgvTransportistas.AutoGenerateColumns = false;
                    dgvTransportistas.DataSource = transportistas1;
                }
                else cargarTransportistas();
            }
        }
    }
}
