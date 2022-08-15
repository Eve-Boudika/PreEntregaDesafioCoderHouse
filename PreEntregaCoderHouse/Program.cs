using PreEntregaCoderHouse.Models;
using PreEntregaCoderHouse.Repository;
using PreEntregaCoderHouse.Services;
using System;

namespace PreEntregaCoderHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();

            UsuarioService usuarioService = new UsuarioService();
            Usuario usuario = usuarioService.ValidarSesion("tcasazza", "SoyTobiasCasazza");
            Console.WriteLine(usuario.Id);


        }
    }

}