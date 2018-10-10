using Clases;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class AgregarDirecciones : Form
    {
        DireccionBL direccionBL;
        public AgregarDirecciones()
        {
            InitializeComponent();
            CargarRegiones();
        }

        private void btnagregarDireccion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se agrego la direccion satisfactoriamente ");
        }

        private void btncancelarDireccion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CargarRegiones()
        {
            direccionBL = new DireccionBL();
            BindingList<Region> departamentos = new BindingList<Region>();
            departamentos = direccionBL.listarDepartamentos();
            cmbdepartamento.ValueMember = "Id";
            cmbdepartamento.DisplayMember = "Name";
            cmbdepartamento.DataSource = departamentos;
            cmbdepartamento.SelectedIndex = -1;

        }

        private void cmbdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idDepartamento;
            if (cmbdepartamento.SelectedItem != null)
            {
                idDepartamento = cmbdepartamento.SelectedValue.ToString();
                direccionBL = new DireccionBL();
                BindingList<Provincia> provincias = new BindingList<Provincia>();
                provincias = direccionBL.listarProvincias(idDepartamento);
                cmbprovincia.ValueMember = "Id";
                cmbprovincia.DisplayMember = "Name";
                cmbprovincia.DataSource = provincias;
                cmbprovincia.SelectedIndex = -1;
            }
            else
            {
                if (cmbdepartamento.SelectedIndex == -1) ;
                else MessageBox.Show("Debe seleccionar un departamento");
            }
        }

        private void cmbprovincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idProvincia;
            string idDepartamento;
            if (cmbdepartamento.SelectedItem != null & cmbprovincia.SelectedItem!=null)
            {
                idDepartamento = cmbdepartamento.SelectedValue.ToString();
                idProvincia = cmbprovincia.SelectedValue.ToString();
                direccionBL = new DireccionBL();
                BindingList<Distrito> distritos = new BindingList<Distrito>();
                distritos = direccionBL.listarDistritos(idDepartamento,idProvincia);
                cmbdistrito.ValueMember = "Id";
                cmbdistrito.DisplayMember = "Name";
                cmbdistrito.DataSource = distritos;
                cmbdistrito.SelectedIndex = -1;
            }
            else
            {
                if (cmbprovincia.SelectedIndex == -1 | cmbdepartamento.SelectedIndex == -1) ;
                else MessageBox.Show("Debe seleccionar una provincia");
            }
        }
    }
}
