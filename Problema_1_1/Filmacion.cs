using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_1
{
    internal class Filmacion
    {
        //atributos publicos
        public int codigo { get; set; }
        public String titulo { get; set; }
        public int duracionMinuto { get; set; }
        public double precioSoles { get; set; }


        //constructor
        public Filmacion() { }
       
        //metodo para retornar el precio de soles a dolares
        public double PrecioADolares() {
            return  precioSoles * 3.59; 
        }
        public void MostrarDatos() {
            Console.WriteLine("Código : " + codigo);
            Console.WriteLine("Título : " + titulo);
            Console.WriteLine("Duración : " + duracionMinuto);
            Console.WriteLine("Precio en soles : " + precioSoles);
            Console.WriteLine("Precio en dólares : " + PrecioADolares());
        }

    }
}
