using System;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContenedorPrincipal cp = new ContenedorPrincipal();
            Console.Clear();
            Console.WriteLine("*------Bienvenido al Sistema Bancario------*");
            Console.WriteLine("\n\n\nPresione una tecla...");
            Console.ReadKey();
            cp.MenuPrincipal();
        }
    }
}
