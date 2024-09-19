using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_OOP_Intef
{
	// Implementação da interface em uma classe Carro
	internal class Carro : IVeiculo
	{
		public string Modelo { get; set; }
		public Carro(string modelo)
		{
			Modelo = modelo;
		}

		// Implementação do método Mover
		public void Mover()
		{
			Console.WriteLine($"{Modelo} está dirigindo.");
		}

		// Implementação do método Parar
		public void Parar()
		{
			Console.WriteLine($"{Modelo} está parando.");
		}

	}
}
