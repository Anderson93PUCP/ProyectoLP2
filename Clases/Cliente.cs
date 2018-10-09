using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{

    public class Cliente : AgenteExterno
    {
        private string  dni_vendedor;

        public Cliente()
        {

        }

        public Cliente(string dni_vendedor, string nombre, List<Direccion> lista, string ruc, string email, int telefono,int celular,int id,string apellidoP, string apellidoM) : base
            (nombre, lista, ruc, email, telefono,celular,id, apellidoP, apellidoM)
        {
            this.Dni_vendedor = dni_vendedor;
        }

        public string Dni_vendedor { get => dni_vendedor; set => dni_vendedor = value; }
    }
}
