using System;
namespace Tarea_1
{
    class Temporero : Empleado
    {
        private static Temporero temporero = null;
        private Temporero(string tipoEmpleado, string nombre, int numeroCuenta, double precioHora, string metodoPago, int horaTrabajo)
        {
            TipoEmpleado = tipoEmpleado;
            Nombre = nombre;
            NumeroCuenta = numeroCuenta;
            PrecioHora = precioHora;
            MetodoPago = metodoPago;
            HoraTrabajo = horaTrabajo;
        }

        public static Temporero GetTemporero(string tipoEmpleado, string nombre, int numeroCuenta, double precioHora, string metodoPago, int horaTrabajo)
        {
            if (temporero == null)
            {
                temporero = new Temporero(tipoEmpleado, nombre, numeroCuenta, precioHora, metodoPago, horaTrabajo);
                return temporero;
            }
            return temporero;
        }

        public override double cobrar()
        {
            Salario = PrecioHora * 9;
            return Salario;
        }

    }
}

