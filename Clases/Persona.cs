using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public abstract class Persona
    {

        private string nombre;
        private string apellido;
        private int edad;
        private char sexo;
        private string dni;
        private string direccion;
        private int telefono;
        private string email;
        private int estado;
        private DateTime fecha_ingreso;
        private string IDUsuario;
        private string password;
        private string respuestaConfimacion;
        private int tipoUsuario;
        private int ingreso;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, int edad, char sexo, string dni, string direccion,
            int telefono, string email, int estado, DateTime fecha_ingreso, string IDUsuario, string password, string respuestaConfimacion,int tipoUsuario)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Sexo = sexo;
            this.Dni = dni;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Estado = estado;
            this.Fecha_ingreso = fecha_ingreso;
            this.IDUsuario1 = IDUsuario;
            this.Password = password;
            this.RespuestaConfimacion = respuestaConfimacion;
            this.TipoUsuario = tipoUsuario;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public int Estado { get => estado; set => estado = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public string IDUsuario1 { get => IDUsuario; set => IDUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string RespuestaConfimacion { get => respuestaConfimacion; set => respuestaConfimacion = value; }
        public int TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public int Ingreso { get => ingreso; set => ingreso = value; }
    }
}
