using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winSemaforos.Models;

namespace winSemaforos
{
	internal class Prueba
	{
		public List<Semaforo> semaforos =
	new List<Semaforo>{
				new Semaforo
				{
					Id = 0,
					SemaforoStatus = 3,
					Identifiers = new string[]{ "1", "2", "3", "a", "b", "c" },
					Actual = false,
					Parpadeando = false,
				},
				new Semaforo
				{
					Id = 1,
					SemaforoStatus = 3,
					Identifiers = new string[] { "4", "5", "6", "d", "e", "f" },
					Actual = false,
					Parpadeando = false,

				},
				new Semaforo
				{
					Id = 2,
					SemaforoStatus = 3,
					Identifiers = new string[] { "7", "8", "9", "g", "h", "i" },
					Actual = false,
					Parpadeando = false,
				}
};
	}
}
