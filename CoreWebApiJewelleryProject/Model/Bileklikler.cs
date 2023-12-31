using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebApiJewelleryProject.Model
{
	public class Bileklikler
	{
		[Key]
		public int BileklikId { get; set; }
		public string BileklikAdi { get; set; }
		public string BMadeni {  get; set; }
		public string BTaslari { get; set; }
		public decimal Bucreti { get; set; }
		public ICollection<Setler> Setlers { get; set; }

	}
}
