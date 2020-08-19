using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlowSense.Models
{
	public class TransactionHistory
	{
		public string FarmRep { get; set; }
		public string Crop { get; set; }
		public int AmountSold { get; set; }
	}
}
