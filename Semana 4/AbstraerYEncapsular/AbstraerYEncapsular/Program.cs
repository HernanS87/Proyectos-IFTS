
using AbstraerYEncapsular;

namespace ManipularClases
{
    internal static class Program
    {
        static void Main()
        {
            Empleado jefe = new Empleado("Leonel", 36, "Campeon Mundial");

            Empresa empresa = new Empresa("DYSI", jefe);

            Console.WriteLine(empresa.Nombre + "\n" + empresa.Empleado.ToString());
        }
    }
}