using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public class Venta
    {
        private string IDUsuario;
        private int idVenta;
        private string ruc_cliente;
        private DateTime fecha_e;
        private int ldetalles;
        private EstadoVenta estado;

        public Venta()
        {

        }

        public Venta(string IDUsuario, int id, string ruc_cliente, DateTime fecha_e, int ldetalles, EstadoVenta estado)
        {
            this.IDUsuario1 = IDUsuario;
            this.IdVenta = id;
            this.Ruc_cliente = ruc_cliente;
            this.Fecha_e = fecha_e;
            this.Ldetalles = ldetalles;
            this.Estado = estado;
        }

        public string IDUsuario1 { get => IDUsuario; set => IDUsuario = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }
        public string Ruc_cliente { get => ruc_cliente; set => ruc_cliente = value; }
        public DateTime Fecha_e { get => fecha_e; set => fecha_e = value; }
        public int Ldetalles { get => ldetalles; set => ldetalles = value; }
        public EstadoVenta Estado { get => estado; set => estado = value; }
    }
}
