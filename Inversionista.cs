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
        private Inversionista(string nombre, int nCuenta, double monto, double inversion)
        {
            Nombre = nombre;
            NCuenta = nCuenta;
            Monto = monto;
            Inversion = inversion;
        }
        public static Inversionista GetInversionista(string nombre, int nCuenta, double monto, double inversion)
        {
            if (inversionista == null)
            {
                inversionista = new Inversionista(nombre, nCuenta, monto, inversion);
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