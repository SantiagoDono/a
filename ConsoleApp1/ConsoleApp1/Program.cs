using System;

namespace ConsoleApp1
{
    class Program {

        
        
     
        
        static void Main(string[] args)
        {
            // creacion de la matriz
            string[,] frases = new string[25, 10];
          


            try
            {
                for (int fila = 0; fila <= 9; fila++)
                {
                    Console.Write("\t" + frases[0, fila]);
                    Console.WriteLine("ingrese palabra ");


                    for (int columna = 0; columna <= 24; columna++)
                    {

                    }
                }
            }
            catch 
            {

                Console.WriteLine("esta todo bien");
            }  
            
        }
    }
}
