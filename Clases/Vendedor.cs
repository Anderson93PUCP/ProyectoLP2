using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{

    public class Vendedor : Persona
    {

        private double comision;
        private int numVentas;
        private List<int> listaVentas;
        private List<String> carteClientes;

        public Vendedor()
        {

        }

        public Vendedor(double comision, int numVentas, List<int> listaVentas, List<string> carteClientes, string nombre, string apellido, int edad, char sexo, string dni, string direccion,
            int telefono, string email, int estado, DateTime fecha_ingreso, string IDUsuario, string password, string respuestaConfimacion) :
            base(nombre, apellido, edad, sexo, dni, direccion,
             telefono, email, estado, fecha_ingreso, IDUsuario, password, respuestaConfimacion)
        {
            this.Comision = comision;
            this.NumVentas = numVentas;
            this.ListaVentas = listaVentas;
            this.CarteClientes = carteClientes;
        }

        public double Comision { get => comision; set => comision = value; }
        public int NumVentas { get => numVentas; set => numVentas = value; }
        public List<int> ListaVentas { get => listaVentas; set => listaVentas = value; }
        public List<string> CarteClientes { get => carteClientes; set => carteClientes = value; }
    }
}
