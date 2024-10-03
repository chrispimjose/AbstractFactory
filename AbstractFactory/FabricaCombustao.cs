using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	internal class FabricaCombustao : IFabricaVeiculos
	{
		public IMotor CriarMotor()
		{
			return new MotorCombustao();
		}

		public IBateria CriarBateria()
		{
			return new BateriaCombustao();
		}

		public IEscapamento CriarEscapamento()
		{
			return new EscapamentoCombustao();
		}

	}
}
