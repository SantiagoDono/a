using System;

namespace ConsoleApp1
{
    class Program
    {

        // muestro matriz, recorro
        static public void muestroMatriz(string[,] matriz)
        {
            Console.Clear();
            for (int iF = 0; iF < matriz.GetLength(0); iF++)
            {
                for (int IC = 0; IC < matriz.GetLength(1); IC++)
                {
                    Console.Write(matriz[iF, IC] + " ");
                }
                Console.WriteLine();


            }
            Console.ReadLine();
        }



        // MENU

        public static void Menu(string[,] matriz)
        {
            bool sigoEjecutando = true;
            string OpcionMenu = "";

            // despliego el menu y determino acciones
            while (sigoEjecutando)
            {
                Console.Clear();
                Console.WriteLine("*******************************************");
                Console.WriteLine("MENU " + "\n");
                Console.WriteLine("1- Agregar Frase");
                Console.WriteLine("2 Invertir Frase");
                Console.WriteLine(" 3- Mostrar todas las frases");
                Console.WriteLine("4- Buscar una palabra ");
                Console.WriteLine("5- Salir " + "\n");
                Console.WriteLine("*********************************************");

                OpcionMenu = Console.ReadLine();

                // verifico que ingreso el usuario y ejecuto accion
                switch (OpcionMenu)
                {
                    case "1":
                        {
                            agregarFrase(frases);
                            break;
                        }
                    case "2":
                        {
                            // invertir Frase ;
                            break;
                        }
                    case "3":
                        {
                            muestroMatriz(frases);
                            break;
                        }
                    case "4":
                        {
                            // buscar una palabra 
                            break;
                        }
                    case " 5":
                        {
                            sigoEjecutando = false;
                            Console.Clear();
                            Console.WriteLine("gracias por usar el programa");
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error - ingrese una opcion valida ");
                            Console.ReadLine();
                            break;
                        }

                }

            }

        }





        static void Main(string[] args)
        {

            Menu(frases);

        }
        // variables que necesito para agregar frase 
        static public int contadorfrase = 0;
        static public int contadorColum = 0;
        // ACA ESTA LA MATRIZ,ASI LA PODEMOS USAR EN CUALQUIER LADO
        static public string[,] frases = new string[25, 10];

        //agregar frase
        static public void agregarFrase(string[,] matriz)
        {





            if (contadorfrase <= 25 && contadorfrase < matriz.GetLength(0))
            {

                //for (int iF = contadorfrase; iF < matriz.GetLength(0); iF++)
                //if (contadorfrase < matriz.GetLength(0))



                //{

                for (int IC = contadorColum; IC < matriz.GetLength(1); IC++)
                {

                    Console.WriteLine("ingrese una palabra: ");
                    matriz[contadorfrase, IC] = Console.ReadLine().Trim();


                }


                contadorfrase++;
                Console.WriteLine("usted agrego una frase");
                Console.ReadLine();
                Console.WriteLine("usted va en la frase numero: " + " " + contadorfrase);
                Console.ReadLine();
                //break;


                //}
            }

            else
            {
                Console.WriteLine("no puede agregar mas frases");
                Console.ReadLine();
            }



        }
    }
}
