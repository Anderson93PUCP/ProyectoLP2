using AccesoDatos;
using Clases;
using ProyectoLP2;
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

        public BindingList<Pago> listar_todos_Pagos()
        {
            return pagoDA.listar_todos_Pagos();
        }


        public void insertarPago(BindingList<Pago> pagos, String dni)
        {
            pagoDA.insertarPago(pagos, dni);
        }

        

        public void cambiarEstado(BindingList<Pago> listapagos)
        {
            pagoDA.cambiarEstado(listapagos);
        }

        public double calcular_monto(BindingList<Pago> listapagos)
        {
            return pagoDA.calcular_monto(listapagos);
        }

    }
}
