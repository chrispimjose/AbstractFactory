using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory
{
	internal class MotorEletrico : IMotor
	{
		public void Especificacao()
		{
			Console.WriteLine("Motor elétrico de alta eficiência.");
		}


	}
}
