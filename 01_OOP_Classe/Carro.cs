
namespace _01_OOP_Classe
{
	class Carro
	{
		public string Marca = "Hyundai";
		public string Modelo;
		public string Cor;
		public bool LuzesInternas = false;

		public void AbrirPorta()
		{
			LuzesInternas=true;			
		}

		public void FecharPorta()
		{
			LuzesInternas=false;			
		}

		public string AcenderFarois(int Lux)
		{
			string retorno;
			switch (Lux)
			{
				case 10:
					retorno = "Farois Altos";
					break;
				case 50:
					retorno = "Farois Baixos";
					break;

				case 100:
					retorno = "Farois Desligados";
					break;
				default:
					retorno = "Carro Desligado";
					break;
			}
			return retorno;
		}		
	}
}		