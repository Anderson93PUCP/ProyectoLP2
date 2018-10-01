using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{

    public abstract class AgenteExterno
    {
        private string nombre;
        private List<int> listaDirecciones;
        private string ruc;
        private string email;
        private int telefono;
        private int celular;

        public AgenteExterno()
        {

        }

        public AgenteExterno(string nombre, List<int> lista, string ruc, string email, int telefono,int celular)
        {
            this.Nombre = nombre;
            this.ListaDirecciones = lista;
            this.Ruc = ruc;
            this.Email = email;
            this.Telefono = telefono;
            this.Celular = celular;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<int> ListaDirecciones { get => listaDirecciones; set => listaDirecciones = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int Celular { get => celular; set => celular = value; }
    }
}
