using AccesoDatos;
using ProyectoLP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class FacturaBL
    {
        private FacturaDA facturaDA;
        public FacturaBL()
        {
            facturaDA = new FacturaDA();
        }
        public BindingList<Factura> listarFacturas()
        {
            return facturaDA.listar();
        }
    }
}
