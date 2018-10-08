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

        public BindingList<Transportista> listarTrans()
        {
            TransportistaDA t = new TransportistaDA();
            return t.listar();
        }

    }
}
