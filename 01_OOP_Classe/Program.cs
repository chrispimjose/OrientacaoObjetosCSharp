namespace _01_OOP_Classe
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Intância o objeto
			Carro carro = new Carro();

			//Atribui valores as propriedades.
			carro.Marca = "Crysler";
			carro.Modelo = "Jeep Renegade";
			carro.Cor = "Preto";

			// Executa um loop enquanto sair for false
			bool sair = false;
			while (!sair)
			{
				// Limpa a tela do console
				Console.Clear();

				//Mostra os valores das propriedades
				Console.WriteLine("Marca: " + carro.Marca);
				Console.WriteLine("Modelo: " + carro.Modelo);
				Console.WriteLine("Cor: " + carro.Cor +"\n\n");

				// Exibe as opções de escolha para o usuário
				Console.WriteLine("Escolha uma opção:");
				Console.WriteLine("1. Abrir Porta");
				Console.WriteLine("2. Fechar Porta");
				Console.WriteLine("3. Para Carro desligado");
				Console.WriteLine("4. Para 100% de Luminosidade");
				Console.WriteLine("5. Para 50% de Luminosidade");
				Console.WriteLine("6. Para 10% de Luminosidade");
				Console.WriteLine("0. Sair");
				// Lê a opção escolhida pelo usuário
				string opcao = Console.ReadLine();
				// Realiza uma ação de acordo com a opção escolhida pelo usuário
				switch (opcao)
				{
					case "1":
						//Porta Fechada
						Console.WriteLine("Porta Fechada");
						Console.WriteLine("Luzes Internas: " + carro.LuzesInternas + "\n\n");
						break;
					case "2":
						//Chama o método AbrirPorta
						carro.AbrirPorta();
						Console.WriteLine("Porta Aberta");
						Console.WriteLine("Luzes Internas: " + carro.LuzesInternas + "\n\n");
						break;
					case "3":
						Console.WriteLine(carro.AcenderFarois(0)+"\n\n");
						break;
					case "4":
						Console.WriteLine(carro.AcenderFarois(100) + "\n\n");
						break;
					case "5":
						Console.WriteLine(carro.AcenderFarois(50) + "\n\n");
						break;
					case "6":
						Console.WriteLine(carro.AcenderFarois(10) + "\n\n");
						break;
					case "0":
						sair = true;
						break;
					default:
						Console.WriteLine("Opção inválida" + "\n\n");
						break;
				}
				opcao = Console.ReadLine();
			}
		}
	}
}
