using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlowSense.Models
{
	public class StaffInfo
	{
		public string Name { get; set; }
		public string AssignedFarm { get; set; }
		public string Task { get; set; }
		public DateTime Deadline { get; set; }
	}
}
