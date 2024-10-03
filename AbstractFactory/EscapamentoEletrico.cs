using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	internal class EscapamentoEletrico : IEscapamento
	{
		public void Tipo()
		{
			Console.WriteLine("Veículos elétricos não possuem escapamento.");
		}
	}
}
