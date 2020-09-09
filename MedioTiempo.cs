using System;
namespace Tarea_1
{
    class MedioTiempo:Empleado
    {
        public override double cobrar(){
            Salario = PrecioHora * 4;
            return Salario;
        }
    }
}