using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public class Direccion
    {
        private int id;
        private string detalleDireccion;
        private string departamento;
        private string provincia;
        private string distrito;

        public Direccion()
        {

        }

        public Direccion(int id, string direccion, string departamento, string provincia, string distrito)
        {
            this.Id = id;
            this.DetalleDireccion = direccion;
            this.Departamento = departamento;
            this.Provincia = provincia;
            this.Distrito = distrito;

        }

        public int Id { get => id; set => id = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public string Distrito { get => distrito; set => distrito = value; }
        public string DetalleDireccion { get => detalleDireccion; set => detalleDireccion = value; }
    }
}
