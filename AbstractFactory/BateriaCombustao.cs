using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	internal class BateriaCombustao : IBateria
	{
		public void Capacidade()
		{
			Console.WriteLine("Bateria de 12V para ignição.");
		}

	}
}
