using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // Pedir al usuario que ingrese un número entero de 4 dígitos
            Console.Write("Ingrese un número entero de 4 dígitos: ");
            string num = Console.ReadLine();           

                int suma = 0;   
                
                for (int i = 0; i < num.Length; i++)
                {
                    string digito =  num[i].ToString();
                    Console.Write(digito);
                    suma += int.Parse(digito);

                if (i < num.Length - 1)
                    {
                        Console.Write(" + ");
                    }
                }

                Console.WriteLine(" = " + suma);    
            
        }
    }
}
