using System;

namespace ejercicio_3
{
    class Program
    {   
        
        static void Main(string[] args)
        {
            int cpu, ram, extiende, monto;
            monto=0;

            Console.WriteLine("Ingrese el tipo de cpu");
            cpu=int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese el tipo de ram");
            ram=int.Parse(Console.ReadLine());

            
            Console.WriteLine("Ingrese si quiere extender");
            extiende=int.Parse(Console.ReadLine());

            switch (cpu){
                case 1:
                        switch (ram){
                        
                            case 1:
                                monto=800;
                        
                                break;
                            
                            case 2:
                                monto=900;
                                break;

                            case 3:
                                monto=1200;
                                break;
                                
                        }
                   
                    
                    break;
                
                case 2:
                        switch(ram){
                            case 1:
                                monto=900;
                                break;

                            case 2:
                                monto=1000;
                                break;

                            case 3:
                                monto=1400;
                                break;
                        }
                    break;

                case 3:
                    switch(ram){
                        case 1:
                            monto=1000;
                            break;

                        case 2:
                            monto=1400;
                            break;

                        case 3:
                            monto=2000;
                            break;
                    }

                    break;
            }

            if(extiende==1){
                monto += 300;
            }

            Console.WriteLine("el monto es: " + monto);

        }
    }
}
