using System;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Le pedimos al usuario que ingrese el precio del producto
          
            Console.WriteLine("Ingresa el precio del producto sin el aumento");
            double precioI = double.Parse(Console.ReadLine());

            double precioF = precioI * 1.15;

            Console.WriteLine("El precio de venta actualizado es: " + precioF);
        }
    }
}
