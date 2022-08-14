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
            Console.WriteLine(usuarioService.ValidarSesion("tcasazza", "SoyTobiasCasazza"));


        }
    }

}