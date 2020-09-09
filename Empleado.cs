using System;
namespace Tarea_1
{
    abstract class Empleado
    {
        public string TipoEmpleado{get; set;}
        public string Nombre {get; set;}
        public int NumeroCuenta {get; set;}
        public double PrecioHora {get; set;}
        public string MetodoPago {get; set;}
        public int HoraTrabajo {get; set;}
        public double Salario {get; set;}
        public abstract double cobrar();
    }
}