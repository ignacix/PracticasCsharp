using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double importe;
            Console.WriteLine("ingrese el importe");

            importe=double.Parse(Console.ReadLine());

            if (importe>1000){
                if(importe>=5000){
                    importe = importe*0.82;
                }else{
                    importe= importe*0.90;
                }
                
            }

            Console.WriteLine(importe);
        }
    }
}
