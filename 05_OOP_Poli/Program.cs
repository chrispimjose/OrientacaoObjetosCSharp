namespace _05_OOP_Poli
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Pessoa pessoa = new Pessoa();

			// Atribuindo valores válidos usando as propriedades
			pessoa.Nome = "Jose";
			pessoa.Sobrenome = "Padilha";
			pessoa.Idade = 56;
			pessoa.ExibirInformacoes();

			// Tentativa de atribuir um valor inválido
			pessoa.Nome = "";
			pessoa.Sobrenome = "";
			pessoa.Idade = -5;
		}
	}
}
