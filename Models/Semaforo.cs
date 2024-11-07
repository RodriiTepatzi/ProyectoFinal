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
		public SemaforoStatus SemaforoStatus { get; set; }
		public string[] StateValues { get; set; }
		public string GreenIdentifier { get; set; }
		public string YellowIdentifier { get; set; }
		public string RedIdentifier { get; set; }
	}
}
