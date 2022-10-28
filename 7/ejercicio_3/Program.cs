using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
            //   El programa deberá generar una cadena donde todas las ocurrencias del primer carácter
            //   dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            //     CADENA FUENTE: “La mar estaba serena"
            //     CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //     CADENA RESULTADO: “Li mir estibi sereni"

            char[] cadenaCaracter= new char[30];
            char c1, c2;
            int i = 0;
            char letra;
            Console.WriteLine("ingrese una frase letra por letra(ingrese 0 al final para cargar)!");
            
            do
            {   
                letra=char.Parse(Console.ReadLine());
                cadenaCaracter[i]=letra;
                i++;
            } while (letra!='0');

            cadenaCaracter[i-1]='\0';

            Console.WriteLine("cargame la primera palabra");
            c1=char.Parse(Console.ReadLine());
            Console.WriteLine("cargame la segunda palabra");
            c2=char.Parse(Console.ReadLine());

            for (int x = 0; x < i; x++)
            {

                if (cadenaCaracter[x]==c1)
                {
                    cadenaCaracter[x]=c2;
                }
            }

            for (int x = 0; x < i; x++)
            {
                Console.Write(cadenaCaracter[x]);
            }




        } 
    }
}
