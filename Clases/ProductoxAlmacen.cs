using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public class ProductoxAlmacen
    {
        private string codigo;
        private int idalmacen;
        private int stock;

        public ProductoxAlmacen()
        {

        }

        public ProductoxAlmacen(string codigo, int idalmacen, int stock)
        {
            this.Codigo = codigo;
            this.Idalmacen = idalmacen;
            this.Stock = stock;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public int Idalmacen { get => idalmacen; set => idalmacen = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
