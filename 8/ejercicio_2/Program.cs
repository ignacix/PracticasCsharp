using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
            //    Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
            
            
            int n, cont=0;
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                n=int.Parse(Console.ReadLine());

                if(par(n)==1){
                    cont++;
                }
            }
            Console.WriteLine("Hay "+cont+" numeros pares");

        }

        static int par(int a){
            
            int r;
            
            if(a%2==0){
                r=1;
            }else{
                r=0;
            }

            return r;
        }
    }
}
