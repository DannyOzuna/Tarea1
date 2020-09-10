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
        List<Ahorrantes> ListadoAhorrante = new List<Ahorrantes>();
        List<Inversionista> ListadoInversionista = new List<Inversionista>();
        //Referencias de instancia de clases
        TiempoCompleto empleadoTiempoC;
        MedioTiempo empleadoMedioT;
        Ahorrantes ahorrantes;
        //Atributos
        private int opcion;
        private string status;
        //Requerimiento A
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
                        MenuRegistroCliente();
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
            while (opcion < 1 || opcion > 4)
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
            while (opcion < 1 || opcion > 5)
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
                                if (EmpleadoTemp.Count != 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("Ya existe un empleado Temporero registrado!...");
                                    Console.WriteLine("Presiona una Tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistro();
                                }
                                else
                                {
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
                                }
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
        //Requerimiento B
        public void MenuRegistroCliente()
        {
            opcion = 0;
            while (opcion < 1 || opcion > 4)
            {
                Console.Clear();
                Console.WriteLine("*------Sistema Bancario------*");
                Console.WriteLine("\nMenu Regitro Cliente");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.WriteLine("1. Agregar Cliente");
                Console.WriteLine("2. Ver Listado de Cliente");
                Console.WriteLine("3. Volver Menu Principal");
                Console.WriteLine("4. Salir");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        status = "Add";
                        MenuCliente();
                        break;
                    case 2:
                        status = "Show";
                        MenuCliente();
                        break;
                    case 3:
                        MenuPrincipal();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public void MenuCliente()
        {
            opcion = 0;
            while (opcion < 1 || opcion > 3)
            {
                Console.Clear();
                Console.WriteLine("*------Sistema Bancario------*");
                Console.WriteLine("\nMenu Cliente");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.WriteLine("1. Ahorrante");
                Console.WriteLine("2. Inversionista");
                Console.WriteLine("3. Volver al Atras...");
                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    //Ahorrante
                    case 1:
                        switch (status)
                        {
                            case "Add":
                                Console.Clear();
                                Console.WriteLine("*------Sistema Bancario------*\n");
                                ahorrantes = new Ahorrantes();
                                Console.Write("Nombre: ");
                                ahorrantes.Nombre = Console.ReadLine();
                                Console.Write("Numero de Cuenta: ");
                                ahorrantes.NCuenta = int.Parse(Console.ReadLine());
                                Console.Write("Monton: ");
                                ahorrantes.Monto = int.Parse(Console.ReadLine());
                                ahorrantes.calculoComision();
                                ListadoAhorrante.Add(ahorrantes);
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.WriteLine("Se ha registrado correctamente!...");
                                Console.WriteLine("Presione una tecla para volver....");
                                Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                Console.ReadKey();
                                MenuRegistroCliente();
                                break;
                            case "Show":
                                if (ListadoAhorrante.Count == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("No hay Cliente Ahorrante Registrado!...");
                                    Console.WriteLine("Presiona una Tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistroCliente();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    foreach (Ahorrantes i in ListadoAhorrante)
                                    {
                                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                        Console.WriteLine($"Nombre: {i.Nombre}");
                                        Console.WriteLine($"Numero de Cuenta: {i.NCuenta}");
                                        Console.WriteLine($"Monto: {i.Monto}");
                                        Console.WriteLine($"Comision: {i.Comision}");
                                        Console.WriteLine("|*-----------------------*-*-----------------------*|\n");
                                    }
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("Presiona una Tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistroCliente();
                                }
                                break;
                        }
                        break;
                    //Invesionista
                    case 2:
                        switch (status)
                        {
                            case "Add":
                                if (ListadoInversionista.Count != 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("Ya existe un cliente Inversionista registrado!...");
                                    Console.WriteLine("Presiona una Tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistroCliente();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    Inversionista inversionista = Inversionista.GetInversionista();
                                    Console.Write("Nombre: ");
                                    inversionista.Nombre = Console.ReadLine();
                                    Console.Write("Numero de Cuenta: ");
                                    inversionista.NCuenta = int.Parse(Console.ReadLine());
                                    Console.Write("Monton: ");
                                    inversionista.Monto = double.Parse(Console.ReadLine());
                                    Console.Write("Inversion: ");
                                    inversionista.Inversion = double.Parse(Console.ReadLine());
                                    inversionista.calculoComision();
                                    ListadoInversionista.Add(inversionista);
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("Se ha registrado correctamente!...");
                                    Console.WriteLine("Presione una tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistroCliente();
                                }
                                break;
                            case "Show":
                                if (ListadoInversionista.Count == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("No hay Inversionista Registrado!...");
                                    Console.WriteLine("Presiona una Tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistroCliente();
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("*------Sistema Bancario------*\n");
                                    foreach (Inversionista i in ListadoInversionista)
                                    {
                                        Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                        Console.WriteLine($"Nombre: {i.Nombre}");
                                        Console.WriteLine($"Numero de Cuenta: {i.NCuenta}");
                                        Console.WriteLine($"Monto: {i.Monto}");
                                        Console.WriteLine($"Comision: {i.Comision}");
                                        Console.WriteLine($"Inversion: {i.Inversion}");
                                        Console.WriteLine("|*-----------------------*-*-----------------------*|\n");
                                    }
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.WriteLine("Presiona una Tecla para volver....");
                                    Console.WriteLine("|*-----------------------*-*-----------------------*|");
                                    Console.ReadKey();
                                    MenuRegistroCliente();
                                }
                                break;
                        }
                        break;
                    case 3:
                        MenuRegistroCliente();
                        break;
                }
            }
        }
    }
}
