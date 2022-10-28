using System;

namespace cuarto_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int sFijo = 150000;
            double tFacturado;
            double sueldoTotal;
            Console.WriteLine("Ingrese el total facturado");
            tFacturado = double.Parse(Console.ReadLine());
            sueldoTotal =  sFijo + (tFacturado * 0.05);
            Console.WriteLine( "El sueldo total es: "+sueldoTotal);


        }
    }
}
