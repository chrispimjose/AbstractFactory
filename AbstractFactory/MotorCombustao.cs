using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	internal class MotorCombustao : IMotor
	{
		public void Especificacao()
		{
			Console.WriteLine("Motor Turbo a combustão de 1.6L.");
		}
	}
}
