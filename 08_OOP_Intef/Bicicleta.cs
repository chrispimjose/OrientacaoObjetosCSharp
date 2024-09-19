using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OOP_Intef
{
	internal class Bicicleta : IVeiculo
	{
		public string Modelo { get; set; }
		public Bicicleta(string modelo)
		{
			Modelo = modelo;
		}

		// Implementação do método Mover
		public void Mover()
		{
			Console.WriteLine($"{Modelo} está pedalando.");
		}

		// Implementação do método Parar
		public void Parar()
		{
			Console.WriteLine($"{Modelo} está parando.");
		}
	}
}
