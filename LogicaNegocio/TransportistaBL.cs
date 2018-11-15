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
    
    public class TransportistaBL
    {
        TransportistaDA transportistaBL;
        public TransportistaBL()
        {
            transportistaBL = new TransportistaDA();
        }

        public BindingList<Transportista> listarTrans()
        {
            TransportistaDA t = new TransportistaDA();
            return t.listar();
        }

        public BindingList<Transportista> listarTrans(string ruc)
        {
            TransportistaDA t = new TransportistaDA();
            return t.listar(ruc);
        }

        public bool eliminarTransportista(int id)
        {
            return transportistaBL.eliminarTransportista(id);
        }

        public bool modificarTransportista(Transportista t)
        {
            return transportistaBL.modificarTransportista(t);
        }

        public bool agregarTransportista(Transportista t)
        {
            return transportistaBL.agregarTransportista(t);
        }

    }
}
