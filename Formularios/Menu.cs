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

        public Menu(string username)
        {
            InitializeComponent();
            lblusuario.Text = "Bienvenido "+ username.ToString();
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
                if (panel1.Width == 188)
                {
                    MenuVertical.Width = 70;
                    panel1.Width = 0;
                    estadosInicialesSubMenus();
                    panelContenedor.Width += 368;
                }
                else
                {
                    MenuVertical.Width = 70;
                    panelContenedor.Width += 188;
                }

            }
            else
            {
                MenuVertical.Width = 250;
                panelContenedor.Width = 1042;
            }

        }

        private void estadosInicialesSubMenus()
        {
            panelVertical2.Visible = false;
            panelVerticalAlmacen.Visible = false;
            panelVerticalPagos.Visible = false;
            panelVerticalPedidos.Visible = false;
            panelVerticalReportes.Visible = false;
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
            if (MenuVertical.Width != 250)
            {
                MenuVertical.Width = 250;
                panel1.Width = 0;
                panelContenedor.Width = 1042;

            }
            else
            {
                if (panelVertical2.Visible)
                {
                    panelVertical2.Visible = false;
                    panel1.Width = 0;
                    if (MenuVertical.Width == 250)
                    {
                        panelContenedor.Width = 180 + 862;
                    }
                    localizacionInicialPanelVertical2();
                }
                else
                {
                    panelVertical2.Visible = true;
                    panel1.Width = 188;
                    panelContenedor.Width = 862;
                    estadosMantenimiento();
                    
                }
            }

            
        }

        void localizacionInicialPanelVertical2()
        {
            panelVertical2.Location = new Point(0, 0);
            panelVerticalAlmacen.Location = new Point(0, 0);
            panelVerticalPagos.Location = new Point(0, 0);
            panelVerticalReportes.Location = new Point(0, 0);
            panelVerticalPedidos.Location = new Point(0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width != 250)
            {
                MenuVertical.Width = 250;
                panel1.Width = 0;
                panelContenedor.Width = 1042;

            }
            else
            {
                if (panelVerticalPedidos.Visible)
                {
                    panelVerticalPedidos.Visible = false;
                    panel1.Width = 0;
                    if (MenuVertical.Width == 250)
                    {
                        panelContenedor.Width = 180 + 862;
                    }
                    localizacionInicialPanelVertical2();
                }
                else
                {
                    panelVerticalPedidos.Visible = true;
                    panel1.Width = 188;
                    panelContenedor.Width = 862;
                    estadosPedido();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width != 250)
            {
                MenuVertical.Width = 250;
                panel1.Width = 0;
                panelContenedor.Width = 1042;

            }
            else
            {
                if (panelVerticalAlmacen.Visible)
                {
                    panelVerticalAlmacen.Visible = false;
                    panel1.Width = 0;
                    if (MenuVertical.Width == 250)
                    {
                        panelContenedor.Width = 180 + 862;
                    }
                    localizacionInicialPanelVertical2();
                }
                else
                {
                    panelVerticalAlmacen.Visible = true;
                    panel1.Width = 188;
                    panelContenedor.Width = 862;
                    estadosAlmacen();

                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width != 250)
            {
                MenuVertical.Width = 250;
                panel1.Width = 0;
                panelContenedor.Width = 1042;

            }
            else
            {
                if (panelVerticalPagos.Visible)
                {
                    panelVerticalPagos.Visible = false;
                    panel1.Width = 0;
                    if (MenuVertical.Width == 250)
                    {
                        panelContenedor.Width = 180 + 862;
                    }
                    localizacionInicialPanelVertical2();
                }
                else
                {
                    panelVerticalPagos.Visible = true;
                    panel1.Width = 188;
                    panelContenedor.Width = 862;
                    estadosPagos();

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width != 250)
            {
                MenuVertical.Width = 250;
                panel1.Width = 0;
                panelContenedor.Width = 1042;

            }
            else
            {
                if (panelVerticalReportes.Visible)
                {
                    panelVerticalReportes.Visible = false;
                    panel1.Width = 0;
                    if (MenuVertical.Width == 250)
                    {
                        panelContenedor.Width = 180 + 862;
                    }
                    localizacionInicialPanelVertical2();
                }
                else
                {
                    panelVerticalReportes.Visible = true;
                    panel1.Width = 188;
                    panelContenedor.Width = 862;
                    estadosReporte();

                }
            }
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
            //fh.WindowState = FormWindowState.Maximized;
            fh.Show();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new GestionUsuarios());
        }

        private void btnTransportistas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new GestionTransportistas());
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new gestorFacturas()); 
        }

        private void btnGestionPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new GestionPedidos()); 
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmAdministrarComisionVendedores()); 
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            MessageBox.Show("Este modulo fue implementado en java");
        }

        private void btnGestionAlmacenes_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            MessageBox.Show("Este modulo fue implementado en java");
        }

        private void btnReporteProductos_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            MessageBox.Show("Este modulo fue implementado en java");
        }

        private void btnReporteClientes_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            MessageBox.Show("Este modulo fue implementado en java");
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            MessageBox.Show("Este modulo fue implementado en java");
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login lg = new Login();
            if (lg.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
