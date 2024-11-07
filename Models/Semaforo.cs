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
		public string[] Identifiers { get; set; }
		public bool IsOn { get; set; }
		public bool IsCurrent { get; set; }
	}
}
