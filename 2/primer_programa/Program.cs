using System;

namespace primer_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //esto es un comentario
            //"clear" limpia la pantalla de la consola
            //"cd" cambia el directorio
            //"dotnet new console -o primer_programa" una vez que estes en el directorio correcto con este código creas una carpeta dentro de esa carpeta
            //"ls" muestra una lista de los elementos que hay en ese directorio
            //"dotnet" es el comando que vamos a escribir siempre que querramos usar la consola
            //"dotnet run" ejecuta el código
            Console.WriteLine("1er Programa!");
            int n1, n2, resultado;
            Console.WriteLine("Ingrese un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            n2 = int.Parse(Console.ReadLine());
            resultado = n1+n2;
            Console.WriteLine("El resultado de la suma es: "+resultado);

            
                
            
        }
    }
}
