using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winSemaforos.Models
{
	internal class Semaforo
	{
		public int Id { get; set; }
		public int SemaforoStatus { get; set; }
		public string[] Identifiers { get; set; }
		public bool Prendido { get; set; }
		public bool Actual { get; set; }
		public bool Parpadeando { get; set; }
	}
}
