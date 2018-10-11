using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{
    public class Venta
    {
        private Vendedor vendedor;
        private int idVenta;
        private Cliente cliente;
        private Transportista transportista;
        private DateTime fecha_e;
        private EstadoVenta estado;
        private Direccion direccion;

        public Venta()
        {
            estado = EstadoVenta.activa;
        }

        public Venta(Vendedor vendedor, int idVenta, Cliente cliente, Transportista transportista, DateTime fecha_e, EstadoVenta estado, Direccion direccion)
        {
            this.vendedor = vendedor;
            this.idVenta = idVenta;
            this.cliente = cliente;
            this.transportista = transportista;
            this.fecha_e = fecha_e;
            this.estado = estado;
            this.direccion = direccion;
        }

        public int IdVenta { get => idVenta; set => idVenta = value; }
         public DateTime Fecha_e { get => fecha_e; set => fecha_e = value; }
        public EstadoVenta Estado { get => estado; set => estado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public string ClienteRUC { get => cliente.Ruc; }
        public string ClienteNombre { get => Cliente.Nombre; }
        public Transportista Transportista { get => transportista; set => transportista = value; }
        public Vendedor Vendedor { get => vendedor; set => vendedor = value; }
        public Direccion Direccion { get => direccion; set => direccion = value; }
    }
}
