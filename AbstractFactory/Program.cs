namespace AbstractFactory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Qual tipo de veículo deseja montar? (elétrico/combustão): ");
			string tipo = Console.ReadLine().ToLower();

			IFabricaVeiculos fabrica;

			if (tipo == "elétrico" || tipo == "eletrico")
			{
				fabrica = new FabricaEletrica();
			}
			else if (tipo == "combustão" || tipo == "combustao")
			{
				fabrica = new FabricaCombustao();
			}
			else
			{
				Console.WriteLine("Tipo desconhecido.");
				return;
			}

			MontarVeiculo(fabrica);
		}
		
		static void MontarVeiculo(IFabricaVeiculos fabrica)
			{
				IMotor motor = fabrica.CriarMotor();
				IBateria bateria = fabrica.CriarBateria();
				IEscapamento escapamento = fabrica.CriarEscapamento();

				motor.Especificacao();
				bateria.Capacidade();
				escapamento.Tipo();
		}

	}
}

