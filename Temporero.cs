using System;
namespace Tarea_1
{
    class Temporero:Empleado
    {
        private static Temporero temporero = null;
        private Temporero(){
        }

        public static Temporero GetTemporero()
        {
            if(temporero == null)
            {
                temporero = new Temporero();
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