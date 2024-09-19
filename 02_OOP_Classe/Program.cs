namespace _02_OOP_Classe
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string nome = "Jose";
			string sobreNome = "Padilha";

			Pessoa pessoa = new Pessoa(nome, sobreNome);
		
			Console.WriteLine("Meu nome é: " + pessoa.meuNome + " " + pessoa.sobreNome);
		}

	}
}
