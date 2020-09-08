using System;

namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContenedorPrincipal cp = new ContenedorPrincipal();
            Console.WriteLine("*------Bienvenido al Sistema Bancario------*");
            Console.WriteLine("Presione una tecla...");
            Console.ReadKey();
            cp.MenuPrincipal();
        }
    }
}
