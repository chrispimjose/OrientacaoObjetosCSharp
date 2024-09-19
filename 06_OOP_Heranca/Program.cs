namespace _06_OOP_Heranca
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Criando um objeto Cachorro
			Cachorro cachorro = new Cachorro("Doky");
			cachorro.Comer(); // Usando método herdado da classe Animal
			cachorro.EmitirSom(); // Usando método sobrescrito na classe Cachorro

			// Criando um objeto Gato
			Gato gato = new Gato("Felix");
			gato.Comer(); // Usando método herdado da classe Animal
			gato.EmitirSom(); // Usando método sobrescrito na classe Gato

		}
	}
}
