using System;

namespace Ejercicio2
{
    internal class Program
    {
        const int NUMERO_JURADOS = 4;
        static void Main(string[] args)
        {
            double puntajeTotal;
            string nombre;
            Console.WriteLine("Ingrese los datos de los participantes");
            Console.WriteLine("Cuando desee finalizar, ingrese 'FIN' como nombre del participante");

            Console.WriteLine("Ingrese el nombre del participante");
            nombre = Console.ReadLine().ToUpper();

            while (nombre != "FIN")
            {
                puntajeTotal = 0;

                for (int i = 1; i <= NUMERO_JURADOS; i++)
                {
                    Console.WriteLine("Ingrese el puntaje del jurado " + i + " para el participante " + nombre + ": ");
                    puntajeTotal += double.Parse(Console.ReadLine());
                }

                Console.WriteLine("El puntaje total de " + nombre + " es: " + puntajeTotal);

                Console.WriteLine("Ingrese el nombre del participante");
                nombre = Console.ReadLine().ToUpper();
            }

        }
    }
}
