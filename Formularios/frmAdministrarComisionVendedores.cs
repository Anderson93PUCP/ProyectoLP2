using Clases;
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
        private PagoBL pagoBL;
        
        public frmAdministrarComisionVendedores()
        {
            InitializeComponent();
            CargarVendedores();
            btnPagar.Enabled = false;
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
            //string montototal = string.Empty;
            //int index = 0;
            //foreach (DataGridViewRow row in dgvpagos.Rows)
            //    montototal = row.Cells[index].Value.ToString();

            var v = MessageBox.Show("¿Desea confirmar el pago al vendedor por el monto de 45.0?", "confirmacion",MessageBoxButtons.OKCancel);

           
            if (v == DialogResult.OK)
            {
               if (cbxvendedores.SelectedIndex != -1)
               {
                    btnPagar.Enabled = true;
                    //se insertan en una tabla las info del pago que esta hecho
                    string dni = cbxvendedores.SelectedValue.ToString();

                    //Pago ptest = new Pago("aa","bb",2.0,4,5);
                    //BindingList<Pago> testlist = new BindingList<Pago>();
                    //testlist.Add(ptest);


                    //pagoBL.insertarPago(testlist);

                    pagoBL.insertarPago(pagoBL.listarPagos(dni));

                    //se cambia el estado de la factura
                    pagoBL.cambiarEstado(dni);
               }
                                                
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbxvendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            pagoBL = new PagoBL();
            string dni = "";
            if (cbxvendedores.SelectedIndex != -1)
            {
                btnPagar.Enabled = true;
                dni = cbxvendedores.SelectedValue.ToString();
                dgvpagos.AutoGenerateColumns = false;
                dgvpagos.DataSource = pagoBL.listarPagos(dni);
            }
        }
    }
}
