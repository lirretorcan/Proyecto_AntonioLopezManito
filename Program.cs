using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion___Practica_2._1___Gestion_hospital
{   
    /// <summary>
    /// Clase que permite definir las constantes en todo el espacio de nombre
    /// </summary>
    public class Constante
    {
        public const int TAMAÑOARRAYPERSONAS = 100;
        public const int N_CAMA = 2;
        public const int N_HABITACION = 10;
        public const int N_TRATAMIENTOS = 100;
    }


    

    class Program
    {

        static Hospital hospital = new Hospital();


        /// #############################################################################################
        /// #############################################################################################
        ///                                           MAIN
        /// #############################################################################################
        /// #############################################################################################
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            hospital.InicializarPacientes();
            hospital.InicializarCamas();

            MenuPrincipal();

        }




        // ###############################################################################################
        // ###############################################################################################
        //                                        FUNCIONES SUELTAS
        // ###############################################################################################
        // ###############################################################################################


        /// <summary>
        /// Mensaje que muestra las palabras por pantalla "Buscar paciente"
        /// </summary>
        public static void MostrarBuscarPaciente()
        {
        	Console.Clear();
			Console.Write(@"
  ______                                             _            _
  | ___ \                                           (_)          | |      
  | |_/ /_   _ ___  ___ __ _ _ __   _ __   __ _  ___ _  ___ _ __ | |_ ___ 
  | ___ | | | / __|/ __/ _` | '__| | '_ \ / _` |/ __| |/ _ | '_ \| __/ _ \
  | |_/ | |_| \__ | (_| (_| | |    | |_) | (_| | (__| |  __| | | | ||  __/
  \____/ \__,_|___/\___\__,_|_|    | .__/ \__,_|\___|_|\___|_| |_|\__\___|
                                   | |                                    
                                   |_|       
");
			Console.WriteLine();        	
        }
        
        
        

        /// <summary>
        /// Menú principal de la aplicación. Es la función que se llama al principio del programa, en el main.
        /// </summary>
        public static void MenuPrincipal()
        {
            string  op;
            
            do
            {
                Console.Clear();
				Console.Write(@"                
		 _   _ _____ ___________ _____ _____ ___  _    
		| | | |  _  /  ___| ___ |_   _|_   _/ _ \| |     
		| |_| | | | \ `--.| |_/ / | |   | |/ /_\ | |      
		|  _  | | | |`--. |  __/  | |   | ||  _  | |       
		| | | \ \_/ /\__/ | |    _| |_  | || | | | |____   
		\_| |_/\___/\____/\_|    \___/  \_/\_| |_\_____/  
		__   _____ _____ _____ _   ___   _______ _____ 
		\ \ / / _ |_   _|  ___| | / | | | | ___ |  _  |
		 \ V / /_\ \| | | |__ | |/ /| | | | |_/ | | | |
		  \ /|  _  || | |  __||    \| | | |    /| | | | 	
		  | || | | || | | |___| |\  | |_| | |\ \\ \_/ /
		  \_/\_| |_/\_/ \____/\_| \_/\___/\_| \_|\___/
");
                Console.WriteLine("\n ------------------------------------------------------------------------------");
                Console.WriteLine("                            1. Urgencias");
                Console.WriteLine("                            2. Hospitalización");
                Console.WriteLine("                            3. Consultas externas");
                Console.WriteLine(" ------------------------------------------------------------------------------");
                Console.WriteLine("                            4. Configurar parámetros ");
                Console.WriteLine("                            0. Salir");
                Console.WriteLine("                             -----------");
                Console.WriteLine("                            | Opcion |  | ");
                Console.WriteLine("                             -----------");
                Console.SetCursorPosition(38, 22);
                op = Console.ReadLine();

                switch (op)
                { 
                    case "1":
                        MenuUrgencias();
                        break;
                    case "2":
                        MenuHospitalizacion();
                        break;
                    case "3":
                        MenuConsultas();
                        break;
                    default:
                        break;
                }

            } while (op != "0");

        }



        
        
        public static void MenuUrgencias()
        {
            Console.Clear();

            string op ;
            int posicionArrayPaciente = 0;
            string dni;
            
            #region BuscarDniDelPaciente
            do
            {
            	MostrarBuscarPaciente();
                Console.Write("\n\n   Introduzca el dni del paciente");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(" (-1 para salir): ");
                Console.ForegroundColor = ConsoleColor.Black;
                dni = Console.ReadLine();

                if (dni == "-1") { break; }


                //Comprueba si el dni ya ha sido creado. Si no existe, se crea uno nuevo. 
                for (int i = 0; i <= hospital.N_Pacientes; i++) 
                {
                    
                    if (hospital.paciente[i].ExisteDNI(dni) == true ) // Comprueba si existe el campo dni.
                    {
                        posicionArrayPaciente = i;
                        break;
                    }

                    if (i == hospital.N_Pacientes) // Comprueba si llega al final del bucle sin encontrar el dni.
                    {
                        if (hospital.N_Pacientes == Constante.TAMAÑOARRAYPERSONAS)
                        {
                            Console.Write("El hospital está lleno");
                        }
                        
                        else
                        {   
							// Si no encuentra el dni, crea un nuevo paciente.                        	
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\n   Paciente no encontrado. \n\n");
                            Console.ReadKey();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
							
                            for (int e = 0; e <= hospital.N_Pacientes; e++)
                            {
                                if (hospital.paciente[e].EstaLibre())
                                {
                                    posicionArrayPaciente = e;
                                    
                                    // Crea un paciente, y añade un tratamiento.
                                    hospital.NuevoPaciente(dni, posicionArrayPaciente);
                                    hospital.ModificarTratamiento(hospital.IndiceArrayPaciente(dni));
                                    break;
                                }
                            }
                            

                            break;
                        }
                    }

                }
				#endregion
				
				
				
                #region Tratamientos y estado
                do
                {
	                int posPaciente=hospital.IndiceArrayPaciente(dni);
	                
	                         
					Console.Clear();
	                hospital.paciente[posPaciente].getPaciente(posPaciente);
	                Console.WriteLine();
	
	                hospital.paciente[posPaciente].getTratamiento();
	                Console.ForegroundColor = ConsoleColor.DarkCyan;
	                Console.WriteLine(" ------------------------------------------------------------------------------");
	                Console.ForegroundColor = ConsoleColor.Black;
	                Console.WriteLine("  1. Añadir tratamiento");
	                Console.WriteLine("  2. Cambiar estado ");
	                Console.WriteLine("  3. Cambiar médico");
	                Console.WriteLine("  4. Modificar paciente");
	                Console.WriteLine("  5. Buscar tratamiento");
	                Console.ForegroundColor = ConsoleColor.DarkCyan;
	                Console.WriteLine(" ------------------------------------------------------------------------------");
	                Console.ForegroundColor = ConsoleColor.Black;
	                Console.WriteLine("  0. Salir");
	                Console.ForegroundColor = ConsoleColor.DarkCyan;
	                Console.WriteLine(" ------------------------------------------------------------------------------");
	                Console.ForegroundColor = ConsoleColor.Black;
	                Console.Write("\n       Opcion: ");
	                op = Console.ReadLine();
	
	                switch (op)
	                { 
	                	case "1":
	                        hospital.ModificarTratamiento(posPaciente);
	                        break;
	                    case "2":
							hospital.ModificarEstadoPaciente(posPaciente);
	                        break;
	                    case "3":
	                        hospital.ModificarMedico(posPaciente);
	                        break;
	                    case "4":
	                        hospital.ModificarPaciente(hospital.paciente[posPaciente].getDNI(), posPaciente);
	                        break;
	                    case "5":
	                        hospital.EscribirTratamientoPorDefinicion(posPaciente);
	                        break;
	                    default:
	                        break;
	                }
	
	                #endregion
                } while(op != "0");          
                
            } while (op != "0");

        } // FIN MenuUrgencias();

        
        
        public static void MenuHospitalizacion()
        {
        	string  op, dni;
        	int posArrayPaciente = 0, posPaciente = 0;
        	bool dniEncontrado = false, estadoAlta = false;
        	

            Console.Clear();
            
            MostrarBuscarPaciente();
            Console.Write("\n\n   Introduzca el dni del paciente");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" (-1 para salir): ");
            Console.ForegroundColor = ConsoleColor.Black;
            dni = Console.ReadLine();

            if (dni == "-1"){}
            else
            {
	            for(int i=0; i< hospital.N_Pacientes; i++)
	            {
	            	if(hospital.paciente[i].ExisteDNI(dni) == true)
	            	{
	            		posArrayPaciente = i;
	            		dniEncontrado = true;
	            		if(hospital.paciente[i].getEstadoPaciente() == "Alta")
	            		{
	            			estadoAlta = true;
	            		}
	            		break;
	            	}
	            	
	            	if(i == hospital.N_Pacientes)
	            	{
	            		dniEncontrado = false;
	            	}
	            }
	            
            }
                

            
            do
            {
	            // ########## 
	            //    MENU
	            // ##########
	            
	            if(dni == "-1" ) { break; }
	            
	            if(dniEncontrado == false) 
	            {
	            	Console.Write("\n  El dni no corresponde a ningún paciente...");
	            	Console.ReadKey();
	            	break;
	            }
	            
	            if(estadoAlta == true)
	            {
	            	Console.Write("\n  El paciente está de alta. Debe ser ingresado primero...");
	            	Console.ReadKey();
	            	break;
	            }
	            
	            posPaciente = hospital.IndiceArrayPaciente(dni);
				Console.Clear();
	            hospital.paciente[posPaciente].getPaciente(posPaciente);
	            Console.WriteLine();
	
	            hospital.paciente[posPaciente].getTratamiento();
	            Console.ForegroundColor = ConsoleColor.DarkCyan;
	            Console.WriteLine(" ------------------------------------------------------------------------------");
	            Console.ForegroundColor = ConsoleColor.Black;
	            Console.WriteLine("  1. Mostrar camas / Asignar cama");
	            Console.WriteLine("  2. Añadir tratamiento");
	            Console.WriteLine("  3. Dar alta");
	            Console.ForegroundColor = ConsoleColor.DarkCyan;
	            Console.WriteLine(" ------------------------------------------------------------------------------");
	            Console.ForegroundColor = ConsoleColor.Black;
	            Console.WriteLine("  0. Salir");
	            Console.ForegroundColor = ConsoleColor.DarkCyan;
	            Console.WriteLine(" ------------------------------------------------------------------------------");
	            Console.ForegroundColor = ConsoleColor.Black;
	            Console.Write("\n        Opcion: ");
	            op = Console.ReadLine();
	
	            switch (op)
	            { 
	                case "1":
	            		hospital.MostrarCamas(dni);
	                    break;
	                case "2":
	                    hospital.ModificarTratamiento(posPaciente);
	                    break;
	                case "3":
	                    hospital.paciente[posPaciente].DarAltaPaciente();
	                    Console.Write("\n El paciente está dado de alta...");
	                    Console.ReadKey();
	                    break;
	                default:
	                    break;
	            }
	            
	            if(hospital.paciente[posPaciente].getEstadoPaciente() == "Alta")
	            { break; }
	            
            } while (op != "0" || dniEncontrado == false);
        }
        
		
        public static void MenuConsultas()
        {
        	string  op;
        	string dni;
        	int posPaciente = 0;
            
            do
            {
                Console.Clear();
                Console.WriteLine("                     -----   Consultas Externas   -----");
                Console.WriteLine("\n ------------------------------------------------------------------------------");
                Console.WriteLine("                            1. Ver pacientes");
                Console.WriteLine("                            2. Buscar pacientes");
                Console.WriteLine("                            3. Añadir tratamiento");
                Console.WriteLine(" ------------------------------------------------------------------------------");
                Console.WriteLine("                            0. Salir");
                Console.WriteLine(" ------------------------------------------------------------------------------");
                Console.Write("                               Opcion: ");
                op = Console.ReadLine();
				MostrarBuscarPaciente();
				
                switch (op)
                { 
                    case "1":
                		hospital.VerPacientesConsultas();
                        break;
                    case "2":
                        hospital.BuscarPacientePorDNI();
                        break;
                    case "3":
                        Console.Write("\n DNI del paciente para añadir tratamiento: ");
                        dni = Console.ReadLine();
                        
                        if(dni == "-1") { break; }

                        posPaciente = hospital.IndiceArrayPaciente(dni);
                        
                        if(hospital.paciente[posPaciente].getEstadoPaciente()
                           == "Ingresado")
                        {
                        	Console.Write("  Sólo los pacientes dados de alta pueden tratarse...");
                        	Console.ReadKey();
                        	break;
                        }
                        
                        if(posPaciente != -1)
                        {
                       		hospital.ModificarTratamiento(posPaciente);
                        }
                        
                        else
                        {
                        	Console.Write("\n El DNI no corresponde a ningún paciente...");
                        	Console.ReadKey();
                        }
                        break;
                    default:
                        break;
                }

            } while (op != "0");

        }
        
        
        
    }
    


}
