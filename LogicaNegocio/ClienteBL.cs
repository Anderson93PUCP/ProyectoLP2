﻿using AccesoDatos;
using ProyectoLP2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ClienteBL
    {
        ClienteDA clienteDA;
        public ClienteBL()
        {
            clienteDA = new ClienteDA();
        }

        public BindingList<Cliente> listarCliente()
        {
            return clienteDA.listarClientes();
        }

        public BindingList<Cliente> listarCliente(string ruc)
        {
            return clienteDA.listarClientes(ruc);
        }

        public bool registrarCliente(Cliente cliente)
        {
            return clienteDA.registrarCliente(cliente);
        }

        public bool eliminarCliente(int id)
        {
            return clienteDA.eliminarCliente(id);
        }

        public bool modificarCliente(Cliente cliente)
        {
            return clienteDA.modificarCliente(cliente);
        }
    }
}