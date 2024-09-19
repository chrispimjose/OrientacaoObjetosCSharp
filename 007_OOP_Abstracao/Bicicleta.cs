using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_OOP_Abstracao
{
	// Classe derivada de Veiculo
	public class Bicicleta : Veiculo
	{
		public Bicicleta(string modelo, int ano) : base(modelo, ano)
		{
		}

		// Implementação do método abstrato
		public override void Mover()
		{
			Console.WriteLine($"{Modelo} está pedalando.");
		}
	}
}
