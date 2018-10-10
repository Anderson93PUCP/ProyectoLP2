using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public class Operario : Persona
    {

        private double salario;
        private int numPedidosAtendidos;

        public Operario()
        {

        }

        public Operario(double salario, int numPedidosAtendidos, string nombre, string apellido, int edad, char sexo, string dni, string direccion,
            int telefono, string email, int estado, DateTime fecha_ingreso, string IDUsuario, string password, string respuestaConfimacion,int tipo) :
            base(nombre, apellido, edad, sexo, dni, direccion,
             telefono, email, estado, fecha_ingreso, IDUsuario, password, respuestaConfimacion,tipo)
        {
            this.Salario = salario;
            this.NumPedidosAtendidos = numPedidosAtendidos;
        }

        public double Salario { get => salario; set => salario = value; }
        public int NumPedidosAtendidos { get => numPedidosAtendidos; set => numPedidosAtendidos = value; }
    }
}
