using Clases;
using LogicaNegocio;
using ProyectoLP2;
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
        BindingList<Direccion> listaDirecciones;
        public AgregarDirecciones()
        {
            InitializeComponent();
            listaDirecciones = new BindingList<Direccion>();
            CargarRegiones();
        }

        private void btnagregarDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                Direccion direccion = new Direccion();
                if (cmbdepartamento.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione un departamento",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (cmbdistrito.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione un distrito",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (cmbprovincia.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione una provincia",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txtdireccion.Text == "")
                {
                    MessageBox.Show("Por favor ingrese una direccion",
                    "Registro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                direccion.Provincia = cmbprovincia.Text;
                direccion.Departamento = cmbdepartamento.Text;
                direccion.Distrito = cmbdistrito.Text;
                direccion.DetalleDireccion = txtdireccion.Text;
                listaDirecciones.Add(direccion);
                MessageBox.Show("Se agrego la direccion satisfactoriamente ");
                limpiarCampos();
            }
            catch
            {
                MessageBox.Show("No se agrego la direccion correctamente");
            }
        }

        public void limpiarCampos()
        {
            txtdireccion.Text = "";
            cmbdepartamento.SelectedIndex = -1;
            cmbdistrito.SelectedIndex = -1;
            cmbprovincia.SelectedIndex = -1;
        }

        private void btncancelarDireccion_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        public BindingList<Direccion> listadirecciones()
        {

            return listaDirecciones;
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
