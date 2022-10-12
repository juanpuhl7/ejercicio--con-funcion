using System;

namespace ejercicio__con_funcion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num=0, resultadoFactor;

            

            do{
                
                titulo();

                num=Convert.ToInt32(Console.ReadLine());

                resultadoFactor= factorNum(num);

                Console.WriteLine("El Factorial de: " + num +" es " + resultadoFactor);

                Console.ReadKey();

 
            } while(num!=0);

            Console.WriteLine("FINALIZO PROGRAMA . . . ");

        }





        static void titulo(){
                Console.Clear();
                Console.WriteLine("**FACTORIAL DE UN NUMERO**");
                Console.WriteLine("0 - Salir");    
                Console.WriteLine("Numero para Factorial: ");
                
        }

        static int factorNum(int num){
            int  factor;
            
                    factor=1;
                    for(int i=1; i<=num ; i++){
                        factor=factor*i;
                    }
                return factor;
        }


    }
}
