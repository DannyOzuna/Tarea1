using System;
namespace Tarea_1{
    class TiempoCompleto:Empleado
    {
        public override double cobrar(){
            Salario = PrecioHora * 8;
            return Salario;
        }
    }
}