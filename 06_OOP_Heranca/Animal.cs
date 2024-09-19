using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Heranca
{
	internal class Animal
	{
		public string Nome { get; set; }
		public Animal(string nome)
		{
			Nome = nome;
		}

		// Método da classe base
		public void Comer()
		{
			Console.WriteLine($"{Nome} está comendo.");
		}

		// Método que pode ser sobrescrito pelas subclasses
		public virtual void EmitirSom()
		{
			Console.WriteLine($"{Nome} está fazendo um som.");
		}
	}
}
