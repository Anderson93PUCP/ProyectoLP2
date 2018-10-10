using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{

    public class Proveedor : AgenteExterno
    {
        private List<string> listaProductos;

        public Proveedor()
        {

        }

        public Proveedor(List<string> lista_productos, string nombre, List<Direccion> lista, string ruc, string email, int telefono,int celular,int id,string apellidoP,string apellidoM) :
            base(nombre, lista, ruc, email, telefono,celular,id,apellidoP,apellidoM)
        {
            this.ListaProductos = lista_productos;
        }

        public List<string> ListaProductos { get => listaProductos; set => listaProductos = value; }
    }
}
