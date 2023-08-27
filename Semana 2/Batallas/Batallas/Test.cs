using Batallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Batallas
{
    public class Test
    {
        public static void Main()
        {
            // Crear los superhéroes según el enunciado
            SuperHeroe superHeroe1 = new SuperHeroe("Batman", 98, 70, 0);
            SuperHeroe superHeroe2 = new SuperHeroe("Superman", 95, 60, 70);
            SuperHeroe superHeroe3 = new SuperHeroe("Gohan", 100, 100, 70);

            // Jugar y mostrar resultados
            // Aca compite batman contra superman 
            string resultado1 = superHeroe1.competir(superHeroe2);
            // Aca compite superman contra Gohan
            string resultado2 = superHeroe2.competir(superHeroe3);

            Console.WriteLine("Resultado de Batman vs. Superman: " + resultado1);
            Console.WriteLine("Resultado de Superman vs. Gohan: " + resultado2);
        }
    }
}
 
