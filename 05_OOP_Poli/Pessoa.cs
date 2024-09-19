
namespace _05_OOP_Poli
{
	internal class Pessoa
	{
		// Atributos privados
		private string nome;
		private string sobrenome;
		private int idade;

		// Propriedade para acessar e modificar o nome
		public string Nome
		{
			get { return nome; }
			set
			{
				/* string.IsNullOrEmpty(value)
				 * método estático da classe string que retorna true se a variável 
				 * value for nula ou contiver uma string vazia ("")
				 * O símbolo de exclamação (!) é o operador de negação lógica em C#. 
				 * Ele inverte o valor booleano retornado por string.IsNullOrEmpty(value)
				 */
				if (!string.IsNullOrEmpty(value))
				{
					nome = value;
				}
				else
				{
					Console.WriteLine("O nome não pode ser vazio.");
				}
			}
		}

		// Propriedade para acessar e modificar o sobrenome
		public string Sobrenome
		{
			get { return sobrenome; }
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					sobrenome = value;
				}
				else
				{
					Console.WriteLine("O sobrenome não pode ser vazio.");
				}
			}
		}

		// Propriedade para acessar e modificar a idade
		public int Idade
		{
			get { return idade; }
			set
			{
				if (value > 0)
				{
					idade = value;
				}
				else
				{
					Console.WriteLine("A idade deve ser um número positivo.");
				}
			}
		}

		// Método para exibir as informações da pessoa
		public void ExibirInformacoes()
		{
			Console.WriteLine($"Nome: {nome}, Idade: {idade}");
		}
	}
}
