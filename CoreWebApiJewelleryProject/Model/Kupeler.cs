using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace CoreWebApiJewelleryProject.Model
{
	public class Kupeler
	{
		[Key]
		public int KupeId { get; set; }
		public string KupeAdi { get; set; }
		public string KupMadeni { get; set; }
		public string KupTaslari { get; set; }
		public decimal Kupucreti { get; set; }
		public ICollection<Setler> Setlers { get; set; }
	}
}
