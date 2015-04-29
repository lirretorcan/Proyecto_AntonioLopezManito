using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion___Practica_2._1___Gestion_hospital
{
    class Hospital
    {
        int posicionArray;
        
        Paciente[] paciente = new Paciente[Constante.TAMAÑOARRAYPERSONAS];



        //#####################################################
        //                       METODOS
        //#####################################################


        public void InicializarPacientes()
        {
            for (int i = 0; i < paciente.Length; i++)
            {
                paciente[i] = new Paciente();
            }

            posicionArray = 0;
        }



        public void NuevoPaciente()
        {
            string nombre,
                   apellido1,
                   apellido2,
                   dni,
                   direccion,
                   fecha_nacimiento,
                   medico,
                   telefono;
            char sexo;

            Console.WriteLine("   ---   NUEVO PACIENTE   ---\n");
            Console.Write(" Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine(" Apellidos: ");
            Console.Write("   Primer apellido: ");
            apellido1 = Console.ReadLine();
            Console.Write("   Segundo apellido: ");
            apellido2 = Console.ReadLine();

            Console.Write(" DNI: ");
            dni = Console.ReadLine();

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

            Console.Write(" Estado del paciente: ");

            paciente[posicionArray].setPaciente(dni, nombre, apellido1, apellido2, fecha_nacimiento, sexo,
                                 direccion, telefono);

            posicionArray++;

        }
    }
}
