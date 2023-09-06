using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraerYEncapsular
{
    internal class Empleado
    {
        private String nombre;
        private int edad;
        private String cargo;

        public Empleado()
        {
        }

        public Empleado(string nombre, int edad, string cargo)
        {
            Nombre = nombre;
            Edad = edad;
            Cargo = cargo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\n"
                 + "Edad: " + Edad + "\n" 
                 + "Cargo: " + Cargo;
        }
    }
}
