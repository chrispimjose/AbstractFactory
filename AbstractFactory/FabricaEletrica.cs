using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	internal class FabricaEletrica : IFabricaVeiculos
	{
		public IMotor CriarMotor()
		{
			return new MotorEletrico();
		}

		public IBateria CriarBateria()
		{
			return new BateriaEletrica();
		}

		public IEscapamento CriarEscapamento()
		{
			return new EscapamentoEletrico();
		}
	}
}
