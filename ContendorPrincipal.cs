using System;

namespace Tarea_1
{
    class ContenedorPrincipal
    {
        public void MenuPrincipal()
        {
            int opcion = 0;
            while(opcion < 1 || opcion > 3)
            {
                Console.Clear();
                Console.WriteLine("Sistema Bancario");
                Console.WriteLine("1. Usuarios");
                Console.WriteLine("2. Empleados");
                Console.WriteLine("3. Salir");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Usuario");
                        break;
                    case 2:
                        Console.WriteLine("Empleado");
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                } 
            }
        }
    }
}