using System;
namespace Tarea_1
{
    class Ahorrantes
    {
        private string nombre;
        private int nCuenta;
        private double monto, comision;
        public Ahorrantes(string nombre, int nCuenta, double monto)
        {
            Nombre = nombre;
            NCuenta = nCuenta;
            Monto = monto;
        }
        public string Nombre { get => nombre; set => nombre = value;}
        public int NCuenta {get => nCuenta; set => nCuenta = value;}
        public double Monto{get => monto; set => monto = value;}
        public double Comision {get => comision;}
        public double calculoComision()
        {
            comision = Monto * 0.40;
            return comision;
        }
    }
}