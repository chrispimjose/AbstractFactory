using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	internal class EscapamentoCombustao : IEscapamento
	{
		public void Tipo()
		{
			Console.WriteLine("Escapamento padrão com catalisador.");
		}
	}
}
