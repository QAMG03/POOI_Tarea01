using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_2
{
    internal class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public double estatura { set; get; }
        public double peso { set; get; }

        public Persona(string nombre, string apellido, int edad, double estatura, double peso) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.estatura = estatura;
            this.peso = peso;
        }

        public string EstadoDeLaPersona() {
            if (edad < 18) {
                return "Menor de edad";
            } else {
                return "Mayor de edad";
            }
        }

        public double IndiceDeMasaCorporal() {
            return peso / (estatura * estatura);
        }

        public void MostrarDatos(){
            Console.WriteLine("Nombre : " + nombre);
            Console.WriteLine("Apellido : " + apellido);
            Console.WriteLine("Edad : " + edad);
            Console.WriteLine("Estatura : " + estatura);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Estado : " + EstadoDeLaPersona());
            Console.WriteLine("Índice de masa corporal : " + IndiceDeMasaCorporal().ToString("F2"));
        }


    }
}
