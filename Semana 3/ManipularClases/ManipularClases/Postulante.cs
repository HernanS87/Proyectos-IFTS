using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipularClases
{
    internal class Postulante
    {
        private String nombre;
        private String apellido;
        private String tipo;
        private int documento;

        public Postulante()
        {
        }

        public Postulante(string nombre, string apellido, string tipo, int documento)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Tipo = tipo;
            this.Documento = documento;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Documento { get => documento; set => documento = value; }
    }
}
