using System;

namespace Ejercicio3
{
    internal class Program
    {
        const int NUMERO_JURADOS = 3;
        const double PUNTAJE_MIN_ULTIMA_ETAPA = 80; 
        static void Main(string[] args)
        {
            double puntajeTotal;
            string nombre;
            Console.WriteLine("Ingrese los datos de los participantes");
            Console.WriteLine("Cuando desee finalizar, ingrese 'FIN' como nombre del participante");

            Console.WriteLine("Ingrese el nombre del participante");
            nombre = Console.ReadLine().ToUpper();

            while (nombre != "FIN" && nombre != "")
            {
                puntajeTotal = 0;

                for (int i = 1; i <= NUMERO_JURADOS; i++)
                {
                    Console.WriteLine("Ingrese el puntaje del jurado " + i + " para el participante " + nombre + ": ");
                    puntajeTotal += double.Parse(Console.ReadLine());
                }

                Console.WriteLine("El puntaje total de " + nombre + " es: " + puntajeTotal);

                if (puntajeTotal >= PUNTAJE_MIN_ULTIMA_ETAPA)
                {
                    Console.WriteLine("Pasó a la instancia final");
                }
                else
                {
                    Console.WriteLine("No pasó a la instancia final. Suerte la próxima 👍");
                }

                Console.WriteLine("Ingrese el nombre del participante");
                nombre = Console.ReadLine().ToUpper();
            }

        }
    }
}
