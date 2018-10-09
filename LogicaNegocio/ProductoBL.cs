using AccesoDatos;
using ProyectoLP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ProductoBL
    {
        //private ProductoDA producto;
        public ProductoBL()
        {

        }

        public BindingList<Producto> listarProducto()
        {
            ProductoDA producto = new ProductoDA();
            return producto.listar();
        }
    }
}
