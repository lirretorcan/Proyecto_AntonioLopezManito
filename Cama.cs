
using System;

namespace Programacion___Practica_2._1___Gestion_hospital
{
	public class Cama
	{
		
		bool estaOcupada;
		
		public Cama()
		{	
			estaOcupada = false;
		} // Constructor de la clase.
		
		public void CamaLibre()
		{
			estaOcupada = false;
		} // Dejar la cama libre
		
		public void CamaOcupada()
		{
			estaOcupada = true;
		} // Ocupar la cama
		
		public bool EstadoCama()
		{
			return estaOcupada;
		} // Devuelve el estado de la cama. True si ya está ocupada.
		
		public string MostrarEstadoCama()
		{
			if(estaOcupada == true) return "Ocupada";
			else return "Libre";
		}
		
	}
}
