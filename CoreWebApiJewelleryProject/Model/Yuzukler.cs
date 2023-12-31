using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CoreWebApiJewelleryProject.Model
{
	public class Yuzukler
	{
		[Key]
		public int YuzukId { get; set; }
		public string YuzukAdi { get; set; }
		public string YMadeni { get; set; }
		public string YTaslari { get; set; }
		public decimal Yucreti { get; set; }
		public ICollection<Setler> Setlers { get; set; }
	}
}
