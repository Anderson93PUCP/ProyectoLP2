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
    public partial class buscarDireccion : Form
    {
        BindingList<Direccion> listaDirec;
        Direccion direccionSeleccionada;

        public Direccion DireccionSeleccionada { get => direccionSeleccionada; set => direccionSeleccionada = value; }

        public buscarDireccion()
        {
            InitializeComponent();

            
        }
        public buscarDireccion(int idCliente)
        {
            InitializeComponent();
            dgvDirecciones.AutoGenerateColumns = false;
            listaDirec = new BindingList<Direccion>();
            DireccionBL c = new DireccionBL ();
            listaDirec = c.listarDireccionesCliente(idCliente);
            dgvDirecciones.AutoGenerateColumns = false;
            dgvDirecciones.DataSource = listaDirec;
            dgvDirecciones.AllowUserToAddRows = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelarBuscarDire_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAcpetarBuscDire_Click(object sender, EventArgs e)
        {
            direccionSeleccionada = new Direccion();
            direccionSeleccionada = (Direccion)dgvDirecciones.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscarDire_Click(object sender, EventArgs e)
        {
            if(txtbuscarDire.Text == "")
            {
                dgvDirecciones.DataSource = listaDirec;
            }
            else
            {
                BindingList<Direccion> listaBusq = new BindingList<Direccion>();
                String criterio;
                if (rbtnDep.Checked == true)
                {
                    criterio = txtbuscarDire.Text;
                    foreach(Direccion d in listaDirec)
                    {
                        if (d.Departamento.Contains(criterio))
                        {
                            Direccion aux = new Direccion();
                            aux = d;
                            listaBusq.Add(aux);
                        }
                    }
                    dgvDirecciones.DataSource = listaBusq;
                }
                if (rbtnDist.Checked == true)
                {
                    criterio = txtbuscarDire.Text;
                    foreach (Direccion d in listaDirec)
                    {
                        if (d.Distrito.Contains(criterio))
                        {
                            Direccion aux = new Direccion();
                            aux = d;
                            listaBusq.Add(aux);
                        }
                    }
                    dgvDirecciones.DataSource = listaBusq;
                }
                if (rbtnProv.Checked == true)
                {
                    criterio = txtbuscarDire.Text;
                    foreach (Direccion d in listaDirec)
                    {
                        if (d.Provincia.Contains(criterio))
                        {
                            Direccion aux = new Direccion();
                            aux = d;
                            listaBusq.Add(aux);
                        }
                    }
                    dgvDirecciones.DataSource = listaBusq;
                }

            }
        }

        private void txtbuscarDire_TextChanged(object sender, EventArgs e)
        {
            if (txtbuscarDire.Text == "")
            {
                dgvDirecciones.DataSource = listaDirec;
            }
            else
            {
                BindingList<Direccion> listaBusq = new BindingList<Direccion>();
                String criterio;
                if (rbtnDep.Checked == true)
                {
                    criterio = txtbuscarDire.Text;
                    foreach (Direccion d in listaDirec)
                    {
                        if (d.Departamento.Contains(criterio))
                        {
                            Direccion aux = new Direccion();
                            aux = d;
                            listaBusq.Add(aux);
                        }
                    }
                    dgvDirecciones.DataSource = listaBusq;
                }
                if (rbtnDist.Checked == true)
                {
                    criterio = txtbuscarDire.Text;
                    foreach (Direccion d in listaDirec)
                    {
                        if (d.Distrito.Contains(criterio))
                        {
                            Direccion aux = new Direccion();
                            aux = d;
                            listaBusq.Add(aux);
                        }
                    }
                    dgvDirecciones.DataSource = listaBusq;
                }
                if (rbtnProv.Checked == true)
                {
                    criterio = txtbuscarDire.Text;
                    foreach (Direccion d in listaDirec)
                    {
                        if (d.Provincia.Contains(criterio))
                        {
                            Direccion aux = new Direccion();
                            aux = d;
                            listaBusq.Add(aux);
                        }
                    }
                    dgvDirecciones.DataSource = listaBusq;
                }

            }
        }
    }
}
