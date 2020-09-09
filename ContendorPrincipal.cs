using System;
using System.Collections.Generic;

namespace Tarea_1
{
    class ContenedorPrincipal
    {
        //Listado de empleados
        List<Empleado> listadoEmpleado = new List<Empleado>();
        Empleado empleado;
        private int opcion;
        public void MenuPrincipal()
        {
            opcion = 0;
            while (opcion < 1 || opcion > 3)
            {
                Console.Clear();
                Console.WriteLine("*------Sistema Bancario------*");
                Console.WriteLine("\nMenu Principal");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.WriteLine("1. Empleados");
                Console.WriteLine("2. Clientes");
                Console.WriteLine("3. Salir");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MenuRegistro();
                        break;
                    case 2:
                        Console.WriteLine("Clientes");
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public void MenuRegistro()
        {
            opcion = 0;
            while (opcion < 1 || opcion > 6)
            {
                Console.Clear();
                Console.WriteLine("*------Sistema Bancario------*");
                Console.WriteLine("\nMenu Registro Empleado");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.WriteLine("1. Agregar Empleado");
                Console.WriteLine("2. Ver Listado de Empleado");
                Console.WriteLine("3. Eliminar Empleado");
                Console.WriteLine("4. Volver Menu Principal");
                Console.WriteLine("5. Salir");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MenuEmpleado();
                        break;
                    case 2:
                        if (listadoEmpleado.Count == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("*------Sistema Bancario------*\n");
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.WriteLine("No hay Empleado Registrado!...");
                            Console.WriteLine("Presiona una Tecla para volver....");
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.ReadKey();
                            MenuRegistro();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("*------Sistema Bancario------*\n");
                            foreach (Empleado i in listadoEmpleado)
                            {
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.WriteLine($"Tipo Empleado: {i.TipoEmpleado}");
                                Console.WriteLine($"Nombre: {i.Nombre}");
                                Console.WriteLine($"Numero de Cuenta: {i.NumeroCuenta}");
                                Console.WriteLine($"Horas de Trabajo: {i.HoraTrabajo}");
                                Console.WriteLine($"Precio Por Hora: {i.PrecioHora}");
                                Console.WriteLine($"Metodo de Pago: {i.MetodoPago}");
                                Console.WriteLine($"Salario: {i.Salario}");
                                Console.WriteLine("|*-----------------------*-*-----------------------*|\n");
                            }
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.WriteLine("Presiona una Tecla para volver....");
                            Console.WriteLine("|*-----------------------*-*-----------------------*|");
                            Console.ReadKey();
                            MenuRegistro();
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.Clear();
                        MenuPrincipal();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public void MenuEmpleado()
        {
            opcion = 0;
            while (opcion < 1 || opcion > 6)
            {
                Console.Clear();
                Console.WriteLine("*------Sistema Bancario------*");
                Console.WriteLine("\nMenu Registro Empleado");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.WriteLine("1. Tiempo Completo");
                Console.WriteLine("2. Medio Tiempo");
                Console.WriteLine("3. Temporero");
                Console.WriteLine("4. Volver Menu Registro");
                Console.WriteLine("5. Salir");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    //Tiempo Completo
                    case 1:
                        Console.Clear();
                        Console.WriteLine("*------Sistema Bancario------*\n");
                        empleado = new TiempoCompleto();
                        empleado.TipoEmpleado = "Tiempo Completo";
                        empleado.MetodoPago = "Este empleado cobra por cuenta bancaria";
                        empleado.HoraTrabajo = 8;
                        Console.Write("Nombre: ");
                        empleado.Nombre = Console.ReadLine();
                        Console.Write("Numero Cuenta: ");
                        empleado.NumeroCuenta = int.Parse(Console.ReadLine());
                        Console.Write("Precio por Hora: ");
                        empleado.PrecioHora = double.Parse(Console.ReadLine());
                        empleado.cobrar();
                        listadoEmpleado.Add(empleado);
                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                        Console.WriteLine("Se ha registrado correctamente!...");
                        Console.WriteLine("Presione una tecla para volver....");
                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                        Console.ReadKey();
                        MenuRegistro();
                        break;
                    //Medio Tiempo
                    case 2:
                        Console.Clear();
                        Console.WriteLine("*------Sistema Bancario------*\n");
                        empleado = new MedioTiempo();
                        empleado.TipoEmpleado = "Medio Tiempo";
                        empleado.MetodoPago = "Este empleado cobra por cuenta bancaria";
                        empleado.HoraTrabajo = 4;
                        Console.Write("Nombre: ");
                        empleado.Nombre = Console.ReadLine();
                        Console.Write("Numero Cuenta: ");
                        empleado.NumeroCuenta = int.Parse(Console.ReadLine());
                        Console.Write("Precio por Hora: ");
                        empleado.PrecioHora = double.Parse(Console.ReadLine());
                        empleado.cobrar();
                        listadoEmpleado.Add(empleado);
                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                        Console.WriteLine("Se ha registrado correctamente!...");
                        Console.WriteLine("Presione una tecla para volver....");
                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                        Console.ReadKey();
                        MenuRegistro();
                        break;
                    case 4:
                        Console.Clear();
                        MenuRegistro();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
