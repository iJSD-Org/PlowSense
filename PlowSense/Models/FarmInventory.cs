using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlowSense.Models
{
	class FarmInventory
	{
		public string FarmRep { get; set; }
		public string Crop { get; set; }
		public int TimeInStorage { get; set; }
		public int Amount { get; set; }
	}
}
