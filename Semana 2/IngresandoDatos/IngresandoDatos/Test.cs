using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresandoDatos
{
    internal class Test
    {
         private String nombre;
         private int dni;

        public Test()
        {
        }

        public Test(string nombre, int dni)
        {
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Dni { get => dni; set => dni = value; }
    }
}
