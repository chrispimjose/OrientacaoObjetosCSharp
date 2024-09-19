using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_OOP_Abstracao
{
	// Classe abstrata
	public abstract class Veiculo
	{
		public string Modelo { get; set; }
		public int Ano { get; set; }

		// Construtor da classe abstrata
		public Veiculo(string modelo, int ano)
		{
			Modelo = modelo;
			Ano = ano;
		}

		// Método abstrato (não possui implementação)
		public abstract void Mover();

		// Método comum que será herdado pelas subclasses
		public void ExibirInformacoes()
		{
			Console.WriteLine($"Veículo: {Modelo}, Ano: {Ano}");
		}
	}
}
