using System;
namespace Tarea_1
{
    class Temporero:Empleado
    {
        private static Temporero temporero = null;
        private Temporero(/*string tipoEmpleado, string nombre, double precioHora, string metodoPago, int horaTrabajo, double salario*/){
            /*TipoEmpleado = TipoEmpleado;
            Nombre = nombre;
            PrecioHora = precioHora;
            MetodoPago = metodoPago;
            HoraTrabajo = horaTrabajo;
            Salario = salario;*/
        }

        public static Temporero GetTemporero(/*string tipoEmpleado, string nombre, double precioHora, string metodoPago, int horaTrabajo, double salario*/)
        {
            if(temporero == null)
            {
                temporero = new Temporero(/*tipoEmpleado, nombre, precioHora, metodoPago, horaTrabajo, salario*/);
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