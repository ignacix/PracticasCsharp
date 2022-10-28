using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double importe,litros;

            Console.Write("Ingrese el importe");
            importe=double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros");
            litros=double.Parse(Console.ReadLine());

            if(litros>=101){

                if(litros<301){
                    importe= importe*0.90;
                }else if(litros<501){
                    importe=importe*0.85;
                }else{
                    importe=importe*0.75;
                }

            }
            
            Console.Write("El importe es: " + importe);

        }
    }
}
