using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
        //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            int n;    

            
            do
            {   Console.WriteLine("Ingrese su lista de numeros de a uno!");
                int cont=0;
                n=int.Parse(Console.ReadLine());
                while (n>0 && n!=0)
                {
                    cont++;
                    n=int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Su lista tiene "+cont+" de números");

            } while (n>=0);
        }
    }
}
