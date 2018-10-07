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
        private List<string> destinos;

        public Transportista()
        {

        }

        public Transportista(Alcance alcance, List<string> destinos, string nombre, List<Direccion> lista, string ruc, string email, int telefono,int celular) : base
            (nombre, lista, ruc, email, telefono,celular)
        {
            this.Alcance = alcance;
            this.Destinos = destinos;
        }

        public Alcance Alcance { get => alcance; set => alcance = value; }
        public List<string> Destinos { get => destinos; set => destinos = value; }
    }
}
