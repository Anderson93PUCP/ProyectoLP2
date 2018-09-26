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
        public Panel()
        {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {

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
    }
}
