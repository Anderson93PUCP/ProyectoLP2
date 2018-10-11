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
    public partial class GestionUsuarios : Form
    {
        UsuarioBL usuarioBL;
        public GestionUsuarios()
        {
            InitializeComponent();
            cmbBusqUsuarioRol.SelectedIndex = -1;
            cargarUsuarios();
        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario ausuario = new AgregarUsuario();

            ausuario.FormClosed += new System.Windows.Forms.FormClosedEventHandler(AgregarUsuario_FormClosed);
            if (ausuario.ShowDialog() == DialogResult.OK)
            {

            }
        }


        private void AgregarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargarUsuarios();
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbtnDNI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDNI.Checked)
            {
                rbtRol.Checked = false;
                txtBusqUsuarioDNI.Enabled = true;
                cmbBusqUsuarioRol.SelectedIndex = -1;
                cmbBusqUsuarioRol.Enabled = false;
            }
        }

        private void rbtRol_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtRol.Checked)
            {
                rbtnDNI.Checked = false;
                cmbBusqUsuarioRol.Enabled = true;
                txtBusqUsuarioDNI.Text = "";
                txtBusqUsuarioDNI.Enabled = false;
            }
        }

        private void btnBusquedaPedido_Click(object sender, EventArgs e)
        {
            string rol = "";
            string dni = txtBusqUsuarioDNI.Text;
            if (cmbBusqUsuarioRol.SelectedIndex==-1 & dni == "") cargarUsuarios();
            else
            {
                rol = cmbBusqUsuarioRol.Text;
                usuarioBL = new UsuarioBL();
                BindingList<Persona> usuarios = new BindingList<Persona>();
                usuarios = usuarioBL.listarUsuarios(dni,rol);
                dgvUsuarios.AutoGenerateColumns = false;
                dgvUsuarios.DataSource = usuarios;
            }
        }

        private void cargarUsuarios()
        {
            usuarioBL = new UsuarioBL();
            BindingList<Persona> usuarios = new BindingList<Persona>();
            usuarios = usuarioBL.listarUsuarios();
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.DataSource = usuarios;
        }

        private void btnModCliente_Click(object sender, EventArgs e)
        {
            Persona usuario = null;
            usuario=(Persona)dgvUsuarios.CurrentRow.DataBoundItem;
            ModificarUsuario fga = new ModificarUsuario(usuario);
            fga.FormClosed += new System.Windows.Forms.FormClosedEventHandler(ModificarUsuario_FormClosed);
            fga.ShowDialog();
        }

        private void ModificarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargarUsuarios();
        }

        private void btnElimCliente_Click(object sender, EventArgs e)
        {
            string dni = "";
            //}
            if (MessageBox.Show("Esta seguro que desea eliminar el Usuario", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dni = dgvUsuarios.Rows[dgvUsuarios.CurrentRow.Index].Cells[0].Value.ToString();
                if (usuarioBL.eliminarUsuario(dni))
                {
                    MessageBox.Show("Se elimino el Usuario satisfactoriamente");
                    cargarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Usuario");
                }
                // user clicked yes
            }
            else
            {
                // user clicked no
            }
        }


        
    }
}
