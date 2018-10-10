using AccesoDatos;
using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class PagoBL
    {
        private PagoDA pagoDA=new PagoDA();
        public PagoBL() { }

        public BindingList<Pago> listarPagos(string dni) {

            return pagoDA.listarPagos(dni);
        }

    }
}
