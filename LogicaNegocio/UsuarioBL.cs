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
    public class UsuarioBL
    {
        UsuarioDA usuarioDA;
        public UsuarioBL()
        {
            usuarioDA = new UsuarioDA();
        }

        public BindingList<Persona> listarUsuarios()
        {
            return usuarioDA.listarUsarios();
        }

        public BindingList<Persona> listarUsuarios(string dni,string rol)
        {
            return usuarioDA.listarUsarios(dni,rol);
        }

        public BindingList<Persona> listarVendedores()
        {
            return usuarioDA.listarVendedores();
        }

        public bool registrarUsuario(Persona usuario,double salario,double comision)
        {
            return usuarioDA.registrarUsuario(usuario,salario,comision);
        }

        public bool eliminarUsuario(string dni)
        {
            return usuarioDA.eliminarUsuario(dni);
        }
    }
}
