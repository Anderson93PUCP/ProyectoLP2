using AccesoDatos;
using Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class DireccionBL
    {
        DireccionDA direccionDA;
        public DireccionBL()
        {
            direccionDA = new DireccionDA();
        }

        public BindingList<Region> listarDepartamentos()
        {
            return direccionDA.listarDepartamentos();
        }

        public BindingList<Provincia> listarProvincias(string idDepartamento)
        {
            return direccionDA.listarProvincias(idDepartamento);
        }

        public BindingList<Distrito> listarDistritos(string idDepartamento,string idProvincia)
        {
            return direccionDA.listarDistritos(idDepartamento, idProvincia);
        }
    }
}
