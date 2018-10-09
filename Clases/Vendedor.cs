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
        private List<Venta> listaVentas;
        private List<Cliente> carteClientes;

        public Vendedor()
        {

        }

        public Vendedor(double comision, int numVentas, List<Venta> listaVentas, List<Cliente> carteClientes, string nombre, string apellido, int edad, char sexo, string dni, string direccion,
            int telefono, string email, int estado, DateTime fecha_ingreso, string IDUsuario, string password, string respuestaConfimacion,int tipo) :
            base(nombre, apellido, edad, sexo, dni, direccion,
             telefono, email, estado, fecha_ingreso, IDUsuario, password, respuestaConfimacion,tipo)
        {
            this.Comision = comision;
            this.NumVentas = numVentas;
            this.ListaVentas1 = listaVentas;
            this.CarteClientes = carteClientes;
        }

        public double Comision { get => comision; set => comision = value; }
        public int NumVentas { get => numVentas; set => numVentas = value; }
        public List<Cliente> CarteClientes { get => carteClientes; set => carteClientes = value; }
        public List<Venta> ListaVentas1 { get => listaVentas; set => listaVentas = value; }
    }
}
