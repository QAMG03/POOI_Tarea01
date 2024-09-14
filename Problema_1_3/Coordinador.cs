using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_3
{
    internal class Coordinador
    {
        public int codigo { get; set; }
        public String nombre { get; set; }
        public int categoria { get; set; }
        public int numeroC { get; set; }
        public int sueldo {get; set; }

        public Coordinador() { 
            this.codigo = 11212;
            this.nombre = "Alvaro";
            this.categoria = 3;
            this.numeroC = 924769246;
        }
        public double SueldoCoordinador() {
            if (categoria == 0)
            {
                return sueldo = 8500;
            }
            else if (categoria == 1)
            {
                return sueldo = 6850;
            }
            else {
                return sueldo = 5500;
            }
        }
    }
}
