using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos números");
            int n1,n2,resultado;
            n1= int.Parse(Console.ReadLine());
            n2= int.Parse(Console.ReadLine());
            if(n1>n2){
                resultado=n1-n2;
            }else if(n1==n2){
                resultado=n1+n2;
            }else{
                resultado=n1*n2;
            }
            Console.WriteLine(resultado);
        }
    }
}
