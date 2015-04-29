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

        string estado_paciente;

        int N_Habitacion, N_Cama;

        //#####################################################
        //                       METODOS
        //#####################################################


        public Paciente()
        { 
            dni = "";
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
        }

        /// <summary>
        /// Muestra los campos de un paciente.
        /// </summary>
        public void getPaciente()
        {
            Console.WriteLine("   ---   PACIENTE   ---\n");
            Console.WriteLine(" Nombre: {0}", nombre);
            Console.WriteLine(" Apellidos: {0} {1}", apellido1, apellido2);
            Console.WriteLine(" DNI: {0}", dni);
            Console.WriteLine(" Dirección: {0}", direccion);
            Console.WriteLine(" Fecha de nacimiento: {0}", fecha_nacimiento);
            Console.WriteLine(" Teléfono: {0}", telefono);
            Console.WriteLine(" Médico asignado: {0}", medico_asignado);
            Console.WriteLine(" Estado del paciente: {0}", estado_paciente);
        }

        public void setPaciente(string dni, string nombre, string apellido1, string apellido2,
                     string fecha_nacimiento,char sexo, string direccion, string telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.fecha_nacimiento = fecha_nacimiento;
            this.sexo = sexo;
            this.direccion = direccion;
            this.telefono = telefono;
        }


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

        public char getSexo()
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


        public string getEstadoPaciente()
        {
            return this.estado_paciente;
        }

        public void DarAltaPaciente()
        {
            this.estado_paciente = "Alta";
        }

        public void DarBajaPaciente()
        {
            this.estado_paciente = "Ingresado";
        }



        public void getTratamiento()
        {
            if (tratamiento.numero_tratamientos > 0)
            {
                for (int i = tratamiento.numero_tratamientos; i > 0; i++)
                {
                    Console.Write(tratamiento.arrayTratamientos[i]);
                    Console.Write("   ");
                    Console.Write(tratamiento.arrayFechaHora[i]);
                    Console.WriteLine();
                }
            }

            else
            {
                Console.WriteLine("No hay tratamientos");
            }
        }

        public void AñadirTratamiento(string[] tratamiento, DateTime[] fecha)
        {
            this.tratamiento.arrayFechaHora = fecha;
            this.tratamiento.arrayTratamientos = tratamiento;
            this.tratamiento.numero_tratamientos++;
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


    }

}

