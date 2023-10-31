using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio11
{
    public class pantallas
    {
        public static int i = 0;
        public static int j = 0;
        public static int n = 1;
        public static int[]Notas = new int[100];
        public static int[]notamayor = new int[1];
        public static int[]notamenor = new int[1];

        public static int menuPrincipal()
        {
            Console.Clear();
            Console.Write("" +
                            "================================\n" +
                            "Casos con arreglos \n" +
                            "================================\n" +
                            "1: Registrar notas\n" +
                            "2: Hallar la nota mayor\n" +
                            "3: Hallar la nota menor\n" +
                            "4: Encontrar una nota\n" +
                            "5: Modificar una nota\n" +
                            "6: Ver notas registradas\n" +
                            "7: Salir\n" +
                            "================================\n" +
                            "Ingrese una opción: ");
            return opcionPrincipal();
        }
       

        public static int RegistrarNota()
        {
            Console.Clear();
            Console.Write("================================\n" +
                            "Registrar una nota\n" +
                            "================================\n");
                            string texto1 = ("Ingresa la nota Nro "+n+": ");
                            Console.Write(texto1);
                            Notas[i] = int.Parse(Console.ReadLine());
                            i++;
                            j++;
                            n++;
                            string texto2 = "================================\n" +
                            "1: Registrar otra nota\n" +
                            "2: Regresar\n" +
                            "================================\n" +
                            "Ingrese una opción: ";
            
            Console.Write(texto2);
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1) return 1;
            if (opcion == 2) return 0;
            return opcion;
        }

        
        public static int NotaMayor()
        {

            int numeroMayor = Notas[0];

            for (int i = 1; i < j; i++)
            {
                if (Notas[i] > numeroMayor)
                {
                    numeroMayor = Notas[i];
                }
            }


            Console.Clear();
            Console.Write("================================\n" +
                            "La nota mayor\n" +
                            "================================\n");
                            string texto1 = "La nota mayor es: " + numeroMayor +"\n";
            Console.Write(texto1);

            for (i = 0; i < j; i++)
            {
                if (Notas[i] == numeroMayor)
                {
                    Console.Write(" [" + numeroMayor + "] ");
                }
                else
                {
                    Console.Write(Notas[i]+" ");
                }
                
            }
                           

                            string texto2 = "\n================================\n" +
                            "1: Regresar\n" +
                            "================================\n";
            Console.Write(texto2);
            return pieDePantalla();
        }



        public static int NotaMenor()
        {
            int numeroMenor = Notas[0];

            for (int i = 1; i < j; i++)
            {
                if (Notas[i] < numeroMenor)
                {
                    numeroMenor = Notas[i];
                }
            }


            Console.Clear();
            Console.Write("================================\n" +
                            "La nota menor\n" +
                            "================================\n");
            string texto1 = "La nota menor es: " + numeroMenor + "\n";
            Console.Write(texto1);

            for (i = 0; i < j; i++)
            {
                if (Notas[i] == numeroMenor)
                {
                    Console.Write(" [" + numeroMenor + "] ");
                }
                else
                {
                    Console.Write(Notas[i] + " ");
                }

            }

            string texto2 = "\n================================\n" +
            "1: Regresar\n" +
            "================================\n";
            Console.Write(texto2);
            return pieDePantalla();
        }



        public static int BuscarNota()
        {
            int orden = 0;
            int ordenencontrado = 0;
            Console.Clear();
            Console.Write("================================\n" +
                            "Buscar nota\n" +
                            "================================\n");
                            string texto1="Ingrese la nota a buscar: "; 
                            Console.Write(texto1);
                            int buscar = int.Parse(Console.ReadLine());


            int buscarNota = buscar;

            for (int i = 1; i < j; i++)
            {
                if (Notas[i] == buscarNota)
                {
                    buscarNota = Notas[i];
                }
            }



            for (i = 0; i < j; i++)
            {
                if (Notas[i] == buscarNota)
                {
                    Console.WriteLine(orden + " -> [" + buscarNota + "]");
                    ordenencontrado = orden;
                    orden++;
                }
                else
                {
                    Console.WriteLine(orden+ " -> " + Notas[i] );
                    orden++;
                }

            }
                            string texto2 = "La nota está en la posición : "+ordenencontrado+"\n";
                            Console.Write(texto2);

            Console.Write("================================\n" +
                            "1: Regresar\n" +
                            "================================\n");
            return pieDePantalla();
        }




        public static int ModificarNota()
        {
            Console.Clear();
            Console.Write("================================\n" +
                            "Modificar nota\n" +
                            "================================\n");
                            string texto1="Ingrese la posición: ";
                            Console.Write(texto1);
                            int posicion = int.Parse(Console.ReadLine());

                            string texto2="Ingrese el nuevo valor: ";
                            Console.Write(texto2);
                            int valornuevo = int.Parse(Console.ReadLine());


            int buscarNota = 0;

            for (int i = 0; i < j; i++)
            {
                if (Notas[i] == Notas[posicion])
                {
                    buscarNota = Notas[i];
                }
            }

            
            string texto3 = "\n================================\n" +
                            "Antes:\n";
            Console.Write(texto3);

            for (i = 0; i < j; i++)
            {
                if (Notas[i] == buscarNota)
                {
                    Console.Write(" [" + buscarNota + "] ");
                }
                else
                {
                    Console.Write(Notas[i] + " ");
                }

            }


            for (int i = 0; i < j; i++)
            {
                if (Notas[i] == Notas[posicion])
                {

                    Notas[posicion] = valornuevo;
                }
            }

            string texto4 = "\nDespués:\n";                
            Console.Write(texto4);

            for (i = 0; i < j; i++)
            {
                if (Notas[i] == valornuevo)
                {
                    Console.Write(" [" + valornuevo + "] ");
                }
                else
                {
                    Console.Write(Notas[i] + " ");
                }

            }

            Console.Write("\n================================\n" +
                            "1: Regresar\n" +
                            "================================\n");
            return pieDePantalla();
        }






        public static int NotasRegistradas()
        {
            Console.Clear();
            Console.Write("================================\n" +
                            "Notas Registradas\n" +
                            "================================\n" +
                            "Notas actuales:\n" +
                            "\n");
            for (i = 0; i < j; i++)
            {
                if (i == 0)
                {
                    Console.Write(Notas[i]);
                }
                else
                {
                    Console.Write(" - " + Notas[i]);
                }
            }
                            
                            Console.Write("\n");
                            int posicion = i+1;
                            Console.Write("\nSiguiente posición será: "+posicion+"\n" +
                            "\n" +
                            "================================\n" +
                            "1: Regresar\n" +
                            "================================\n");
            return pieDePantalla();
            
        }





        private static int pieDePantalla()
        {
            Console.Write("\nIngrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1) return 0;
            return opcion;
        }

        public static int opcionPrincipal()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }

    }
}
