using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            /* 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un
             registro con los siguientes datos:
                - Número de Artículo (1 a 15)
                - Cantidad Vendida 

                Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
                Se pide determinar e informar:
                a) El número de artículo que más se vendió en total.
                b) Los números de artículos que no registraron ventas.
                c) Cuantas unidades se vendieron del número de artículo 10. */
            
            int[] VnumArt = new int[15];
            int nA,cant ,artMayor;    
            Console.WriteLine("Ingrese el número de articulo!");

            nA=int.Parse(Console.ReadLine());

            while (nA!=0)
            {   
                Console.WriteLine("Ingrese la cantidad");
                cant=int.Parse(Console.ReadLine());

                VnumArt[nA-1]+=cant;

                Console.WriteLine("Ingrese el número de articulo");
                nA=int.Parse(Console.ReadLine());
            }

            artMayor=0;

            for (int i = 0; i < 15; i++)
            {
                if (VnumArt[i]>VnumArt[artMayor])
                {
                    artMayor=i;
                }
            }
            artMayor++;

            Console.WriteLine("el articulo con más ventas fue: "+artMayor);

            Console.Write("Los articulos que no vendieron nada son: ");
            for (int i = 0; i < 15; i++)
            {
                if (VnumArt[i]==0)
                {
                    
                    Console.Write("("+(i+1)+")");
                }
            }
            
            Console.WriteLine("");
            Console.WriteLine("se vendieron "+VnumArt[9]+" unidades del articulo 10");
        }   
    }
}
