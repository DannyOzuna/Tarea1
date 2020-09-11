using System;
namespace Tarea_1
{
    class MedioTiempo : Empleado
    {
        public MedioTiempo(string tipoEmpleado, string nombre, int numeroCuenta, double precioHora, string metodoPago, int horaTrabajo)
        {
            TipoEmpleado = tipoEmpleado;
            Nombre = nombre;
            NumeroCuenta = numeroCuenta;
            PrecioHora = precioHora;
            MetodoPago = metodoPago;
            HoraTrabajo = horaTrabajo;
        }
        public override double cobrar()
        {
            Salario = PrecioHora * 4;
            return Salario;
        }
    }
}