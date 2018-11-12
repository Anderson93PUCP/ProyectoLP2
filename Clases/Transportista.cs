using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public class Transportista : AgenteExterno
    {
        private Alcance alcance;

        private string direccion;

        public Transportista()
        {

        }

        public Transportista(Alcance alcance, string direccion, string nombre, List<Direccion> lista, string ruc, string email, int telefono,int celular,int id, string apellidoP, string apellidoM) : base
            (nombre, lista, ruc, email, telefono,celular,id, apellidoP, apellidoM)
        {
            this.Alcance = alcance;
            this.Direccion = direccion;
        }

        public Alcance Alcance { get => alcance; set => alcance = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
