using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filmacion film = new Filmacion();

            film.codigo = 12124;
            film.titulo = "Pelicula";
            film.duracionMinuto = 90;
            film.precioSoles = 20;

            film.MostrarDatos();

            Console.ReadKey();
        }
    }
}
