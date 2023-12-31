using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CoreWebApiJewelleryProject.Model
{
	public class Kolyeler
	{
		[Key]
		public int KolyeId { get; set; }
		public string KolyeAdi { get; set; }
		public string KMadeni { get; set; }
		public string KTaslari { get; set; }
		public decimal Kucreti { get; set; }
		public ICollection<Setler> Setlers { get; set; }
	}
}
