using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
            // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el
            // monto total a pagar. Usar la función.

            int a, b, c;
            
            Console.WriteLine("Ingrese un número");
            a= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            b= int.Parse(Console.ReadLine());

            c=producto(a,b);

            Console.WriteLine(c);


            
     
        }

        static int producto(int n1 , int n2){

            int r;
            r = n1*n2;

            return r;
        }
    }

}
