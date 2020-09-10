using System;
namespace Tarea_1
{
    class Inversionista
    {
        private static Inversionista inversionista = null;
        private string nombre;
        private int nCuenta;
        private double monto, inversion, comision;
        public string Nombre { get => nombre; set => nombre = value; }
        public int NCuenta { get => nCuenta; set => nCuenta = value; }
        public double Monto { get => monto; set => monto = value; }
        public double Comision { get => comision; }
        public double Inversion { get => inversion; set => inversion = value; }
        private Inversionista()
        {

        }
        public static Inversionista GetInversionista()
        {
            if (inversionista == null)
            {
                inversionista = new Inversionista();
                return inversionista;
            }
            return inversionista;
        }
        public double calculoComision()
        {
            comision = Monto * 0.40;
            return comision;
        }
    }
}