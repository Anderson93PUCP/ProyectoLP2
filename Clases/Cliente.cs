﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLP2
{

    public class Cliente : AgenteExterno
    {
        private int ruc_vendedor;

        public Cliente()
        {

        }

        public Cliente(int ruc_vendedor, string nombre, List<Direccion> lista, string ruc, string email, int telefono,int celular,int id,string apellidoP, string apellidoM) : base
            (nombre, lista, ruc, email, telefono,celular,id, apellidoP, apellidoM)
        {
            this.Ruc_vendedor = ruc_vendedor;
        }

        public int Ruc_vendedor { get => ruc_vendedor; set => ruc_vendedor = value; }
    }
}
