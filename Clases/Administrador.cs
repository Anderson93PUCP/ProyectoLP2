using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{

    public class Administrador : Persona
    {
        private double salario;

        public Administrador()
        {

        }

        public Administrador(double salario, string nombre, string apellido, int edad, char sexo, string dni, string direccion,
            int telefono, string email, int estado, DateTime fecha_ingreso, string IDUsuario, string password, string respuestaConfimacion) :
            base(nombre, apellido, edad, sexo, dni, direccion,
             telefono, email, estado, fecha_ingreso, IDUsuario, password, respuestaConfimacion)
        {
            this.Salario = salario;

        }

        public double Salario { get => salario; set => salario = value; }

        public string getDatos()
        {
            return "Salario: " + Salario.ToString();
        }
    }
}
