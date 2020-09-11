using System;
namespace Tarea_1{
    class TiempoCompleto:Empleado
    {
        public TiempoCompleto(string tipoEmpleado, string nombre, int numeroCuenta, double precioHora, string metodoPago, int horaTrabajo)
        {
            TipoEmpleado = tipoEmpleado;
            Nombre = nombre;
            NumeroCuenta = numeroCuenta;
            PrecioHora = precioHora;
            MetodoPago = metodoPago;
            HoraTrabajo = horaTrabajo;
        }
        public override double cobrar(){
            Salario = PrecioHora * 8;
            return Salario;
        }
    }
}