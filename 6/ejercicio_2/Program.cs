using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Se dispone de una lista de 5 listas de números enteros separados 
            //entre ellos por ceros. Se pide determinar e informar:

            //*El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //*Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            
            
            int n, cont, impar, mayor=0,grupoMayorPorcent=0, porcentaje=0,mayorPorcent=0,ordenados=0;
            bool llave, flag;

            
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un número!");
                n=int.Parse(Console.ReadLine());
                
                cont=0;
                impar=0;
                llave=true;
                flag=true;

                while (n!=0)
                {
                    cont++;

                    if ((n%2)!=0)
                    {
                        impar++;
                    }

                    if (flag==true)
                    {
                        mayor=n;
                        flag=false;
                    }else if (llave==true)
                    {
                        if (n<mayor)
                        {
                            mayor=n;
                        }else
                        {
                            llave=false;
                        }
                    }

                    n=int.Parse(Console.ReadLine());


                }

                porcentaje=impar*100/cont;

                if (i==0)
                {
                    mayorPorcent=porcentaje;
                    grupoMayorPorcent=i+1;
                }else if (porcentaje>mayorPorcent)
                {
                    mayorPorcent=porcentaje;
                    grupoMayorPorcent=i+1;
                }
                
                if (llave==true)
                {
                    ordenados++;
                }
                

            
            }

            Console.WriteLine("El grupo con mayor porcentaje de números impares es: "+grupoMayorPorcent);
            Console.WriteLine("La cantidad de grupos ordenados es: "+ordenados);
        }

            

            



    }
}

