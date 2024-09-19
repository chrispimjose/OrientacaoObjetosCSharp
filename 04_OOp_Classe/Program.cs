namespace _04_OOp_Classe
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Usando o construtor sem parâmetros
			Pessoa pessoa1 = new Pessoa();
			pessoa1.ExibirInformacoes();

			// Usando o construtor com dois parâmetros
			Pessoa pessoa2 = new Pessoa("Jose", "Padilha");
			pessoa2.ExibirInformacoes();

			// Usando o construtor com três parâmetros
			Pessoa pessoa3 = new Pessoa("Ana", "Silva", 30);
			pessoa3.ExibirInformacoes();
		}
	}
}
