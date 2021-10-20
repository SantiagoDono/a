using System;

namespace ConsoleApp1
{
    class Program {
        // muestro matriz, recorro
        static public void MuestroMatriz(string[,] Matriz)
        {
           
        }
        // agregar frases 

        
        
            static public void agregarFrases(string[,] Matriz)
            {
            string[,] palabras = new string[25, 10];
            }
        

           
        
        static void Main(string[] args)
        {
            // creacion de la matriz
            string[,] frases = new string[25, 10];
           

                
                 
           
            
        }

        //agregar frase
        public static void agregarFrase(string[,] frases, int cantFrases)
        {
            Console.Clear();
            Console.WriteLine("Opcion 1: agregar frase");
            Console.WriteLine();
            if (frases.GetLength(0) >= cantFrases)
            {
                for (int i1 = 0; i1 < 1; i1 += 0)
                {
                    try
                    {
                        for (int i = 0; i < frases.GetLength(1); i++)
                        {
                            Console.Write("Ingrese " + i++ + "º palabra: ");
                            frases[cantFrases, i] = Console.ReadLine();
                        }
                        cantFrases++;
                        i1++;
                    }
                    catch
                    {
                        Console.WriteLine("Error, ingrese solamente palabras");
                    }
                }

            }
            else
            {
                Console.WriteLine("No queda mas espacio para otras frases.");
                Console.ReadLine();
            }
        }
    }
}
