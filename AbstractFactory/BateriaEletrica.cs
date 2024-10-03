using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	internal class BateriaEletrica : IBateria
	{
		public void Capacidade()
		{
			Console.WriteLine("Bateria com capacidade de 100 kWh.");
		}

	}
}
