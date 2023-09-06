using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraerYEncapsular
{
    internal class Empresa
    {
        private String nombre;
        private Empleado empleado;

        public Empresa(string nombre, Empleado empleado)
        {
            Nombre = nombre;
            Empleado = empleado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal Empleado Empleado { get => empleado; set => empleado = value; }
    }
}
