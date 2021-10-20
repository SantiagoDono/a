using System;

namespace ConsoleApp1
{
    class Program {
        // muestro matriz, recorro
        static public void MuestroMatriz(string[,] Matriz)
        {
            for (int indiceP = 0; indiceP < Matriz.GetLength(0); indiceP++)
            {
                for (int indiceF = 0; indiceF < Matriz.GetLength(1); indiceF++)
                {
                    Console.Write(Matriz[indiceP, indiceF] + " ");
                }
                Console.WriteLine();
            }
        }
        // NO SE SI ESO ESTA BIEN
       
        // MENU
        public static void menu ()
        {
            Console.Clear();
            Console.WriteLine("**************************************************");
            Console.WriteLine("MENU");
            Console.WriteLine("************************************************** \n");

            Console.WriteLine("1- Agregar frase");

            Console.WriteLine("2- Invertir frase");

            Console.WriteLine("3- Mostrar todas las frases");

            Console.WriteLine("4- Buscar una palabra ");

            Console.WriteLine("5- Salir \n"); // no lo pide pero en la clase siempre lo pone asi que por las dudas lo puse 

            Console.Write("ingrese su opcion: ");
        }
        public static bool procesoMenu(string Opcion)
        {
            switch (Opcion.Trim())
            {
                case "1":
                    {
                        //agregarFrase();
                        break;
                    }
                case "2":
                    {
                        //"invertir frase"
                        break;
                    }
                case "3":
                    {
                        MuestroMatriz() ; // aca seria desplegar todo lo que se escribio es solo recorrer la matriz,  
                        break;
                    }
                case "4":
                    {
                        // buscar una palabra, hay un ejemplo de como hacerlo  en el ejercicio que hicimos ayer
                        break;
                    }
                case "5": return (false);

                default:
                    Console.WriteLine("opcion de menu invalida");
                    Console.ReadLine();
                    break;
            }
            return (true); // para que vuelva a repetirse el menu
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
