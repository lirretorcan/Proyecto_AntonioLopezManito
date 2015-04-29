using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion___Practica_2._1___Gestion_hospital
{
    public struct Tratamiento
    {
        public int numero_tratamientos;
        public string[] arrayTratamientos;
        public DateTime[] arrayFechaHora;

    }




    class Paciente
    {
        
        Tratamiento tratamiento;

        string      dni,
                    nombre,
                    apellido1, apellido2,
                    fecha_nacimiento,
                    direccion,
                    telefono;
        public string medico_asignado;
        char sexo;

        string estado_paciente = "Alta";

        int N_Habitacion, N_Cama, historia_clinica;

        //#####################################################
        //                       METODOS
        //#####################################################


        public Paciente()
        { 
            dni = "DNI";
            nombre = "";
            apellido1 = "";
            apellido2 = "";
            fecha_nacimiento = "";
            direccion = "";
            telefono = "";
            medico_asignado = "";
            sexo = 'V';
            estado_paciente = "Alta";

            N_Habitacion = -1;
            N_Cama = -1;

            tratamiento.arrayTratamientos = new string[Constante.N_TRATAMIENTOS];
            tratamiento.arrayFechaHora = new DateTime[Constante.N_TRATAMIENTOS];
        }

        
        /// <summary>
        /// Muestra los campos de un paciente.
        /// </summary>
        public void getPaciente(int NumPaciente)
        {
        	Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("           ---   DATOS DEL PACIENTE {0}  ---", NumPaciente+1);
            Console.WriteLine("  |");
            
            Console.SetCursorPosition(50, 1);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            
            Console.Write("  |   DNI: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(dni);
            
            Console.SetCursorPosition(50, 2);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            
            
            Console.Write("  |   Nombre: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(nombre);
            
            Console.SetCursorPosition(50, 3);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  |   Apellidos: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("{0} ", apellido1);
            Console.Write(apellido2);
            
            Console.SetCursorPosition(50, 4);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  |   Fecha de nacimiento: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(fecha_nacimiento);
            
            Console.SetCursorPosition(50, 5);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  |   Sexo: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(sexo);
            
            Console.SetCursorPosition(50, 6);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  |   Direccion: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(direccion);
            
            Console.SetCursorPosition(50, 7);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  |   Telefono: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(telefono);
            
            Console.SetCursorPosition(50, 8);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            
            Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("  |   Médico asignado: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(medico_asignado);
            
            Console.SetCursorPosition(50, 9);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  |   Estado del paciente: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(estado_paciente);
            
            Console.SetCursorPosition(50, 10);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  |   Cama asignada: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if(N_Cama == -1 ) Console.Write("Ninguna");
            else Console.Write(N_Cama);
            
            Console.SetCursorPosition(50, 11);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  |   Habitación asignada: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if(N_Habitacion == -1) Console.Write("Ninguna");
            else Console.Write(N_Habitacion);
            
            Console.SetCursorPosition(50, 12);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("|");
            
            Console.WriteLine("  -------------------------------------------------");
        }

        
        
        
        public void setPaciente(string dni, string nombre, string apellido1, string apellido2,
                     string fecha_nacimiento,char sexo, string direccion, string telefono, string medico_asignado)
        {
        	this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.fecha_nacimiento = fecha_nacimiento;
            this.sexo = sexo;
            this.direccion = direccion;
            this.telefono = telefono;
            this.medico_asignado = medico_asignado;
        }


        public bool EstaLibre()
        {
            return dni == "DNI";
        }

        
        
        /// <summary>
        /// Los métodos get+Campo, funcionará como conexión entre otras clases y 
        /// los campos privados de esta clase.
        /// Cada campo devuelto, será de su tipo.
        /// </summary>
        
        public string getDNI()
        {
            return this.dni;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getApellido1()
        {
            return this.apellido1;
        }

        public string getApellido2()
        {
            return this.apellido2;
        }

        public string getFechaNacimiento()
        {
            return this.fecha_nacimiento;
        }

        public char   getSexo()
        {
            return this.sexo;
        }

        public string getDireccion()
        {
            return this.direccion;
        }

        public string getTelefono()
        {
            return this.telefono;
        }


        
		/// <summary>
		/// Método que simplemente devuelve el campo estado_paciente de un 
		/// objeto paciente.
		/// </summary>
        public string getEstadoPaciente()
        {
        	return estado_paciente;
        }

        /// <summary>
        /// Asigna el valor "alta" al campo estado_paciente.
        /// </summary>

        public void DarAltaPaciente()
        {
            this.estado_paciente = "Alta";
        }

        /// <summary>
        /// Asigna el valor "ingresado" al campo estado_paciente.
        /// </summary>
        /// 
        public void DarBajaPaciente()
        {
            this.estado_paciente = "Ingresado";
        }


        
        
        
        /// <summary>
        /// Muestra el paciente y sus tratamientos, con fecha.
        /// </summary>
        public void getTratamiento()
        {
            if (tratamiento.numero_tratamientos > 0)
            {
                for (int i = tratamiento.numero_tratamientos; i > 0; i--)
                {
                	Console.Write("  {0}) Tratamiento : " ,i);
                	
                	Console.ForegroundColor = ConsoleColor.DarkGreen;
                	Console.Write(tratamiento.arrayTratamientos[i-1]);
                	Console.ForegroundColor = ConsoleColor.Black;
                	              						
                    Console.Write("      Fecha: {0}", tratamiento.arrayFechaHora[i-1]);
                    Console.WriteLine();
                }
            }

            else
            {
            	Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("   No hay tratamientos");
                Console.Write("         ");
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
        
        
        /// <summary>
        /// Método que sirve para buscar un tratamiento según su definición
        /// </summary>
        /// <param name="tratamiento_buscar"></param>
        /// <returns>Devuelve verdadero si encuentra un tratamiento</returns>
        
        public bool getTratamientoPorDefinicion(string tratamiento_buscar)
        {
        	tratamiento_buscar = tratamiento_buscar.ToLower();
        	for(int i=0; i<tratamiento.numero_tratamientos; i++)
        	{
        		if(tratamiento_buscar == tratamiento.arrayTratamientos[i])
        			return true;
        	}
        	
        	return false;
        }
        
        
        public string MostrarTratamientoPorDefinicion(int posTratamiento)
        {
        	return tratamiento.arrayTratamientos[posTratamiento];
        }
        
        
        public DateTime MostrarTratamientoPorFecha(int posTratamiento)
        {
        	return tratamiento.arrayFechaHora[posTratamiento];
        }
        
        
        public int getPosicionTratamientoPorDefinicion(string tratamient)
        {
        	for(int i=0; i < getNumeroTratamientos() ; i++)
        	{
        		if(tratamient == tratamiento.arrayTratamientos[i])
        		{
        			return i;
        		}
        	}
        	
        	return -1;
        }
        
        /// <summary>
        /// Método que calcula el numero de tratamientos de un paciente
        /// </summary>
        /// <returns>Devuelve el numero de tratamientos</returns>
        
        public int getNumeroTratamientos()
        {
        	return tratamiento.numero_tratamientos;
        }
		
        
        /// <summary>
        /// Añade un tratamiento nuevo al paciente.
        /// </summary>
        /// <param name="fecha">Fecha del tratamiento</param>
        /// <param name="tratamient">Definicion del tratamiento</param>
        public void AñadirTratamiento(DateTime fecha,string tratamient)
        {
        	tratamient = tratamient.ToLower();
            tratamiento.arrayFechaHora[tratamiento.numero_tratamientos] = fecha;
            tratamiento.arrayTratamientos[tratamiento.numero_tratamientos] = tratamient;
            tratamiento.numero_tratamientos++;
        }


        

        public string getMedico()
        {
            return this.medico_asignado;
        }

        public void CambiarMedico(string nuevoMedico)
        {
            this.medico_asignado = nuevoMedico;
        }

        public bool ExisteDNI(string dni)
            {
                if (this.dni == dni) return true;
                else return false;
            }

        public int HistoriaClinica(int historia)
        {
            return this.historia_clinica = historia;
        }
        
        /// <summary>
        /// Método que nos indica si el paciente está ocupando una cama o no.
        /// </summary>
        /// <returns>Devuelve TRUE si el paciente ocupa una cama, False si no 
        /// tiene ninguna asignada.</returns>
        public bool PacienteOcupandoCama()
        {
        	if(this.N_Cama != -1) return true;
        	else return false;
        		
        }
        
        public int getCama()
        {
        	return N_Cama;
        }
        
        public int getHabitacion()
        {
        	return N_Habitacion;
        }
        
        public void AsignarCama(int cama)
        {
        	this.N_Cama = cama;
        }
        
        public void AsignarHabitacion(int habitacion)
        {
        	this.N_Habitacion = habitacion;
        }
    }

}

