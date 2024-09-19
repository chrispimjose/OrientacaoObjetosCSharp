namespace _007_OOP_Abstracao
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Criando um objeto Carro
			Carro carro = new Carro("Toyota Corolla", 2022);
			carro.ExibirInformacoes();
			carro.Mover(); // Implementação específica do carro

			// Criando um objeto Bicicleta
			Bicicleta bicicleta = new Bicicleta("BMX", 2021);
			bicicleta.ExibirInformacoes();
			bicicleta.Mover(); // Implementação específica da bicicleta

			// Criando um objeto Aviao
			Aviao aviao = new Aviao("Embraer E2 195", 2024);
			aviao.ExibirInformacoes();
			aviao.Mover(); // Implementação específica do aviao

		}
	}
}
