using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Heranca
{
	internal class Cachorro : Animal
	{
		/*
		 * :base(nome): Indica que o construtor da classe base, 
		 * que no caso é a classe Animal, 
		 * deve ser chamado e o valor do parâmetro nome deve 
		 * ser passado para o construtor da classe Animal.		 * 
		 */
		public Cachorro(string nome) : base(nome)
		{
		}

		// Sobrescrevendo o método EmitirSom
		public override void EmitirSom()
		{
			Console.WriteLine($"{Nome} está latindo.");
		}

	}
}
