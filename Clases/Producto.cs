using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public class Producto
    {
        private string codigo;
        private string nombre;
        private string descripcion;
        private double precio;
        private Medida um;
        private char tipo;
        private int minimoStock;
        private List<Proveedor> listaProveedores;

        public Producto()
        {

        }

        public Producto(string codigo, string nombre, string descripcion, double precio, Medida um, char tipo, int minimoStock, List<Proveedor> listaProveedores)
        {
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Um = um;
            this.Tipo = tipo;
            this.MinimoStock = minimoStock;
            this.listaProveedores = listaProveedores;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public Medida Um { get => um; set => um = value; }
        public char Tipo { get => tipo; set => tipo = value; }
        public int MinimoStock { get => minimoStock; set => minimoStock = value; }
        public List<Proveedor> ListaProveedores { get => listaProveedores; set => listaProveedores = value; }
    }
}
