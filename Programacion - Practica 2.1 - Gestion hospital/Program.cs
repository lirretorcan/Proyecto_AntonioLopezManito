using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion___Practica_2._1___Gestion_hospital
{   
    
    public class Constante
    {
        public const int TAMAÑOARRAYPERSONAS = 100;
        public const int N_CAMA = 10;
        public const int N_HABITACION = 10;
    }

    



    class Program
    {

        static Paciente[] paciente = new Paciente[Constante.TAMAÑOARRAYPERSONAS];

        static int N_Pacientes = 0;

        /// #############################################################################################
        /// #############################################################################################
        ///                                           MAIN
        /// #############################################################################################
        /// #############################################################################################
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            MenuPrincipal();

        }




        // ###############################################################################################
        // ###############################################################################################
        //                                        FUNCIONES SUELTAS
        // ###############################################################################################
        // ###############################################################################################




        /// <summary>
        /// Menú principal de la aplicación. Es la función que se llama al principio del programa, en el main.
        /// </summary>
        public static void MenuPrincipal()
        {
            Console.Clear();
            
            int op = 0;
            
            do
            {              
                Console.WriteLine("----------------");
                Console.WriteLine(" MENU PRINCIPAL");
                Console.WriteLine("----------------");
                Console.WriteLine("1. Urgencias");
                Console.WriteLine("2. Hospitalización");
                Console.WriteLine("3. Consultas externas");
                Console.WriteLine("0. Salir");
                Console.Write("\n Opcion: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                { 
                    case 1:
                        MenuUrgencias();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }

            } while (op != 0);

        }



        public static void MenuUrgencias()
        {
            Console.Clear();

            int op = 0;
            string dni;

            do
            {
                Console.Write("Paciente a buscar: ");
                dni = Console.ReadLine();

                for (int i = 0; i < N_Pacientes; i++)
                {
                    if (paciente[i].ExisteDNI(dni))
                    {
                        paciente[i].getPaciente();
                        Console.ReadLine();
                    }

                    else
                    {
                        if (N_Pacientes == Constante.TAMAÑOARRAYPERSONAS)
                        {
                            Console.Write("El hospital está lleno");
                        }
                        
                        else
                        { 
                        
                        }
                    }

                }



                Console.WriteLine("----------------");
                Console.WriteLine(" MENU URGENCIAS");
                Console.WriteLine("----------------");
                Console.WriteLine("1. Urgencias");
                Console.WriteLine("2. Hospitalización");
                Console.WriteLine("3. Consultas externas");
                Console.WriteLine("0. Salir");
                Console.Write("\n Opcion: ");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }

            } while (op != 0);

        } // FIN MenuUrgencias();


    }
    


}
