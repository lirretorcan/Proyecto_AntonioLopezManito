using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion___Practica_2._1___Gestion_hospital
{
    class Hospital
    {
        public int N_Pacientes;
        
        public Paciente[] paciente = new Paciente[Constante.TAMAÑOARRAYPERSONAS];

        public Cama[,] cama = new Cama[Constante.N_HABITACION, Constante.N_CAMA];
        
        

        //#####################################################
        //                       METODOS
        //#####################################################


        public void InicializarPacientes()
        {
            for (int i = 0; i < paciente.Length; i++)
            {
                paciente[i] = new Paciente();
            }

            N_Pacientes = 0;
        }
        
        
        public void InicializarCamas()
        {
        	for(int i=0; i < Constante.N_HABITACION; i++)
        	{
        		for(int j=0; j < Constante.N_CAMA; j++)
        		{
        			cama[i, j] = new Cama();
        		}
        	}
        }
       
        
        
		/// <summary>
		/// Crea un nuevo paciente. En realidad, el paciente está creado. Modifica un objeto paciente
		/// del array paciente, de la clase Paciente, e introduce los datos el usuario.
		/// Al final, se suma 1 al número total de pacientes de la lista que hemos creado para llevar un 
		/// control sobre los pacientes que tenemos en el hospital.
		/// </summary>
		/// <param name="dni">Este parámetro indica qué paciente debemos buscar, en función del
		/// campo dni.</param>
		/// <param name="posicionPaciente">Nos indica qué posición en el array ocupa el objeto paciente,
		/// de este modo podemos rellenar de forma ordenada la lista, y no perder la cuenta del 
		/// último paciente introducido.</param>
		/// 
        public void NuevoPaciente(string dni, int posicionPaciente)
        {
            string nombre,
                   apellido1,
                   apellido2,
                   direccion,
                   fecha_nacimiento,
                   medico,
                   telefono;
            char sexo;
            int historia_clinica = paciente[N_Pacientes].HistoriaClinica(posicionPaciente);

            Console.WriteLine("  -----   NUEVO PACIENTE   -----\n");
            Console.WriteLine(" DNI : {0:9}", dni);
            Console.WriteLine(" Historia : {0}", historia_clinica+1);
            Console.WriteLine();
            Console.Write(" Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine(" Apellidos: ");
            Console.Write("   Primer apellido: ");
            apellido1 = Console.ReadLine();
            Console.Write("   Segundo apellido: ");
            apellido2 = Console.ReadLine();

            Console.Write(" Sexo: ");
            sexo = char.Parse(Console.ReadLine());

            Console.Write(" Dirección: ");
            direccion = Console.ReadLine();

            Console.Write(" Fecha de nacimiento: ");
            fecha_nacimiento = Console.ReadLine();

            Console.Write(" Teléfono: ");
            telefono = Console.ReadLine();

            Console.Write(" Médico asignado: ");
            medico = Console.ReadLine();
			
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n   Paciente iniciado correctamente.");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadKey();
            
            paciente[posicionPaciente].setPaciente(dni, nombre, apellido1, apellido2, fecha_nacimiento, 
                                                   sexo, direccion, telefono, medico);

            N_Pacientes++;
        }

        /// <summary>
        /// Modifica un paciente creado
        /// </summary>
        /// <param name="dni">Dni del paciente</param>
        /// <param name="posicionPaciente">Posición de la lista del paciente.</param>
		public void ModificarPaciente(string dni, int posicionPaciente)
        {
            string nombre,
                   apellido1,
                   apellido2,
                   direccion,
                   fecha_nacimiento,
                   medico,
                   telefono;
            char sexo;
            int historia_clinica = paciente[N_Pacientes].HistoriaClinica(posicionPaciente);
			
            Console.Clear();
            Console.WriteLine("  -----   MODIFICAR PACIENTE   -----\n");
            Console.WriteLine(" DNI : {0:9}", dni);
            Console.WriteLine(" Historia : {0}", historia_clinica+1);
            Console.WriteLine();
            Console.Write(" Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine(" Apellidos: ");
            Console.Write("   Primer apellido: ");
            apellido1 = Console.ReadLine();
            Console.Write("   Segundo apellido: ");
            apellido2 = Console.ReadLine();

            Console.Write(" Sexo: ");
            sexo = char.Parse(Console.ReadLine());

            Console.Write(" Dirección: ");
            direccion = Console.ReadLine();

            Console.Write(" Fecha de nacimiento: ");
            fecha_nacimiento = Console.ReadLine();

            Console.Write(" Teléfono: ");
            telefono = Console.ReadLine();

            Console.Write(" Médico asignado: ");
            medico = Console.ReadLine();
			
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n   Paciente iniciado correctamente.");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadKey();
            
            paciente[posicionPaciente].setPaciente(dni, nombre, apellido1, apellido2, fecha_nacimiento, 
                                                   sexo, direccion, telefono, medico);

            N_Pacientes++;
        }


        /// <summary>
        /// Busca el índice del array paciente cuyo dni exista.
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>Devuelve la posición del array</returns>
    
        public int IndiceArrayPaciente(string dni)
        {
            for (int i = 0; i <= N_Pacientes; i++)
            {
                if (paciente[i].ExisteDNI(dni) == true)
                    return i;
            }

            return -1;
        }


        /// <summary>
        /// Cambia el médico de un paciente
        /// </summary>
        /// <param name="indiceArray">Índice de la lista paciente.</param>
        public void ModificarMedico(int indiceArray)
        {
        	string medico;
        	
            Console.Clear();
            Console.WriteLine("   ---  Modificar Médico  ---");
            Console.Write("\n   Medico: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(paciente[indiceArray].getMedico());
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n   Nuevo médico: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            medico = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.Write("\n\n  El médico ha sido modificado satisfactoriamente...");
            Console.ReadKey();
            
            paciente[indiceArray].CambiarMedico(medico);
        }


        /// <summary>
        /// Modifica el tratamiento de un paciente
        /// </summary>
        /// <param name="indiceArray">Índice de la lista paciente.</param>
        public void ModificarTratamiento(int indiceArray)
        {
            string tratamiento;

            Console.Clear();
            Console.Write("  Tratamientos del paciente: \n");
            paciente[indiceArray].getTratamiento();

            Console.WriteLine();
            Console.WriteLine("  Añadir tratamiento: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("   -- Tratamiento: ");
            tratamiento = Console.ReadLine();
            Console.Write("  || Fecha: {0}", DateTime.Now.Date);

            paciente[indiceArray].AñadirTratamiento(DateTime.Now , tratamiento);
        }

		
        /// <summary>
        /// Muestra un tratamiento buscado de un paciente.
        /// </summary>
        /// <param name="posicionPaciente">Posicion del paciente a buscar 
        /// 							   el tratamiento</param>
        public void EscribirTratamientoPorDefinicion(int posicionPaciente)
        {
        	// Buscamos por la matriz de tratamientos si algún tratamiento coincide con el escrito.
        	// El tamaño máximo será siempre de N_TRATAMIENTOS.
        	string tratamiento;
        	
        	Console.Clear();
        	Console.Write("\n  Tratamiento a buscar: ");
        	tratamiento = Console.ReadLine();
        	tratamiento = tratamiento.ToLower();
        	if(paciente[posicionPaciente].getTratamientoPorDefinicion(tratamiento) == true)
        	{
        		Console.WriteLine("\n Tratamiento buscado: ");
        		Console.ForegroundColor = ConsoleColor.DarkYellow;
        		Console.Write("  " + 
        			paciente[posicionPaciente].MostrarTratamientoPorDefinicion
        		              (posicionPaciente));
        		Console.Write("  ||  Fecha: " + 
        		              paciente[posicionPaciente].MostrarTratamientoPorFecha
        		              (posicionPaciente));
        		Console.ForegroundColor = ConsoleColor.Black;
        	}
        	
        	else
        	{
        		Console.Write("  Tratamiento no encontrado...");
        	}
        	
        	Console.ReadKey();
        }
        
        
        /// <summary>
        /// Método que permite cambiar el campo estad de un paciente.
        /// </summary>
        /// <param name="indiceArray">Posición del paciente en el array</param>
        public void ModificarEstadoPaciente(int indiceArray)
        {
        	int op;
        	       	
            do
            {
            	Console.Clear();
        		Console.Write("\n  Estado actual del paciente: ");
        		Console.ForegroundColor = ConsoleColor.DarkRed;
        		Console.Write(paciente[indiceArray].getEstadoPaciente());
        		Console.ForegroundColor = ConsoleColor.Black;
        		Console.Write("\n\n");
            	Console.Write("\n   1. Dar alta");
            	Console.Write("\n   2. Ingresar");
            	Console.Write("\n\n    Opción: ");
            	op = int.Parse(Console.ReadLine());
            	
            	switch(op)
            	{
	            	case 1:
            			paciente[indiceArray].DarAltaPaciente();
            			Console.Write("\n\n  El paciente ha sido dado de alta...");
            			Console.ReadKey();
	            		break;
	            	case 2:
	            		paciente[indiceArray].DarBajaPaciente();
	            		Console.Write("\n\n  El paciente ha sido ingresado...");
            			Console.ReadKey();
	            		break;
	            	default: break;
            	}
            	
            }while (op<1 || op>2);
        }

        
        public void VerPacientesConsultas()
        {
        	bool hayPacientes = false;
        	
        	Console.Clear();
        	for(int i=0;i<N_Pacientes;i++ )
        	{
        		if((paciente[i].getMedico() != "") && (paciente[i].getEstadoPaciente() == "Alta"))
        		{
        			Console.ForegroundColor = ConsoleColor.DarkCyan;
        			Console.WriteLine(" ------------------------------------------------------------------------------");
        			Console.ForegroundColor = ConsoleColor.Black;
        			Console.WriteLine(" {0}) Nombre: {1} {2} || DNI: {3} || Médico: {4}",
        			                  i+1, paciente[i].getNombre(), paciente[i].getApellido1(),
        			                  paciente[i].getDNI(), paciente[i].getMedico());
        			hayPacientes = true;
        		}
        		
        	}
       		
        	Console.ForegroundColor = ConsoleColor.DarkCyan;
        	Console.WriteLine(" ------------------------------------------------------------------------------");
        	Console.ForegroundColor = ConsoleColor.Black;
        	if(hayPacientes == false)
        	{
        		Console.Write(" No hay pacientes en consultas externas...");
        	}
        	
        	Console.ReadKey();
        }
        
        
        public void BuscarPacientePorDNI()
        {
        	string dni;
        	bool hayPaciente = false;
        	
            Console.Write("\n\n   Introduzca el dni del paciente(-1 para salir): ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            dni = Console.ReadLine();
            
            if(dni == "-1") { }
            
            else
            {
	            Console.Clear();
	        	for(int i=0; i<N_Pacientes; i++)
	        	{
	        		if(paciente[i].getDNI() == dni)
	        		{
	        			paciente[i].getPaciente(i);
	        			Console.Write("\n Pulse una tecla para continuar...");
	        			hayPaciente = true;
	        		}
	        	}
	        	
	        	if(hayPaciente == false)
	        	{
	        		Console.WriteLine("\n No hay pacientes con ese dni...");
	        	}
	        	
	        	Console.ReadKey();
            }
        }
        
        
        // --- CAMAS ---
        
        public void MostrarCamas(string dni)
        {
        	Console.Clear();
        	
        	Console.WriteLine("-------------------------------------------------");
        	Console.WriteLine("--------------------- CAMAS ---------------------");
        	Console.WriteLine("-------------------------------------------------\n");
        	
        	for (int i = 0; i < Constante.N_HABITACION; i++) 
        	{
        		Console.WriteLine(" ---------- HABITACIÓN {0} ----------", i);
        		
        		for (int j = 0; j < Constante.N_CAMA; j++)
        		{
        			// Comprueba el estado de la cama, y cambia el color según estado,
        			// Y lo muestra.
        			
        			Console.Write("   Cama {0} :", j);
        			if(cama[i,j].EstadoCama() == false)
        			{
	        			Console.ForegroundColor = ConsoleColor.DarkGreen;
	        			Console.WriteLine(cama[i,j].MostrarEstadoCama());
	        			Console.ForegroundColor = ConsoleColor.Black;   		
        			}
        			
        			else
        			{
        				Console.ForegroundColor = ConsoleColor.DarkRed;
	        			Console.WriteLine(cama[i,j].MostrarEstadoCama());
	        			Console.ForegroundColor = ConsoleColor.Black;   
        			}
        		}
        		
        		Console.WriteLine();
        	}

        	Console.WriteLine(" ------------------------------------");
        	
        	AsignarCamaPaciente(dni);
        	
        }
        
        
        /// <summary>
        /// Este método crea una rutina para asignar una habitación y cama a un paciente.
        /// Sólo válido si el campo dni existe, comprobado anteriormente.
        /// </summary>
        public void AsignarCamaPaciente(string dni)
        {
        	string op;
        	int camaAsignada, habitacionAsignada;
        	bool camaOcupada = false; // variable que indica si una cama está ocupada ya.
        	bool esFallo = false;
        	int posPaciente = IndiceArrayPaciente(dni);
        	Console.WriteLine();
        	do // Preguntar si se quiere asignar una cama a un paciente
        	{
        		Console.Write(" ¿Asignar cama a un paciente? (S/N): ");
        		op = Console.ReadLine();	
        	} while (op != "s" && op != "S" && op != "n" && op != "N");
        	
        	
        	if(op == "s" || op=="S") // Se va a asignar una cama
        	{
    			
				// Este bucle se repetirá si se intenta asignar una cama a un 
				// paciente que ya está ocupada.
				do
				{
    				Console.Clear();
    				camaOcupada = false;
    				
    				paciente[posPaciente].getPaciente(posPaciente);
    				
    				#region AsignaValorCama
    				// Asigna el valor de una cama. Si no está entre el rango, se
    				// repite la rutina
    				do
    				{
    					// Comprobamos si el paciente ya tenía una cama. Primero, dejamos la 
    					// cama en estado "libre".
    					if(paciente[posPaciente].PacienteOcupandoCama() == true)
    					{
    						cama[paciente[posPaciente].getHabitacion(), 
    						     paciente[posPaciente].getCama()].CamaLibre();
    					}
    					
    					
    					// En esta rutina, hemos liberado la cama que estaba usando. Ahora, 
    					// asignaremos una nueva al paciente.
    					
    					// Toma por teclado el valor de una cama, y comprueba si es válido.
    					if (esFallo == true)
    					{
    						Console.WriteLine("**ERROR** La cama debe estar entre 0 y {0}"
    						                  , Constante.N_CAMA-1);
    						esFallo = false;
    					}
    					esFallo = true;
        				Console.Write(" Cama (0 - {0}): ", Constante.N_CAMA-1);     				
        				camaAsignada = int.Parse(Console.ReadLine());
        				if(camaAsignada >= 0 && camaAsignada < Constante.N_CAMA) 
        				{
        					esFallo = false;
        				}
        				Console.WriteLine();
    				} while(esFallo == true);
    				#endregion
    				
    				esFallo = false;
    				
    				#region AsignaValorHabitacion
    				// Igualmente para la habitación.
    				do
    				{
    					if (esFallo == true)
    					{
    						Console.WriteLine("**ERROR** La habitación debe estar entre" +
    						                  "0 y {0}", Constante.N_HABITACION-1 );
    						esFallo = false;
    					}
    					esFallo = true;
        				Console.Write(" Habitación (0 - {0}): ", Constante.N_HABITACION-1);
        				habitacionAsignada = int.Parse(Console.ReadLine());		        				
        				if(habitacionAsignada >= 0 && habitacionAsignada < Constante.N_HABITACION)
        				{
        					esFallo = false;
        				}
        				Console.WriteLine();
    				} while (esFallo == true);
					#endregion
    				
					if(cama[habitacionAsignada, camaAsignada].EstadoCama() == true)
    				{
    					camaOcupada = true;
    					Console.Write(" Esa cama ya está ocupada...");
    					Console.ReadKey();
    				}
    				
				} while(camaOcupada == true);
				
				
				// Aquí asignaremos el valor de la cama y la habitación al objeto paciente.
				
				paciente[posPaciente].AsignarCama(camaAsignada);
				paciente[posPaciente].AsignarHabitacion(habitacionAsignada);
				
				// Por último, dentro del array cama[], diremos que esa cama está en 
				// estado ocupada.
				cama[habitacionAsignada, camaAsignada].CamaOcupada();
				
				Console.Write(" Cama asignada exitosamente...");
				Console.ReadKey();
	
        	} // END if(op == "s" || op=="S")
        }
        
    }
}
