namespace _08_OOP_Intef
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Criando um objeto Carro
			IVeiculo carro = new Carro("Toyota Corolla");
			carro.Mover();
			carro.Parar();

			// Criando um objeto Bicicleta
			IVeiculo bicicleta = new Bicicleta("BMX");
			bicicleta.Mover();
			bicicleta.Parar();
		}
	}
}
