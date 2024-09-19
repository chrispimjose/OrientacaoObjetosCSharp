using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_Classe
{
	public class Pessoa
	{
		public string meuNome;
		public string sobreNome;

		// Construtor
		public Pessoa(string nome, string segundoNome)
		{
			meuNome = nome;
			sobreNome = segundoNome;
		}
	}
}
