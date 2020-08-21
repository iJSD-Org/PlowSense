using Ganss.Excel;

namespace PlowSense.Models
{
	public class CropInfo
	{
		public string Farm { get; set; }
		public string Crop { get; set; }
		[Column("Shelf Life")]
		public string ShelfLife { get; set; }
	}
}
