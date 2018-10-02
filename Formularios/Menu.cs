using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Formularios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            panelVertical2.Visible = false;
            panelVerticalReportes.Visible = false;
            panelVerticalAlmacen.Visible = false;
            panelVerticalPagos.Visible = false;
            panelVerticalPedidos.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }else
            {
                MenuVertical.Width = 250;
            }
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnprod_Click(object sender, EventArgs e)
        {

            //if (panelVertical2.Width == 188)
            //{
            //    panelVertical2.Width = 0;
            //}
            //else
            //{
            //    panelVertical2.Width = 188;
            //}
            if (panelVertical2.Visible)
            {
                panelVertical2.Visible = false;
            }
            else estadosMantenimiento();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //if (panelVerticalPedidos.Width == 188)
            //{
            //    panelVerticalPedidos.Width = 0;
            //}
            //else
            //{
            //    panelVerticalPedidos.Width = 188;
            //}
            if (panelVerticalPedidos.Visible) panelVerticalPedidos.Visible = false;
            else
                estadosPedido();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //if (panelVerticalAlmacen.Width == 188)
            //{
            //    panelVerticalAlmacen.Width = 0;
            //}
            //else
            //{
            //    panelVerticalAlmacen.Width = 188;
            //}
            if (panelVerticalAlmacen.Visible) panelVerticalAlmacen.Visible = false;
            else
                estadosAlmacen();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //if (panelVerticalPagos.Width == 188)
            //{
            //    panelVerticalPagos.Width = 0;
            //}
            //else
            //{
            //    panelVerticalPagos.Width = 188;
            //}
            if (panelVerticalPagos.Visible) panelVerticalPagos.Visible = false;
            else
                estadosPagos();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //if (panelVerticalReportes.Width == 188)
            //{
            //    panelVerticalReportes.Width = 0;
            //}
            //else
            //{
            //    panelVerticalReportes.Width = 188;
            //}
            if (panelVerticalReportes.Visible) panelVerticalReportes.Visible = false;
            else
                estadosReporte();
        }

        private void estadosMantenimiento()
        {
            panelVertical2.Visible = true;
            panelVerticalAlmacen.Visible = false;
            panelVerticalPagos.Visible = false;
            panelVerticalPedidos.Visible = false;
            panelVerticalReportes.Visible = false;
            //btnClientes.Visible = true;
            //btnProveedores.Visible = true;
            //btnUsuarios.Visible = true;
            //btnTransportistas.Visible = true;

            //btnGestionPedidos.Visible = false;
            //btnFactura.Visible = false;
            //btnProducto.Visible = false;
            //btnGestionAlmacenes.Visible = false;
            //btnVendedores.Visible = false;
            //btnReporteClientes.Visible = false;
            //btnReporteProductos.Visible = false;
        }
        private void estadosPedido()
        {
            panelVertical2.Visible = false;
            panelVerticalAlmacen.Visible = false;
            panelVerticalPagos.Visible = false;
            panelVerticalPedidos.Visible = true;
            panelVerticalReportes.Visible = false;
        }
        private void estadosAlmacen()
        {
            panelVertical2.Visible = false;
            panelVerticalAlmacen.Visible = true;
            panelVerticalPagos.Visible = false;
            panelVerticalPedidos.Visible = false;
            panelVerticalReportes.Visible = false;
        }
        private void estadosPagos()
        {
            panelVertical2.Visible = false;
            panelVerticalAlmacen.Visible = false;
            panelVerticalPagos.Visible = true;
            panelVerticalPedidos.Visible = false;
            panelVerticalReportes.Visible = false;
        }
        private void estadosReporte()
        {
            panelVertical2.Visible = false;
            panelVerticalAlmacen.Visible = false;
            panelVerticalPagos.Visible = false;
            panelVerticalPedidos.Visible = false;
            panelVerticalReportes.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
                AbrirFormInPanel(new GestionClientes());
            
            
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.WindowState = FormWindowState.Maximized;
            fh.Show();

        }
    }
}
