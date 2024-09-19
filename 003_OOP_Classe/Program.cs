namespace _003_OOP_Classe
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Calcule calcule = new Calcule();

			int meuNum1 = calcule.meuMetodo(8, 5);
			double meuNum2 = calcule.meuMetodo(4.3, 6.26);
			
			//Aplicando o Overloading
			Console.WriteLine("inteiro: " + meuNum1);
			Console.WriteLine("double: " + meuNum2);
		}
	}
}
