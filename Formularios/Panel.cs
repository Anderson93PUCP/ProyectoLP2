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
    public partial class Panel : Form
    {
        private static GestionClientes fgc;
        public Panel()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void gestionDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPedidos nuevaVentana = new GestionPedidos();
            nuevaVentana.ShowDialog();



        }

        private void itemFacturas_Click(object sender, EventArgs e)
        {
            gestorFacturas ventana = new gestorFacturas();
            ventana.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void reporteDeProductoDeAltoMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteprod rp = new reporteprod();
            rp.ShowDialog();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteclientes rc = new reporteclientes();
            rc.ShowDialog();
        }

        private void itemClientes_Click(object sender, EventArgs e)
        {
            GestionClientes fgc = new GestionClientes();
            fgc.ShowDialog();
            //if(fgc!=null)
            //{
            //    fgc.Close();
            //    fgc = null;
            //}
            //else
            //{
            //    fgc = new GestionClientes();
            //    fgc.MdiParent = this;
            //    fgc.WindowState = FormWindowState.Maximized;
            //    fgc.Visible = true;
            //    fgc.FormClosing += volverNulo;
            //}


        }

        public void volverNulo(object sender,
            FormClosingEventArgs e)
        {
            fgc = null;
        }

        private void itemTransportes_Click(object sender, EventArgs e)
        {
            GestionTransportistas fgt = new GestionTransportistas();
            fgt.ShowDialog();
        }
    }
}
  
