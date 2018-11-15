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
    public partial class buscarTransportista : Form
    {
        private Transportista transSeleccionado;
        private BindingList<Transportista> lista;

        public Transportista TransSeleccionado { get => transSeleccionado; set => transSeleccionado = value; }
        public BindingList<Transportista> Lista { get => lista; set => lista = value; }

        public buscarTransportista()
        {

            InitializeComponent();
            TransportistaBL t = new TransportistaBL();
            lista = new BindingList<Transportista>();
            lista = t.listarTrans();
            dgvTransportistas.AutoGenerateColumns = false;
            dgvTransportistas.DataSource = lista;
            dgvTransportistas.AllowUserToAddRows = false;
        }

        private void buscarTransportista_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel ;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            transSeleccionado = new Transportista();
            try
            {
                transSeleccionado = (Transportista)dgvTransportistas.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un transportista");
            }
        }

        private void btnBuscarTran_Click(object sender, EventArgs e)
        {
            BindingList<Transportista> listaAux = new BindingList<Transportista>();
            listaAux = null;
            if (txtBuscarT.Text == "")
            {
                dgvTransportistas.DataSource = lista;
            }else
            {
                if(rbtnNombre.Checked == true)
                {
                    String criterio = txtBuscarT.Text;
                    foreach (Transportista t in lista)
                    {
                        if (t.Nombre.Contains(criterio))
                        {
                            Transportista agencia = new Transportista();
                            agencia = t;
                            listaAux.Add(agencia);
                        }
                        dgvTransportistas.DataSource = listaAux;
                    }

                }
                if(rbtnRUC.Checked == true)
                {
                    String criterio = txtBuscarT.Text;
                    foreach (Transportista t in lista)
                    {
                        if (t.Ruc.Contains(criterio))
                        {
                            Transportista agencia = new Transportista();
                            agencia = t;
                            listaAux.Add(t);
                        }
                        dgvTransportistas.DataSource = listaAux;
                    }
                }
            }
            
        }

        private void txtBuscarT_TextChanged(object sender, EventArgs e)
        {
            
            if (txtBuscarT.Text == "")
            {
                dgvTransportistas.DataSource = lista;
            }
            else
            {
                BindingList<Transportista> listaAux = new BindingList<Transportista>();
                
                String criterio;
                if (rbtnNombre.Checked == true)
                {
                    criterio = txtBuscarT.Text;
                    foreach (Transportista t in lista)
                    {
                        if (t.Nombre.Contains(criterio))
                        {
                            Transportista agencia = new Transportista();
                            agencia = t;
                            listaAux.Add(agencia);
                        }
                        
                    }
                    dgvTransportistas.DataSource = listaAux;
                }
                if (rbtnRUC.Checked == true)
                {
                    criterio = txtBuscarT.Text;
                    foreach (Transportista t in lista)
                    {
                        if (t.Ruc.Contains(criterio))
                        {
                            Transportista agencia = new Transportista();
                            agencia = t;
                            listaAux.Add(t);
                        }
                       
                    }
                    dgvTransportistas.DataSource = listaAux;
                }
            }
        }
    }
}
