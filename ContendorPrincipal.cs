using System;
using System.Collections.Generic;

namespace Tarea_1
{
    class ContenedorPrincipal
    {
        //Listado de empleados
        List<TiempoCompleto> EmpleadoTiempoC = new List<TiempoCompleto>();
        List<MedioTiempo> EmpleadoMedioT = new List<MedioTiempo>();
        List<Temporero> EmpleadoTemp = new List<Temporero>();
        //Referencias de instancia de clases
        TiempoCompleto empleadoTiempoC;
        MedioTiempo empleadoMedioT;
        //Atributos
        private int opcion;
        private string status;
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
            while (opcion < 1 || opcion > 5)
            {
                Console.Clear();
                Console.WriteLine("*------Sistema Bancario------*");
                Console.WriteLine("\nMenu Registro Empleado");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.WriteLine("1. Agregar Empleado");
                Console.WriteLine("2. Ver Listado de Empleado");
                Console.WriteLine("3. Volver Menu Principal");
                Console.WriteLine("4. Salir");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        status = "Add";
                        MenuEmpleado();
                        break;
                    case 2:
                        status = "Show";
                        MenuEmpleado();
                        break;
                    case 3:
                        Console.Clear();
                        MenuPrincipal();
                        break;
                    case 4:
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
                        switch (status)
                        {
                            case "Add":
                                Console.Clear();
                                Console.WriteLine("*------Sistema Bancario------*\n");
                                empleadoTiempoC = new TiempoCompleto();
                                empleadoTiempoC.TipoEmpleado = "Tiempo Completo";
                                empleadoTiempoC.MetodoPago = "Este empleado cobra por cuenta bancaria";
                                empleadoTiempoC.HoraTrabajo = 8;
                                Console.Write("Nombre: ");
                                empleadoTiempoC.Nombre = Console.ReadLine();
                                Console.Write("Numero Cuenta: ");
                                empleadoTiempoC.NumeroCuenta = int.Parse(Console.ReadLine());
                                Console.Write("Precio por Hora: ");
                                empleadoTiempoC.PrecioHora = double.Parse(Console.ReadLine());
                                empleadoTiempoC.cobrar();
                                EmpleadoTiempoC.Add(empleadoTiempoC);
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.WriteLine("Se ha registrado correctamente!...");
                                Console.WriteLine("Presione una tecla para volver....");
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.ReadKey();
                                MenuRegistro();
                                break;
                            case "Show":
                                if (EmpleadoTiempoC.Count == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("No hay Empleado de Tiempo Completo Registrado!...");
                                    Console.WriteLine("Presiona una Tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistro();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    foreach (TiempoCompleto i in EmpleadoTiempoC)
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

                        }
                        break;
                    //Medio Tiempo
                    case 2:
                        switch (status)
                        {
                            case "Add":
                                Console.Clear();
                                Console.WriteLine("*------Sistema Bancario------*\n");
                                empleadoMedioT = new MedioTiempo();
                                empleadoMedioT.TipoEmpleado = "Medio Tiempo";
                                empleadoMedioT.MetodoPago = "Este empleado cobra por cuenta bancaria";
                                empleadoMedioT.HoraTrabajo = 4;
                                Console.Write("Nombre: ");
                                empleadoMedioT.Nombre = Console.ReadLine();
                                Console.Write("Numero Cuenta: ");
                                empleadoMedioT.NumeroCuenta = int.Parse(Console.ReadLine());
                                Console.Write("Precio por Hora: ");
                                empleadoMedioT.PrecioHora = double.Parse(Console.ReadLine());
                                empleadoMedioT.cobrar();
                                EmpleadoMedioT.Add(empleadoMedioT);
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.WriteLine("Se ha registrado correctamente!...");
                                Console.WriteLine("Presione una tecla para volver....");
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.ReadKey();
                                MenuRegistro();
                                break;
                            case "Show":
                                if (EmpleadoMedioT.Count == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("No hay Empleado de Medio Tiempo Registrado!...");
                                    Console.WriteLine("Presiona una Tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistro();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    foreach (MedioTiempo i in EmpleadoMedioT)
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
                        }
                        break;
                    //Temporero
                    case 3:
                        switch (status)
                        {
                            case "Add":
                                Console.Clear();
                                Console.WriteLine("*------Sistema Bancario------*\n");
                                Temporero temporero = Temporero.GetTemporero();
                                temporero.TipoEmpleado = "Temporero";
                                temporero.MetodoPago = "Este empleado cobra por cheque";
                                temporero.HoraTrabajo = 9;
                                Console.Write("Nombre: ");
                                temporero.Nombre = Console.ReadLine();
                                Console.Write("Numero Cuenta: ");
                                temporero.NumeroCuenta = int.Parse(Console.ReadLine());
                                Console.Write("Precio por Hora: ");
                                temporero.PrecioHora = double.Parse(Console.ReadLine());
                                temporero.cobrar();
                                EmpleadoTemp.Add(temporero);
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.WriteLine("Se ha registrado correctamente!...");
                                Console.WriteLine("Presione una tecla para volver....");
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.ReadKey();
                                MenuRegistro();
                                break;
                            case "Show":
                                if (EmpleadoTemp.Count == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("No hay Empleado de Medio Tiempo Registrado!...");
                                    Console.WriteLine("Presiona una Tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistro();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    foreach (Temporero i in EmpleadoTemp)
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
                        }

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
