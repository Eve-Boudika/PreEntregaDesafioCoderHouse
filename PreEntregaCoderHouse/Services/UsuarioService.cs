using PreEntregaCoderHouse.Models;
using PreEntregaCoderHouse.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntregaCoderHouse.Services
{
    internal class UsuarioService
    {
        public string ValidarSesion(string nombreUsuario, string contraseña)
        {
            UsuarioRepository _usuarioRepository = new UsuarioRepository();

            List<Usuario> Usuarios = _usuarioRepository.GetUsuarios();

            bool usuarioValido = false;
            bool contraseñaValida = false;

            usuarioValido = ValidarUsuario(Usuarios, nombreUsuario.ToUpper());

            if (usuarioValido)
            {

                contraseñaValida = ValidarContraseña(Usuarios, contraseña.ToUpper());

            }

            if (usuarioValido && contraseñaValida)
            {
                return "ingreso Exitoso";
            }
            else
            {
                return "usuario o contraseña invalida";
            }
        }

        private bool ValidarUsuario(List<Usuario> Usuarios, string UpperUserName)
        {
            foreach (var item in Usuarios)
            {
                if (item.NombreUsuario.ToUpper().Equals(UpperUserName))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ValidarContraseña(List<Usuario> Usuarios, string UpperPassword)
        {
            foreach (var item in Usuarios)
            {
                if (item.Contraseña.ToUpper().Equals(UpperPassword))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
