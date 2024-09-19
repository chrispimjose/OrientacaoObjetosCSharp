using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOp_Classe
{
	public class Pessoa
	{
		string meuNome;
		string sobreNome;
		int idade;

		// Construtor sem parâmetros
		public Pessoa()
		{
			meuNome = "Desconhecido";
			sobreNome = "Desconhecido";
			idade = 0;
		}

		// Construtor com dois parâmetros
		public Pessoa(string nome, string segundoNome)
		{
			meuNome = nome;
			sobreNome = segundoNome;
			idade = 0; // Definindo um valor padrão para idade
		}

		// Construtor com três parâmetros
		public Pessoa(string nome, string segundoNome, int idadePessoa)
		{
			meuNome = nome;
			sobreNome = segundoNome;
			idade = idadePessoa;
		}

		public void ExibirInformacoes()
		{
			Console.WriteLine($"Nome: {meuNome} {sobreNome}, Idade: {idade}");
		}
	}
}
