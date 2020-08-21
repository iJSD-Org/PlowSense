namespace PlowSense.Models
{
	public class FarmInfo	
	{
		public string Farm { get; set; }
		public string Location { get; set; }
		public string FarmRep { get; set; }
		public System.Collections.Generic.List<CropInfo> Crops {get; set;}
	}
}
