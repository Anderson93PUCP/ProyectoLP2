using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{

    public abstract class AgenteExterno
    {
        private int id;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private List<Direccion> listaDirecciones;
        private string ruc;
        private string email;
        private int telefono;
        private int celular;

        public AgenteExterno()
        {

        }

        public AgenteExterno(string nombre, List<Direccion> lista, string ruc, string email, int telefono,int celular,int id,string apellidoP,string apellidoM)
        {
            this.Nombre = nombre;
            this.ListaDirecciones = lista;
            this.Ruc = ruc;
            this.Email = email;
            this.Telefono = telefono;
            this.Celular = celular;
            this.Id = id;
            this.ApellidoMaterno = apellidoM;
            this.ApellidoPaterno = apellidoP;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Email { get => email; set => email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int Celular { get => celular; set => celular = value; }
        public List<Direccion> ListaDirecciones { get => listaDirecciones; set => listaDirecciones = value; }
        public int Id { get => id; set => id = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
    }
}
