using Ganss.Excel;

namespace PlowSense.Models
{
	public class FarmInfo
	{
		public string Farm { get; set; }
		public string Location { get; set; }
		[Column("Farm Representative")]
		public string FarmRep { get; set; }
		[Ignore]
		public System.Collections.Generic.List<CropInfo> Crops { get; set; }
	}
}
