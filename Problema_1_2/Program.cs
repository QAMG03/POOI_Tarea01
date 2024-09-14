using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Alvaro", "Querevalu", 21, 1.70, 70.0);

            persona.MostrarDatos();

            Console.ReadKey();

        }
    }
}
