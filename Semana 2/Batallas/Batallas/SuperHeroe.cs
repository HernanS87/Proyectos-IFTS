using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batallas
{
    internal class SuperHeroe
    {
        // Atributos
        private string nombre;
        private int fuerza;
        private int resistencia;
        private int superpoderes;

        // Constructor
        public SuperHeroe(string nombre, int fuerza, int resistencia, int superpoderes)
        {
            this.Nombre = nombre;
            this.Fuerza = fuerza;
            this.Resistencia = resistencia;
            this.Superpoderes = superpoderes;
        }

        // Propiedades con validación de rango
        public string Nombre
        {
            get { return nombre; }
            private set { nombre = value; }
        }

        public int Fuerza
        {
            get { return fuerza; }
            private set { fuerza = validarNumero(value); }
        }

        public int Resistencia
        {
            get { return resistencia; }
            private set { resistencia = validarNumero(value); }
        }

        public int Superpoderes
        {
            get { return superpoderes; }
            private set { superpoderes = validarNumero(value); }
        }

        // Método para validar que los atributos numéricos estén dentro del rango (0 a 100)
        private int validarNumero(int value)
        {
            if (value < 0)
                return 0;
            else if (value > 100)
                return 100;
            return value;
        }

        // Método para comparar los poderes de dos superhéroes
        public string competir(SuperHeroe otroSuperheroe)
        {
            string resultado = "EMPATE";
            int misPuntos = 0;
            int susPuntos = 0;

            if (this.Fuerza > otroSuperheroe.Fuerza)
                misPuntos++;
            else if (this.Fuerza < otroSuperheroe.Fuerza)
                susPuntos++;

            if (this.Resistencia > otroSuperheroe.Resistencia)
                misPuntos++;
            else if (this.Resistencia < otroSuperheroe.Resistencia)
                susPuntos++;

            if (this.Superpoderes > otroSuperheroe.Superpoderes)
                misPuntos++;
            else if (this.Superpoderes < otroSuperheroe.Superpoderes)
                susPuntos++;

            if (susPuntos >= 2)
                resultado = "El ganador es " + otroSuperheroe.Nombre;
            else if (misPuntos >= 2)
                resultado = "El ganador es " + this.Nombre;
            return resultado;
        }

    }
}
