using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{

    public class Almacen
    {
        private int idalmacen;
        private string direccion;

        public Almacen()
        {

        }

        public Almacen(int idalmacen, string direccion)
        {
            this.Idalmacen = idalmacen;
            this.Direccion = direccion;
        }

        public int Idalmacen { get => idalmacen; set => idalmacen = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
