using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Coordinador cor = new Coordinador();

            Console.WriteLine("Código : " +cor.codigo);
            Console.WriteLine("Nombre : " + cor.nombre);
            Console.WriteLine("Categoría : "+ cor.categoria);
            Console.WriteLine("Número de celular : " + cor.numeroC);
            Console.WriteLine("Sueldo : " + cor.SueldoCoordinador());

            Console.ReadKey();

        }
    }
}
