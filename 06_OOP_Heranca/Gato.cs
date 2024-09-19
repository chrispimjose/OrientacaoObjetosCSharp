using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Heranca
{
	internal class Gato : Animal
	{
		public Gato(string nome) : base(nome)
		{
		}

		// Sobrescrevendo o método EmitirSom
		public override void EmitirSom()
		{
			Console.WriteLine($"{Nome} está miando.");
		}
	}
}
